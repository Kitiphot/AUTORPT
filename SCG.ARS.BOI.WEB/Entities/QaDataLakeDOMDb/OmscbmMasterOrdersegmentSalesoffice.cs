using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmMasterOrdersegmentSalesoffice
    {
        public string Ordergroup { get; set; }
        public string Sapshippingpointcode { get; set; }
        public string Salesoffice { get; set; }
        public bool Activeflag { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public int Ordersegmentid { get; set; }
        public int Systemid { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
