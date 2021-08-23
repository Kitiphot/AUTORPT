using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class ReportsCustomizationItemModel
    {
        public int schema_id { get; set; }
        public string schema_name { get; set; }
        public string schema_display { get; set; }
        public string catalog_name { get; set; }
        public int group_id { get; set; }
        public string group_name { get; set; }
        public string report_name { get; set; }
        public string function_name { get; set; }
        public List<ReportsCustomizationDetailModel> CustomizationDetails { get; set; }

        public ReportsCustomizationItemModel()
        {
            CustomizationDetails = new List<ReportsCustomizationDetailModel>();
        }
    }
}
