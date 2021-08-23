using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterVehicleType
    {
        public string Vehicletypecode { get; set; }
        public string Vehicletypename { get; set; }
        public decimal Capweight { get; set; }
        public string Capweightunit { get; set; }
        public decimal Capvolume { get; set; }
        public string Capvolumeunit { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
