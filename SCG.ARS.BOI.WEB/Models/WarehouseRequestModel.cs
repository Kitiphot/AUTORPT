using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Models
{
    public partial class WarehouseRequestModel
    {
        public DateTime selectStartDate { get; set; }
        public DateTime selectEndDate { get; set; }
        public string reportType { get; set; }
        public List<int> selectCustomer { get; set; }
    }

    public partial class WarehouseRequestCDCModel
    {
        public DateTime selectStartDate { get; set; }
        public DateTime selectEndDate { get; set; }
        public List<int> selectDc { get; set; }
        public List<int> selectCustomer { get; set; }
        public string CountBy { get; set; }
    }
    public partial class WarehouseCDCRequestDateModel
    {
        public string selectStartDate { get; set; }
        public string selectEndDate { get; set; }
        public List<string> selectDc { get; set; }
        public List<string> selectCustomer { get; set; }
        public string CountBy { get; set; }
        public string CountByName { get; set; }
        public string selectCustomerName { get; set; }
        public string selectStatus { get; set; }
        public int? selectTime { get; set; }
        public bool? selectCheckMove { get; set; }
        public string selectlocationType { get; set; }
        public string selectDateType { get; set; }
        
    }

    public partial class WarehouseESCRequestDateModel
    {
        public string selectStartDate { get; set; }
        public string selectEndDate { get; set; }
        public List<int> selectDc { get; set; }
        public List<int> selectCustomer { get; set; }
        public string CountBy { get; set; }
        public string CountByName { get; set; }
        public string selectCustomerName { get; set; }
        public string selectStatus { get; set; }
        public int? selectTime { get; set; }
        public bool? selectCheckMove { get; set; }
        public string selectlocationType { get; set; }
        public string selectDateType { get; set; }

    }

    public partial class WarehouseOverAllRequestModel
    {
        public List<string> selectDc { get; set; }
        public List<string> selectCustomer { get; set; }
        public int? selectDay { get; set; }
        public int? selectMonth { get; set; }
        public int? selectYear { get; set; }

    }

    public partial class WarehouseRequestPickPackModel
    {
        public string selectPickStartDate { get; set; }
        public string selectPickEndDate { get; set; }
        public string selectPackStartDate { get; set; }
        public string selectPackEndDate { get; set; }
        public List<string> selectDc { get; set; }
        public List<string> selectCustomer { get; set; }
        public string selectCustomerName { get; set; }
        public List<string> selectProductGroup { get; set; }

    }

    public partial class WarehouseESCRequestPickPackModel
    {
        public string selectPickStartDate { get; set; }
        public string selectPickEndDate { get; set; }
        public string selectPackStartDate { get; set; }
        public string selectPackEndDate { get; set; }
        public List<int> selectDc { get; set; }
        public List<int> selectCustomer { get; set; }
        public string selectCustomerName { get; set; }

    }

    public partial class WarehouseRequestStockModel
    {
        public string selectDate { get; set; }
        public List<string> selectDc { get; set; }
        public List<string> selectCustomer { get; set; }
        public string selectCustomerName { get; set; }
        public string selectLocationtype { get; set; }
        public string selectAging { get; set; }
        public List<string> selectProductGroup { get; set; }
    }

    public partial class WarehouseESCRequestStockModel
    {
        public string selectDate { get; set; }
        public List<int> selectDc { get; set; }
        public List<int> selectCustomer { get; set; }
        public string selectCustomerName { get; set; }
        public string selectLocationtype { get; set; }
        public string selectAging { get; set; }
    }

}
