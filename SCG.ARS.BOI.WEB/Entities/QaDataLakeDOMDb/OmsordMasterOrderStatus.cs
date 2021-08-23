using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterOrderStatus
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
