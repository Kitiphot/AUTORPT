using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterVehicleSubtype
    {
        public string Vehicletypecode { get; set; }
        public string Vehiclesubtypecode { get; set; }
        public string Vehiclesubtypename { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
