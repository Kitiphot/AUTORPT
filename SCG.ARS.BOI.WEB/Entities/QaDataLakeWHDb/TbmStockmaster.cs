using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeWHDb
{
    public partial class TbmStockmaster
    {
        public int? CustomerId { get; set; }
        public int? StorageTypeId { get; set; }
        public decimal? LocationAreaM3 { get; set; }
        public decimal? LocationCharge { get; set; }
        public int? LocationPlan { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string DcType { get; set; }
        public int StockmasterId { get; set; }
    }
}
