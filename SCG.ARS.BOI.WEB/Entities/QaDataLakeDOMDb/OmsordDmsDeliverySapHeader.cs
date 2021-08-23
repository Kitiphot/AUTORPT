using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDmsDeliverySapHeader
    {
        public string Dnnumber { get; set; }
        public string Legheader { get; set; }
        public int Legid { get; set; }
        public string Orderscheduleline { get; set; }
        public string Scheduledatetime { get; set; }
        public string Serviceoption { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
