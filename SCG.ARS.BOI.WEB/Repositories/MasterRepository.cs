using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NLog;
using NLog.Web.LayoutRenderers;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;
using NpgsqlTypes;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Entities.MasterDb;
using SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb;
using SCG.ARS.BOI.WEB.Entities.QaDataLakePKGDb;
using SCG.ARS.BOI.WEB.Entities.QaDataLakeWHDb;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.ViewModels;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Quartz.Util;
//using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SCG.ARS.BOI.WEB.Repositories
{
	enum EnumParamDataType
	{
		Integer = 1,
		String = 2,
		Array = 3,
		Now = 4,
		Today = 5,
		Yesterday = 6,
		DayMinus7 = 7,
		LastWeek = 8,
		FirstDayOfWeek = 9,
		LastDayOfWeek = 10,
		FirstDayOfMonth = 11,
		LastDayOfMonth = 12,
		FirstDayOfLastMonth = 13,
		LastDayOfLastMonth = 14,
		DayMinus3,
		DayMinus15
	}

	public class MasterRepository : IMasterRepository
	{
		static Logger logger = LogManager.GetCurrentClassLogger();
		private ConnectionStrings _connections;
		private string _tempPath;

		private readonly IHostingEnvironment _hostingEnvironment;
		private readonly MasterContext _masterContext;
		private readonly QaWHContext _whContext;
		private readonly QaPKGContext _pkgContext;
		private readonly QaDOMContext _domContext;
		public MasterRepository(IConfiguration configuration,
			IOptions<ConnectionStrings> connections,
			IHostingEnvironment hostingEnvironment,
			MasterContext masterContext,
			QaWHContext whContext)
		{
			_connections = connections.Value;
			_hostingEnvironment = hostingEnvironment;
			_masterContext = masterContext;
			_whContext = whContext;
			_tempPath = Path.GetTempPath();
		}
		internal IDbConnection PDLakeConnection
		{
			get
			{
				return new NpgsqlConnection(_connections.PDLakeConnection);
			}
		}
		internal IDbConnection PDLakeWConnection
		{
			get
			{
				return new NpgsqlConnection(_connections.PDLakeWConnection);
			}
		}
		internal IDbConnection ARSConnection
		{
			get
			{
				return new NpgsqlConnection(_connections.ARSConnection);
			}
		}

		public List<SourceSchema> GetSourceSchema()
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<SourceSchema>($@"SELECT catalog_name, schema_name, schema_owner
FROM information_schema.schemata
WHERE schema_name not in('public','information_schema','pg_catalog');");

					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<Schema> GetSchemas()
		{
			//try
			//{
			//	//using (IDbConnection dbConnection = PDLakeConnection)
			//	//{
			//	//    dbConnection.Open();
			//	//    var data = dbConnection.Query<Schema>("SELECT catalog_name, schema_name, schema_owner FROM information_schema.schemata;");

			//	var result = _masterContext.ArsTblSchema
			//		.Select(s => new Schema
			//		{
			//			schema_id = s.SchemaId,
			//			catalog_name = s.CatalogName,
			//			schema_name = s.SchemaName,
			//			schema_owner = s.SchemaOwner,
			//			schema_display = s.SchemaDisplay,
			//			schema_order = s.SchemaOrder,
			//			is_active = s.IsActive,
			//			is_deleted = s.IsDeleted
			//		}).OrderBy(o => o.schema_order).ToList();

			//	//var result = data.ToList();
			//	return result;
			//	//}
			//}
			try
			{
				using IDbConnection dbConnection = ARSConnection;
				dbConnection.Open();
				var data = dbConnection.Query<Schema>($"SELECT schema_id, schema_name, schema_display, catalog_name, schema_owner, is_active, is_deleted, schema_order, update_by, update_date " +
					$" FROM master.ars_tbl_schema  ", commandType: CommandType.Text).OrderBy(d => d.schema_order);
				return data.ToList();
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, Schema, string)> SaveSchema(Schema request)
		{
			var status = false;
			var message = string.Empty;
			DateTime now = DateTime.Now;
			request.update_date = now.ToString("dd/MM/yyyy HH:mm:ss");
			try
			{
				if (request.schema_id == null)
				{
					int count = _masterContext.ArsTblSchema.Count();
					_masterContext.ArsTblSchema.Add(new ArsTblSchema
					{
						SchemaName = request.schema_name,
						CatalogName = request.catalog_name,
						SchemaOwner = request.schema_owner,
						SchemaDisplay = request.schema_display_edit,
						UpdateBy = request.update_by,
						UpdateDate = request.update_date,
						IsActive = true,
						IsDeleted = false
					});
				}
				else
				{
					_masterContext.ArsTblSchema.Update(new ArsTblSchema
					{
						SchemaId = request.schema_id.Value,
						SchemaName = request.schema_name,
						CatalogName = request.catalog_name,
						SchemaOwner = request.schema_owner,
						SchemaDisplay = request.schema_display_edit,
						SchemaOrder = request.schema_order,
						UpdateBy = request.update_by,
						UpdateDate = request.update_date,
						IsActive = request.is_active,
						IsDeleted = request.is_deleted
					});
				}

				_masterContext.SaveChanges();
				status = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}
		public Task<(bool, Schema, string)> DeleteSchema(Schema request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				_masterContext.ArsTblSchema.Remove(new ArsTblSchema
				{
					SchemaName = request.schema_name,
					SchemaOwner = request.schema_owner,
					SchemaDisplay = request.schema_display,
					SchemaOrder = request.schema_order,
					IsActive = request.is_active,
					IsDeleted = request.is_deleted
				});

				_masterContext.SaveChanges();
				status = true;
				message = "Delete Successful.";
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}

		public Task<(bool, ReportGroup, string)> SaveGroup(ReportGroup request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				if (request.group_id == null)
				{
					int count = _masterContext.ArsTblReportGroup.Count();
					_masterContext.ArsTblReportGroup.Add(new ArsTblReportGroup
					{
						GroupName = request.group_name,
						SchemaId = request.schema_id,
						CreatedBy = request.created_by,
						CreatedDate = DateTime.Now,
						UpdatedBy = "",
						UpdatedDate = Convert.ToDateTime(request.updated_date),
						IsActive = true

					});
				}
				else
				{
					_masterContext.ArsTblReportGroup.Update(new ArsTblReportGroup
					{
						GroupId = request.group_id.Value,
						GroupName = request.group_name,
						SchemaId = request.schema_id,
						CreatedBy = request.created_by,
						CreatedDate = Convert.ToDateTime(request.created_date),
						UpdatedBy = request.updated_by,
						UpdatedDate = DateTime.Now,
						IsActive = request.is_active
					});
				}

				_masterContext.SaveChanges();
				status = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}

		public Task<(bool, ReportGroup, string)> DeleteGroup(ReportGroup request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				_masterContext.ArsTblReportGroup.Remove(new ArsTblReportGroup
				{
					GroupId = request.group_id.Value,
					GroupName = request.group_name,
					SchemaId = request.schema_id,
					CreatedBy = request.created_by,
					CreatedDate = Convert.ToDateTime(request.created_date),
					UpdatedBy = "ADMIN",
					UpdatedDate = Convert.ToDateTime(request.updated_date),
					IsActive = request.is_active
				});

				_masterContext.SaveChanges();
				status = true;
				message = "Delete Successful.";
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}

		public Task<(bool, ReportGroup, string)> SaveReport(ReportGroup request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				if (request.checkupdate)
				{
					int count = _masterContext.ArsTblReportGroupMapping.Count();
					_masterContext.ArsTblReportGroupMapping.Add(new ArsTblReportGroupMapping
					{
						GroupId = request.group_id.Value,
						FunctionName = request.function_name,
						ReportName = request.report_name,
						CreatedBy = request.created_by,
						CreatedDate = DateTime.Now,
						UpdatedBy = "",
						UpdatedDate = request.updated_date,
						IsActive = true

					});
					_masterContext.SaveChanges();
				}
				else
				{
					//_masterContext.ArsTblReportGroupMapping.Update(new ArsTblReportGroupMapping
					//{
					//	GroupId = request.group_id.Value,
					//	ReportId = request.report_id,
					//	ReportName = request.report_name,
					//	//CreatedBy = request.created_by,
					//	//CreatedDate = Convert.ToDateTime(request.created_date),
					//	CreatedBy = "Admin",
					//	CreatedDate = DateTime.Now,
					//	UpdatedBy = "Admin",
					//	UpdatedDate = DateTime.Now,
					//	IsActive = request.is_active
					//});
					//request.updated_by = "ADMIN";
					request.updated_date = DateTime.Now;

					using IDbConnection dbConnection = ARSConnection;
					dbConnection.Open();
					dbConnection.Query<ReportGroup>($"update master.ars_tbl_report_group_mapping set report_name = '{request.report_name}', function_name = '{request.function_name}', updated_by = '{request.updated_by}', updated_date = '{request.updated_date}' " +
						$" where group_id = {request.group_id} and function_name = '{request.function_name_old}' ", commandType: CommandType.Text);
					status = true;
					message = "Update Successful.";

					if (status)
					{
						status = UpdateReportCustomize(request);
					}

				}

				
				status = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}         

			return Task.FromResult((status, request, message));
		}

		public Task<(bool, ReportGroup, string)> UpdateReportActive(ReportGroup request)
		{
			var status = false;
			var message = string.Empty;
			request.updated_date = DateTime.Now;
			try
			{
				if (request.check_active == "SM")
				{
					using IDbConnection dbConnection = ARSConnection;
					dbConnection.Open();
					dbConnection.Query<ReportGroup>($"update master.ars_tbl_schema set is_active = {request.is_active} " +
						$" where schema_id = {request.schema_id} ", commandType: CommandType.Text);
					status = true;
					message = "Update Successful.";
				}
                else if (request.check_active == "GR")
                {
					using IDbConnection dbConnection = ARSConnection;
					dbConnection.Open();
					dbConnection.Query<ReportGroup>($"update master.ars_tbl_report_group set is_active = {request.is_active}, updated_by = '{request.updated_by}', updated_date = '{request.updated_date}' " +
						$" where group_id = {request.group_id} and schema_id = {request.schema_id} ", commandType: CommandType.Text);
					status = true;
					message = "Update Successful.";
				}
				else if (request.check_active == "FN")
				{
										
					using IDbConnection dbConnection = ARSConnection;
					dbConnection.Open();
					dbConnection.Query<ReportGroup>($"update master.ars_tbl_report_group_mapping set is_active = {request.is_active}, updated_by = '{request.updated_by}', updated_date = '{request.updated_date}' " +
						$" where group_id = {request.group_id} and function_name = '{request.function_name}' ", commandType: CommandType.Text);
					status = true;
					message = "Update Successful.";
				}

			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}


		public bool UpdateReportCustomize(ReportGroup request)
		{
			var status = false;
			var message = string.Empty;
			try
			{

				using IDbConnection dbConnection = ARSConnection;
				dbConnection.Open();
				dbConnection.Query<ReportGroup>($"update master.ars_tbl_template_report_mapping set function_name = '{request.function_name}' " +
					$" where group_id = {request.group_id} and function_name = '{request.function_name_old}' ", commandType: CommandType.Text);
				status = true;
				message = "Update Successful.";


				status = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return status;
		}

		public bool DeleteReportCustomize(ReportGroup request)
		{
			var status = false;
			var message = string.Empty;
			try
			{

				using IDbConnection dbConnection = ARSConnection;
				dbConnection.Open();
				dbConnection.Query<ReportGroup>($"delete master.ars_tbl_template_report_mapping " +
					$" where group_id = {request.group_id} and function_name = '{request.function_name}' ", commandType: CommandType.Text);
				status = true;
				message = "Update Successful.";


				status = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return status;
		}


		public Task<(bool, ReportGroup, string)> DeleteReportGroup(ReportGroup request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				using IDbConnection dbConnection = ARSConnection;
				dbConnection.Open();
				dbConnection.Query<ReportGroup>($"delete from master.ars_tbl_report_group_mapping where group_id = {request.group_id}" +
					$" AND function_name = '{request.function_name}' ", commandType: CommandType.Text);
				status = true;


				if (status)
				{
					status = DeleteReportCustomize(request);
				}

				message = "Delete Successful.";
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}

		public List<MasterFunction>  GetReportsCustomization()
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();

					var data = dbConnection.Query<MasterFunction>("master.get_reports_customization", commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}

		//public Task<(bool, List<ReportsCustomizationDetailModel>, string)> GetReportsCustomization()
		//{
		//	var status = true;
		//	var message = string.Empty;
		//	try
		//	{
		//		using (IDbConnection dbConnection = ARSConnection)
		//		{
		//			dbConnection.Open();

		//			var data = dbConnection.Query<ReportsCustomizationDetailModel>("master.get_reports_customization", commandType: CommandType.StoredProcedure);
		//			return Task.FromResult((status, data.ToList(), message));
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		logger.Error(ex, ex.Message);
		//		return null;
		//	}
		//}

		public List<Table> GetTables(string schema)
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<Table>($@"
SELECT table_catalog, table_schema, table_name, table_type
FROM information_schema.tables
WHERE table_type = 'BASE TABLE'
AND table_schema = '{schema}';
			");
					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<Function> GetSourceFunctions(string schema)
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<Function>($@"
								SELECT routines.specific_catalog, routines.specific_schema,
									routines.routine_name, routines.routine_type
								FROM information_schema.routines
								WHERE routines.specific_schema = '{schema}'
								ORDER BY routines.routine_name ");
					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<Parameter> GetFunctionParameters(string schema, string function_name)
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<Parameter>($@"
SELECT distinct routines.specific_catalog, routines.specific_schema,
	routines.routine_name, routines.routine_type, parameters.parameter_mode,
	parameters.parameter_name, parameters.data_type, parameters.udt_name, parameters.ordinal_position
FROM information_schema.routines
LEFT JOIN information_schema.parameters ON routines.specific_name = parameters.specific_name
WHERE routines.specific_schema = '{schema}'
and routine_name = '{function_name}'
and parameter_mode = 'IN'
ORDER BY routines.routine_name, parameters.ordinal_position;");
					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}

		public List<FunctionColumn> GetColumnParameters(string schema, string function_name)
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<FunctionColumn>($@"
SELECT routines.specific_catalog, routines.specific_schema,
	routines.routine_name, routines.routine_type, parameters.parameter_mode,
	parameters.parameter_name, parameters.data_type, parameters.ordinal_position
FROM information_schema.routines
LEFT JOIN information_schema.parameters ON routines.specific_name = parameters.specific_name
WHERE routines.specific_schema = '{schema}'
and routine_name = '{function_name}'
and parameter_mode = 'OUT'
ORDER BY routines.routine_name, parameters.ordinal_position;");
					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}

		public List<Column> GetColumns(string schema, string table)
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<Column>($@"
SELECT * FROM information_schema.columns
WHERE table_schema = '{schema}'
AND table_name = '{table}';");
					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, List<TemplateColumnMapping>, string)> GetColumnSelection(TemplateReportMapping report, List<TemplateColumnMapping> selectedColumns)
		{
			var status = false;
			List<TemplateColumnMapping> data = null;
			var message = string.Empty;
			try
			{
				var columns = GetColumnParameters(report.schema_name, report.function_name).Select(s => new RawColumn {
					column_name = s.parameter_name,
					column_data_type = s.data_type
				});

				var currentColumns = selectedColumns.Select(s => new RawColumn {
					column_name = s.column_name,
					column_data_type = s.column_data_type
				});

				data = columns.Except(currentColumns, new ColumnSelectionComparer()).Select(s => new TemplateColumnMapping
				{
					template_report_mapping_id = report.template_report_mapping_id.Value,
					schema_id = report.schema_id,
					schema_name = report.schema_name,
					schema_display = report.schema_display,
					catalog_name = report.catalog_name,
					schema_owner = report.schema_owner,
					function_id = report.function_id,
					function_name = report.function_name,
					report_id = report.report_id,
					report_name = report.report_name,
					report_desc = report.report_desc,
					column_name = s.column_name,
					//column_display = s.column_display,
					column_data_type = s.column_data_type,
					column_sorting = 0,
					is_active = true
				}).ToList();
				
				data.Add(new TemplateColumnMapping {
					template_report_mapping_id = report.template_report_mapping_id.Value,
					schema_id = report.schema_id,
					schema_name = report.schema_name,
					schema_display = report.schema_display,
					catalog_name = report.catalog_name,
					schema_owner = report.schema_owner,
					function_id = report.function_id,
					function_name = report.function_name,
					report_id = report.report_id,
					report_name = report.report_name,
					report_desc = report.report_desc,
					column_name = null,
					column_data_type = null,
					column_sorting = 0,
					is_active = true
				});

				status = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return Task.FromResult((status, data, message));
		}
		/// <summary>
		/// Generwiz - Pittaya J. 2021-02-19
		/// </summary>
		/// <returns></returns>
		public List<ReportGroup> GetReportGroups()
		{
			try
			{
				using IDbConnection dbConnection = ARSConnection;
				dbConnection.Open();
				var data = dbConnection.Query<ReportGroup>($"select group_id, group_name, schema_id from master.ars_tbl_report_group ", commandType: CommandType.Text);
				return data.ToList();
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}

		public List<ReportGroup> GetReportGroups(int? p_schema_id = null, int? p_group_id = null)
		{
			try
			{
				using IDbConnection dbConnection = ARSConnection;
				dbConnection.Open();  
				var data = dbConnection.Query<ReportGroup>($"select r.group_id, r.group_name, r.schema_id, r.is_active, r.created_by, r.created_date, r.updated_by, r.updated_date from master.ars_tbl_report_group r " +
					$" inner join master.ars_tbl_schema s ON r.schema_id = s.schema_id where r.schema_id = {p_schema_id} AND s.is_active = true ", commandType: CommandType.Text).OrderBy(d=> d.group_id);
				return data.ToList();
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}

		public List<Report> GetReports()
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<Report>("master.get_reports", commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<Report> GetReports(int? p_schema_id = null, int? p_report_id = null, int? p_group_id = null)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_schema_id = p_schema_id,
						p_report_id = p_report_id,
						p_group_id = p_group_id
					};
					var data = dbConnection.Query<Report>("master.get_reports", parameters, commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}

		public List<Report> GetGroupReports(int? schema_id = null, int? group_id = null)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_schema_id = schema_id,
						p_group_id = group_id
					};
					var data = dbConnection.Query<Report>("master.get_group_reports", parameters, commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, List<Report>, string)> AddReports(List<Report> request)
		{
			var result = false;
			var data = new List<Report>();
			var message = string.Empty;
			try
			{
				var update = request.Where(w => w.report_id > 0).Select(s => new ArsTblReport
				{
					SchemaId = s.schema_id,
					ReportId = s.report_id.Value,
					ReportName = s.report_name,
					IsActive = s.is_active
				});

				if (update.Count() > 0)
					_masterContext.ArsTblReport.UpdateRange(update);

				var maxId = _masterContext.ArsTblReport.Max(s => s.ReportId);
				var newReport = request.Where(w => !w.report_id.HasValue);
				var records = new List<ArsTblReport>();

				foreach (var s in newReport)
				{
					if (!_masterContext.ArsTblReport.Any(a => a.ReportName == s.report_name && a.SchemaId == s.schema_id))
					{
						records.Add(new ArsTblReport
						{
							ReportId = maxId + 1,
							SchemaId = s.schema_id,
							ReportName = s.report_name,
							IsActive = s.is_active
						});
						maxId++;
					}
				}

				if (records.Count() > 0)
					_masterContext.ArsTblReport.AddRange(records);

				_masterContext.SaveChanges();

				data = GetReports(p_schema_id: request[0].schema_id);

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, data, message));
		}
		public Task<(bool, List<Report>, string)> DeleteReports(Report request)
		{
			var result = false;
			var data = new List<Report>();
			var message = string.Empty;
			try
			{
				if (request != null && request.report_id.HasValue)
				{
					if(!_masterContext.ArsTblFunction.Any(a => a.ReportId == request.report_id.Value)){
						var rows = _masterContext.ArsTblReport.Where(w => w.ReportId == request.report_id.Value);
						_masterContext.ArsTblReport.RemoveRange(rows);
						_masterContext.SaveChanges();

						result = true;
					}
					else
					{
						message = $"Report {request.report_name} already in use.";
					}
				}
				else
				{
					message = "ReportId does not exist from request.";
				}
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, data, message));
		}
		public List<MasterFunction> GetFunctions(int? p_schema_id = null, int? p_report_id = null, int? p_function_id = null)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_schema_id = p_schema_id,
						p_report_id = p_report_id,
						p_function_id = p_function_id
					};
					var data = dbConnection.Query<MasterFunction>("master.get_functions", parameters, commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, MasterFunction, string)> SaveFunction(MasterFunction request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				if (request.function_id == null)
				{
					_masterContext.ArsTblFunction.Add(new ArsTblFunction
					{
						FunctionName = request.function_name,
						SchemaId = request.schema_id,
						ReportId = request.report_id,
						IsActive = true
					});
				}
				else
				{
					_masterContext.ArsTblFunction.Update(new ArsTblFunction
					{
						FunctionId = request.function_id.Value,
						FunctionName = request.function_name,
						SchemaId = request.schema_id,
						ReportId = request.report_id,
						IsActive = request.is_active
					});
				}

				_masterContext.SaveChanges();
				status = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}
		public Task<(bool, MasterFunction, string)> DeleteFunction(MasterFunction request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				_masterContext.ArsTblFunction.Remove(new ArsTblFunction
				{
					FunctionId = request.function_id.Value,
					FunctionName = request.function_name,
					SchemaId = request.schema_id,
					ReportId = request.report_id,
					IsActive = request.is_active
				});

				_masterContext.SaveChanges();
				status = true;
				message = "Delete Successful.";
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}
		//        public List<Parameter> GetParameters(string schema, string function_name)
		//        {
		//            try
		//            {
		//                using (IDbConnection dbConnection = PDLakeConnection)
		//                {
		//                    dbConnection.Open();
		//                    var data = dbConnection.Query<Parameter>($@"
		//SELECT routines.specific_catalog, routines.specific_schema,
		//    routines.routine_name, routines.routine_type, parameters.parameter_mode,
		//    parameters.parameter_name, parameters.data_type, parameters.ordinal_position
		//FROM information_schema.routines
		//LEFT JOIN information_schema.parameters ON routines.specific_name = parameters.specific_name
		//WHERE routines.specific_schema = '{schema}'
		//and routine_name = '{function_name}'
		//ORDER BY routines.routine_name, parameters.ordinal_position;");
		//                    var result = data.ToList();
		//                    return result;
		//                }
		//            }
		//            catch (Exception ex)
		//            {
		//                logger.Error(ex, ex.Message);
		//                return null;
		//            }
		//        }
		public List<ParameterType> GetParameterTypes()
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<ParameterType>("master.get_parameter_types", commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<TemplateReportMapping> GetTemplateReportMapping(string p_schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null, bool onlyActive = false)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_schema_name = p_schema_name,
						p_template_report_mapping_id = p_template_report_mapping_id,
						p_function_id = p_function_id,
						p_report_id = p_report_id
					};
					var data = dbConnection.Query<TemplateReportMapping>("master.get_template_report_mapping", parameters, commandType: CommandType.StoredProcedure);
					return data.Where(w => !onlyActive || w.is_active).ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}

		public List<TemplateReportMapping> GetTemplateReportMappingNew()
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<TemplateReportMapping>("master.get_template_report_mapping_new", commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}


		public Task<(bool, TemplateReportMapping, string)> SaveTemplateReportMapping(TemplateReportMapping request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				if (request.template_report_mapping_id == null)
				{
					var item = new ArsTblTemplateReportMapping
					{
						SchemaId = request.schema_id,
						FunctionId = 0,
						ReportId = 0,
						ReportDesc = request.report_desc,
						GroupId = request.group_id,
						FunctionName = request.function_name,
						IsActive = true
					};
					_masterContext.ArsTblTemplateReportMapping.Add(item);

					_masterContext.SaveChanges();
					request.template_report_mapping_id = item.TemplateReportMappingId;

					AddTemplateParameterMapping(request);
					AddTemplateColumnMapping(request);
					message = "Add data successful";
				}
				else
				{
					_masterContext.ArsTblTemplateReportMapping.Update(new ArsTblTemplateReportMapping
					{
						TemplateReportMappingId = request.template_report_mapping_id.Value,
						TemplateName = request.template_name,
						SchemaId = request.schema_id,
						GroupId = request.group_id,
						FunctionName = request.function_name,
						FunctionId = 0,
						ReportId = 0,
						ReportDesc = request.report_desc,
						IsActive = true
					});

					var pCount = _masterContext.ArsTblTemplateParameterMapping.Where(w => w.TemplateReportMappingId == request.template_report_mapping_id).Count();
					if (pCount == 0)
						AddTemplateParameterMapping(request);

					var cCount = _masterContext.ArsTblTemplateColumnMapping.Where(w => w.TemplateReportMappingId == request.template_report_mapping_id).Count();
					if (cCount == 0)
						AddTemplateColumnMapping(request);

					message = "Save data successful";
				}

				_masterContext.SaveChanges();
				status = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return Task.FromResult((status, request, message));
		}
		public Task<(bool, TemplateReportMapping, string)> CopyTemplateReportMapping(TemplateReportMapping request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				var item = new ArsTblTemplateReportMapping
				{
					SchemaId = request.schema_id,
					FunctionId = request.function_id,
					ReportId = request.report_id,
					ReportDesc = $"{request.report_desc}-Copy",
					IsActive = true
				};
				_masterContext.ArsTblTemplateReportMapping.Add(item);

				_masterContext.SaveChanges();

				CopyTemplateParameterMapping(request, item);
				CopyTemplateColumnMapping(request, item);
				message = "Add data successful";

				_masterContext.SaveChanges();
				status = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return Task.FromResult((status, request, message));
		}
		public async Task<(bool, string, string)> DownloadTemplateReportMapping(TemplateReportMapping request, int? limit = null)
		{
			var status = false;
			var filePath = string.Empty;
			Stream stream = null;
			var message = string.Empty;
			var data = new DataTable();
			try {
				var report = GetTemplateReportMapping(p_template_report_mapping_id: request.template_report_mapping_id).FirstOrDefault();

				var parameters = GetTemplateParameterMapping(p_template_report_mapping_id: request.template_report_mapping_id);
				var columns = GetTemplateColumnMapping(p_template_report_mapping_id: request.template_report_mapping_id);
				var columnNames = columns
					.Select(c => {
						string colNameOrVal;

						if (!string.IsNullOrWhiteSpace(c.column_name)) {
							colNameOrVal = "\"" + c.column_name + "\"";
						} else {
							if (!string.IsNullOrWhiteSpace(c.default_value)) {
								colNameOrVal = "'" + c.default_value + "'";
							} else {
								colNameOrVal = "NULL";
							}
						}

						string aliasName;
						if (!string.IsNullOrWhiteSpace(c.column_display)) {
							aliasName = "\"" + c.column_display + "\"";
						} else {
							if (!string.IsNullOrWhiteSpace(c.column_name)) {
								aliasName = "\"" + c.column_name + "\"";
							} else {
								aliasName = "_dummy_" + c.column_sorting;
							}
						}

						return $"{colNameOrVal} AS {aliasName}";
					})
					.ToArray();

				var displayNames = columns
					.Select(c => {
						if (!string.IsNullOrWhiteSpace(c.column_display))
							return c.column_display;
						if (c.column_name.StartsWith("_dummy_"))
							return "";
						else
							return c.column_name;
					})
					.ToArray();

				var footers = columns.Select(s => s.footer).ToArray();
				var paramList = parameters.Select(s => "@" + s.parameter_name).ToArray();
				var sql = $"SELECT {string.Join(',', columnNames)} FROM {report.schema_name}.{report.function_name}({string.Join(',', paramList)})";
				if (limit.HasValue && limit.Value > 0) {
					sql += $" LIMIT {limit.Value}";
				}

				Task.Factory.StartNew(async () => {
					(status, data, message) = await GetFunctionData(sql, parameters, CommandType.Text);
				}).Wait();

				if (status) {
					string saveFileName = $"{report.report_desc}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
					FileInfo file = null;
					try {
						if (!string.IsNullOrEmpty(report.template_path))
							file = new FileInfo(report.template_path);
					} catch (Exception ex) {
						logger.Error(ex, ex.Message);
					}

					string path = Path.Combine("Temp", report.template_report_mapping_id.ToString());
					string savePath = Path.Combine(_tempPath, path);
					
					FileInfo fileSave = new FileInfo(Path.Combine(savePath, saveFileName.Replace("/", "-")));

					if (!Directory.Exists(savePath)) Directory.CreateDirectory(savePath);

					filePath = Path.Combine(path, saveFileName.Replace("/", "-"));

					Task.Factory.StartNew(async () => {
						if (file == null) { 
							(status, stream, message) = await ExcelHelper.GetExcelFromDataTable(data, footers);
						} else {
							(status, stream, message) = await ExcelHelper.GetExcelFromTemplate(data, file, displayNames, 0, footers);
						}
					}).Wait();

					if (stream != null)
					{
						using (var fileStream = new FileStream(fileSave.FullName, FileMode.Create, FileAccess.Write))
							stream.CopyTo(fileStream);
						status = true;
						message = "Download data successful.";
					} 
					else {
						message = "Cannot generate excel";
					}
				} else {
					message = "Cannot generate excel";
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				message = ex.Message;
			}

			return (status, filePath, message);
		}

		[Obsolete]
		public async Task<(bool, string, string)> DownloadWithTemplateReportMapping(TemplateReportMapping request)
		{
			var status = false;
			var filePath = string.Empty;
			var message = string.Empty;
			Stream stream = null;
			var data = new DataTable();
			try {
				var report = GetTemplateReportMapping(p_template_report_mapping_id: request.template_report_mapping_id).FirstOrDefault();

				if (string.IsNullOrEmpty(report.template_path)) {
					message = "Template does not exist";
					return (status, filePath, message);
				}

				var parameters = GetTemplateParameterMapping(p_template_report_mapping_id: request.template_report_mapping_id);
				var columns = GetTemplateColumnMapping(p_template_report_mapping_id: report.template_report_mapping_id);
				var columnNames = columns
					.Select(c =>
						$"{(string.IsNullOrWhiteSpace(c.column_name) ? "null" : "\"" + c.column_name + "\"")} AS \"{(c.column_display ?? (string.IsNullOrEmpty(c.column_name) ? "_dummy_" + c.column_sorting : c.column_name))}\""
					)
					.ToArray();
				var displayNames = columns
					.Select(c => {
						if (!string.IsNullOrWhiteSpace(c.column_display))
							return c.column_display;
						if (c.column_name.StartsWith("_dummy_"))
							return "";
						else
							return c.column_name;
					})					
					.ToArray();
				
				var footers = columns.Select(s => s.footer).ToArray();
				var paramList = parameters.Select(s => "@" + s.parameter_name).ToArray();
				var sql = $"SELECT {string.Join(',', columnNames)} FROM {report.schema_name}.{report.function_name}({string.Join(',', paramList)});";

				Task.Factory.StartNew(async () =>
				{
					(status, data, message) = await GetFunctionData(sql, parameters, CommandType.Text);
				}).Wait();

				//Stream stream = ExcelHelper.GetExcelFromDataTable(dt);

				//string sWebRootFolder = _hostingEnvironment.WebRootPath;
				string saveFileName = $"{report.report_desc}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
				//string sFileName = template.template_path;

				//string path = Path.Combine(sWebRootFolder, "Templates");
				//FileInfo file = new FileInfo(Path.Combine(path, sFileName));
				//string path = Path.Combine(_tempPath, "Templates");
				FileInfo file = new FileInfo(report.template_path);

				string temp = Path.Combine("Temp", report.template_report_mapping_id.ToString());
				string savePath = Path.Combine(_tempPath, temp);
				FileInfo fileSave = new FileInfo(Path.Combine(savePath, saveFileName));

				if (!Directory.Exists(savePath)) Directory.CreateDirectory(savePath);

				//filePath = $"Temp/{ report.template_report_mapping_id.ToString()}/{ saveFileName}";
				filePath = Path.Combine(temp, saveFileName.Replace("/", "-")); //fileSave.FullName;

				Task.Factory.StartNew(async () =>
				{
					(status, stream, message) = await ExcelHelper.GetExcelFromTemplate(data, file, displayNames, 0, footers);
				}).Wait();

				if (status)
				{
					using (var fileStream = new FileStream(fileSave.FullName, FileMode.Create, FileAccess.Write))
						stream.CopyTo(fileStream);
					status = true;
					message = "Download data successful.";
				}

				//byte[] fileBytes = Helper.GetFile(fileSave.FullName);
				//File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileSave.FullName);

				//status = true;
				//message = "Download data successful.";
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				message = ex.Message;
			}

			return (status, filePath, message);
		}
		public Task<(bool, TemplateReportMapping, string)> UploadTemplateReportMapping(string uploadedPath, int template_report_mapping_id)
		{
			var status = false;
			TemplateReportMapping template = null;
			var message = string.Empty;
			try
			{
				template = GetTemplateReportMapping(p_template_report_mapping_id: template_report_mapping_id).FirstOrDefault();

				template.template_name = Path.GetFileName(uploadedPath);
				template.template_path = uploadedPath;

				_masterContext.ArsTblTemplateReportMapping.Update(new ArsTblTemplateReportMapping
				{
					TemplateReportMappingId = template.template_report_mapping_id.Value,
					SchemaId = template.schema_id,
					FunctionId = template.function_id,
					ReportId = template.report_id,
					ReportDesc = template.report_desc,
					TemplateName = template.template_name,
					TemplatePath = template.template_path,
					IsActive = template.is_active
				});

				_masterContext.SaveChanges();

				status = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return Task.FromResult((status, template, message));
		}
		public Task<(bool, TemplateReportMapping, string)> DeleteTemplateReportMapping(TemplateReportMapping request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				if (request.template_report_mapping_id.HasValue)
				{
					_masterContext.ArsTblTemplateReportMapping.Remove(new ArsTblTemplateReportMapping
					{
						TemplateReportMappingId = request.template_report_mapping_id.Value,
						SchemaId = request.schema_id,
						FunctionId = request.function_id,
						ReportId = request.report_id,
						ReportDesc = request.report_desc,
						IsActive = request.is_active
					});

					var parameters = _masterContext.ArsTblTemplateParameterMapping
						.Where(w => w.TemplateReportMappingId == request.template_report_mapping_id.Value);
					_masterContext.ArsTblTemplateParameterMapping.RemoveRange(parameters);

					var columns = _masterContext.ArsTblTemplateColumnMapping
						.Where(w => w.TemplateReportMappingId == request.template_report_mapping_id.Value);
					_masterContext.ArsTblTemplateColumnMapping.RemoveRange(columns);

					message = "Delete data successful";

					_masterContext.SaveChanges();
					status = true;
				}
				else
				{
					message = "Delete data fail. Report does not send key to delete.";
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return Task.FromResult((status, request, message));
		}

		public Task<(bool, TemplateReportMapping, string)> ResetTemplateReportMapping(TemplateReportMapping request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				if (request.template_report_mapping_id.HasValue)
				{
					var template = GetTemplateReportMapping(p_template_report_mapping_id: request.template_report_mapping_id).FirstOrDefault();

					if (template != null)
					{
						var parameters = _masterContext.ArsTblTemplateParameterMapping
							.Where(w => w.TemplateReportMappingId == request.template_report_mapping_id.Value);
						_masterContext.ArsTblTemplateParameterMapping.RemoveRange(parameters);

						AddTemplateParameterMapping(template);

						var columns = _masterContext.ArsTblTemplateColumnMapping
							.Where(w => w.TemplateReportMappingId == request.template_report_mapping_id.Value);
						_masterContext.ArsTblTemplateColumnMapping.RemoveRange(columns);

						AddTemplateColumnMapping(template);

						message = "Reset data successful";

						_masterContext.SaveChanges();
						status = true;
					}
					else
					{
						message = "Template does not exist.";
					}
				}
				else
				{
					message = "Reset template fail";
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				message = ex.Message;
			}

			return Task.FromResult((status, request, message));
		}

		public Task<(bool, TemplateReportMapping, string)> RemoveTemplate(TemplateReportMapping request)
		{
			var status = false;
			var data = request;
			var message = string.Empty;
			try
			{
				if (request.template_report_mapping_id.HasValue)
				{
					var template = GetTemplateReportMapping(p_template_report_mapping_id: request.template_report_mapping_id).FirstOrDefault();
	
					if (template != null)
					{
						template.template_name = string.Empty;
						template.template_path = string.Empty;
						var row = _masterContext.ArsTblTemplateReportMapping.Where(w => w.TemplateReportMappingId == template.template_report_mapping_id).FirstOrDefault();
						if (row != null)
						{
							row.TemplateName = template.template_name;
							row.TemplatePath = template.template_path;
							_masterContext.ArsTblTemplateReportMapping.Update(row);
							_masterContext.SaveChanges();
						}
						data = template;
						status = true;
						message = "Remove template successful";
					}
					else
					{
						message = "Template does not exist.";
					}
				}
				else
				{
					message = "Reset template fail";
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				message = ex.Message;
			}

			return Task.FromResult((status, data, message));
		}
		public List<TemplateParameterMapping> GetTemplateParameterMapping(string p_schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null, int? p_parameter_id = null)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_schema_name = p_schema_name,
						p_template_report_mapping_id = p_template_report_mapping_id,
						p_function_id = p_function_id,
						p_report_id = p_report_id,
						p_parameter_id = p_parameter_id
					};
					var data = dbConnection.Query<TemplateParameterMapping>("master.get_template_parameter_mapping", parameters, commandType: CommandType.StoredProcedure);

					return data.OrderBy(o => o.ordinal_position).ToList();

				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, string)> AddTemplateParameterMapping(TemplateReportMapping request)
		{
			var result = false;
			var message = string.Empty;
			var parameters = new List<ArsTblTemplateParameterMapping>();
			try
			{
				var list = GetFunctionParameters(request.schema_name, request.function_name);
				foreach (var item in list)
				{
					parameters.Add(new ArsTblTemplateParameterMapping
					{
						TemplateReportMappingId = request.template_report_mapping_id.Value,
						ParameterName = item.parameter_name,
						ParameterTypeId = GetParameterDataType(item.data_type),
						ParameterUdtName = item.udt_name,
						OrdinalPosition = item.ordinal_position
					});
				}

				_masterContext.ArsTblTemplateParameterMapping.AddRange(parameters);
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, message));
		}
		public Task<(bool, string)> CopyTemplateParameterMapping(TemplateReportMapping source, ArsTblTemplateReportMapping target)
		{
			var result = false;
			var message = string.Empty;
			var parameters = new List<ArsTblTemplateParameterMapping>();
			try
			{
				var list = GetTemplateParameterMapping(p_template_report_mapping_id: source.template_report_mapping_id);
				foreach (var item in list)
				{
					parameters.Add(new ArsTblTemplateParameterMapping
					{
						TemplateReportMappingId = target.TemplateReportMappingId,
						ParameterName = item.parameter_name,
						ParameterTypeId = item.parameter_type_id,
						OrdinalPosition = item.ordinal_position,
						ParameterDefaultValue = item.parameter_default_value,
						ParameterUdtName = item.parameter_udt_name
					});
				}

				_masterContext.ArsTblTemplateParameterMapping.AddRange(parameters);
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, message));
		}
		public Task<(bool, TemplateParameterMapping, string)> RemoveTemplateParameterMapping(TemplateParameterMapping request)
		{
			var result = false;
			var data = request;
			var message = string.Empty;
			try
			{
				_masterContext.ArsTblTemplateParameterMapping.Remove(new ArsTblTemplateParameterMapping
				{
					TemplateParameterMappingId = request.template_parameter_mapping_id,
					TemplateReportMappingId = request.template_report_mapping_id,
					ParameterName = request.parameter_name,
					ParameterTypeId = request.parameter_type_id,
					ParameterDataTypeId = request.parameter_data_type_id,
					ParameterDefaultValue = request.parameter_default_value,
					ParameterSourceId = request.parameter_source_id,
					ParameterSourceColumn = request.parameter_source_column,
					ParameterSourceQuery = request.parameter_source_query,
					IsActive = request.is_active

				});
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, data, message));
		}

		private int GetParameterDataType(string dataTypeName) {
			var list = _masterContext.ArsTblDataType;

			dataTypeName = dataTypeName.ToLower() switch
			{
				"character varying" => "Varchar",
				"timestamp without time zone" =>"Timestamp",
				_ => dataTypeName
			};

			var id = list.FirstOrDefault(w => w.DataTypeName.Equals(dataTypeName, StringComparison.OrdinalIgnoreCase))?.DataTypeId ?? 0;

			return id;
		}

		public Task<(bool, List<TemplateParameterMapping>, string)> SaveTemplateParameterMapping(TemplateReportMapping header, List<TemplateParameterMapping> list)
		{
			var result = false;
			var data = list;
			var message = string.Empty;
			var parameters = new List<ArsTblTemplateParameterMapping>();
			try
			{
				var param_list = GetFunctionParameters(header.schema_name, header.function_name);
				var func_params_name = param_list.Select(s => s.parameter_name).ToArray();
				var params_name = list.Select(s => s.parameter_name).ToArray();

				var except = func_params_name.Except(params_name);
				var exist = func_params_name.Intersect(params_name);

				//foreach (var item in list)
				//{
				//    var record = new ArsTblTemplateParameterMapping
				//    {
				//        TemplateParameterMappingId = item.template_parameter_mapping_id,
				//        TemplateReportMappingId = item.template_report_mapping_id,
				//        ParameterName = item.parameter_name,
				//        ParameterTypeId = item.parameter_type_id,
				//        ParameterDataTypeId = item.parameter_data_type_id,
				//        ParameterDefaultValue = item.parameter_default_value,
				//        ParameterSourceId = item.parameter_source_id,
				//        ParameterSourceColumn = item.parameter_source_column,
				//        ParameterSourceQuery = item.parameter_source_query,
				//        IsActive = item.is_active,
				//        OrdinalPosition = item.ordinal_position
				//    };
				//    parameters.Add(record);
				//}

				if (exist.Count() > 0)
				{
					var params_exist = list.Where(w => exist.Contains(w.parameter_name)).Select(s => new ArsTblTemplateParameterMapping
					{
						TemplateParameterMappingId = s.template_parameter_mapping_id,
						TemplateReportMappingId = s.template_report_mapping_id,
						ParameterName = s.parameter_name,
						ParameterTypeId = s.parameter_type_id,
						ParameterDataTypeId = s.parameter_data_type_id,
						ParameterUdtName = s.parameter_udt_name,
						ParameterDefaultValue = s.parameter_default_value,
						ParameterSourceId = s.parameter_source_id,
						ParameterSourceColumn = s.parameter_source_column,
						ParameterSourceQuery = s.parameter_source_query,
						IsActive = s.is_active,
						OrdinalPosition = s.ordinal_position
					});

					foreach (var param in param_list)
					{
						foreach (var item in params_exist)
						{
							if (param.parameter_name.Equals(item.ParameterName))
							{
								item.ParameterTypeId = GetParameterDataType(param.data_type);
								item.ParameterUdtName = param.udt_name;
							}
						}
					}

					_masterContext.ArsTblTemplateParameterMapping.UpdateRange(params_exist);
				}

				if (except.Count() > 0)
				{
					var params_except = param_list.Where(w => except.Contains(w.parameter_name)).Select(s => new ArsTblTemplateParameterMapping
					{
						TemplateReportMappingId = header.template_report_mapping_id.Value,
						ParameterName = s.parameter_name,
						ParameterTypeId = GetParameterDataType(s.data_type),
						ParameterUdtName = s.udt_name,
						OrdinalPosition = s.ordinal_position
					});

					_masterContext.ArsTblTemplateParameterMapping.AddRange(params_except);
				}

				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, list, message));
		}
		public List<TemplateColumnMapping> GetTemplateColumnMapping(string p_schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null, int? p_column_id = null)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_schema_name = p_schema_name,
						p_template_report_mapping_id = p_template_report_mapping_id,
						p_function_id = p_function_id,
						p_report_id = p_report_id,
						p_column_id = p_column_id
					};
					var data = dbConnection.Query<TemplateColumnMapping>("master.get_template_column_mapping", parameters, commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, string)> AddTemplateColumnMapping(TemplateReportMapping request)
		{
			var result = false;
			var message = string.Empty;
			var parameters = new List<ArsTblTemplateColumnMapping>();
			try
			{
				var list = GetColumnParameters(request.schema_name, request.function_name);
				var ordering = 1;
				foreach (var item in list)
				{
					parameters.Add(new ArsTblTemplateColumnMapping
					{
						TemplateReportMappingId = request.template_report_mapping_id.Value,
						ColumnName = item.parameter_name,
						ColumnDataType = item.data_type,
						ColumnSorting = ordering
					});

					ordering++;
				}

				_masterContext.ArsTblTemplateColumnMapping.AddRange(parameters);
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, message));
		}
		public Task<(bool, string)> CopyTemplateColumnMapping(TemplateReportMapping source, ArsTblTemplateReportMapping target)
		{
			var result = false;
			var message = string.Empty;
			var parameters = new List<ArsTblTemplateColumnMapping>();
			try
			{
				var list = GetTemplateColumnMapping(p_template_report_mapping_id: source.template_report_mapping_id);
				foreach (var item in list)
				{
					parameters.Add(new ArsTblTemplateColumnMapping
					{
						TemplateReportMappingId = target.TemplateReportMappingId,
						ColumnName = item.column_name,
						ColumnDisplay = item.column_display,
						ColumnDataType = item.column_data_type,
						ColumnSorting = item.column_sorting,
						DefaultValue = item.default_value,
						Footer = item.footer,
					});
				}

				_masterContext.ArsTblTemplateColumnMapping.AddRange(parameters);
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, message));
		}
		public Task<(bool, List<TemplateColumnMapping>, string)> AddNewTemplateColumnMapping(List<TemplateColumnMapping> request)
		{
			var result = false;
			var message = string.Empty;
			var data = new List<ArsTblTemplateColumnMapping>();
			try
			{
				//var ordering = 0;
				foreach (var item in request)
				{
					data.Add(new ArsTblTemplateColumnMapping
					{
						TemplateReportMappingId = item.template_report_mapping_id,
						ColumnName = item.column_name,
						ColumnDisplay = item.column_display,
						ColumnDataType = item.column_data_type,
						ColumnSorting = item.column_sorting
					});

					//ordering++;
				}

				_masterContext.ArsTblTemplateColumnMapping.AddRange(data);
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, request, message));
		}
		public Task<(bool, List<TemplateColumnMapping>, string)> SaveTemplateColumnMapping(List<TemplateColumnMapping> list)
		{
			var result = false;
			var data = new List<ArsTblTemplateColumnMapping>();
			var message = string.Empty;
			try
			{
				foreach (var item in list)
				{
					data.Add(new ArsTblTemplateColumnMapping
					{
						TemplateColumnMappingId = item.template_column_mapping_id.Value,
						TemplateReportMappingId = item.template_report_mapping_id,
						ColumnName = item.column_name,
						ColumnDataType = item.column_data_type,
						ColumnSorting = item.column_sorting,
						IsActive = item.is_active
					});
				}
				_masterContext.ArsTblTemplateColumnMapping.UpdateRange(data);
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, list, message));
		}
		public Task<(bool, List<TemplateColumnMapping>, string)> SaveAddNewTemplateColumnMapping(List<TemplateColumnMapping> list)
		{
			var result = false;
			var newData = new List<ArsTblTemplateColumnMapping>();
			var updateData = new List<ArsTblTemplateColumnMapping>();
			var message = string.Empty;
			try
			{
				foreach (var item in list)
				{
					if (item.template_column_mapping_id == null)
					{
						newData.Add(new ArsTblTemplateColumnMapping
						{
							TemplateReportMappingId = item.template_report_mapping_id,
							ColumnName = item.column_name,
							ColumnDataType = item.column_data_type,
							ColumnSorting = item.column_sorting,
							IsActive = item.is_active,
							Footer = item.footer,
							ColumnDisplay = item.column_display.IsNullOrWhiteSpace() ? null : item.column_display,
							DefaultValue = item.default_value.IsNullOrWhiteSpace() ? null : item.default_value
						});
					}
					else
					{
						updateData.Add(new ArsTblTemplateColumnMapping
						{
							TemplateColumnMappingId = item.template_column_mapping_id.Value,
							TemplateReportMappingId = item.template_report_mapping_id,
							ColumnName = item.column_name ?? "",
							ColumnDataType = item.column_data_type,
							ColumnSorting = item.column_sorting,
							IsActive = item.is_active,
							Footer = item.footer,
							ColumnDisplay = item.column_display.IsNullOrWhiteSpace() ? null : item.column_display,
							DefaultValue = item.default_value.IsNullOrWhiteSpace() ? null : item.default_value
						});
					}
				}
				_masterContext.ArsTblTemplateColumnMapping.AddRange(newData);
				_masterContext.ArsTblTemplateColumnMapping.UpdateRange(updateData);
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{	
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, list, message));
		}
		public Task<(bool, TemplateColumnMapping[], string)> DeleteTemplateColumnMapping(TemplateColumnMapping[] requests)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				foreach (var request in requests) {
					if (request.template_column_mapping_id.HasValue) {
						_masterContext.ArsTblTemplateColumnMapping.Remove(new ArsTblTemplateColumnMapping {
							TemplateColumnMappingId = request.template_column_mapping_id.Value,
							TemplateReportMappingId = request.template_report_mapping_id,
							ColumnName = request.column_name,
							ColumnDataType = request.column_data_type,
							ColumnSorting = request.column_sorting,
							ColumnDisplay = request.column_display,
							IsActive = request.is_active
						});
					}
				}
				_masterContext.SaveChanges();
				status = true;
				message = "Delete Successful.";
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, requests, message));
		}
		public Task<(bool, TemplateTriggerPropertiesViewModel, string)> SaveTemplateTrigger(TemplateTriggerPropertiesViewModel item)
		{
			var result = false;
			//var data = new TemplateTrigger();
			var message = string.Empty;
			try
			{
				var weekly = new List<string>();
				if (item.Daily.DaysOfWeek.Monday)
					weekly.Add("MON");
				if (item.Daily.DaysOfWeek.Tuesday)
					weekly.Add("TUE");
				if (item.Daily.DaysOfWeek.Wednesday)
					weekly.Add("WED");
				if (item.Daily.DaysOfWeek.Thursday)
					weekly.Add("THU");
				if (item.Daily.DaysOfWeek.Friday)
					weekly.Add("FRI");
				if (item.Daily.DaysOfWeek.Saturday)
					weekly.Add("SAT");
				if (item.Daily.DaysOfWeek.Sunday)
					weekly.Add("SUN");

				item.Weekly = weekly.ToArray();

				var data = new ArsTblTemplateTrigger
				{
					TemplateSchedName = item.TemplateSchedulerName,
					TemplateTriggerName = item.TemplateTriggerName,
					TemplateTriggerGroup = item.TriggerGroup,
					TemplateFrom = item.TemplateFrom,
					TemplateTo = item.TemplateTo,
					TemplateCc = item.TemplateCc,
					TemplateBcc = item.TemplateBcc,
					TemplateSubject = item.TemplateSubject,
					TemplateBody = item.TemplateBody,
					TabNumber = item.TabNumber,
					DailyType = item.DailyType,
					Minutes = item.Minutes,
					Hours = item.Hours,
					DailyTime = item.DailyTime,
					WeeklyTime = item.WeeklyTime,
					MonthlyTime = item.MonthlyTime,
					Weekly = item.Weekly,
					SelectedDates = item.SelectedDates,
					EndOfMonth = item.EndOfMonth
				};

				if (item.IsNew || item.IsCopy)
				{
					_masterContext.ArsTblTemplateTrigger.Add(data);
				}
				else
				{
					data.TemplateTriggerId = item.TemplateTriggerId.Value;
					_masterContext.ArsTblTemplateTrigger.Update(data);
				}

				_masterContext.SaveChanges();
				if (item.IsNew || item.IsCopy)
					item.TemplateTriggerId = data.TemplateTriggerId;

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, item, message));
		}
		public Task<(bool, TemplateTriggerPropertiesViewModel, string)> DeleteTemplateTrigger(TemplateTriggerPropertiesViewModel item)
		{
			var result = false;
			//var data = new TemplateTrigger();
			var message = string.Empty;
			try
			{
				_masterContext.ArsTblTemplateTrigger.Remove(new ArsTblTemplateTrigger
				{
					TemplateTriggerId = item.TemplateTriggerId.Value,
					TemplateSchedName = item.TemplateSchedulerName,
					TemplateTriggerName = item.TemplateTriggerName,
					TemplateTriggerGroup = item.TriggerGroup,
					TemplateFrom = item.TemplateFrom,
					TemplateTo = item.TemplateTo,
					TemplateCc = item.TemplateCc,
					TemplateBcc = item.TemplateBcc,
					TemplateSubject = item.TemplateSubject,
					TemplateBody = item.TemplateBody
				});
				_masterContext.SaveChanges();

				result = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((result, item, message));
		}
		public Task<(bool, DataTable, string)> GetFunctionData(string query, List<TemplateParameterMapping> parameters, CommandType commandType = CommandType.StoredProcedure) 
		{
			var status = false;
			DataTable data = new DataTable();
			var message = string.Empty;
			try 
			{

				using IDbConnection dbConnection = PDLakeConnection;
				using var cmd = new NpgsqlCommand(query, dbConnection as NpgsqlConnection);
				dbConnection.Open();
				cmd.CommandType = commandType;
				foreach (var parameter in parameters ?? Enumerable.Empty<TemplateParameterMapping>()) 
				{
					// if (parameter.parameter_default_value == null) {
					//     if (parameter.parameter_data_type_id == (int) EnumParamDataType.Array)
					//         parameter.parameter_default_value = "{}";
					//     else if (parameter.parameter_data_type_id == (int) EnumParamDataType.Now)
					//         parameter.parameter_default_value = EnumParamDataType.Now.ToString ().ToLower ();
					//     else if (parameter.parameter_data_type_id == (int) EnumParamDataType.Today)
					//         parameter.parameter_default_value = EnumParamDataType.Today.ToString ().ToLower ();
					//     else if (parameter.parameter_data_type_id == (int) EnumParamDataType.Yesterday)
					//         parameter.parameter_default_value = EnumParamDataType.Yesterday.ToString ().ToLower ();
					//     else if (parameter.parameter_data_type_id == (int) EnumParamDataType.DayMinus7)
					//         parameter.parameter_default_value = $"'{new NpgsqlDateTime(DateTime.Now.AddDays(-7))}'";
					//     else if (parameter.parameter_data_type_id == (int) EnumParamDataType.FirstDayOfWeek)
					//         parameter.parameter_default_value = $"'{new NpgsqlDateTime(DateTime.Now.FirstDayOfWeek(DayOfWeek.Monday))}'";
					//     else if (parameter.parameter_data_type_id == (int) EnumParamDataType.LastDayOfWeek)
					//         parameter.parameter_default_value = $"'{new NpgsqlDateTime(DateTime.Now.LastDayOfWeek(DayOfWeek.Monday))}'";
					//     else if (parameter.parameter_data_type_id == (int) EnumParamDataType.FirstDayOfMonth)
					//         parameter.parameter_default_value = $"'{new NpgsqlDateTime(DateTime.Now.FirstDayOfMonth())}'";
					//     else if (parameter.parameter_data_type_id == (int) EnumParamDataType.LastDayOfMonth)
					//         parameter.parameter_default_value = $"'{new NpgsqlDateTime(DateTime.Now.LastDayOfMonth())}'";
					// }

					var param = new NpgsqlParameter();
					param.ParameterName = parameter.parameter_name;

					//object value = null;
					if (parameter.data_type_name == NpgsqlDbType.Array.ToString() && string.IsNullOrEmpty(parameter.parameter_udt_name)) {
						param.NpgsqlDbType = NpgsqlDbType.Array | NpgsqlDbType.Integer;
						if (string.IsNullOrEmpty(parameter.parameter_default_value) ||
							parameter.parameter_default_value.Trim().Equals("null", StringComparison.OrdinalIgnoreCase))
							param.Value = DBNull.Value;
						else
							param.Value = parameter.parameter_default_value.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
					} else if (parameter.data_type_name == NpgsqlDbType.Array.ToString() && parameter.parameter_udt_name.Trim().Equals("_int4", StringComparison.OrdinalIgnoreCase)) {
						param.NpgsqlDbType = NpgsqlDbType.Array | NpgsqlDbType.Integer;
						if (string.IsNullOrEmpty(parameter.parameter_default_value) ||
							parameter.parameter_default_value.Trim().Equals("null"))
							param.Value = DBNull.Value;
						else
							param.Value = parameter.parameter_default_value.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
					} else if (parameter.data_type_name == NpgsqlDbType.Array.ToString() && parameter.parameter_udt_name.Trim().Equals("_varchar", StringComparison.OrdinalIgnoreCase)) {
						param.NpgsqlDbType = NpgsqlDbType.Array | NpgsqlDbType.Varchar;
						if (string.IsNullOrEmpty(parameter.parameter_default_value) ||
							parameter.parameter_default_value.Trim().Equals("null"))
							param.Value = DBNull.Value;
						else
							param.Value = parameter.parameter_default_value.Split(',').Select(n => n.Trim()).ToArray();
					} else if (parameter.data_type_name == NpgsqlDbType.Array.ToString() && parameter.parameter_udt_name.Trim().Equals("_text", StringComparison.OrdinalIgnoreCase)) {
						param.NpgsqlDbType = NpgsqlDbType.Array | NpgsqlDbType.Text;
						if (string.IsNullOrEmpty(parameter.parameter_default_value) ||
							parameter.parameter_default_value.Trim().Equals("null"))
							param.Value = DBNull.Value;
						else
							param.Value = parameter.parameter_default_value.Split(',').Select(n => n.Trim()).ToArray();
					} else if ((parameter.data_type_name == NpgsqlDbType.Varchar.ToString() /*&& parameter.parameter_udt_name.Trim().Equals("varchar", StringComparison.OrdinalIgnoreCase)*/) ||
							parameter.data_type_name == NpgsqlDbType.Text.ToString()) {
						if (parameter.data_type_name == NpgsqlDbType.Varchar.ToString())
							param.NpgsqlDbType = NpgsqlDbType.Varchar;
						else
							param.NpgsqlDbType = NpgsqlDbType.Text;

						param.NpgsqlDbType = NpgsqlDbType.Varchar;
						if (string.IsNullOrEmpty(parameter.parameter_default_value) ||
							parameter.parameter_default_value.Trim().Equals("null", StringComparison.OrdinalIgnoreCase))
							param.Value = DBNull.Value;
						else
							param.Value = parameter.parameter_default_value;
					} else if (parameter.data_type_name == NpgsqlDbType.Timestamp.ToString()
							|| parameter.data_type_name == NpgsqlDbType.Date.ToString()) {
						DateTime? paramValue = null;
						if (parameter.parameter_data_type_id == (int)EnumParamDataType.Now ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("now", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Now;
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.Today ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("today", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today;
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.Yesterday ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("yesterday", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.AddDays(-1);
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.DayMinus3 ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("dayminus3", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.AddDays(-3);
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.DayMinus7 ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("dayminus7", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.AddDays(-7);
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.DayMinus15 ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("dayminus15", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.AddDays(-15);
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.FirstDayOfWeek ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("firstdayofweek", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.FirstDayOfWeek(DayOfWeek.Monday);
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.LastDayOfWeek ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("lastdayofweek", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.LastDayOfWeek(DayOfWeek.Monday);
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.FirstDayOfMonth ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("firstdayofmonth", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.FirstDayOfMonth();
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.LastDayOfMonth ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("lastdayofmonth", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.LastDayOfMonth();
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.FirstDayOfLastMonth ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("firstdayoflastmonth", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.FirstDayOfLastMonth();
						else if (parameter.parameter_data_type_id == (int)EnumParamDataType.LastDayOfLastMonth ||
							(!string.IsNullOrEmpty(parameter.parameter_default_value) &&
							parameter.parameter_default_value.Trim().Equals("lastdayoflastmonth", StringComparison.OrdinalIgnoreCase)))
							paramValue = DateTime.Today.LastDayOfLastMonth();
						else if (parameter.parameter_data_type_id == 0 ||
							!string.IsNullOrEmpty(parameter.parameter_default_value)) {
							DateTime dateTime = DateTime.MinValue;
							if (DateTime.TryParse(parameter.parameter_default_value, out dateTime)) {	
								paramValue = dateTime;
							} else {
								paramValue = null;
							}
							//else if (param.ParameterName.Contains("from"))
							//    param.Value = new NpgsqlDateTime(DateTime.Today.AddDays(-1));
							//else if (param.ParameterName.Contains("to"))
							//    param.Value = new NpgsqlDateTime(DateTime.Today);
						}

						if (parameter.data_type_name == NpgsqlDbType.Timestamp.ToString()) {
							param.NpgsqlDbType = NpgsqlDbType.Timestamp;
							param.Value = paramValue.HasValue ? (object)new NpgsqlDateTime(paramValue.Value) : (object)DBNull.Value;
						} else {
							param.NpgsqlDbType = NpgsqlDbType.Date;
							param.Value = paramValue.HasValue ? (object)new NpgsqlDate(paramValue.Value) : (object)DBNull.Value;
						}
					} else {
						param.NpgsqlDbType = NpgsqlDbType.Varchar;
						param.Value = DBNull.Value; //parameter.parameter_default_value;
					}

					// param.Value = parameter.parameter_default_value;

					// cmd.Parameters.Add (param);

					cmd.Parameters.Add(param);
				}

				cmd.CommandTimeout = 600; // 10 minutes
				using var reader = cmd.ExecuteReader();
				data.Load(reader);

				foreach (DataColumn dc in data.Columns) {
					if (dc.ColumnName.StartsWith("_dummy_"))
						dc.Caption = "";
				}
				//if (data.Rows.Count > 0)
				//	data = data.AsEnumerable().Distinct(DataRowComparer.Default).CopyToDataTable();

				status = true;
			} catch (Exception ex) {
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, ex.InnerException.Message + " query: " + query);
					message = ex.InnerException.Message;
				} else {
					logger.Error(ex, ex.Message + " query: " + query);
					message = ex.Message;
				}
			}

			return Task.FromResult((status, data, message));
		}

		public List<EmailScheduler> GetEmailScheduler(int? p_email_scheduler_id)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_email_scheduler_id = p_email_scheduler_id
					};
					var data = dbConnection.Query<EmailScheduler>("master.get_email_scheduler", parameters, commandType: CommandType.StoredProcedure);

					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<TemplateTrigger> GetTemplateTrigger(int? template_trigger_id = null, string sched_name = null, string trigger_name = null,
			string trigger_group = null, string template_subject = null,
			string trigger_email = null, string trigger_state = null)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_template_trigger_id = template_trigger_id,
						p_sched_name = sched_name,
						p_trigger_name = '%' + trigger_name + '%',
						p_trigger_group = trigger_group,
						p_template_subject = '%' + template_subject + '%',
						p_template_to = '%' + trigger_email + '%',
						p_trigger_state = trigger_state,
					};
					var data = dbConnection.Query<TemplateTrigger>("master.get_template_trigger", parameters, commandType: CommandType.StoredProcedure);

					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, EmailScheduler, string)> SaveEmailScheduler(EmailScheduler item)
		{
			var status = false;
			var data = item;
			var message = string.Empty;

			try
			{
				if (!item.email_scheduler_id.HasValue)
				{
					var row = new ArsTblEmailScheduler
					{
						EmailSchedulerName = item.email_scheduler_name,
						EmailSchedulerStatusId = item.email_scheduler_status_id,
						EmailCronExpression = item.email_cron_expression,
						EmailTimeZoneId = "SE Asia Standard Time",
						EmailFrom = item.email_from,
						EmailTo = item.email_to,
						EmailCc = item.email_cc,
						EmailBcc = item.email_bcc,
						EmailSubject = item.email_subject,
						EmailBody = item.email_body
					};
					_masterContext.ArsTblEmailScheduler.Add(row);
				}
				else
				{
					var row = new ArsTblEmailScheduler
					{
						EmailSchedulerId = item.email_scheduler_id.Value,
						EmailSchedulerName = item.email_scheduler_name,
						EmailSchedulerStatusId = item.email_scheduler_status_id,
						EmailCronExpression = item.email_cron_expression,
						EmailTimeZoneId = item.email_time_zone_id,
						EmailFrom = item.email_from,
						EmailTo = item.email_to,
						EmailCc = item.email_cc,
						EmailBcc = item.email_bcc,
						EmailSubject = item.email_subject,
						EmailBody = item.email_body
					};
					_masterContext.ArsTblEmailScheduler.Update(row);
				}

				_masterContext.SaveChanges();
				status = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, data, message));
		}
		public List<EmailAttachment> GetEmailAttachment(int? p_email_scheduler_id)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_email_scheduler_id = p_email_scheduler_id
					};
					var data = dbConnection.Query<EmailAttachment>("master.get_email_attachment", parameters, commandType: CommandType.StoredProcedure);

					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public bool SaveEmailAttachment(int id, int[] ids)
		{
			var result = false;
			try
			{
				var all = GetEmailAttachment(id);
				if ((ids == null || ids.Count() == 0) && all.Count() == 0) return result;
				else if ((ids == null || ids.Count() == 0) && all.Count() > 0)
				{
					_masterContext.ArsTblEmailAttachment.RemoveRange(_masterContext.ArsTblEmailAttachment.Where(s => s.EmailSchedulerId == id));
					_masterContext.SaveChanges();
				}
				else
				{
					var values = all.Select(s => s.template_report_mapping_id).ToArray();
					var exist = ids.Intersect(values);
					var rest = values.Except(ids);
					var except = ids.Except(values);

					if ((values == null || values.Length == 0))
						_masterContext.ArsTblEmailAttachment.AddRange(ids.Select(s => new ArsTblEmailAttachment
						{
							EmailSchedulerId = id,
							TemplateReportMappingId = s
						}));
					else if ((except.Count() > 0) && (values != null || values.Length > 0))
						_masterContext.ArsTblEmailAttachment.AddRange(except.Select(s => new ArsTblEmailAttachment
						{
							EmailSchedulerId = id,
							TemplateReportMappingId = s
						}));

					if ((exist == null || exist.Count() == 0) && (values != null || values.Length > 0))
					{
						var list = _masterContext.ArsTblEmailAttachment.Where(s => s.EmailSchedulerId == id && values.Contains(s.TemplateReportMappingId));
						_masterContext.ArsTblEmailAttachment.RemoveRange(list);
					}
					else if (rest != null && values != null && values.Any(c => rest.Contains(c)))
					{
						var list = _masterContext.ArsTblEmailAttachment.Where(s => s.EmailSchedulerId == id && rest.Contains(s.TemplateReportMappingId));

						_masterContext.ArsTblEmailAttachment.RemoveRange(list);
					}

					_masterContext.SaveChanges();
				}
				result = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}
			return result;
		}

		public List<Menu> GetMasterMenu()
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<Menu>("master.get_master_menu", commandType: CommandType.StoredProcedure);
					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<Menu> GetSubMenu(int p_parent_id)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_parent_id = p_parent_id
					};
					var data = dbConnection.Query<Menu>("master.get_sub_menu", param: parameters, commandType: CommandType.StoredProcedure);
					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<Menu> GetPageMenu(int p_parent_id)
		{
			try
			{
				using (IDbConnection dbConnection = ARSConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						p_parent_id = p_parent_id
					};
					var data = dbConnection.Query<Menu>("master.get_page_menu", param: parameters, commandType: CommandType.StoredProcedure);
					var result = data.ToList();
					return result;
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, string)> UpdateMasterColumns()
		{
			throw new System.NotImplementedException();
		}
		public Task<(bool, string)> UpdateMasterSchema()
		{
			throw new System.NotImplementedException();
		}
		public Task<(bool, string)> UpdateMasterTables()
		{
			throw new System.NotImplementedException();
		}
		public List<Customer> GetCustomers(string pwarehouse)
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						pwarehouse = pwarehouse
					};
					var data = dbConnection.Query<Customer>("wh.get_common_customer", param: parameters, commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<StorageType> GetStorageType(string pwarehouse)
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var parameters = new
					{
						pwarehouse = pwarehouse
					};
					var data = dbConnection.Query<StorageType>("wh.get_common_storage_type", param: parameters, commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<StockMaster> GetStock()
		{
			throw new NotImplementedException();
		}
		public List<StockMaster> GetStockMaster()
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<StockMaster>("wh.get_stock_master", commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public List<DCType> GetDCType()
		{
			try
			{
				using (IDbConnection dbConnection = PDLakeConnection)
				{
					dbConnection.Open();
					var data = dbConnection.Query<DCType>("wh.get_common_dc_type", commandType: CommandType.StoredProcedure);
					return data.ToList();
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				return null;
			}
		}
		public Task<(bool, List<TreeView>, string)> GetTreeView()
		{
			var status = false;
			var schemas = _masterContext.ArsTblSchema;
			//var functions = GetFunctions();
			var functions = GetReportsCustomization();
			//var subReports = GetTemplateReportMapping();
			var subReports = GetTemplateReportMappingNew();

			var groups = from row in functions
						 group row by new { schema_id = row.schema_id, group_id = row.group_id, group_name = row.group_name } into grp
						 select new
						 {
							 schema_id = grp.Key.schema_id,
							 group_id = grp.Key.group_id,
							 group_name = grp.Key.group_name
						 };
			//screma
			groups = groups.Where(x=> x.group_id != 0 && x.group_name != null );
			  var data = schemas.Select(s => new TreeView
			{
				id = s.SchemaId,
				Text = s.SchemaDisplay,
				Selectable = false,
				tags = new string[] { "schema", s.SchemaId.ToString() },
				//group
				nodes = groups.Where(wg => wg.schema_id.Equals(s.SchemaId)).Select(gr => new TreeView
				{
					id = gr.group_id,
					Text = gr.group_name,
					//Selectable = false,
					tags = new string[] { "group", gr.group_id.ToString() },

					//function
					nodes = functions.Where(wf => wf.schema_id.Equals(s.SchemaId) && wf.group_id.Equals(gr.group_id)).Select(sr => new TreeView
					{
						id = sr.group_id,
						function = sr.function_name,
						Text = sr.report_name,//$"{sr.report_name}({sr.function_name})",
											  //ShowAddButton = true,
						tags = new string[] { "function", sr.function_id.ToString() },
						data = new TemplateReportMapping
						{
							schema_id = sr.schema_id,
							schema_name = sr.schema_name,
							group_id = sr.group_id,
							group_name = sr.group_name,
							function_name = sr.function_name,
							report_name = sr.report_name
						},
                        nodes = subReports.Where(wc => wc.group_id.Equals(sr.group_id) && wc.function_name.Equals(sr.function_name)).Select(sc => new TreeView
                        {
                            id = sc.template_report_mapping_id.Value,
                            Text = sc.report_desc,
                            //ShowEditButton = true,
                            //ShowCopyButton = true,
                            //ShowRemoveButton = true,
                            tags = new string[] { "subreport", sc.template_report_mapping_id.ToString() },
                            data = sc
                        }).ToList()
                    }).ToList()
				}).ToList()
			}).ToList();


			var message = string.Empty;
			try
			{
				status = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
			}

			return Task.FromResult((status, data, message));
		}
		public Task<(bool, StockMaster, string)> SaveStock(StockMaster request)
		{
			var status = false;
			var message = string.Empty;
			try
			{
				if (request.stockmaster_id == null)
				{
					//int count = _whContext.TbmStockmaster.Count();
					_whContext.TbmStockmaster.Add(new TbmStockmaster
					{
						DcType = request.dc_type,
						CustomerId = request.customer_id,
						StorageTypeId = request.storage_type_id,
						LocationAreaM3 = Convert.ToDecimal(request.location_area_m3),
						LocationCharge = Convert.ToDecimal(request.location_charge),
						LocationPlan = request.location_plan,
						EffectiveDate = request.effective_date
						//is_deleted = false
					}); ; ;
				}
				else
				{
					_whContext.TbmStockmaster.Update(new TbmStockmaster
					{
						DcType = request.dc_type,
						CustomerId = request.customer_id,
						StorageTypeId = request.storage_type_id,
						LocationAreaM3 = Convert.ToDecimal(request.location_area_m3),
						LocationCharge = Convert.ToDecimal(request.location_charge),
						LocationPlan = request.location_plan,
						EffectiveDate = request.effective_date
					}); ; ;
				}

				_whContext.SaveChanges();
				status = true;
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					message = ex.InnerException.Message;
					logger.Error(ex.InnerException, ex.InnerException.Message);
				}
				else
				{
					message = ex.Message;
					logger.Error(ex, ex.Message);
				}
			}

			return Task.FromResult((status, request, message));
		}
		public Task<(bool, string)> DeleteStock(int? StockID)
		{
			var status = false;
			var message = string.Empty;

			try
			{
				using (IDbConnection dbConnection = PDLakeWConnection)
				{
					var parameters = new
					{
						StockID = StockID
					};
					dbConnection.Open();
					var data = dbConnection.Execute("SELECT wh.delete_stock_master(@StockID)", param: parameters, commandType: CommandType.Text);
					status = true;
					message = "Delete record Successful!";
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				message = ex.Message;

			}

			return Task.FromResult((status, message));
		}
		public Task<(bool, string)> saveUpload(List<StockMaster> list)
		{
			var status = false;
			var message = string.Empty;
			var dataUpload = JsonSerializer.Serialize(list);

			try
			{
				using (IDbConnection dbConnection = PDLakeWConnection)
				{
					var parameters = new
					{
						dataUpload = dataUpload
					};
					dbConnection.Open();
					var data = dbConnection.Execute("SELECT wh.save_stock_master(@dataUpload::json)", param: parameters, commandType: CommandType.Text);
					status = true;
					message = "Upoad Success!";
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex, ex.Message);
				message = ex.Message;

			}
			return Task.FromResult((status, message));
		}

		public PowerBIEmbeddedViewModel GetPowerBI(string reportName) {
			try {
				using IDbConnection dbConnection = ARSConnection;
				dbConnection.Open();
				var data = dbConnection.QueryFirstOrDefault<PowerBIEmbeddedViewModel>($"select report_id AS ReportId from master.ars_tbl_powerbi_embed where report_name='{reportName}'", commandType: CommandType.Text);
				return data;
				
			} catch (Exception ex) {
				logger.Error(ex, ex.Message);
				return new PowerBIEmbeddedViewModel();
			}
		}
	}

	internal class ColumnSelectionComparer : IEqualityComparer<RawColumn>
	{
		public bool Equals(RawColumn x, RawColumn y)
		{
			if (string.Equals(x.column_name, y.column_name, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			return false;
		}

		public int GetHashCode(RawColumn obj)
		{
			return obj.column_name.GetHashCode();
		}
	}

	


}

//var data = schemas.Select(s => new TreeView
//{
//    id = s.SchemaId,
//    Text = s.SchemaDisplay,
//    Selectable = false,
//    tags = new string[] { "schema", s.SchemaId.ToString() },
//    nodes = functions.Where(wf => wf.schema_id.Equals(s.SchemaId)).Select(sr => new TreeView
//    {
//        id = sr.function_id.Value,
//        Text = sr.report_name,//$"{sr.report_name}({sr.function_name})",
//        ShowAddButton = true,
//        tags = new string[] { "function", sr.function_id.ToString() },
//        data = new TemplateReportMapping
//        {
//            schema_id = sr.schema_id,
//            schema_name = sr.schema_name,
//            schema_display = sr.schema_display,
//            catalog_name = sr.catalog_name,
//            schema_owner = sr.schema_owner,
//            schema_order = sr.schema_order,
//            function_id = sr.function_id.Value,
//            function_name = sr.function_name,
//            report_id = sr.report_id,
//            report_name = sr.report_name
//        },
//        nodes = subReports.Where(wc => wc.report_id.Equals(sr.report_id) && wc.function_id.Equals(sr.function_id)).Select(sc => new TreeView
//        {
//            id = sc.template_report_mapping_id.Value,
//            Text = sc.report_desc,
//            ShowEditButton = true,
//            ShowCopyButton = true,
//            ShowRemoveButton = true,
//            tags = new string[] { "subreport", sc.template_report_mapping_id.ToString() },
//            data = sc
//        }).ToList()
//    }).ToList()
//}).ToList();