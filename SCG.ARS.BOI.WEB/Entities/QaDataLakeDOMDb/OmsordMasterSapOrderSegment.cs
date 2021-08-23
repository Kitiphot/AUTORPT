using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapOrderSegment
    {
        public string Segmenttype { get; set; }
        public string Segmentdesc { get; set; }
        public int Day { get; set; }
        public bool? Itineraryflag { get; set; }
        public bool? Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
