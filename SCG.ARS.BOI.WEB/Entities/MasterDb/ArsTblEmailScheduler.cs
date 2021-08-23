using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblEmailScheduler
    {
        public int EmailSchedulerId { get; set; }
        public string EmailSchedulerName { get; set; }
        public int EmailSchedulerStatusId { get; set; }
        public string EmailCronExpression { get; set; }
        public string EmailTimeZoneId { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
    }
}
