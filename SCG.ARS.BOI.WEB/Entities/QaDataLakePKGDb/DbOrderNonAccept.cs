using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakePKGDb
{
    public partial class DbOrderNonAccept
    {
        public string TruckType { get; set; }
        public string DueDate { get; set; }
        public string Shipment { get; set; }
        public string SoldTo { get; set; }
        public string ShipTo { get; set; }
        public string Fleet { get; set; }
    }
}
