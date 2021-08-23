using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderAutosplittingOrder
    {
        public string Sapbatchno { get; set; }
        public bool? Ischeck { get; set; }
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public string Seletedshippingpoint { get; set; }
        public string Shiptolocationcode { get; set; }
        public string Shiptonamemaster { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptospecialcond { get; set; }
        public string ServiceOption01 { get; set; }
        public string ServiceOption02 { get; set; }
        public string ServiceOption03 { get; set; }
        public string ServiceOption04 { get; set; }
        public decimal? Ordertotalweight { get; set; }
        public decimal? Ordergrossweight { get; set; }
        public decimal? Orderdeliveryweight { get; set; }
        public decimal? Orderbackweight { get; set; }
        public decimal? Orderremainweight { get; set; }
        public decimal? Ordervolume { get; set; }
        public string Orderreqdeliverydate { get; set; }
        public string Schdudate { get; set; }
        public string Orderdeliverycreatedate { get; set; }
        public string Pono { get; set; }
        public string Shippingcondition { get; set; }
        public string Shiptoname4 { get; set; }
        public string Shiptotelephone { get; set; }
        public string Soldtocode { get; set; }
        public string Soldtoname { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptocity { get; set; }
        public string Ordercreatedate { get; set; }
        public string Ordercreditapprovedate { get; set; }
        public bool Biglotorderflag { get; set; }
        public bool Backorderflag { get; set; }
        public string Incoterm1 { get; set; }
        public string Shiptoregioncode { get; set; }
        public string Shiptosubregiondesc { get; set; }
        public bool Freightflag { get; set; }
        public string Conflictdmstatus { get; set; }
        public int Difflocationcount { get; set; }
        public string Pageflag { get; set; }
        public string Documenttype { get; set; }
        public string Stampdatetime { get; set; }
        public string Stampby { get; set; }
        public string Errormessage { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
