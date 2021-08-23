using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterProductGroup
    {
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Deleteflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
