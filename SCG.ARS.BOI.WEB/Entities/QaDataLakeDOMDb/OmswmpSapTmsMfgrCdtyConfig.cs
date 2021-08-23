using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmswmpSapTmsMfgrCdtyConfig
    {
        public string SapCdtyCd { get; set; }
        public int OptLck { get; set; }
        public string TmCdtyCd { get; set; }
        public string FcCd { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
