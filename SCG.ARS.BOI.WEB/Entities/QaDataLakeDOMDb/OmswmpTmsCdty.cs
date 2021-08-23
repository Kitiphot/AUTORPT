using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmswmpTmsCdty
    {
        public string CdtyCd { get; set; }
        public int OptLck { get; set; }
        public string CdtyDesc { get; set; }
        public string HzdsYn { get; set; }
        public int? EdiCdtyCdTyp { get; set; }
        public int? CdtyPickSeqNum { get; set; }
        public string ExtlCd { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
