using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmConvTruckCommitted
    {
        public int Fleetid { get; set; }
        public string Committeddate { get; set; }
        public string Vehicletypecode { get; set; }
        public int Committedamount { get; set; }
        public int Sparedamount { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
