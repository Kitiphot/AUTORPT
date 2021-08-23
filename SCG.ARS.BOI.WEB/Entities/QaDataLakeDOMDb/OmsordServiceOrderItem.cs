using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderItem
    {
        public long Id { get; set; }
        public string Sonumber { get; set; }
        public int Itemno { get; set; }
        public string Origincode { get; set; }
        public string Originname { get; set; }
        public int? Originregion { get; set; }
        public string Originprovince { get; set; }
        public string Originamphur { get; set; }
        public string Origindistrict { get; set; }
        public string Originhouseno { get; set; }
        public string Originsoi { get; set; }
        public string Originstreet { get; set; }
        public string Originpostalcode { get; set; }
        public string Description { get; set; }
        public string Customermaterialcode { get; set; }
        public string Materialcode { get; set; }
        public string Materialname { get; set; }
        public string Materialfreightgroup { get; set; }
        public decimal Materialnetweight { get; set; }
        public decimal Materialgrossweight { get; set; }
        public decimal Materialvolume { get; set; }
        public string Materialbaseunit { get; set; }
        public string Materialpricingunit { get; set; }
        public decimal Quantity { get; set; }
        public decimal Pricingquantity { get; set; }
        public decimal? Totalnetweight { get; set; }
        public decimal? Totalgrossweight { get; set; }
        public string Weightunit { get; set; }
        public decimal? Totalvolume { get; set; }
        public string Volumeunit { get; set; }
        public string Remark { get; set; }
        public bool? Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Customermaterialname { get; set; }
        public string Palletid { get; set; }
        public string Refshippingpoint { get; set; }
        public string Orderdeliverycreatedate { get; set; }
        public string Refplantcode { get; set; }
        public string Refconditiontype { get; set; }
        public decimal? Refpercentrate { get; set; }
        public string Refpricecurrency { get; set; }
        public string Refproductprice { get; set; }
        public string Refproductpricerate { get; set; }
        public decimal? Totalquantity { get; set; }
        public bool? Iscompensate { get; set; }
        public bool? Ispending { get; set; }
        public string Refproductpricingdate { get; set; }
        public string Incoterm { get; set; }
        public string Incoterm2 { get; set; }
        public string Incoterm3 { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
