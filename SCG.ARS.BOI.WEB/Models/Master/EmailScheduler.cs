using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class EmailScheduler
    {
        public int? email_scheduler_id { get; set; }
        public string email_scheduler_name { get; set; }
        public int email_scheduler_status_id { get; set; }
        public string email_scheduler_staus_name { get; set; }
        public string email_cron_expression { get; set; }
        public string email_time_zone_id { get; set; }
        public string email_from { get; set; }
        public string email_to { get; set; }
        public string email_cc { get; set; }
        public string email_bcc { get; set; }
        public string email_subject { get; set; }
        public string email_body { get; set; }
    }
}
