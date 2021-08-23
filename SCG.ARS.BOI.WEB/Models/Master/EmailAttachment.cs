using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class EmailAttachment
    {
        public int email_attachment_id { get; set; }
        public int email_scheduler_id { get; set; }
        public string email_scheduler_name { get; set; }
        public int template_report_mapping_id { get; set; }
        public int schema_id { get; set; }
        public string schema_name { get; set; }
        public string schema_display { get; set; }
        public string catalog_name { get; set; }
        public string schema_owner { get; set; }
        public int function_id { get; set; }
        public string function_name { get; set; }
        public int report_id { get; set; }
        public string report_name { get; set; }
        public string report_desc { get; set; }

    }
}
