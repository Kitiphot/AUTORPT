using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstmanager
    {
        public string Functioncode { get; set; }
        public string Managercode { get; set; }
        public string Managername { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public bool Isactive { get; set; }
        public string Position { get; set; }
        public string Departmentcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
