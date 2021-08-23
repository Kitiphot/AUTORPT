using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterService
    {
        public string Id { get; set; }
        public int? Servicemodelid { get; set; }
        public string Name { get; set; }
        public string Limittimecalculate { get; set; }
        public string Dayprefercalculate { get; set; }
        public bool IsActive { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Inittimecalculate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
