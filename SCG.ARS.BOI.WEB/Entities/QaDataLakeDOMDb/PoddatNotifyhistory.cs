using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatNotifyhistory
    {
        public int Notifyid { get; set; }
        public string Recipient { get; set; }
        public string Notititle { get; set; }
        public string Notimessage { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public Instant Sendeddate { get; set; }
        public Instant? Readeddate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
