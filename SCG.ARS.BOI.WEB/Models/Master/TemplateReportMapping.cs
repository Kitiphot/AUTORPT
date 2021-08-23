using SCG.ARS.BOI.WEB.Entities.MasterDb;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class TemplateReportMapping
    {
        public int? template_report_mapping_id { get; set; }
        public int schema_id { get; set; }
        public string schema_name { get; set; }
        public string schema_display { get; set; }
        public string catalog_name { get; set; }
        public string schema_owner { get; set; }
        public int schema_order { get; set; }
        public int? function_id { get; set; }
        public string function_name { get; set; }
        public int? group_id { get; set; }
        public string group_name { get; set; }
        public int? report_id { get; set; }
        public string report_name { get; set; }
        public string report_desc { get; set; }
        public string template_name { get; set; }
        public string template_path { get; set; }
        public bool is_active { get; set; }
    }
}