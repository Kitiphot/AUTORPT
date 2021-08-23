using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDmsScheduleHeader
    {
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public decimal? Schduqty { get; set; }
        public decimal? Schdugrossqty { get; set; }
        public decimal? Schdudeliveryqty { get; set; }
        public string Schdudate { get; set; }
        public string Schdudeliverycreatedate { get; set; }
        public string Pageflag { get; set; }
        public string Conflictdmstatus { get; set; }
        public bool Backorderflag { get; set; }
        public bool Biglotorderflag { get; set; }
        public bool Completeorderflag { get; set; }
        public string Omscreateddate { get; set; }
        public string Omscreatedby { get; set; }
        public string Omsupdateddate { get; set; }
        public string Omsupdatedby { get; set; }
        public string Omsshipmentmemo { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
