using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakePKGDb
{
    public partial class DbBooking
    {
        public string TruckType { get; set; }
        public string SubTruckType { get; set; }
        public string TruckLicense { get; set; }
        public string DriverName { get; set; }
        public string ShippingPoint { get; set; }
        public Instant? TimeStampBooking { get; set; }
        public string Fleet { get; set; }
        public string Carrier { get; set; }
    }
}
