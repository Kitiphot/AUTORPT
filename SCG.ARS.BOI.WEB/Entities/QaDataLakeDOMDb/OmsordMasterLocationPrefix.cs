using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterLocationPrefix
    {
        public string PrefixCode { get; set; }
        public string PrefixDesc { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
