using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatCheckedpoint
    {
        public string Shipmentno { get; set; }
        public string Locationtype { get; set; }
        public string Locationcode { get; set; }
        public string Driverlicense { get; set; }
        public string Trucklicense { get; set; }
        public Instant? Checkindate { get; set; }
        public string Checkinuser { get; set; }
        public double? Checkinlatitude { get; set; }
        public double? Checkinlongitude { get; set; }
        public Instant? Checkoutdate { get; set; }
        public string Checkoutuser { get; set; }
        public double? Checkoutlatitude { get; set; }
        public double? Checkoutlongitude { get; set; }
        public Instant? Confirmqtydate { get; set; }
        public Instant? Confirmpicdate { get; set; }
        public Instant? Confirmsigdate { get; set; }
        public Instant? Confirmdocdate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
