using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterServiceItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Servicetypeid { get; set; }
        public bool Isrequired { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
