using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Models
{
    public partial class TransportationRequestMonthYearModel
    {
        public int? selectDaySearch { get; set; }
        public int? selectMonth { get; set; }
        public int? selectYear { get; set; }
        public string selectBussinessGroup { get; set; }
        public int? selectFleet { get; set; }
        public string selectShippingPointCode { get; set; }
        public string selectRegionCode { get; set; }
        public string selectOrderTypeCode { get; set; }
        public string selectEquipmentCode { get; set; }
        public string selectPlannerName { get; set; }
        public string selectMatfrg { get; set; }
        public string iStatus { get; set; }
        public string iCarier { get; set; }
        public string iAging { get; set; }
        public DateTime selectDateFrom { get; set; }
        public DateTime selectDateTo { get; set; }


    }
    
    public partial class TransportationRequestCommonModel
    {
        public List<string> selectBusiness { get; set; }
        public List<int> selectFleet { get; set; }
        public List<string> selectMatfreight { get; set; }
        public List<string> selectShippingpoint { get; set; }
        public List<string> selectRegion { get; set; }

    }


}
