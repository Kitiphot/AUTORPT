using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitDeliveryItemsPackedMapping
    {
        public string Refdnnumber { get; set; }
        public int Dnitem { get; set; }
        public string Sonumber { get; set; }
        public int Soitemnumber { get; set; }
        public int Legid { get; set; }
        public string Materialcode { get; set; }
        public string Refmaterialcode { get; set; }
        public string Transactionid { get; set; }
        public decimal Quantity { get; set; }
        public bool Deleteflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
