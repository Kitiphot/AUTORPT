using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Quartz;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Services;
using System.Drawing;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Jobs {
	[DisallowConcurrentExecution]
	public class SKICOverallFleetImageLineMessageJob : IJob {
		private readonly ILogger<SKICOverallFleetImageLineMessageJob> _logger;
		private readonly ILineMessageService _lineMessageService;

		private readonly HttpContext _context;
		private readonly IHostingEnvironment _hostingEnvironment;
		private IReportRepository _report;
		private IFunctionTemplateRepository _template;

		public SKICOverallFleetImageLineMessageJob(ILogger<SKICOverallFleetImageLineMessageJob> logger,
			IHttpContextAccessor httpContextAccessor,
			IHostingEnvironment hostingEnvironment,
			IReportRepository report,
			IFunctionTemplateRepository template,
			ILineMessageService lineMessageService) {
			_logger = logger;
			_hostingEnvironment = hostingEnvironment;
			_context = httpContextAccessor.HttpContext;
			_report = report;
			_template = template;
			_lineMessageService = lineMessageService;
		}

		public Task Execute(IJobExecutionContext context) {
			_logger.LogInformation("SKIC Overall Fleet Image Line Message Job Execute!");
			Debug.WriteLine($"{DateTime.Now}: SKIC Overall Fleet Image Line Message Job");

			string message = "";
			var dataDate = DateTime.Today;
			var data = _report.RPTPKG002_OverallFleetDomesticsReport(dataDate.ToString("yyyy-MM-dd"), dataDate.ToString("yyyy-MM-dd"), 20);
			var headerField = new Dictionary<string, string>() {
				{ "fleet", "Fleet" },
				{ "truck_type", "Truck Type" },
				{ "truck_commit", "Commit" },
				{ "pending_count", "Order คงค้างวันก่อนหน้า" },
				{ "order_count", "Order วันนี้" },
				{ "book_count", "จองคิว (คัน)" },
				{ "accept_count", "ได้งาน (คัน)" },
				{ "truck_wait", "รถเหลือ (คัน)" }
			};
			var result = _lineMessageService.SendImage(
				ListToTableImage(data, headerField, $"Overall fleet domestic {dataDate: yyyy-MM-dd}"),
				 $"Overall fleet domestic {dataDate: dd/MM}");

			//			var groups = data.GroupBy(g => g.message_id);
			//			foreach (var group in groups) {
			//				var filter = data.Where(w => w.message_id == group.Key).OrderBy(o => o.line_no) ;
			//				foreach (var line in filter) {
			//					message += $@"
			//{line.message}";
			//				}
			//				_lineMessageService.SendNotify(message);
			//				message = "";
			//			}
			if (!string.IsNullOrEmpty(result)) {
				_logger.LogError(result);
			}
			Debug.WriteLine(message);
			return Task.CompletedTask;
		}

		private Image ListToTableImage<T>(IList<T> list, Dictionary<string, string> columnHeader, string tableHeader) {
			var objType = typeof(T);
			using Bitmap bmp = new Bitmap(1920, 1080);
			var font = new Font("Verdana", 12, FontStyle.Regular);
			var g = Graphics.FromImage(bmp);
			g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			

			float imageOffsetX = 10;
			float imageOffsetY = 10;
			float columnHeaderOffset = 50;
			float imageHeaderOffset = 50;
			float textHeightVariant = 3;
			float leftRightPadding = 5;
			float topBottomPadding = 5;
			float offsetX = imageOffsetX;
			float offsetY = imageOffsetY;
			SizeF textSize;

			foreach (var prop in objType.GetProperties()) {
				float maxColWidth = 0;
				float fixColHeight = 0;
				int idx = 0;

				offsetY = imageOffsetY + imageHeaderOffset;

				var headerText = columnHeader[prop.Name];
				textSize = g.MeasureString(headerText, font);

				if (textSize.Width > maxColWidth)
					maxColWidth = textSize.Width;

				// draw column header text
				g.DrawString(headerText, font, Brushes.Black, 
					new PointF(leftRightPadding + offsetX, topBottomPadding + offsetY + (columnHeaderOffset - textSize.Height) / 2));

				offsetY += (topBottomPadding * 2 + columnHeaderOffset);

				// draw text each row
				for (; idx < list.Count; idx++) {
					string fieldVal = Convert.ToString(prop.GetValue(list[idx]));
					textSize = g.MeasureString(fieldVal, font);

					if (textSize.Width > maxColWidth)
						maxColWidth = textSize.Width;

					if (fixColHeight == 0)
						fixColHeight = textSize.Height + textHeightVariant;

					g.DrawString(fieldVal, font, Brushes.Black, 
						new PointF(leftRightPadding + offsetX, topBottomPadding + offsetY + (fixColHeight - textSize.Height) / 2));
					offsetY += (topBottomPadding * 2 + fixColHeight);
				}

				float offsetYForBorder = offsetY;
				for (; idx > 0; idx--) {
					offsetYForBorder -= (fixColHeight + topBottomPadding * 2);
					g.DrawRectangle(Pens.Black, offsetX, offsetYForBorder, maxColWidth + leftRightPadding * 2, fixColHeight + topBottomPadding * 2);
				}

				offsetYForBorder -= (columnHeaderOffset + topBottomPadding * 2);
				g.DrawRectangle(Pens.Black, offsetX, offsetYForBorder, maxColWidth + leftRightPadding * 2, columnHeaderOffset + topBottomPadding * 2);
				offsetX += (leftRightPadding * 2 + maxColWidth);
			}

			offsetX += imageOffsetX;
			offsetY += imageOffsetY;

			textSize = g.MeasureString(tableHeader, font);
			g.DrawString(tableHeader, font, Brushes.Black,
				new PointF((offsetX - textSize.Width) / 2, topBottomPadding + imageOffsetY + (imageHeaderOffset - textSize.Height) / 2));

			Bitmap result = new Bitmap((int)Math.Ceiling(offsetX), (int)Math.Ceiling(offsetY));
			g = Graphics.FromImage(result);
			g.DrawImage(bmp, 0, 0);
			return result;
		}
	}
}