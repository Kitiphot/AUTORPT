using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterServiceOptionMapping
    {
        public int Id { get; set; }
        public string SapFieldName { get; set; }
        public string ServiceOptionName { get; set; }
        public string FieldName { get; set; }
        public bool? ActiveStatus { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
