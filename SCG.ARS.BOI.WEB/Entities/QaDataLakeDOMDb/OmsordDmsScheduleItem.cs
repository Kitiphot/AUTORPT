using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDmsScheduleItem
    {
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public string Itemno { get; set; }
        public decimal? Schduqty { get; set; }
        public decimal? Schduconfirmqty { get; set; }
        public decimal? Schdudeliveryqty { get; set; }
        public decimal? Schduweight { get; set; }
        public decimal? Schdugrossweight { get; set; }
        public decimal? Schdudeliveryweight { get; set; }
        public bool Omscancelflag { get; set; }
        public string Omssystemremark { get; set; }
        public string Usercreateddate { get; set; }
        public string Usercreatedby { get; set; }
        public string Userupdateddate { get; set; }
        public string Userupdatedby { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
