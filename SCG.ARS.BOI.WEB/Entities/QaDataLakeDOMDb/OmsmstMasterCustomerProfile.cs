using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterCustomerProfile
    {
        public string Customercode { get; set; }
        public string Sapname1 { get; set; }
        public string Sapname2 { get; set; }
        public string Sapname3 { get; set; }
        public string Sapname4 { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Postalcode { get; set; }
        public string Paymentterm { get; set; }
        public string Shortname { get; set; }
        public int? Channelid { get; set; }
        public int? Businessgroupid { get; set; }
        public string Extrashipcond { get; set; }
        public string Remark { get; set; }
        public bool? Deleteflag { get; set; }
        public string UpdatedDate { get; set; }
        public string Countrycode { get; set; }
        public string Sapregion { get; set; }
        public string Saptaxid { get; set; }
        public string Saptranszone { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Ischeckcredit { get; set; }
        public int? Pricingdate { get; set; }
        public decimal? Weightperschedule { get; set; }
        public bool Iscalpricing { get; set; }
        public bool Iscalrequesteddate { get; set; }
        public bool Billendofmonth { get; set; }
        public int? Billformconsol { get; set; }
        public int? Billformftl { get; set; }
        public string Billgrouptype { get; set; }
        public string Billperiod { get; set; }
        public bool Isbilling { get; set; }
        public bool Isautosplit { get; set; }
        public bool Isbillgroupbyorigin { get; set; }
        public bool Isprintbill { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
