using System;
using System.Runtime.CompilerServices;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class StockMaster
    {
        public int? stockmaster_id { get; set; }
        public string dc_type { get; set; }
        public int? customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_code { get; set; }
        public int? storage_type_id { get; set; }
        public string storage_type_name { get; set; }
        public decimal location_area_m3 { get; set; }
        public decimal location_charge { get; set; }
        public int location_plan { get; set; }
        public DateTime effective_date { get; set; }
        public bool is_deleted { get; set; }
        public string err_msg { get; set; }
    }

    public class StockMasterShow
    {
        public string stockmaster_id { get; set; }
        public string dc_type { get; set; }
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_code { get; set; }
        public string storage_type_id { get; set; }
        public string storage_type_name { get; set; }
        public string location_area { get; set; }
        public string location_charge { get; set; }
        public string location_plan { get; set; }
        public string effective_date { get; set; }
        public string is_deleted { get; set; }
        public string err_msg { get; set; }


    }

}

