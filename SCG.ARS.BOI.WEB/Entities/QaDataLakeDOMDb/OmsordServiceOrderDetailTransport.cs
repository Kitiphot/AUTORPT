using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderDetailTransport
    {
        public string Sonumber { get; set; }
        public int Ordertypeid { get; set; }
        public string Destinationcode { get; set; }
        public int? Destinationregion { get; set; }
        public string Destinationprovince { get; set; }
        public string Destinationamphur { get; set; }
        public string Destinationdistrict { get; set; }
        public string Destinationhouseno { get; set; }
        public string Destinationsoi { get; set; }
        public string Destinationstreet { get; set; }
        public string Destinationpostalcode { get; set; }
        public string Hublocidlist { get; set; }
        public string Destinationname { get; set; }
        public string Endcustomercode { get; set; }
        public int? Servicelevel { get; set; }
        public string Shipcondcode { get; set; }
        public string Transportmode { get; set; }
        public string Vehicletypecode { get; set; }
        public string Outsourcecode { get; set; }
        public int? Pricingmodelid { get; set; }
        public int? Pricingdatemethod { get; set; }
        public string Pricingdate { get; set; }
        public string Referenceordernumber { get; set; }
        public int? Returnreason { get; set; }
        public int? Reworkreason { get; set; }
        public string Destinationreceipient { get; set; }
        public string Destinationtelephone { get; set; }
        public string Licenseplate { get; set; }
        public decimal? Customeramount1 { get; set; }
        public decimal? Customeramount2 { get; set; }
        public string Customercondition { get; set; }
        public string Destinationamphurname { get; set; }
        public string Destinationprovincename { get; set; }
        public string Shiptospecialcond { get; set; }
        public string Reflocationcode { get; set; }
        public string Refshiptocode { get; set; }
        public string Refshiptocity { get; set; }
        public string Refshiptodistrict { get; set; }
        public string Refshiptoname { get; set; }
        public string Refshiptopostalcode { get; set; }
        public string Refshiptoregion { get; set; }
        public string Refshiptostreet { get; set; }
        public string Refshiptotelephone { get; set; }
        public string Refshiptotranzone { get; set; }
        public string Reflocationflag { get; set; }
        public string Refreturnreasoncode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
