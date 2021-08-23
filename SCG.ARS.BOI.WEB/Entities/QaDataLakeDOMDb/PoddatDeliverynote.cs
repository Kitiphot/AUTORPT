using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatDeliverynote
    {
        public string Shipmentno { get; set; }
        public string Deliveryno { get; set; }
        public string Salesorder { get; set; }
        public string Soldtocode { get; set; }
        public string Soldtoname { get; set; }
        public string Soldtoaddr { get; set; }
        public string Soldtotel { get; set; }
        public string Soldtopostalcode { get; set; }
        public string Shippingcode { get; set; }
        public string Shippingname { get; set; }
        public string Shippingaddr { get; set; }
        public string Shippingtel { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptoaddr { get; set; }
        public string Shiptotel { get; set; }
        public Instant? Deliverydate { get; set; }
        public Instant? Requesteddate { get; set; }
        public Instant? Orderdate { get; set; }
        public Instant? Shipmentdate { get; set; }
        public string Commuditycode { get; set; }
        public string Productgroup { get; set; }
        public string Regioncode { get; set; }
        public string Regionname { get; set; }
        public string Postalkey { get; set; }
        public string Postalcode { get; set; }
        public string Purchaseorder { get; set; }
        public string Deliveryleg { get; set; }
        public string Deliverystatus { get; set; }
        public string Statusremark { get; set; }
        public Instant? Laststatusdate { get; set; }
        public string Deliveryremark { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public Instant? Sapgidate { get; set; }
        public Instant? Sappickdate { get; set; }
        public string Sapgistatus { get; set; }
        public string Sappickstatus { get; set; }
        public decimal? Sapgiweight { get; set; }
        public Instant? Saptaredate { get; set; }
        public decimal? Saptareweight { get; set; }
        public Instant? Sapbayindate { get; set; }
        public Instant? Sapbayoutdate { get; set; }
        public string Sapbayno { get; set; }
        public string Sapsealno { get; set; }
        public double? Servicerating { get; set; }
        public double? Personalrating { get; set; }
        public string Serviceremark { get; set; }
        public string Personalremark { get; set; }
        public string Salesorg { get; set; }
        public string Paymentterm { get; set; }
        public string Receivertel { get; set; }
        public string Shipmentmemo { get; set; }
        public string Poservice { get; set; }
        public string Sapshiptocode { get; set; }
        public string Origincode { get; set; }
        public string Originname { get; set; }
        public string Originaddr { get; set; }
        public int? Pickstopseqno { get; set; }
        public string Destinationcode { get; set; }
        public string Destinationname { get; set; }
        public string Destinationaddr { get; set; }
        public int? Dropstopseqno { get; set; }
        public bool? Isswitching { get; set; }
        public string Sapshiptoname { get; set; }
        public string Soldtoregion { get; set; }
        public string Incoterm { get; set; }
        public Instant? Exitdate { get; set; }
        public decimal? Exitweight { get; set; }
        public string Damageremark { get; set; }
        public string Returnremark { get; set; }
        public bool? Isallreturngoods { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
