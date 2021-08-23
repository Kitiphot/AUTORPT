using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCG.ARS.BOI.WEB.Models
{
    public class MiscDataModel
    {
        public int MiscData_Id { get; set; }
        public string Field_Name { get; set; }
        public string DataValue_Key { get; set; }
        public string DataDisplay { get; set; }
        public int Sorting_No { get; set; }
        public int Display_Flag { get; set; }
        public string CreateUser_Code { get; set; }
        public string Create_DateTime { get; set; }
        public string UpdateUser_Code { get; set; }
        public string Update_DateTime { get; set; }
    }

    public class MiscDataSelectionModel
    {
        public string DataValue_Key { get; set; }
        public string DataDisplay { get; set; }
    }

    public class MiscDataTestComboModel
    {
        public string id { get; set; }
        public string text { get; set; }
    }
    public class MiscDataSelectionWithRawModel : MiscDataSelectionModel
    {
        public string Json { get; set; }
    }
    public class MiscDataSelectionWithDataModel : MiscDataSelectionModel
    {
        public bool IsSubItem { get; set; }
        public string ParentKey { get; set; }
        public string ParentText { get; set; }
    }
    public class BankFormatModel
    {
        public int BankFormat_Id { get; set; }
        public string BankSegmentGroup_Code { get; set; }
        public string BankSegmentType_Code { get; set; }
        public int FormatSeq_No { get; set; }
        public int PosStart_No { get; set; }
        public int PosEnd_No { get; set; }
        public int Length_No { get; set; }
        public string DataType_Code { get; set; }
        public string Format_Name { get; set; }
        public string FormatDescription { get; set; }
        public int Usage_Flag { get; set; }
        public int Mapping_Flag { get; set; }
        public string CreateUser_Code { get; set; }
        public string Create_DateTime { get; set; }
        public string UpdateUser_Code { get; set; }
        public string Update_DateTime { get; set; }
    }
    public class ListMiscDataViewModel
    {
        public List<MiscDataModel> Misc { get; set; }
    }

    public class ListMiscDataSelectionViewModel
    {
        public List<MiscDataSelectionModel> ReportType { get; set; }
        public List<MiscDataSelectionModel> Customer { get; set; }
        public List<MiscDataSelectionModel> CustomerTransport { get; set; }
        public List<MiscDataSelectionModel> Location { get; set; }
        public List<MiscDataSelectionModel> Business { get; set; }
        public List<MiscDataSelectionModel> Fleet { get; set; }
        public List<MiscDataSelectionModel> Shipping_Point { get; set; }
        public List<MiscDataSelectionModel> Shipto_Region { get; set; }
        public List<MiscDataSelectionModel> Matfrg { get; set; }
        public List<MiscDataSelectionModel> Order_Type { get; set; }
        public List<MiscDataSelectionModel> Truck_Type { get; set; }
        public List<MiscDataSelectionModel> Planner_Name { get; set; }
        public List<MiscDataSelectionModel> Service { get; set; }
        public List<MiscDataSelectionModel> Warehouse { get; set; }
        public List<MiscDataSelectionModel> Productgroup { get; set; }

    }
}