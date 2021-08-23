using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordBkDeliverySapItem
    {
        public string Dnnumber { get; set; }
        public string Legheader { get; set; }
        public int Legid { get; set; }
        public string Dnitem { get; set; }
        public string Refdnnumber { get; set; }
        public string Sonumber { get; set; }
        public string Soitemnumber { get; set; }
        public string Materialcode { get; set; }
        public string Materialname { get; set; }
        public decimal? Materialnetweight { get; set; }
        public decimal? Materialgrossweight { get; set; }
        public decimal? Materialvolume { get; set; }
        public string Materialfreightgroup { get; set; }
        public string Materialfreightdescription { get; set; }
        public string Materialbaseunit { get; set; }
        public string Materialpricingunit { get; set; }
        public string Shippingpoint { get; set; }
        public string Shippingpointdescription { get; set; }
        public string Shippingcondition { get; set; }
        public string Shippingconditiondescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal Deliveryquantity { get; set; }
        public string Isosaleunit { get; set; }
        public decimal? Totalnetweight { get; set; }
        public decimal? Totalgrossweight { get; set; }
        public string Weightunit { get; set; }
        public string Isoweightunit { get; set; }
        public decimal? Weightperunit { get; set; }
        public decimal? Weightperunitkg { get; set; }
        public decimal? Totalvolume { get; set; }
        public string Volumeunit { get; set; }
        public string Isovolumeunit { get; set; }
        public decimal? Volumeperunit { get; set; }
        public decimal? Volumeperunitccm { get; set; }
        public bool Deleteflag { get; set; }
        public bool Cancelflag { get; set; }
        public bool Requestpalletflag { get; set; }
        public string Remark { get; set; }
        public string Plannername { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
