using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Packaging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public partial interface IReportRepository// : IRestRepositoryBase 
    {
        //IEnumerable<T> FindAll();
        //Task<IEnumerable<TranshareModel>> ListAsync();
        DataTable GetReport01(DateTime? start_date, DateTime? end_date, List<int> dc_list ,List<int> customers_list);

        DataTable GetReport03(DateTime? start_date, DateTime? end_date, List<int> dc_list ,List<int> customers_list);

        DataTable GetReceiving(int customer_id);
        DataTable GetStockOnHand(int customer_id);
        DataTable GetDispatching(int customer_id);
        DataTable GetInventoryInquiry(int customer_id);
        DataTable GetPickPack(int customer_id);
        DataTable GetCheckMove(int customer_id);

        DataTable GetPalletControlDaily();
        DataTable GetNotShipment();
        DataTable GetNotGI();
        DataTable GetWaitingList();
        DataTable GetOrderCommit();
        DataTable GetDocumentReturn();
        DataTable GetOntime();
        DataTable GetReject();
        DataTable GetTruckUtilization();
        DataTable GetTranshare();
        
        List<RPTCDC001ReceivingViewModel> RPTCDC001_RecivingReport(WarehouseCDCRequestDateModel input);
        List<RPTCDC001ReceivingChartViewModel> RPTCDC001_RecivingReportChart(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer);
        List<RPTCDC001CompareReceivingChartViewModel> RPTCDC001_CompareReceivingChart(WarehouseCDCRequestDateModel input);
        List<RPTCDC001ReceivedByTimeViewModel> RPTCDC001ReceivedByTimePieChart(WarehouseCDCRequestDateModel input);
        List<RPTCDC001ReceivedByCustomerTimeViewModel> RPTCDC001ReceivedByCustomerTimeBarChart(WarehouseCDCRequestDateModel input);
        List<RPTCDC001ReceivedByCustomerTimeViewModel> RPTCDC001ReceivedByReceivedTimeBarChart(WarehouseCDCRequestDateModel input);
        
        List<RPTCDC001ReceivedSummaryViewModel> RPTCDC001ReceivedSummary(WarehouseCDCRequestDateModel input);
        List<RPTCDC001ReceivedSummaryTableViewModel> RPTCDC001ReceivedSummaryTable(WarehouseCDCRequestDateModel input);

        List<RPTCDC002StockOnHandViewModel> RPTCDC002_StockOnHandReport(WarehouseRequestStockModel input);
        List<RPTCDC002StockSummaryViewModel> RPTCDC002_StockSummary(WarehouseRequestStockModel input);
        List<RPTCDC002StockByLocationTypeViewModel> RPTCDC002_StockByLocationType(WarehouseRequestStockModel input);
        List<RPTCDC002StorageByCustomerLocationViewModel> RPTCDC002_StorageByCustomerLocation(WarehouseRequestStockModel input);
        List<RPTCDC002StorageByCustomerLocationPieceViewModel> RPTCDC002_StorageByCustomerLocationPiece(WarehouseRequestStockModel input);
        List<RPTCDC002StockByAgingViewModel> RPTCDC002_StockByAging(WarehouseRequestStockModel input);



        List<RPTCDC003DispatchingViewModel> RPTCDC003_DispatchingReport(WarehouseCDCRequestDateModel request);
        List<RPTCDC003DispatchSummaryViewModel> RPTCDC003DispatchSummary(WarehouseCDCRequestDateModel input);
        List<RPTCDC003CompareDispatchChartViewModel> RPTCDC003_CompareDispatchChart(WarehouseCDCRequestDateModel input);
        List<RPTCDC003DispatchSummaryTableViewModel> RPTCDC003_DispatchSummaryTable(WarehouseCDCRequestDateModel input);
        List<RPTCDC003DispatchByCustomerTimeViewModel> RPTCDC003DispatchByCustomerTimeChart(WarehouseCDCRequestDateModel input);
        List<RPTCDC003DispatchByCustomerTimeViewModel> RPTCDC003DispatchByCustomerCreateTimeChart(WarehouseCDCRequestDateModel input);
        List<RPTCDC003DispatchByTimeViewModel> RPTCDC003DispatchByTimeChart(WarehouseCDCRequestDateModel input);

        List<RPTCDC005PickPackSummaryViewModel> RPTCDC005_PickPackSummary(WarehouseRequestPickPackModel input);
        List<RPTCDC005PickByCustomerViewModel> RPTCDC005_PickByCustomer(WarehouseRequestPickPackModel input);
        List<RPTCDC005PackByCustomerViewModel> RPTCDC005_PackByCustomer(WarehouseRequestPickPackModel input);
        List<RPTCDC005PickPackViewModel> RPTCDC005_PickPackReport(WarehouseRequestPickPackModel input);

        List<RPTCDC006CheckMoveQtyViewModel> RPTCDC006_CheckMoveQty(WarehouseCDCRequestDateModel input);
        List<RPTCDC006CheckMoveViewModel> RPTCDC006_CheckMoveReport(WarehouseCDCRequestDateModel input);
        List<RPTCDC006CheckMoveByLocationViewModel> RPTCDC006_CheckMoveByLocation(WarehouseCDCRequestDateModel input);
        
        
        List<RPTCDC000ReceiveAccuracyViewModel> RPTCDC000_ReceiveAccuracy(WarehouseOverAllRequestModel input);
        List<RPTCDC000DispatchAccuracyViewModel> RPTCDC000_DispatchAccuracy(WarehouseOverAllRequestModel input);
        List<RPTCDC000ReceiveDispatchViewModel> RPTCDC000_ReceiveDispatch(WarehouseOverAllRequestModel input);
        List<RPTCDC000StockUtilizationViewModel> RPTCDC000_StockUtilization(WarehouseOverAllRequestModel input);
        List<RPTCDC000AgingProductViewModel> RPTCDC000_AgingProduct(WarehouseOverAllRequestModel input);


        List<RPTCDC004InventoryInquiryViewModel> RPTCDC004_InventoryInquiryReport(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer);
        List<RPTCDC007ReportForLPCViewModel> RPT007_ReportForLPC(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer);

        List<RPTESC003InventoryInquiryViewModel> RPTESC003_InventoryInquiryReport(DateTime selectStartDate, DateTime selectEndDate, List<int> selectCustomer);
        //List<RPTESC004CheckMoveViewModel> RPTESC004_CheckMoveReport(WarehouseRequestDateModel input);
        
        List<RPTLPC001ViewModel> RPTLPC001_Report(TransportationCriteria request);
        //List<RPTLPC001ViewModel> RPTLPC001_Report(string business,string fleet,string shipping_point,string shipto_region,string mat_group,string order_type,string truck_type,string planner_name,string search_day,string search_month,string search_year,string status,string carrier,string aging);
        List<RPT001GRGIReportViewModel> RPT001_GRGIReports();
        List<RPT002PROSTAReportViewModel> RPT002_PROSTAReports();


        List<RPTESC001CompareReceivingChartViewModel> RPTESC001_CompareReceivingChart(WarehouseESCRequestDateModel input);
        List<RPTESC001ReceivedSummaryTableViewModel> RPTESC001ReceivedSummaryTable(WarehouseESCRequestDateModel input);
        List<RPTESC001ReceivedSummaryViewModel> RPTESC001ReceivedSummary(WarehouseESCRequestDateModel input);
        List<RPTESC001ReceivedByCustomerTimeViewModel> RPTESC001ReceivedByCustomerTimeBarChart(WarehouseESCRequestDateModel input);
        List<RPTESC001ReceivedByTimeViewModel> RPTESC001ReceivedByTimePieChart(WarehouseESCRequestDateModel input);
        List<RPTESC001ReceivingViewModel> RPTESC001_RecivingReport(WarehouseESCRequestDateModel input);

        List<RPTESC002CompareDispatchChartViewModel> RPTESC002_CompareDispatchChart(WarehouseESCRequestDateModel input);
        List<RPTESC002DispatchSummaryTableViewModel> RPTESC002_DispatchSummaryTable(WarehouseESCRequestDateModel input);
        List<RPTESC002DispatchSummaryViewModel> RPTESC002DispatchSummary(WarehouseESCRequestDateModel input);
        List<RPTESC002DispatchByCustomerTimeViewModel> RPTESC002DispatchByCustomerTimeChart(WarehouseESCRequestDateModel input);
        List<RPTESC002DispatchByTimeViewModel> RPTESC002DispatchByTimeChart(WarehouseESCRequestDateModel input);
        List<RPTESC002DispatchingViewModel> RPTESC002_DispatchingReport(WarehouseESCRequestDateModel input);
        

        List<RPTESC003StockSummaryViewModel> RPTESC003_StockSummary(WarehouseESCRequestStockModel input);
        List<RPTESC003StockByLocationTypeViewModel> RPTESC003_StockByLocationType(WarehouseESCRequestStockModel input);
        List<RPTESC003StorageByCustomerLocationViewModel> RPTESC003_StorageByCustomerLocation(WarehouseESCRequestStockModel input);
        List<RPTESC003StorageByCustomerLocationPieceViewModel> RPTESC003_StorageByCustomerLocationPiece(WarehouseESCRequestStockModel input);
        List<RPTESC003StockByAgingViewModel> RPTESC003_StockByAging(WarehouseESCRequestStockModel input);
        List<RPTESC003StockOnHandViewModel> RPTESC003_StockOnHandReport(WarehouseESCRequestStockModel input);

        List<RPTESC004CheckMoveByLocationViewModel> RPTESC004_CheckMoveByLocation(WarehouseESCRequestDateModel input);
        List<RPTESC004CheckMoveViewModel> RPTESC004_CheckMoveReport(WarehouseESCRequestDateModel input);
        List<RPTESC004CheckMoveQtyViewModel> RPTESC004_CheckMoveQty(WarehouseESCRequestDateModel input);

        List<RPTESC005PickByCustomerViewModel> RPTESC005_PickByCustomer(WarehouseESCRequestPickPackModel input);
        List<RPTESC005PackByCustomerViewModel> RPTESC005_PackByCustomer(WarehouseESCRequestPickPackModel input);
        List<RPTESC005PickPackViewModel> RPTESC005_PickPackReport(WarehouseESCRequestPickPackModel input);
        List<RPTESC005PickPackSummaryViewModel> RPTESC005_PickPackSummary(WarehouseESCRequestPickPackModel input);

        Task<(bool, List<MiscDataSelectionModel>)> RPTWH_GetCustomer(string warehouse,List<string> dc);
        Task<(bool, List<MiscDataSelectionModel>)> RPTWH_GetProductGroup(string warehouse);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetCustomer(string[] customerCode,string customer);
        Task<(bool, List<MiscDataSelectionModel>)> RPTWHESC_GetCustomer(string warehouse,List<int> dc);
        Task<(bool, List<MiscDataSelectionModel>)> RPTWH_GetDC(string selectDcType);
        Task<(bool, List<MiscDataSelectionModel>)> RPTWHESC_GetDC(string selectDcType);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetBusiness(TransportationRequestCommonModel input);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetFleet(TransportationRequestCommonModel input);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetShippingPoint(TransportationRequestCommonModel input);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetShiptoRegion(TransportationRequestCommonModel input);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetMatfrg(TransportationRequestCommonModel input);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetOrderType(string order_type_name);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetTruckType(string equipment_type_code);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetPlannerName(string planner_name);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetOrderPlannerName(string planner_name);
        Task<(bool, List<MiscDataTestComboModel>)> RPTLPC_GetOrderPlannerNameTest(string planner_name,string term);
        Task<(bool, List<MiscDataSelectionModel>)> RPTLPC_GetCustomerTest(string customer,string term);

        List<LineMessageModel> GetTransportationLineMessage01();
		List<LineMessageModel> GetTransportationLineMessage02();
	}
}