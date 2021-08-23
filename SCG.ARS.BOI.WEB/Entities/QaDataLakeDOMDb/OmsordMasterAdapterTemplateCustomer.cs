using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterAdapterTemplateCustomer
    {
        public int Adapterid { get; set; }
        public string Customerid { get; set; }
        public string Displayname { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
