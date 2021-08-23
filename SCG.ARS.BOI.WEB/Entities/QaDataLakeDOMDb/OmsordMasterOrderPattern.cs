using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterOrderPattern
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Istransport { get; set; }
        public bool? Iswarehouse { get; set; }
        public bool? Includeoutsource { get; set; }
        public int? Stocktypeid { get; set; }
        public string Interfacecode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
