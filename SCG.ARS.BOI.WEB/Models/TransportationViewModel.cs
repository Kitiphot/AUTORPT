using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models
{
    public class RPTLPC001_ShipmentMonthlyStatusViewModel
    {
        public DateTime dn_day { get; set; }
        public int total_dn { get; set; }
        public int total_tender { get; set; }
        public int total_accept { get; set; }
        public int total_gi { get; set; }
        public int total_delivery { get; set; }
    }
    public class RPTLPC001_ShipmentYearlyStatusViewModel
    {
        public string shipment_month { get; set; }
        public int total_dn { get; set; }
        public int total_tender { get; set; }
        public int total_accept { get; set; }
        public int total_gi { get; set; }
        public int total_delivery { get; set; }
    }
    public class RPTLPC001_ShipmentMonthlyStatusAgingViewModel
    {
        public string status_aging { get; set; }
        //public int total_dn { get; set; }
        public int total_tender { get; set; }
        public int total_accept { get; set; }
        public int total_gi { get; set; }
        public int total_delivery { get; set; }
        public int total_data { get; set; }
    }

    public class RPTLPC001_ShipmentMonthlyCarrierStatusViewModel
    {
        public string carrier_name { get; set; }
        public int total_accept { get; set; }
        public int total_gi { get; set; }
        public int total_delivery { get; set; }
        public int total_tender { get; set; }
    }

    public class DataTableDataDetailViewModel
    {
        public string rowType { get; set; }
        public int[] qty { get; set; }
        public double[] dqty { get; set; }
    }

    public class DataTableDataHeaderViewModel
    {
        public string[] header { get; set; }
        public DataTableDataDetailViewModel[] dataDetail { get; set; }
    }

    public class RPTLPC001_ShipmentDailyStatusViewModel
    {
        public int total_dn { get; set; }
        public int total_tender { get; set; }
        public int total_accept { get; set; }
        public int total_gi { get; set; }
        public int total_delivery { get; set; }
    }
}
