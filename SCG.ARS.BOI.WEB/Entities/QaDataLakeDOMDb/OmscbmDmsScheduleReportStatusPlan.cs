using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmDmsScheduleReportStatusPlan
    {
        public string Orderno { get; set; }
        public string Username { get; set; }
        public string Ordercreateddate { get; set; }
        public string Creditblock { get; set; }
        public string Requestdate { get; set; }
        public string Pono { get; set; }
        public string Soldtocode { get; set; }
        public string Soldtoname { get; set; }
        public string Productcate { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptoregdes { get; set; }
        public string Incoterm1 { get; set; }
        public decimal? Totalqty { get; set; }
        public decimal? Scheduleqty { get; set; }
        public decimal? Remainqty { get; set; }
        public string Schedulests { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
