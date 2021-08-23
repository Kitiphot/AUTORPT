using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDmsOmsScheduleLines
    {
        public string Schduid { get; set; }
        public string Orderline { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
