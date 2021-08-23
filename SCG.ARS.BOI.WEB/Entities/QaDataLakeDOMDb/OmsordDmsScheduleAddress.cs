using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDmsScheduleAddress
    {
        public string Orderno { get; set; }
        public string Addressno { get; set; }
        public string Street { get; set; }
        public string Soi { get; set; }
        public string District { get; set; }
        public string Receivername { get; set; }
        public string Receivertel { get; set; }
        public string Adjacentremark { get; set; }
        public string Distfromsoi { get; set; }
        public string Unitdistance { get; set; }
        public string Usercreateby { get; set; }
        public string Usercreatedate { get; set; }
        public string Userupdateby { get; set; }
        public string Userupdatedate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
