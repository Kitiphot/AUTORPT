using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmDmsScheduleReportDmreqPlan
    {
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public string Itemno { get; set; }
        public string Username { get; set; }
        public string Ordercreateddate { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptocity { get; set; }
        public string Shiptoregdes { get; set; }
        public string Matdesc { get; set; }
        public string Scheduledate { get; set; }
        public decimal? Scheduleqty { get; set; }
        public decimal? Actualgi { get; set; }
        public string Description { get; set; }
        public string Createdby { get; set; }
        public string Createddate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
