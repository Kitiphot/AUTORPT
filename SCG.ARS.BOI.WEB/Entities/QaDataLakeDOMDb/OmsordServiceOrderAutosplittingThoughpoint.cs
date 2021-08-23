using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderAutosplittingThoughpoint
    {
        public string Systembatchno { get; set; }
        public string Sonumber { get; set; }
        public short Sequence { get; set; }
        public string Locationcode { get; set; }
        public string Locationtype { get; set; }
        public int Scheduleno { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
