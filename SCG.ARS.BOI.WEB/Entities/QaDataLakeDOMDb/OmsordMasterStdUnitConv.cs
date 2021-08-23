using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterStdUnitConv
    {
        public string Baseunit { get; set; }
        public string Alterunit { get; set; }
        public int Basequantity { get; set; }
        public int Alterquantity { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
