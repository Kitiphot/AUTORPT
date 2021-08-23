using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitDeliveryItems
    {
        public string Dnnumber { get; set; }
        public string Legheader { get; set; }
        public int Legid { get; set; }
        public string Refdnnumber { get; set; }
        public int Dnitem { get; set; }
        public string Sonumber { get; set; }
        public int Soitemnumber { get; set; }
        public string Materialcode { get; set; }
        public string Materialname { get; set; }
        public string Materialfreightgroup { get; set; }
        public decimal? Materialnetweight { get; set; }
        public decimal? Materialgrossweight { get; set; }
        public decimal? Materialvolume { get; set; }
        public string Materialbaseunit { get; set; }
        public string Materialpricingunit { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Totalnetweight { get; set; }
        public decimal? Totalgrossweight { get; set; }
        public string Weightunit { get; set; }
        public decimal? Totalvolume { get; set; }
        public string Volumeunit { get; set; }
        public string Plannername { get; set; }
        public string Shippingmark { get; set; }
        public string Remark { get; set; }
        public bool? Requestpalletflag { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Deliverytype { get; set; }
        public bool? Giflag { get; set; }
        public decimal? Giquantity { get; set; }
        public string Gicompleteddatetime { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
