using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapTransportZone
    {
        public string Regioncode { get; set; }
        public string Subregioncode { get; set; }
        public string Transportzonecode { get; set; }
        public string Transportzonedesc { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
