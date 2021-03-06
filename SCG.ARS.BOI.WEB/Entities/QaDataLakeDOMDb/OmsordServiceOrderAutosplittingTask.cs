using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderAutosplittingTask
    {
        public string Systembatchno { get; set; }
        public string Computername { get; set; }
        public string Tasktype { get; set; }
        public string Stage { get; set; }
        public string Errormessage { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public string ProcessedDate { get; set; }
        public string ErrorDate { get; set; }
        public byte[] Rowversion { get; set; }
        public string Sourcesystem { get; set; }
        public string Jobbatchno { get; set; }
        public bool? Reportflag { get; set; }
        public string Plannerusername { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
