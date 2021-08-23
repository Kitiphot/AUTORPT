using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterCustomerChannel
    {
        public int Channelid { get; set; }
        public string Channelname { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
