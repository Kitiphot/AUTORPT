using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstfleet
    {
        public string Fleetcode { get; set; }
        public string Fleetname { get; set; }
        public decimal? Frequency { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public bool Isactive { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
