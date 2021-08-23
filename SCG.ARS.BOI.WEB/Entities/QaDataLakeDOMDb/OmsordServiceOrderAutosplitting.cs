using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderAutosplitting
    {
        public string Systembatchno { get; set; }
        public string Sonumber { get; set; }
        public string Plannername { get; set; }
        public int Scheduleno { get; set; }
        public string Stampdatetime { get; set; }
        public string Stampname { get; set; }
        public string Errormessage { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
