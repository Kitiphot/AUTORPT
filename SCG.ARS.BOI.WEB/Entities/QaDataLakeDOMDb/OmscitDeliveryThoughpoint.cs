using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitDeliveryThoughpoint
    {
        public string Dnnumber { get; set; }
        public string Sonumber { get; set; }
        public string Refdnnumber { get; set; }
        public string Legheader { get; set; }
        public int Legid { get; set; }
        public short Sequence { get; set; }
        public string Locationcode { get; set; }
        public string Locationtype { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
