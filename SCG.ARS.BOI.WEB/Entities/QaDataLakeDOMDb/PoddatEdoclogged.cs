using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatEdoclogged
    {
        public int Loggedid { get; set; }
        public Instant Loggeddate { get; set; }
        public string Loggedinuser { get; set; }
        public string Documentno { get; set; }
        public string Documenttype { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
