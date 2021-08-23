using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcTmsLoadMemo
    {
        public string LoadId { get; set; }
        public string LoadPrtbCtnt { get; set; }
        public string LoadNonPrtbCtnt { get; set; }
        public byte[] Rowversion { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
