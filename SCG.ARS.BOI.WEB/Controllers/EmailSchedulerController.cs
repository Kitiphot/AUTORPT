using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog;
using Quartz;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Schedule;

namespace SCG.ARS.BOI.WEB.Controllers
{
    [Authorize]
    public class EmailSchedulerController : Controller
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        private ILogger<EmailSchedulerController> _logger;
        private readonly HttpContext _context;
        private IMasterRepository _data;
        private readonly IHostingEnvironment _hostingEnvironment;
        private static SmtpSetting _config;
        private static SmtpClientEx _smtpClient;
        private StdSchedulerFactoryEx _factory;
        public EmailSchedulerController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IOptions<SmtpSetting> config,
            SmtpClientEx smtpClient,
            IMasterRepository data,
            ISchedulerFactory factory)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _config = config.Value;
            _smtpClient = smtpClient;
            _data = data;
            _factory = (StdSchedulerFactoryEx)factory;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View(_config);
        }

        [HttpPost]
        public ActionResult LoadEmailScheduler()
        {
            try
            {
                var data = _data.GetEmailScheduler(null);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        //[HttpPost]
        //public ActionResult LoadTemplateTrigger()
        //{
        //    try
        //    {
        //        var data = _data.GetTemplateTrigger(null);
        //        return Json(new { data = data, status = true, message = "Successful" });
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex, ex.Message);
        //        return Json(new { status = false, message = "Fail" });
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> SaveEmailScheduler(EmailScheduler item)
        {
            var status = false;
            var data = item;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.SaveEmailScheduler(item);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);

            }

            return Json(new { status = status, data = data, message = message });
        }

        [HttpPost]
        public ActionResult LoadSchemas()
        {
            try
            {
                var data = _data.GetSchemas();
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult LoadTemplateReportMapping(string schema)
        {
            try
            {
                var data = _data.GetTemplateReportMapping(schema);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Run(EmailScheduler model)
        {
            try
            {
                var jobDataMap = new JobDataMap();
                jobDataMap.Put("email_scheduler_id", model.email_scheduler_id.ToString());

                var builder = TriggerBuilder.Create()
                        .WithIdentity(new TriggerKey(model.email_scheduler_name, "DEFAULT"))
                        .ForJob("EmailSchedulerJob")
                        .UsingJobData(jobDataMap)
                        .WithDescription(model.email_subject)
                        .WithPriority(1);

                builder.StartAt(DateTime.UtcNow.AddMinutes(1));
                builder.EndAt(DateTime.UtcNow.AddDays(1));

                //if (!string.IsNullOrEmpty(triggerModel.CalendarName))
                //    builder.ModifiedByCalendar(triggerModel.CalendarName);

                //builder.WithCronSchedule(model.email_cron_expression);
                builder.WithCronSchedule("0/5 * * * * ?");

                var trigger = builder.Build();
                var scheduler = _factory.Scheduler;

                await scheduler.ScheduleJob(trigger);

                //await Scheduler.RescheduleJob(new TriggerKey(triggerModel.OldTriggerName, triggerModel.OldTriggerGroup), trigger);



                //var builder = TriggerBuilder.Create()
                //        .WithIdentity(new TriggerKey("test trigger", "Test"))
                //        .ForJob("HelloWorldJob")
                //        //.UsingJobData(jobDataMap.GetQuartzJobDataMap())
                //        .WithDescription("test")
                //        .WithPriority(1);

                //builder.StartAt(DateTime.UtcNow);
                //builder.EndAt(DateTime.UtcNow.AddDays(1));

                ////if (!string.IsNullOrEmpty(triggerModel.CalendarName))
                ////    builder.ModifiedByCalendar(triggerModel.CalendarName);

                //builder.WithCronSchedule("0/5 * * * * ?");

                //var trigger = builder.Build();
                //var scheduler = _factory.Scheduler;


                //await scheduler.ScheduleJob(trigger);

                ////await Scheduler.RescheduleJob(new TriggerKey(triggerModel.OldTriggerName, triggerModel.OldTriggerGroup), trigger);


                return Json(new { status = true, data = model, message = "Success" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> Pause(EmailScheduler model)
        {
            try
            {
                return Json(new { status = true, data = model, message = "Success" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }

        }
    }
}
