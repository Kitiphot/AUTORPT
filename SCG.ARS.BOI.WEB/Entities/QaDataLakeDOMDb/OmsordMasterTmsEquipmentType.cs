using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterTmsEquipmentType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
