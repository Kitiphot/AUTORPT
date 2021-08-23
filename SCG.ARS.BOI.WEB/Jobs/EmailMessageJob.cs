using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Quartz;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Services;

namespace SCG.ARS.BOI.WEB.Jobs
{
    [DisallowConcurrentExecution]
    public class EmailMessageJob : IJob
    {
        private readonly ILogger<EmailMessageJob> _logger;
        private readonly HttpContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        private static IEmailMessageService _mailService;
        private IReportRepository _report;
        private IFunctionTemplateRepository _template;
        private string _tempPath;
        public EmailMessageJob(ILogger<EmailMessageJob> logger,
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IReportRepository report,
            IFunctionTemplateRepository template,
            IEmailMessageService mailService)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _report = report;
            _template = template;
            _mailService = mailService;
            _tempPath = Path.GetTempPath();
        }

        public Task Execute(IJobExecutionContext context)
        {
            var status = false;
            Stream stream = null;
            var message = string.Empty;
            try
            {
                _logger.LogInformation("Email message job execute!");
                //Console.WriteLine ($"{DateTime.Now}: Email message job start");
                var date = DateTime.Today.AddDays(-1);
                var emailMapping = _template.GetEmailReportMapping();
                var columnTemplate = _template.GetColumnTemplate();
                var templates = _template.GetCustomerTemplate();
                var data = new DataTable();
                List<Attachment> attachs = new List<Attachment>();
                List<string> emails = emailMapping.Where(w => w.template_id == 1).Select(s => s.email_address).ToList();

                foreach (var template in templates)
                {
                    //var emailMapping = _template.GetEmailReportMapping ();
                    string sWebRootFolder = _hostingEnvironment.WebRootPath;
                    string saveFileName = $"{template.template_name}_{date.ToString("yyyyMMdd")}.xlsx";
                    string sFileName = template.template_path;

                    string path = Path.Combine(sWebRootFolder, "Templates");
                    FileInfo file = new FileInfo(Path.Combine(path, sFileName));

                    string savePath = Path.Combine(_tempPath, "Temp");
                    FileInfo fileSave = new FileInfo(Path.Combine(savePath, saveFileName));
                    if (!Directory.Exists(savePath)) Directory.CreateDirectory(savePath);

                    var customers = new List<int>();
                    customers.Add(template.customer_id);
                    var dc_list = new List<int>();

                    if (template.report_id == 1)
                        data = _report.GetReport01(null, null, dc_list, customers);
                    else if (template.report_id == 3)
                        data = _report.GetReport03(null, null, dc_list, customers);

                    var columns = columnTemplate.Where(w => w.template_id == template.template_id).OrderBy(o => o.column_id).Select(s => $"\"{s.column_name}\"").ToArray();

                    Task.Factory.StartNew(async () =>
                    {
                        (status, stream, message) = await ExcelHelper.GetExcelFromTemplate(data, file, columns, 0);
                    }).Wait();


                    if (stream != null)
                    {
                        Attachment attachment = new Attachment(stream, new ContentType(MediaTypeNames.Application.Octet));

                        attachment.ContentDisposition.FileName = fileSave.Name;
                        attachment.ContentDisposition.Size = stream.Length;

                        attachs.Add(attachment);
                    }
                }

                string subject = $"[Test][Warehouse][CDC & DC Rangsit] - รายงานรวม วันที่ {date.ToString("dd/MM/yyyy")}";
                string body = subject; //$"รายงานรวมทดสอบ ประจำวันที่ {date.ToString("dd MMM yyyy")}";

                _mailService.SendMailMessage(
                    new string[] { "chainimit@csigroups.com"},//emails.ToArray(), 
                    subject,
                    body,
                    attachs);

                Console.WriteLine($"send mail to {string.Join(',', emails.Select(s => s))}");
                Console.WriteLine($"{subject}: message sent");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return Task.CompletedTask;
        }
    }
}