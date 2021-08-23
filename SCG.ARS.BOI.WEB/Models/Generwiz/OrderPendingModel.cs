using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Generwiz
{
    public class OrderPendingModel
    {
        public string businessgroup { get; set; }
        public string customergroup { get; set; }
        public string productgroup { get; set; }
        public int toltallasttender { get; set; } //Last Tender
        public int toltaltender { get; set; } //Tender
        public int toltaltenderwaiting { get; set; } //Tender (order ที่ tender จากกลุ่ม waiting list)
        public int toltalcreatewaiting { get; set; } //Create Order (sap)
        public int toltalrequestedwaiting { get; set; } //Requested Date (OMS)
        public int toltalrequestedbooking { get; set; } //Today -7
        public int toltalordersamedaybooking { get; set; } //Order Same Day
        public int toltalorderleadtimebooking { get; set; } //Order Leadtime
        public int toltalrank { get; set; } //ORank
    }
}
