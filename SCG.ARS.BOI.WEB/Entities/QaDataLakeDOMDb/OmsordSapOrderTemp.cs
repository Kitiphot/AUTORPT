using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderTemp
    {
        public string Orderno { get; set; }
        public string Saleorg { get; set; }
        public string Distrchan { get; set; }
        public string Division { get; set; }
        public string Ordertypecode { get; set; }
        public string Ordertypedesc { get; set; }
        public string Doctype { get; set; }
        public string Pono { get; set; }
        public string Incoterm1 { get; set; }
        public string Incoterm1desc { get; set; }
        public string Incoterm2 { get; set; }
        public string Shippingcondition { get; set; }
        public string Shippingconditiondesc { get; set; }
        public string Returncondition { get; set; }
        public string Returnconditiondesc { get; set; }
        public string Soldtocode { get; set; }
        public string Soldtoname { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptonamemaster { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptoname2 { get; set; }
        public string Shiptoname3 { get; set; }
        public string Shiptoname4 { get; set; }
        public string Shiptostreet { get; set; }
        public string Shiptodistrict { get; set; }
        public string Shiptocity { get; set; }
        public string Shiptopostalcode { get; set; }
        public string Shiptotranzone { get; set; }
        public string Shiptoregioncode { get; set; }
        public string Shiptoregionname { get; set; }
        public string Shiptotelephone { get; set; }
        public string Shiptomobile { get; set; }
        public string Shiptospecialcond { get; set; }
        public string Shiptolocationcode { get; set; }
        public string Orderreqdeliverydate { get; set; }
        public string Ordercreatedate { get; set; }
        public string Ordercreditapprovedate { get; set; }
        public string Orderdeliverycreatedate { get; set; }
        public string Orderdeliverydate { get; set; }
        public string Orderconfirmdeliverydate { get; set; }
        public string Ordertransplandate { get; set; }
        public decimal? Ordertotalweight { get; set; }
        public decimal? Ordergrossweight { get; set; }
        public decimal? Orderdeliveryweight { get; set; }
        public string Weightunit { get; set; }
        public decimal? Ordervolume { get; set; }
        public string Ordervolumeunit { get; set; }
        public bool Backorderflag { get; set; }
        public bool Biglotorderflag { get; set; }
        public bool Sapcompleteflag { get; set; }
        public bool Omscompleteflag { get; set; }
        public bool Reqpalletflag { get; set; }
        public bool Omsfullfillflag { get; set; }
        public string Omsposervice { get; set; }
        public string Omsvesselname { get; set; }
        public string Omsspecialordertype { get; set; }
        public string Omsshipmentmemo { get; set; }
        public bool Freightflag { get; set; }
        public string Omscreateddate { get; set; }
        public string Omscreatedby { get; set; }
        public string Omsupdateddate { get; set; }
        public string Omsupdatedby { get; set; }
        public string Shiptosubregioncode { get; set; }
        public string Shiptosubregiondesc { get; set; }
        public string Scgtshiptocode { get; set; }
        public string Plant { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
