using Microsoft.AspNetCore.Mvc.Rendering;
using NLog;
using Quartz;
using Quartz.Impl.Matchers;
using Quartzmin.Models;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.ViewModels
{
    public class TemplateTriggerPropertiesViewModel : TriggerPropertiesViewModel
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        public int? TemplateTriggerId { get; set; }
        [Required]
        public string TemplateSchedulerName { get; set; }
        [Required]
        public string TemplateTriggerName { get { return TriggerName; } set { TriggerName = value; } }
        [Required]
        public string TemplateTriggerGroup { get { return TriggerGroup; } set { TriggerGroup = value; } }
        [Required]
        public string TemplateFrom { get; set; }
        [Required]
        public string TemplateTo { get; set; }
        public string TemplateCc { get; set; }
        public string TemplateBcc { get; set; }
        [Required]
        public string TemplateSubject { get; set; }
        public string TemplateBody { get; set; }
        public int TabNumber { get; set; }
        public int DailyType { get; set; }
        public int Minutes { get; set; }
        public int Hours { get; set; }
        public string DailyTime { get; set; }
        public string WeeklyTime { get; set; }
        public string MonthlyTime { get; set; }
        public string[] Weekly { get; set; }
        public int[] SelectedDates { get; set; }
        public MultiSelectList Dates { get; set; }
        public bool EndOfMonth { get; set; }

        //public MultiSelectList TemplateReportMapping { get; set; }
        public IEnumerable<TemplateReportMapping> TemplateReportMapping { get; set; }
        public int[] EmailAttachments { get; set; }

        public static new async Task<TemplateTriggerPropertiesViewModel> Create(IScheduler scheduler)
        {
            var model = new TemplateTriggerPropertiesViewModel()
            {
                TriggerGroupList = (await scheduler.GetTriggerGroupNames()).GroupArray(),
                TriggerGroup = SchedulerConstants.DefaultGroup,
                JobList = (await scheduler.GetJobKeys(GroupMatcher<JobKey>.AnyGroup())).Select(x => x.ToString()).ToArray(),
                CalendarNameList = await scheduler.GetCalendarNames(),
            };

            model.Cron.TimeZone = TimeZoneInfo.Local.Id;

            model.Simple.RepeatInterval = 1;
            model.Simple.RepeatUnit = IntervalUnit.Minute;
            model.Simple.RepeatForever = true;

            model.Daily.DaysOfWeek.AllOn();
            model.Daily.RepeatInterval = 1;
            model.Daily.RepeatUnit = IntervalUnit.Minute;
            model.Daily.RepeatForever = true;
            model.Daily.TimeZone = TimeZoneInfo.Local.Id;

            model.Calendar.RepeatInterval = 1;
            model.Calendar.RepeatUnit = IntervalUnit.Minute;
            model.Calendar.TimeZone = TimeZoneInfo.Local.Id;

            return model;
        }

        public bool BuildCron()
        {
            var result = false;
            try
            {
                if (TabNumber.Equals(1))
                {
                    if (DailyType == 1)
                        Cron.Expression = $"0 0/{Minutes} * * * ? *";
                    else if (DailyType == 2)
                        Cron.Expression = $"0 0 0/{Hours} * * ? *";
                    else if (DailyType == 3 && !string.IsNullOrEmpty(DailyTime))
                    {
                        var arr = ConvertTime(DailyTime);
                        Cron.Expression = $"0 {arr[1]} {arr[0]} * * ? *";
                    }
                    else
                        Cron.Expression = "0 0 1 * * ? *";
                }
                else if (TabNumber.Equals(2))
                {
                    var hour = "0";
                    var minute = "0";
                    if (!string.IsNullOrEmpty(WeeklyTime))
                    {
                        var arr = ConvertTime(WeeklyTime);
                        hour = arr[0];
                        minute = arr[1];
                    }
                    var weekly = new List<string>();
                    if (Daily.DaysOfWeek.Sunday) weekly.Add("SUN");
                    if (Daily.DaysOfWeek.Monday) weekly.Add("MON");
                    if (Daily.DaysOfWeek.Tuesday) weekly.Add("TUE");
                    if (Daily.DaysOfWeek.Wednesday) weekly.Add("WED");
                    if (Daily.DaysOfWeek.Thursday) weekly.Add("THU");
                    if (Daily.DaysOfWeek.Friday) weekly.Add("FRI");
                    if (Daily.DaysOfWeek.Saturday) weekly.Add("SAT");

                    var strWeekly = weekly.Count == 0 ? "*" : string.Join(',', weekly);

                    Cron.Expression = $"0 {minute} {hour} ? * {strWeekly} *";
                }
                else if (TabNumber.Equals(3))
                {
                    var hour = "0";
                    var minute = "0";
                    if (!string.IsNullOrEmpty(MonthlyTime))
                    {
                        var arr = ConvertTime(MonthlyTime);
                        hour = arr[0];
                        minute = arr[1];
                    }

                    var dates = "*";
                    if (SelectedDates != null)
                        dates = string.Join(',', SelectedDates);

                    var endofmonth = "";
                    if (EndOfMonth)
                        endofmonth = SelectedDates != null ? ",L" : "L";
                    Cron.Expression = $"0 {minute} {hour} {dates} * ? *";
                }
                else Cron.Expression = "0 0 1 * * ? *";
                result = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return result;
        }

        private List<string> ConvertTime(string value)
        {
            var result = new List<string>();
            if (!string.IsNullOrEmpty(value))
            {
                var arr = value.Split(':');
                for (int i = 0; i < arr.Length; i++)
                    if (int.TryParse(arr[i], out int output))
                        result.Add(output.ToString());
            }

            if (result.Count == 0)
                for (int i = 0; i < 2; i++)
                    result.Add("0");

            return result;
        }
    }
}
