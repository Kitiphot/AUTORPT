using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterVehicleSubtype
    {
        public string Vehiclesubtypecode { get; set; }
        public string Vehiclesubtypename { get; set; }
        public string Vehicletypecode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
