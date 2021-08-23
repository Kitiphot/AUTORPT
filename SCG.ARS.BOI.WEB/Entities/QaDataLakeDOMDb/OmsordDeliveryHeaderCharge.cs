using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDeliveryHeaderCharge
    {
        public string Dnnumber { get; set; }
        public string Legheader { get; set; }
        public string Refdnnumber { get; set; }
        public string Chargetype { get; set; }
        public decimal Chargeamount { get; set; }
        public string Chargeunit { get; set; }
        public string Applyapoption { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Deliverytype { get; set; }
        public bool Deleteflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
