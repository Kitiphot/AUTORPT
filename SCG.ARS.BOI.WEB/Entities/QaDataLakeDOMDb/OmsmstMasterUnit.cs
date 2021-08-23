using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterUnit
    {
        public string Unitcode { get; set; }
        public string Unitdescription { get; set; }
        public string Isocode { get; set; }
        public bool Weightunit { get; set; }
        public bool Volumeunit { get; set; }
        public bool Dimensionunit { get; set; }
        public bool Decimalflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
