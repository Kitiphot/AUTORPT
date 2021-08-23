using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class TemplateParameterMapping
    {
        public int schema_id { get; set; }
        public string schema_name { get; set; }
        public int template_parameter_mapping_id { get; set; }
        public int template_report_mapping_id { get; set; }
        public string report_desc { get; set; }
        public string parameter_name { get; set; }
        public int parameter_type_id { get; set; }
        public string data_type_name { get; set; }
        public int parameter_data_type_id { get; set; }
        public string parameter_type_name { get; set; }
        public string parameter_udt_name { get; set; }
        public string parameter_default_value { get; set; }
        public int parameter_source_id { get; set; }
        public string parameter_source_column { get; set; }
        public string parameter_source_query { get; set; }
        public int ordinal_position { get; set; }
        public bool is_active { get; set; }
    }
}
