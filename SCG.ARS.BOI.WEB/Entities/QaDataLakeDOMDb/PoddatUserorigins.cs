using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatUserorigins
    {
        public string Username { get; set; }
        public string Shippingcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
