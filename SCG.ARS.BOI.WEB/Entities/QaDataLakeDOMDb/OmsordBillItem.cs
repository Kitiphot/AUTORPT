using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordBillItem
    {
        public long Billid { get; set; }
        public string Dnnumber { get; set; }
        public string Sonumber { get; set; }
        public string Matfreightgroup { get; set; }
        public decimal Amount { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Gidate { get; set; }
        public string Pono { get; set; }
        public string Servicelevel { get; set; }
        public string Shipfromcode { get; set; }
        public string Shipfromname { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptoname { get; set; }
        public string Giheadertext { get; set; }
        public decimal? Pricerate { get; set; }
        public string Shipmentnumber { get; set; }
        public string Vehicletypecode { get; set; }
        public string Vehicletypename { get; set; }
        public string Ordercreatorname { get; set; }
        public string Orderdate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
