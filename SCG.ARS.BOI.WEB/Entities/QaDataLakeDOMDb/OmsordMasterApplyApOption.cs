using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterApplyApOption
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Sequence { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
