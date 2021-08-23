using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmDmsOrderItem
    {
        public string Orderno { get; set; }
        public string Itemno { get; set; }
        public string Mfg { get; set; }
        public string Shippingpoint { get; set; }
        public string Matcode { get; set; }
        public string Matdesc { get; set; }
        public decimal? Totalqty { get; set; }
        public decimal? Confirmqty { get; set; }
        public decimal? Deliveryqty { get; set; }
        public decimal? Remainqty { get; set; }
        public string Saleunit { get; set; }
        public decimal? Wtperunitkg { get; set; }
        public int? Transittime { get; set; }
        public decimal? Itemtotalweight { get; set; }
        public decimal? Itemgrossweight { get; set; }
        public decimal? Itemscheduleweight { get; set; }
        public string Hightlevelitem { get; set; }
        public string Freeitem { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
