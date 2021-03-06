using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmMasterTruckCommittedHistory
    {
        public long Historyid { get; set; }
        public int Fleetid { get; set; }
        public string Committeddate { get; set; }
        public string Vehicletypecode { get; set; }
        public int Bookedamount { get; set; }
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public int Systemid { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public int Bookedsparedamount { get; set; }
        public int Committedamount { get; set; }
        public int Sparedamount { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
