using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapShipto
    {
        public string Shiptocode { get; set; }
        public string Sapname1 { get; set; }
        public string Sapname2 { get; set; }
        public string Sapname3 { get; set; }
        public string Sapname4 { get; set; }
        public string Saptaxid { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Postalcode { get; set; }
        public string Countrycode { get; set; }
        public string Sapregion { get; set; }
        public string Saptranszone { get; set; }
        public string Paymentterm { get; set; }
        public bool? Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
