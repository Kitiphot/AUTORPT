using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordRunningNumberConfig
    {
        public int RunningConfigId { get; set; }
        public string RunningConfigName { get; set; }
        public string Prefix1 { get; set; }
        public string Prefix2 { get; set; }
        public string Prefix3 { get; set; }
        public string Number1From { get; set; }
        public string Number1To { get; set; }
        public string Number2From { get; set; }
        public string Number2To { get; set; }
        public string Number3From { get; set; }
        public string Number3To { get; set; }
        public string Description { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
