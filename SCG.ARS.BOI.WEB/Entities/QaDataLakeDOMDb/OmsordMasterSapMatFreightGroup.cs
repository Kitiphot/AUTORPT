using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapMatFreightGroup
    {
        public string Matfrtgrpcode { get; set; }
        public string Matfrtgrpdesc { get; set; }
        public bool Deleteflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
