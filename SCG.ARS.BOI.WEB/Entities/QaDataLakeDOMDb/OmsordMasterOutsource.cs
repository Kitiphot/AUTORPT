using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterOutsource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Istransport { get; set; }
        public bool? Iswarehouse { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
