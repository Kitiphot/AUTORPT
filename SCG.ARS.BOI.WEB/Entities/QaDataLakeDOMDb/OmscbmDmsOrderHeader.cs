using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmDmsOrderHeader
    {
        public string Orderno { get; set; }
        public string Saleorg { get; set; }
        public string Distrchan { get; set; }
        public string Division { get; set; }
        public string Salesoffice { get; set; }
        public string Ordertypecode { get; set; }
        public string Ordercreateddate { get; set; }
        public string Requesteddate { get; set; }
        public string Maxallowdate { get; set; }
        public string Ordergroup { get; set; }
        public string Pono { get; set; }
        public string Soldtocode { get; set; }
        public string Soldtoname { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptostreet { get; set; }
        public string Shiptodistrict { get; set; }
        public string Shiptocity { get; set; }
        public string Shiptoregion { get; set; }
        public string Shiptoregdes { get; set; }
        public string Shiptotel { get; set; }
        public string Shiptounloadpoint { get; set; }
        public string Incoterms1 { get; set; }
        public string Incoterms2 { get; set; }
        public string Shippingcond { get; set; }
        public string Shippingconddesc { get; set; }
        public decimal? Totalqty { get; set; }
        public decimal? Confirmqty { get; set; }
        public decimal? Remainqty { get; set; }
        public decimal? Dnqty { get; set; }
        public string Weightunit { get; set; }
        public string Creditblockd { get; set; }
        public string Palletflag { get; set; }
        public string Pageplag { get; set; }
        public string Markflag { get; set; }
        public string Createdby { get; set; }
        public string Createddate { get; set; }
        public string Updateby { get; set; }
        public string Updatedate { get; set; }
        public string Shiptotranzone { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
