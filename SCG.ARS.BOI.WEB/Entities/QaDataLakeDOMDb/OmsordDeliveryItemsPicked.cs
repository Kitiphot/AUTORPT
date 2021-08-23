using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDeliveryItemsPicked
    {
        public string Refdnnumber { get; set; }
        public int Dnitem { get; set; }
        public string Sonumber { get; set; }
        public int Soitemnumber { get; set; }
        public int Legid { get; set; }
        public string Transactionid { get; set; }
        public bool Receivedflag { get; set; }
        public string Issuedatetime { get; set; }
        public string Reason { get; set; }
        public string Deliverytype { get; set; }
        public string Stampdatetime { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
