using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstcarrierorigins
    {
        public string Carriercode { get; set; }
        public string Shippingcode { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
