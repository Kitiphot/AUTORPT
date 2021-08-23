using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterTmsLoadStatus
    {
        public string Loadstatus { get; set; }
        public string Loaddescription { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
