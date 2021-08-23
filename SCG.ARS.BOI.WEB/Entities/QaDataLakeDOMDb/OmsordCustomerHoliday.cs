using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordCustomerHoliday
    {
        public string Customercode { get; set; }
        public string Holidayname { get; set; }
        public string Holidaydate { get; set; }
        public bool IsActive { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
