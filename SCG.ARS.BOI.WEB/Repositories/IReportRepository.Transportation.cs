using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Packaging;

namespace SCG.ARS.BOI.WEB.Repositories {
    public partial interface IReportRepository
    {
        List<TransportationStatusModel> NotShipmentStatus(TransportationCriteria input);
        List<TransportationYearlyModel> NotShipmentYearly(TransportationCriteria input);
        List<TransportationMonthlyModel> NotShipmentMonthly(TransportationCriteria input);
        List<NotShipmentDetailModel> NotShipmentDetail(TransportationCriteria input);
        List<NotShipmentMonitoringDetailModel> NotShipmentMonitoringDetail(TransportationCriteria input);
        List<NotDNMonitoringDetailModel> NotDNDetail(TransportationCriteria input);
        List<TransportationStatusModel> NotGIStatus(TransportationCriteria input);
        List<TransportationYearlyModel> NotGIYearly(TransportationCriteria input);
        List<TransportationMonthlyModel> NotGIMonthly(TransportationCriteria input);
        List<NotGIDetailModel> NotGIDetail(TransportationCriteria input);
        List<TransportationStatusModel> PendingDocReturnStatus(TransportationCriteria input);
        List<TransportationStatusRawModel> NotDNStatus(TransportationCriteria input);
        List<TransportationStatusRawModel> NotShipmentStatusMonitor(TransportationCriteria input);
        List<TransportationNotDNByBusinessModel> NotDNByBusiness(TransportationCriteria input);
        List<TransportationNotDNByPlannerModel> NotDNByPlanner(TransportationCriteria input);
        List<TransportationNotShipmentByPlannerModel> NotShipmentByPlanner(TransportationCriteria input);
        List<TransportationNotShipmentByBusinessModel> NotShipmentByBusiness(TransportationCriteria input);
        List<TransportationYearlyModel> PendingDocReturnYearly(TransportationCriteria input);
        List<TransportationByCarrierModel> PendingDocReturnByCarrier(TransportationCriteria input);
        List<TransportationMonthlyModel> PendingDocReturnMonthly(TransportationCriteria input);
        List<PendingDocReturnDetailModel> PendingDocReturnDetail(TransportationCriteria input);
        List<LoadByDayModel> LoadByDay(TransportationCriteria input);
        List<LoadByCarrierModel> LoadByCarrier(TransportationCriteria input);
        List<LoadDetailModel> LoadDetail(TransportationCriteria input);
        List<OrderMonitoringStatusModel> OrderMonitoringStatus(OrderMonitoringCriteria input);
        List<OrderMonitoringStatusModel> ReturnOrderMonitoringStatus(OrderMonitoringCriteria input);
        OrderMonitoringSummaryModel OrderMonitoringSummary(OrderMonitoringCriteria input);
        List<OrderMonitoringByHubModel> OrderMonitoringByHub(OrderMonitoringCriteria input);
        List<OrderMonitoringByHubModel> ReturnOrderMonitoringByHub(OrderMonitoringCriteria input);
        List<OrderMonitoringShipmentModel> OrderMonitoringShipment(OrderMonitoringCriteria input);
        List<OrderMonitoringShipmentModel> ReturnOrderMonitoringShipment(OrderMonitoringCriteria input);
        List<MiscDataSelectionModel> GetCarrier();
        List<OntimeDetailModel> OntimeDetail(TransportationCriteria input);
        List<TransportationDamageYearlyModel> DamageYearly(TransportationCriteria input);
        List<TransportationDamageMonthlyModel> DamageMonthly(TransportationCriteria input);
        List<DamageDetailModel> DamageDetail(TransportationCriteria input);

        List<TransportationStatusRawModel> NotAcceptedStatus(TransportationCriteria input);
        List<TransportationByBusinessModel> NotAcceptedByBusiness(TransportationCriteria input);
        List<TransportationNotAcceptedByCarrierModel> NotAcceptedByCarrier(TransportationCriteria input);
        List<NotAcceptedDetailModel> NotAcceptedDetail(TransportationCriteria input);        
        List<TransportationStatusRawModel> NotGIMonitoringStatus(TransportationCriteria input);
        List<TransportationByBusinessModel> NotGIMonitoringByBusiness(TransportationCriteria input);
        List<TransportationByCarrierMonitoringModel> NotGIMonitoringByCarrier(TransportationCriteria input);
        List<NotGIMonitoringDetailModel> NotGIMonitoringDetail(TransportationCriteria input);

        List<TransportationDocReturnStatusMonitorModel> DocReturnStatus(TransportationCriteria input);
        List<TransportationByBusinessModel> DocReturnByBusiness(TransportationCriteria input);
        List<TransportationByCarrierMonitoringModel> DocReturnByCarrier(TransportationCriteria input);
        List<DocReturnMonitoringDetailModel> DocReturnDetail(TransportationCriteria input);

        List<TransportationPerformanceMonthlyModel> ShipmentMonthly(TransportationCriteria input);
        List<TransportationPerformanceSummaryMonthlyModel> ShipmentSummaryMonthly(TransportationCriteria input);
        List<TransportationPerformanceMonthlyDetailModel> ShipmentMonthlyDetail(TransportationCriteria input);

        List<TransportationPerformanceYearlyModel> ShipmentYearly(TransportationCriteria input);
        List<TransportationPerformanceYearlyDetailModel> ShipmentYearlyDetail(TransportationCriteria input);
        List<TransportationPerformanceSummaryYearlyModel> ShipmentSummaryYearly(TransportationCriteria input);        
        
        List<TransportationPerformanceMonthlyModel> TonMonthly(TransportationCriteria input);
        List<TransportationPerformanceSummaryMonthlyModel> TonSummaryMonthly(TransportationCriteria input);
        List<TransportationPerformanceMonthlyDetailModel> TonMonthlyDetail(TransportationCriteria input);

        List<TransportationPerformanceYearlyModel> TonYearly(TransportationCriteria input);
        List<TransportationPerformanceSummaryYearlyModel> TonSummaryYearly(TransportationCriteria input);
        List<TransportationPerformanceYearlyDetailModel> TonYearlyDetail(TransportationCriteria input);        
        
        List<TransportationPerformanceMonthlyModel> PieceMonthly(TransportationCriteria input);
        List<TransportationPerformanceSummaryMonthlyModel> PieceSummaryMonthly(TransportationCriteria input);
        List<TransportationPerformanceMonthlyDetailModel> PieceMonthlyDetail(TransportationCriteria input);

        List<TransportationPerformanceYearlyModel> PieceYearly(TransportationCriteria input);
        List<TransportationPerformanceSummaryYearlyModel> PieceSummaryYearly(TransportationCriteria input);
        List<TransportationPerformanceYearlyDetailModel> PieceYearlyDetail(TransportationCriteria input);        
        
        List<TransportationOntimeMonthlyModel> OntimeMonthly(TransportationCriteria input);
        List<TransportationOntimeSummaryMonthlyModel> OntimeSummaryMonthly(TransportationCriteria input);
        List<TransportationPerformanceMonthlyDetailModel> OntimeMonthlyDetail(TransportationCriteria input);

        List<TransportationOntimeYearlyModel> OntimeYearly(TransportationCriteria input);
        List<TransportationOntimeSummaryYearlyModel> OntimeSummaryYearly(TransportationCriteria input);
        List<TransportationPerformanceYearlyDetailModel> OntimeYearlyDetail(TransportationCriteria input);

        List<WaitingListStatusModel> WaitingListStatus(TransportationCriteria input);
        List<WaitingListMonthlyModel> WaitingListMonthly(TransportationCriteria input);
        List<RPTLPC004_ReportViewModel> RPTLPC004_Report(TransportationCriteria input);

        List<RejectMonthlyModel> RejectMonthly(TransportationCriteria input);
        List<RejectYearlyModel> RejectYearly(TransportationCriteria input);
        List<RPTLPC010_ReportViewModel> RPTLPC010_Report(TransportationCriteria input);

    }
}
