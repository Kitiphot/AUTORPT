using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterTmsEvent
    {
        public string Eventname { get; set; }
        public bool Isshipmentflag { get; set; }
        public bool Isdelivery { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
