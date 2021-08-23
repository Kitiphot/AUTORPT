using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterSapShippingpointPlant
    {
        public string Sapshippingpointcode { get; set; }
        public string Sapshippingpointname { get; set; }
        public string Sapplantcode { get; set; }
        public bool Deleteflag { get; set; }
        public string Saptranzone { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
