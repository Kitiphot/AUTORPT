using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcTmsLoadTracking
    {
        public string LoadId { get; set; }
        public Instant? ActualOpen { get; set; }
        public Instant? ActualPlan { get; set; }
        public Instant? ActualTender { get; set; }
        public Instant? ActualTenderAccept { get; set; }
        public Instant? ActualInTransit { get; set; }
        public byte[] Rowversion { get; set; }
        public Instant? ActualCancel { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
