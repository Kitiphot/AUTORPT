using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Npgsql;
using Quartz;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Services;

namespace SCG.ARS.BOI.WEB.Jobs
{
	[DisallowConcurrentExecution]
	public class EmailSchedulerJob : IJob
	{
		private readonly ILogger<EmailSchedulerJob> _logger;
		private readonly HttpContext _context;
		private readonly IHostingEnvironment _hostingEnvironment;
		private static IEmailMessageService _mailService;
		private IReportRepository _report;
		private IMasterRepository _master;
		private IFunctionTemplateRepository _template;
		private string _tempPath;

		static NLog.Logger debugLog = NLog.LogManager.GetLogger("DebugLog");

		public EmailSchedulerJob(ILogger<EmailSchedulerJob> logger,
			IHttpContextAccessor httpContextAccessor,
			IHostingEnvironment hostingEnvironment,
			IReportRepository report,
			IMasterRepository master,
			IFunctionTemplateRepository template,
			IEmailMessageService mailService)
		{
			_logger = logger;
			_hostingEnvironment = hostingEnvironment;
			_context = httpContextAccessor.HttpContext;
			_report = report;
			_master = master;
			_template = template;
			_mailService = mailService;
			_tempPath = Path.GetTempPath();
		}

		public Task Execute(IJobExecutionContext context)
		{
			var status = false;
			Stream stream = null;
			var message = string.Empty;
			var data = new DataTable();
			try
			{
				_logger.LogInformation("Email scheduler job execute!");
				Debug.WriteLine($"{DateTime.Now}: Email message job start");
				JobKey key = context.JobDetail.Key;

				//JobDataMap dataMap = context.JobDetail.JobDataMap;
				var scheduler = context.Scheduler;
				var sched_name = scheduler.SchedulerName;
				//var sched_name = "QuartzScheduler";
				var trigger = (Quartz.Impl.Triggers.AbstractTrigger)context.Trigger;
				var trigger_name = trigger.Name;
				//var trigger_name = "IM/EX ปูนเม็ด SCG ภาคใต้";
				var job_key = trigger.JobKey;
				var job_group = job_key.Group;
				//var job_group = "DEFAULT";
				var job_name = job_key.Name;
				var scdDataMap = context.Trigger.JobDataMap;
				//var id = scdDataMap.Get("email_scheduler_id") as string;

				var model = _master.GetTemplateTrigger(sched_name: sched_name, trigger_name: trigger_name, trigger_group: job_group).FirstOrDefault();

				if (model != null)
				{
					//if (!string.IsNullOrEmpty(id)) {
					//var p_email_scheduler_id = Convert.ToInt32(id);
					//var model = _master.GetEmailScheduler(p_email_scheduler_id).FirstOrDefault();

					debugLog.Info($"before get list of attachment for job '{model.template_trigger_name}'");
					var email_attachements = _master.GetEmailAttachment(model.template_trigger_id);

					debugLog.Info($"got {email_attachements.Count} attaches for job '{model.template_trigger_name}'");
					List<Attachment> attachs = new List<Attachment>();

					foreach (var attachment in email_attachements)
					{

						debugLog.Info($"before get report data for job '{model.template_trigger_name}'");
						var report = _master.GetTemplateReportMapping(p_template_report_mapping_id: attachment.template_report_mapping_id).FirstOrDefault();

						if (report != null)
						{
							debugLog.Info($"before get sql parameter for job '{model.template_trigger_name}'");
							var parameters = _master.GetTemplateParameterMapping(p_template_report_mapping_id: attachment.template_report_mapping_id);

							//var function_name = $"{attachment.schema_name}.{attachment.function_name}";
							//var data = _master.GetFunctionData(function_name, parameters);

							var columns = _master.GetTemplateColumnMapping(p_template_report_mapping_id: report.template_report_mapping_id);
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
							var sql = $"SELECT {string.Join(',', columnNames)} FROM {report.schema_name}.{report.function_name}({string.Join(',', paramList)});";

							debugLog.Info($"before get data for job '{model.template_trigger_name}' with sql: {sql}");
							Task.Factory.StartNew(async () =>
							{
								(status, data, message) = await _master.GetFunctionData(sql, parameters, CommandType.Text);
							}).Wait();

							debugLog.Info($"finish get data for job '{model.template_trigger_name}' with sql: {sql}");

							string sWebRootFolder = _hostingEnvironment.WebRootPath;
							string saveFileName = $"{report.report_desc}_{DateTime.Now:yyyyMMddHHmmsss)}.xlsx";

							string path = Path.Combine(sWebRootFolder, "Templates");
							FileInfo file = null;
							try {
								if (!string.IsNullOrEmpty(report.template_path))
									file = new FileInfo(report.template_path);
							} catch(Exception ex) {
								_logger.LogError(ex, $"Email Scheduler: {ex.Message}");
								file = null;
							}

							string savePath = Path.Combine(_tempPath, "Temp", report.template_report_mapping_id.ToString());
							if (!Directory.Exists(savePath)) Directory.CreateDirectory(savePath);

							FileInfo fileSave = new FileInfo(Path.Combine(savePath, saveFileName));

							//var filePath = $"Temp/{ report.template_report_mapping_id.ToString()}/{ saveFileName}";

							debugLog.Info($"before export {model.template_trigger_name}");
							Task.Factory.StartNew(async () =>
							{
								if (file != null)
								{
									debugLog.Info($"call export '{model.template_trigger_name}' with template {file.Name}");
									(status, stream, message) = await ExcelHelper.GetExcelFromTemplate(data, file, displayNames, 0, footers);
								}
								else
								{
									debugLog.Info($"call export '{model.template_trigger_name}' (no template)");
									(status, stream, message) = await ExcelHelper.GetExcelFromDataTable(data);
								}
							}).Wait();

							debugLog.Info("excel finish");
							if (!status || stream == null || !string.IsNullOrWhiteSpace(message))
							{
								debugLog.Info($"E-mail attachment id: {attachment.email_attachment_id} for report {model.template_trigger_name} cannot generate excel: {message}");

								_logger.LogError($"E-mail attachment id: {attachment.email_attachment_id} for report {model.template_trigger_name} cannot generate excel: {message}");
							}

							if (stream != null)
							{
								Attachment attach = new Attachment(stream, new ContentType(MediaTypeNames.Application.Octet));

								attach.ContentDisposition.FileName = $"{attachment.report_desc.Replace("/", "-")}.xlsx";
								attach.ContentDisposition.Size = stream.Length;

								attachs.Add(attach);
							}  //if (File.Exists(fileSave.FullName))
							   //    attachs.Add(new Attachment(fileSave.FullName));
							   //}
						}
						else
							_logger.LogError($"E-mail attachment id: {attachment.email_attachment_id} for report {model.description} is not found.");
					}

					//dataMap.
					//String jobSays = dataMap.getString("jobSays");
					//float myFloatValue = dataMap.getFloat("myFloatValue");

					//System.err.println("Instance " + key + " of DumbJob says: " + jobSays + ", and val is: " + myFloatValue);

					var date = DateTime.Today.AddDays(-1);
					//var emailMapping = _template.GetEmailReportMapping ();
					//var columnTemplate = _template.GetColumnTemplate ();
					//var templates = _template.GetCustomerTemplate ();
					//var data = new DataTable ();
					string pattern = "[;,]+";
					string[] emails = Regex.Split(model.template_to, pattern);// model.template_to.Split(";");
					string[] ccs = string.IsNullOrEmpty(model.template_cc) ? null : Regex.Split(model.template_cc, pattern);
					string[] bccs = string.IsNullOrEmpty(model.template_bcc) ? null : Regex.Split(model.template_bcc, pattern);
					string subject = model.template_subject;
					string body = model.template_body;

					//foreach (var template in templates) {
					//    //var emailMapping = _template.GetEmailReportMapping ();
					//    string sWebRootFolder = _hostingEnvironment.WebRootPath;
					//    string saveFileName = $"{template.template_name}_{date.ToString("yyyyMMdd")}.xlsx";
					//    string sFileName = template.template_path;

					//    string path = Path.Combine (sWebRootFolder, "Templates");
					//    FileInfo file = new FileInfo (Path.Combine (path, sFileName));

					//    string savePath = Path.Combine (sWebRootFolder, "Temp");
					//    FileInfo fileSave = new FileInfo (Path.Combine (savePath, saveFileName));
					//    if (!Directory.Exists(savePath))
					//        Directory.CreateDirectory(savePath);

					//    var customers = new List<int>();
					//    customers.Add(template.customer_id);
					//    var dc_list = new List<int>();

					//    if (template.report_type_id == 1)
					//        data = _report.GetReport01 (null, null, dc_list, customers);
					//    else if (template.report_type_id == 3)
					//        data = _report.GetReport03 (null, null, dc_list, customers);

					//    //var columns = data.Columns.Cast<DataColumn> ().Select (x => x.ColumnName).ToArray ();
					//    var columns = columnTemplate.Where (w => w.template_id == template.template_id).OrderBy (o => o.column_id).Select (s => s.column_name).ToArray ();

					//    Stream stream = ExcelHelper.GetExcelFromTemplate (data, fileSave, file, columns, 0);
					//    //if (File.Exists(fileSave.FullName))
					//    //    attachs.Add(new Attachment(fileSave.FullName));

					//    if (stream != null)
					//    {
					//        Attachment attachment = new Attachment(stream, new ContentType(MediaTypeNames.Application.Octet));

					//        attachment.ContentDisposition.FileName = fileSave.Name;
					//        attachment.ContentDisposition.Size = stream.Length;

					//        attachs.Add(attachment);
					//        //attachs.Add(new Attachment(stream, fileSave.Name, System.Net.Mime.MediaTypeNames.Application.op));
					//    }

					//    //List<string> emails = emailMapping.Where (w => w.template_id == template.template_id).Select (s => s.email_address).ToList ();

					//    // string subject = $"{template.report_name} {template.customer_name} ประจำวันที่ {date.ToString("dd MMM yyyy")}";
					//    // string body = $"{template.report_name} {template.customer_name} ประจำวันที่ {date.ToString("dd MMM yyyy")}";

					//    //Console.WriteLine ($"send mail to {string.Join(',', emails.Select(s=>s))}");
					//    Console.WriteLine ($"columns {string.Join(',', columns.Select(s=>s))}");
					//    // Console.WriteLine ($"{subject}: message sent");

					//    // _mailService.SendMailMessage (
					//    //     emails.ToArray(),
					//    //     subject,
					//    //     body,
					//    //     attachs);

					//    if (File.Exists (fileSave.FullName)) {
					//         //File.Delete (fileSave.FullName);
					//    }
					//}

					//// string subject = $"รายงานรวมทดสอบ ประจำวันที่ {date.ToString("dd MMM yyyy")}";
					//// string body = $"รายงานรวมทดสอบ ประจำวันที่ {date.ToString("dd MMM yyyy")}";

					//string subject = $"[Test][Warehouse][CDC & DC Rangsit] - รายงานรวม วันที่ {date.ToString("dd/MM/yyyy")}";
					//string body = subject; //$"รายงานรวมทดสอบ ประจำวันที่ {date.ToString("dd MMM yyyy")}";

					//if(email_attachements.Count != attachs.Count) {
					if (attachs.Count == 0 && email_attachements.Count > 0) {
						body = "Error to generate excel file. Please contact admin";
					}

					_mailService.SendMailMessage(
						emails.ToArray(),
						subject,
						body,
						attachs,
						ccs,
						bccs);

					//Console.WriteLine ($"send mail to {string.Join(',', emails.Select(s=>s))}");
					//Console.WriteLine ($"{subject}: message sent");
				}
				else
				{
					_logger.LogWarning($"Email Scheduler missing id to get scheduler");
				}
			}
			catch (Exception ex)
			{
				message = ex.Message;
				_logger.LogError(ex, $"Email Scheduler: {ex.Message}");
			}
			return Task.CompletedTask;
		}
	}
}