using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterBillForm
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Transportmode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
