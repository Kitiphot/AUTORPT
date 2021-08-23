using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterLocationType
    {
        public int Locationtypeid { get; set; }
        public string Locationtypename { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
