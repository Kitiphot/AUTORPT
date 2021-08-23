using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstcommumfgs
    {
        public string Commuditycode { get; set; }
        public string Mfgcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
