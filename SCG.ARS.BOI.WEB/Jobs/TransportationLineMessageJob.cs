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

namespace SCG.ARS.BOI.WEB.Jobs {
	[DisallowConcurrentExecution]
	public class TransportationLineMessageJob : IJob {
		private readonly ILogger<LineMessage2Job> _logger;
		private readonly ILineMessageService _lineMessageService;

		private readonly HttpContext _context;
		private readonly IHostingEnvironment _hostingEnvironment;
		private IReportRepository _report;
		private IFunctionTemplateRepository _template;

		public TransportationLineMessageJob(ILogger<LineMessage2Job> logger,
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
			_logger.LogInformation("Line Message Job Execute!");
			Debug.WriteLine($"{DateTime.Now}: Line Message Job");

			string message = "";

			var data = _report.GetTransportationLineMessage01();

			var groups = data.GroupBy(g => g.message_id);
			foreach (var group in groups) {
				var filter = data.Where(w => w.message_id == group.Key).OrderBy(o => o.line_no) ;
				foreach (var line in filter) {
					message += $@"
{line.message}";
				}
				_lineMessageService.SendNotify(message);
				message = "";
			}

			Debug.WriteLine(message);
			return Task.CompletedTask;
		}
	}
}