using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordConfigBiglotOrder
    {
        public long Id { get; set; }
        public string Customercode { get; set; }
        public string Originlocationcode { get; set; }
        public string Materialcode { get; set; }
        public decimal Weight { get; set; }
        public string Unit { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
