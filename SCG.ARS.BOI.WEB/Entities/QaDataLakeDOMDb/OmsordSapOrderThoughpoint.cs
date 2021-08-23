using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderThoughpoint
    {
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public short Sequence { get; set; }
        public string Locationcode { get; set; }
        public string Locationtype { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
