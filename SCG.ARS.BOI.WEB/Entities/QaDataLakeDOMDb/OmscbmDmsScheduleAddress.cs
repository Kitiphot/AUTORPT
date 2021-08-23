using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmDmsScheduleAddress
    {
        public string Orderno { get; set; }
        public string Addressno { get; set; }
        public string Street { get; set; }
        public string Soi { get; set; }
        public string District { get; set; }
        public string Receivername { get; set; }
        public string Receivetel { get; set; }
        public string Adjacentremark { get; set; }
        public string Distfromsoi { get; set; }
        public string Createdby { get; set; }
        public string Createddate { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public string Unitdistance { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
