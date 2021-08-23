using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterUserCustomer
    {
        public string Userid { get; set; }
        public string Customercode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
