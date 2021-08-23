using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class MetadataMasterTruckUtilization
    {
        public string TruckType { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? MaxVolume { get; set; }
    }
}
