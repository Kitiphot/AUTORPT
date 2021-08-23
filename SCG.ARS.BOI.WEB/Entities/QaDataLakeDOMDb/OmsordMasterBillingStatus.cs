using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterBillingStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
