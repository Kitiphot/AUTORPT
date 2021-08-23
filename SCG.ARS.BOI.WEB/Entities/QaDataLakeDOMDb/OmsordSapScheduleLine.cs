using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapScheduleLine
    {
        public string Schduid { get; set; }
        public string Orderno { get; set; }
        public string Itemno { get; set; }
        public string Schduno { get; set; }
        public string Matcode { get; set; }
        public string Matdesc { get; set; }
        public string Shippingpoint { get; set; }
        public string Shippingpointdesc { get; set; }
        public bool Omsinactiveflag { get; set; }
        public bool Omscancelflag { get; set; }
        public string Omsitinerarycode { get; set; }
        public string Omsroute { get; set; }
        public string Omsroutedesc { get; set; }
        public decimal? Omstransittime { get; set; }
        public string Omsshippinglocation { get; set; }
        public string Omsshiptolocation { get; set; }
        public string Omsshiptolocationname { get; set; }
        public string Omsshiptoaddress { get; set; }
        public string Omsshiptocity { get; set; }
        public string Omsshiptopostalcode { get; set; }
        public string Omsshiptoregioncode { get; set; }
        public string Omsshiptoregionname { get; set; }
        public string Omsshiptorecipientname { get; set; }
        public string Omsshiptotelephone { get; set; }
        public string Omsshiptomobile { get; set; }
        public string Omsshiptospecialcond { get; set; }
        public string Omsservicetype { get; set; }
        public string Omsequipmenttype { get; set; }
        public string Omscarriercode { get; set; }
        public string Omsmergeintransitcode { get; set; }
        public bool Omsreqpalletflag { get; set; }
        public string Omssystemremark { get; set; }
        public string Omsremark { get; set; }
        public string Omsnewdeliverydatefromcust { get; set; }
        public string Omsnewdeliverydatefromlpc { get; set; }
        public string Omsnewdeliverydatetocust { get; set; }
        public string Omsnewdeliverydatetolpc { get; set; }
        public decimal? Omsnewdeliveryqtycust { get; set; }
        public decimal? Omsnewdeliveryqtylpc { get; set; }
        public string Omstmsshipfromlocation { get; set; }
        public string Omstmsshiptolocation { get; set; }
        public string Omspickupfromdate { get; set; }
        public string Omspickuptodate { get; set; }
        public string Omsdeliveryfromdate { get; set; }
        public string Omsdeliverytodate { get; set; }
        public string Omscreateby { get; set; }
        public string Omscreatedate { get; set; }
        public string Omsupdateby { get; set; }
        public string Omsupdatedate { get; set; }
        public string Omsprebuildloadflag { get; set; }
        public int? Omsspotrate { get; set; }
        public string Omsspotunit { get; set; }
        public string Omstrailerlicensenumber { get; set; }
        public string Omsdriverlicensenumber { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
