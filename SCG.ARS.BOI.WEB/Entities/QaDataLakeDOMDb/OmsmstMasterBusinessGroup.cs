using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterBusinessGroup
    {
        public int Businessgroupid { get; set; }
        public string Businessgroupname { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
