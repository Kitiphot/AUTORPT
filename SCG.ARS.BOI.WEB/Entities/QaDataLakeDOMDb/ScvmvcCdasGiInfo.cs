using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcCdasGiInfo
    {
        public string DnNo { get; set; }
        public string ItemNo { get; set; }
        public string Source { get; set; }
        public string ShippingpointId { get; set; }
        public string Material { get; set; }
        public Instant? InboundDate { get; set; }
        public Instant? Gidate { get; set; }
        public decimal? GiWeight { get; set; }
        public string Trucklicense { get; set; }
        public string Sealno { get; set; }
        public Instant? DpboothDate { get; set; }
        public Instant? BayinDate { get; set; }
        public Instant? BayoutDate { get; set; }
        public string BayNo { get; set; }
        public Instant? TareDate { get; set; }
        public decimal? TareWeight { get; set; }
        public string Pono { get; set; }
        public string Sealno1 { get; set; }
        public string UserCreateName { get; set; }
        public Instant UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public Instant? ExitDate { get; set; }
        public decimal? ExitWeight { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
