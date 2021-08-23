using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmMasterFleetVehicleType
    {
        public int Fleetid { get; set; }
        public string Vehicletypecode { get; set; }
        public int Priority { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public bool Bymaterialflag { get; set; }
        public bool Bysoldtoflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
