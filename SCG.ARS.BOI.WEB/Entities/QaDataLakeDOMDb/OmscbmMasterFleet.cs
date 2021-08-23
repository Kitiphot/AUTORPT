using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmMasterFleet
    {
        public string Fleetname { get; set; }
        public bool Activeflag { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public int Fleetid { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
