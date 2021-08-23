using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class ReportsCustomizationGroupModel
    {
        public int schema_id { get; set; }
        public int group_id { get; set; }
        public string group_name { get; set; }
        public List<ReportsCustomizationItemModel> CustomizationItems { get; set; }

        public ReportsCustomizationGroupModel()
        {
            CustomizationItems = new List<ReportsCustomizationItemModel>();
        }
    }
}
