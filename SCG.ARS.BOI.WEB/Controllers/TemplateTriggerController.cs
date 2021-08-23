using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog;
using Quartz;
using Quartz.Impl.Matchers;
using Quartz.Plugins.RecentHistory;
using Quartzmin.Helpers;
using Quartzmin.Models;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Schedule;
using SCG.ARS.BOI.WEB.ViewModels;

namespace SCG.ARS.BOI.WEB.Controllers
{
    [Authorize]
    public class TemplateTriggerController : Controller
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        private readonly HttpContext _context;
        private IMasterRepository _data;
        private readonly IHostingEnvironment _hostingEnvironment;
        private static SmtpSetting _config;
        private static SmtpClientEx _smtpClient;
        private Quartzmin.Services _services;
        private StdSchedulerFactoryEx _factory;
        private IScheduler _scheduler;

        //TemplateTriggerController _controller;
        //protected string GetRouteData(string key) => RouteData.Values[key].ToString();
        //public string ControllerName => _controller.GetRouteData("controller");
        public TemplateTriggerController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IOptions<SmtpSetting> config,
            SmtpClientEx smtpClient,
            IMasterRepository data,
            Quartzmin.Services services,
            ISchedulerFactory factory
            )
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _config = config.Value;
            _smtpClient = smtpClient;
            _data = data;
            _services = services;
            _factory = (StdSchedulerFactoryEx)factory;
            _scheduler = _factory.Scheduler;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            //var schedulerName = _scheduler.SchedulerName;
            //var data = _data.GetTemplateTrigger();
            //var keys = (await _scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup())).OrderBy(x => x.ToString());
            //var list = new List<TemplateTriggerList>();

            //foreach (var key in keys)
            //{
            //    var t = await GetTrigger(key);
            //    var state = await _scheduler.GetTriggerState(key);
            //    var template = data.Where(w =>
            //        w.template_sched_name == schedulerName &&
            //        w.template_trigger_name == t.Key.Name &&
            //        w.template_trigger_group == t.Key.Group).FirstOrDefault();

            //    if (template != null)
            //    {

            //        list.Add(new TemplateTriggerList()
            //        {
            //            TemplateTriggerId = template.template_trigger_id,
            //            TemplateSchedulerName = template.template_sched_name,
            //            TemplateTriggerName = template.template_trigger_name,
            //            TemplateTriggerGroup = template.template_trigger_group,
            //            TemplateFrom = template.template_from,
            //            TemplateTo = template.template_to,
            //            TemplateCc = template.template_cc,
            //            TemplateBcc = template.template_bcc,
            //            TemplateSubject = template.template_subject,
            //            TemplateBody = template.template_body,

            //            Type = t.GetTriggerType(),
            //            TriggerName = t.Key.Name,
            //            TriggerGroup = t.Key.Group,
            //            IsPaused = state == TriggerState.Paused,
            //            JobKey = t.JobKey.ToString(),
            //            JobGroup = t.JobKey.Group,
            //            JobName = t.JobKey.Name,
            //            ScheduleDescription = t.GetScheduleDescription(),
            //            History = Histogram.Empty,
            //            StartTime = t.StartTimeUtc.UtcDateTime.ToDefaultFormat(),
            //            EndTime = t.FinalFireTimeUtc?.UtcDateTime.ToDefaultFormat(),
            //            LastFireTime = t.GetPreviousFireTimeUtc()?.UtcDateTime.ToDefaultFormat(),
            //            NextFireTime = t.GetNextFireTimeUtc()?.UtcDateTime.ToDefaultFormat(),
            //            ClrType = t.GetType().Name,
            //            Description = t.Description,
            //        });
            //    }
            //}

            //ViewBag.Groups = (await _scheduler.GetTriggerGroupNames()).GroupArray();

            //list = list.OrderBy(x => x.JobKey).ToList();
            //string prevKey = null;
            //foreach (var item in list)
            //{
            //    if (item.JobKey != prevKey)
            //    {
            //        item.JobHeaderSeparator = true;
            //        prevKey = item.JobKey;
            //    }
            //}

            //return View(list);
            return View();
        }

        public async Task<IActionResult> Load(TemplateTrigger value)
        {
            try
            {
                var schedulerName = _scheduler.SchedulerName;
                var data = _data.GetTemplateTrigger(null, null, value.template_sched_name, null, value.template_subject, value.template_to, null);
                var keys = (await _scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup())).OrderBy(x => x.ToString());
                var list = new List<TemplateTriggerList>();

                List<string> _listsSreach = new List<string>(); // new

                switch (value.trigger_state)
                {
                    case "Normal":
                        _listsSreach.Add("Normal");
                        break;
                    case "Paused":
                        _listsSreach.Add("Blocked");
                        _listsSreach.Add("Complete");
                        _listsSreach.Add("Error");
                        _listsSreach.Add("None");
                        _listsSreach.Add("Paused");
                        break;
                    case null:
                        _listsSreach.Add("Normal");
                        _listsSreach.Add("Blocked");
                        _listsSreach.Add("Complete");
                        _listsSreach.Add("Error");
                        _listsSreach.Add("None");
                        _listsSreach.Add("Paused");
                        break;
                }
                List<string> _mockup = new List<string>();

                foreach (var key in keys)
                {
                    var t = await GetTrigger(key);
                    var state = await _scheduler.GetTriggerState(key);
                    var template = data.Where(w =>
                    w.template_sched_name == schedulerName &&
                    w.template_trigger_name == t.Key.Name &&
                    w.template_trigger_group == t.Key.Group && 
                    _listsSreach.Contains(Convert.ToString(state)??"")
                    ).FirstOrDefault();

                    _mockup.Add(Convert.ToString(state) ?? "");

                    if (template != null)
                    {
                        var _realstat = state;
                        if (state == TriggerState.Blocked || state == TriggerState.Complete
                        || state == TriggerState.Error || state == TriggerState.None || state == TriggerState.Normal)
                        {
                            state = (TriggerState)0;
                        }
                        else if (state == TriggerState.Paused)
                        {
                            state = (TriggerState)1;
                        }

                        list.Add(new TemplateTriggerList()
                        {
                            TemplateTriggerId = template.template_trigger_id,
                            TemplateSchedulerName = template.template_sched_name,
                            TemplateTriggerName = template.template_trigger_name,
                            TemplateTriggerGroup = template.template_trigger_group,
                            TemplateFrom = template.template_from,
                            TemplateTo = template.template_to,
                            TemplateCc = template.template_cc,
                            TemplateBcc = template.template_bcc,
                            TemplateSubject = template.template_subject,
                            TemplateBody = template.template_body,
                            Type = t.GetTriggerType(),
                            TriggerName = t.Key.Name,
                            TriggerGroup = t.Key.Group,
                            //RealStatus = _realstat.ToString(),
                            IsPaused = state == TriggerState.Paused,
                            JobKey = t.JobKey.ToString(),
                            JobGroup = t.JobKey.Group,
                            JobName = t.JobKey.Name,
                            ScheduleDescription = t.GetScheduleDescription(),
                            History = Histogram.Empty,
                            StartTime = t.StartTimeUtc.UtcDateTime.Subtract(new TimeSpan(-7, 0, 0)).ToDefaultFormat(),
                            EndTime = t.FinalFireTimeUtc?.UtcDateTime.Subtract(new TimeSpan(-7, 0, 0)).ToDefaultFormat(),
                            LastFireTime = t.GetPreviousFireTimeUtc()?.UtcDateTime.Subtract(new TimeSpan(-7, 0, 0)).ToDefaultFormat(),
                            NextFireTime = t.GetNextFireTimeUtc()?.UtcDateTime.Subtract(new TimeSpan(-7, 0, 0)).ToDefaultFormat(),
                            ClrType = t.GetType().Name,
                            Description = t.Description,
                        });
                    }
                }

                //ViewBag.Groups = (await _scheduler.GetTriggerGroupNames()).GroupArray(); /////// << OLD

                list = list.OrderBy(x => x.JobKey).ThenBy(x => x.IsPaused).ToList();
                string prevKey = null;
                foreach (var item in list)
                {
                    if (item.JobKey != prevKey)
                    {
                        item.JobHeaderSeparator = true;
                        prevKey = item.JobKey;
                    }
                }

                return Json(new { data = list, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }

            //if (value.trigger_state == "Normal")
            //{
            //    _listsSreach.Add("Normal");
            //}
            //else if (value.trigger_state == "Paused")
            //{
            //    _listsSreach.Add("Blocked");
            //    _listsSreach.Add("Complete");
            //    _listsSreach.Add("Error");
            //    _listsSreach.Add("None");
            //    _listsSreach.Add("Paused");
            //}
            //else {
            //    _listsSreach.Add("Normal");
            //    _listsSreach.Add("Blocked");
            //    _listsSreach.Add("Complete");
            //    _listsSreach.Add("Error");
            //    _listsSreach.Add("None");
            //    _listsSreach.Add("Paused");
            //}

        }

        [HttpGet]
        public async Task<IActionResult> New()
        {
            var model = await TemplateTriggerPropertiesViewModel.Create(_scheduler);
            var jobDataMap = new JobDataMapModel() { Template = JobDataMapItemTemplate };

            model.IsNew = true;

            model.Type = TriggerType.Cron;
            model.Cron.TimeZone = "SE Asia Standard Time";
            model.Priority = 5;

            model.MisfireInstruction = MisfireInstruction.SmartPolicy;

            model.TriggerGroup = "DEFAULT";
            model.TemplateSchedulerName = "QuartzScheduler";
            model.Job = "DEFAULT.EmailSchedulerJob";
            model.TemplateFrom = _config.From;

            var reportsMapping = _data.GetTemplateReportMapping();
            model.TemplateReportMapping = reportsMapping;
            model.EmailAttachments = new int[] { };

            model.TabNumber = 1;
            model.DailyType = 1;
            model.Minutes = 1;
            model.Hours = 1;
            model.DailyTime = "00:00";
            model.WeeklyTime = "00:00";
            model.MonthlyTime = "00:00";
            var dates = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            model.Dates = new MultiSelectList(dates);
            model.SelectedDates = new int[] { };
            model.EndOfMonth = false;

            return View("Edit", new TemplateTriggerViewModel() { Trigger = model, DataMap = jobDataMap });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id, bool clone = false)
        {
            var template = _data.GetTemplateTrigger(template_trigger_id: id).FirstOrDefault();
            var name = template.template_trigger_name;
            var group = template.template_trigger_group;

            if (!EnsureValidKey(name, group)) return BadRequest();

            var key = new TriggerKey(name, group);
            var trigger = await GetTrigger(key);

            var jobDataMap = new JobDataMapModel() { Template = JobDataMapItemTemplate };

            var model = await TemplateTriggerPropertiesViewModel.Create(_scheduler);

            model.IsNew = clone;
            model.IsCopy = clone;
            model.Type = trigger.GetTriggerType();
            model.Job = trigger.JobKey.ToString();
            model.TriggerName = model.TemplateTriggerName = trigger.Key.Name;
            model.TriggerGroup = model.TemplateTriggerGroup = trigger.Key.Group;
            model.OldTriggerName = trigger.Key.Name;
            model.OldTriggerGroup = trigger.Key.Group;

            if (clone)
                model.TriggerName += " - Copy";

            //start add new properties for template
            model.TemplateTriggerId = template.template_trigger_id;
            //model.TemplateTriggerName = template.template_trigger_name;
            //model.TemplateTriggerGroup = template.template_trigger_group;
            var reportsMapping = _data.GetTemplateReportMapping();
            var attachments = _data.GetEmailAttachment(template.template_trigger_id);
            var dates = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            model.TemplateSchedulerName = template.template_sched_name;
            model.TemplateFrom = !string.IsNullOrEmpty(template.template_from) ? template.template_from : _config.From;
            model.TemplateTo = template.template_to;
            model.TemplateCc = template.template_cc;
            model.TemplateBcc = template.template_bcc;
            model.TemplateSubject = template.template_subject;
            model.TemplateBody = template.template_body;
            model.TemplateReportMapping = reportsMapping;
            model.EmailAttachments = attachments?.Select(s => s.template_report_mapping_id).ToArray();

            model.TabNumber = template.tab_number;
            model.DailyType = template.daily_type;
            model.Minutes = template.minutes;
            model.Hours = template.hours;
            model.Weekly = template.weekly;
            model.DailyTime = template.daily_time;
            model.WeeklyTime = template.weekly_time;
            model.MonthlyTime = template.monthly_time;
            model.Dates = new MultiSelectList(dates);
            model.SelectedDates = template.selected_dates;
            model.EndOfMonth = template.end_of_month;

            model.Daily.DaysOfWeek.Monday = false;
            model.Daily.DaysOfWeek.Tuesday = false;
            model.Daily.DaysOfWeek.Wednesday = false;
            model.Daily.DaysOfWeek.Thursday = false;
            model.Daily.DaysOfWeek.Friday = false;
            model.Daily.DaysOfWeek.Saturday = false;
            model.Daily.DaysOfWeek.Sunday = false;

            if (model.Weekly != null)
                foreach (var item in model.Weekly)
                {
                    switch (item)
                    {
                        case "MON": model.Daily.DaysOfWeek.Monday = true; break;
                        case "TUE": model.Daily.DaysOfWeek.Tuesday = true; break;
                        case "WED": model.Daily.DaysOfWeek.Wednesday = true; break;
                        case "THU": model.Daily.DaysOfWeek.Thursday = true; break;
                        case "FRI": model.Daily.DaysOfWeek.Friday = true; break;
                        case "SAT": model.Daily.DaysOfWeek.Saturday = true; break;
                        case "SUN": model.Daily.DaysOfWeek.Sunday = true; break;
                        default:
                            break;
                    }

                }

            //end add new properties for template

            // don't show start time in the past because rescheduling cause triggering missfire policies
            model.StartTimeUtc = trigger.StartTimeUtc > DateTimeOffset.UtcNow ? trigger.StartTimeUtc.UtcDateTime.ToDefaultFormat() : null;

            model.EndTimeUtc = trigger.EndTimeUtc?.UtcDateTime.ToDefaultFormat();

            model.CalendarName = trigger.CalendarName;
            model.Description = trigger.Description;
            model.Priority = trigger.Priority;

            model.MisfireInstruction = trigger.MisfireInstruction;

            switch (model.Type)
            {
                case TriggerType.Cron:
                    model.Cron = CronTriggerViewModel.FromTrigger((ICronTrigger)trigger);
                    break;
                case TriggerType.Simple:
                    model.Simple = SimpleTriggerViewModel.FromTrigger((ISimpleTrigger)trigger);
                    break;
                case TriggerType.Daily:
                    model.Daily = DailyTriggerViewModel.FromTrigger((IDailyTimeIntervalTrigger)trigger);
                    break;
                case TriggerType.Calendar:
                    model.Calendar = CalendarTriggerViewModel.FromTrigger((ICalendarIntervalTrigger)trigger);
                    break;
                default:
                    throw new InvalidOperationException("Unsupported trigger type: " + trigger.GetType().AssemblyQualifiedName);
            }

            jobDataMap.Items.AddRange(trigger.GetJobDataMapModel(_services));

            return View("Edit", new TemplateTriggerViewModel() { Trigger = model, DataMap = jobDataMap });
        }

        [HttpPost, JsonErrorResponse]
        public async Task<IActionResult> Save([FromForm] TemplateTriggerViewModel model)
        {
            var output = false;
            var message = string.Empty;
            var triggerModel = model.Trigger;
            var jobDataMap = (await Request.GetJobDataMapForm()).GetModel(_services);

            var result = new ValidationResult();
            try
            {
                model.Trigger.BuildCron();
                model.Validate(result.Errors);
                ModelValidator.Validate(jobDataMap, result.Errors);

                if (result.Success)
                {
                    var builder = TriggerBuilder.Create()
                        .WithIdentity(new TriggerKey(triggerModel.TriggerName, triggerModel.TriggerGroup))
                        .ForJob(jobKey: triggerModel.Job)
                        .UsingJobData(jobDataMap.GetQuartzJobDataMap())
                        .WithDescription(triggerModel.Description)
                        .WithPriority(triggerModel.PriorityOrDefault);

                    builder.StartAt(triggerModel.GetStartTimeUtc() ?? DateTime.UtcNow);
                    builder.EndAt(triggerModel.GetEndTimeUtc());

                    if (!string.IsNullOrEmpty(triggerModel.CalendarName))
                        builder.ModifiedByCalendar(triggerModel.CalendarName);

                    if (triggerModel.Type == TriggerType.Cron)
                        triggerModel.Cron.Apply(builder, triggerModel);
                    if (triggerModel.Type == TriggerType.Simple)
                        triggerModel.Simple.Apply(builder, triggerModel);
                    if (triggerModel.Type == TriggerType.Daily)
                        triggerModel.Daily.Apply(builder, triggerModel);
                    if (triggerModel.Type == TriggerType.Calendar)
                        triggerModel.Calendar.Apply(builder, triggerModel);

                    var trigger = builder.Build();

                    if (triggerModel.IsNew)
                    {
                        await _scheduler.ScheduleJob(trigger);
                    }
                    else
                    {
                        await _scheduler.RescheduleJob(new TriggerKey(triggerModel.OldTriggerName, triggerModel.OldTriggerGroup), trigger);
                    }

                    (output, triggerModel, message) = await _data.SaveTemplateTrigger(triggerModel);
                    if (output)
                    {
                        _data.SaveEmailAttachment(triggerModel.TemplateTriggerId.Value, triggerModel.EmailAttachments);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                var item = new ValidationError();
                item.Field = ex.Source;
                item.Reason = ex.Message;
                result.Errors.Add(item);
            }

            return Json(result);
        }

        [HttpPost, JsonErrorResponse]
        public async Task<IActionResult> Delete([FromBody] KeyModel model)
        {
            if (!EnsureValidKey(model)) return BadRequest();

            var key = model.ToTriggerKey();

            if (!await _scheduler.UnscheduleJob(key))
                throw new InvalidOperationException("Cannot unschedule job " + key);
            //else
            //    _data.DeleteTemplateTrigger()

            return NoContent();
        }

        [HttpPost, JsonErrorResponse]
        public async Task<IActionResult> Resume([FromBody] KeyModel model)
        {
            if (!EnsureValidKey(model)) return BadRequest();
            await _scheduler.ResumeTrigger(model.ToTriggerKey());
            return NoContent();
        }

        [HttpPost, JsonErrorResponse]
        public async Task<IActionResult> Pause([FromBody] KeyModel model)
        {
            if (!EnsureValidKey(model)) return BadRequest();
            await _scheduler.PauseTrigger(model.ToTriggerKey());
            return NoContent();
        }

        [HttpPost, JsonErrorResponse]
        public async Task<IActionResult> PauseJob([FromBody] KeyModel model)
        {
            if (!EnsureValidKey(model)) return BadRequest();
            await _scheduler.PauseJob(model.ToJobKey());
            return NoContent();
        }

        [HttpPost, JsonErrorResponse]
        public async Task<IActionResult> ResumeJob([FromBody] KeyModel model)
        {
            if (!EnsureValidKey(model)) return BadRequest();
            await _scheduler.ResumeJob(model.ToJobKey());
            return NoContent();
        }

        [HttpPost, JsonErrorResponse]
        public IActionResult Cron()
        {
            var cron = Request.ReadAsString()?.Trim();
            if (string.IsNullOrEmpty(cron))
                return Json(new { Description = "", Next = new object[0] });

            string desc = "Invalid format.";

            try
            {
                desc = CronExpressionDescriptor.ExpressionDescriptor.GetDescription(cron);
            }
            catch
            { }

            List<string> nextDates = new List<string>();

            try
            {
                var qce = new CronExpression(cron);
                DateTime dt = DateTime.Now;
                for (int i = 0; i < 10; i++)
                {
                    var next = qce.GetNextValidTimeAfter(dt);
                    if (next == null)
                        break;
                    nextDates.Add(next.Value.LocalDateTime.ToDefaultFormat());
                    dt = next.Value.LocalDateTime;
                }
            }
            catch
            { }

            return Json(new { Description = desc, Next = nextDates });
        }

        private async Task<ITrigger> GetTrigger(TriggerKey key)
        {
            var trigger = await _scheduler.GetTrigger(key);

            if (trigger == null)
                throw new InvalidOperationException("Trigger " + key + " not found.");

            return trigger;
        }

        [HttpGet, JsonErrorResponse]
        public async Task<IActionResult> AdditionalData()
        {
            var keys = await _scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());
            var history = await _scheduler.Context.GetExecutionHistoryStore().FilterLastOfEveryTrigger(10);
            var historyByTrigger = history.ToLookup(x => x.Trigger);

            var list = new List<object>();
            foreach (var key in keys)
            {
                list.Add(new
                {
                    TriggerName = key.Name,
                    TriggerGroup = key.Group,
                    History = historyByTrigger.TryGet(key.ToString()).ToHistogram(),
                });
            }

            return View(list);
        }


        //[HttpGet]
        //public Task<IActionResult> Duplicate(string name, string group)
        //{
        //    return Edit(name, group, clone: true);
        //}

        [HttpGet]
        public Task<IActionResult> Duplicate(int id)
        {
            return Edit(id, clone: true);
        }

        protected JobDataMapItem JobDataMapItemTemplate => new JobDataMapItem()
        {
            SelectedType = _services.Options.DefaultSelectedType,
            SupportedTypes = _services.Options.StandardTypes.Order(),
        };

        bool EnsureValidKey(string name, string group) => !(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(group));
        bool EnsureValidKey(KeyModel model) => EnsureValidKey(model.Name, model.Group);
    }
}
