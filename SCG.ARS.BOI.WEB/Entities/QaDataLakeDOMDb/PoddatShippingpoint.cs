using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatShippingpoint
    {
        public string Shippingcode { get; set; }
        public string Shippingname { get; set; }
        public string Fulladdress { get; set; }
        public string Addressstreet { get; set; }
        public string Addresscity { get; set; }
        public string Countrycode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Telephone { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public bool Isactive { get; set; }
        public string Obsoletecode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
