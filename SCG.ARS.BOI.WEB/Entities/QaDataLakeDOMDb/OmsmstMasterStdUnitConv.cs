using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterStdUnitConv
    {
        public string Baseunitcode { get; set; }
        public string Alterunitcode { get; set; }
        public decimal Basequantity { get; set; }
        public decimal Alterquantity { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
