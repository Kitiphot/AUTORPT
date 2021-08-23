using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    /// <summary>
    /// Generwiz - Pittaya J. 2021-02-19
    /// </summary>
    public class ReportGroup
    {
        public int schema_id { get; set; }
        public string schema_name { get; set; }
        public int? group_id { get; set; }
        public string group_name { get; set; }
        public bool is_active { get; set; }
        public string CreateUser_Code { get; set; }
        public DateTime Create_DateTime { get; set; }
        public string UpdateUser_Code { get; set; }
        public DateTime Update_DateTime { get; set; }
        public bool checkupdate { get; set; }


        //error ลองเพิ่มมาก่อน
        public int? function_id { get; set; }
        public string function_name { get; set; }
        public string function_name_old { get; set; }
        public string schema_display { get; set; }
        public string catalog_name { get; set; }
        public string schema_owner { get; set; }
        public int schema_order { get; set; }
        public int report_id { get; set; }
        public int report_id_old { get; set; }
        public string report_name { get; set; }
        public int report_group_id { get; set; }
        public string report_group_name { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_date_string { get; set; }
        public string created_date_string { get; set; }
        public string check_active { get; set; }

    }
}
