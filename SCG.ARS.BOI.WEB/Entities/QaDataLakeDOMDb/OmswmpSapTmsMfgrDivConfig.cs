using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmswmpSapTmsMfgrDivConfig
    {
        public string SapMfgCode { get; set; }
        public string TmsDivCode { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
