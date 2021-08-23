using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmDmsScheduleHeaderPlan
    {
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public decimal? Scheduleqty { get; set; }
        public string Scheduleunit { get; set; }
        public string Scheduledate { get; set; }
        public string Schedulestatus { get; set; }
        public string Flagtransfer { get; set; }
        public string Createdby { get; set; }
        public string Createddate { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
