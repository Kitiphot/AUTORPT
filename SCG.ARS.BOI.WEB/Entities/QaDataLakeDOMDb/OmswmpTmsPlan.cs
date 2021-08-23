using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmswmpTmsPlan
    {
        public string PlanId { get; set; }
        public string StatEnu { get; set; }
        public string CrtdDtt { get; set; }
        public string UpdtDtt { get; set; }
        public string CrtdUsrCd { get; set; }
        public string UpdtUsrCd { get; set; }
        public string DivCd { get; set; }
        public string LgstGrpCd { get; set; }
        public string PlanDesc { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
