using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterPricingDate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Interfacecode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
