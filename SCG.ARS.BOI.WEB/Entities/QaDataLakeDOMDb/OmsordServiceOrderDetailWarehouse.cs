using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderDetailWarehouse
    {
        public string Sonumber { get; set; }
        public int Stocktypeid { get; set; }
        public string Locationcode { get; set; }
        public string Locationname { get; set; }
        public string Outsourcecode { get; set; }
        public string Expiredate { get; set; }
        public string Manufacturedate { get; set; }
        public string Warehousebatchno { get; set; }
        public string Whref1 { get; set; }
        public string Whref2 { get; set; }
        public string Whref3 { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
