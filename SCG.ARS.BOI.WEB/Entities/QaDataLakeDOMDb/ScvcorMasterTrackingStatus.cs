using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvcorMasterTrackingStatus
    {
        public int StatusId { get; set; }
        public string StatusField { get; set; }
        public string StatusDisplay { get; set; }
        public string StatusDescription { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
