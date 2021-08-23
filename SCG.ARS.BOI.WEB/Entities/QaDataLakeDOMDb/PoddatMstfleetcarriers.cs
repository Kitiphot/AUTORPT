using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstfleetcarriers
    {
        public string Fleetcode { get; set; }
        public string Carriercode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
