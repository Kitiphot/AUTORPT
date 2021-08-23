using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterWorkingday
    {
        public int Workingdayid { get; set; }
        public string Workingdayname { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
