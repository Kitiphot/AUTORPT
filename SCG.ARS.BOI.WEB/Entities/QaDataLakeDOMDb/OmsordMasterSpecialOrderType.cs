using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSpecialOrderType
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
