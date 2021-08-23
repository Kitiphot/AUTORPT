using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmDmsScheduleItemPlan
    {
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public string Itemno { get; set; }
        public string Matcode { get; set; }
        public string Matdesc { get; set; }
        public decimal? Scheduleqty { get; set; }
        public decimal? Confirmqty { get; set; }
        public string Scheduleunit { get; set; }
        public string Deliverycrateddate { get; set; }
        public string Createdby { get; set; }
        public string Createddate { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
