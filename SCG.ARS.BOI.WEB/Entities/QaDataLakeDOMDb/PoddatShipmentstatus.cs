using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatShipmentstatus
    {
        public string Statuscode { get; set; }
        public string Statusdesc { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
