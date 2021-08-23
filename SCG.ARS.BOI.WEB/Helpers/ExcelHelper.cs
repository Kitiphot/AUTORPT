using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using NLog;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using Quartz.Util;

namespace SCG.ARS.BOI.WEB.Helpers
{
	public static class ExcelHelper
	{
		static Logger logger = LogManager.GetCurrentClassLogger();
		public static DataTable GetDataTableFromExcel(string path, bool hasHeader = true)
		{
			using (var pck = new OfficeOpenXml.ExcelPackage())
			{
				using (var stream = File.OpenRead(path))
				{
					pck.Load(stream);
				}
				var ws = pck.Workbook.Worksheets[0];
				DataTable tbl = new DataTable(ws.Name);
				foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
				{
					tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
				}
				var startRow = hasHeader ? 2 : 1;
				for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
				{
					var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
					DataRow row = tbl.Rows.Add();
					foreach (var cell in wsRow)
					{
						if ((cell.Start.Column - 1) <= tbl.Columns.Count)
							row[cell.Start.Column - 1] = cell.Text;
					}
				}
				return tbl;
			}
		}

		public static List<DataTable> GetDataTablesFromExcel(string path, bool hasHeader = true)
		{
			var tables = new List<DataTable>();
			using (var pck = new OfficeOpenXml.ExcelPackage())
			{
				using (var stream = File.OpenRead(path))
				{
					pck.Load(stream);
				}

				for (int i = 0; i <= pck.Workbook.Worksheets.Count - 1; i++)
				{
					var ws = pck.Workbook.Worksheets[i];
					DataTable tbl = new DataTable(ws.Name);
					foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
					{
						tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
					}
					var startRow = hasHeader ? 2 : 1;
					for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
					{
						var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
						DataRow row = tbl.Rows.Add();
						foreach (var cell in wsRow)
						{
							if ((cell.Start.Column - 1) <= tbl.Columns.Count)
								row[cell.Start.Column - 1] = cell.Text;
						}
					}
					tables.Add(tbl);
				}
			}

			return tables;
		}

		public static Task<(bool, ExcelWorksheet)> AddExcelWorkSheet<T>(List<T> data, string sheetName, ref ExcelPackage excelPackage)
		{
			var isSuccess = false;
			ExcelWorksheet worksheet = null;
			try
			{
				//Do NOT include Col1
				var mi = typeof(T)
					.GetProperties()
					.Where(pi => pi.Name != "Col1")
					.Select(pi => (MemberInfo)pi)
					.ToArray();

				worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);
				worksheet.Cells.LoadFromCollection(
					data, true, TableStyles.None, BindingFlags.Public | BindingFlags.Instance, mi);

				isSuccess = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return Task.FromResult((isSuccess, worksheet));
		}

		public static Task<(bool, Stream, string)> GetExcelFromDataTable(DataTable data, string[] footers = null)
		{
			var status = false;
			Stream stream = null;
			var message = string.Empty;
			try {
				using var package = new ExcelPackage();

				ExcelWorksheet ws = package.Workbook.Worksheets.Add("Sheet1");

				ws.Cells["A1"].LoadFromDataTable(data, true);

				for (int i = 0; i < data.Columns.Count; i++) {
					var column = data.Columns[i];
					if (column.DataType == Type.GetType("System.DateTime"))
						using (ExcelRange col = ws.Cells[1, i + 1, data.Rows.Count + 1, i + 1]) {
							col.Style.Numberformat.Format = "dd/MM/yyyy hh:mm:ss";
							col.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
						}
				}

				int footerRow = data.Rows.Count + 2;

				if (footers == null) {
					footers = new string[] { };
				}
				for (int i = 0; i < footers.Length; i++) {
					string footer = footers[i];

					if (!string.IsNullOrEmpty(footer)) {
						if (footer.StartsWith("func.")) {
							string formula = footer.Substring(5).ToLower();
							string firstCell = GetCellName(2, i + 1);
							string lastCell = GetCellName(footerRow - 1, i + 1);

							ws.Cells[footerRow, i + 1].Formula = formula switch {
								"sum" => $"SUM({firstCell}:{lastCell})",
								"count" => $"COUNTA({firstCell}:{lastCell})",
								"countdistinct" => $"SUM(IF(FREQUENCY({firstCell}:{lastCell}, {firstCell}:{lastCell})>0,1))",
								_ => null
							};
						} else {
							ws.Cells[footerRow, i + 1].Value = footer;
						}
					}
				}

				stream = new MemoryStream(package.GetAsByteArray());
				status = true;
			} catch (Exception ex) {
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, ex.InnerException.Message);
					message = ex.InnerException.Message;
				} else {
					logger.Error(ex, ex.Message);
					message = ex.Message;
				}
			}

			return Task.FromResult((status, stream, message));
		}

		public static bool GetExcelFromDataTable<T>(List<T> data, FileInfo fileInfo)
		{
			var result = false;
			try
			{
				using (var pck = new ExcelPackage(fileInfo))
				{

					//Do NOT include Col1
					var mi = typeof(T)
						.GetProperties()
						.Where(pi => pi.Name != "Col1")
						.Select(pi => (MemberInfo)pi)
						.ToArray();

					var worksheet = pck.Workbook.Worksheets.Count == 0 ? pck.Workbook.Worksheets.Add("Sheet1") : pck.Workbook.Worksheets[0];
					worksheet.Cells.LoadFromCollection(
						data, true, TableStyles.None, BindingFlags.Public | BindingFlags.Instance, mi);

					// using (ExcelRange col = worksheet.Cells[$"G2:G{data.Count+1}"]) {
					//     col.Style.Numberformat.Format = "dd/MM/yyyy hh:mm:ss";
					//     col.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
					// }

					// using (ExcelRange col = worksheet.Cells[$"I2:I{data.Count+1}"]) {
					//     col.Style.Numberformat.Format = "dd/MM/yyyy hh:mm:ss";
					//     col.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
					// }

					pck.Save();
				}
				result = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return result;
		}

		public static bool GetExcelFromDataTable<T>(List<T> data, FileInfo fileInfo, string[] columnsName)
		{
			var result = false;
			try
			{
				using (var pck = new ExcelPackage(fileInfo))
				{

					//Do NOT include Col1
					var mi = typeof(T)
						.GetProperties()
						.Where(pi => pi.Name != "Col1")
						.Select(pi => (MemberInfo)pi)
						.ToArray();

					var worksheet = pck.Workbook.Worksheets.Count == 0 ? pck.Workbook.Worksheets.Add("Sheet1") : pck.Workbook.Worksheets[0];
					worksheet.Cells.LoadFromCollection(
						data, true, TableStyles.None, BindingFlags.Public | BindingFlags.Instance, mi);

					if (worksheet.Dimension.Columns >= columnsName.Length)
					{
						for (int i = 0; i < columnsName.Length; i++)
						{
							{
								var index = i + 1;
								worksheet.Cells[1, index].Value = columnsName[i];
							}
						}
					}

					pck.Save();
				}
				result = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return result;
		}

		public static Task<(bool, Stream, string)> GetExcelFromTemplate(DataTable data, FileInfo templateFileInfo, string[] columnsName, int sheetNumber, string[] footers = null)
		{
			var status = false;
			Stream stream = null;
			var message = string.Empty;
			try
			{
				if (File.Exists(templateFileInfo.FullName))
				{
					ExcelPackage package = new ExcelPackage(templateFileInfo);
					ExcelWorksheets worksheets = package.Workbook.Worksheets;

					if (worksheets.Count >= sheetNumber && worksheets.Count > 0)
					{
						ExcelWorksheet sheet = package.Workbook.Worksheets[sheetNumber];
						if (sheet != null)
						{
							// get number of rows and columns in the sheet
							//int rows = sheet.Dimension.Rows; // 20
							//int columns = sheet.Dimension.Columns; // 7

							// set header if template not supplied
							for (int c = 0; c < data.Columns.Count; c++) {
								if (string.IsNullOrWhiteSpace(sheet.Cells[1, c + 1].Value as string)) {
									var dc = data.Columns[c];
									sheet.Cells[1, c + 1].Value = string.IsNullOrEmpty(dc.Caption) ? dc.ColumnName : dc.Caption; //columnsName[c];
								}
								var formulaFirstRow = sheet.Cells[2, c + 1].FormulaR1C1;
								if (!string.IsNullOrWhiteSpace(formulaFirstRow)) {
									for (int r = 1; r < data.Rows.Count; r++) {
										var xr = r + 2;
										var xc = c + 1;
										if(!string.IsNullOrWhiteSpace(sheet.Cells[xr, xc].Formula)) {
											break;
										}
										sheet.Cells[xr, xc].FormulaR1C1 = formulaFirstRow;
									}
								}
							}
							// loop through the worksheet rows and columns
							for (int r = 0; r < data.Rows.Count; r++)
							{
								var xr = r + 2;
								var row = data.Rows[r];
								for (int c = 0; c < data.Columns.Count; c++)
								{
									//var column = columnsName[j].Replace("\"", string.Empty);
									var col = data.Columns[c];
									var xc = c + 1;
									if (col != null)
									{
										//var newFormat = Type.GetTypeCode(col.DataType) switch
										//{
										//	TypeCode.SByte or TypeCode.Byte or
										//	TypeCode.Int16 or TypeCode.UInt16 or
										//	TypeCode.Int32 or TypeCode.UInt32 or
										//	TypeCode.Int64 or TypeCode.UInt64
										//		=> "###0",
										//	TypeCode.Single or TypeCode.Double or TypeCode.Decimal => "###0.00",
										//	TypeCode.DateTime when !string.IsNullOrEmpty(sheet.Cells[xr, xc].Style.Numberformat.Format)
										//		=> "dd/MM/yyyy hh:mm:ss",
										//	_ => null
										//};
										//if (newFormat != null) {
										//	sheet.Cells[xr, xc].Style.Numberformat.Format = newFormat;
										//}
										switch (Type.GetTypeCode(col.DataType)) {
											case TypeCode.SByte:
											case TypeCode.Byte:
											case TypeCode.Int16:
											case TypeCode.UInt16:
											case TypeCode.Int32:
											case TypeCode.UInt32:
											case TypeCode.Int64:
											case TypeCode.UInt64:
												sheet.Cells[xr, xc].Style.Numberformat.Format = "###0";
												break;

											case TypeCode.Single:
											case TypeCode.Double:
											case TypeCode.Decimal:
												sheet.Cells[xr, xc].Style.Numberformat.Format = "###0.00";
												break;

											case TypeCode.DateTime:
												if (!string.IsNullOrEmpty(sheet.Cells[xr, xc].Style.Numberformat.Format))
												{
													sheet.Cells[xr, xc].Style.Numberformat.Format = "dd/MM/yyyy hh:mm:ss";
												}
												break;
										}

										if (string.IsNullOrEmpty(sheet.Cells[xr, xc].Formula) && !string.IsNullOrEmpty(row[c].ToString())) {
											sheet.Cells[xr, xc].Value = row[c];
										}
									}
									else
									{
										sheet.Cells[xr, xc].Value = row[c].ToString();
									}
								}
							}

							int footerRow = data.Rows.Count + 2;

							if (footers == null) {
								footers = new string[] { };
							}
							for (int i = 0; i < footers.Length; i++) {
								string footer = footers[i];

								if (!string.IsNullOrEmpty(footer)){
									if (footer.StartsWith("func.")) {
										string formula = footer.Substring(5).ToLower();
										string firstCell = GetCellName(2, i + 1);
										string lastCell = GetCellName(footerRow - 1, i + 1);

										sheet.Cells[footerRow, i + 1].Formula = formula switch
										{
											"sum" => $"SUM({firstCell}:{lastCell})",
											"count" => $"COUNTA({firstCell}:{lastCell})",
											"countdistinct" => $"SUM(IF(FREQUENCY({firstCell}:{lastCell}, {firstCell}:{lastCell})>0,1))",
											_ => null
										};
									} else {
										sheet.Cells[footerRow, i + 1].Value = footer;
									}
								}
							}

							//var dataCell = sheet.Cells["A1"];
							//var dataRange = dataCell.LoadFromDataTable(data, PrintHeaders: true);

							foreach (var ws in worksheets)
							{
								var sheet1 = worksheets[0].Name;
								foreach (var pivot in ws.PivotTables)
								{
									var source = pivot.CacheDefinition.SourceRange;
									pivot.CacheDefinition.SourceRange = sheet.Cells[source.Start.Row, source.Start.Column, data.Rows.Count + 1, source.End.Column];
								}

								foreach (var chart in ws.Drawings)
								{
									var type = chart.GetType();
									if (type.Equals(typeof(ExcelBarChart)))
									{
										var barChart = (ExcelBarChart)chart;
										var series = barChart.Series;
										for (int i = 0; i < series.Count; i++)
										{
											var s = series[i];
											var address = s.HeaderAddress;
											if (!string.IsNullOrEmpty(s.Series))
											{
												var sourceSheet = s.Series.Split('!')[0];
												if (sheet1 != sourceSheet) break;
											}

											if (!string.IsNullOrEmpty(s.XSeries))
											{

											}
										}
									}
								}
							}
						}

						stream = new MemoryStream(package.GetAsByteArray());
						status = true;
					}
					else
						message = $"Data does not exist in sheet number {sheetNumber}";
					//var path = fileInfo.Directory;
					//if (!Directory.Exists(path.FullName))
					//    Directory.CreateDirectory(path.FullName);
					//package.SaveAs(fileInfo);
					//using (stream = File.Create(fileInfo.FullName))
					//{
					//    package.SaveAs(stream);
					//}
				}
				else
				{
					message = $"Template file does not exist in a path {templateFileInfo.FullName}";
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				status = false;
				message = ex.Message;
			}

			return Task.FromResult((status, stream, message));
		}
		
		private static string GetColumnName(int col) {
			if (col > 16384 || col < 1) {
				throw new ArgumentOutOfRangeException("column must between 1 and 16384");
			}
			int dividend = col;
			string columnName = "";
			int modulo;

			while (dividend > 0) {
				modulo = (dividend - 1) % 26;
				columnName = Convert.ToChar(65 + modulo).ToString() + columnName; // 65 = 'A'
				dividend = (int)((dividend - modulo) / 26);
			}

			return columnName;
		}

		private static string GetCellName(int row, int col) {
			return GetColumnName(col) + row.ToString();
		}
	}
}