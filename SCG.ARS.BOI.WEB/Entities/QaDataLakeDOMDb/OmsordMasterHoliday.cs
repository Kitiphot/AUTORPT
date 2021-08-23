using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterHoliday
    {
        public int Holidayid { get; set; }
        public string Holidayname { get; set; }
        public string Holidaydate { get; set; }
        public bool IsActive { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
