using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblTemplateTrigger
    {
        public int TemplateTriggerId { get; set; }
        public string TemplateSchedName { get; set; }
        public string TemplateTriggerName { get; set; }
        public string TemplateTriggerGroup { get; set; }
        public string TemplateFrom { get; set; }
        public string TemplateTo { get; set; }
        public string TemplateCc { get; set; }
        public string TemplateBcc { get; set; }
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
        public bool EndOfMonth { get; set; }
    }
}
