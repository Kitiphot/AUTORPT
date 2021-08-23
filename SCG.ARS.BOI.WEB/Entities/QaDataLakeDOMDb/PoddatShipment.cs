using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatShipment
    {
        public string Shipmentno { get; set; }
        public string Carriercode { get; set; }
        public string Carriername { get; set; }
        public string Trucktype { get; set; }
        public string Trucklicense { get; set; }
        public string Trailerlicense { get; set; }
        public string Fulllicense { get; set; }
        public string Driverlicense { get; set; }
        public string Drivername { get; set; }
        public string Shippingcode { get; set; }
        public string Shippingname { get; set; }
        public string Shippingaddr { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptoname { get; set; }
        public string Shiptoaddr { get; set; }
        public string Shippingarea { get; set; }
        public string Productgroup { get; set; }
        public string Shipmentleg { get; set; }
        public Instant? Shipmentdate { get; set; }
        public Instant? Tendereddate { get; set; }
        public Instant? Assigneddate { get; set; }
        public Instant? Accepteddate { get; set; }
        public Instant? Loadeddate { get; set; }
        public Instant? Unloadeddate { get; set; }
        public Instant? Completedate { get; set; }
        public decimal? Totalquantity { get; set; }
        public decimal? Totalweight { get; set; }
        public decimal? Totalvolume { get; set; }
        public string Quantityunit { get; set; }
        public string Volumeunit { get; set; }
        public string Weightunit { get; set; }
        public decimal? Estdistance { get; set; }
        public decimal? Shipmentamount { get; set; }
        public string Shipmentmemo { get; set; }
        public string Tmsdescription { get; set; }
        public string Tmsmemo { get; set; }
        public string Shipmentremark { get; set; }
        public string Shipmentstatus { get; set; }
        public Instant? Laststatusdate { get; set; }
        public string Rejectreason { get; set; }
        public string Rejectremark { get; set; }
        public double? Lastlatitude { get; set; }
        public double? Lastlongitude { get; set; }
        public string Trackingno { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public Instant? Checkindate { get; set; }
        public Instant? Checkoutdate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
