using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
	public class TemplateColumnMapping
	{
		public int? template_column_mapping_id { get; set; }
		public int template_report_mapping_id { get; set; }
		public int schema_id { get; set; }
		public string schema_name { get; set; }
		public string schema_display { get; set; }
		public string catalog_name { get; set; }
		public string schema_owner { get; set; }
		public int? function_id { get; set; } 
		public string function_name { get; set; }
		public int? report_id { get; set; }
		public string report_name { get; set; }
		public string report_desc { get; set; }
		public string column_name { get; set; }
		public string column_display { get; set; }
		public string column_data_type { get; set; }
		public int column_sorting { get; set; }
		public bool is_active { get; set; }
		public string footer { get; set; }
		public string default_value { get; set; }
	}
}
