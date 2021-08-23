using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitJobIntransitHeader
    {
        public int Jobheaderid { get; set; }
        public string Jobname { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Jobheadertype { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
