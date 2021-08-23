using Quartzmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class TemplateTriggerList : TriggerListItem
    {
        public int? TemplateTriggerId { get; set; }
        public string TemplateSchedulerName { get; set; }
        public string TemplateTriggerName { get; set; }
        public string TemplateTriggerGroup { get; set; }
        public string TemplateFrom { get; set; }
        public string TemplateTo { get; set; }
        public string TemplateCc { get; set; }
        public string TemplateBcc { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateBody { get; set; }
        public string RealStatus { get; set; }
    }
}
