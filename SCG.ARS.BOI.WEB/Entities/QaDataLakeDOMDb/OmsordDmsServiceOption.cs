using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDmsServiceOption
    {
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public int Serviceoptionseq { get; set; }
        public string Serviceoptionname { get; set; }
        public string Serviceoptionvalue { get; set; }
        public string Serviceoptionremark { get; set; }
        public string Usercreateby { get; set; }
        public string Usercreatedate { get; set; }
        public string Userupdateby { get; set; }
        public string Userupdatedate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
