using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class QaDOMContext : DbContext
    {
        public QaDOMContext()
        {
        }

        public QaDOMContext(DbContextOptions<QaDOMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MetadataMasterBusinessGroup> MetadataMasterBusinessGroup { get; set; }
        public virtual DbSet<MetadataMasterTruckUtilization> MetadataMasterTruckUtilization { get; set; }
        public virtual DbSet<OmscbmBookPlan> OmscbmBookPlan { get; set; }
        public virtual DbSet<OmscbmConvTruckCommitted> OmscbmConvTruckCommitted { get; set; }
        public virtual DbSet<OmscbmDmsOrderHeader> OmscbmDmsOrderHeader { get; set; }
        public virtual DbSet<OmscbmDmsOrderItem> OmscbmDmsOrderItem { get; set; }
        public virtual DbSet<OmscbmDmsOrderPending> OmscbmDmsOrderPending { get; set; }
        public virtual DbSet<OmscbmDmsOrderPlan> OmscbmDmsOrderPlan { get; set; }
        public virtual DbSet<OmscbmDmsScheduleAddress> OmscbmDmsScheduleAddress { get; set; }
        public virtual DbSet<OmscbmDmsScheduleHeaderPlan> OmscbmDmsScheduleHeaderPlan { get; set; }
        public virtual DbSet<OmscbmDmsScheduleItemPlan> OmscbmDmsScheduleItemPlan { get; set; }
        public virtual DbSet<OmscbmDmsScheduleReportDmreqPlan> OmscbmDmsScheduleReportDmreqPlan { get; set; }
        public virtual DbSet<OmscbmDmsScheduleReportStatusPlan> OmscbmDmsScheduleReportStatusPlan { get; set; }
        public virtual DbSet<OmscbmDmsServiceOption> OmscbmDmsServiceOption { get; set; }
        public virtual DbSet<OmscbmMasterFleet> OmscbmMasterFleet { get; set; }
        public virtual DbSet<OmscbmMasterFleetShippointMatfreight> OmscbmMasterFleetShippointMatfreight { get; set; }
        public virtual DbSet<OmscbmMasterFleetVehicleType> OmscbmMasterFleetVehicleType { get; set; }
        public virtual DbSet<OmscbmMasterOrdersegmentSalesoffice> OmscbmMasterOrdersegmentSalesoffice { get; set; }
        public virtual DbSet<OmscbmMasterSaleArea> OmscbmMasterSaleArea { get; set; }
        public virtual DbSet<OmscbmMasterTruckCommitted> OmscbmMasterTruckCommitted { get; set; }
        public virtual DbSet<OmscbmMasterTruckCommittedHistory> OmscbmMasterTruckCommittedHistory { get; set; }
        public virtual DbSet<OmscbmMasterTruckQueue> OmscbmMasterTruckQueue { get; set; }
        public virtual DbSet<OmscbmMasterVehicleType> OmscbmMasterVehicleType { get; set; }
        public virtual DbSet<OmscbmOrderScheduleSplitQueue> OmscbmOrderScheduleSplitQueue { get; set; }
        public virtual DbSet<OmscitDeliveryHeader> OmscitDeliveryHeader { get; set; }
        public virtual DbSet<OmscitDeliveryHeaderServiceOptions> OmscitDeliveryHeaderServiceOptions { get; set; }
        public virtual DbSet<OmscitDeliveryItems> OmscitDeliveryItems { get; set; }
        public virtual DbSet<OmscitDeliveryItemsGoodIssue> OmscitDeliveryItemsGoodIssue { get; set; }
        public virtual DbSet<OmscitDeliveryItemsPacked> OmscitDeliveryItemsPacked { get; set; }
        public virtual DbSet<OmscitDeliveryItemsPackedMapping> OmscitDeliveryItemsPackedMapping { get; set; }
        public virtual DbSet<OmscitDeliveryItemsPicked> OmscitDeliveryItemsPicked { get; set; }
        public virtual DbSet<OmscitDeliverySapGoodIssue> OmscitDeliverySapGoodIssue { get; set; }
        public virtual DbSet<OmscitDeliverySapHeader> OmscitDeliverySapHeader { get; set; }
        public virtual DbSet<OmscitDeliveryThoughpoint> OmscitDeliveryThoughpoint { get; set; }
        public virtual DbSet<OmscitJobIntransitDetail> OmscitJobIntransitDetail { get; set; }
        public virtual DbSet<OmscitJobIntransitHeader> OmscitJobIntransitHeader { get; set; }
        public virtual DbSet<OmscitJobIntransitInfo> OmscitJobIntransitInfo { get; set; }
        public virtual DbSet<OmscitJobIntransitItem> OmscitJobIntransitItem { get; set; }
        public virtual DbSet<OmscitMasterSapCarrier> OmscitMasterSapCarrier { get; set; }
        public virtual DbSet<OmsmstMasterAmphur> OmsmstMasterAmphur { get; set; }
        public virtual DbSet<OmsmstMasterBillForm> OmsmstMasterBillForm { get; set; }
        public virtual DbSet<OmsmstMasterBusinessGroup> OmsmstMasterBusinessGroup { get; set; }
        public virtual DbSet<OmsmstMasterCustomerChannel> OmsmstMasterCustomerChannel { get; set; }
        public virtual DbSet<OmsmstMasterCustomerMaterial> OmsmstMasterCustomerMaterial { get; set; }
        public virtual DbSet<OmsmstMasterCustomerProfile> OmsmstMasterCustomerProfile { get; set; }
        public virtual DbSet<OmsmstMasterDistrict> OmsmstMasterDistrict { get; set; }
        public virtual DbSet<OmsmstMasterEndCustomer> OmsmstMasterEndCustomer { get; set; }
        public virtual DbSet<OmsmstMasterLocation> OmsmstMasterLocation { get; set; }
        public virtual DbSet<OmsmstMasterLocationType> OmsmstMasterLocationType { get; set; }
        public virtual DbSet<OmsmstMasterMaterial> OmsmstMasterMaterial { get; set; }
        public virtual DbSet<OmsmstMasterMaterialBom> OmsmstMasterMaterialBom { get; set; }
        public virtual DbSet<OmsmstMasterMaterialUnitConv> OmsmstMasterMaterialUnitConv { get; set; }
        public virtual DbSet<OmsmstMasterMatfrtgrp> OmsmstMasterMatfrtgrp { get; set; }
        public virtual DbSet<OmsmstMasterOriginLocation> OmsmstMasterOriginLocation { get; set; }
        public virtual DbSet<OmsmstMasterPricingDate> OmsmstMasterPricingDate { get; set; }
        public virtual DbSet<OmsmstMasterProductGroup> OmsmstMasterProductGroup { get; set; }
        public virtual DbSet<OmsmstMasterProvince> OmsmstMasterProvince { get; set; }
        public virtual DbSet<OmsmstMasterRegion> OmsmstMasterRegion { get; set; }
        public virtual DbSet<OmsmstMasterSapAmphur> OmsmstMasterSapAmphur { get; set; }
        public virtual DbSet<OmsmstMasterSapMatFreightGroup> OmsmstMasterSapMatFreightGroup { get; set; }
        public virtual DbSet<OmsmstMasterSapProvince> OmsmstMasterSapProvince { get; set; }
        public virtual DbSet<OmsmstMasterSapShippingpoint> OmsmstMasterSapShippingpoint { get; set; }
        public virtual DbSet<OmsmstMasterSapShippingpointPlant> OmsmstMasterSapShippingpointPlant { get; set; }
        public virtual DbSet<OmsmstMasterSapShipto> OmsmstMasterSapShipto { get; set; }
        public virtual DbSet<OmsmstMasterSapShiptoAmphur> OmsmstMasterSapShiptoAmphur { get; set; }
        public virtual DbSet<OmsmstMasterStdUnitConv> OmsmstMasterStdUnitConv { get; set; }
        public virtual DbSet<OmsmstMasterUnit> OmsmstMasterUnit { get; set; }
        public virtual DbSet<OmsmstMasterVehicleSubtype> OmsmstMasterVehicleSubtype { get; set; }
        public virtual DbSet<OmsmstMasterVehicleType> OmsmstMasterVehicleType { get; set; }
        public virtual DbSet<OmsordActTransportService> OmsordActTransportService { get; set; }
        public virtual DbSet<OmsordBatchOrderUpload> OmsordBatchOrderUpload { get; set; }
        public virtual DbSet<OmsordBillHeader> OmsordBillHeader { get; set; }
        public virtual DbSet<OmsordBillItem> OmsordBillItem { get; set; }
        public virtual DbSet<OmsordBillItemGroup> OmsordBillItemGroup { get; set; }
        public virtual DbSet<OmsordBkDeliverySapHeader> OmsordBkDeliverySapHeader { get; set; }
        public virtual DbSet<OmsordBkDeliverySapItem> OmsordBkDeliverySapItem { get; set; }
        public virtual DbSet<OmsordConfigBiglotOrder> OmsordConfigBiglotOrder { get; set; }
        public virtual DbSet<OmsordConfigShippingPointAuto> OmsordConfigShippingPointAuto { get; set; }
        public virtual DbSet<OmsordCustomerHoliday> OmsordCustomerHoliday { get; set; }
        public virtual DbSet<OmsordCustomerServiceExpress> OmsordCustomerServiceExpress { get; set; }
        public virtual DbSet<OmsordCustomerServiceLeadtime> OmsordCustomerServiceLeadtime { get; set; }
        public virtual DbSet<OmsordCustomerServiceWindow> OmsordCustomerServiceWindow { get; set; }
        public virtual DbSet<OmsordCustomerServiceWindowSchedule> OmsordCustomerServiceWindowSchedule { get; set; }
        public virtual DbSet<OmsordCustomerWorkingday> OmsordCustomerWorkingday { get; set; }
        public virtual DbSet<OmsordDeliveryHeader> OmsordDeliveryHeader { get; set; }
        public virtual DbSet<OmsordDeliveryHeaderCharge> OmsordDeliveryHeaderCharge { get; set; }
        public virtual DbSet<OmsordDeliveryHeaderServiceOptions> OmsordDeliveryHeaderServiceOptions { get; set; }
        public virtual DbSet<OmsordDeliveryItems> OmsordDeliveryItems { get; set; }
        public virtual DbSet<OmsordDeliveryItemsGoodIssue> OmsordDeliveryItemsGoodIssue { get; set; }
        public virtual DbSet<OmsordDeliveryItemsGoodReceive> OmsordDeliveryItemsGoodReceive { get; set; }
        public virtual DbSet<OmsordDeliveryItemsPacked> OmsordDeliveryItemsPacked { get; set; }
        public virtual DbSet<OmsordDeliveryItemsPackedMapping> OmsordDeliveryItemsPackedMapping { get; set; }
        public virtual DbSet<OmsordDeliveryItemsPicked> OmsordDeliveryItemsPicked { get; set; }
        public virtual DbSet<OmsordDeliverySapCharge> OmsordDeliverySapCharge { get; set; }
        public virtual DbSet<OmsordDeliverySapHeader> OmsordDeliverySapHeader { get; set; }
        public virtual DbSet<OmsordDeliverySapItem> OmsordDeliverySapItem { get; set; }
        public virtual DbSet<OmsordDeliveryThoughpoint> OmsordDeliveryThoughpoint { get; set; }
        public virtual DbSet<OmsordDmsDeliverySapHeader> OmsordDmsDeliverySapHeader { get; set; }
        public virtual DbSet<OmsordDmsOmsScheduleLines> OmsordDmsOmsScheduleLines { get; set; }
        public virtual DbSet<OmsordDmsScheduleAddress> OmsordDmsScheduleAddress { get; set; }
        public virtual DbSet<OmsordDmsScheduleHeader> OmsordDmsScheduleHeader { get; set; }
        public virtual DbSet<OmsordDmsScheduleItem> OmsordDmsScheduleItem { get; set; }
        public virtual DbSet<OmsordDmsServiceOption> OmsordDmsServiceOption { get; set; }
        public virtual DbSet<OmsordEstTransportService> OmsordEstTransportService { get; set; }
        public virtual DbSet<OmsordExtraService> OmsordExtraService { get; set; }
        public virtual DbSet<OmsordLegSplitting> OmsordLegSplitting { get; set; }
        public virtual DbSet<OmsordMasterAdapterTemplate> OmsordMasterAdapterTemplate { get; set; }
        public virtual DbSet<OmsordMasterAdapterTemplateCustomer> OmsordMasterAdapterTemplateCustomer { get; set; }
        public virtual DbSet<OmsordMasterAmphur> OmsordMasterAmphur { get; set; }
        public virtual DbSet<OmsordMasterApplyApOption> OmsordMasterApplyApOption { get; set; }
        public virtual DbSet<OmsordMasterArPostingStatus> OmsordMasterArPostingStatus { get; set; }
        public virtual DbSet<OmsordMasterBatchStatus> OmsordMasterBatchStatus { get; set; }
        public virtual DbSet<OmsordMasterBatchType> OmsordMasterBatchType { get; set; }
        public virtual DbSet<OmsordMasterBigLot> OmsordMasterBigLot { get; set; }
        public virtual DbSet<OmsordMasterBillForm> OmsordMasterBillForm { get; set; }
        public virtual DbSet<OmsordMasterBillFormColumn> OmsordMasterBillFormColumn { get; set; }
        public virtual DbSet<OmsordMasterBillingStatus> OmsordMasterBillingStatus { get; set; }
        public virtual DbSet<OmsordMasterCharge> OmsordMasterCharge { get; set; }
        public virtual DbSet<OmsordMasterChargeType> OmsordMasterChargeType { get; set; }
        public virtual DbSet<OmsordMasterCustomerMaterial> OmsordMasterCustomerMaterial { get; set; }
        public virtual DbSet<OmsordMasterCustomerProfile> OmsordMasterCustomerProfile { get; set; }
        public virtual DbSet<OmsordMasterCustomerService> OmsordMasterCustomerService { get; set; }
        public virtual DbSet<OmsordMasterDistrict> OmsordMasterDistrict { get; set; }
        public virtual DbSet<OmsordMasterDnStatus> OmsordMasterDnStatus { get; set; }
        public virtual DbSet<OmsordMasterEndCustomer> OmsordMasterEndCustomer { get; set; }
        public virtual DbSet<OmsordMasterHoliday> OmsordMasterHoliday { get; set; }
        public virtual DbSet<OmsordMasterLocation> OmsordMasterLocation { get; set; }
        public virtual DbSet<OmsordMasterLocationPrefix> OmsordMasterLocationPrefix { get; set; }
        public virtual DbSet<OmsordMasterLocationType> OmsordMasterLocationType { get; set; }
        public virtual DbSet<OmsordMasterLogistic> OmsordMasterLogistic { get; set; }
        public virtual DbSet<OmsordMasterMappingBillFormColumn> OmsordMasterMappingBillFormColumn { get; set; }
        public virtual DbSet<OmsordMasterMaterial> OmsordMasterMaterial { get; set; }
        public virtual DbSet<OmsordMasterMaterialBom> OmsordMasterMaterialBom { get; set; }
        public virtual DbSet<OmsordMasterMaterialUnitConv> OmsordMasterMaterialUnitConv { get; set; }
        public virtual DbSet<OmsordMasterOrderPattern> OmsordMasterOrderPattern { get; set; }
        public virtual DbSet<OmsordMasterOrderScheduleStatus> OmsordMasterOrderScheduleStatus { get; set; }
        public virtual DbSet<OmsordMasterOrderStatus> OmsordMasterOrderStatus { get; set; }
        public virtual DbSet<OmsordMasterOriginLocation> OmsordMasterOriginLocation { get; set; }
        public virtual DbSet<OmsordMasterOutsource> OmsordMasterOutsource { get; set; }
        public virtual DbSet<OmsordMasterPricingDate> OmsordMasterPricingDate { get; set; }
        public virtual DbSet<OmsordMasterPricingModel> OmsordMasterPricingModel { get; set; }
        public virtual DbSet<OmsordMasterProvince> OmsordMasterProvince { get; set; }
        public virtual DbSet<OmsordMasterRegion> OmsordMasterRegion { get; set; }
        public virtual DbSet<OmsordMasterReturnReason> OmsordMasterReturnReason { get; set; }
        public virtual DbSet<OmsordMasterReworkReason> OmsordMasterReworkReason { get; set; }
        public virtual DbSet<OmsordMasterRoute> OmsordMasterRoute { get; set; }
        public virtual DbSet<OmsordMasterRouteSap> OmsordMasterRouteSap { get; set; }
        public virtual DbSet<OmsordMasterSapAmphur> OmsordMasterSapAmphur { get; set; }
        public virtual DbSet<OmsordMasterSapCarrier> OmsordMasterSapCarrier { get; set; }
        public virtual DbSet<OmsordMasterSapMatFreightGroup> OmsordMasterSapMatFreightGroup { get; set; }
        public virtual DbSet<OmsordMasterSapOrderSegment> OmsordMasterSapOrderSegment { get; set; }
        public virtual DbSet<OmsordMasterSapOrderSegmentMapping> OmsordMasterSapOrderSegmentMapping { get; set; }
        public virtual DbSet<OmsordMasterSapProvince> OmsordMasterSapProvince { get; set; }
        public virtual DbSet<OmsordMasterSapRegion> OmsordMasterSapRegion { get; set; }
        public virtual DbSet<OmsordMasterSapScgtShipto> OmsordMasterSapScgtShipto { get; set; }
        public virtual DbSet<OmsordMasterSapShippingpoint> OmsordMasterSapShippingpoint { get; set; }
        public virtual DbSet<OmsordMasterSapShipto> OmsordMasterSapShipto { get; set; }
        public virtual DbSet<OmsordMasterSapShiptoAmphur> OmsordMasterSapShiptoAmphur { get; set; }
        public virtual DbSet<OmsordMasterSapSubRegion> OmsordMasterSapSubRegion { get; set; }
        public virtual DbSet<OmsordMasterSapTransportZone> OmsordMasterSapTransportZone { get; set; }
        public virtual DbSet<OmsordMasterService> OmsordMasterService { get; set; }
        public virtual DbSet<OmsordMasterServiceItem> OmsordMasterServiceItem { get; set; }
        public virtual DbSet<OmsordMasterServiceItemType> OmsordMasterServiceItemType { get; set; }
        public virtual DbSet<OmsordMasterServiceLevel> OmsordMasterServiceLevel { get; set; }
        public virtual DbSet<OmsordMasterServiceModel> OmsordMasterServiceModel { get; set; }
        public virtual DbSet<OmsordMasterServiceOptionMapping> OmsordMasterServiceOptionMapping { get; set; }
        public virtual DbSet<OmsordMasterShippingCond> OmsordMasterShippingCond { get; set; }
        public virtual DbSet<OmsordMasterSpecialOrderType> OmsordMasterSpecialOrderType { get; set; }
        public virtual DbSet<OmsordMasterStdUnitConv> OmsordMasterStdUnitConv { get; set; }
        public virtual DbSet<OmsordMasterStockType> OmsordMasterStockType { get; set; }
        public virtual DbSet<OmsordMasterTmsEquipmentType> OmsordMasterTmsEquipmentType { get; set; }
        public virtual DbSet<OmsordMasterTmsEvent> OmsordMasterTmsEvent { get; set; }
        public virtual DbSet<OmsordMasterTmsLoadStatus> OmsordMasterTmsLoadStatus { get; set; }
        public virtual DbSet<OmsordMasterTmsSequence> OmsordMasterTmsSequence { get; set; }
        public virtual DbSet<OmsordMasterTmsServiceType> OmsordMasterTmsServiceType { get; set; }
        public virtual DbSet<OmsordMasterTransport> OmsordMasterTransport { get; set; }
        public virtual DbSet<OmsordMasterTransportMode> OmsordMasterTransportMode { get; set; }
        public virtual DbSet<OmsordMasterTransportOrderType> OmsordMasterTransportOrderType { get; set; }
        public virtual DbSet<OmsordMasterUnit> OmsordMasterUnit { get; set; }
        public virtual DbSet<OmsordMasterUserCustomer> OmsordMasterUserCustomer { get; set; }
        public virtual DbSet<OmsordMasterVehicleSubtype> OmsordMasterVehicleSubtype { get; set; }
        public virtual DbSet<OmsordMasterVehicleType> OmsordMasterVehicleType { get; set; }
        public virtual DbSet<OmsordMasterWorkingday> OmsordMasterWorkingday { get; set; }
        public virtual DbSet<OmsordRunningNumberConfig> OmsordRunningNumberConfig { get; set; }
        public virtual DbSet<OmsordSapOrder> OmsordSapOrder { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingCriteria> OmsordSapOrderAutosplittingCriteria { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingCriteriaMatterialFrom> OmsordSapOrderAutosplittingCriteriaMatterialFrom { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingCriteriaMatterialTo> OmsordSapOrderAutosplittingCriteriaMatterialTo { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingCriteriaShippingpoint> OmsordSapOrderAutosplittingCriteriaShippingpoint { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingCriteriaShiptoRegion> OmsordSapOrderAutosplittingCriteriaShiptoRegion { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingCriteriaSubShiptoRegion> OmsordSapOrderAutosplittingCriteriaSubShiptoRegion { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingOrder> OmsordSapOrderAutosplittingOrder { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingOrderShippingpoint> OmsordSapOrderAutosplittingOrderShippingpoint { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingOrderThoughpoint> OmsordSapOrderAutosplittingOrderThoughpoint { get; set; }
        public virtual DbSet<OmsordSapOrderAutosplittingTask> OmsordSapOrderAutosplittingTask { get; set; }
        public virtual DbSet<OmsordSapOrderCharge> OmsordSapOrderCharge { get; set; }
        public virtual DbSet<OmsordSapOrderItem> OmsordSapOrderItem { get; set; }
        public virtual DbSet<OmsordSapOrderTemp> OmsordSapOrderTemp { get; set; }
        public virtual DbSet<OmsordSapOrderThoughpoint> OmsordSapOrderThoughpoint { get; set; }
        public virtual DbSet<OmsordSapScheduleLine> OmsordSapScheduleLine { get; set; }
        public virtual DbSet<OmsordServiceOrder> OmsordServiceOrder { get; set; }
        public virtual DbSet<OmsordServiceOrderAutosplitting> OmsordServiceOrderAutosplitting { get; set; }
        public virtual DbSet<OmsordServiceOrderAutosplittingTask> OmsordServiceOrderAutosplittingTask { get; set; }
        public virtual DbSet<OmsordServiceOrderAutosplittingThoughpoint> OmsordServiceOrderAutosplittingThoughpoint { get; set; }
        public virtual DbSet<OmsordServiceOrderCreditGroup> OmsordServiceOrderCreditGroup { get; set; }
        public virtual DbSet<OmsordServiceOrderDetailOutsource> OmsordServiceOrderDetailOutsource { get; set; }
        public virtual DbSet<OmsordServiceOrderDetailTransport> OmsordServiceOrderDetailTransport { get; set; }
        public virtual DbSet<OmsordServiceOrderDetailWarehouse> OmsordServiceOrderDetailWarehouse { get; set; }
        public virtual DbSet<OmsordServiceOrderItem> OmsordServiceOrderItem { get; set; }
        public virtual DbSet<OmsordServiceOrderItemSchedule> OmsordServiceOrderItemSchedule { get; set; }
        public virtual DbSet<OmsordServiceOrderItemShipMark> OmsordServiceOrderItemShipMark { get; set; }
        public virtual DbSet<OmsordServiceOrderSchedule> OmsordServiceOrderSchedule { get; set; }
        public virtual DbSet<OmsordTmsShipment> OmsordTmsShipment { get; set; }
        public virtual DbSet<OmsordTransportService> OmsordTransportService { get; set; }
        public virtual DbSet<OmsordTransportServiceExpress> OmsordTransportServiceExpress { get; set; }
        public virtual DbSet<OmsordTransportServiceExpressInsource> OmsordTransportServiceExpressInsource { get; set; }
        public virtual DbSet<OmsordTransportServiceExpressOutsource> OmsordTransportServiceExpressOutsource { get; set; }
        public virtual DbSet<OmsordTransportServiceLeadtime> OmsordTransportServiceLeadtime { get; set; }
        public virtual DbSet<OmsordTransportServiceWindow> OmsordTransportServiceWindow { get; set; }
        public virtual DbSet<OmsordTransportTruckType> OmsordTransportTruckType { get; set; }
        public virtual DbSet<OmswmpSapTmsMfgrCdtyConfig> OmswmpSapTmsMfgrCdtyConfig { get; set; }
        public virtual DbSet<OmswmpSapTmsMfgrDivConfig> OmswmpSapTmsMfgrDivConfig { get; set; }
        public virtual DbSet<OmswmpTmsCdty> OmswmpTmsCdty { get; set; }
        public virtual DbSet<OmswmpTmsPlan> OmswmpTmsPlan { get; set; }
        public virtual DbSet<PoddatAbnormality> PoddatAbnormality { get; set; }
        public virtual DbSet<PoddatCheckedpoint> PoddatCheckedpoint { get; set; }
        public virtual DbSet<PoddatCustomer> PoddatCustomer { get; set; }
        public virtual DbSet<PoddatDamageheader> PoddatDamageheader { get; set; }
        public virtual DbSet<PoddatDamageitem> PoddatDamageitem { get; set; }
        public virtual DbSet<PoddatDeliveryitem> PoddatDeliveryitem { get; set; }
        public virtual DbSet<PoddatDeliverynote> PoddatDeliverynote { get; set; }
        public virtual DbSet<PoddatEbooking> PoddatEbooking { get; set; }
        public virtual DbSet<PoddatEdoclogged> PoddatEdoclogged { get; set; }
        public virtual DbSet<PoddatMstcarrier> PoddatMstcarrier { get; set; }
        public virtual DbSet<PoddatMstcarrierorigins> PoddatMstcarrierorigins { get; set; }
        public virtual DbSet<PoddatMstcommudity> PoddatMstcommudity { get; set; }
        public virtual DbSet<PoddatMstcommumfgs> PoddatMstcommumfgs { get; set; }
        public virtual DbSet<PoddatMstdepartment> PoddatMstdepartment { get; set; }
        public virtual DbSet<PoddatMstdriver> PoddatMstdriver { get; set; }
        public virtual DbSet<PoddatMstfleet> PoddatMstfleet { get; set; }
        public virtual DbSet<PoddatMstfleetcarriers> PoddatMstfleetcarriers { get; set; }
        public virtual DbSet<PoddatMstfleetorigins> PoddatMstfleetorigins { get; set; }
        public virtual DbSet<PoddatMstmanager> PoddatMstmanager { get; set; }
        public virtual DbSet<PoddatMstproducttype> PoddatMstproducttype { get; set; }
        public virtual DbSet<PoddatMstregion> PoddatMstregion { get; set; }
        public virtual DbSet<PoddatMstsaleorg> PoddatMstsaleorg { get; set; }
        public virtual DbSet<PoddatMsttitle> PoddatMsttitle { get; set; }
        public virtual DbSet<PoddatMsttrucktype> PoddatMsttrucktype { get; set; }
        public virtual DbSet<PoddatMstvehicle> PoddatMstvehicle { get; set; }
        public virtual DbSet<PoddatMstzone> PoddatMstzone { get; set; }
        public virtual DbSet<PoddatNotifyhistory> PoddatNotifyhistory { get; set; }
        public virtual DbSet<PoddatPhototaking> PoddatPhototaking { get; set; }
        public virtual DbSet<PoddatShipment> PoddatShipment { get; set; }
        public virtual DbSet<PoddatShipmentstatus> PoddatShipmentstatus { get; set; }
        public virtual DbSet<PoddatShippingpoint> PoddatShippingpoint { get; set; }
        public virtual DbSet<PoddatShipto> PoddatShipto { get; set; }
        public virtual DbSet<PoddatTruckcommit> PoddatTruckcommit { get; set; }
        public virtual DbSet<PoddatUserdevice> PoddatUserdevice { get; set; }
        public virtual DbSet<PoddatUserlogin> PoddatUserlogin { get; set; }
        public virtual DbSet<PoddatUserorigins> PoddatUserorigins { get; set; }
        public virtual DbSet<ScvcorDeliveryTrackingHeader> ScvcorDeliveryTrackingHeader { get; set; }
        public virtual DbSet<ScvcorDeliveryTrackingLoadLeg> ScvcorDeliveryTrackingLoadLeg { get; set; }
        public virtual DbSet<ScvcorDeliveryTrackingStatus> ScvcorDeliveryTrackingStatus { get; set; }
        public virtual DbSet<ScvcorMasterMatFreightGrp> ScvcorMasterMatFreightGrp { get; set; }
        public virtual DbSet<ScvcorMasterSalesOrg> ScvcorMasterSalesOrg { get; set; }
        public virtual DbSet<ScvcorMasterTrackingStatus> ScvcorMasterTrackingStatus { get; set; }
        public virtual DbSet<ScvmvcCdasGiInfo> ScvmvcCdasGiInfo { get; set; }
        public virtual DbSet<ScvmvcExtDeliveryHeader> ScvmvcExtDeliveryHeader { get; set; }
        public virtual DbSet<ScvmvcExtDeliveryItem> ScvmvcExtDeliveryItem { get; set; }
        public virtual DbSet<ScvmvcExtDeliveryItemGoodsIssue> ScvmvcExtDeliveryItemGoodsIssue { get; set; }
        public virtual DbSet<ScvmvcExtDeliveryItemGoodsReceived> ScvmvcExtDeliveryItemGoodsReceived { get; set; }
        public virtual DbSet<ScvmvcMasterTmsLocation> ScvmvcMasterTmsLocation { get; set; }
        public virtual DbSet<ScvmvcSapDeliveryHeader> ScvmvcSapDeliveryHeader { get; set; }
        public virtual DbSet<ScvmvcSapDeliveryItem> ScvmvcSapDeliveryItem { get; set; }
        public virtual DbSet<ScvmvcTmsDeliveryHeader> ScvmvcTmsDeliveryHeader { get; set; }
        public virtual DbSet<ScvmvcTmsDeliveryItem> ScvmvcTmsDeliveryItem { get; set; }
        public virtual DbSet<ScvmvcTmsLoadLeg> ScvmvcTmsLoadLeg { get; set; }
        public virtual DbSet<ScvmvcTmsLoadLegDetail> ScvmvcTmsLoadLegDetail { get; set; }
        public virtual DbSet<ScvmvcTmsLoadMemo> ScvmvcTmsLoadMemo { get; set; }
        public virtual DbSet<ScvmvcTmsLoadTracking> ScvmvcTmsLoadTracking { get; set; }

        // Unable to generate entity type for table 'dom.metadata_master_lpc_group'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.metadata_master_lpc_user_group'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.metadata_master_fleet_old'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.metadata_master_fleet_old2'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.metadata_master_fleet_old3'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.metadata_master_province'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.metadata_master_fleet'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.metadata_master_distance_amphurm4'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.poddat_xdeliveryitem'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.gpssmc_vehicles'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.poddat_xshipment'. Please see the warning messages.
        // Unable to generate entity type for table 'dom.poddat_xdeliverynote'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=qa-datalake-pg.cluster-ctg0nvlybzpq.ap-southeast-1.rds.amazonaws.com; Username =csi_report; Password =CSI@SCGL; Database =pd_datalake", x => x.UseNodaTime());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("postgis")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<MetadataMasterBusinessGroup>(entity =>
            {
                entity.HasKey(e => e.Matfrigrp)
                    .HasName("metadata_master_business_group_pk");

                entity.ToTable("metadata_master_business_group", "dom");

                entity.Property(e => e.Matfrigrp)
                    .HasColumnName("matfrigrp")
                    .HasColumnType("character varying")
                    .ValueGeneratedNever();

                entity.Property(e => e.Businessgroup)
                    .HasColumnName("businessgroup")
                    .HasColumnType("character varying");

                entity.Property(e => e.MatfrigrpName)
                    .HasColumnName("matfrigrp_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProductGroup)
                    .HasColumnName("product_group")
                    .HasColumnType("character varying");

                entity.Property(e => e.ScgNscg)
                    .HasColumnName("scg_nscg")
                    .HasColumnType("character varying");

                entity.Property(e => e.SubBusinessgroup)
                    .HasColumnName("sub_businessgroup")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<MetadataMasterTruckUtilization>(entity =>
            {
                entity.HasKey(e => e.TruckType)
                    .HasName("metadata_master_truck_utilization_pkey");

                entity.ToTable("metadata_master_truck_utilization", "dom");

                entity.Property(e => e.TruckType)
                    .HasColumnName("truck_type")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxVolume)
                    .HasColumnName("max_volume")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxWeight)
                    .HasColumnName("max_weight")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<OmscbmBookPlan>(entity =>
            {
                entity.HasKey(e => e.Booknumber)
                    .HasName("omscbm_book_plan_pkey");

                entity.ToTable("omscbm_book_plan", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_book_plan_dms_rep_dtt_idx");

                entity.Property(e => e.Booknumber)
                    .HasColumnName("booknumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Bookedamount).HasColumnName("bookedamount");

                entity.Property(e => e.Bookeddate)
                    .IsRequired()
                    .HasColumnName("bookeddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Bookqueue).HasColumnName("bookqueue");

                entity.Property(e => e.Booktype)
                    .HasColumnName("booktype")
                    .HasMaxLength(10);

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fleetid).HasColumnName("fleetid");

                entity.Property(e => e.Fleetname)
                    .HasColumnName("fleetname")
                    .HasMaxLength(100);

                entity.Property(e => e.Oldbooknumber)
                    .HasColumnName("oldbooknumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Pendingapproveflag).HasColumnName("pendingapproveflag");

                entity.Property(e => e.Queuedate)
                    .HasColumnName("queuedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Rowversion).HasColumnName("rowversion");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehiclecapweight)
                    .HasColumnName("vehiclecapweight")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Vehicletypecode)
                    .IsRequired()
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Vehicletypename)
                    .HasColumnName("vehicletypename")
                    .HasMaxLength(200);

                entity.Property(e => e.Vehicleweightunit)
                    .IsRequired()
                    .HasColumnName("vehicleweightunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Waitingflag).HasColumnName("waitingflag");
            });

            modelBuilder.Entity<OmscbmConvTruckCommitted>(entity =>
            {
                entity.HasKey(e => new { e.Fleetid, e.Committeddate, e.Vehicletypecode })
                    .HasName("omscbm_conv_truck_committed_pkey");

                entity.ToTable("omscbm_conv_truck_committed", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_conv_truck_committed_dms_rep_dtt_idx");

                entity.Property(e => e.Fleetid).HasColumnName("fleetid");

                entity.Property(e => e.Committeddate)
                    .HasColumnName("committeddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Committedamount).HasColumnName("committedamount");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sparedamount).HasColumnName("sparedamount");
            });

            modelBuilder.Entity<OmscbmDmsOrderHeader>(entity =>
            {
                entity.HasKey(e => e.Orderno)
                    .HasName("omscbm_dms_order_header_pkey");

                entity.ToTable("omscbm_dms_order_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_order_header_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Confirmqty)
                    .HasColumnName("confirmqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Creditblockd)
                    .HasColumnName("creditblockd")
                    .HasMaxLength(5);

                entity.Property(e => e.Distrchan)
                    .HasColumnName("distrchan")
                    .HasMaxLength(2);

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(2);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dnqty)
                    .HasColumnName("dnqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Incoterms1)
                    .HasColumnName("incoterms1")
                    .HasMaxLength(3);

                entity.Property(e => e.Incoterms2)
                    .HasColumnName("incoterms2")
                    .HasMaxLength(28);

                entity.Property(e => e.Markflag)
                    .HasColumnName("markflag")
                    .HasMaxLength(3);

                entity.Property(e => e.Maxallowdate)
                    .HasColumnName("maxallowdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordercreateddate)
                    .HasColumnName("ordercreateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordergroup)
                    .HasColumnName("ordergroup")
                    .HasMaxLength(1);

                entity.Property(e => e.Ordertypecode)
                    .HasColumnName("ordertypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Pageplag)
                    .HasColumnName("pageplag")
                    .HasMaxLength(1);

                entity.Property(e => e.Palletflag)
                    .HasColumnName("palletflag")
                    .HasMaxLength(3);

                entity.Property(e => e.Pono)
                    .HasColumnName("pono")
                    .HasMaxLength(35);

                entity.Property(e => e.Remainqty)
                    .HasColumnName("remainqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Requesteddate)
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Saleorg)
                    .HasColumnName("saleorg")
                    .HasMaxLength(4);

                entity.Property(e => e.Salesoffice)
                    .HasColumnName("salesoffice")
                    .HasMaxLength(4);

                entity.Property(e => e.Shippingcond)
                    .HasColumnName("shippingcond")
                    .HasMaxLength(2);

                entity.Property(e => e.Shippingconddesc)
                    .HasColumnName("shippingconddesc")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptodistrict)
                    .HasColumnName("shiptodistrict")
                    .HasMaxLength(40);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(80);

                entity.Property(e => e.Shiptoregdes)
                    .HasColumnName("shiptoregdes")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptoregion)
                    .HasColumnName("shiptoregion")
                    .HasMaxLength(3);

                entity.Property(e => e.Shiptostreet)
                    .HasColumnName("shiptostreet")
                    .HasMaxLength(60);

                entity.Property(e => e.Shiptotel)
                    .HasColumnName("shiptotel")
                    .HasMaxLength(30);

                entity.Property(e => e.Shiptotranzone)
                    .HasColumnName("shiptotranzone")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptounloadpoint)
                    .HasColumnName("shiptounloadpoint")
                    .HasMaxLength(50);

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtoname)
                    .HasColumnName("soldtoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Totalqty)
                    .HasColumnName("totalqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Updateby).HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<OmscbmDmsOrderItem>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Itemno })
                    .HasName("omscbm_dms_order_item_pkey");

                entity.ToTable("omscbm_dms_order_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_order_item_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Itemno)
                    .HasColumnName("itemno")
                    .HasMaxLength(10);

                entity.Property(e => e.Confirmqty)
                    .HasColumnName("confirmqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Deliveryqty)
                    .HasColumnName("deliveryqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Freeitem)
                    .HasColumnName("freeitem")
                    .HasMaxLength(1);

                entity.Property(e => e.Hightlevelitem)
                    .HasColumnName("hightlevelitem")
                    .HasMaxLength(6);

                entity.Property(e => e.Itemgrossweight)
                    .HasColumnName("itemgrossweight")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Itemscheduleweight)
                    .HasColumnName("itemscheduleweight")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Itemtotalweight)
                    .HasColumnName("itemtotalweight")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Matcode)
                    .HasColumnName("matcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Matdesc)
                    .HasColumnName("matdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Mfg)
                    .HasColumnName("mfg")
                    .HasMaxLength(5);

                entity.Property(e => e.Remainqty)
                    .HasColumnName("remainqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Saleunit)
                    .HasColumnName("saleunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Shippingpoint)
                    .HasColumnName("shippingpoint")
                    .HasMaxLength(5);

                entity.Property(e => e.Totalqty)
                    .HasColumnName("totalqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Transittime).HasColumnName("transittime");

                entity.Property(e => e.Wtperunitkg)
                    .HasColumnName("wtperunitkg")
                    .HasColumnType("numeric(20,3)");
            });

            modelBuilder.Entity<OmscbmDmsOrderPending>(entity =>
            {
                entity.HasKey(e => e.Orderno)
                    .HasName("omscbm_dms_order_pending_pkey");

                entity.ToTable("omscbm_dms_order_pending", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_order_pending_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Pendingstatus).HasColumnName("pendingstatus");

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmscbmDmsOrderPlan>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Createdby })
                    .HasName("omscbm_dms_order_plan_pkey");

                entity.ToTable("omscbm_dms_order_plan", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_order_plan_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Confirmqty)
                    .HasColumnName("confirmqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Creditblockd)
                    .HasColumnName("creditblockd")
                    .HasMaxLength(5);

                entity.Property(e => e.Distrchan)
                    .HasColumnName("distrchan")
                    .HasMaxLength(2);

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(2);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dnqty)
                    .HasColumnName("dnqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Incoterms1)
                    .HasColumnName("incoterms1")
                    .HasMaxLength(3);

                entity.Property(e => e.Incoterms2)
                    .HasColumnName("incoterms2")
                    .HasMaxLength(28);

                entity.Property(e => e.Maxallowdate)
                    .HasColumnName("maxallowdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordercreateddate)
                    .HasColumnName("ordercreateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordergroup)
                    .HasColumnName("ordergroup")
                    .HasMaxLength(1);

                entity.Property(e => e.Ordertypecode)
                    .HasColumnName("ordertypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Palletflag)
                    .HasColumnName("palletflag")
                    .HasMaxLength(3);

                entity.Property(e => e.Pono)
                    .HasColumnName("pono")
                    .HasMaxLength(35);

                entity.Property(e => e.Remainqty)
                    .HasColumnName("remainqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Requesteddate)
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Saleorg)
                    .HasColumnName("saleorg")
                    .HasMaxLength(4);

                entity.Property(e => e.Salesoffice)
                    .HasColumnName("salesoffice")
                    .HasMaxLength(4);

                entity.Property(e => e.Shippingcond)
                    .HasColumnName("shippingcond")
                    .HasMaxLength(2);

                entity.Property(e => e.Shippingconddesc)
                    .HasColumnName("shippingconddesc")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptodistrict)
                    .HasColumnName("shiptodistrict")
                    .HasMaxLength(40);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(80);

                entity.Property(e => e.Shiptoregdes)
                    .HasColumnName("shiptoregdes")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptoregion)
                    .HasColumnName("shiptoregion")
                    .HasMaxLength(3);

                entity.Property(e => e.Shiptostreet)
                    .HasColumnName("shiptostreet")
                    .HasMaxLength(60);

                entity.Property(e => e.Shiptotel)
                    .HasColumnName("shiptotel")
                    .HasMaxLength(30);

                entity.Property(e => e.Shiptounloadpoint)
                    .HasColumnName("shiptounloadpoint")
                    .HasMaxLength(50);

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtoname)
                    .HasColumnName("soldtoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Totalqty)
                    .HasColumnName("totalqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<OmscbmDmsScheduleAddress>(entity =>
            {
                entity.HasKey(e => e.Orderno)
                    .HasName("omscbm_dms_schedule_address_pkey");

                entity.ToTable("omscbm_dms_schedule_address", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_schedule_address_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Addressno)
                    .HasColumnName("addressno")
                    .HasMaxLength(60);

                entity.Property(e => e.Adjacentremark)
                    .HasColumnName("adjacentremark")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Distfromsoi)
                    .HasColumnName("distfromsoi")
                    .HasMaxLength(10);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Receivername)
                    .HasColumnName("receivername")
                    .HasMaxLength(40);

                entity.Property(e => e.Receivetel)
                    .HasColumnName("receivetel")
                    .HasMaxLength(20);

                entity.Property(e => e.Soi)
                    .HasColumnName("soi")
                    .HasMaxLength(50);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(50);

                entity.Property(e => e.Unitdistance)
                    .HasColumnName("unitdistance")
                    .HasMaxLength(20);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmDmsScheduleHeaderPlan>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline })
                    .HasName("omscbm_dms_schedule_header_plan_pkey");

                entity.ToTable("omscbm_dms_schedule_header_plan", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_schedule_header_plan_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(10);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Flagtransfer)
                    .HasColumnName("flagtransfer")
                    .HasMaxLength(1);

                entity.Property(e => e.Scheduledate)
                    .HasColumnName("scheduledate")
                    .HasMaxLength(37);

                entity.Property(e => e.Scheduleqty)
                    .HasColumnName("scheduleqty")
                    .HasColumnType("numeric(8,3)");

                entity.Property(e => e.Schedulestatus)
                    .HasColumnName("schedulestatus")
                    .HasMaxLength(1);

                entity.Property(e => e.Scheduleunit)
                    .HasColumnName("scheduleunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmDmsScheduleItemPlan>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline, e.Itemno })
                    .HasName("omscbm_dms_schedule_item_plan_pkey");

                entity.ToTable("omscbm_dms_schedule_item_plan", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_schedule_item_plan_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(10);

                entity.Property(e => e.Itemno)
                    .HasColumnName("itemno")
                    .HasMaxLength(10);

                entity.Property(e => e.Confirmqty)
                    .HasColumnName("confirmqty")
                    .HasColumnType("numeric(20,3)");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliverycrateddate)
                    .HasColumnName("deliverycrateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Matcode)
                    .HasColumnName("matcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Matdesc)
                    .HasColumnName("matdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Scheduleqty)
                    .HasColumnName("scheduleqty")
                    .HasColumnType("numeric(8,3)");

                entity.Property(e => e.Scheduleunit)
                    .HasColumnName("scheduleunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmDmsScheduleReportDmreqPlan>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline, e.Itemno, e.Username })
                    .HasName("omscbm_dms_schedule_report_dmreq_plan_pkey");

                entity.ToTable("omscbm_dms_schedule_report_dmreq_plan", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_schedule_report_dmreq_plan_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(10);

                entity.Property(e => e.Itemno)
                    .HasColumnName("itemno")
                    .HasMaxLength(10);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(200);

                entity.Property(e => e.Actualgi)
                    .HasColumnName("actualgi")
                    .HasColumnType("numeric(8,3)");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Matdesc)
                    .HasColumnName("matdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Ordercreateddate)
                    .HasColumnName("ordercreateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Scheduledate)
                    .HasColumnName("scheduledate")
                    .HasMaxLength(37);

                entity.Property(e => e.Scheduleqty)
                    .HasColumnName("scheduleqty")
                    .HasColumnType("numeric(8,3)");

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(80);

                entity.Property(e => e.Shiptoregdes)
                    .HasColumnName("shiptoregdes")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<OmscbmDmsScheduleReportStatusPlan>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Username })
                    .HasName("omscbm_dms_schedule_report_status_plan_pkey");

                entity.ToTable("omscbm_dms_schedule_report_status_plan", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_schedule_report_status_plan_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(200);

                entity.Property(e => e.Creditblock)
                    .HasColumnName("creditblock")
                    .HasMaxLength(1);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Incoterm1)
                    .HasColumnName("incoterm1")
                    .HasMaxLength(3);

                entity.Property(e => e.Ordercreateddate)
                    .HasColumnName("ordercreateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pono)
                    .HasColumnName("pono")
                    .HasMaxLength(35);

                entity.Property(e => e.Productcate)
                    .HasColumnName("productcate")
                    .HasMaxLength(20);

                entity.Property(e => e.Remainqty)
                    .HasColumnName("remainqty")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.Requestdate)
                    .HasColumnName("requestdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Scheduleqty)
                    .HasColumnName("scheduleqty")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.Schedulests)
                    .HasColumnName("schedulests")
                    .HasMaxLength(3);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(80);

                entity.Property(e => e.Shiptoregdes)
                    .HasColumnName("shiptoregdes")
                    .HasMaxLength(20);

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtoname)
                    .HasColumnName("soldtoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Totalqty)
                    .HasColumnName("totalqty")
                    .HasColumnType("numeric(10,3)");
            });

            modelBuilder.Entity<OmscbmDmsServiceOption>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline, e.Serviceoptionseq })
                    .HasName("omscbm_dms_service_option_pkey");

                entity.ToTable("omscbm_dms_service_option", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_dms_service_option_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceoptionseq).HasColumnName("serviceoptionseq");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Serviceoptionname)
                    .HasColumnName("serviceoptionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Serviceoptionremark)
                    .HasColumnName("serviceoptionremark")
                    .HasMaxLength(40);

                entity.Property(e => e.Serviceoptionvalue)
                    .HasColumnName("serviceoptionvalue")
                    .HasMaxLength(40);

                entity.Property(e => e.Usercreateby)
                    .HasColumnName("usercreateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Usercreatedate)
                    .HasColumnName("usercreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Userupdateby)
                    .HasColumnName("userupdateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Userupdatedate)
                    .HasColumnName("userupdatedate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmMasterFleet>(entity =>
            {
                entity.HasKey(e => e.Fleetid)
                    .HasName("omscbm_master_fleet_pkey");

                entity.ToTable("omscbm_master_fleet", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_fleet_dms_rep_dtt_idx");

                entity.Property(e => e.Fleetid)
                    .HasColumnName("fleetid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fleetname)
                    .IsRequired()
                    .HasColumnName("fleetname")
                    .HasMaxLength(100);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmMasterFleetShippointMatfreight>(entity =>
            {
                entity.ToTable("omscbm_master_fleet_shippoint_matfreight", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_fleet_shippoint_matfreight_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fleetid).HasColumnName("fleetid");

                entity.Property(e => e.Matfreightgroupcode)
                    .IsRequired()
                    .HasColumnName("matfreightgroupcode")
                    .HasMaxLength(8);

                entity.Property(e => e.Maxweight)
                    .HasColumnName("maxweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Minweight)
                    .HasColumnName("minweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannerusername)
                    .HasColumnName("plannerusername")
                    .HasMaxLength(200);

                entity.Property(e => e.Shipcondcode)
                    .IsRequired()
                    .HasColumnName("shipcondcode")
                    .HasMaxLength(2);

                entity.Property(e => e.Shippingpointcode)
                    .IsRequired()
                    .HasColumnName("shippingpointcode")
                    .HasMaxLength(16);

                entity.Property(e => e.Shiptoregion)
                    .IsRequired()
                    .HasColumnName("shiptoregion")
                    .HasMaxLength(6);

                entity.Property(e => e.Systemid).HasColumnName("systemid");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmMasterFleetVehicleType>(entity =>
            {
                entity.HasKey(e => new { e.Fleetid, e.Vehicletypecode })
                    .HasName("omscbm_master_fleet_vehicle_type_pkey");

                entity.ToTable("omscbm_master_fleet_vehicle_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_fleet_vehicle_type_dms_rep_dtt_idx");

                entity.Property(e => e.Fleetid).HasColumnName("fleetid");

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Bymaterialflag).HasColumnName("bymaterialflag");

                entity.Property(e => e.Bysoldtoflag).HasColumnName("bysoldtoflag");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmMasterOrdersegmentSalesoffice>(entity =>
            {
                entity.HasKey(e => new { e.Ordersegmentid, e.Systemid })
                    .HasName("omscbm_master_ordersegment_salesoffice_pkey");

                entity.ToTable("omscbm_master_ordersegment_salesoffice", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_ordersegment_salesoffice_dms_rep_dtt_idx");

                entity.Property(e => e.Ordersegmentid).HasColumnName("ordersegmentid");

                entity.Property(e => e.Systemid).HasColumnName("systemid");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Ordergroup)
                    .IsRequired()
                    .HasColumnName("ordergroup")
                    .HasMaxLength(1);

                entity.Property(e => e.Salesoffice)
                    .IsRequired()
                    .HasColumnName("salesoffice")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapshippingpointcode)
                    .IsRequired()
                    .HasColumnName("sapshippingpointcode")
                    .HasMaxLength(16);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmMasterSaleArea>(entity =>
            {
                entity.HasKey(e => e.Saleareagroupid)
                    .HasName("omscbm_master_sale_area_pkey");

                entity.ToTable("omscbm_master_sale_area", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_sale_area_dms_rep_dtt_idx");

                entity.Property(e => e.Saleareagroupid)
                    .HasColumnName("saleareagroupid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Bugroupid).HasColumnName("bugroupid");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Distrchancode)
                    .IsRequired()
                    .HasColumnName("distrchancode")
                    .HasMaxLength(2);

                entity.Property(e => e.Divisioncode)
                    .IsRequired()
                    .HasColumnName("divisioncode")
                    .HasMaxLength(4);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Saleorgcode)
                    .IsRequired()
                    .HasColumnName("saleorgcode")
                    .HasMaxLength(4);

                entity.Property(e => e.Salesofficecode)
                    .IsRequired()
                    .HasColumnName("salesofficecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Systemid).HasColumnName("systemid");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmMasterTruckCommitted>(entity =>
            {
                entity.HasKey(e => new { e.Fleetid, e.Committeddate, e.Vehicletypecode })
                    .HasName("omscbm_master_truck_committed_pkey");

                entity.ToTable("omscbm_master_truck_committed", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_truck_committed_dms_rep_dtt_idx");

                entity.Property(e => e.Fleetid).HasColumnName("fleetid");

                entity.Property(e => e.Committeddate)
                    .HasColumnName("committeddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Bookedamount).HasColumnName("bookedamount");

                entity.Property(e => e.Bookedsparedamount).HasColumnName("bookedsparedamount");

                entity.Property(e => e.Committedamount).HasColumnName("committedamount");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Rowversion).HasColumnName("rowversion");

                entity.Property(e => e.Sparedamount).HasColumnName("sparedamount");

                entity.Property(e => e.Systemid).HasColumnName("systemid");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscbmMasterTruckCommittedHistory>(entity =>
            {
                entity.HasKey(e => e.Historyid)
                    .HasName("omscbm_master_truck_committed_history_pkey");

                entity.ToTable("omscbm_master_truck_committed_history", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_truck_committed_history_dms_rep_dtt_idx");

                entity.Property(e => e.Historyid)
                    .HasColumnName("historyid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bookedamount).HasColumnName("bookedamount");

                entity.Property(e => e.Bookedsparedamount).HasColumnName("bookedsparedamount");

                entity.Property(e => e.Committedamount).HasColumnName("committedamount");

                entity.Property(e => e.Committeddate)
                    .IsRequired()
                    .HasColumnName("committeddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(50);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fleetid).HasColumnName("fleetid");

                entity.Property(e => e.Orderline)
                    .IsRequired()
                    .HasColumnName("orderline")
                    .HasMaxLength(5);

                entity.Property(e => e.Orderno)
                    .IsRequired()
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Sparedamount).HasColumnName("sparedamount");

                entity.Property(e => e.Systemid).HasColumnName("systemid");

                entity.Property(e => e.Vehicletypecode)
                    .IsRequired()
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<OmscbmMasterTruckQueue>(entity =>
            {
                entity.HasKey(e => new { e.Fleetid, e.Committeddate, e.Vehicletypecode, e.Queueno })
                    .HasName("omscbm_master_truck_queue_pkey");

                entity.ToTable("omscbm_master_truck_queue", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_truck_queue_dms_rep_dtt_idx");

                entity.Property(e => e.Fleetid).HasColumnName("fleetid");

                entity.Property(e => e.Committeddate).HasColumnName("committeddate");

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Queueno).HasColumnName("queueno");

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Orderline)
                    .IsRequired()
                    .HasColumnName("orderline")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderno)
                    .IsRequired()
                    .HasColumnName("orderno")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmscbmMasterVehicleType>(entity =>
            {
                entity.HasKey(e => e.Vehicletypecode)
                    .HasName("omscbm_master_vehicle_type_pkey");

                entity.ToTable("omscbm_master_vehicle_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_master_vehicle_type_dms_rep_dtt_idx");

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.Buildmatcapweight)
                    .HasColumnName("buildmatcapweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Buildmatflag).HasColumnName("buildmatflag");

                entity.Property(e => e.Buildmatminweight)
                    .HasColumnName("buildmatminweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Buildmatunit)
                    .HasColumnName("buildmatunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Capvolume)
                    .HasColumnName("capvolume")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Capvolumeunit)
                    .IsRequired()
                    .HasColumnName("capvolumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Capweight)
                    .HasColumnName("capweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Capweightunit)
                    .IsRequired()
                    .HasColumnName("capweightunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Expectweight)
                    .HasColumnName("expectweight")
                    .HasColumnType("numeric(7,3)");

                entity.Property(e => e.Minweight)
                    .HasColumnName("minweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Overvolumn)
                    .HasColumnName("overvolumn")
                    .HasColumnType("numeric(7,3)");

                entity.Property(e => e.Schedulingflag).HasColumnName("schedulingflag");

                entity.Property(e => e.Shipcondcode)
                    .HasColumnName("shipcondcode")
                    .HasMaxLength(2);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Utilityweight)
                    .HasColumnName("utilityweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Vehicletypename)
                    .IsRequired()
                    .HasColumnName("vehicletypename")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmscbmOrderScheduleSplitQueue>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline })
                    .HasName("omscbm_order_schedule_split_queue_pkey");

                entity.ToTable("omscbm_order_schedule_split_queue", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscbm_order_schedule_split_queue_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(10);

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Autosplitbatchno)
                    .HasColumnName("autosplitbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Autospliterrormessage)
                    .HasColumnName("autospliterrormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Booknumber).HasColumnName("booknumber");

                entity.Property(e => e.Bypassflag).HasColumnName("bypassflag");

                entity.Property(e => e.Calculationtype)
                    .HasColumnName("calculationtype")
                    .HasMaxLength(1);

                entity.Property(e => e.Combineflag).HasColumnName("combineflag");

                entity.Property(e => e.Compensatedflag).HasColumnName("compensatedflag");

                entity.Property(e => e.Completeschedulelineflag).HasColumnName("completeschedulelineflag");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fieldflag).HasColumnName("fieldflag");

                entity.Property(e => e.Matfreightgroupcode)
                    .IsRequired()
                    .HasColumnName("matfreightgroupcode")
                    .HasMaxLength(8);

                entity.Property(e => e.Plannerusername)
                    .HasColumnName("plannerusername")
                    .HasMaxLength(200);

                entity.Property(e => e.Requesteddate)
                    .IsRequired()
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Rowversion).HasColumnName("rowversion");

                entity.Property(e => e.Scheduleweight)
                    .HasColumnName("scheduleweight")
                    .HasColumnType("numeric(8,3)");

                entity.Property(e => e.Scheduleweightunit)
                    .IsRequired()
                    .HasColumnName("scheduleweightunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptotranzone)
                    .HasColumnName("shiptotranzone")
                    .HasMaxLength(10);

                entity.Property(e => e.Smalllotflag).HasColumnName("smalllotflag");

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.Systemid).HasColumnName("systemid");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Waitingtocombineflag).HasColumnName("waitingtocombineflag");
            });

            modelBuilder.Entity<OmscitDeliveryHeader>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Legid, e.Deliverytype })
                    .HasName("omscit_delivery_header_pkey");

                entity.ToTable("omscit_delivery_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_header_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Batchname)
                    .HasColumnName("batchname")
                    .HasMaxLength(20);

                entity.Property(e => e.Batchupdatedate)
                    .HasColumnName("batchupdatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Biglot).HasColumnName("biglot");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(32);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasColumnName("customername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Delivereddatetime)
                    .HasColumnName("delivereddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliveredfromdate)
                    .IsRequired()
                    .HasColumnName("deliveredfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliveredtodate)
                    .IsRequired()
                    .HasColumnName("deliveredtodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Destinationcode)
                    .IsRequired()
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationlocationtype)
                    .HasColumnName("destinationlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Docreturndatetime)
                    .HasColumnName("docreturndatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Driverlicenseno)
                    .HasColumnName("driverlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Endcustomercode)
                    .IsRequired()
                    .HasColumnName("endcustomercode")
                    .HasMaxLength(100);

                entity.Property(e => e.Endcustomername)
                    .IsRequired()
                    .HasColumnName("endcustomername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Equipmenttype)
                    .HasColumnName("equipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Freightclasscode)
                    .HasColumnName("freightclasscode")
                    .HasMaxLength(10);

                entity.Property(e => e.Gicompleteddatetime)
                    .HasColumnName("gicompleteddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Giheadertext)
                    .HasColumnName("giheadertext")
                    .HasMaxLength(500);

                entity.Property(e => e.Giremark)
                    .HasColumnName("giremark")
                    .HasMaxLength(500);

                entity.Property(e => e.Grcompleteddatetime)
                    .HasColumnName("grcompleteddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Grremark)
                    .HasColumnName("grremark")
                    .HasMaxLength(500);

                entity.Property(e => e.Incotermcode)
                    .HasColumnName("incotermcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Incotermdescription)
                    .HasColumnName("incotermdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Intransitdatetime)
                    .HasColumnName("intransitdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Iscompletedgi).HasColumnName("iscompletedgi");

                entity.Property(e => e.Iscompletedgr).HasColumnName("iscompletedgr");

                entity.Property(e => e.Iscompletedpackedflag).HasColumnName("iscompletedpackedflag");

                entity.Property(e => e.Iscreateshipment).HasColumnName("iscreateshipment");

                entity.Property(e => e.Isexecutejobschedule).HasColumnName("isexecutejobschedule");

                entity.Property(e => e.Isintransit).HasColumnName("isintransit");

                entity.Property(e => e.Isoverridethoughpoint).HasColumnName("isoverridethoughpoint");

                entity.Property(e => e.Isoverwritecharge).HasColumnName("isoverwritecharge");

                entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

                entity.Property(e => e.Isprocessed).HasColumnName("isprocessed");

                entity.Property(e => e.Issuspendload).HasColumnName("issuspendload");

                entity.Property(e => e.Legheader)
                    .IsRequired()
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Mergeintransitcode)
                    .HasColumnName("mergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Omsrouteid)
                    .HasColumnName("omsrouteid")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderdate)
                    .IsRequired()
                    .HasColumnName("orderdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdoctype)
                    .HasColumnName("orderdoctype")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderpatternid).HasColumnName("orderpatternid");

                entity.Property(e => e.Orderscheduleline).HasColumnName("orderscheduleline");

                entity.Property(e => e.Orderschedulelineno).HasColumnName("orderschedulelineno");

                entity.Property(e => e.Origincode)
                    .IsRequired()
                    .HasColumnName("origincode")
                    .HasMaxLength(10);

                entity.Property(e => e.Originlocationtype)
                    .HasColumnName("originlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Outsource)
                    .HasColumnName("outsource")
                    .HasMaxLength(100);

                entity.Property(e => e.Pickedupfromdate)
                    .IsRequired()
                    .HasColumnName("pickedupfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pickeduptodate)
                    .IsRequired()
                    .HasColumnName("pickeduptodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Planeddeliverydate)
                    .IsRequired()
                    .HasColumnName("planeddeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("ponumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Receivedflag).HasColumnName("receivedflag");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Requesteddate)
                    .IsRequired()
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Requirepackflag).HasColumnName("requirepackflag");

                entity.Property(e => e.Requirepalletflag).HasColumnName("requirepalletflag");

                entity.Property(e => e.Retryno).HasColumnName("retryno");

                entity.Property(e => e.Returnflag).HasColumnName("returnflag");

                entity.Property(e => e.Servicelevel)
                    .IsRequired()
                    .HasColumnName("servicelevel")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceleveldescription)
                    .HasColumnName("serviceleveldescription")
                    .HasMaxLength(100);

                entity.Property(e => e.Servicetype)
                    .HasColumnName("servicetype")
                    .HasMaxLength(16);

                entity.Property(e => e.Shipfromcode)
                    .IsRequired()
                    .HasColumnName("shipfromcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shipfromname)
                    .IsRequired()
                    .HasColumnName("shipfromname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipfromtype)
                    .HasColumnName("shipfromtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Shipmentlegid)
                    .HasColumnName("shipmentlegid")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipmentloadid)
                    .HasColumnName("shipmentloadid")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipmentmemo)
                    .HasColumnName("shipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentnumber)
                    .HasColumnName("shipmentnumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipmentprocessdatetime)
                    .HasColumnName("shipmentprocessdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Shiptocode)
                    .IsRequired()
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptoname)
                    .IsRequired()
                    .HasColumnName("shiptoname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shiptospecialcond)
                    .HasColumnName("shiptospecialcond")
                    .HasMaxLength(100);

                entity.Property(e => e.Shiptotype)
                    .HasColumnName("shiptotype")
                    .HasMaxLength(10);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Specialordertype)
                    .HasColumnName("specialordertype")
                    .HasMaxLength(120);

                entity.Property(e => e.Spotrate)
                    .HasColumnName("spotrate")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Spotunit)
                    .HasColumnName("spotunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.Systembatchno)
                    .HasColumnName("systembatchno")
                    .HasMaxLength(25);

                entity.Property(e => e.Trailerlicenseno)
                    .HasColumnName("trailerlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Transportmode)
                    .HasColumnName("transportmode")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypeid)
                    .HasColumnName("vehicletypeid")
                    .HasMaxLength(5);

                entity.Property(e => e.Vesselname)
                    .HasColumnName("vesselname")
                    .HasMaxLength(120);

                entity.Property(e => e.Warehouseloccode)
                    .HasColumnName("warehouseloccode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmscitDeliveryHeaderServiceOptions>(entity =>
            {
                entity.HasKey(e => e.Dnnumber)
                    .HasName("omscit_delivery_header_service_options_pkey");

                entity.ToTable("omscit_delivery_header_service_options", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_header_service_options_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Orderscheduleline).HasColumnName("orderscheduleline");

                entity.Property(e => e.Orderschedulelineno).HasColumnName("orderschedulelineno");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Serviceoptionname)
                    .HasColumnName("serviceoptionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Serviceoptionremark)
                    .HasColumnName("serviceoptionremark")
                    .HasMaxLength(40);

                entity.Property(e => e.Serviceoptionseq).HasColumnName("serviceoptionseq");

                entity.Property(e => e.Serviceoptionvalue)
                    .HasColumnName("serviceoptionvalue")
                    .HasMaxLength(40);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscitDeliveryItems>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Dnitem, e.Legid, e.Deliverytype })
                    .HasName("omscit_delivery_items_pkey");

                entity.ToTable("omscit_delivery_items", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_items_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Gicompleteddatetime)
                    .HasColumnName("gicompleteddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Giflag).HasColumnName("giflag");

                entity.Property(e => e.Giquantity)
                    .HasColumnName("giquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Legheader)
                    .IsRequired()
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialname)
                    .HasColumnName("materialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialpricingunit)
                    .HasColumnName("materialpricingunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Requestpalletflag).HasColumnName("requestpalletflag");

                entity.Property(e => e.Shippingmark)
                    .HasColumnName("shippingmark")
                    .HasMaxLength(50);

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmscitDeliveryItemsGoodIssue>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid, e.Deliverytype })
                    .HasName("omscit_delivery_items_good_issue_pkey");

                entity.ToTable("omscit_delivery_items_good_issue", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_items_good_issue_dms_rep_dtt_idx");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Completedflag).HasColumnName("completedflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Issuedatetime)
                    .IsRequired()
                    .HasColumnName("issuedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(500);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Stampdatetime)
                    .IsRequired()
                    .HasColumnName("stampdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmscitDeliveryItemsPacked>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid })
                    .HasName("omscit_delivery_items_packed_pkey");

                entity.ToTable("omscit_delivery_items_packed", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_items_packed_dms_rep_dtt_idx");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Cancelflag).HasColumnName("cancelflag");

                entity.Property(e => e.Completedflag).HasColumnName("completedflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

                entity.Property(e => e.Issuedatetime)
                    .IsRequired()
                    .HasColumnName("issuedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(500);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmscitDeliveryItemsPackedMapping>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid })
                    .HasName("omscit_delivery_items_packed_mapping_pkey");

                entity.ToTable("omscit_delivery_items_packed_mapping", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_items_packed_mapping_dms_rep_dtt_idx");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Refmaterialcode)
                    .IsRequired()
                    .HasColumnName("refmaterialcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmscitDeliveryItemsPicked>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid })
                    .HasName("omscit_delivery_items_picked_pkey");

                entity.ToTable("omscit_delivery_items_picked", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_items_picked_dms_rep_dtt_idx");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Issuedatetime)
                    .IsRequired()
                    .HasColumnName("issuedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(500);

                entity.Property(e => e.Receiveflag).HasColumnName("receiveflag");

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmscitDeliverySapGoodIssue>(entity =>
            {
                entity.HasKey(e => new { e.Omsdnnumber, e.Sequence, e.Sapdnnumber, e.Sourcesystem, e.Idocnumber, e.Pimessageid })
                    .HasName("omscit_delivery_sap_good_issue_pkey");

                entity.ToTable("omscit_delivery_sap_good_issue", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_sap_good_issue_dms_rep_dtt_idx");

                entity.Property(e => e.Omsdnnumber)
                    .HasColumnName("omsdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Sapdnnumber)
                    .HasColumnName("sapdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Idocnumber)
                    .HasColumnName("idocnumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Pimessageid)
                    .HasColumnName("pimessageid")
                    .HasMaxLength(50);

                entity.Property(e => e.Backdateflag).HasColumnName("backdateflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Deliverydate)
                    .HasColumnName("deliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Dmreceivertel)
                    .HasColumnName("dmreceivertel")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dmscheduledate)
                    .HasColumnName("dmscheduledate")
                    .HasMaxLength(37);

                entity.Property(e => e.Incoterm)
                    .HasColumnName("incoterm")
                    .HasMaxLength(4);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Salesorg)
                    .HasColumnName("salesorg")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapdncreatedate)
                    .HasColumnName("sapdncreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Sapdntype)
                    .IsRequired()
                    .HasColumnName("sapdntype")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapgidatetime)
                    .HasColumnName("sapgidatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Sapgistatus)
                    .HasColumnName("sapgistatus")
                    .HasMaxLength(1);

                entity.Property(e => e.Sappickingdatetime)
                    .HasColumnName("sappickingdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Sappickingstatus)
                    .HasColumnName("sappickingstatus")
                    .HasMaxLength(1);

                entity.Property(e => e.Sappurchaseno)
                    .IsRequired()
                    .HasColumnName("sappurchaseno")
                    .HasMaxLength(50);

                entity.Property(e => e.Sapsocreatedate)
                    .HasColumnName("sapsocreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Sapsonumber)
                    .HasColumnName("sapsonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sapsopaymentterm)
                    .HasColumnName("sapsopaymentterm")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapsoreqdlvdate)
                    .HasColumnName("sapsoreqdlvdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Serialization)
                    .HasColumnName("serialization")
                    .HasMaxLength(40);

                entity.Property(e => e.Shipfromdescription)
                    .HasColumnName("shipfromdescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipfromlocationcode)
                    .HasColumnName("shipfromlocationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shippingpoint)
                    .HasColumnName("shippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Shiptodescription)
                    .HasColumnName("shiptodescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shiptolocationcode)
                    .HasColumnName("shiptolocationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscitDeliverySapHeader>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Legid })
                    .HasName("omscit_delivery_sap_header_pkey");

                entity.ToTable("omscit_delivery_sap_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_sap_header_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Batchupdateddate)
                    .HasColumnName("batchupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Biglot).HasColumnName("biglot");

                entity.Property(e => e.Cancelflag).HasColumnName("cancelflag");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(32);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Deliveredfromdate)
                    .IsRequired()
                    .HasColumnName("deliveredfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliveredtodate)
                    .IsRequired()
                    .HasColumnName("deliveredtodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationcode)
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationlocationtype)
                    .HasColumnName("destinationlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Driverlicenseno)
                    .HasColumnName("driverlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Equipmenttype)
                    .HasColumnName("equipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Incotermcode)
                    .HasColumnName("incotermcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Incotermdescription)
                    .HasColumnName("incotermdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Iscreatedshipment).HasColumnName("iscreatedshipment");

                entity.Property(e => e.Isexecuteinjobschedule).HasColumnName("isexecuteinjobschedule");

                entity.Property(e => e.Islastmile).HasColumnName("islastmile");

                entity.Property(e => e.Isoverwritecharge).HasColumnName("isoverwritecharge");

                entity.Property(e => e.Isoverwritethoughpoint).HasColumnName("isoverwritethoughpoint");

                entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

                entity.Property(e => e.Isrecievefromsap).HasColumnName("isrecievefromsap");

                entity.Property(e => e.Issenttosap).HasColumnName("issenttosap");

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Mergeintransitcode)
                    .HasColumnName("mergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Newdeliverydatefrom)
                    .HasColumnName("newdeliverydatefrom")
                    .HasMaxLength(37);

                entity.Property(e => e.Newdeliverydateto)
                    .HasColumnName("newdeliverydateto")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsposervice)
                    .HasColumnName("omsposervice")
                    .HasMaxLength(50);

                entity.Property(e => e.Orderdate)
                    .IsRequired()
                    .HasColumnName("orderdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdoctype)
                    .HasColumnName("orderdoctype")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderscheduleline)
                    .HasColumnName("orderscheduleline")
                    .HasMaxLength(3);

                entity.Property(e => e.Origincode)
                    .HasColumnName("origincode")
                    .HasMaxLength(65);

                entity.Property(e => e.Originlocationtype)
                    .HasColumnName("originlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Outsource)
                    .HasColumnName("outsource")
                    .HasMaxLength(100);

                entity.Property(e => e.Pickedupfromdate)
                    .IsRequired()
                    .HasColumnName("pickedupfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pickeduptodate)
                    .IsRequired()
                    .HasColumnName("pickeduptodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Planeddeliverydate)
                    .IsRequired()
                    .HasColumnName("planeddeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("ponumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Requestdncount).HasColumnName("requestdncount");

                entity.Property(e => e.Requesteddate)
                    .IsRequired()
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Requestrecievedatetime)
                    .HasColumnName("requestrecievedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Requestsenddatetime)
                    .HasColumnName("requestsenddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Requirepalletflag).HasColumnName("requirepalletflag");

                entity.Property(e => e.Retryno).HasColumnName("retryno");

                entity.Property(e => e.Returnflag).HasColumnName("returnflag");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Saperrormessage)
                    .HasColumnName("saperrormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Saproute)
                    .HasColumnName("saproute")
                    .HasMaxLength(6);

                entity.Property(e => e.Sapshippingpoint)
                    .HasColumnName("sapshippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapshippingpointdescription)
                    .HasColumnName("sapshippingpointdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Sapshiptocode)
                    .HasColumnName("sapshiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Sapshiptoname)
                    .HasColumnName("sapshiptoname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Servicelevel)
                    .HasColumnName("servicelevel")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceleveldescription)
                    .HasColumnName("serviceleveldescription")
                    .HasMaxLength(100);

                entity.Property(e => e.Servicetype)
                    .HasColumnName("servicetype")
                    .HasMaxLength(16);

                entity.Property(e => e.Shipmenterrormessage)
                    .HasColumnName("shipmenterrormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentmemo)
                    .HasColumnName("shipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentprocessdatetime)
                    .HasColumnName("shipmentprocessdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Shiptoaddress)
                    .HasColumnName("shiptoaddress")
                    .HasMaxLength(200);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(150);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptomobile)
                    .HasColumnName("shiptomobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptopostalcode)
                    .HasColumnName("shiptopostalcode")
                    .HasMaxLength(150);

                entity.Property(e => e.Shiptorecipientname)
                    .HasColumnName("shiptorecipientname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregioncode)
                    .HasColumnName("shiptoregioncode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregionname)
                    .HasColumnName("shiptoregionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptospecialcondition)
                    .HasColumnName("shiptospecialcondition")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptotelephone)
                    .HasColumnName("shiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Specialordertype)
                    .HasColumnName("specialordertype")
                    .HasMaxLength(120);

                entity.Property(e => e.Spotrate)
                    .HasColumnName("spotrate")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Spotunit)
                    .HasColumnName("spotunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.Stocktypecode).HasColumnName("stocktypecode");

                entity.Property(e => e.Stocktypedesc)
                    .HasColumnName("stocktypedesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Systembatchno)
                    .HasColumnName("systembatchno")
                    .HasMaxLength(50);

                entity.Property(e => e.Trailerlicenseno)
                    .HasColumnName("trailerlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Transportmode)
                    .HasColumnName("transportmode")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypeid)
                    .HasColumnName("vehicletypeid")
                    .HasMaxLength(5);

                entity.Property(e => e.Vesselname)
                    .HasColumnName("vesselname")
                    .HasMaxLength(120);

                entity.Property(e => e.Warehouseloccode)
                    .HasColumnName("warehouseloccode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmscitDeliveryThoughpoint>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Sequence, e.Locationcode })
                    .HasName("omscit_delivery_thoughpoint_pkey");

                entity.ToTable("omscit_delivery_thoughpoint", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_delivery_thoughpoint_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Legheader)
                    .IsRequired()
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Locationtype)
                    .HasColumnName("locationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<OmscitJobIntransitDetail>(entity =>
            {
                entity.HasKey(e => new { e.Jobdetailid, e.Jobheaderid })
                    .HasName("omscit_job_intransit_detail_pkey");

                entity.ToTable("omscit_job_intransit_detail", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_job_intransit_detail_dms_rep_dtt_idx");

                entity.Property(e => e.Jobdetailid).HasColumnName("jobdetailid");

                entity.Property(e => e.Jobheaderid).HasColumnName("jobheaderid");

                entity.Property(e => e.Accepttenderdatetime)
                    .HasColumnName("accepttenderdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(50);

                entity.Property(e => e.Carriername)
                    .HasColumnName("carriername")
                    .HasMaxLength(280);

                entity.Property(e => e.Confirmdatetime)
                    .HasColumnName("confirmdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Confirmflag).HasColumnName("confirmflag");

                entity.Property(e => e.Confirmpimessageid).HasColumnName("confirmpimessageid");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Destinationcode)
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(100);

                entity.Property(e => e.Differencequantity)
                    .HasColumnName("differencequantity")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Intransitdatetime)
                    .HasColumnName("intransitdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Joberrormessage)
                    .HasColumnName("joberrormessage")
                    .HasMaxLength(2000);

                entity.Property(e => e.Jobmessage)
                    .HasColumnName("jobmessage")
                    .HasMaxLength(250);

                entity.Property(e => e.Jobstatus)
                    .HasColumnName("jobstatus")
                    .HasMaxLength(3);

                entity.Property(e => e.Loadid)
                    .HasColumnName("loadid")
                    .HasMaxLength(50);

                entity.Property(e => e.Loadsequencenumber)
                    .HasColumnName("loadsequencenumber")
                    .HasMaxLength(10);

                entity.Property(e => e.Loadstatus)
                    .HasColumnName("loadstatus")
                    .HasMaxLength(100);

                entity.Property(e => e.Origincode)
                    .HasColumnName("origincode")
                    .HasMaxLength(65);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Retrievedatetime)
                    .HasColumnName("retrievedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Retrieveflag).HasColumnName("retrieveflag");

                entity.Property(e => e.Retrivepimessageid).HasColumnName("retrivepimessageid");

                entity.Property(e => e.Sapidocnumber).HasColumnName("sapidocnumber");

                entity.Property(e => e.Tmspimessageid).HasColumnName("tmspimessageid");

                entity.Property(e => e.Totalquantity)
                    .HasColumnName("totalquantity")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Tripid)
                    .HasColumnName("tripid")
                    .HasMaxLength(10);

                entity.Property(e => e.Unsuspenddatetime)
                    .HasColumnName("unsuspenddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Unsuspendflag).HasColumnName("unsuspendflag");

                entity.Property(e => e.Unsuspendpimessageid).HasColumnName("unsuspendpimessageid");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscitJobIntransitHeader>(entity =>
            {
                entity.HasKey(e => e.Jobheaderid)
                    .HasName("omscit_job_intransit_header_pkey");

                entity.ToTable("omscit_job_intransit_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_job_intransit_header_dms_rep_dtt_idx");

                entity.Property(e => e.Jobheaderid)
                    .HasColumnName("jobheaderid")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Jobheadertype)
                    .HasColumnName("jobheadertype")
                    .HasMaxLength(15);

                entity.Property(e => e.Jobname)
                    .HasColumnName("jobname")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscitJobIntransitInfo>(entity =>
            {
                entity.HasKey(e => new { e.Loadid, e.Dnnumber })
                    .HasName("omscit_job_intransit_info_pkey");

                entity.ToTable("omscit_job_intransit_info", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_job_intransit_info_dms_rep_dtt_idx");

                entity.Property(e => e.Loadid)
                    .HasColumnName("loadid")
                    .HasMaxLength(50);

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationcode)
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dnquantity)
                    .HasColumnName("dnquantity")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Dnstatus)
                    .HasColumnName("dnstatus")
                    .HasMaxLength(20);

                entity.Property(e => e.Gidatetime)
                    .HasColumnName("gidatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Origincode)
                    .HasColumnName("origincode")
                    .HasMaxLength(65);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Pickingdatetime)
                    .HasColumnName("pickingdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscitJobIntransitItem>(entity =>
            {
                entity.HasKey(e => new { e.Jobitemid, e.Jobheaderid, e.Jobdetailid })
                    .HasName("omscit_job_intransit_item_pkey");

                entity.ToTable("omscit_job_intransit_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_job_intransit_item_dms_rep_dtt_idx");

                entity.Property(e => e.Jobitemid).HasColumnName("jobitemid");

                entity.Property(e => e.Jobheaderid).HasColumnName("jobheaderid");

                entity.Property(e => e.Jobdetailid).HasColumnName("jobdetailid");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationcode)
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnquantity)
                    .HasColumnName("dnquantity")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Dnstatus)
                    .HasColumnName("dnstatus")
                    .HasMaxLength(20);

                entity.Property(e => e.Gidatetime)
                    .HasColumnName("gidatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Loadid)
                    .HasColumnName("loadid")
                    .HasMaxLength(50);

                entity.Property(e => e.Origincode)
                    .HasColumnName("origincode")
                    .HasMaxLength(65);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Pickingdatetime)
                    .HasColumnName("pickingdatetime")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmscitMasterSapCarrier>(entity =>
            {
                entity.HasKey(e => e.Carriercode)
                    .HasName("omscit_master_sap_carrier_pkey");

                entity.ToTable("omscit_master_sap_carrier", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omscit_master_sap_carrier_dms_rep_dtt_idx");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carriername)
                    .HasColumnName("carriername")
                    .HasMaxLength(280);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsmstMasterAmphur>(entity =>
            {
                entity.HasKey(e => e.Amphurcode)
                    .HasName("omsmst_master_amphur_pkey");

                entity.ToTable("omsmst_master_amphur", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_amphur_dms_rep_dtt_idx");

                entity.Property(e => e.Amphurcode)
                    .HasColumnName("amphurcode")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurname)
                    .IsRequired()
                    .HasColumnName("amphurname")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("numeric(13,10)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("numeric(13,10)");

                entity.Property(e => e.Provincecode)
                    .IsRequired()
                    .HasColumnName("provincecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Sapcode)
                    .HasColumnName("sapcode")
                    .HasMaxLength(24);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterBillForm>(entity =>
            {
                entity.ToTable("omsmst_master_bill_form", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_bill_form_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Transportmode)
                    .IsRequired()
                    .HasColumnName("transportmode")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<OmsmstMasterBusinessGroup>(entity =>
            {
                entity.HasKey(e => e.Businessgroupid)
                    .HasName("omsmst_master_business_group_pkey");

                entity.ToTable("omsmst_master_business_group", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_business_group_dms_rep_dtt_idx");

                entity.Property(e => e.Businessgroupid)
                    .HasColumnName("businessgroupid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Businessgroupname)
                    .IsRequired()
                    .HasColumnName("businessgroupname")
                    .HasMaxLength(250);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsmstMasterCustomerChannel>(entity =>
            {
                entity.HasKey(e => e.Channelid)
                    .HasName("omsmst_master_customer_channel_pkey");

                entity.ToTable("omsmst_master_customer_channel", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_customer_channel_dms_rep_dtt_idx");

                entity.Property(e => e.Channelid)
                    .HasColumnName("channelid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Channelname)
                    .IsRequired()
                    .HasColumnName("channelname")
                    .HasMaxLength(250);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsmstMasterCustomerMaterial>(entity =>
            {
                entity.ToTable("omsmst_master_customer_material", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_customer_material_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.Customermaterialcode)
                    .IsRequired()
                    .HasColumnName("customermaterialcode")
                    .HasMaxLength(100);

                entity.Property(e => e.Customermaterialname)
                    .IsRequired()
                    .HasColumnName("customermaterialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Sapmaterialcode)
                    .HasColumnName("sapmaterialcode")
                    .HasMaxLength(72);

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterCustomerProfile>(entity =>
            {
                entity.HasKey(e => e.Customercode)
                    .HasName("omsmst_master_customer_profile_pkey");

                entity.ToTable("omsmst_master_customer_profile", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_customer_profile_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.Billendofmonth).HasColumnName("billendofmonth");

                entity.Property(e => e.Billformconsol).HasColumnName("billformconsol");

                entity.Property(e => e.Billformftl).HasColumnName("billformftl");

                entity.Property(e => e.Billgrouptype)
                    .IsRequired()
                    .HasColumnName("billgrouptype")
                    .HasMaxLength(10);

                entity.Property(e => e.Billperiod)
                    .HasColumnName("billperiod")
                    .HasMaxLength(100);

                entity.Property(e => e.Businessgroupid).HasColumnName("businessgroupid");

                entity.Property(e => e.Channelid).HasColumnName("channelid");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(140);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(140);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Extrashipcond)
                    .HasColumnName("extrashipcond")
                    .HasMaxLength(1000);

                entity.Property(e => e.Isautosplit).HasColumnName("isautosplit");

                entity.Property(e => e.Isbillgroupbyorigin).HasColumnName("isbillgroupbyorigin");

                entity.Property(e => e.Isbilling).HasColumnName("isbilling");

                entity.Property(e => e.Iscalpricing).HasColumnName("iscalpricing");

                entity.Property(e => e.Iscalrequesteddate).HasColumnName("iscalrequesteddate");

                entity.Property(e => e.Ischeckcredit).HasColumnName("ischeckcredit");

                entity.Property(e => e.Isprintbill).HasColumnName("isprintbill");

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(10);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(40);

                entity.Property(e => e.Pricingdate).HasColumnName("pricingdate");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sapname1)
                    .HasColumnName("sapname1")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname2)
                    .HasColumnName("sapname2")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname3)
                    .HasColumnName("sapname3")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname4)
                    .HasColumnName("sapname4")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapregion)
                    .HasColumnName("sapregion")
                    .HasMaxLength(12);

                entity.Property(e => e.Saptaxid)
                    .HasColumnName("saptaxid")
                    .HasMaxLength(64);

                entity.Property(e => e.Saptranszone)
                    .HasColumnName("saptranszone")
                    .HasMaxLength(40);

                entity.Property(e => e.Shortname)
                    .HasColumnName("shortname")
                    .HasMaxLength(20);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(140);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Weightperschedule)
                    .HasColumnName("weightperschedule")
                    .HasColumnType("numeric(13,3)");
            });

            modelBuilder.Entity<OmsmstMasterDistrict>(entity =>
            {
                entity.HasKey(e => e.Districtcode)
                    .HasName("omsmst_master_district_pkey");

                entity.ToTable("omsmst_master_district", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_district_dms_rep_dtt_idx");

                entity.Property(e => e.Districtcode)
                    .HasColumnName("districtcode")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurcode)
                    .IsRequired()
                    .HasColumnName("amphurcode")
                    .HasMaxLength(4);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Districtname)
                    .IsRequired()
                    .HasColumnName("districtname")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterEndCustomer>(entity =>
            {
                entity.ToTable("omsmst_master_end_customer", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_end_customer_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.Customertransportmode)
                    .HasColumnName("customertransportmode")
                    .HasMaxLength(40);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Endcustomercode)
                    .IsRequired()
                    .HasColumnName("endcustomercode")
                    .HasMaxLength(100);

                entity.Property(e => e.Endcustomername)
                    .IsRequired()
                    .HasColumnName("endcustomername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Lono)
                    .HasColumnName("lono")
                    .HasMaxLength(256);

                entity.Property(e => e.Sapshiptocode)
                    .HasColumnName("sapshiptocode")
                    .HasMaxLength(40);

                entity.Property(e => e.Sapshiptotype)
                    .HasColumnName("sapshiptotype")
                    .HasMaxLength(1);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterLocation>(entity =>
            {
                entity.HasKey(e => e.Locationcode)
                    .HasName("omsmst_master_location_pkey");

                entity.ToTable("omsmst_master_location", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_location_dms_rep_dtt_idx");

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurcode)
                    .IsRequired()
                    .HasColumnName("amphurcode")
                    .HasMaxLength(4);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Destinationflag).HasColumnName("destinationflag");

                entity.Property(e => e.Districtcode)
                    .HasColumnName("districtcode")
                    .HasMaxLength(6);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Houseno)
                    .HasColumnName("houseno")
                    .HasMaxLength(20);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("numeric(13,10)");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Locationtype).HasColumnName("locationtype");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("numeric(13,10)");

                entity.Property(e => e.Originflag).HasColumnName("originflag");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Provincecode)
                    .IsRequired()
                    .HasColumnName("provincecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Receipient)
                    .HasColumnName("receipient")
                    .HasMaxLength(50);

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Saplocationcode)
                    .HasColumnName("saplocationcode")
                    .HasMaxLength(64);

                entity.Property(e => e.Sapshippingpoint)
                    .HasColumnName("sapshippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapshipto)
                    .HasColumnName("sapshipto")
                    .HasMaxLength(40);

                entity.Property(e => e.Soi)
                    .HasColumnName("soi")
                    .HasMaxLength(88);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(1000);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<OmsmstMasterLocationType>(entity =>
            {
                entity.HasKey(e => e.Locationtypeid)
                    .HasName("omsmst_master_location_type_pkey");

                entity.ToTable("omsmst_master_location_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_location_type_dms_rep_dtt_idx");

                entity.Property(e => e.Locationtypeid)
                    .HasColumnName("locationtypeid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Locationtypename)
                    .IsRequired()
                    .HasColumnName("locationtypename")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsmstMasterMaterial>(entity =>
            {
                entity.HasKey(e => e.Materialcode)
                    .HasName("omsmst_master_material_pkey");

                entity.ToTable("omsmst_master_material", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_material_dms_rep_dtt_idx");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Baseunit)
                    .IsRequired()
                    .HasColumnName("baseunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Bomflag).HasColumnName("bomflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Dimensionunit)
                    .HasColumnName("dimensionunit")
                    .HasMaxLength(12);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Eancode)
                    .HasColumnName("eancode")
                    .HasMaxLength(128);

                entity.Property(e => e.Freeflag).HasColumnName("freeflag");

                entity.Property(e => e.Grossweight)
                    .HasColumnName("grossweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialname)
                    .HasColumnName("materialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Materialshortname)
                    .HasColumnName("materialshortname")
                    .HasMaxLength(100);

                entity.Property(e => e.Netweight)
                    .HasColumnName("netweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Pricingunit)
                    .HasColumnName("pricingunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Productgroupid).HasColumnName("productgroupid");

                entity.Property(e => e.Sapmaterialcode)
                    .HasColumnName("sapmaterialcode")
                    .HasMaxLength(72);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicleflag).HasColumnName("vehicleflag");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Volumeunit)
                    .IsRequired()
                    .HasColumnName("volumeunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Volumeweight)
                    .HasColumnName("volumeweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Weightunit)
                    .IsRequired()
                    .HasColumnName("weightunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("numeric(15,3)");
            });

            modelBuilder.Entity<OmsmstMasterMaterialBom>(entity =>
            {
                entity.HasKey(e => new { e.Materialcode, e.Bomno })
                    .HasName("omsmst_master_material_bom_pkey");

                entity.ToTable("omsmst_master_material_bom", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_material_bom_dms_rep_dtt_idx");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Bomno).HasColumnName("bomno");

                entity.Property(e => e.Childmatcode)
                    .HasColumnName("childmatcode")
                    .HasMaxLength(12);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterMaterialUnitConv>(entity =>
            {
                entity.HasKey(e => new { e.Materialcode, e.Alterunit })
                    .HasName("omsmst_master_material_unit_conv_pkey");

                entity.ToTable("omsmst_master_material_unit_conv", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_material_unit_conv_dms_rep_dtt_idx");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Alterunit)
                    .HasColumnName("alterunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Denumerator).HasColumnName("denumerator");

                entity.Property(e => e.Dimensionunit)
                    .HasColumnName("dimensionunit")
                    .HasMaxLength(12);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Numerator).HasColumnName("numerator");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Volumeweight)
                    .HasColumnName("volumeweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("numeric(15,3)");
            });

            modelBuilder.Entity<OmsmstMasterMatfrtgrp>(entity =>
            {
                entity.HasKey(e => e.Matfrtgrpcode)
                    .HasName("omsmst_master_matfrtgrp_pkey");

                entity.ToTable("omsmst_master_matfrtgrp", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_matfrtgrp_dms_rep_dtt_idx");

                entity.Property(e => e.Matfrtgrpcode)
                    .HasColumnName("matfrtgrpcode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Matfrtgrpdesc)
                    .HasColumnName("matfrtgrpdesc")
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterOriginLocation>(entity =>
            {
                entity.HasKey(e => new { e.Locationcode, e.Customercode })
                    .HasName("omsmst_master_origin_location_pkey");

                entity.ToTable("omsmst_master_origin_location", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_origin_location_dms_rep_dtt_idx");

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sapshippingpointcode)
                    .HasColumnName("sapshippingpointcode")
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<OmsmstMasterPricingDate>(entity =>
            {
                entity.ToTable("omsmst_master_pricing_date", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_pricing_date_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsmstMasterProductGroup>(entity =>
            {
                entity.ToTable("omsmst_master_product_group", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_product_group_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterProvince>(entity =>
            {
                entity.HasKey(e => e.Provincecode)
                    .HasName("omsmst_master_province_pkey");

                entity.ToTable("omsmst_master_province", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_province_dms_rep_dtt_idx");

                entity.Property(e => e.Provincecode)
                    .HasColumnName("provincecode")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Provincename)
                    .IsRequired()
                    .HasColumnName("provincename")
                    .HasMaxLength(100);

                entity.Property(e => e.Regioncode).HasColumnName("regioncode");

                entity.Property(e => e.Sapcode)
                    .HasColumnName("sapcode")
                    .HasMaxLength(28);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterRegion>(entity =>
            {
                entity.HasKey(e => e.Regioncode)
                    .HasName("omsmst_master_region_pkey");

                entity.ToTable("omsmst_master_region", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_region_dms_rep_dtt_idx");

                entity.Property(e => e.Regioncode)
                    .HasColumnName("regioncode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Regionname)
                    .HasColumnName("regionname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsmstMasterSapAmphur>(entity =>
            {
                entity.HasKey(e => e.Amphurcode)
                    .HasName("omsmst_master_sap_amphur_pkey");

                entity.ToTable("omsmst_master_sap_amphur", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_sap_amphur_dms_rep_dtt_idx");

                entity.Property(e => e.Amphurcode)
                    .HasColumnName("amphurcode")
                    .HasMaxLength(28)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurname)
                    .HasColumnName("amphurname")
                    .HasMaxLength(140);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsmstMasterSapMatFreightGroup>(entity =>
            {
                entity.HasKey(e => e.Matfrtgrpcode)
                    .HasName("omsmst_master_sap_mat_freight_group_pkey");

                entity.ToTable("omsmst_master_sap_mat_freight_group", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_sap_mat_freight_group_dms_rep_dtt_idx");

                entity.Property(e => e.Matfrtgrpcode)
                    .HasColumnName("matfrtgrpcode")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Matfrtgrpdesc)
                    .HasColumnName("matfrtgrpdesc")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsmstMasterSapProvince>(entity =>
            {
                entity.HasKey(e => e.Provincecode)
                    .HasName("omsmst_master_sap_province_pkey");

                entity.ToTable("omsmst_master_sap_province", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_sap_province_dms_rep_dtt_idx");

                entity.Property(e => e.Provincecode)
                    .HasColumnName("provincecode")
                    .HasMaxLength(24)
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Provincename)
                    .IsRequired()
                    .HasColumnName("provincename")
                    .HasMaxLength(140);
            });

            modelBuilder.Entity<OmsmstMasterSapShippingpoint>(entity =>
            {
                entity.HasKey(e => new { e.Sapshippingpointcode, e.Systemid })
                    .HasName("omsmst_master_sap_shippingpoint_pkey");

                entity.ToTable("omsmst_master_sap_shippingpoint", "dom");

                entity.Property(e => e.Sapshippingpointcode)
                    .HasColumnName("sapshippingpointcode")
                    .HasMaxLength(16);

                entity.Property(e => e.Systemid).HasColumnName("systemid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sapshippingpointname)
                    .HasColumnName("sapshippingpointname")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<OmsmstMasterSapShippingpointPlant>(entity =>
            {
                entity.HasKey(e => new { e.Sapshippingpointcode, e.Sapplantcode })
                    .HasName("omsmst_master_sap_shippingpoint_plant_pkey");

                entity.ToTable("omsmst_master_sap_shippingpoint_plant", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_sap_shippingpoint_plant_dms_rep_dtt_idx");

                entity.Property(e => e.Sapshippingpointcode)
                    .HasColumnName("sapshippingpointcode")
                    .HasMaxLength(16);

                entity.Property(e => e.Sapplantcode)
                    .HasColumnName("sapplantcode")
                    .HasMaxLength(16);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sapshippingpointname)
                    .HasColumnName("sapshippingpointname")
                    .HasMaxLength(400);

                entity.Property(e => e.Saptranzone)
                    .HasColumnName("saptranzone")
                    .HasMaxLength(28);
            });

            modelBuilder.Entity<OmsmstMasterSapShipto>(entity =>
            {
                entity.HasKey(e => e.Shiptocode)
                    .HasName("omsmst_master_sap_shipto_pkey");

                entity.ToTable("omsmst_master_sap_shipto", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_sap_shipto_dms_rep_dtt_idx");

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(140);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(140);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(10);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(40);

                entity.Property(e => e.Sapname1)
                    .HasColumnName("sapname1")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname2)
                    .HasColumnName("sapname2")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname3)
                    .HasColumnName("sapname3")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname4)
                    .HasColumnName("sapname4")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapregion)
                    .HasColumnName("sapregion")
                    .HasMaxLength(12);

                entity.Property(e => e.Saptaxid)
                    .HasColumnName("saptaxid")
                    .HasMaxLength(64);

                entity.Property(e => e.Saptranszone)
                    .HasColumnName("saptranszone")
                    .HasMaxLength(40);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(140);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsmstMasterSapShiptoAmphur>(entity =>
            {
                entity.HasKey(e => e.Shiptocode)
                    .HasName("omsmst_master_sap_shipto_amphur_pkey");

                entity.ToTable("omsmst_master_sap_shipto_amphur", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_sap_shipto_amphur_dms_rep_dtt_idx");

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurcode)
                    .IsRequired()
                    .HasColumnName("amphurcode")
                    .HasMaxLength(28);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Provincecode)
                    .HasColumnName("provincecode")
                    .HasMaxLength(24);
            });

            modelBuilder.Entity<OmsmstMasterStdUnitConv>(entity =>
            {
                entity.HasKey(e => new { e.Baseunitcode, e.Alterunitcode })
                    .HasName("omsmst_master_std_unit_conv_pkey");

                entity.ToTable("omsmst_master_std_unit_conv", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_std_unit_conv_dms_rep_dtt_idx");

                entity.Property(e => e.Baseunitcode)
                    .HasColumnName("baseunitcode")
                    .HasMaxLength(450);

                entity.Property(e => e.Alterunitcode)
                    .HasColumnName("alterunitcode")
                    .HasMaxLength(450);

                entity.Property(e => e.Alterquantity)
                    .HasColumnName("alterquantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Basequantity)
                    .HasColumnName("basequantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsmstMasterUnit>(entity =>
            {
                entity.HasKey(e => e.Unitcode)
                    .HasName("omsmst_master_unit_pkey");

                entity.ToTable("omsmst_master_unit", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_unit_dms_rep_dtt_idx");

                entity.Property(e => e.Unitcode)
                    .HasColumnName("unitcode")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Decimalflag).HasColumnName("decimalflag");

                entity.Property(e => e.Dimensionunit).HasColumnName("dimensionunit");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isocode)
                    .HasColumnName("isocode")
                    .HasMaxLength(12);

                entity.Property(e => e.Unitdescription)
                    .HasColumnName("unitdescription")
                    .HasMaxLength(250);

                entity.Property(e => e.Volumeunit).HasColumnName("volumeunit");

                entity.Property(e => e.Weightunit).HasColumnName("weightunit");
            });

            modelBuilder.Entity<OmsmstMasterVehicleSubtype>(entity =>
            {
                entity.HasKey(e => new { e.Vehicletypecode, e.Vehiclesubtypecode })
                    .HasName("omsmst_master_vehicle_subtype_pkey");

                entity.ToTable("omsmst_master_vehicle_subtype", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_vehicle_subtype_dms_rep_dtt_idx");

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Vehiclesubtypecode)
                    .HasColumnName("vehiclesubtypecode")
                    .HasMaxLength(6);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Vehiclesubtypename)
                    .HasColumnName("vehiclesubtypename")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsmstMasterVehicleType>(entity =>
            {
                entity.HasKey(e => e.Vehicletypecode)
                    .HasName("omsmst_master_vehicle_type_pkey");

                entity.ToTable("omsmst_master_vehicle_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsmst_master_vehicle_type_dms_rep_dtt_idx");

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.Buildmatflag).HasColumnName("buildmatflag");

                entity.Property(e => e.Capvolume)
                    .HasColumnName("capvolume")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Capvolumeunit)
                    .IsRequired()
                    .HasColumnName("capvolumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Capweight)
                    .HasColumnName("capweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Capweightunit)
                    .IsRequired()
                    .HasColumnName("capweightunit")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Minweight)
                    .HasColumnName("minweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Schedulingflag).HasColumnName("schedulingflag");

                entity.Property(e => e.Shipcondcode)
                    .HasColumnName("shipcondcode")
                    .HasMaxLength(2);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Utilityweight)
                    .HasColumnName("utilityweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Vehicletypename)
                    .IsRequired()
                    .HasColumnName("vehicletypename")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordActTransportService>(entity =>
            {
                entity.ToTable("omsord_act_transport_service", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_act_transport_service_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Arflag).HasColumnName("arflag");

                entity.Property(e => e.Baseunit)
                    .HasColumnName("baseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Fuelrate)
                    .HasColumnName("fuelrate")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Fueltype)
                    .HasColumnName("fueltype")
                    .HasMaxLength(10);

                entity.Property(e => e.Gidate)
                    .IsRequired()
                    .HasColumnName("gidate")
                    .HasMaxLength(37);

                entity.Property(e => e.Interfaceid)
                    .HasColumnName("interfaceid")
                    .HasMaxLength(40);

                entity.Property(e => e.Layer)
                    .IsRequired()
                    .HasColumnName("layer")
                    .HasMaxLength(1);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Pricebyweight)
                    .HasColumnName("pricebyweight")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Pricecaltype)
                    .HasColumnName("pricecaltype")
                    .HasMaxLength(20);

                entity.Property(e => e.Pricequantity)
                    .HasColumnName("pricequantity")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Pricerate)
                    .HasColumnName("pricerate")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Pricingunit).HasColumnName("pricingunit");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Serviceitemid).HasColumnName("serviceitemid");

                entity.Property(e => e.Serviceitemname)
                    .HasColumnName("serviceitemname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

                entity.Property(e => e.Servicetypename)
                    .HasColumnName("servicetypename")
                    .HasMaxLength(200);

                entity.Property(e => e.Shipmentnumber)
                    .IsRequired()
                    .HasColumnName("shipmentnumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Vehicletypename)
                    .HasColumnName("vehicletypename")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordBatchOrderUpload>(entity =>
            {
                entity.ToTable("omsord_batch_order_upload", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_batch_order_upload_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Autosplitbatchno)
                    .HasColumnName("autosplitbatchno")
                    .HasMaxLength(25);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Inprocessflag).HasColumnName("inprocessflag");

                entity.Property(e => e.Templateid).HasColumnName("templateid");

                entity.Property(e => e.Uploadby)
                    .HasColumnName("uploadby")
                    .HasMaxLength(200);

                entity.Property(e => e.Uploaddate)
                    .HasColumnName("uploaddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordBillHeader>(entity =>
            {
                entity.ToTable("omsord_bill_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_bill_header_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Approvedby)
                    .HasColumnName("approvedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Approveddate)
                    .HasColumnName("approveddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Baselinedate)
                    .IsRequired()
                    .HasColumnName("baselinedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Billgroupname)
                    .HasColumnName("billgroupname")
                    .HasMaxLength(100);

                entity.Property(e => e.Billingdate).HasColumnName("billingdate");

                entity.Property(e => e.Billnumber)
                    .IsRequired()
                    .HasColumnName("billnumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasColumnName("channel")
                    .HasMaxLength(4);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(3);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Invoicecreationdate)
                    .IsRequired()
                    .HasColumnName("invoicecreationdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Isprinted).HasColumnName("isprinted");

                entity.Property(e => e.Isreposted).HasColumnName("isreposted");

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(4);

                entity.Property(e => e.Periodfrom)
                    .IsRequired()
                    .HasColumnName("periodfrom")
                    .HasMaxLength(37);

                entity.Property(e => e.Periodto)
                    .IsRequired()
                    .HasColumnName("periodto")
                    .HasMaxLength(37);

                entity.Property(e => e.Postingdate)
                    .IsRequired()
                    .HasColumnName("postingdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Postsapstatus)
                    .IsRequired()
                    .HasColumnName("postsapstatus")
                    .HasMaxLength(1);

                entity.Property(e => e.Refsapfidocno)
                    .HasColumnName("refsapfidocno")
                    .HasMaxLength(10);

                entity.Property(e => e.Refsapfiscalyear)
                    .HasColumnName("refsapfiscalyear")
                    .HasMaxLength(4);

                entity.Property(e => e.Saperrormessage)
                    .HasColumnName("saperrormessage")
                    .HasMaxLength(50);

                entity.Property(e => e.Sapfidocno)
                    .HasColumnName("sapfidocno")
                    .HasMaxLength(10);

                entity.Property(e => e.Sapfiscalyear)
                    .HasColumnName("sapfiscalyear")
                    .HasMaxLength(4);

                entity.Property(e => e.Sappaymentdate)
                    .HasColumnName("sappaymentdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Sappaymentdocno)
                    .HasColumnName("sappaymentdocno")
                    .HasMaxLength(10);

                entity.Property(e => e.Servicecode)
                    .IsRequired()
                    .HasColumnName("servicecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Taxcode)
                    .IsRequired()
                    .HasColumnName("taxcode")
                    .HasMaxLength(2);

                entity.Property(e => e.Transportmode)
                    .IsRequired()
                    .HasColumnName("transportmode")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vatamount)
                    .HasColumnName("vatamount")
                    .HasColumnType("numeric(13,2)");
            });

            modelBuilder.Entity<OmsordBillItem>(entity =>
            {
                entity.HasKey(e => new { e.Billid, e.Dnnumber })
                    .HasName("omsord_bill_item_pkey");

                entity.ToTable("omsord_bill_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_bill_item_dms_rep_dtt_idx");

                entity.Property(e => e.Billid).HasColumnName("billid");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Gidate)
                    .HasColumnName("gidate")
                    .HasMaxLength(37);

                entity.Property(e => e.Giheadertext)
                    .HasColumnName("giheadertext")
                    .HasMaxLength(500);

                entity.Property(e => e.Matfreightgroup)
                    .IsRequired()
                    .HasColumnName("matfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Ordercreatorname)
                    .HasColumnName("ordercreatorname")
                    .HasMaxLength(100);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pono)
                    .HasColumnName("pono")
                    .HasMaxLength(50);

                entity.Property(e => e.Pricerate)
                    .HasColumnName("pricerate")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Servicelevel)
                    .HasColumnName("servicelevel")
                    .HasMaxLength(100);

                entity.Property(e => e.Shipfromcode)
                    .HasColumnName("shipfromcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shipfromname)
                    .HasColumnName("shipfromname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentnumber)
                    .HasColumnName("shipmentnumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Vehicletypename)
                    .HasColumnName("vehicletypename")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordBillItemGroup>(entity =>
            {
                entity.HasKey(e => new { e.Billid, e.Matfreightgroup })
                    .HasName("omsord_bill_item_group_pkey");

                entity.ToTable("omsord_bill_item_group", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_bill_item_group_dms_rep_dtt_idx");

                entity.Property(e => e.Billid).HasColumnName("billid");

                entity.Property(e => e.Matfreightgroup)
                    .HasColumnName("matfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Itemtext)
                    .IsRequired()
                    .HasColumnName("itemtext")
                    .HasMaxLength(48);

                entity.Property(e => e.Matfreightgroupdesc)
                    .HasColumnName("matfreightgroupdesc")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordBkDeliverySapHeader>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Legid })
                    .HasName("omsord_bk_delivery_sap_header_pkey");

                entity.ToTable("omsord_bk_delivery_sap_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_bk_delivery_sap_header_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Batchupdateddate)
                    .HasColumnName("batchupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Biglot).HasColumnName("biglot");

                entity.Property(e => e.Cancelflag).HasColumnName("cancelflag");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(32);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Deliveredfromdate)
                    .IsRequired()
                    .HasColumnName("deliveredfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliveredtodate)
                    .IsRequired()
                    .HasColumnName("deliveredtodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationcode)
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationlocationtype)
                    .HasColumnName("destinationlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Driverlicenseno)
                    .HasColumnName("driverlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Equipmenttype)
                    .HasColumnName("equipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Incotermcode)
                    .HasColumnName("incotermcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Incotermdescription)
                    .HasColumnName("incotermdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Iscreatedshipment).HasColumnName("iscreatedshipment");

                entity.Property(e => e.Isexecuteinjobschedule).HasColumnName("isexecuteinjobschedule");

                entity.Property(e => e.Islastmile).HasColumnName("islastmile");

                entity.Property(e => e.Isoverwritecharge).HasColumnName("isoverwritecharge");

                entity.Property(e => e.Isoverwritethoughpoint).HasColumnName("isoverwritethoughpoint");

                entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

                entity.Property(e => e.Isrecievefromsap).HasColumnName("isrecievefromsap");

                entity.Property(e => e.Issenttosap).HasColumnName("issenttosap");

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Mergeintransitcode)
                    .HasColumnName("mergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Newdeliverydatefrom)
                    .HasColumnName("newdeliverydatefrom")
                    .HasMaxLength(37);

                entity.Property(e => e.Newdeliverydateto)
                    .HasColumnName("newdeliverydateto")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsposervice)
                    .HasColumnName("omsposervice")
                    .HasMaxLength(50);

                entity.Property(e => e.Orderdate)
                    .IsRequired()
                    .HasColumnName("orderdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdoctype)
                    .HasColumnName("orderdoctype")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderscheduleline)
                    .HasColumnName("orderscheduleline")
                    .HasMaxLength(3);

                entity.Property(e => e.Origincode)
                    .HasColumnName("origincode")
                    .HasMaxLength(10);

                entity.Property(e => e.Originlocationtype)
                    .HasColumnName("originlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Outsource)
                    .HasColumnName("outsource")
                    .HasMaxLength(100);

                entity.Property(e => e.Pickedupfromdate)
                    .IsRequired()
                    .HasColumnName("pickedupfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pickeduptodate)
                    .IsRequired()
                    .HasColumnName("pickeduptodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Planeddeliverydate)
                    .IsRequired()
                    .HasColumnName("planeddeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("ponumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Requestdncount).HasColumnName("requestdncount");

                entity.Property(e => e.Requesteddate)
                    .IsRequired()
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Requirepalletflag).HasColumnName("requirepalletflag");

                entity.Property(e => e.Retryno).HasColumnName("retryno");

                entity.Property(e => e.Returnflag).HasColumnName("returnflag");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Saperrormessage)
                    .HasColumnName("saperrormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Saproute)
                    .HasColumnName("saproute")
                    .HasMaxLength(6);

                entity.Property(e => e.Sapshippingpoint)
                    .HasColumnName("sapshippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapshippingpointdescription)
                    .HasColumnName("sapshippingpointdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Sapshiptocode)
                    .HasColumnName("sapshiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Sapshiptoname)
                    .HasColumnName("sapshiptoname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Servicelevel)
                    .HasColumnName("servicelevel")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceleveldescription)
                    .HasColumnName("serviceleveldescription")
                    .HasMaxLength(100);

                entity.Property(e => e.Servicetype)
                    .HasColumnName("servicetype")
                    .HasMaxLength(16);

                entity.Property(e => e.Shipmenterrormessage)
                    .HasColumnName("shipmenterrormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentloadid)
                    .HasColumnName("shipmentloadid")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipmentmemo)
                    .HasColumnName("shipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentprocessdatetime)
                    .HasColumnName("shipmentprocessdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Shiptoaddress)
                    .HasColumnName("shiptoaddress")
                    .HasMaxLength(200);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(150);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptomobile)
                    .HasColumnName("shiptomobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shiptopostalcode)
                    .HasColumnName("shiptopostalcode")
                    .HasMaxLength(150);

                entity.Property(e => e.Shiptorecipientname)
                    .HasColumnName("shiptorecipientname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregioncode)
                    .HasColumnName("shiptoregioncode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregionname)
                    .HasColumnName("shiptoregionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptospecialcondition)
                    .HasColumnName("shiptospecialcondition")
                    .HasMaxLength(100);

                entity.Property(e => e.Shiptotelephone)
                    .HasColumnName("shiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Specialordertype)
                    .HasColumnName("specialordertype")
                    .HasMaxLength(120);

                entity.Property(e => e.Spotrate)
                    .HasColumnName("spotrate")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Spotunit)
                    .HasColumnName("spotunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.Stocktypecode).HasColumnName("stocktypecode");

                entity.Property(e => e.Stocktypedesc)
                    .HasColumnName("stocktypedesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Systembatchno)
                    .HasColumnName("systembatchno")
                    .HasMaxLength(50);

                entity.Property(e => e.Trailerlicenseno)
                    .HasColumnName("trailerlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Transportmode)
                    .HasColumnName("transportmode")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypeid)
                    .HasColumnName("vehicletypeid")
                    .HasMaxLength(5);

                entity.Property(e => e.Vesselname)
                    .HasColumnName("vesselname")
                    .HasMaxLength(120);

                entity.Property(e => e.Warehouseloccode)
                    .HasColumnName("warehouseloccode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordBkDeliverySapItem>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Dnitem, e.Legid })
                    .HasName("omsord_bk_delivery_sap_item_pkey");

                entity.ToTable("omsord_bk_delivery_sap_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_bk_delivery_sap_item_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Dnitem)
                    .HasColumnName("dnitem")
                    .HasMaxLength(3);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Cancelflag).HasColumnName("cancelflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Deliveryquantity)
                    .HasColumnName("deliveryquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isosaleunit)
                    .HasColumnName("isosaleunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Isovolumeunit)
                    .HasColumnName("isovolumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Isoweightunit)
                    .HasColumnName("isoweightunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightdescription)
                    .HasColumnName("materialfreightdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Materialfreightgroup)
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialname)
                    .HasColumnName("materialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialpricingunit)
                    .HasColumnName("materialpricingunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Requestpalletflag).HasColumnName("requestpalletflag");

                entity.Property(e => e.Shippingcondition)
                    .HasColumnName("shippingcondition")
                    .HasMaxLength(2);

                entity.Property(e => e.Shippingconditiondescription)
                    .HasColumnName("shippingconditiondescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Shippingpoint)
                    .HasColumnName("shippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Shippingpointdescription)
                    .HasColumnName("shippingpointdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Soitemnumber)
                    .IsRequired()
                    .HasColumnName("soitemnumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeperunit)
                    .HasColumnName("volumeperunit")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Volumeperunitccm)
                    .HasColumnName("volumeperunitccm")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightperunit)
                    .HasColumnName("weightperunit")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Weightperunitkg)
                    .HasColumnName("weightperunitkg")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordConfigBiglotOrder>(entity =>
            {
                entity.ToTable("omsord_config_biglot_order", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_config_biglot_order_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Originlocationcode)
                    .IsRequired()
                    .HasColumnName("originlocationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasColumnName("unit")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("numeric(13,3)");
            });

            modelBuilder.Entity<OmsordConfigShippingPointAuto>(entity =>
            {
                entity.HasKey(e => new { e.Configtype, e.Shippingpoint })
                    .HasName("omsord_config_shipping_point_auto_pkey");

                entity.ToTable("omsord_config_shipping_point_auto", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_config_shipping_point_auto_dms_rep_dtt_idx");

                entity.Property(e => e.Configtype)
                    .HasColumnName("configtype")
                    .HasMaxLength(3);

                entity.Property(e => e.Shippingpoint)
                    .HasColumnName("shippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OmsordCustomerHoliday>(entity =>
            {
                entity.HasKey(e => new { e.Customercode, e.Holidaydate })
                    .HasName("omsord_customer_holiday_pkey");

                entity.ToTable("omsord_customer_holiday", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_customer_holiday_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Holidaydate)
                    .HasColumnName("holidaydate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Holidayname)
                    .HasColumnName("holidayname")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive).HasColumnName("is_active");
            });

            modelBuilder.Entity<OmsordCustomerServiceExpress>(entity =>
            {
                entity.HasKey(e => new { e.Customercode, e.Serviceid })
                    .HasName("omsord_customer_service_express_pkey");

                entity.ToTable("omsord_customer_service_express", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_customer_service_express_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceid)
                    .HasColumnName("serviceid")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Ordercutofftime)
                    .IsRequired()
                    .HasColumnName("ordercutofftime")
                    .HasMaxLength(16);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordCustomerServiceLeadtime>(entity =>
            {
                entity.HasKey(e => new { e.Customercode, e.Routeid })
                    .HasName("omsord_customer_service_leadtime_pkey");

                entity.ToTable("omsord_customer_service_leadtime", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_customer_service_leadtime_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Routeid)
                    .HasColumnName("routeid")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsStandard).HasColumnName("is_standard");

                entity.Property(e => e.Leadtime).HasColumnName("leadtime");

                entity.Property(e => e.Ordercutofftime)
                    .IsRequired()
                    .HasColumnName("ordercutofftime")
                    .HasMaxLength(16);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordCustomerServiceWindow>(entity =>
            {
                entity.HasKey(e => new { e.Customercode, e.Transportid })
                    .HasName("omsord_customer_service_window_pkey");

                entity.ToTable("omsord_customer_service_window", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_customer_service_window_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsStandard).HasColumnName("is_standard");

                entity.Property(e => e.Ordercutofftime)
                    .IsRequired()
                    .HasColumnName("ordercutofftime")
                    .HasMaxLength(16);

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordCustomerServiceWindowSchedule>(entity =>
            {
                entity.HasKey(e => new { e.Customercode, e.Transportid, e.Arrivalday, e.Departureday })
                    .HasName("omsord_customer_service_window_schedule_pkey");

                entity.ToTable("omsord_customer_service_window_schedule", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_customer_service_window_schedule_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.Arrivalday)
                    .HasColumnName("arrivalday")
                    .HasMaxLength(10);

                entity.Property(e => e.Departureday)
                    .HasColumnName("departureday")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordCustomerWorkingday>(entity =>
            {
                entity.HasKey(e => e.Customercode)
                    .HasName("omsord_customer_workingday_pkey");

                entity.ToTable("omsord_customer_workingday", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_customer_workingday_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Friday).HasColumnName("friday");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Monday).HasColumnName("monday");

                entity.Property(e => e.Saturday).HasColumnName("saturday");

                entity.Property(e => e.Sunday).HasColumnName("sunday");

                entity.Property(e => e.Thursday).HasColumnName("thursday");

                entity.Property(e => e.Tuesday).HasColumnName("tuesday");

                entity.Property(e => e.Wednesday).HasColumnName("wednesday");
            });

            modelBuilder.Entity<OmsordDeliveryHeader>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Legid, e.Deliverytype })
                    .HasName("omsord_delivery_header_pkey");

                entity.ToTable("omsord_delivery_header", "dom");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Batchupdatedate)
                    .HasColumnName("batchupdatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Biglot).HasColumnName("biglot");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(32);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercity)
                    .HasColumnName("customercity")
                    .HasMaxLength(140);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customerdistrict)
                    .HasColumnName("customerdistrict")
                    .HasMaxLength(140);

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasColumnName("customername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Customerpostalcode)
                    .HasColumnName("customerpostalcode")
                    .HasMaxLength(140);

                entity.Property(e => e.Customerstreet)
                    .HasColumnName("customerstreet")
                    .HasMaxLength(140);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Delivereddatetime)
                    .HasColumnName("delivereddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliveredfromdate)
                    .IsRequired()
                    .HasColumnName("deliveredfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliveredtodate)
                    .IsRequired()
                    .HasColumnName("deliveredtodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Destinationcode)
                    .IsRequired()
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationlocationtype)
                    .HasColumnName("destinationlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(100);

                entity.Property(e => e.Dmreceivertelephone)
                    .HasColumnName("dmreceivertelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dmscheduledate)
                    .HasColumnName("dmscheduledate")
                    .HasMaxLength(37);

                entity.Property(e => e.Docreturndatetime)
                    .HasColumnName("docreturndatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Driverlicenseno)
                    .HasColumnName("driverlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Endcustomercode)
                    .IsRequired()
                    .HasColumnName("endcustomercode")
                    .HasMaxLength(100);

                entity.Property(e => e.Endcustomername)
                    .IsRequired()
                    .HasColumnName("endcustomername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Equipmenttype)
                    .HasColumnName("equipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Freightclasscode)
                    .HasColumnName("freightclasscode")
                    .HasMaxLength(10);

                entity.Property(e => e.Gicompleteddatetime)
                    .HasColumnName("gicompleteddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Giheadertext)
                    .HasColumnName("giheadertext")
                    .HasMaxLength(500);

                entity.Property(e => e.Giremark)
                    .HasColumnName("giremark")
                    .HasMaxLength(500);

                entity.Property(e => e.Grcompleteddatetime)
                    .HasColumnName("grcompleteddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Grremark)
                    .HasColumnName("grremark")
                    .HasMaxLength(500);

                entity.Property(e => e.Haveshippingmark).HasColumnName("haveshippingmark");

                entity.Property(e => e.Incotermcode)
                    .HasColumnName("incotermcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Incotermcode2)
                    .HasColumnName("incotermcode2")
                    .HasMaxLength(70);

                entity.Property(e => e.Incotermcode3)
                    .HasColumnName("incotermcode3")
                    .HasMaxLength(70);

                entity.Property(e => e.Incotermdescription)
                    .HasColumnName("incotermdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Iscompletedgi).HasColumnName("iscompletedgi");

                entity.Property(e => e.Iscompletedgr).HasColumnName("iscompletedgr");

                entity.Property(e => e.Iscompletedpackedflag).HasColumnName("iscompletedpackedflag");

                entity.Property(e => e.Isconfirmdndist).HasColumnName("isconfirmdndist");

                entity.Property(e => e.Iscreatednsap).HasColumnName("iscreatednsap");

                entity.Property(e => e.Iscreateshipment).HasColumnName("iscreateshipment");

                entity.Property(e => e.Isexecutejobschedule).HasColumnName("isexecutejobschedule");

                entity.Property(e => e.Isoverridethoughpoint).HasColumnName("isoverridethoughpoint");

                entity.Property(e => e.Isoverwritecharge).HasColumnName("isoverwritecharge");

                entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

                entity.Property(e => e.Issapgiadvance).HasColumnName("issapgiadvance");

                entity.Property(e => e.Issuspendload).HasColumnName("issuspendload");

                entity.Property(e => e.Legheader)
                    .IsRequired()
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Licenseplate)
                    .HasColumnName("licenseplate")
                    .HasMaxLength(22);

                entity.Property(e => e.Mergeintransitcode)
                    .HasColumnName("mergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Omsrouteid)
                    .HasColumnName("omsrouteid")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderdate)
                    .IsRequired()
                    .HasColumnName("orderdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdoctype)
                    .HasColumnName("orderdoctype")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderpatternid).HasColumnName("orderpatternid");

                entity.Property(e => e.Orderscheduleline).HasColumnName("orderscheduleline");

                entity.Property(e => e.Orderschedulelineno).HasColumnName("orderschedulelineno");

                entity.Property(e => e.Origincode)
                    .IsRequired()
                    .HasColumnName("origincode")
                    .HasMaxLength(10);

                entity.Property(e => e.Originlocationtype)
                    .HasColumnName("originlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Outsource)
                    .HasColumnName("outsource")
                    .HasMaxLength(100);

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(5);

                entity.Property(e => e.Pickedupfromdate)
                    .IsRequired()
                    .HasColumnName("pickedupfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pickeduptodate)
                    .IsRequired()
                    .HasColumnName("pickeduptodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Planeddeliverydate)
                    .IsRequired()
                    .HasColumnName("planeddeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("ponumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Receivedflag).HasColumnName("receivedflag");

                entity.Property(e => e.Refblockdndist).HasColumnName("refblockdndist");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Refsaleorg)
                    .HasColumnName("refsaleorg")
                    .HasMaxLength(5);

                entity.Property(e => e.Refwaitdnsap).HasColumnName("refwaitdnsap");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Requesteddate)
                    .IsRequired()
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Requirepackflag).HasColumnName("requirepackflag");

                entity.Property(e => e.Requirepalletflag).HasColumnName("requirepalletflag");

                entity.Property(e => e.Retryno).HasColumnName("retryno");

                entity.Property(e => e.Returnflag).HasColumnName("returnflag");

                entity.Property(e => e.Sapshipmentnumber)
                    .HasColumnName("sapshipmentnumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Sapshippingpoint)
                    .HasColumnName("sapshippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapshipto)
                    .HasColumnName("sapshipto")
                    .HasMaxLength(10);

                entity.Property(e => e.Sapshiptoname)
                    .HasColumnName("sapshiptoname")
                    .HasMaxLength(100);

                entity.Property(e => e.Servicelevel)
                    .IsRequired()
                    .HasColumnName("servicelevel")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceleveldescription)
                    .HasColumnName("serviceleveldescription")
                    .HasMaxLength(100);

                entity.Property(e => e.Servicetype)
                    .HasColumnName("servicetype")
                    .HasMaxLength(16);

                entity.Property(e => e.Shipfromcode)
                    .IsRequired()
                    .HasColumnName("shipfromcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shipfromname)
                    .IsRequired()
                    .HasColumnName("shipfromname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipfromtype)
                    .HasColumnName("shipfromtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Shipmentlegid)
                    .HasColumnName("shipmentlegid")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipmentloadid)
                    .HasColumnName("shipmentloadid")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipmentmemo)
                    .HasColumnName("shipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentnumber)
                    .HasColumnName("shipmentnumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipmentprocessdatetime)
                    .HasColumnName("shipmentprocessdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Shiptocode)
                    .IsRequired()
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptoname)
                    .IsRequired()
                    .HasColumnName("shiptoname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shiptospecialcond)
                    .HasColumnName("shiptospecialcond")
                    .HasMaxLength(100);

                entity.Property(e => e.Shiptotelephone)
                    .HasColumnName("shiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptotype)
                    .HasColumnName("shiptotype")
                    .HasMaxLength(10);

                entity.Property(e => e.SoIdocno)
                    .HasColumnName("so_idocno")
                    .HasMaxLength(16);

                entity.Property(e => e.Soldtoregion)
                    .HasColumnName("soldtoregion")
                    .HasMaxLength(4);

                entity.Property(e => e.Soldtotelephone)
                    .HasColumnName("soldtotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Specialordertype)
                    .HasColumnName("specialordertype")
                    .HasMaxLength(120);

                entity.Property(e => e.Spotrate)
                    .HasColumnName("spotrate")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Spotunit)
                    .HasColumnName("spotunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.Systembatchno)
                    .HasColumnName("systembatchno")
                    .HasMaxLength(25);

                entity.Property(e => e.Trailerlicenseno)
                    .HasColumnName("trailerlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Transportmode)
                    .HasColumnName("transportmode")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypeid)
                    .HasColumnName("vehicletypeid")
                    .HasMaxLength(5);

                entity.Property(e => e.Vesselname)
                    .HasColumnName("vesselname")
                    .HasMaxLength(120);

                entity.Property(e => e.Warehouseloccode)
                    .HasColumnName("warehouseloccode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordDeliveryHeaderCharge>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Deliverytype, e.Chargetype })
                    .HasName("omsord_delivery_header_charge_pkey");

                entity.ToTable("omsord_delivery_header_charge", "dom");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Chargetype)
                    .HasColumnName("chargetype")
                    .HasMaxLength(50);

                entity.Property(e => e.Applyapoption)
                    .HasColumnName("applyapoption")
                    .HasMaxLength(255);

                entity.Property(e => e.Chargeamount)
                    .HasColumnName("chargeamount")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Chargeunit)
                    .HasColumnName("chargeunit")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordDeliveryHeaderServiceOptions>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Deliverytype, e.Serviceitemid })
                    .HasName("omsord_delivery_header_service_options_pkey");

                entity.ToTable("omsord_delivery_header_service_options", "dom");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Serviceitemid).HasColumnName("serviceitemid");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Otherdescription)
                    .HasColumnName("otherdescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Serviceitemname)
                    .HasColumnName("serviceitemname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordDeliveryItems>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Dnitem, e.Legid, e.Deliverytype })
                    .HasName("omsord_delivery_items_pkey");

                entity.ToTable("omsord_delivery_items", "dom");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customermaterialcode)
                    .HasColumnName("customermaterialcode")
                    .HasMaxLength(100);

                entity.Property(e => e.Customermaterialname)
                    .HasColumnName("customermaterialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Gicompleteddatetime)
                    .HasColumnName("gicompleteddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Giflag).HasColumnName("giflag");

                entity.Property(e => e.Giquantity)
                    .HasColumnName("giquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Grcompleteddatetime)
                    .HasColumnName("grcompleteddatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Grflag).HasColumnName("grflag");

                entity.Property(e => e.Grquantity)
                    .HasColumnName("grquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Legheader)
                    .IsRequired()
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialname)
                    .HasColumnName("materialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialpricingunit)
                    .HasColumnName("materialpricingunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Packedquantity)
                    .HasColumnName("packedquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Palletid)
                    .HasColumnName("palletid")
                    .HasMaxLength(100);

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Refplant)
                    .HasColumnName("refplant")
                    .HasMaxLength(4);

                entity.Property(e => e.Refshippingpoint)
                    .HasColumnName("refshippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Requestpalletflag).HasColumnName("requestpalletflag");

                entity.Property(e => e.Shippingmark)
                    .HasColumnName("shippingmark")
                    .HasMaxLength(50);

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordDeliveryItemsGoodIssue>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid, e.Deliverytype })
                    .HasName("omsord_delivery_items_good_issue_pkey");

                entity.ToTable("omsord_delivery_items_good_issue", "dom");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Breakitemquantity)
                    .HasColumnName("breakitemquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Completedflag).HasColumnName("completedflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Gooditemquantity)
                    .HasColumnName("gooditemquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Issuedatetime)
                    .IsRequired()
                    .HasColumnName("issuedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Missitemquantity)
                    .HasColumnName("missitemquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(500);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Stampdatetime)
                    .IsRequired()
                    .HasColumnName("stampdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordDeliveryItemsGoodReceive>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid, e.Deliverytype })
                    .HasName("omsord_delivery_items_good_receive_pkey");

                entity.ToTable("omsord_delivery_items_good_receive", "dom");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Breakitemquantity)
                    .HasColumnName("breakitemquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Completedflag).HasColumnName("completedflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Gooditemquantity)
                    .HasColumnName("gooditemquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Issuedatetime)
                    .IsRequired()
                    .HasColumnName("issuedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Missitemquantity)
                    .HasColumnName("missitemquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(500);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Stampdatetime)
                    .IsRequired()
                    .HasColumnName("stampdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordDeliveryItemsPacked>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid, e.Deliverytype, e.Materialcode })
                    .HasName("omsord_delivery_items_packed_pkey");

                entity.ToTable("omsord_delivery_items_packed", "dom");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Completedflag).HasColumnName("completedflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

                entity.Property(e => e.Issuedatetime)
                    .IsRequired()
                    .HasColumnName("issuedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(500);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Stampdatetime)
                    .IsRequired()
                    .HasColumnName("stampdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordDeliveryItemsPackedMapping>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid, e.Deliverytype, e.Materialcode })
                    .HasName("omsord_delivery_items_packed_mapping_pkey");

                entity.ToTable("omsord_delivery_items_packed_mapping", "dom");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Refmaterialcode)
                    .IsRequired()
                    .HasColumnName("refmaterialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Stampdatetime)
                    .IsRequired()
                    .HasColumnName("stampdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordDeliveryItemsPicked>(entity =>
            {
                entity.HasKey(e => new { e.Refdnnumber, e.Dnitem, e.Legid, e.Deliverytype })
                    .HasName("omsord_delivery_items_picked_pkey");

                entity.ToTable("omsord_delivery_items_picked", "dom");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Dnitem).HasColumnName("dnitem");

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Issuedatetime)
                    .IsRequired()
                    .HasColumnName("issuedatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(1000);

                entity.Property(e => e.Receivedflag).HasColumnName("receivedflag");

                entity.Property(e => e.Soitemnumber).HasColumnName("soitemnumber");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Stampdatetime)
                    .IsRequired()
                    .HasColumnName("stampdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("transactionid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordDeliverySapCharge>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Chargetype })
                    .HasName("omsord_delivery_sap_charge_pkey");

                entity.ToTable("omsord_delivery_sap_charge", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_delivery_sap_charge_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Chargetype)
                    .HasColumnName("chargetype")
                    .HasMaxLength(50);

                entity.Property(e => e.Applyapoption)
                    .HasColumnName("applyapoption")
                    .HasMaxLength(255);

                entity.Property(e => e.Chargeamount)
                    .HasColumnName("chargeamount")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Chargeunit)
                    .HasColumnName("chargeunit")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordDeliverySapHeader>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Legid })
                    .HasName("omsord_delivery_sap_header_pkey");

                entity.ToTable("omsord_delivery_sap_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_delivery_sap_header_dms_rep_dtt_idx");

                entity.HasIndex(e => e.Refdnnumber)
                    .HasName("index_ref")
                    .ForNpgsqlHasOperators(new[] { "varchar_ops" });

                entity.HasIndex(e => e.Sonumber)
                    .HasName("index_so")
                    .ForNpgsqlHasOperators(new[] { "varchar_ops" });

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Batchupdateddate)
                    .HasColumnName("batchupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Biglot).HasColumnName("biglot");

                entity.Property(e => e.Cancelflag).HasColumnName("cancelflag");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(32);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customername)
                    .HasColumnName("customername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Deliveredfromdate)
                    .IsRequired()
                    .HasColumnName("deliveredfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliveredtodate)
                    .IsRequired()
                    .HasColumnName("deliveredtodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationcode)
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationlocationtype)
                    .HasColumnName("destinationlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Driverlicenseno)
                    .HasColumnName("driverlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Equipmenttype)
                    .HasColumnName("equipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Incotermcode)
                    .HasColumnName("incotermcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Incotermdescription)
                    .HasColumnName("incotermdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Iscreatedshipment).HasColumnName("iscreatedshipment");

                entity.Property(e => e.Isexecuteinjobschedule).HasColumnName("isexecuteinjobschedule");

                entity.Property(e => e.Islastmile).HasColumnName("islastmile");

                entity.Property(e => e.Isoverwritecharge).HasColumnName("isoverwritecharge");

                entity.Property(e => e.Isoverwritethoughpoint).HasColumnName("isoverwritethoughpoint");

                entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

                entity.Property(e => e.Isrecievefromsap).HasColumnName("isrecievefromsap");

                entity.Property(e => e.Issenttosap).HasColumnName("issenttosap");

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Mergeintransitcode)
                    .HasColumnName("mergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Newdeliverydatefrom)
                    .HasColumnName("newdeliverydatefrom")
                    .HasMaxLength(37);

                entity.Property(e => e.Newdeliverydateto)
                    .HasColumnName("newdeliverydateto")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsposervice)
                    .HasColumnName("omsposervice")
                    .HasMaxLength(50);

                entity.Property(e => e.Orderdate)
                    .IsRequired()
                    .HasColumnName("orderdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdoctype)
                    .HasColumnName("orderdoctype")
                    .HasMaxLength(10);

                entity.Property(e => e.Orderscheduleline)
                    .HasColumnName("orderscheduleline")
                    .HasMaxLength(3);

                entity.Property(e => e.Origincode)
                    .HasColumnName("origincode")
                    .HasMaxLength(10);

                entity.Property(e => e.Originlocationtype)
                    .HasColumnName("originlocationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Outsource)
                    .HasColumnName("outsource")
                    .HasMaxLength(100);

                entity.Property(e => e.Pickedupfromdate)
                    .IsRequired()
                    .HasColumnName("pickedupfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pickeduptodate)
                    .IsRequired()
                    .HasColumnName("pickeduptodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Planeddeliverydate)
                    .IsRequired()
                    .HasColumnName("planeddeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("ponumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Requestdncount).HasColumnName("requestdncount");

                entity.Property(e => e.Requesteddate)
                    .IsRequired()
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Requirepalletflag).HasColumnName("requirepalletflag");

                entity.Property(e => e.Retryno).HasColumnName("retryno");

                entity.Property(e => e.Returnflag).HasColumnName("returnflag");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Saperrormessage)
                    .HasColumnName("saperrormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Saproute)
                    .HasColumnName("saproute")
                    .HasMaxLength(6);

                entity.Property(e => e.Sapshippingpoint)
                    .HasColumnName("sapshippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapshippingpointdescription)
                    .HasColumnName("sapshippingpointdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Sapshiptocode)
                    .HasColumnName("sapshiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Sapshiptoname)
                    .HasColumnName("sapshiptoname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Servicelevel)
                    .HasColumnName("servicelevel")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceleveldescription)
                    .HasColumnName("serviceleveldescription")
                    .HasMaxLength(100);

                entity.Property(e => e.Servicetype)
                    .HasColumnName("servicetype")
                    .HasMaxLength(16);

                entity.Property(e => e.Shipmenterrormessage)
                    .HasColumnName("shipmenterrormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentloadid)
                    .HasColumnName("shipmentloadid")
                    .HasMaxLength(50);

                entity.Property(e => e.Shipmentmemo)
                    .HasColumnName("shipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shipmentprocessdatetime)
                    .HasColumnName("shipmentprocessdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Shiptoaddress)
                    .HasColumnName("shiptoaddress")
                    .HasMaxLength(200);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(150);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptomobile)
                    .HasColumnName("shiptomobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Shiptopostalcode)
                    .HasColumnName("shiptopostalcode")
                    .HasMaxLength(150);

                entity.Property(e => e.Shiptorecipientname)
                    .HasColumnName("shiptorecipientname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregioncode)
                    .HasColumnName("shiptoregioncode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregionname)
                    .HasColumnName("shiptoregionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptospecialcondition)
                    .HasColumnName("shiptospecialcondition")
                    .HasMaxLength(100);

                entity.Property(e => e.Shiptotelephone)
                    .HasColumnName("shiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Sourcesystem)
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(20);

                entity.Property(e => e.Specialordertype)
                    .HasColumnName("specialordertype")
                    .HasMaxLength(120);

                entity.Property(e => e.Spotrate)
                    .HasColumnName("spotrate")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Spotunit)
                    .HasColumnName("spotunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.Stocktypecode).HasColumnName("stocktypecode");

                entity.Property(e => e.Stocktypedesc)
                    .HasColumnName("stocktypedesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Systembatchno)
                    .HasColumnName("systembatchno")
                    .HasMaxLength(50);

                entity.Property(e => e.Trailerlicenseno)
                    .HasColumnName("trailerlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Transportmode)
                    .HasColumnName("transportmode")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypeid)
                    .HasColumnName("vehicletypeid")
                    .HasMaxLength(5);

                entity.Property(e => e.Vesselname)
                    .HasColumnName("vesselname")
                    .HasMaxLength(120);

                entity.Property(e => e.Warehouseloccode)
                    .HasColumnName("warehouseloccode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordDeliverySapItem>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Dnitem, e.Legid })
                    .HasName("omsord_delivery_sap_item_pkey");

                entity.ToTable("omsord_delivery_sap_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_delivery_sap_item_dms_rep_dtt_idx");

                entity.HasIndex(e => e.Refdnnumber)
                    .HasName("omsord_delivery_sap_item_refdnnumber_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Dnitem)
                    .HasColumnName("dnitem")
                    .HasMaxLength(3);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Cancelflag).HasColumnName("cancelflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Deliveryquantity)
                    .HasColumnName("deliveryquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isosaleunit)
                    .HasColumnName("isosaleunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Isovolumeunit)
                    .HasColumnName("isovolumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Isoweightunit)
                    .HasColumnName("isoweightunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Materialbaseunit)
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightdescription)
                    .HasColumnName("materialfreightdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Materialfreightgroup)
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialname)
                    .HasColumnName("materialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Materialpricingunit)
                    .HasColumnName("materialpricingunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Requestpalletflag).HasColumnName("requestpalletflag");

                entity.Property(e => e.Shippingcondition)
                    .HasColumnName("shippingcondition")
                    .HasMaxLength(2);

                entity.Property(e => e.Shippingconditiondescription)
                    .HasColumnName("shippingconditiondescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Shippingpoint)
                    .HasColumnName("shippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Shippingpointdescription)
                    .HasColumnName("shippingpointdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Soitemnumber)
                    .IsRequired()
                    .HasColumnName("soitemnumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeperunit)
                    .HasColumnName("volumeperunit")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Volumeperunitccm)
                    .HasColumnName("volumeperunitccm")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightperunit)
                    .HasColumnName("weightperunit")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Weightperunitkg)
                    .HasColumnName("weightperunitkg")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordDeliveryThoughpoint>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Sequence, e.Locationcode })
                    .HasName("omsord_delivery_thoughpoint_pkey");

                entity.ToTable("omsord_delivery_thoughpoint", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_delivery_thoughpoint_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Legheader)
                    .IsRequired()
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.Locationtype)
                    .HasColumnName("locationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Refdnnumber)
                    .HasColumnName("refdnnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<OmsordDmsDeliverySapHeader>(entity =>
            {
                entity.HasKey(e => new { e.Dnnumber, e.Legid })
                    .HasName("omsord_dms_delivery_sap_header_pkey");

                entity.ToTable("omsord_dms_delivery_sap_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_dms_delivery_sap_header_dms_rep_dtt_idx");

                entity.Property(e => e.Dnnumber)
                    .HasColumnName("dnnumber")
                    .HasMaxLength(13);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Legheader)
                    .IsRequired()
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Orderscheduleline)
                    .HasColumnName("orderscheduleline")
                    .HasMaxLength(3);

                entity.Property(e => e.Scheduledatetime)
                    .HasColumnName("scheduledatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Serviceoption)
                    .HasColumnName("serviceoption")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<OmsordDmsOmsScheduleLines>(entity =>
            {
                entity.HasKey(e => e.Schduid)
                    .HasName("omsord_dms_oms_schedule_lines_pkey");

                entity.ToTable("omsord_dms_oms_schedule_lines", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_dms_oms_schedule_lines_dms_rep_dtt_idx");

                entity.Property(e => e.Schduid)
                    .HasColumnName("schduid")
                    .HasMaxLength(13)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<OmsordDmsScheduleAddress>(entity =>
            {
                entity.HasKey(e => e.Orderno)
                    .HasName("omsord_dms_schedule_address_pkey");

                entity.ToTable("omsord_dms_schedule_address", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_dms_schedule_address_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Addressno)
                    .HasColumnName("addressno")
                    .HasMaxLength(60);

                entity.Property(e => e.Adjacentremark)
                    .HasColumnName("adjacentremark")
                    .HasMaxLength(255);

                entity.Property(e => e.Distfromsoi)
                    .HasColumnName("distfromsoi")
                    .HasMaxLength(10);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Receivername)
                    .HasColumnName("receivername")
                    .HasMaxLength(40);

                entity.Property(e => e.Receivertel)
                    .HasColumnName("receivertel")
                    .HasMaxLength(20);

                entity.Property(e => e.Soi)
                    .HasColumnName("soi")
                    .HasMaxLength(50);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(50);

                entity.Property(e => e.Unitdistance)
                    .HasColumnName("unitdistance")
                    .HasMaxLength(20);

                entity.Property(e => e.Usercreateby)
                    .HasColumnName("usercreateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Usercreatedate)
                    .IsRequired()
                    .HasColumnName("usercreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Userupdateby)
                    .HasColumnName("userupdateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Userupdatedate)
                    .HasColumnName("userupdatedate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordDmsScheduleHeader>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline })
                    .HasName("omsord_dms_schedule_header_pkey");

                entity.ToTable("omsord_dms_schedule_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_dms_schedule_header_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(3);

                entity.Property(e => e.Backorderflag).HasColumnName("backorderflag");

                entity.Property(e => e.Biglotorderflag).HasColumnName("biglotorderflag");

                entity.Property(e => e.Completeorderflag).HasColumnName("completeorderflag");

                entity.Property(e => e.Conflictdmstatus)
                    .HasColumnName("conflictdmstatus")
                    .HasMaxLength(1);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Omscreatedby)
                    .IsRequired()
                    .HasColumnName("omscreatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Omscreateddate)
                    .IsRequired()
                    .HasColumnName("omscreateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsshipmentmemo)
                    .HasColumnName("omsshipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Omsupdatedby)
                    .HasColumnName("omsupdatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Omsupdateddate)
                    .HasColumnName("omsupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pageflag)
                    .HasColumnName("pageflag")
                    .HasMaxLength(1);

                entity.Property(e => e.Schdudate)
                    .HasColumnName("schdudate")
                    .HasMaxLength(37);

                entity.Property(e => e.Schdudeliverycreatedate)
                    .HasColumnName("schdudeliverycreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Schdudeliveryqty)
                    .HasColumnName("schdudeliveryqty")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Schdugrossqty)
                    .HasColumnName("schdugrossqty")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Schduqty)
                    .HasColumnName("schduqty")
                    .HasColumnType("numeric(18,3)");
            });

            modelBuilder.Entity<OmsordDmsScheduleItem>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline, e.Itemno })
                    .HasName("omsord_dms_schedule_item_pkey");

                entity.ToTable("omsord_dms_schedule_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_dms_schedule_item_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(3);

                entity.Property(e => e.Itemno)
                    .HasColumnName("itemno")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Omscancelflag).HasColumnName("omscancelflag");

                entity.Property(e => e.Omssystemremark)
                    .HasColumnName("omssystemremark")
                    .HasMaxLength(150);

                entity.Property(e => e.Schduconfirmqty)
                    .HasColumnName("schduconfirmqty")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Schdudeliveryqty)
                    .HasColumnName("schdudeliveryqty")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Schdudeliveryweight)
                    .HasColumnName("schdudeliveryweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Schdugrossweight)
                    .HasColumnName("schdugrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Schduqty)
                    .HasColumnName("schduqty")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Schduweight)
                    .HasColumnName("schduweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Usercreatedby)
                    .IsRequired()
                    .HasColumnName("usercreatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Usercreateddate)
                    .IsRequired()
                    .HasColumnName("usercreateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Userupdatedby)
                    .HasColumnName("userupdatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Userupdateddate)
                    .HasColumnName("userupdateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordDmsServiceOption>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline, e.Serviceoptionseq, e.Serviceoptionname })
                    .HasName("omsord_dms_service_option_pkey");

                entity.ToTable("omsord_dms_service_option", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_dms_service_option_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(3);

                entity.Property(e => e.Serviceoptionseq).HasColumnName("serviceoptionseq");

                entity.Property(e => e.Serviceoptionname)
                    .HasColumnName("serviceoptionname")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Serviceoptionremark)
                    .HasColumnName("serviceoptionremark")
                    .HasMaxLength(40);

                entity.Property(e => e.Serviceoptionvalue)
                    .HasColumnName("serviceoptionvalue")
                    .HasMaxLength(40);

                entity.Property(e => e.Usercreateby)
                    .HasColumnName("usercreateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Usercreatedate)
                    .IsRequired()
                    .HasColumnName("usercreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Userupdateby)
                    .HasColumnName("userupdateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Userupdatedate)
                    .HasColumnName("userupdatedate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordEstTransportService>(entity =>
            {
                entity.ToTable("omsord_est_transport_service", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_est_transport_service_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Baseunit)
                    .HasColumnName("baseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fuelrate)
                    .HasColumnName("fuelrate")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Fueltype)
                    .HasColumnName("fueltype")
                    .HasMaxLength(10);

                entity.Property(e => e.Interfaceid)
                    .HasColumnName("interfaceid")
                    .HasMaxLength(40);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Pricebyweight)
                    .HasColumnName("pricebyweight")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Pricecaltype)
                    .HasColumnName("pricecaltype")
                    .HasMaxLength(20);

                entity.Property(e => e.Pricerate)
                    .HasColumnName("pricerate")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Remainprice)
                    .HasColumnName("remainprice")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Remainquantity)
                    .HasColumnName("remainquantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Serviceitemid).HasColumnName("serviceitemid");

                entity.Property(e => e.Serviceitemname)
                    .HasColumnName("serviceitemname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

                entity.Property(e => e.Servicetypename)
                    .HasColumnName("servicetypename")
                    .HasMaxLength(200);

                entity.Property(e => e.Soitemid).HasColumnName("soitemid");

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordExtraService>(entity =>
            {
                entity.ToTable("omsord_extra_service", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_extra_service_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Serviceitemid).HasColumnName("serviceitemid");

                entity.Property(e => e.Serviceitemname)
                    .HasColumnName("serviceitemname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

                entity.Property(e => e.Servicetypename)
                    .HasColumnName("servicetypename")
                    .HasMaxLength(200);

                entity.Property(e => e.Soitemid).HasColumnName("soitemid");

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordLegSplitting>(entity =>
            {
                entity.HasKey(e => new { e.Sonumber, e.Transportid, e.Legheader, e.Legid })
                    .HasName("omsord_leg_splitting_pkey");

                entity.ToTable("omsord_leg_splitting", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_leg_splitting_dms_rep_dtt_idx");

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.Legheader)
                    .HasColumnName("legheader")
                    .HasMaxLength(14);

                entity.Property(e => e.Legid).HasColumnName("legid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsUsed).HasColumnName("is_used");
            });

            modelBuilder.Entity<OmsordMasterAdapterTemplate>(entity =>
            {
                entity.ToTable("omsord_master_adapter_template", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_adapter_template_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .IsRequired()
                    .HasColumnName("createddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Customertypeid).HasColumnName("customertypeid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.FileDatarow).HasColumnName("file_datarow");

                entity.Property(e => e.FileHeaderfields)
                    .HasColumnName("file_headerfields")
                    .HasMaxLength(4000);

                entity.Property(e => e.FileHeaderrow).HasColumnName("file_headerrow");

                entity.Property(e => e.FileIsincludeheader).HasColumnName("file_isincludeheader");

                entity.Property(e => e.FileSheetname)
                    .HasColumnName("file_sheetname")
                    .HasMaxLength(200);

                entity.Property(e => e.FileTemplatefields)
                    .HasColumnName("file_templatefields")
                    .HasMaxLength(4000);

                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .HasMaxLength(200);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Istransformtosap).HasColumnName("istransformtosap");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Orderpatternid).HasColumnName("orderpatternid");

                entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

                entity.Property(e => e.Outsourceid).HasColumnName("outsourceid");

                entity.Property(e => e.Pricingmodelid).HasColumnName("pricingmodelid");

                entity.Property(e => e.Transportmodecode).HasColumnName("transportmodecode");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Warehouselocationcode).HasColumnName("warehouselocationcode");
            });

            modelBuilder.Entity<OmsordMasterAdapterTemplateCustomer>(entity =>
            {
                entity.HasKey(e => new { e.Adapterid, e.Customerid })
                    .HasName("omsord_master_adapter_template_customer_pkey");

                entity.ToTable("omsord_master_adapter_template_customer", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_adapter_template_customer_dms_rep_dtt_idx");

                entity.Property(e => e.Adapterid).HasColumnName("adapterid");

                entity.Property(e => e.Customerid)
                    .HasColumnName("customerid")
                    .HasMaxLength(40);

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasMaxLength(200);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterAmphur>(entity =>
            {
                entity.HasKey(e => e.Amphurcode)
                    .HasName("omsord_master_amphur_pkey");

                entity.ToTable("omsord_master_amphur", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_amphur_dms_rep_dtt_idx");

                entity.Property(e => e.Amphurcode)
                    .HasColumnName("amphurcode")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurname)
                    .IsRequired()
                    .HasColumnName("amphurname")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Provincecode)
                    .IsRequired()
                    .HasColumnName("provincecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Sapcode)
                    .HasColumnName("sapcode")
                    .HasMaxLength(24);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterApplyApOption>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_apply_ap_option_pkey");

                entity.ToTable("omsord_master_apply_ap_option", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_apply_ap_option_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<OmsordMasterArPostingStatus>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_ar_posting_status_pkey");

                entity.ToTable("omsord_master_ar_posting_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_ar_posting_status_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordMasterBatchStatus>(entity =>
            {
                entity.HasKey(e => new { e.Batchtypecode, e.Statuscode })
                    .HasName("omsord_master_batch_status_pkey");

                entity.ToTable("omsord_master_batch_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_batch_status_dms_rep_dtt_idx");

                entity.Property(e => e.Batchtypecode)
                    .HasColumnName("batchtypecode")
                    .HasMaxLength(10);

                entity.Property(e => e.Statuscode)
                    .HasColumnName("statuscode")
                    .HasMaxLength(1);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(100);

                entity.Property(e => e.Statusdescription)
                    .IsRequired()
                    .HasColumnName("statusdescription")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<OmsordMasterBatchType>(entity =>
            {
                entity.HasKey(e => e.Batchtypecode)
                    .HasName("omsord_master_batch_type_pkey");

                entity.ToTable("omsord_master_batch_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_batch_type_dms_rep_dtt_idx");

                entity.Property(e => e.Batchtypecode)
                    .HasColumnName("batchtypecode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Batchtypename)
                    .IsRequired()
                    .HasColumnName("batchtypename")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Inactiveflag).HasColumnName("inactiveflag");
            });

            modelBuilder.Entity<OmsordMasterBigLot>(entity =>
            {
                entity.HasKey(e => e.RegionCode)
                    .HasName("omsord_master_big_lot_pkey");

                entity.ToTable("omsord_master_big_lot", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_big_lot_dms_rep_dtt_idx");

                entity.Property(e => e.RegionCode)
                    .HasColumnName("region_code")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.WeightUnit)
                    .HasColumnName("weight_unit")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<OmsordMasterBillForm>(entity =>
            {
                entity.ToTable("omsord_master_bill_form", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_bill_form_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Transportmode)
                    .IsRequired()
                    .HasColumnName("transportmode")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<OmsordMasterBillFormColumn>(entity =>
            {
                entity.HasKey(e => e.Fieldname)
                    .HasName("omsord_master_bill_form_column_pkey");

                entity.ToTable("omsord_master_bill_form_column", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_bill_form_column_dms_rep_dtt_idx");

                entity.Property(e => e.Fieldname)
                    .HasColumnName("fieldname")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Columnnameen)
                    .HasColumnName("columnnameen")
                    .HasMaxLength(100);

                entity.Property(e => e.Columnnameth)
                    .IsRequired()
                    .HasColumnName("columnnameth")
                    .HasMaxLength(100);

                entity.Property(e => e.Columnstyle)
                    .HasColumnName("columnstyle")
                    .HasMaxLength(400);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isformatnumber).HasColumnName("isformatnumber");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<OmsordMasterBillingStatus>(entity =>
            {
                entity.ToTable("omsord_master_billing_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_billing_status_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterCharge>(entity =>
            {
                entity.HasKey(e => e.Chargecode)
                    .HasName("omsord_master_charge_pkey");

                entity.ToTable("omsord_master_charge", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_charge_dms_rep_dtt_idx");

                entity.Property(e => e.Chargecode)
                    .HasColumnName("chargecode")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Chargename)
                    .HasColumnName("chargename")
                    .HasMaxLength(280);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Lastupdateddate)
                    .IsRequired()
                    .HasColumnName("lastupdateddate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterChargeType>(entity =>
            {
                entity.HasKey(e => e.Chargetype)
                    .HasName("omsord_master_charge_type_pkey");

                entity.ToTable("omsord_master_charge_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_charge_type_dms_rep_dtt_idx");

                entity.Property(e => e.Chargetype)
                    .HasColumnName("chargetype")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Chargedescription)
                    .HasColumnName("chargedescription")
                    .HasMaxLength(500);

                entity.Property(e => e.Chargeunit)
                    .HasColumnName("chargeunit")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterCustomerMaterial>(entity =>
            {
                entity.ToTable("omsord_master_customer_material", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_customer_material_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.Customermaterialcode)
                    .IsRequired()
                    .HasColumnName("customermaterialcode")
                    .HasMaxLength(100);

                entity.Property(e => e.Customermaterialname)
                    .IsRequired()
                    .HasColumnName("customermaterialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Sapmaterialcode)
                    .HasColumnName("sapmaterialcode")
                    .HasMaxLength(72);

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterCustomerProfile>(entity =>
            {
                entity.HasKey(e => e.Customercode)
                    .HasName("omsord_master_customer_profile_pkey");

                entity.ToTable("omsord_master_customer_profile", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_customer_profile_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.Billendofmonth).HasColumnName("billendofmonth");

                entity.Property(e => e.Billformconsol).HasColumnName("billformconsol");

                entity.Property(e => e.Billformftl).HasColumnName("billformftl");

                entity.Property(e => e.Billgrouptype)
                    .IsRequired()
                    .HasColumnName("billgrouptype")
                    .HasMaxLength(10);

                entity.Property(e => e.Billperiod)
                    .HasColumnName("billperiod")
                    .HasMaxLength(100);

                entity.Property(e => e.Businessgroupid).HasColumnName("businessgroupid");

                entity.Property(e => e.Channelid).HasColumnName("channelid");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(140);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(140);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Extrashipcond)
                    .HasColumnName("extrashipcond")
                    .HasMaxLength(1000);

                entity.Property(e => e.Isautosplit).HasColumnName("isautosplit");

                entity.Property(e => e.Isbilling).HasColumnName("isbilling");

                entity.Property(e => e.Iscalpricing).HasColumnName("iscalpricing");

                entity.Property(e => e.Iscalrequesteddate).HasColumnName("iscalrequesteddate");

                entity.Property(e => e.Ischeckcredit).HasColumnName("ischeckcredit");

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(10);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(40);

                entity.Property(e => e.Pricingdate).HasColumnName("pricingdate");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sapname1)
                    .HasColumnName("sapname1")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname2)
                    .HasColumnName("sapname2")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname3)
                    .HasColumnName("sapname3")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname4)
                    .HasColumnName("sapname4")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapregion)
                    .HasColumnName("sapregion")
                    .HasMaxLength(12);

                entity.Property(e => e.Saptaxid)
                    .HasColumnName("saptaxid")
                    .HasMaxLength(64);

                entity.Property(e => e.Saptranszone)
                    .HasColumnName("saptranszone")
                    .HasMaxLength(40);

                entity.Property(e => e.Shortname)
                    .HasColumnName("shortname")
                    .HasMaxLength(20);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(140);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Weightperschedule)
                    .HasColumnName("weightperschedule")
                    .HasColumnType("numeric(13,3)");
            });

            modelBuilder.Entity<OmsordMasterCustomerService>(entity =>
            {
                entity.HasKey(e => e.Customercode)
                    .HasName("omsord_master_customer_service_pkey");

                entity.ToTable("omsord_master_customer_service", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_customer_service_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsExpressservice).HasColumnName("is_expressservice");

                entity.Property(e => e.IsLeadtimeservice).HasColumnName("is_leadtimeservice");

                entity.Property(e => e.IsWindowservice).HasColumnName("is_windowservice");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterDistrict>(entity =>
            {
                entity.HasKey(e => e.Districtcode)
                    .HasName("omsord_master_district_pkey");

                entity.ToTable("omsord_master_district", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_district_dms_rep_dtt_idx");

                entity.Property(e => e.Districtcode)
                    .HasColumnName("districtcode")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurcode)
                    .IsRequired()
                    .HasColumnName("amphurcode")
                    .HasMaxLength(4);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Districtname)
                    .IsRequired()
                    .HasColumnName("districtname")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterDnStatus>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_dn_status_pkey");

                entity.ToTable("omsord_master_dn_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_dn_status_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordMasterEndCustomer>(entity =>
            {
                entity.ToTable("omsord_master_end_customer", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_end_customer_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Endcustomercode)
                    .IsRequired()
                    .HasColumnName("endcustomercode")
                    .HasMaxLength(100);

                entity.Property(e => e.Endcustomername)
                    .IsRequired()
                    .HasColumnName("endcustomername")
                    .HasMaxLength(1000);

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Lono)
                    .HasColumnName("lono")
                    .HasMaxLength(256);

                entity.Property(e => e.Sapshiptocode)
                    .HasColumnName("sapshiptocode")
                    .HasMaxLength(40);

                entity.Property(e => e.Sapshiptotype)
                    .HasColumnName("sapshiptotype")
                    .HasMaxLength(1);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterHoliday>(entity =>
            {
                entity.HasKey(e => e.Holidayid)
                    .HasName("omsord_master_holiday_pkey");

                entity.ToTable("omsord_master_holiday", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_holiday_dms_rep_dtt_idx");

                entity.Property(e => e.Holidayid)
                    .HasColumnName("holidayid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Holidaydate)
                    .IsRequired()
                    .HasColumnName("holidaydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Holidayname)
                    .HasColumnName("holidayname")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive).HasColumnName("is_active");
            });

            modelBuilder.Entity<OmsordMasterLocation>(entity =>
            {
                entity.HasKey(e => e.Locationcode)
                    .HasName("omsord_master_location_pkey");

                entity.ToTable("omsord_master_location", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_location_dms_rep_dtt_idx");

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurcode)
                    .HasColumnName("amphurcode")
                    .HasMaxLength(4);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Destinationflag).HasColumnName("destinationflag");

                entity.Property(e => e.Districtcode)
                    .HasColumnName("districtcode")
                    .HasMaxLength(6);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Houseno)
                    .HasColumnName("houseno")
                    .HasMaxLength(20);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("numeric(13,10)");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Locationtype).HasColumnName("locationtype");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("numeric(13,10)");

                entity.Property(e => e.Originflag).HasColumnName("originflag");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Provincecode)
                    .HasColumnName("provincecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Receipient)
                    .HasColumnName("receipient")
                    .HasMaxLength(50);

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.Saplocationcode)
                    .HasColumnName("saplocationcode")
                    .HasMaxLength(64);

                entity.Property(e => e.Sapshippingpoint)
                    .HasColumnName("sapshippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapshipto)
                    .HasColumnName("sapshipto")
                    .HasMaxLength(40);

                entity.Property(e => e.Soi)
                    .HasColumnName("soi")
                    .HasMaxLength(88);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(1000);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<OmsordMasterLocationPrefix>(entity =>
            {
                entity.HasKey(e => e.PrefixCode)
                    .HasName("omsord_master_location_prefix_pkey");

                entity.ToTable("omsord_master_location_prefix", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_location_prefix_dms_rep_dtt_idx");

                entity.Property(e => e.PrefixCode)
                    .HasColumnName("prefix_code")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.PrefixDesc)
                    .IsRequired()
                    .HasColumnName("prefix_desc")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<OmsordMasterLocationType>(entity =>
            {
                entity.HasKey(e => e.Locationtypeid)
                    .HasName("omsord_master_location_type_pkey");

                entity.ToTable("omsord_master_location_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_location_type_dms_rep_dtt_idx");

                entity.Property(e => e.Locationtypeid)
                    .HasColumnName("locationtypeid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Locationtypename)
                    .IsRequired()
                    .HasColumnName("locationtypename")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordMasterLogistic>(entity =>
            {
                entity.ToTable("omsord_master_logistic", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_logistic_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Logisticcode)
                    .IsRequired()
                    .HasColumnName("logisticcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Logisticname)
                    .IsRequired()
                    .HasColumnName("logisticname")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterMappingBillFormColumn>(entity =>
            {
                entity.HasKey(e => new { e.Formid, e.Fieldname })
                    .HasName("omsord_master_mapping_bill_form_column_pkey");

                entity.ToTable("omsord_master_mapping_bill_form_column", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_mapping_bill_form_column_dms_rep_dtt_idx");

                entity.Property(e => e.Formid).HasColumnName("formid");

                entity.Property(e => e.Fieldname)
                    .HasColumnName("fieldname")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterMaterial>(entity =>
            {
                entity.HasKey(e => e.Materialcode)
                    .HasName("omsord_master_material_pkey");

                entity.ToTable("omsord_master_material", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_material_dms_rep_dtt_idx");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Baseunit)
                    .IsRequired()
                    .HasColumnName("baseunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Bomflag).HasColumnName("bomflag");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Dimensionunit)
                    .HasColumnName("dimensionunit")
                    .HasMaxLength(12);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Eancode)
                    .HasColumnName("eancode")
                    .HasMaxLength(128);

                entity.Property(e => e.Freeflag).HasColumnName("freeflag");

                entity.Property(e => e.Grossweight)
                    .HasColumnName("grossweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialname)
                    .HasColumnName("materialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Materialshortname)
                    .HasColumnName("materialshortname")
                    .HasMaxLength(100);

                entity.Property(e => e.Netweight)
                    .HasColumnName("netweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Pricingunit)
                    .HasColumnName("pricingunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Productgroupid).HasColumnName("productgroupid");

                entity.Property(e => e.Sapmaterialcode)
                    .HasColumnName("sapmaterialcode")
                    .HasMaxLength(72);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicleflag).HasColumnName("vehicleflag");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Volumeunit)
                    .IsRequired()
                    .HasColumnName("volumeunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Volumeweight)
                    .HasColumnName("volumeweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Weightunit)
                    .IsRequired()
                    .HasColumnName("weightunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("numeric(15,3)");
            });

            modelBuilder.Entity<OmsordMasterMaterialBom>(entity =>
            {
                entity.HasKey(e => new { e.Materialcode, e.Bomno })
                    .HasName("omsord_master_material_bom_pkey");

                entity.ToTable("omsord_master_material_bom", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_material_bom_dms_rep_dtt_idx");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Bomno).HasColumnName("bomno");

                entity.Property(e => e.Childmatcode)
                    .HasColumnName("childmatcode")
                    .HasMaxLength(12);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(12);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterMaterialUnitConv>(entity =>
            {
                entity.HasKey(e => new { e.Materialcode, e.Alterunit })
                    .HasName("omsord_master_material_unit_conv_pkey");

                entity.ToTable("omsord_master_material_unit_conv", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_material_unit_conv_dms_rep_dtt_idx");

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Alterunit)
                    .HasColumnName("alterunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Denumerator).HasColumnName("denumerator");

                entity.Property(e => e.Dimensionunit)
                    .HasColumnName("dimensionunit")
                    .HasMaxLength(12);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Numerator).HasColumnName("numerator");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Volumeweight)
                    .HasColumnName("volumeweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("numeric(15,3)");
            });

            modelBuilder.Entity<OmsordMasterOrderPattern>(entity =>
            {
                entity.ToTable("omsord_master_order_pattern", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_order_pattern_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Includeoutsource).HasColumnName("includeoutsource");

                entity.Property(e => e.Interfacecode)
                    .HasColumnName("interfacecode")
                    .HasMaxLength(20);

                entity.Property(e => e.Istransport).HasColumnName("istransport");

                entity.Property(e => e.Iswarehouse).HasColumnName("iswarehouse");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Stocktypeid).HasColumnName("stocktypeid");
            });

            modelBuilder.Entity<OmsordMasterOrderScheduleStatus>(entity =>
            {
                entity.ToTable("omsord_master_order_schedule_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_order_schedule_status_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterOrderStatus>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_order_status_pkey");

                entity.ToTable("omsord_master_order_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_order_status_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordMasterOriginLocation>(entity =>
            {
                entity.HasKey(e => new { e.Locationcode, e.Customercode })
                    .HasName("omsord_master_origin_location_pkey");

                entity.ToTable("omsord_master_origin_location", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_origin_location_dms_rep_dtt_idx");

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sapshippingpointcode)
                    .HasColumnName("sapshippingpointcode")
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<OmsordMasterOutsource>(entity =>
            {
                entity.ToTable("omsord_master_outsource", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_outsource_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Istransport).HasColumnName("istransport");

                entity.Property(e => e.Iswarehouse).HasColumnName("iswarehouse");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterPricingDate>(entity =>
            {
                entity.ToTable("omsord_master_pricing_date", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_pricing_date_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Interfacecode)
                    .HasColumnName("interfacecode")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterPricingModel>(entity =>
            {
                entity.ToTable("omsord_master_pricing_model", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_pricing_model_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Interfacecode)
                    .HasColumnName("interfacecode")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterProvince>(entity =>
            {
                entity.HasKey(e => e.Provincecode)
                    .HasName("omsord_master_province_pkey");

                entity.ToTable("omsord_master_province", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_province_dms_rep_dtt_idx");

                entity.Property(e => e.Provincecode)
                    .HasColumnName("provincecode")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Provincename)
                    .IsRequired()
                    .HasColumnName("provincename")
                    .HasMaxLength(100);

                entity.Property(e => e.Regioncode).HasColumnName("regioncode");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterRegion>(entity =>
            {
                entity.HasKey(e => e.Regioncode)
                    .HasName("omsord_master_region_pkey");

                entity.ToTable("omsord_master_region", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_region_dms_rep_dtt_idx");

                entity.Property(e => e.Regioncode)
                    .HasColumnName("regioncode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Regionname)
                    .HasColumnName("regionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Sapcode)
                    .HasColumnName("sapcode")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<OmsordMasterReturnReason>(entity =>
            {
                entity.ToTable("omsord_master_return_reason", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_return_reason_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterReworkReason>(entity =>
            {
                entity.ToTable("omsord_master_rework_reason", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_rework_reason_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterRoute>(entity =>
            {
                entity.ToTable("omsord_master_route", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_route_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Destlocid)
                    .IsRequired()
                    .HasColumnName("destlocid")
                    .HasMaxLength(10);

                entity.Property(e => e.Destloctype).HasColumnName("destloctype");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Hublocid)
                    .HasColumnName("hublocid")
                    .HasMaxLength(10);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Originlocid)
                    .IsRequired()
                    .HasColumnName("originlocid")
                    .HasMaxLength(10);

                entity.Property(e => e.Originloctype).HasColumnName("originloctype");

                entity.Property(e => e.Percentftlweight)
                    .HasColumnName("percentftlweight")
                    .HasColumnType("numeric(8,3)");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Routemodel)
                    .IsRequired()
                    .HasColumnName("routemodel")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterRouteSap>(entity =>
            {
                entity.HasKey(e => e.Routecode)
                    .HasName("omsord_master_route_sap_pkey");

                entity.ToTable("omsord_master_route_sap", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_route_sap_dms_rep_dtt_idx");

                entity.Property(e => e.Routecode)
                    .HasColumnName("routecode")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Destinationcode)
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Originlocationcode)
                    .HasColumnName("originlocationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Routedescription)
                    .HasColumnName("routedescription")
                    .HasMaxLength(100);

                entity.Property(e => e.Thoughtpointlocationcode)
                    .HasColumnName("thoughtpointlocationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Transittime).HasColumnName("transittime");
            });

            modelBuilder.Entity<OmsordMasterSapAmphur>(entity =>
            {
                entity.HasKey(e => e.Amphurcode)
                    .HasName("omsord_master_sap_amphur_pkey");

                entity.ToTable("omsord_master_sap_amphur", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_amphur_dms_rep_dtt_idx");

                entity.Property(e => e.Amphurcode)
                    .HasColumnName("amphurcode")
                    .HasMaxLength(28)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurname)
                    .HasColumnName("amphurname")
                    .HasMaxLength(140);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterSapCarrier>(entity =>
            {
                entity.HasKey(e => e.Carriercode)
                    .HasName("omsord_master_sap_carrier_pkey");

                entity.ToTable("omsord_master_sap_carrier", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_carrier_dms_rep_dtt_idx");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carriername)
                    .HasColumnName("carriername")
                    .HasMaxLength(280);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterSapMatFreightGroup>(entity =>
            {
                entity.HasKey(e => e.Matfrtgrpcode)
                    .HasName("omsord_master_sap_mat_freight_group_pkey");

                entity.ToTable("omsord_master_sap_mat_freight_group", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_mat_freight_group_dms_rep_dtt_idx");

                entity.Property(e => e.Matfrtgrpcode)
                    .HasColumnName("matfrtgrpcode")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Matfrtgrpdesc)
                    .HasColumnName("matfrtgrpdesc")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordMasterSapOrderSegment>(entity =>
            {
                entity.HasKey(e => e.Segmenttype)
                    .HasName("omsord_master_sap_order_segment_pkey");

                entity.ToTable("omsord_master_sap_order_segment", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_order_segment_dms_rep_dtt_idx");

                entity.Property(e => e.Segmenttype)
                    .HasColumnName("segmenttype")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Itineraryflag).HasColumnName("itineraryflag");

                entity.Property(e => e.Segmentdesc)
                    .HasColumnName("segmentdesc")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterSapOrderSegmentMapping>(entity =>
            {
                entity.HasKey(e => new { e.Matfreightgroupcode, e.Shippingpointcode })
                    .HasName("omsord_master_sap_order_segment_mapping_pkey");

                entity.ToTable("omsord_master_sap_order_segment_mapping", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_order_segment_mapping_dms_rep_dtt_idx");

                entity.Property(e => e.Matfreightgroupcode)
                    .HasColumnName("matfreightgroupcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shippingpointcode)
                    .HasColumnName("shippingpointcode")
                    .HasMaxLength(4);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Segmenttype)
                    .IsRequired()
                    .HasColumnName("segmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterSapProvince>(entity =>
            {
                entity.HasKey(e => e.Provincecode)
                    .HasName("omsord_master_sap_province_pkey");

                entity.ToTable("omsord_master_sap_province", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_province_dms_rep_dtt_idx");

                entity.Property(e => e.Provincecode)
                    .HasColumnName("provincecode")
                    .HasMaxLength(24)
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Provincename)
                    .IsRequired()
                    .HasColumnName("provincename")
                    .HasMaxLength(140);
            });

            modelBuilder.Entity<OmsordMasterSapRegion>(entity =>
            {
                entity.HasKey(e => e.Regioncode)
                    .HasName("omsord_master_sap_region_pkey");

                entity.ToTable("omsord_master_sap_region", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_region_dms_rep_dtt_idx");

                entity.Property(e => e.Regioncode)
                    .HasColumnName("regioncode")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Regionname)
                    .HasColumnName("regionname")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordMasterSapScgtShipto>(entity =>
            {
                entity.HasKey(e => e.Scgtshiptocode)
                    .HasName("omsord_master_sap_scgt_shipto_pkey");

                entity.ToTable("omsord_master_sap_scgt_shipto", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_scgt_shipto_dms_rep_dtt_idx");

                entity.Property(e => e.Scgtshiptocode)
                    .HasColumnName("scgtshiptocode")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Scgtshiptoname)
                    .HasColumnName("scgtshiptoname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OmsordMasterSapShippingpoint>(entity =>
            {
                entity.HasKey(e => new { e.Sapshippingpointcode, e.Systemid })
                    .HasName("omsord_master_sap_shippingpoint_pkey");

                entity.ToTable("omsord_master_sap_shippingpoint", "dom");

                entity.Property(e => e.Sapshippingpointcode)
                    .HasColumnName("sapshippingpointcode")
                    .HasMaxLength(16);

                entity.Property(e => e.Systemid).HasColumnName("systemid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sapshippingpointname)
                    .HasColumnName("sapshippingpointname")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<OmsordMasterSapShipto>(entity =>
            {
                entity.HasKey(e => e.Shiptocode)
                    .HasName("omsord_master_sap_shipto_pkey");

                entity.ToTable("omsord_master_sap_shipto", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_shipto_dms_rep_dtt_idx");

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(140);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(140);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(10);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(40);

                entity.Property(e => e.Sapname1)
                    .HasColumnName("sapname1")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname2)
                    .HasColumnName("sapname2")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname3)
                    .HasColumnName("sapname3")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapname4)
                    .HasColumnName("sapname4")
                    .HasMaxLength(140);

                entity.Property(e => e.Sapregion)
                    .HasColumnName("sapregion")
                    .HasMaxLength(12);

                entity.Property(e => e.Saptaxid)
                    .HasColumnName("saptaxid")
                    .HasMaxLength(64);

                entity.Property(e => e.Saptranszone)
                    .HasColumnName("saptranszone")
                    .HasMaxLength(40);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(140);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterSapShiptoAmphur>(entity =>
            {
                entity.HasKey(e => e.Shiptocode)
                    .HasName("omsord_master_sap_shipto_amphur_pkey");

                entity.ToTable("omsord_master_sap_shipto_amphur", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_shipto_amphur_dms_rep_dtt_idx");

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amphurcode)
                    .IsRequired()
                    .HasColumnName("amphurcode")
                    .HasMaxLength(28);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Provincecode)
                    .HasColumnName("provincecode")
                    .HasMaxLength(24);
            });

            modelBuilder.Entity<OmsordMasterSapSubRegion>(entity =>
            {
                entity.HasKey(e => new { e.Regioncode, e.Subregioncode })
                    .HasName("omsord_master_sap_sub_region_pkey");

                entity.ToTable("omsord_master_sap_sub_region", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_sub_region_dms_rep_dtt_idx");

                entity.Property(e => e.Regioncode)
                    .HasColumnName("regioncode")
                    .HasMaxLength(6);

                entity.Property(e => e.Subregioncode)
                    .HasColumnName("subregioncode")
                    .HasMaxLength(6);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Subregionname)
                    .HasColumnName("subregionname")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordMasterSapTransportZone>(entity =>
            {
                entity.HasKey(e => new { e.Subregioncode, e.Regioncode, e.Transportzonecode })
                    .HasName("omsord_master_sap_transport_zone_pkey");

                entity.ToTable("omsord_master_sap_transport_zone", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_sap_transport_zone_dms_rep_dtt_idx");

                entity.Property(e => e.Subregioncode)
                    .HasColumnName("subregioncode")
                    .HasMaxLength(6);

                entity.Property(e => e.Regioncode)
                    .HasColumnName("regioncode")
                    .HasMaxLength(6);

                entity.Property(e => e.Transportzonecode)
                    .HasColumnName("transportzonecode")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Transportzonedesc)
                    .HasColumnName("transportzonedesc")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<OmsordMasterService>(entity =>
            {
                entity.ToTable("omsord_master_service", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_service_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Dayprefercalculate)
                    .IsRequired()
                    .HasColumnName("dayprefercalculate")
                    .HasMaxLength(5);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Inittimecalculate)
                    .IsRequired()
                    .HasColumnName("inittimecalculate")
                    .HasMaxLength(16);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Limittimecalculate)
                    .IsRequired()
                    .HasColumnName("limittimecalculate")
                    .HasMaxLength(16);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Servicemodelid).HasColumnName("servicemodelid");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterServiceItem>(entity =>
            {
                entity.ToTable("omsord_master_service_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_service_item_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isrequired).HasColumnName("isrequired");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");
            });

            modelBuilder.Entity<OmsordMasterServiceItemType>(entity =>
            {
                entity.ToTable("omsord_master_service_item_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_service_item_type_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterServiceLevel>(entity =>
            {
                entity.ToTable("omsord_master_service_level", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_service_level_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(2);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(400);

                entity.Property(e => e.Shipmentversion)
                    .IsRequired()
                    .HasColumnName("shipmentversion")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<OmsordMasterServiceModel>(entity =>
            {
                entity.ToTable("omsord_master_service_model", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_service_model_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsValidatedimension).HasColumnName("is_validatedimension");

                entity.Property(e => e.IsValidatepostal).HasColumnName("is_validatepostal");

                entity.Property(e => e.IsValidateweight).HasColumnName("is_validateweight");

                entity.Property(e => e.Limitdimension)
                    .HasColumnName("limitdimension")
                    .HasColumnType("numeric(8,3)");

                entity.Property(e => e.Limitweight)
                    .HasColumnName("limitweight")
                    .HasColumnType("numeric(8,3)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Postalapi)
                    .HasColumnName("postalapi")
                    .HasMaxLength(500);

                entity.Property(e => e.Transportserviceid)
                    .IsRequired()
                    .HasColumnName("transportserviceid")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterServiceOptionMapping>(entity =>
            {
                entity.ToTable("omsord_master_service_option_mapping", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_service_option_mapping_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasColumnName("active_status");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SapFieldName)
                    .HasColumnName("sap_field_name")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceOptionName)
                    .HasColumnName("service_option_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordMasterShippingCond>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_shipping_cond_pkey");

                entity.ToTable("omsord_master_shipping_cond", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_shipping_cond_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordMasterSpecialOrderType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_special_order_type_pkey");

                entity.ToTable("omsord_master_special_order_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_special_order_type_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(120);
            });

            modelBuilder.Entity<OmsordMasterStdUnitConv>(entity =>
            {
                entity.HasKey(e => new { e.Baseunit, e.Alterunit })
                    .HasName("omsord_master_std_unit_conv_pkey");

                entity.ToTable("omsord_master_std_unit_conv", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_std_unit_conv_dms_rep_dtt_idx");

                entity.Property(e => e.Baseunit)
                    .HasColumnName("baseunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Alterunit)
                    .HasColumnName("alterunit")
                    .HasMaxLength(12);

                entity.Property(e => e.Alterquantity).HasColumnName("alterquantity");

                entity.Property(e => e.Basequantity).HasColumnName("basequantity");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterStockType>(entity =>
            {
                entity.ToTable("omsord_master_stock_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_stock_type_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterTmsEquipmentType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_tms_equipment_type_pkey");

                entity.ToTable("omsord_master_tms_equipment_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_tms_equipment_type_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(280);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterTmsEvent>(entity =>
            {
                entity.HasKey(e => e.Eventname)
                    .HasName("omsord_master_tms_event_pkey");

                entity.ToTable("omsord_master_tms_event", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_tms_event_dms_rep_dtt_idx");

                entity.Property(e => e.Eventname)
                    .HasColumnName("eventname")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isdelivery).HasColumnName("isdelivery");

                entity.Property(e => e.Isshipmentflag).HasColumnName("isshipmentflag");
            });

            modelBuilder.Entity<OmsordMasterTmsLoadStatus>(entity =>
            {
                entity.HasKey(e => e.Loadstatus)
                    .HasName("omsord_master_tms_load_status_pkey");

                entity.ToTable("omsord_master_tms_load_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_tms_load_status_dms_rep_dtt_idx");

                entity.Property(e => e.Loadstatus)
                    .HasColumnName("loadstatus")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Loaddescription)
                    .HasColumnName("loaddescription")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordMasterTmsSequence>(entity =>
            {
                entity.HasKey(e => e.Systemloadstatus)
                    .HasName("omsord_master_tms_sequence_pkey");

                entity.ToTable("omsord_master_tms_sequence", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_tms_sequence_dms_rep_dtt_idx");

                entity.Property(e => e.Systemloadstatus)
                    .HasColumnName("systemloadstatus")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<OmsordMasterTmsServiceType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_tms_service_type_pkey");

                entity.ToTable("omsord_master_tms_service_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_tms_service_type_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(280);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterTransport>(entity =>
            {
                entity.ToTable("omsord_master_transport", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_transport_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Cuttingtime)
                    .IsRequired()
                    .HasColumnName("cuttingtime")
                    .HasMaxLength(16);

                entity.Property(e => e.Destlocid)
                    .IsRequired()
                    .HasColumnName("destlocid")
                    .HasMaxLength(10);

                entity.Property(e => e.Destloctype).HasColumnName("destloctype");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Originlocid)
                    .IsRequired()
                    .HasColumnName("originlocid")
                    .HasMaxLength(10);

                entity.Property(e => e.Originloctype).HasColumnName("originloctype");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordMasterTransportMode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("omsord_master_transport_mode_pkey");

                entity.ToTable("omsord_master_transport_mode", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_transport_mode_dms_rep_dtt_idx");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordMasterTransportOrderType>(entity =>
            {
                entity.ToTable("omsord_master_transport_order_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_transport_order_type_dms_rep_dtt_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Billcode)
                    .HasColumnName("billcode")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Interfacecode)
                    .HasColumnName("interfacecode")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterUnit>(entity =>
            {
                entity.HasKey(e => e.Unitcode)
                    .HasName("omsord_master_unit_pkey");

                entity.ToTable("omsord_master_unit", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_unit_dms_rep_dtt_idx");

                entity.Property(e => e.Unitcode)
                    .HasColumnName("unitcode")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Decimalflag).HasColumnName("decimalflag");

                entity.Property(e => e.Dimensionunit).HasColumnName("dimensionunit");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isocode)
                    .HasColumnName("isocode")
                    .HasMaxLength(12);

                entity.Property(e => e.Unitdescription)
                    .HasColumnName("unitdescription")
                    .HasMaxLength(250);

                entity.Property(e => e.Volumeunit).HasColumnName("volumeunit");

                entity.Property(e => e.Weightunit).HasColumnName("weightunit");
            });

            modelBuilder.Entity<OmsordMasterUserCustomer>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Customercode })
                    .HasName("omsord_master_user_customer_pkey");

                entity.ToTable("omsord_master_user_customer", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_user_customer_dms_rep_dtt_idx");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(100);

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordMasterVehicleSubtype>(entity =>
            {
                entity.HasKey(e => e.Vehiclesubtypecode)
                    .HasName("omsord_master_vehicle_subtype_pkey");

                entity.ToTable("omsord_master_vehicle_subtype", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_vehicle_subtype_dms_rep_dtt_idx");

                entity.Property(e => e.Vehiclesubtypecode)
                    .HasColumnName("vehiclesubtypecode")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Vehiclesubtypename)
                    .HasColumnName("vehiclesubtypename")
                    .HasMaxLength(200);

                entity.Property(e => e.Vehicletypecode)
                    .IsRequired()
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<OmsordMasterVehicleType>(entity =>
            {
                entity.HasKey(e => e.Vehicletypecode)
                    .HasName("omsord_master_vehicle_type_pkey");

                entity.ToTable("omsord_master_vehicle_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_vehicle_type_dms_rep_dtt_idx");

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.Capvolume)
                    .HasColumnName("capvolume")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Capvolumeunit)
                    .IsRequired()
                    .HasColumnName("capvolumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Capweight)
                    .HasColumnName("capweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Capweightunit)
                    .IsRequired()
                    .HasColumnName("capweightunit")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Vehicletypename)
                    .IsRequired()
                    .HasColumnName("vehicletypename")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmsordMasterWorkingday>(entity =>
            {
                entity.HasKey(e => e.Workingdayid)
                    .HasName("omsord_master_workingday_pkey");

                entity.ToTable("omsord_master_workingday", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_master_workingday_dms_rep_dtt_idx");

                entity.Property(e => e.Workingdayid)
                    .HasColumnName("workingdayid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Friday).HasColumnName("friday");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.Monday).HasColumnName("monday");

                entity.Property(e => e.Saturday).HasColumnName("saturday");

                entity.Property(e => e.Sunday).HasColumnName("sunday");

                entity.Property(e => e.Thursday).HasColumnName("thursday");

                entity.Property(e => e.Tuesday).HasColumnName("tuesday");

                entity.Property(e => e.Wednesday).HasColumnName("wednesday");

                entity.Property(e => e.Workingdayname)
                    .IsRequired()
                    .HasColumnName("workingdayname")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordRunningNumberConfig>(entity =>
            {
                entity.HasKey(e => e.RunningConfigId)
                    .HasName("omsord_running_number_config_pkey");

                entity.ToTable("omsord_running_number_config", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_running_number_config_dms_rep_dtt_idx");

                entity.Property(e => e.RunningConfigId)
                    .HasColumnName("running_config_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Number1From)
                    .HasColumnName("number_1_from")
                    .HasMaxLength(20);

                entity.Property(e => e.Number1To)
                    .HasColumnName("number_1_to")
                    .HasMaxLength(20);

                entity.Property(e => e.Number2From)
                    .HasColumnName("number_2_from")
                    .HasMaxLength(20);

                entity.Property(e => e.Number2To)
                    .HasColumnName("number_2_to")
                    .HasMaxLength(20);

                entity.Property(e => e.Number3From)
                    .HasColumnName("number_3_from")
                    .HasMaxLength(20);

                entity.Property(e => e.Number3To)
                    .HasColumnName("number_3_to")
                    .HasMaxLength(20);

                entity.Property(e => e.Prefix1)
                    .HasColumnName("prefix_1")
                    .HasMaxLength(60);

                entity.Property(e => e.Prefix2)
                    .HasColumnName("prefix_2")
                    .HasMaxLength(60);

                entity.Property(e => e.Prefix3)
                    .HasColumnName("prefix_3")
                    .HasMaxLength(60);

                entity.Property(e => e.RunningConfigName)
                    .HasColumnName("running_config_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordSapOrder>(entity =>
            {
                entity.HasKey(e => e.Orderno)
                    .HasName("omsord_sap_order_pkey");

                entity.ToTable("omsord_sap_order", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_dms_rep_dtt_idx");

                entity.HasIndex(e => e.Orderreqdeliverydate)
                    .HasName("index_reqdate");

                entity.HasIndex(e => e.Soldtocode)
                    .HasName("index_soldto");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Backorderflag).HasColumnName("backorderflag");

                entity.Property(e => e.Biglotorderflag).HasColumnName("biglotorderflag");

                entity.Property(e => e.Distrchan)
                    .HasColumnName("distrchan")
                    .HasMaxLength(2);

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(2);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasMaxLength(3);

                entity.Property(e => e.Freightflag).HasColumnName("freightflag");

                entity.Property(e => e.Incoterm1)
                    .HasColumnName("incoterm1")
                    .HasMaxLength(3);

                entity.Property(e => e.Incoterm1desc)
                    .HasColumnName("incoterm1desc")
                    .HasMaxLength(50);

                entity.Property(e => e.Incoterm2)
                    .HasColumnName("incoterm2")
                    .HasMaxLength(50);

                entity.Property(e => e.Omscarriercode)
                    .HasColumnName("omscarriercode")
                    .HasMaxLength(32);

                entity.Property(e => e.Omscompleteflag).HasColumnName("omscompleteflag");

                entity.Property(e => e.Omscreatedby)
                    .IsRequired()
                    .HasColumnName("omscreatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Omscreateddate)
                    .IsRequired()
                    .HasColumnName("omscreateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsdestlocationcode)
                    .HasColumnName("omsdestlocationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Omsdestlocationhouseno)
                    .HasColumnName("omsdestlocationhouseno")
                    .HasMaxLength(20);

                entity.Property(e => e.Omsdestlocationmobile)
                    .HasColumnName("omsdestlocationmobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsdestlocationname)
                    .HasColumnName("omsdestlocationname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Omsdestlocationpostalcode)
                    .HasColumnName("omsdestlocationpostalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Omsdestlocationrecipient)
                    .HasColumnName("omsdestlocationrecipient")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsdestlocationregion).HasColumnName("omsdestlocationregion");

                entity.Property(e => e.Omsdestlocationregionname)
                    .HasColumnName("omsdestlocationregionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsdestlocationsoi)
                    .HasColumnName("omsdestlocationsoi")
                    .HasMaxLength(88);

                entity.Property(e => e.Omsdestlocationspecialcond)
                    .HasColumnName("omsdestlocationspecialcond")
                    .HasMaxLength(100);

                entity.Property(e => e.Omsdestlocationstreet)
                    .HasColumnName("omsdestlocationstreet")
                    .HasMaxLength(1000);

                entity.Property(e => e.Omsdestlocationtelephone)
                    .HasColumnName("omsdestlocationtelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsdriverlicenseno)
                    .HasColumnName("omsdriverlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Omsequipmenttype)
                    .HasColumnName("omsequipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Omsfullfillflag).HasColumnName("omsfullfillflag");

                entity.Property(e => e.Omsmergeintransitcode)
                    .HasColumnName("omsmergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Omsposervice)
                    .HasColumnName("omsposervice")
                    .HasMaxLength(10);

                entity.Property(e => e.Omsprebuildloadflag).HasColumnName("omsprebuildloadflag");

                entity.Property(e => e.Omsreqpalletflag).HasColumnName("omsreqpalletflag");

                entity.Property(e => e.Omsservicetype)
                    .HasColumnName("omsservicetype")
                    .HasMaxLength(16);

                entity.Property(e => e.Omsshipmentmemo)
                    .HasColumnName("omsshipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Omsspecialordertype)
                    .HasColumnName("omsspecialordertype")
                    .HasMaxLength(120);

                entity.Property(e => e.Omsspotrate)
                    .HasColumnName("omsspotrate")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Omsspotunit)
                    .HasColumnName("omsspotunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Omssystemremark)
                    .HasColumnName("omssystemremark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Omstrailerlicenseno)
                    .HasColumnName("omstrailerlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Omsupdatedby)
                    .HasColumnName("omsupdatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Omsupdateddate)
                    .HasColumnName("omsupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsvesselname)
                    .HasColumnName("omsvesselname")
                    .HasMaxLength(120);

                entity.Property(e => e.Orderconfirmdeliverydate)
                    .HasColumnName("orderconfirmdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordercreatedate)
                    .HasColumnName("ordercreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordercreditapprovedate)
                    .HasColumnName("ordercreditapprovedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliverycreatedate)
                    .HasColumnName("orderdeliverycreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliverydate)
                    .HasColumnName("orderdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliveryweight)
                    .HasColumnName("orderdeliveryweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordergrossweight)
                    .HasColumnName("ordergrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Orderreqdeliverydate)
                    .HasColumnName("orderreqdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordertotalweight)
                    .HasColumnName("ordertotalweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordertransplandate)
                    .HasColumnName("ordertransplandate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordertypecode)
                    .HasColumnName("ordertypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Ordertypedesc)
                    .HasColumnName("ordertypedesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Ordervolume)
                    .HasColumnName("ordervolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordervolumeunit)
                    .HasColumnName("ordervolumeunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(50);

                entity.Property(e => e.Pono)
                    .HasColumnName("pono")
                    .HasMaxLength(50);

                entity.Property(e => e.Reqpalletflag).HasColumnName("reqpalletflag");

                entity.Property(e => e.Returncondition)
                    .HasColumnName("returncondition")
                    .HasMaxLength(4);

                entity.Property(e => e.Returnconditiondesc)
                    .HasColumnName("returnconditiondesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Saleorg)
                    .HasColumnName("saleorg")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapcompleteflag).HasColumnName("sapcompleteflag");

                entity.Property(e => e.Scgtshiptocode)
                    .HasColumnName("scgtshiptocode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shippingcondition)
                    .HasColumnName("shippingcondition")
                    .HasMaxLength(2);

                entity.Property(e => e.Shippingconditiondesc)
                    .HasColumnName("shippingconditiondesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(128);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptodistrict)
                    .HasColumnName("shiptodistrict")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptolocationcode)
                    .HasColumnName("shiptolocationcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptomobile)
                    .HasColumnName("shiptomobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname2)
                    .HasColumnName("shiptoname2")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname3)
                    .HasColumnName("shiptoname3")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname4)
                    .HasColumnName("shiptoname4")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptonamemaster)
                    .HasColumnName("shiptonamemaster")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptopostalcode)
                    .HasColumnName("shiptopostalcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Shiptoregioncode)
                    .HasColumnName("shiptoregioncode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregionname)
                    .HasColumnName("shiptoregionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptospecialcond)
                    .HasColumnName("shiptospecialcond")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptostreet)
                    .HasColumnName("shiptostreet")
                    .HasMaxLength(60);

                entity.Property(e => e.Shiptosubregioncode)
                    .HasColumnName("shiptosubregioncode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptosubregiondesc)
                    .HasColumnName("shiptosubregiondesc")
                    .HasMaxLength(100);

                entity.Property(e => e.Shiptotelephone)
                    .HasColumnName("shiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptotranzone)
                    .HasColumnName("shiptotranzone")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtoname)
                    .HasColumnName("soldtoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingCriteria>(entity =>
            {
                entity.HasKey(e => e.Sapbatchno)
                    .HasName("omsord_sap_order_autosplitting_criteria_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_criteria", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_criteria_dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.Availablevolumeorderfrom)
                    .HasColumnName("availablevolumeorderfrom")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Availablevolumeorderto)
                    .HasColumnName("availablevolumeorderto")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Availablevolumeorderunit)
                    .HasColumnName("availablevolumeorderunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Availableweightorderfrom)
                    .HasColumnName("availableweightorderfrom")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Availableweightorderto)
                    .HasColumnName("availableweightorderto")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Availableweightorderunit)
                    .HasColumnName("availableweightorderunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Deliverycreatedatefrom)
                    .HasColumnName("deliverycreatedatefrom")
                    .HasMaxLength(37);

                entity.Property(e => e.DeliverycreatedatefromStr)
                    .HasColumnName("deliverycreatedatefrom_str")
                    .HasMaxLength(30);

                entity.Property(e => e.Deliverycreatedateto)
                    .HasColumnName("deliverycreatedateto")
                    .HasMaxLength(37);

                entity.Property(e => e.DeliverycreatedatetoStr)
                    .HasColumnName("deliverycreatedateto_str")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Documenttype)
                    .HasColumnName("documenttype")
                    .HasMaxLength(3);

                entity.Property(e => e.Incoterm1from)
                    .HasColumnName("incoterm1from")
                    .HasMaxLength(3);

                entity.Property(e => e.Incoterm1to)
                    .HasColumnName("incoterm1to")
                    .HasMaxLength(3);

                entity.Property(e => e.Numberofdays).HasColumnName("numberofdays");

                entity.Property(e => e.Ordercreatedatefrom)
                    .HasColumnName("ordercreatedatefrom")
                    .HasMaxLength(37);

                entity.Property(e => e.OrdercreatedatefromStr)
                    .HasColumnName("ordercreatedatefrom_str")
                    .HasMaxLength(30);

                entity.Property(e => e.Ordercreatedateto)
                    .HasColumnName("ordercreatedateto")
                    .HasMaxLength(37);

                entity.Property(e => e.OrdercreatedatetoStr)
                    .HasColumnName("ordercreatedateto_str")
                    .HasMaxLength(30);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(3);

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Ordernumberfrom)
                    .HasColumnName("ordernumberfrom")
                    .HasMaxLength(2000);

                entity.Property(e => e.Ordernumberto)
                    .HasColumnName("ordernumberto")
                    .HasMaxLength(2000);

                entity.Property(e => e.Orderstatus)
                    .HasColumnName("orderstatus")
                    .HasMaxLength(10);

                entity.Property(e => e.Projectmanagerorder)
                    .HasColumnName("projectmanagerorder")
                    .HasMaxLength(50);

                entity.Property(e => e.Regionlevel)
                    .HasColumnName("regionlevel")
                    .HasMaxLength(20);

                entity.Property(e => e.Requestdeliverydatefrom)
                    .HasColumnName("requestdeliverydatefrom")
                    .HasMaxLength(37);

                entity.Property(e => e.RequestdeliverydatefromStr)
                    .HasColumnName("requestdeliverydatefrom_str")
                    .HasMaxLength(30);

                entity.Property(e => e.Requestdeliverydateto)
                    .HasColumnName("requestdeliverydateto")
                    .HasMaxLength(37);

                entity.Property(e => e.RequestdeliverydatetoStr)
                    .HasColumnName("requestdeliverydateto_str")
                    .HasMaxLength(30);

                entity.Property(e => e.Shiptopartyfrom)
                    .HasColumnName("shiptopartyfrom")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptopartyto)
                    .HasColumnName("shiptopartyto")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregiontype)
                    .HasColumnName("shiptoregiontype")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptosapregionfrom)
                    .HasColumnName("shiptosapregionfrom")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptosapregionto)
                    .HasColumnName("shiptosapregionto")
                    .HasMaxLength(20);

                entity.Property(e => e.Soldtopartyfrom)
                    .HasColumnName("soldtopartyfrom")
                    .HasMaxLength(50);

                entity.Property(e => e.Soldtopartypostalcodefrom)
                    .HasColumnName("soldtopartypostalcodefrom")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtopartypostalcodeto)
                    .HasColumnName("soldtopartypostalcodeto")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtopartyto)
                    .HasColumnName("soldtopartyto")
                    .HasMaxLength(50);

                entity.Property(e => e.Userposition)
                    .HasColumnName("userposition")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingCriteriaMatterialFrom>(entity =>
            {
                entity.HasKey(e => e.Sapbatchno)
                    .HasName("omsord_sap_order_autosplitting_criteria_matterial_from_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_criteria_matterial_from", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_criteria_matteri_dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Materialnumber)
                    .HasColumnName("materialnumber")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingCriteriaMatterialTo>(entity =>
            {
                entity.HasKey(e => e.Sapbatchno)
                    .HasName("omsord_sap_order_autosplitting_criteria_matterial_to_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_criteria_matterial_to", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_criteria_matter_dms_rep_dtt_idx1");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Materialnumber)
                    .HasColumnName("materialnumber")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingCriteriaShippingpoint>(entity =>
            {
                entity.HasKey(e => new { e.Sapbatchno, e.Shippingpoint })
                    .HasName("omsord_sap_order_autosplitting_criteria_shippingpoint_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_criteria_shippingpoint", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_criteria_shippin_dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Shippingpoint)
                    .HasColumnName("shippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingCriteriaShiptoRegion>(entity =>
            {
                entity.HasKey(e => new { e.Sapbatchno, e.Shiptoregion })
                    .HasName("omsord_sap_order_autosplitting_criteria_shipto_region_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_criteria_shipto_region", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_criteria_shipto__dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Shiptoregion)
                    .HasColumnName("shiptoregion")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingCriteriaSubShiptoRegion>(entity =>
            {
                entity.HasKey(e => new { e.Sapbatchno, e.Subshiptoregion })
                    .HasName("omsord_sap_order_autosplitting_criteria_sub_shipto_region_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_criteria_sub_shipto_region", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_criteria_sub_shi_dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Subshiptoregion)
                    .HasColumnName("subshiptoregion")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingOrder>(entity =>
            {
                entity.HasKey(e => new { e.Sapbatchno, e.Orderno, e.Orderline })
                    .HasName("omsord_sap_order_autosplitting_order_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_order", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_order_dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(3);

                entity.Property(e => e.Backorderflag).HasColumnName("backorderflag");

                entity.Property(e => e.Biglotorderflag).HasColumnName("biglotorderflag");

                entity.Property(e => e.Conflictdmstatus)
                    .HasColumnName("conflictdmstatus")
                    .HasMaxLength(1);

                entity.Property(e => e.Difflocationcount).HasColumnName("difflocationcount");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Documenttype)
                    .HasColumnName("documenttype")
                    .HasMaxLength(3);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Freightflag).HasColumnName("freightflag");

                entity.Property(e => e.Incoterm1)
                    .HasColumnName("incoterm1")
                    .HasMaxLength(3);

                entity.Property(e => e.Ischeck).HasColumnName("ischeck");

                entity.Property(e => e.Orderbackweight)
                    .HasColumnName("orderbackweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordercreatedate)
                    .HasColumnName("ordercreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordercreditapprovedate)
                    .HasColumnName("ordercreditapprovedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliverycreatedate)
                    .HasColumnName("orderdeliverycreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliveryweight)
                    .HasColumnName("orderdeliveryweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordergrossweight)
                    .HasColumnName("ordergrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Orderremainweight)
                    .HasColumnName("orderremainweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Orderreqdeliverydate)
                    .HasColumnName("orderreqdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordertotalweight)
                    .HasColumnName("ordertotalweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordervolume)
                    .HasColumnName("ordervolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Pageflag)
                    .HasColumnName("pageflag")
                    .HasMaxLength(1);

                entity.Property(e => e.Pono)
                    .HasColumnName("pono")
                    .HasMaxLength(50);

                entity.Property(e => e.Schdudate)
                    .HasColumnName("schdudate")
                    .HasMaxLength(37);

                entity.Property(e => e.Seletedshippingpoint)
                    .HasColumnName("seletedshippingpoint")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceOption01)
                    .HasColumnName("service_option_01")
                    .HasMaxLength(90);

                entity.Property(e => e.ServiceOption02)
                    .HasColumnName("service_option_02")
                    .HasMaxLength(90);

                entity.Property(e => e.ServiceOption03)
                    .HasColumnName("service_option_03")
                    .HasMaxLength(90);

                entity.Property(e => e.ServiceOption04)
                    .HasColumnName("service_option_04")
                    .HasMaxLength(90);

                entity.Property(e => e.Shippingcondition)
                    .HasColumnName("shippingcondition")
                    .HasMaxLength(500);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptolocationcode)
                    .HasColumnName("shiptolocationcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname4)
                    .HasColumnName("shiptoname4")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptonamemaster)
                    .HasColumnName("shiptonamemaster")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregioncode)
                    .HasColumnName("shiptoregioncode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptospecialcond)
                    .HasColumnName("shiptospecialcond")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptosubregiondesc)
                    .HasColumnName("shiptosubregiondesc")
                    .HasMaxLength(100);

                entity.Property(e => e.Shiptotelephone)
                    .HasColumnName("shiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtoname)
                    .HasColumnName("soldtoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Stampby)
                    .HasColumnName("stampby")
                    .HasMaxLength(100);

                entity.Property(e => e.Stampdatetime)
                    .IsRequired()
                    .HasColumnName("stampdatetime")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingOrderShippingpoint>(entity =>
            {
                entity.HasKey(e => new { e.Sapbatchno, e.Orderno, e.Orderline, e.Value })
                    .HasName("omsord_sap_order_autosplitting_order_shippingpoint_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_order_shippingpoint", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_order_shippingpo_dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(3);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingOrderThoughpoint>(entity =>
            {
                entity.HasKey(e => new { e.Sapbatchno, e.Orderno, e.Orderline, e.Locationcode })
                    .HasName("omsord_sap_order_autosplitting_order_thoughpoint_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_order_thoughpoint", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_order_thoughpoin_dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(3);

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Locationtype)
                    .HasColumnName("locationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<OmsordSapOrderAutosplittingTask>(entity =>
            {
                entity.HasKey(e => e.Sapbatchno)
                    .HasName("omsord_sap_order_autosplitting_task_pkey");

                entity.ToTable("omsord_sap_order_autosplitting_task", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_autosplitting_task_dms_rep_dtt_idx");

                entity.Property(e => e.Sapbatchno)
                    .HasColumnName("sapbatchno")
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.Computername)
                    .HasColumnName("computername")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ErrorDate)
                    .HasColumnName("error_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Jobbatchno)
                    .HasColumnName("jobbatchno")
                    .HasMaxLength(50);

                entity.Property(e => e.Plannerusername)
                    .HasColumnName("plannerusername")
                    .HasMaxLength(200);

                entity.Property(e => e.ProcessedDate)
                    .HasColumnName("processed_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Reportflag).HasColumnName("reportflag");

                entity.Property(e => e.Stage)
                    .HasColumnName("stage")
                    .HasMaxLength(100);

                entity.Property(e => e.Tasktype)
                    .HasColumnName("tasktype")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordSapOrderCharge>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Chargetype })
                    .HasName("omsord_sap_order_charge_pkey");

                entity.ToTable("omsord_sap_order_charge", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_charge_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Chargetype)
                    .HasColumnName("chargetype")
                    .HasMaxLength(50);

                entity.Property(e => e.Applyapoption)
                    .HasColumnName("applyapoption")
                    .HasMaxLength(50);

                entity.Property(e => e.Chargeamount)
                    .HasColumnName("chargeamount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Chargeunit)
                    .HasColumnName("chargeunit")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Updateby)
                    .HasColumnName("updateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordSapOrderItem>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Itemno })
                    .HasName("omsord_sap_order_item_pkey");

                entity.ToTable("omsord_sap_order_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_item_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Itemno)
                    .HasColumnName("itemno")
                    .HasMaxLength(20);

                entity.Property(e => e.Confirmdeldatetime)
                    .HasColumnName("confirmdeldatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Confirmqty)
                    .HasColumnName("confirmqty")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Deliverydatetime)
                    .HasColumnName("deliverydatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Deliveryqty)
                    .HasColumnName("deliveryqty")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Deliveryweight)
                    .HasColumnName("deliveryweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Freegoodsflag).HasColumnName("freegoodsflag");

                entity.Property(e => e.Grossweight)
                    .HasColumnName("grossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Isosaleunit)
                    .HasColumnName("isosaleunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Isovolumeunit)
                    .HasColumnName("isovolumeunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Isoweightunit)
                    .HasColumnName("isoweightunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Loadingdatetime)
                    .HasColumnName("loadingdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Matavaildatetime)
                    .HasColumnName("matavaildatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Materialcode)
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialdesc)
                    .HasColumnName("materialdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Matfreightgroup)
                    .HasColumnName("matfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Matfreightgroupdesc)
                    .HasColumnName("matfreightgroupdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Omscancelflag).HasColumnName("omscancelflag");

                entity.Property(e => e.Omscreateby)
                    .HasColumnName("omscreateby")
                    .HasMaxLength(50);

                entity.Property(e => e.Omscreatedate)
                    .HasColumnName("omscreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omshavescheduleflag).HasColumnName("omshavescheduleflag");

                entity.Property(e => e.Omsinactiveflag).HasColumnName("omsinactiveflag");

                entity.Property(e => e.Omsoriginlocationcode)
                    .HasColumnName("omsoriginlocationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Omsreqpalletflag).HasColumnName("omsreqpalletflag");

                entity.Property(e => e.Omssystemremark)
                    .HasColumnName("omssystemremark")
                    .HasMaxLength(150);

                entity.Property(e => e.Omstransittime)
                    .HasColumnName("omstransittime")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Omsupdateby)
                    .HasColumnName("omsupdateby")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsupdatedate)
                    .HasColumnName("omsupdatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderqty)
                    .HasColumnName("orderqty")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Ordervolume)
                    .HasColumnName("ordervolume")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Orderweight)
                    .HasColumnName("orderweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Reqpalletflag).HasColumnName("reqpalletflag");

                entity.Property(e => e.Saleunit)
                    .HasColumnName("saleunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Saproute)
                    .HasColumnName("saproute")
                    .HasMaxLength(6);

                entity.Property(e => e.Saproutedesc)
                    .HasColumnName("saproutedesc")
                    .HasMaxLength(100);

                entity.Property(e => e.Shippingcondition)
                    .HasColumnName("shippingcondition")
                    .HasMaxLength(2);

                entity.Property(e => e.Shippingconditiondesc)
                    .HasColumnName("shippingconditiondesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Shippingpoint)
                    .HasColumnName("shippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Shippingpointdesc)
                    .HasColumnName("shippingpointdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Transportplaningdatetime)
                    .HasColumnName("transportplaningdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeperunit)
                    .HasColumnName("volumeperunit")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Volumeperunitccm)
                    .HasColumnName("volumeperunitccm")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Weightperunit)
                    .HasColumnName("weightperunit")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Weightperunitkg)
                    .HasColumnName("weightperunitkg")
                    .HasColumnType("numeric(16,3)");

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<OmsordSapOrderTemp>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Omscreatedby, e.Omscreateddate })
                    .HasName("omsord_sap_order_temp_pkey");

                entity.ToTable("omsord_sap_order_temp", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_temp_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Omscreatedby)
                    .HasColumnName("omscreatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Omscreateddate)
                    .HasColumnName("omscreateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Backorderflag).HasColumnName("backorderflag");

                entity.Property(e => e.Biglotorderflag).HasColumnName("biglotorderflag");

                entity.Property(e => e.Distrchan)
                    .HasColumnName("distrchan")
                    .HasMaxLength(2);

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(2);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasMaxLength(3);

                entity.Property(e => e.Freightflag).HasColumnName("freightflag");

                entity.Property(e => e.Incoterm1)
                    .HasColumnName("incoterm1")
                    .HasMaxLength(3);

                entity.Property(e => e.Incoterm1desc)
                    .HasColumnName("incoterm1desc")
                    .HasMaxLength(50);

                entity.Property(e => e.Incoterm2)
                    .HasColumnName("incoterm2")
                    .HasMaxLength(50);

                entity.Property(e => e.Omscompleteflag).HasColumnName("omscompleteflag");

                entity.Property(e => e.Omsfullfillflag).HasColumnName("omsfullfillflag");

                entity.Property(e => e.Omsposervice)
                    .HasColumnName("omsposervice")
                    .HasMaxLength(120);

                entity.Property(e => e.Omsshipmentmemo)
                    .HasColumnName("omsshipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Omsspecialordertype)
                    .HasColumnName("omsspecialordertype")
                    .HasMaxLength(120);

                entity.Property(e => e.Omsupdatedby)
                    .HasColumnName("omsupdatedby")
                    .HasMaxLength(200);

                entity.Property(e => e.Omsupdateddate)
                    .HasColumnName("omsupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsvesselname)
                    .HasColumnName("omsvesselname")
                    .HasMaxLength(120);

                entity.Property(e => e.Orderconfirmdeliverydate)
                    .HasColumnName("orderconfirmdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordercreatedate)
                    .HasColumnName("ordercreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordercreditapprovedate)
                    .HasColumnName("ordercreditapprovedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliverycreatedate)
                    .HasColumnName("orderdeliverycreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliverydate)
                    .HasColumnName("orderdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliveryweight)
                    .HasColumnName("orderdeliveryweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordergrossweight)
                    .HasColumnName("ordergrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Orderreqdeliverydate)
                    .HasColumnName("orderreqdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordertotalweight)
                    .HasColumnName("ordertotalweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordertransplandate)
                    .HasColumnName("ordertransplandate")
                    .HasMaxLength(37);

                entity.Property(e => e.Ordertypecode)
                    .HasColumnName("ordertypecode")
                    .HasMaxLength(4);

                entity.Property(e => e.Ordertypedesc)
                    .HasColumnName("ordertypedesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Ordervolume)
                    .HasColumnName("ordervolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Ordervolumeunit)
                    .HasColumnName("ordervolumeunit")
                    .HasMaxLength(3);

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(50);

                entity.Property(e => e.Pono)
                    .HasColumnName("pono")
                    .HasMaxLength(50);

                entity.Property(e => e.Reqpalletflag).HasColumnName("reqpalletflag");

                entity.Property(e => e.Returncondition)
                    .HasColumnName("returncondition")
                    .HasMaxLength(4);

                entity.Property(e => e.Returnconditiondesc)
                    .HasColumnName("returnconditiondesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Saleorg)
                    .HasColumnName("saleorg")
                    .HasMaxLength(4);

                entity.Property(e => e.Sapcompleteflag).HasColumnName("sapcompleteflag");

                entity.Property(e => e.Scgtshiptocode)
                    .HasColumnName("scgtshiptocode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shippingcondition)
                    .HasColumnName("shippingcondition")
                    .HasMaxLength(2);

                entity.Property(e => e.Shippingconditiondesc)
                    .HasColumnName("shippingconditiondesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptocity)
                    .HasColumnName("shiptocity")
                    .HasMaxLength(128);

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptodistrict)
                    .HasColumnName("shiptodistrict")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptolocationcode)
                    .HasColumnName("shiptolocationcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptomobile)
                    .HasColumnName("shiptomobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname)
                    .HasColumnName("shiptoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname2)
                    .HasColumnName("shiptoname2")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname3)
                    .HasColumnName("shiptoname3")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoname4)
                    .HasColumnName("shiptoname4")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptonamemaster)
                    .HasColumnName("shiptonamemaster")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptopostalcode)
                    .HasColumnName("shiptopostalcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Shiptoregioncode)
                    .HasColumnName("shiptoregioncode")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptoregionname)
                    .HasColumnName("shiptoregionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptospecialcond)
                    .HasColumnName("shiptospecialcond")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptostreet)
                    .HasColumnName("shiptostreet")
                    .HasMaxLength(60);

                entity.Property(e => e.Shiptosubregioncode)
                    .HasColumnName("shiptosubregioncode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shiptosubregiondesc)
                    .HasColumnName("shiptosubregiondesc")
                    .HasMaxLength(100);

                entity.Property(e => e.Shiptotelephone)
                    .HasColumnName("shiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Shiptotranzone)
                    .HasColumnName("shiptotranzone")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Soldtoname)
                    .HasColumnName("soldtoname")
                    .HasMaxLength(50);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<OmsordSapOrderThoughpoint>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Orderline, e.Locationcode })
                    .HasName("omsord_sap_order_thoughpoint_pkey");

                entity.ToTable("omsord_sap_order_thoughpoint", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_order_thoughpoint_dms_rep_dtt_idx");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Orderline)
                    .HasColumnName("orderline")
                    .HasMaxLength(20);

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Locationtype)
                    .HasColumnName("locationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<OmsordSapScheduleLine>(entity =>
            {
                entity.HasKey(e => e.Schduid)
                    .HasName("omsord_sap_schedule_line_pkey");

                entity.ToTable("omsord_sap_schedule_line", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_sap_schedule_line_dms_rep_dtt_idx");

                entity.Property(e => e.Schduid)
                    .HasColumnName("schduid")
                    .HasMaxLength(13)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Itemno)
                    .HasColumnName("itemno")
                    .HasMaxLength(20);

                entity.Property(e => e.Matcode)
                    .HasColumnName("matcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Matdesc)
                    .HasColumnName("matdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Omscancelflag).HasColumnName("omscancelflag");

                entity.Property(e => e.Omscarriercode)
                    .HasColumnName("omscarriercode")
                    .HasMaxLength(32);

                entity.Property(e => e.Omscreateby)
                    .HasColumnName("omscreateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Omscreatedate)
                    .IsRequired()
                    .HasColumnName("omscreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsdeliveryfromdate)
                    .HasColumnName("omsdeliveryfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsdeliverytodate)
                    .HasColumnName("omsdeliverytodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsdriverlicensenumber)
                    .HasColumnName("omsdriverlicensenumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Omsequipmenttype)
                    .HasColumnName("omsequipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Omsinactiveflag).HasColumnName("omsinactiveflag");

                entity.Property(e => e.Omsitinerarycode)
                    .HasColumnName("omsitinerarycode")
                    .HasMaxLength(32);

                entity.Property(e => e.Omsmergeintransitcode)
                    .HasColumnName("omsmergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Omsnewdeliverydatefromcust)
                    .HasColumnName("omsnewdeliverydatefromcust")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsnewdeliverydatefromlpc)
                    .HasColumnName("omsnewdeliverydatefromlpc")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsnewdeliverydatetocust)
                    .HasColumnName("omsnewdeliverydatetocust")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsnewdeliverydatetolpc)
                    .HasColumnName("omsnewdeliverydatetolpc")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsnewdeliveryqtycust)
                    .HasColumnName("omsnewdeliveryqtycust")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Omsnewdeliveryqtylpc)
                    .HasColumnName("omsnewdeliveryqtylpc")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Omspickupfromdate)
                    .HasColumnName("omspickupfromdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omspickuptodate)
                    .HasColumnName("omspickuptodate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omsprebuildloadflag)
                    .HasColumnName("omsprebuildloadflag")
                    .HasMaxLength(120);

                entity.Property(e => e.Omsremark)
                    .HasColumnName("omsremark")
                    .HasMaxLength(150);

                entity.Property(e => e.Omsreqpalletflag).HasColumnName("omsreqpalletflag");

                entity.Property(e => e.Omsroute)
                    .HasColumnName("omsroute")
                    .HasMaxLength(6);

                entity.Property(e => e.Omsroutedesc)
                    .HasColumnName("omsroutedesc")
                    .HasMaxLength(100);

                entity.Property(e => e.Omsservicetype)
                    .HasColumnName("omsservicetype")
                    .HasMaxLength(16);

                entity.Property(e => e.Omsshippinglocation)
                    .HasColumnName("omsshippinglocation")
                    .HasMaxLength(64);

                entity.Property(e => e.Omsshiptoaddress)
                    .HasColumnName("omsshiptoaddress")
                    .HasMaxLength(168);

                entity.Property(e => e.Omsshiptocity)
                    .HasColumnName("omsshiptocity")
                    .HasMaxLength(128);

                entity.Property(e => e.Omsshiptolocation)
                    .HasColumnName("omsshiptolocation")
                    .HasMaxLength(64);

                entity.Property(e => e.Omsshiptolocationname)
                    .HasColumnName("omsshiptolocationname")
                    .HasMaxLength(280);

                entity.Property(e => e.Omsshiptomobile)
                    .HasColumnName("omsshiptomobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsshiptopostalcode)
                    .HasColumnName("omsshiptopostalcode")
                    .HasMaxLength(64);

                entity.Property(e => e.Omsshiptorecipientname)
                    .HasColumnName("omsshiptorecipientname")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsshiptoregioncode)
                    .HasColumnName("omsshiptoregioncode")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsshiptoregionname)
                    .HasColumnName("omsshiptoregionname")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsshiptospecialcond)
                    .HasColumnName("omsshiptospecialcond")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsshiptotelephone)
                    .HasColumnName("omsshiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Omsspotrate).HasColumnName("omsspotrate");

                entity.Property(e => e.Omsspotunit)
                    .HasColumnName("omsspotunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Omssystemremark)
                    .HasColumnName("omssystemremark")
                    .HasMaxLength(150);

                entity.Property(e => e.Omstmsshipfromlocation)
                    .HasColumnName("omstmsshipfromlocation")
                    .HasMaxLength(64);

                entity.Property(e => e.Omstmsshiptolocation)
                    .HasColumnName("omstmsshiptolocation")
                    .HasMaxLength(64);

                entity.Property(e => e.Omstrailerlicensenumber)
                    .HasColumnName("omstrailerlicensenumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Omstransittime)
                    .HasColumnName("omstransittime")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.Omsupdateby)
                    .HasColumnName("omsupdateby")
                    .HasMaxLength(200);

                entity.Property(e => e.Omsupdatedate)
                    .HasColumnName("omsupdatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasMaxLength(12);

                entity.Property(e => e.Schduno)
                    .HasColumnName("schduno")
                    .HasMaxLength(4);

                entity.Property(e => e.Shippingpoint)
                    .HasColumnName("shippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Shippingpointdesc)
                    .HasColumnName("shippingpointdesc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OmsordServiceOrder>(entity =>
            {
                entity.HasKey(e => e.Sonumber)
                    .HasName("omsord_service_order_pkey");

                entity.ToTable("omsord_service_order", "dom");

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Agentflag).HasColumnName("agentflag");

                entity.Property(e => e.Autoreleaseflag).HasColumnName("autoreleaseflag");

                entity.Property(e => e.Batchid).HasColumnName("batchid");

                entity.Property(e => e.Billgroupname)
                    .HasColumnName("billgroupname")
                    .HasMaxLength(100);

                entity.Property(e => e.Billingstatus).HasColumnName("billingstatus");

                entity.Property(e => e.Completedeliveryflag).HasColumnName("completedeliveryflag");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Creditamount)
                    .HasColumnName("creditamount")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Creditapprovedamount)
                    .HasColumnName("creditapprovedamount")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Creditapprovedate)
                    .HasColumnName("creditapprovedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Creditapproveddate)
                    .HasColumnName("creditapproveddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Creditapprovedflag).HasColumnName("creditapprovedflag");

                entity.Property(e => e.Creditdocfiscalyear).HasColumnName("creditdocfiscalyear");

                entity.Property(e => e.Creditfidocid)
                    .HasColumnName("creditfidocid")
                    .HasMaxLength(10);

                entity.Property(e => e.Creditgroup)
                    .HasColumnName("creditgroup")
                    .HasMaxLength(10);

                entity.Property(e => e.Customercity)
                    .HasColumnName("customercity")
                    .HasMaxLength(140);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.Customerdistrict)
                    .HasColumnName("customerdistrict")
                    .HasMaxLength(140);

                entity.Property(e => e.Customername1)
                    .HasColumnName("customername1")
                    .HasMaxLength(140);

                entity.Property(e => e.Customername2)
                    .HasColumnName("customername2")
                    .HasMaxLength(140);

                entity.Property(e => e.Customername3)
                    .HasColumnName("customername3")
                    .HasMaxLength(140);

                entity.Property(e => e.Customername4)
                    .HasColumnName("customername4")
                    .HasMaxLength(140);

                entity.Property(e => e.Customerpostalcode)
                    .HasColumnName("customerpostalcode")
                    .HasMaxLength(140);

                entity.Property(e => e.Customerstreet)
                    .HasColumnName("customerstreet")
                    .HasMaxLength(140);

                entity.Property(e => e.Customertype)
                    .HasColumnName("customertype")
                    .HasMaxLength(10);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Dmreceivertelephone)
                    .HasColumnName("dmreceivertelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dmscheduledate)
                    .HasColumnName("dmscheduledate")
                    .HasMaxLength(37);

                entity.Property(e => e.Draftreason)
                    .HasColumnName("draftreason")
                    .HasMaxLength(2000);

                entity.Property(e => e.Haveshippingmark).HasColumnName("haveshippingmark");

                entity.Property(e => e.Idocno)
                    .HasColumnName("idocno")
                    .HasMaxLength(20);

                entity.Property(e => e.Issapgiadvance).HasColumnName("issapgiadvance");

                entity.Property(e => e.Isscheduling).HasColumnName("isscheduling");

                entity.Property(e => e.Issoldtoready).HasColumnName("issoldtoready");

                entity.Property(e => e.Isusestandardcuttingtime).HasColumnName("isusestandardcuttingtime");

                entity.Property(e => e.Mergeintransitcode)
                    .HasColumnName("mergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Omscarriercode)
                    .HasColumnName("omscarriercode")
                    .HasMaxLength(32);

                entity.Property(e => e.Omsdriverlicenseno)
                    .HasColumnName("omsdriverlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Omsequipmenttype)
                    .HasColumnName("omsequipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Omsmergeintransitcode)
                    .HasColumnName("omsmergeintransitcode")
                    .HasMaxLength(12);

                entity.Property(e => e.Omsposervice)
                    .HasColumnName("omsposervice")
                    .HasMaxLength(10);

                entity.Property(e => e.Omsprebuildloadflag).HasColumnName("omsprebuildloadflag");

                entity.Property(e => e.Omsreqpalletflag).HasColumnName("omsreqpalletflag");

                entity.Property(e => e.Omsservicetype)
                    .HasColumnName("omsservicetype")
                    .HasMaxLength(16);

                entity.Property(e => e.Omsshipmentmemo)
                    .HasColumnName("omsshipmentmemo")
                    .HasMaxLength(1000);

                entity.Property(e => e.Omsspecialordertype)
                    .HasColumnName("omsspecialordertype")
                    .HasMaxLength(120);

                entity.Property(e => e.Omsspotrate)
                    .HasColumnName("omsspotrate")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Omsspotunit)
                    .HasColumnName("omsspotunit")
                    .HasMaxLength(50);

                entity.Property(e => e.Omstrailerlicenseno)
                    .HasColumnName("omstrailerlicenseno")
                    .HasMaxLength(255);

                entity.Property(e => e.Omsvesselname)
                    .HasColumnName("omsvesselname")
                    .HasMaxLength(120);

                entity.Property(e => e.Ordercharge).HasColumnName("ordercharge");

                entity.Property(e => e.Orderdate)
                    .IsRequired()
                    .HasColumnName("orderdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderdeliverycreatedate)
                    .HasColumnName("orderdeliverycreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Orderpatternid).HasColumnName("orderpatternid");

                entity.Property(e => e.Payercode)
                    .HasColumnName("payercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Payercompanycode)
                    .HasColumnName("payercompanycode")
                    .HasMaxLength(4);

                entity.Property(e => e.Payername)
                    .HasColumnName("payername")
                    .HasMaxLength(560);

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(10);

                entity.Property(e => e.Ponumber)
                    .IsRequired()
                    .HasColumnName("ponumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Recipiantname)
                    .HasColumnName("recipiantname")
                    .HasMaxLength(200);

                entity.Property(e => e.Recipianttelephone)
                    .HasColumnName("recipianttelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Refdistrchan)
                    .HasColumnName("refdistrchan")
                    .HasMaxLength(2);

                entity.Property(e => e.Refdivision)
                    .HasColumnName("refdivision")
                    .HasMaxLength(2);

                entity.Property(e => e.Reference1)
                    .HasColumnName("reference1")
                    .HasMaxLength(250);

                entity.Property(e => e.Reference2)
                    .HasColumnName("reference2")
                    .HasMaxLength(250);

                entity.Property(e => e.Reference3)
                    .HasColumnName("reference3")
                    .HasMaxLength(250);

                entity.Property(e => e.Reference4)
                    .HasColumnName("reference4")
                    .HasMaxLength(250);

                entity.Property(e => e.Reference5)
                    .HasColumnName("reference5")
                    .HasMaxLength(250);

                entity.Property(e => e.Refincoterm)
                    .HasColumnName("refincoterm")
                    .HasMaxLength(3);

                entity.Property(e => e.Refincoterm2)
                    .HasColumnName("refincoterm2")
                    .HasMaxLength(70);

                entity.Property(e => e.Refincoterm3)
                    .HasColumnName("refincoterm3")
                    .HasMaxLength(70);

                entity.Property(e => e.Refordertype)
                    .HasColumnName("refordertype")
                    .HasMaxLength(4);

                entity.Property(e => e.Refrequestdeliverydate)
                    .HasColumnName("refrequestdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Refsaleorg)
                    .HasColumnName("refsaleorg")
                    .HasMaxLength(4);

                entity.Property(e => e.Refsalesdoctype)
                    .HasColumnName("refsalesdoctype")
                    .HasMaxLength(10);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Requestdeliverydate)
                    .HasColumnName("requestdeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Sapshiptoname)
                    .HasColumnName("sapshiptoname")
                    .HasMaxLength(100);

                entity.Property(e => e.Soldtoregion)
                    .HasColumnName("soldtoregion")
                    .HasMaxLength(4);

                entity.Property(e => e.Soldtotelephone)
                    .HasColumnName("soldtotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Sourcesystem)
                    .IsRequired()
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(30);

                entity.Property(e => e.Specialcondition)
                    .HasColumnName("specialcondition")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Warningmessage)
                    .HasColumnName("warningmessage")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<OmsordServiceOrderAutosplitting>(entity =>
            {
                entity.HasKey(e => new { e.Systembatchno, e.Sonumber, e.Scheduleno })
                    .HasName("omsord_service_order_autosplitting_pkey");

                entity.ToTable("omsord_service_order_autosplitting", "dom");

                entity.Property(e => e.Systembatchno)
                    .HasColumnName("systembatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Scheduleno).HasColumnName("scheduleno");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Plannername)
                    .HasColumnName("plannername")
                    .HasMaxLength(50);

                entity.Property(e => e.Stampdatetime)
                    .IsRequired()
                    .HasColumnName("stampdatetime")
                    .HasMaxLength(37);

                entity.Property(e => e.Stampname)
                    .HasColumnName("stampname")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordServiceOrderAutosplittingTask>(entity =>
            {
                entity.HasKey(e => e.Systembatchno)
                    .HasName("omsord_service_order_autosplitting_task_pkey");

                entity.ToTable("omsord_service_order_autosplitting_task", "dom");

                entity.Property(e => e.Systembatchno)
                    .HasColumnName("systembatchno")
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.Computername)
                    .HasColumnName("computername")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ErrorDate)
                    .HasColumnName("error_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.Jobbatchno)
                    .HasColumnName("jobbatchno")
                    .HasMaxLength(50);

                entity.Property(e => e.Plannerusername)
                    .HasColumnName("plannerusername")
                    .HasMaxLength(200);

                entity.Property(e => e.ProcessedDate)
                    .HasColumnName("processed_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Reportflag).HasColumnName("reportflag");

                entity.Property(e => e.Rowversion).HasColumnName("rowversion");

                entity.Property(e => e.Sourcesystem)
                    .IsRequired()
                    .HasColumnName("sourcesystem")
                    .HasMaxLength(30);

                entity.Property(e => e.Stage)
                    .HasColumnName("stage")
                    .HasMaxLength(100);

                entity.Property(e => e.Tasktype)
                    .HasColumnName("tasktype")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordServiceOrderAutosplittingThoughpoint>(entity =>
            {
                entity.HasKey(e => new { e.Systembatchno, e.Sonumber, e.Scheduleno, e.Locationcode })
                    .HasName("omsord_service_order_autosplitting_thoughpoint_pkey");

                entity.ToTable("omsord_service_order_autosplitting_thoughpoint", "dom");

                entity.Property(e => e.Systembatchno)
                    .HasColumnName("systembatchno")
                    .HasMaxLength(16);

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Scheduleno).HasColumnName("scheduleno");

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Locationtype)
                    .HasColumnName("locationtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<OmsordServiceOrderCreditGroup>(entity =>
            {
                entity.HasKey(e => e.Creditgroupcode)
                    .HasName("omsord_service_order_credit_group_pkey");

                entity.ToTable("omsord_service_order_credit_group", "dom");

                entity.Property(e => e.Creditgroupcode)
                    .HasColumnName("creditgroupcode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Approvalposition)
                    .HasColumnName("approvalposition")
                    .HasMaxLength(2);

                entity.Property(e => e.Aramount)
                    .HasColumnName("aramount")
                    .HasColumnType("numeric(21,5)");

                entity.Property(e => e.Cca)
                    .IsRequired()
                    .HasColumnName("cca")
                    .HasMaxLength(4);

                entity.Property(e => e.Collateralamount)
                    .HasColumnName("collateralamount")
                    .HasColumnType("numeric(21,5)");

                entity.Property(e => e.Creditcheckdate)
                    .IsRequired()
                    .HasColumnName("creditcheckdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Creditexceedamount)
                    .HasColumnName("creditexceedamount")
                    .HasColumnType("numeric(21,5)");

                entity.Property(e => e.Creditrepgroupcode)
                    .HasColumnName("creditrepgroupcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("customercode")
                    .HasMaxLength(40);

                entity.Property(e => e.Customerrisk)
                    .HasColumnName("customerrisk")
                    .HasMaxLength(3);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Overduebaht)
                    .HasColumnName("overduebaht")
                    .HasColumnType("numeric(21,5)");

                entity.Property(e => e.Overdueday).HasColumnName("overdueday");

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordServiceOrderDetailOutsource>(entity =>
            {
                entity.ToTable("omsord_service_order_detail_outsource", "dom");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fielddescription)
                    .HasColumnName("fielddescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasColumnName("fieldname")
                    .HasMaxLength(100);

                entity.Property(e => e.Fieldtype)
                    .IsRequired()
                    .HasColumnName("fieldtype")
                    .HasMaxLength(10);

                entity.Property(e => e.Fieldvalue)
                    .HasColumnName("fieldvalue")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<OmsordServiceOrderDetailTransport>(entity =>
            {
                entity.HasKey(e => e.Sonumber)
                    .HasName("omsord_service_order_detail_transport_pkey");

                entity.ToTable("omsord_service_order_detail_transport", "dom");

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Customeramount1)
                    .HasColumnName("customeramount1")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Customeramount2)
                    .HasColumnName("customeramount2")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Customercondition)
                    .HasColumnName("customercondition")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationamphur)
                    .HasColumnName("destinationamphur")
                    .HasMaxLength(4);

                entity.Property(e => e.Destinationamphurname)
                    .HasColumnName("destinationamphurname")
                    .HasMaxLength(100);

                entity.Property(e => e.Destinationcode)
                    .IsRequired()
                    .HasColumnName("destinationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationdistrict)
                    .HasColumnName("destinationdistrict")
                    .HasMaxLength(6);

                entity.Property(e => e.Destinationhouseno)
                    .HasColumnName("destinationhouseno")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Destinationpostalcode)
                    .HasColumnName("destinationpostalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Destinationprovince)
                    .HasColumnName("destinationprovince")
                    .HasMaxLength(2);

                entity.Property(e => e.Destinationprovincename)
                    .HasColumnName("destinationprovincename")
                    .HasMaxLength(100);

                entity.Property(e => e.Destinationreceipient)
                    .HasColumnName("destinationreceipient")
                    .HasMaxLength(50);

                entity.Property(e => e.Destinationregion).HasColumnName("destinationregion");

                entity.Property(e => e.Destinationsoi)
                    .HasColumnName("destinationsoi")
                    .HasMaxLength(88);

                entity.Property(e => e.Destinationstreet)
                    .HasColumnName("destinationstreet")
                    .HasMaxLength(1000);

                entity.Property(e => e.Destinationtelephone)
                    .HasColumnName("destinationtelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Endcustomercode)
                    .HasColumnName("endcustomercode")
                    .HasMaxLength(100);

                entity.Property(e => e.Hublocidlist)
                    .HasColumnName("hublocidlist")
                    .HasMaxLength(250);

                entity.Property(e => e.Licenseplate)
                    .HasColumnName("licenseplate")
                    .HasMaxLength(22);

                entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

                entity.Property(e => e.Outsourcecode)
                    .HasColumnName("outsourcecode")
                    .HasMaxLength(100);

                entity.Property(e => e.Pricingdate)
                    .HasColumnName("pricingdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Pricingdatemethod).HasColumnName("pricingdatemethod");

                entity.Property(e => e.Pricingmodelid).HasColumnName("pricingmodelid");

                entity.Property(e => e.Referenceordernumber)
                    .HasColumnName("referenceordernumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Reflocationcode)
                    .HasColumnName("reflocationcode")
                    .HasMaxLength(64);

                entity.Property(e => e.Reflocationflag)
                    .HasColumnName("reflocationflag")
                    .HasMaxLength(1);

                entity.Property(e => e.Refreturnreasoncode)
                    .HasColumnName("refreturnreasoncode")
                    .HasMaxLength(4);

                entity.Property(e => e.Refshiptocity)
                    .HasColumnName("refshiptocity")
                    .HasMaxLength(140);

                entity.Property(e => e.Refshiptocode)
                    .HasColumnName("refshiptocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Refshiptodistrict)
                    .HasColumnName("refshiptodistrict")
                    .HasMaxLength(140);

                entity.Property(e => e.Refshiptoname)
                    .HasColumnName("refshiptoname")
                    .HasMaxLength(140);

                entity.Property(e => e.Refshiptopostalcode)
                    .HasColumnName("refshiptopostalcode")
                    .HasMaxLength(140);

                entity.Property(e => e.Refshiptoregion)
                    .HasColumnName("refshiptoregion")
                    .HasMaxLength(4);

                entity.Property(e => e.Refshiptostreet)
                    .HasColumnName("refshiptostreet")
                    .HasMaxLength(140);

                entity.Property(e => e.Refshiptotelephone)
                    .HasColumnName("refshiptotelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Refshiptotranzone)
                    .HasColumnName("refshiptotranzone")
                    .HasMaxLength(10);

                entity.Property(e => e.Returnreason).HasColumnName("returnreason");

                entity.Property(e => e.Reworkreason).HasColumnName("reworkreason");

                entity.Property(e => e.Servicelevel).HasColumnName("servicelevel");

                entity.Property(e => e.Shipcondcode)
                    .HasColumnName("shipcondcode")
                    .HasMaxLength(2);

                entity.Property(e => e.Shiptospecialcond)
                    .HasColumnName("shiptospecialcond")
                    .HasMaxLength(50);

                entity.Property(e => e.Transportmode)
                    .IsRequired()
                    .HasColumnName("transportmode")
                    .HasMaxLength(10);

                entity.Property(e => e.Vehicletypecode)
                    .HasColumnName("vehicletypecode")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<OmsordServiceOrderDetailWarehouse>(entity =>
            {
                entity.HasKey(e => e.Sonumber)
                    .HasName("omsord_service_order_detail_warehouse_pkey");

                entity.ToTable("omsord_service_order_detail_warehouse", "dom");

                entity.Property(e => e.Sonumber)
                    .HasColumnName("sonumber")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Expiredate)
                    .HasColumnName("expiredate")
                    .HasMaxLength(37);

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Locationname)
                    .HasColumnName("locationname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Manufacturedate)
                    .HasColumnName("manufacturedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Outsourcecode)
                    .HasColumnName("outsourcecode")
                    .HasMaxLength(100);

                entity.Property(e => e.Stocktypeid).HasColumnName("stocktypeid");

                entity.Property(e => e.Warehousebatchno)
                    .HasColumnName("warehousebatchno")
                    .HasMaxLength(100);

                entity.Property(e => e.Whref1)
                    .HasColumnName("whref1")
                    .HasMaxLength(100);

                entity.Property(e => e.Whref2)
                    .HasColumnName("whref2")
                    .HasMaxLength(100);

                entity.Property(e => e.Whref3)
                    .HasColumnName("whref3")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OmsordServiceOrderItem>(entity =>
            {
                entity.ToTable("omsord_service_order_item", "dom");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Customermaterialcode)
                    .HasColumnName("customermaterialcode")
                    .HasMaxLength(100);

                entity.Property(e => e.Customermaterialname)
                    .HasColumnName("customermaterialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Incoterm)
                    .HasColumnName("incoterm")
                    .HasMaxLength(3);

                entity.Property(e => e.Incoterm2)
                    .HasColumnName("incoterm2")
                    .HasMaxLength(70);

                entity.Property(e => e.Incoterm3)
                    .HasColumnName("incoterm3")
                    .HasMaxLength(70);

                entity.Property(e => e.Iscompensate).HasColumnName("iscompensate");

                entity.Property(e => e.Ispending).HasColumnName("ispending");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Materialbaseunit)
                    .IsRequired()
                    .HasColumnName("materialbaseunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialcode)
                    .IsRequired()
                    .HasColumnName("materialcode")
                    .HasMaxLength(18);

                entity.Property(e => e.Materialfreightgroup)
                    .IsRequired()
                    .HasColumnName("materialfreightgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.Materialgrossweight)
                    .HasColumnName("materialgrossweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Materialname)
                    .HasColumnName("materialname")
                    .HasMaxLength(1000);

                entity.Property(e => e.Materialnetweight)
                    .HasColumnName("materialnetweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Materialpricingunit)
                    .HasColumnName("materialpricingunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Materialvolume)
                    .HasColumnName("materialvolume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Orderdeliverycreatedate)
                    .HasColumnName("orderdeliverycreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.Originamphur)
                    .HasColumnName("originamphur")
                    .HasMaxLength(4);

                entity.Property(e => e.Origincode)
                    .IsRequired()
                    .HasColumnName("origincode")
                    .HasMaxLength(10);

                entity.Property(e => e.Origindistrict)
                    .HasColumnName("origindistrict")
                    .HasMaxLength(6);

                entity.Property(e => e.Originhouseno)
                    .HasColumnName("originhouseno")
                    .HasMaxLength(20);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(100);

                entity.Property(e => e.Originpostalcode)
                    .HasColumnName("originpostalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Originprovince)
                    .HasColumnName("originprovince")
                    .HasMaxLength(2);

                entity.Property(e => e.Originregion).HasColumnName("originregion");

                entity.Property(e => e.Originsoi)
                    .HasColumnName("originsoi")
                    .HasMaxLength(88);

                entity.Property(e => e.Originstreet)
                    .HasColumnName("originstreet")
                    .HasMaxLength(500);

                entity.Property(e => e.Palletid)
                    .HasColumnName("palletid")
                    .HasMaxLength(100);

                entity.Property(e => e.Pricingquantity)
                    .HasColumnName("pricingquantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Refconditiontype)
                    .HasColumnName("refconditiontype")
                    .HasMaxLength(10);

                entity.Property(e => e.Refpercentrate)
                    .HasColumnName("refpercentrate")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Refplantcode)
                    .HasColumnName("refplantcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Refpricecurrency)
                    .HasColumnName("refpricecurrency")
                    .HasMaxLength(10);

                entity.Property(e => e.Refproductprice)
                    .HasColumnName("refproductprice")
                    .HasMaxLength(256);

                entity.Property(e => e.Refproductpricerate)
                    .HasColumnName("refproductpricerate")
                    .HasMaxLength(256);

                entity.Property(e => e.Refproductpricingdate)
                    .HasColumnName("refproductpricingdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Refshippingpoint)
                    .HasColumnName("refshippingpoint")
                    .HasMaxLength(4);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Totalgrossweight)
                    .HasColumnName("totalgrossweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Totalnetweight)
                    .HasColumnName("totalnetweight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Totalquantity)
                    .HasColumnName("totalquantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Volumeunit)
                    .IsRequired()
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .IsRequired()
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmsordServiceOrderItemSchedule>(entity =>
            {
                entity.HasKey(e => new { e.Soitemid, e.Scheduleid })
                    .HasName("omsord_service_order_item_schedule_pkey");

                entity.ToTable("omsord_service_order_item_schedule", "dom");

                entity.Property(e => e.Soitemid).HasColumnName("soitemid");

                entity.Property(e => e.Scheduleid).HasColumnName("scheduleid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(15,3)");
            });

            modelBuilder.Entity<OmsordServiceOrderItemShipMark>(entity =>
            {
                entity.ToTable("omsord_service_order_item_ship_mark", "dom");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Palletid)
                    .HasColumnName("palletid")
                    .HasMaxLength(100);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Shippingmark)
                    .IsRequired()
                    .HasColumnName("shippingmark")
                    .HasMaxLength(512);

                entity.Property(e => e.Soitemid).HasColumnName("soitemid");
            });

            modelBuilder.Entity<OmsordServiceOrderSchedule>(entity =>
            {
                entity.ToTable("omsord_service_order_schedule", "dom");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.Deliverycreatedate)
                    .HasColumnName("deliverycreatedate")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Plandeliverydate)
                    .HasColumnName("plandeliverydate")
                    .HasMaxLength(37);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.Requesteddate)
                    .HasColumnName("requesteddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Scheduleno).HasColumnName("scheduleno");

                entity.Property(e => e.Sonumber)
                    .IsRequired()
                    .HasColumnName("sonumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");

                entity.Property(e => e.Transferdmflag).HasColumnName("transferdmflag");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordTmsShipment>(entity =>
            {
                entity.HasKey(e => new { e.Shipmentnumber, e.Systemshipmentlegid })
                    .HasName("omsord_tms_shipment_pkey");

                entity.ToTable("omsord_tms_shipment", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_tms_shipment_dms_rep_dtt_idx");

                entity.Property(e => e.Shipmentnumber)
                    .HasColumnName("shipmentnumber")
                    .HasMaxLength(15);

                entity.Property(e => e.Systemshipmentlegid)
                    .HasColumnName("systemshipmentlegid")
                    .HasMaxLength(28);

                entity.Property(e => e.Accepttenderedupdateddate)
                    .HasColumnName("accepttenderedupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.Createdshipmentdate)
                    .HasColumnName("createdshipmentdate")
                    .HasMaxLength(37);

                entity.Property(e => e.Currentshipmentopstatus)
                    .HasColumnName("currentshipmentopstatus")
                    .HasMaxLength(20);

                entity.Property(e => e.Currentshipmentopstatusdescription)
                    .HasColumnName("currentshipmentopstatusdescription")
                    .HasMaxLength(200);

                entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Equipmenttype)
                    .HasColumnName("equipmenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Intransitupdateddate)
                    .HasColumnName("intransitupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Loadcompletedupdateddate)
                    .HasColumnName("loadcompletedupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Omslegid).HasColumnName("omslegid");

                entity.Property(e => e.Onholdflag).HasColumnName("onholdflag");

                entity.Property(e => e.Sapshipmentnumber)
                    .HasColumnName("sapshipmentnumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Shipmentitineraryseqnum).HasColumnName("shipmentitineraryseqnum");

                entity.Property(e => e.Shipmentsequencenumber)
                    .HasColumnName("shipmentsequencenumber")
                    .HasMaxLength(10);

                entity.Property(e => e.Stoplocationcode)
                    .HasColumnName("stoplocationcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Stopsequencenumber).HasColumnName("stopsequencenumber");

                entity.Property(e => e.Stopshippingpointtype)
                    .HasColumnName("stopshippingpointtype")
                    .HasMaxLength(20);

                entity.Property(e => e.Suspendedflag).HasColumnName("suspendedflag");

                entity.Property(e => e.Suspendedreason)
                    .HasColumnName("suspendedreason")
                    .HasMaxLength(2000);

                entity.Property(e => e.Systemshipmentid)
                    .IsRequired()
                    .HasColumnName("systemshipmentid")
                    .HasMaxLength(28);

                entity.Property(e => e.Systemshipmentloadid)
                    .HasColumnName("systemshipmentloadid")
                    .HasMaxLength(28);

                entity.Property(e => e.Systemstopid)
                    .HasColumnName("systemstopid")
                    .HasMaxLength(20);

                entity.Property(e => e.Tenderedupdateddate)
                    .HasColumnName("tenderedupdateddate")
                    .HasMaxLength(37);

                entity.Property(e => e.Totaldistance)
                    .HasColumnName("totaldistance")
                    .HasColumnType("numeric(6,1)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmsordTransportService>(entity =>
            {
                entity.HasKey(e => new { e.Transportid, e.Arrivalday, e.Departureday })
                    .HasName("omsord_transport_service_pkey");

                entity.ToTable("omsord_transport_service", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_transport_service_dms_rep_dtt_idx");

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.Arrivalday)
                    .HasColumnName("arrivalday")
                    .HasMaxLength(10);

                entity.Property(e => e.Departureday)
                    .HasColumnName("departureday")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordTransportServiceExpress>(entity =>
            {
                entity.HasKey(e => new { e.Transportid, e.Serviceid })
                    .HasName("omsord_transport_service_express_pkey");

                entity.ToTable("omsord_transport_service_express", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_transport_service_express_dms_rep_dtt_idx");

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceid)
                    .HasColumnName("serviceid")
                    .HasMaxLength(10);

                entity.Property(e => e.Cutofftime)
                    .IsRequired()
                    .HasColumnName("cutofftime")
                    .HasMaxLength(16);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordTransportServiceExpressInsource>(entity =>
            {
                entity.HasKey(e => new { e.Transportid, e.Serviceid, e.Logisticid })
                    .HasName("omsord_transport_service_express_insource_pkey");

                entity.ToTable("omsord_transport_service_express_insource", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_transport_service_express_insource_dms_rep_dtt_idx");

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceid)
                    .HasColumnName("serviceid")
                    .HasMaxLength(10);

                entity.Property(e => e.Logisticid).HasColumnName("logisticid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordTransportServiceExpressOutsource>(entity =>
            {
                entity.HasKey(e => new { e.Transportid, e.Serviceid, e.Logisticid })
                    .HasName("omsord_transport_service_express_outsource_pkey");

                entity.ToTable("omsord_transport_service_express_outsource", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_transport_service_express_outsource_dms_rep_dtt_idx");

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.Serviceid)
                    .HasColumnName("serviceid")
                    .HasMaxLength(10);

                entity.Property(e => e.Logisticid).HasColumnName("logisticid");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Ordering).HasColumnName("ordering");
            });

            modelBuilder.Entity<OmsordTransportServiceLeadtime>(entity =>
            {
                entity.HasKey(e => e.Transportid)
                    .HasName("omsord_transport_service_leadtime_pkey");

                entity.ToTable("omsord_transport_service_leadtime", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_transport_service_leadtime_dms_rep_dtt_idx");

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Leadtime).HasColumnName("leadtime");
            });

            modelBuilder.Entity<OmsordTransportServiceWindow>(entity =>
            {
                entity.HasKey(e => new { e.Transportid, e.Arrivalday, e.Departureday })
                    .HasName("omsord_transport_service_window_pkey");

                entity.ToTable("omsord_transport_service_window", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_transport_service_window_dms_rep_dtt_idx");

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.Arrivalday)
                    .HasColumnName("arrivalday")
                    .HasMaxLength(10);

                entity.Property(e => e.Departureday)
                    .HasColumnName("departureday")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<OmsordTransportTruckType>(entity =>
            {
                entity.HasKey(e => new { e.Transportid, e.Truckid, e.Truckpriority })
                    .HasName("omsord_transport_truck_type_pkey");

                entity.ToTable("omsord_transport_truck_type", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omsord_transport_truck_type_dms_rep_dtt_idx");

                entity.Property(e => e.Transportid)
                    .HasColumnName("transportid")
                    .HasMaxLength(10);

                entity.Property(e => e.Truckid)
                    .HasColumnName("truckid")
                    .HasMaxLength(20);

                entity.Property(e => e.Truckpriority).HasColumnName("truckpriority");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Limitvolume)
                    .HasColumnName("limitvolume")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Limitweight)
                    .HasColumnName("limitweight")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.Volumeunit)
                    .IsRequired()
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .IsRequired()
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OmswmpSapTmsMfgrCdtyConfig>(entity =>
            {
                entity.HasKey(e => e.SapCdtyCd)
                    .HasName("omswmp_sap_tms_mfgr_cdty_config_pkey");

                entity.ToTable("omswmp_sap_tms_mfgr_cdty_config", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omswmp_sap_tms_mfgr_cdty_config_dms_rep_dtt_idx");

                entity.Property(e => e.SapCdtyCd)
                    .HasColumnName("sap_cdty_cd")
                    .HasMaxLength(72)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.FcCd)
                    .HasColumnName("fc_cd")
                    .HasMaxLength(10);

                entity.Property(e => e.OptLck).HasColumnName("opt_lck");

                entity.Property(e => e.TmCdtyCd)
                    .HasColumnName("tm_cdty_cd")
                    .HasMaxLength(48);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmswmpSapTmsMfgrDivConfig>(entity =>
            {
                entity.HasKey(e => e.SapMfgCode)
                    .HasName("omswmp_sap_tms_mfgr_div_config_pkey");

                entity.ToTable("omswmp_sap_tms_mfgr_div_config", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omswmp_sap_tms_mfgr_div_config_dms_rep_dtt_idx");

                entity.Property(e => e.SapMfgCode)
                    .HasColumnName("sap_mfg_code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.TmsDivCode)
                    .HasColumnName("tms_div_code")
                    .HasMaxLength(16);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmswmpTmsCdty>(entity =>
            {
                entity.HasKey(e => e.CdtyCd)
                    .HasName("omswmp_tms_cdty_pkey");

                entity.ToTable("omswmp_tms_cdty", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omswmp_tms_cdty_dms_rep_dtt_idx");

                entity.Property(e => e.CdtyCd)
                    .HasColumnName("cdty_cd")
                    .HasMaxLength(48)
                    .ValueGeneratedNever();

                entity.Property(e => e.CdtyDesc)
                    .HasColumnName("cdty_desc")
                    .HasMaxLength(280);

                entity.Property(e => e.CdtyPickSeqNum).HasColumnName("cdty_pick_seq_num");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasMaxLength(37);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.EdiCdtyCdTyp).HasColumnName("edi_cdty_cd_typ");

                entity.Property(e => e.ExtlCd)
                    .HasColumnName("extl_cd")
                    .HasMaxLength(120);

                entity.Property(e => e.HzdsYn)
                    .HasColumnName("hzds_yn")
                    .HasMaxLength(1);

                entity.Property(e => e.OptLck).HasColumnName("opt_lck");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasMaxLength(37);
            });

            modelBuilder.Entity<OmswmpTmsPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId)
                    .HasName("omswmp_tms_plan_pkey");

                entity.ToTable("omswmp_tms_plan", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("omswmp_tms_plan_dms_rep_dtt_idx");

                entity.Property(e => e.PlanId)
                    .HasColumnName("plan_id")
                    .HasMaxLength(16)
                    .ValueGeneratedNever();

                entity.Property(e => e.CrtdDtt)
                    .IsRequired()
                    .HasColumnName("crtd_dtt")
                    .HasMaxLength(37);

                entity.Property(e => e.CrtdUsrCd)
                    .HasColumnName("crtd_usr_cd")
                    .HasMaxLength(40);

                entity.Property(e => e.DivCd)
                    .HasColumnName("div_cd")
                    .HasMaxLength(16);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.LgstGrpCd)
                    .HasColumnName("lgst_grp_cd")
                    .HasMaxLength(16);

                entity.Property(e => e.PlanDesc)
                    .HasColumnName("plan_desc")
                    .HasMaxLength(280);

                entity.Property(e => e.StatEnu)
                    .HasColumnName("stat_enu")
                    .HasMaxLength(280);

                entity.Property(e => e.UpdtDtt)
                    .HasColumnName("updt_dtt")
                    .HasMaxLength(37);

                entity.Property(e => e.UpdtUsrCd)
                    .HasColumnName("updt_usr_cd")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<PoddatAbnormality>(entity =>
            {
                entity.HasKey(e => e.Caseno)
                    .HasName("poddat_abnormality_pkey");

                entity.ToTable("poddat_abnormality", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_abnormality_dms_rep_dtt_idx");

                entity.Property(e => e.Caseno)
                    .HasColumnName("caseno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Driverlecense)
                    .IsRequired()
                    .HasColumnName("driverlecense")
                    .HasMaxLength(50);

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Reasoncode)
                    .IsRequired()
                    .HasColumnName("reasoncode")
                    .HasMaxLength(20);

                entity.Property(e => e.Remarktext)
                    .HasColumnName("remarktext")
                    .HasMaxLength(300);

                entity.Property(e => e.Trucklicense)
                    .IsRequired()
                    .HasColumnName("trucklicense")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PoddatCheckedpoint>(entity =>
            {
                entity.HasKey(e => new { e.Shipmentno, e.Locationtype, e.Locationcode })
                    .HasName("poddat_checkedpoint_pkey");

                entity.ToTable("poddat_checkedpoint", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_checkedpoint_dms_rep_dtt_idx");

                entity.Property(e => e.Shipmentno)
                    .HasColumnName("shipmentno")
                    .HasMaxLength(20);

                entity.Property(e => e.Locationtype)
                    .HasColumnName("locationtype")
                    .HasMaxLength(20);

                entity.Property(e => e.Locationcode)
                    .HasColumnName("locationcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Checkindate)
                    .HasColumnName("checkindate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Checkinlatitude).HasColumnName("checkinlatitude");

                entity.Property(e => e.Checkinlongitude).HasColumnName("checkinlongitude");

                entity.Property(e => e.Checkinuser)
                    .HasColumnName("checkinuser")
                    .HasMaxLength(30);

                entity.Property(e => e.Checkoutdate)
                    .HasColumnName("checkoutdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Checkoutlatitude).HasColumnName("checkoutlatitude");

                entity.Property(e => e.Checkoutlongitude).HasColumnName("checkoutlongitude");

                entity.Property(e => e.Checkoutuser)
                    .HasColumnName("checkoutuser")
                    .HasMaxLength(30);

                entity.Property(e => e.Confirmdocdate)
                    .HasColumnName("confirmdocdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Confirmpicdate)
                    .HasColumnName("confirmpicdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Confirmqtydate)
                    .HasColumnName("confirmqtydate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Confirmsigdate)
                    .HasColumnName("confirmsigdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Driverlicense)
                    .IsRequired()
                    .HasColumnName("driverlicense")
                    .HasMaxLength(20);

                entity.Property(e => e.Trucklicense)
                    .IsRequired()
                    .HasColumnName("trucklicense")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PoddatCustomer>(entity =>
            {
                entity.HasKey(e => e.Customercode)
                    .HasName("poddat_customer_pkey");

                entity.ToTable("poddat_customer", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_customer_dms_rep_dtt_idx");

                entity.Property(e => e.Customercode)
                    .HasColumnName("customercode")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasColumnName("customername")
                    .HasMaxLength(300);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fulladdress)
                    .HasColumnName("fulladdress")
                    .HasMaxLength(500);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PoddatDamageheader>(entity =>
            {
                entity.HasKey(e => e.Documentno)
                    .HasName("poddat_damageheader_pkey");

                entity.ToTable("poddat_damageheader", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_damageheader_dms_rep_dtt_idx");

                entity.Property(e => e.Documentno)
                    .HasColumnName("documentno")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .IsRequired()
                    .HasColumnName("createduser")
                    .HasMaxLength(50);

                entity.Property(e => e.Damagestatus)
                    .HasColumnName("damagestatus")
                    .HasMaxLength(10);

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Manager)
                    .HasColumnName("manager")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PoddatDamageitem>(entity =>
            {
                entity.HasKey(e => new { e.Shipmentno, e.Deliveryno, e.Deliveryitem })
                    .HasName("poddat_damageitem_pkey");

                entity.ToTable("poddat_damageitem", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_damageitem_dms_rep_dtt_idx");

                entity.Property(e => e.Shipmentno)
                    .HasColumnName("shipmentno")
                    .HasMaxLength(20);

                entity.Property(e => e.Deliveryno)
                    .HasColumnName("deliveryno")
                    .HasMaxLength(20);

                entity.Property(e => e.Deliveryitem)
                    .HasColumnName("deliveryitem")
                    .HasMaxLength(6);

                entity.Property(e => e.Apcdebitamount)
                    .HasColumnName("apcdebitamount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Apcreditamount)
                    .HasColumnName("apcreditamount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Arcdebitamount)
                    .HasColumnName("arcdebitamount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Arcreditamount)
                    .HasColumnName("arcreditamount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Damagecause)
                    .IsRequired()
                    .HasColumnName("damagecause")
                    .HasMaxLength(3);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Documentno)
                    .IsRequired()
                    .HasColumnName("documentno")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PoddatDeliveryitem>(entity =>
            {
                entity.HasKey(e => new { e.Deliveryno, e.Deliveryitem })
                    .HasName("poddat_deliveryitem_pkey");

                entity.ToTable("poddat_deliveryitem", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_deliveryitem_dms_rep_dtt_idx");

                entity.Property(e => e.Deliveryno)
                    .HasColumnName("deliveryno")
                    .HasMaxLength(20);

                entity.Property(e => e.Deliveryitem)
                    .HasColumnName("deliveryitem")
                    .HasMaxLength(6);

                entity.Property(e => e.Commuditycode)
                    .HasColumnName("commuditycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Damageqty)
                    .HasColumnName("damageqty")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Damageunit)
                    .HasColumnName("damageunit")
                    .HasMaxLength(10);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Documentno)
                    .HasColumnName("documentno")
                    .HasMaxLength(20);

                entity.Property(e => e.Isdamageitem).HasColumnName("isdamageitem");

                entity.Property(e => e.Isreturnitem).HasColumnName("isreturnitem");

                entity.Property(e => e.Itemcode)
                    .IsRequired()
                    .HasColumnName("itemcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Itemquantity)
                    .HasColumnName("itemquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Itemtext)
                    .IsRequired()
                    .HasColumnName("itemtext")
                    .HasMaxLength(200);

                entity.Property(e => e.Itemvolume)
                    .HasColumnName("itemvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Itemweight)
                    .HasColumnName("itemweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Plantcode)
                    .HasColumnName("plantcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Quantityunit)
                    .HasColumnName("quantityunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Returnqty)
                    .HasColumnName("returnqty")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Returnunit)
                    .HasColumnName("returnunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Sapgrossweight)
                    .HasColumnName("sapgrossweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Sapitemquantity)
                    .HasColumnName("sapitemquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Unitquantity)
                    .HasColumnName("unitquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Unitvolume)
                    .HasColumnName("unitvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Unitweight)
                    .HasColumnName("unitweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PoddatDeliverynote>(entity =>
            {
                entity.HasKey(e => new { e.Shipmentno, e.Deliveryno })
                    .HasName("poddat_deliverynote_pkey");

                entity.ToTable("poddat_deliverynote", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_deliverynote_dms_rep_dtt_idx");

                entity.HasIndex(e => e.Salesorder)
                    .HasName("so_idx");

                entity.Property(e => e.Shipmentno)
                    .HasColumnName("shipmentno")
                    .HasMaxLength(20);

                entity.Property(e => e.Deliveryno)
                    .HasColumnName("deliveryno")
                    .HasMaxLength(20);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Commuditycode)
                    .HasColumnName("commuditycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Damageremark)
                    .HasColumnName("damageremark")
                    .HasMaxLength(300);

                entity.Property(e => e.Deliverydate)
                    .HasColumnName("deliverydate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Deliveryleg)
                    .HasColumnName("deliveryleg")
                    .HasMaxLength(6);

                entity.Property(e => e.Deliveryremark)
                    .HasColumnName("deliveryremark")
                    .HasMaxLength(300);

                entity.Property(e => e.Deliverystatus)
                    .HasColumnName("deliverystatus")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationaddr)
                    .HasColumnName("destinationaddr")
                    .HasMaxLength(300);

                entity.Property(e => e.Destinationcode)
                    .HasColumnName("destinationcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Destinationname)
                    .HasColumnName("destinationname")
                    .HasMaxLength(200);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dropstopseqno).HasColumnName("dropstopseqno");

                entity.Property(e => e.Exitdate)
                    .HasColumnName("exitdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Exitweight)
                    .HasColumnName("exitweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Incoterm)
                    .HasColumnName("incoterm")
                    .HasMaxLength(10);

                entity.Property(e => e.Isallreturngoods).HasColumnName("isallreturngoods");

                entity.Property(e => e.Isswitching).HasColumnName("isswitching");

                entity.Property(e => e.Laststatusdate)
                    .HasColumnName("laststatusdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Originaddr)
                    .HasColumnName("originaddr")
                    .HasMaxLength(300);

                entity.Property(e => e.Origincode)
                    .HasColumnName("origincode")
                    .HasMaxLength(20);

                entity.Property(e => e.Originname)
                    .HasColumnName("originname")
                    .HasMaxLength(200);

                entity.Property(e => e.Paymentterm)
                    .HasColumnName("paymentterm")
                    .HasMaxLength(20);

                entity.Property(e => e.Personalrating).HasColumnName("personalrating");

                entity.Property(e => e.Personalremark)
                    .HasColumnName("personalremark")
                    .HasMaxLength(300);

                entity.Property(e => e.Pickstopseqno).HasColumnName("pickstopseqno");

                entity.Property(e => e.Poservice)
                    .HasColumnName("poservice")
                    .HasMaxLength(70);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Postalkey)
                    .HasColumnName("postalkey")
                    .HasMaxLength(20);

                entity.Property(e => e.Productgroup)
                    .HasColumnName("productgroup")
                    .HasMaxLength(50);

                entity.Property(e => e.Purchaseorder)
                    .HasColumnName("purchaseorder")
                    .HasMaxLength(50);

                entity.Property(e => e.Receivertel)
                    .HasColumnName("receivertel")
                    .HasMaxLength(20);

                entity.Property(e => e.Regioncode)
                    .HasColumnName("regioncode")
                    .HasMaxLength(20);

                entity.Property(e => e.Regionname)
                    .HasColumnName("regionname")
                    .HasMaxLength(200);

                entity.Property(e => e.Requesteddate)
                    .HasColumnName("requesteddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Returnremark)
                    .HasColumnName("returnremark")
                    .HasMaxLength(300);

                entity.Property(e => e.Salesorder)
                    .HasColumnName("salesorder")
                    .HasMaxLength(20);

                entity.Property(e => e.Salesorg)
                    .HasColumnName("salesorg")
                    .HasMaxLength(20);

                entity.Property(e => e.Sapbayindate)
                    .HasColumnName("sapbayindate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sapbayno)
                    .HasColumnName("sapbayno")
                    .HasMaxLength(20);

                entity.Property(e => e.Sapbayoutdate)
                    .HasColumnName("sapbayoutdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sapgidate)
                    .HasColumnName("sapgidate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sapgistatus)
                    .HasColumnName("sapgistatus")
                    .HasMaxLength(20);

                entity.Property(e => e.Sapgiweight)
                    .HasColumnName("sapgiweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Sappickdate)
                    .HasColumnName("sappickdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Sappickstatus)
                    .HasColumnName("sappickstatus")
                    .HasMaxLength(20);

                entity.Property(e => e.Sapsealno)
                    .HasColumnName("sapsealno")
                    .HasMaxLength(100);

                entity.Property(e => e.Sapshiptocode)
                    .HasColumnName("sapshiptocode")
                    .HasMaxLength(20);

                entity.Property(e => e.Sapshiptoname)
                    .HasColumnName("sapshiptoname")
                    .HasMaxLength(300);

                entity.Property(e => e.Saptaredate)
                    .HasColumnName("saptaredate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Saptareweight)
                    .HasColumnName("saptareweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Servicerating).HasColumnName("servicerating");

                entity.Property(e => e.Serviceremark)
                    .HasColumnName("serviceremark")
                    .HasMaxLength(300);

                entity.Property(e => e.Shipmentdate)
                    .HasColumnName("shipmentdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Shipmentmemo)
                    .HasColumnName("shipmentmemo")
                    .HasMaxLength(600);

                entity.Property(e => e.Shippingaddr)
                    .HasColumnName("shippingaddr")
                    .HasMaxLength(300);

                entity.Property(e => e.Shippingcode)
                    .IsRequired()
                    .HasColumnName("shippingcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Shippingname)
                    .HasColumnName("shippingname")
                    .HasMaxLength(200);

                entity.Property(e => e.Shippingtel)
                    .HasColumnName("shippingtel")
                    .HasMaxLength(100);

                entity.Property(e => e.Shiptoaddr)
                    .HasColumnName("shiptoaddr")
                    .HasMaxLength(300);

                entity.Property(e => e.Shiptocode)
                    .IsRequired()
                    .HasColumnName("shiptocode")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptoname)
                    .IsRequired()
                    .HasColumnName("shiptoname")
                    .HasMaxLength(200);

                entity.Property(e => e.Shiptotel)
                    .HasColumnName("shiptotel")
                    .HasMaxLength(100);

                entity.Property(e => e.Soldtoaddr)
                    .HasColumnName("soldtoaddr")
                    .HasMaxLength(300);

                entity.Property(e => e.Soldtocode)
                    .HasColumnName("soldtocode")
                    .HasMaxLength(20);

                entity.Property(e => e.Soldtoname)
                    .HasColumnName("soldtoname")
                    .HasMaxLength(200);

                entity.Property(e => e.Soldtopostalcode)
                    .HasColumnName("soldtopostalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Soldtoregion)
                    .HasColumnName("soldtoregion")
                    .HasMaxLength(5);

                entity.Property(e => e.Soldtotel)
                    .HasColumnName("soldtotel")
                    .HasMaxLength(100);

                entity.Property(e => e.Statusremark)
                    .HasColumnName("statusremark")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<PoddatEbooking>(entity =>
            {
                entity.HasKey(e => e.Bookingno)
                    .HasName("poddat_ebooking_pkey");

                entity.ToTable("poddat_ebooking", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_ebooking_dms_rep_dtt_idx");

                entity.Property(e => e.Bookingno)
                    .HasColumnName("bookingno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Documentno)
                    .IsRequired()
                    .HasColumnName("documentno")
                    .HasMaxLength(20);

                entity.Property(e => e.Driverlecense)
                    .IsRequired()
                    .HasColumnName("driverlecense")
                    .HasMaxLength(50);

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Referenceno)
                    .HasColumnName("referenceno")
                    .HasMaxLength(20);

                entity.Property(e => e.Remarktext)
                    .HasColumnName("remarktext")
                    .HasMaxLength(300);

                entity.Property(e => e.Trucklicense)
                    .IsRequired()
                    .HasColumnName("trucklicense")
                    .HasMaxLength(50);

                entity.Property(e => e.Weightafter).HasColumnName("weightafter");

                entity.Property(e => e.Weightbefor).HasColumnName("weightbefor");
            });

            modelBuilder.Entity<PoddatEdoclogged>(entity =>
            {
                entity.HasKey(e => e.Loggedid)
                    .HasName("poddat_edoclogged_pkey");

                entity.ToTable("poddat_edoclogged", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_edoclogged_dms_rep_dtt_idx");

                entity.Property(e => e.Loggedid)
                    .HasColumnName("loggedid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Documentno)
                    .IsRequired()
                    .HasColumnName("documentno")
                    .HasMaxLength(20);

                entity.Property(e => e.Documenttype)
                    .IsRequired()
                    .HasColumnName("documenttype")
                    .HasMaxLength(20);

                entity.Property(e => e.Loggeddate)
                    .HasColumnName("loggeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Loggedinuser)
                    .IsRequired()
                    .HasColumnName("loggedinuser")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PoddatMstcarrier>(entity =>
            {
                entity.HasKey(e => e.Carriercode)
                    .HasName("poddat_mstcarrier_pkey");

                entity.ToTable("poddat_mstcarrier", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstcarrier_dms_rep_dtt_idx");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Addresscity)
                    .HasColumnName("addresscity")
                    .HasMaxLength(200);

                entity.Property(e => e.Addressno)
                    .HasColumnName("addressno")
                    .HasMaxLength(200);

                entity.Property(e => e.Carriername)
                    .IsRequired()
                    .HasColumnName("carriername")
                    .HasMaxLength(300);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("emailaddress")
                    .HasMaxLength(50);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Regioncode)
                    .HasColumnName("regioncode")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<PoddatMstcarrierorigins>(entity =>
            {
                entity.HasKey(e => new { e.Carriercode, e.Shippingcode })
                    .HasName("poddat_mstcarrierorigins_pkey");

                entity.ToTable("poddat_mstcarrierorigins", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstcarrierorigins_dms_rep_dtt_idx");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(20);

                entity.Property(e => e.Shippingcode)
                    .HasColumnName("shippingcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoddatMstcommudity>(entity =>
            {
                entity.HasKey(e => e.Commuditycode)
                    .HasName("poddat_mstcommudity_pkey");

                entity.ToTable("poddat_mstcommudity", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstcommudity_dms_rep_dtt_idx");

                entity.Property(e => e.Commuditycode)
                    .HasColumnName("commuditycode")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Commuditydesc)
                    .IsRequired()
                    .HasColumnName("commuditydesc")
                    .HasMaxLength(300);

                entity.Property(e => e.Commudityedi)
                    .HasColumnName("commudityedi")
                    .HasMaxLength(200);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Externalcode)
                    .HasColumnName("externalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Ishazardous).HasColumnName("ishazardous");

                entity.Property(e => e.Pickquantity)
                    .HasColumnName("pickquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Referencetype)
                    .HasColumnName("referencetype")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<PoddatMstcommumfgs>(entity =>
            {
                entity.HasKey(e => new { e.Commuditycode, e.Mfgcode })
                    .HasName("poddat_mstcommumfgs_pkey");

                entity.ToTable("poddat_mstcommumfgs", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstcommumfgs_dms_rep_dtt_idx");

                entity.Property(e => e.Commuditycode)
                    .HasColumnName("commuditycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Mfgcode)
                    .HasColumnName("mfgcode")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoddatMstdepartment>(entity =>
            {
                entity.HasKey(e => new { e.Departmentcode, e.Functioncode })
                    .HasName("poddat_mstdepartment_pkey");

                entity.ToTable("poddat_mstdepartment", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstdepartment_dms_rep_dtt_idx");

                entity.Property(e => e.Departmentcode)
                    .HasColumnName("departmentcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Functioncode)
                    .HasColumnName("functioncode")
                    .HasMaxLength(10);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Departmentname)
                    .IsRequired()
                    .HasColumnName("departmentname")
                    .HasMaxLength(500);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isactive).HasColumnName("isactive");
            });

            modelBuilder.Entity<PoddatMstdriver>(entity =>
            {
                entity.HasKey(e => e.Citizenid)
                    .HasName("poddat_mstdriver_pkey");

                entity.ToTable("poddat_mstdriver", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstdriver_dms_rep_dtt_idx");

                entity.Property(e => e.Citizenid)
                    .HasColumnName("citizenid")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Acceptstatus)
                    .HasColumnName("acceptstatus")
                    .HasMaxLength(50);

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(100);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Drivertype)
                    .HasColumnName("drivertype")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Expiredate)
                    .HasColumnName("expiredate")
                    .HasMaxLength(10);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(200);

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(200);

                entity.Property(e => e.Fullplate)
                    .HasColumnName("fullplate")
                    .HasMaxLength(50);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Jobcomplete).HasColumnName("jobcomplete");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(200);

                entity.Property(e => e.Nametitle)
                    .HasColumnName("nametitle")
                    .HasMaxLength(50);

                entity.Property(e => e.Provinceid)
                    .HasColumnName("provinceid")
                    .HasMaxLength(10);

                entity.Property(e => e.Provincename)
                    .HasColumnName("provincename")
                    .HasMaxLength(50);

                entity.Property(e => e.Shortprovince)
                    .HasColumnName("shortprovince")
                    .HasMaxLength(10);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Trucklicense)
                    .HasColumnName("trucklicense")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PoddatMstfleet>(entity =>
            {
                entity.HasKey(e => e.Fleetcode)
                    .HasName("poddat_mstfleet_pkey");

                entity.ToTable("poddat_mstfleet", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstfleet_dms_rep_dtt_idx");

                entity.Property(e => e.Fleetcode)
                    .HasColumnName("fleetcode")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fleetname)
                    .IsRequired()
                    .HasColumnName("fleetname")
                    .HasMaxLength(200);

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Isactive).HasColumnName("isactive");
            });

            modelBuilder.Entity<PoddatMstfleetcarriers>(entity =>
            {
                entity.HasKey(e => new { e.Fleetcode, e.Carriercode })
                    .HasName("poddat_mstfleetcarriers_pkey");

                entity.ToTable("poddat_mstfleetcarriers", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstfleetcarriers_dms_rep_dtt_idx");

                entity.Property(e => e.Fleetcode)
                    .HasColumnName("fleetcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoddatMstfleetorigins>(entity =>
            {
                entity.HasKey(e => new { e.Fleetcode, e.Shippingcode })
                    .HasName("poddat_mstfleetorigins_pkey");

                entity.ToTable("poddat_mstfleetorigins", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstfleetorigins_dms_rep_dtt_idx");

                entity.Property(e => e.Fleetcode)
                    .HasColumnName("fleetcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Shippingcode)
                    .HasColumnName("shippingcode")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoddatMstmanager>(entity =>
            {
                entity.HasKey(e => new { e.Managercode, e.Functioncode })
                    .HasName("poddat_mstmanager_pkey");

                entity.ToTable("poddat_mstmanager", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstmanager_dms_rep_dtt_idx");

                entity.Property(e => e.Managercode)
                    .HasColumnName("managercode")
                    .HasMaxLength(20);

                entity.Property(e => e.Functioncode)
                    .HasColumnName("functioncode")
                    .HasMaxLength(10);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Departmentcode)
                    .HasColumnName("departmentcode")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Managername)
                    .IsRequired()
                    .HasColumnName("managername")
                    .HasMaxLength(500);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<PoddatMstproducttype>(entity =>
            {
                entity.HasKey(e => e.Productcode)
                    .HasName("poddat_mstproducttype_pkey");

                entity.ToTable("poddat_mstproducttype", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstproducttype_dms_rep_dtt_idx");

                entity.Property(e => e.Productcode)
                    .HasColumnName("productcode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Productname)
                    .IsRequired()
                    .HasColumnName("productname")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PoddatMstregion>(entity =>
            {
                entity.HasKey(e => e.Regioncode)
                    .HasName("poddat_mstregion_pkey");

                entity.ToTable("poddat_mstregion", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstregion_dms_rep_dtt_idx");

                entity.Property(e => e.Regioncode)
                    .HasColumnName("regioncode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Regionname)
                    .IsRequired()
                    .HasColumnName("regionname")
                    .HasMaxLength(200);

                entity.Property(e => e.Regionnameen)
                    .HasColumnName("regionnameen")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PoddatMstsaleorg>(entity =>
            {
                entity.HasKey(e => e.Saleorgcode)
                    .HasName("poddat_mstsaleorg_pkey");

                entity.ToTable("poddat_mstsaleorg", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstsaleorg_dms_rep_dtt_idx");

                entity.Property(e => e.Saleorgcode)
                    .HasColumnName("saleorgcode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Addressno)
                    .HasColumnName("addressno")
                    .HasMaxLength(200);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Cosaleorg)
                    .HasColumnName("cosaleorg")
                    .HasMaxLength(10);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(200);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(200);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(20);

                entity.Property(e => e.Saleorgname)
                    .IsRequired()
                    .HasColumnName("saleorgname")
                    .HasMaxLength(300);

                entity.Property(e => e.Searchkey)
                    .HasColumnName("searchkey")
                    .HasMaxLength(20);

                entity.Property(e => e.Searchterm)
                    .HasColumnName("searchterm")
                    .HasMaxLength(20);

                entity.Property(e => e.Shortname)
                    .HasColumnName("shortname")
                    .HasMaxLength(100);

                entity.Property(e => e.Taxid)
                    .HasColumnName("taxid")
                    .HasMaxLength(20);

                entity.Property(e => e.Transpzone)
                    .HasColumnName("transpzone")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PoddatMsttitle>(entity =>
            {
                entity.HasKey(e => e.Titlecode)
                    .HasName("poddat_msttitle_pkey");

                entity.ToTable("poddat_msttitle", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_msttitle_dms_rep_dtt_idx");

                entity.Property(e => e.Titlecode)
                    .HasColumnName("titlecode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Titlename)
                    .IsRequired()
                    .HasColumnName("titlename")
                    .HasMaxLength(200);

                entity.Property(e => e.Titlenameen)
                    .HasColumnName("titlenameen")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PoddatMsttrucktype>(entity =>
            {
                entity.HasKey(e => e.Trucktypecode)
                    .HasName("poddat_msttrucktype_pkey");

                entity.ToTable("poddat_msttrucktype", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_msttrucktype_dms_rep_dtt_idx");

                entity.Property(e => e.Trucktypecode)
                    .HasColumnName("trucktypecode")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Truckgroup)
                    .HasColumnName("truckgroup")
                    .HasMaxLength(5);

                entity.Property(e => e.Trucktypename)
                    .HasColumnName("trucktypename")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PoddatMstvehicle>(entity =>
            {
                entity.HasKey(e => e.Trucklicense)
                    .HasName("poddat_mstvehicle_pkey");

                entity.ToTable("poddat_mstvehicle", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstvehicle_dms_rep_dtt_idx");

                entity.Property(e => e.Trucklicense)
                    .HasColumnName("trucklicense")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carriercode)
                    .IsRequired()
                    .HasColumnName("carriercode")
                    .HasMaxLength(20);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fullplate)
                    .HasColumnName("fullplate")
                    .HasMaxLength(100);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Trailerlicense)
                    .HasColumnName("trailerlicense")
                    .HasMaxLength(50);

                entity.Property(e => e.Trucktype)
                    .IsRequired()
                    .HasColumnName("trucktype")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PoddatMstzone>(entity =>
            {
                entity.HasKey(e => e.Zonecode)
                    .HasName("poddat_mstzone_pkey");

                entity.ToTable("poddat_mstzone", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_mstzone_dms_rep_dtt_idx");

                entity.Property(e => e.Zonecode)
                    .HasColumnName("zonecode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Zonename)
                    .IsRequired()
                    .HasColumnName("zonename")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PoddatNotifyhistory>(entity =>
            {
                entity.HasKey(e => e.Notifyid)
                    .HasName("poddat_notifyhistory_pkey");

                entity.ToTable("poddat_notifyhistory", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_notifyhistory_dms_rep_dtt_idx");

                entity.Property(e => e.Notifyid)
                    .HasColumnName("notifyid")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Notimessage)
                    .IsRequired()
                    .HasColumnName("notimessage")
                    .HasMaxLength(300);

                entity.Property(e => e.Notititle)
                    .IsRequired()
                    .HasColumnName("notititle")
                    .HasMaxLength(100);

                entity.Property(e => e.Readeddate)
                    .HasColumnName("readeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Recipient)
                    .IsRequired()
                    .HasColumnName("recipient")
                    .HasMaxLength(50);

                entity.Property(e => e.Reference1)
                    .HasColumnName("reference1")
                    .HasMaxLength(100);

                entity.Property(e => e.Reference2)
                    .HasColumnName("reference2")
                    .HasMaxLength(100);

                entity.Property(e => e.Reference3)
                    .HasColumnName("reference3")
                    .HasMaxLength(100);

                entity.Property(e => e.Sendeddate)
                    .HasColumnName("sendeddate")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoddatPhototaking>(entity =>
            {
                entity.HasKey(e => new { e.Groupcode, e.Photocode })
                    .HasName("poddat_phototaking_pkey");

                entity.ToTable("poddat_phototaking", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_phototaking_dms_rep_dtt_idx");

                entity.Property(e => e.Groupcode)
                    .HasColumnName("groupcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Photocode)
                    .HasColumnName("photocode")
                    .HasMaxLength(10);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Photodesc)
                    .IsRequired()
                    .HasColumnName("photodesc")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<PoddatShipment>(entity =>
            {
                entity.HasKey(e => e.Shipmentno)
                    .HasName("poddat_shipment_pkey");

                entity.ToTable("poddat_shipment", "dom");

                entity.HasIndex(e => e.Completedate)
                    .HasName("idx_completedate");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_shipment_dms_rep_dtt_idx");

                entity.Property(e => e.Shipmentno)
                    .HasColumnName("shipmentno")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Accepteddate)
                    .HasColumnName("accepteddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Assigneddate)
                    .HasColumnName("assigneddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Carriercode)
                    .IsRequired()
                    .HasColumnName("carriercode")
                    .HasMaxLength(20);

                entity.Property(e => e.Carriername)
                    .IsRequired()
                    .HasColumnName("carriername")
                    .HasMaxLength(200);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Checkindate)
                    .HasColumnName("checkindate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Checkoutdate)
                    .HasColumnName("checkoutdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Completedate)
                    .HasColumnName("completedate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Driverlicense)
                    .IsRequired()
                    .HasColumnName("driverlicense")
                    .HasMaxLength(20);

                entity.Property(e => e.Drivername)
                    .IsRequired()
                    .HasColumnName("drivername")
                    .HasMaxLength(200);

                entity.Property(e => e.Estdistance)
                    .HasColumnName("estdistance")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Fulllicense)
                    .HasColumnName("fulllicense")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastlatitude).HasColumnName("lastlatitude");

                entity.Property(e => e.Lastlongitude).HasColumnName("lastlongitude");

                entity.Property(e => e.Laststatusdate)
                    .HasColumnName("laststatusdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Loadeddate)
                    .HasColumnName("loadeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Productgroup)
                    .HasColumnName("productgroup")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantityunit)
                    .HasColumnName("quantityunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Rejectreason)
                    .HasColumnName("rejectreason")
                    .HasMaxLength(300);

                entity.Property(e => e.Rejectremark)
                    .HasColumnName("rejectremark")
                    .HasMaxLength(300);

                entity.Property(e => e.Shipmentamount)
                    .HasColumnName("shipmentamount")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Shipmentdate)
                    .HasColumnName("shipmentdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Shipmentleg)
                    .HasColumnName("shipmentleg")
                    .HasMaxLength(6);

                entity.Property(e => e.Shipmentmemo)
                    .HasColumnName("shipmentmemo")
                    .HasMaxLength(600);

                entity.Property(e => e.Shipmentremark)
                    .HasColumnName("shipmentremark")
                    .HasMaxLength(300);

                entity.Property(e => e.Shipmentstatus)
                    .HasColumnName("shipmentstatus")
                    .HasMaxLength(20);

                entity.Property(e => e.Shippingaddr)
                    .HasColumnName("shippingaddr")
                    .HasMaxLength(300);

                entity.Property(e => e.Shippingarea)
                    .HasColumnName("shippingarea")
                    .HasMaxLength(50);

                entity.Property(e => e.Shippingcode)
                    .IsRequired()
                    .HasColumnName("shippingcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Shippingname)
                    .IsRequired()
                    .HasColumnName("shippingname")
                    .HasMaxLength(200);

                entity.Property(e => e.Shiptoaddr)
                    .HasColumnName("shiptoaddr")
                    .HasMaxLength(300);

                entity.Property(e => e.Shiptocode)
                    .IsRequired()
                    .HasColumnName("shiptocode")
                    .HasMaxLength(20);

                entity.Property(e => e.Shiptoname)
                    .IsRequired()
                    .HasColumnName("shiptoname")
                    .HasMaxLength(200);

                entity.Property(e => e.Tendereddate)
                    .HasColumnName("tendereddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Tmsdescription)
                    .HasColumnName("tmsdescription")
                    .HasMaxLength(300);

                entity.Property(e => e.Tmsmemo)
                    .HasColumnName("tmsmemo")
                    .HasMaxLength(600);

                entity.Property(e => e.Totalquantity)
                    .HasColumnName("totalquantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalvolume)
                    .HasColumnName("totalvolume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Totalweight)
                    .HasColumnName("totalweight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Trackingno)
                    .HasColumnName("trackingno")
                    .HasMaxLength(30);

                entity.Property(e => e.Trailerlicense)
                    .HasColumnName("trailerlicense")
                    .HasMaxLength(20);

                entity.Property(e => e.Trucklicense)
                    .IsRequired()
                    .HasColumnName("trucklicense")
                    .HasMaxLength(20);

                entity.Property(e => e.Trucktype)
                    .IsRequired()
                    .HasColumnName("trucktype")
                    .HasMaxLength(20);

                entity.Property(e => e.Unloadeddate)
                    .HasColumnName("unloadeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Volumeunit)
                    .HasColumnName("volumeunit")
                    .HasMaxLength(10);

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PoddatShipmentstatus>(entity =>
            {
                entity.HasKey(e => e.Statuscode)
                    .HasName("poddat_shipmentstatus_pkey");

                entity.ToTable("poddat_shipmentstatus", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_shipmentstatus_dms_rep_dtt_idx");

                entity.Property(e => e.Statuscode)
                    .HasColumnName("statuscode")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Statusdesc)
                    .IsRequired()
                    .HasColumnName("statusdesc")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<PoddatShippingpoint>(entity =>
            {
                entity.HasKey(e => e.Shippingcode)
                    .HasName("poddat_shippingpoint_pkey");

                entity.ToTable("poddat_shippingpoint", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_shippingpoint_dms_rep_dtt_idx");

                entity.Property(e => e.Shippingcode)
                    .HasColumnName("shippingcode")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Addresscity)
                    .HasColumnName("addresscity")
                    .HasMaxLength(200);

                entity.Property(e => e.Addressstreet)
                    .HasColumnName("addressstreet")
                    .HasMaxLength(200);

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(5);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fulladdress)
                    .IsRequired()
                    .HasColumnName("fulladdress")
                    .HasMaxLength(500);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Obsoletecode)
                    .HasColumnName("obsoletecode")
                    .HasMaxLength(20);

                entity.Property(e => e.Shippingname)
                    .IsRequired()
                    .HasColumnName("shippingname")
                    .HasMaxLength(300);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PoddatShipto>(entity =>
            {
                entity.HasKey(e => e.Shiptocode)
                    .HasName("poddat_shipto_pkey");

                entity.ToTable("poddat_shipto", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_shipto_dms_rep_dtt_idx");

                entity.Property(e => e.Shiptocode)
                    .HasColumnName("shiptocode")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fulladdress)
                    .IsRequired()
                    .HasColumnName("fulladdress")
                    .HasMaxLength(500);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Shiptoname)
                    .IsRequired()
                    .HasColumnName("shiptoname")
                    .HasMaxLength(300);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PoddatTruckcommit>(entity =>
            {
                entity.HasKey(e => new { e.Carriercode, e.Fleetcode, e.Trucktypecode, e.Commuditycode, e.Zonecode, e.Commitdate })
                    .HasName("poddat_truckcommit_pkey");

                entity.ToTable("poddat_truckcommit", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_truckcommit_dms_rep_dtt_idx");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(20);

                entity.Property(e => e.Fleetcode)
                    .HasColumnName("fleetcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Trucktypecode)
                    .HasColumnName("trucktypecode")
                    .HasMaxLength(20);

                entity.Property(e => e.Commuditycode)
                    .HasColumnName("commuditycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Zonecode)
                    .HasColumnName("zonecode")
                    .HasMaxLength(10);

                entity.Property(e => e.Commitdate)
                    .HasColumnName("commitdate")
                    .HasMaxLength(8);

                entity.Property(e => e.Commitamount).HasColumnName("commitamount");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Entityid).HasColumnName("entityid");
            });

            modelBuilder.Entity<PoddatUserdevice>(entity =>
            {
                entity.HasKey(e => e.Deviceid)
                    .HasName("poddat_userdevice_pkey");

                entity.ToTable("poddat_userdevice", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_userdevice_dms_rep_dtt_idx");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasMaxLength(300)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(50);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .IsRequired()
                    .HasColumnName("createduser")
                    .HasMaxLength(50);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Usercode)
                    .IsRequired()
                    .HasColumnName("usercode")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.Usertype)
                    .IsRequired()
                    .HasColumnName("usertype")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PoddatUserlogin>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("poddat_userlogin_pkey");

                entity.ToTable("poddat_userlogin", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_userlogin_dms_rep_dtt_idx");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Changeddate)
                    .HasColumnName("changeddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Changeduser)
                    .HasColumnName("changeduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Createduser)
                    .HasColumnName("createduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasMaxLength(300);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Expiredate)
                    .IsRequired()
                    .HasColumnName("expiredate")
                    .HasMaxLength(8);

                entity.Property(e => e.Falsecount).HasColumnName("falsecount");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(100);

                entity.Property(e => e.Forgetdate)
                    .HasColumnName("forgetdate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(300);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(100);

                entity.Property(e => e.Mobileno)
                    .HasColumnName("mobileno")
                    .HasMaxLength(50);

                entity.Property(e => e.Passwordenc).HasColumnName("passwordenc");

                entity.Property(e => e.Passwordx)
                    .HasColumnName("passwordx")
                    .HasMaxLength(300);

                entity.Property(e => e.Picture).HasColumnName("picture");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(200);

                entity.Property(e => e.Resetcode)
                    .HasColumnName("resetcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Signature).HasColumnName("signature");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Usercode)
                    .IsRequired()
                    .HasColumnName("usercode")
                    .HasMaxLength(50);

                entity.Property(e => e.Usertype)
                    .IsRequired()
                    .HasColumnName("usertype")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PoddatUserorigins>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Shippingcode })
                    .HasName("poddat_userorigins_pkey");

                entity.ToTable("poddat_userorigins", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("poddat_userorigins_dms_rep_dtt_idx");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.Shippingcode)
                    .HasColumnName("shippingcode")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScvcorDeliveryTrackingHeader>(entity =>
            {
                entity.HasKey(e => e.DeliveryNumber)
                    .HasName("scvcor_delivery_tracking_header_pkey");

                entity.ToTable("scvcor_delivery_tracking_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvcor_delivery_tracking_header_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommodityCode)
                    .HasColumnName("commodity_code")
                    .HasMaxLength(12);

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerRegion)
                    .HasColumnName("customer_region")
                    .HasMaxLength(4);

                entity.Property(e => e.DeliveryCreateDate)
                    .HasColumnName("delivery_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DestinationCode)
                    .HasColumnName("destination_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DestinationName)
                    .HasColumnName("destination_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DestinationPostalCode)
                    .HasColumnName("destination_postal_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DestinationRegion)
                    .HasColumnName("destination_region")
                    .HasMaxLength(4);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.MatFreightGrp)
                    .HasColumnName("mat_freight_grp")
                    .HasMaxLength(8);

                entity.Property(e => e.OrderCreateDate)
                    .HasColumnName("order_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(30);

                entity.Property(e => e.OriginCode)
                    .HasColumnName("origin_code")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginName)
                    .HasColumnName("origin_name")
                    .HasMaxLength(255);

                entity.Property(e => e.OriginPostalCode)
                    .HasColumnName("origin_postal_code")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginRegion)
                    .HasColumnName("origin_region")
                    .HasMaxLength(4);

                entity.Property(e => e.PoNumber)
                    .HasColumnName("po_number")
                    .HasMaxLength(100);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion");

                entity.Property(e => e.SalesOrg)
                    .HasColumnName("sales_org")
                    .HasMaxLength(4);

                entity.Property(e => e.TotalOfLeg).HasColumnName("total_of_leg");

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ScvcorDeliveryTrackingLoadLeg>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryNumber, e.LoadId })
                    .HasName("scvcor_delivery_tracking_load_leg_pkey");

                entity.ToTable("scvcor_delivery_tracking_load_leg", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvcor_delivery_tracking_load_leg_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.LoadId)
                    .HasColumnName("load_id")
                    .HasMaxLength(30);

                entity.Property(e => e.CarrierCode)
                    .HasColumnName("carrier_code")
                    .HasMaxLength(20);

                entity.Property(e => e.CarrierName)
                    .HasColumnName("carrier_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CommodityCode)
                    .HasColumnName("commodity_code")
                    .HasMaxLength(12);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DriverName)
                    .HasColumnName("driver_name")
                    .HasMaxLength(150);

                entity.Property(e => e.DropCode)
                    .HasColumnName("drop_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DropName)
                    .HasColumnName("drop_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DropPostalCode)
                    .HasColumnName("drop_postal_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DropRegion)
                    .HasColumnName("drop_region")
                    .HasMaxLength(4);

                entity.Property(e => e.DropstopSeqNo).HasColumnName("dropstop_seq_no");

                entity.Property(e => e.EquipmentType)
                    .HasColumnName("equipment_type")
                    .HasMaxLength(5);

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.LoadCreateDate)
                    .HasColumnName("load_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.LoadDesc)
                    .HasColumnName("load_desc")
                    .HasMaxLength(280);

                entity.Property(e => e.LoadLeg).HasColumnName("load_leg");

                entity.Property(e => e.MatFreightGrp)
                    .HasColumnName("mat_freight_grp")
                    .HasMaxLength(8);

                entity.Property(e => e.PickstopSeqNo).HasColumnName("pickstop_seq_no");

                entity.Property(e => e.PickupCode)
                    .HasColumnName("pickup_code")
                    .HasMaxLength(20);

                entity.Property(e => e.PickupName)
                    .HasColumnName("pickup_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PickupPostalCode)
                    .HasColumnName("pickup_postal_code")
                    .HasMaxLength(20);

                entity.Property(e => e.PickupRegion)
                    .HasColumnName("pickup_region")
                    .HasMaxLength(4);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion");

                entity.Property(e => e.TripId)
                    .HasColumnName("trip_id")
                    .HasColumnType("numeric(28,0)");

                entity.Property(e => e.TripLoadSeqNo).HasColumnName("trip_load_seq_no");

                entity.Property(e => e.TruckLicense)
                    .HasColumnName("truck_license")
                    .HasMaxLength(70);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ScvcorDeliveryTrackingStatus>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryNumber, e.LoadId })
                    .HasName("scvcor_delivery_tracking_status_pkey");

                entity.ToTable("scvcor_delivery_tracking_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvcor_delivery_tracking_status_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.LoadId)
                    .HasColumnName("load_id")
                    .HasMaxLength(30);

                entity.Property(e => e.ActualCdasBayinDate)
                    .HasColumnName("actual_cdas_bayin_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualCdasBayoutDate)
                    .HasColumnName("actual_cdas_bayout_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualCdasDpboothDate)
                    .HasColumnName("actual_cdas_dpbooth_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualCdasGiDate)
                    .HasColumnName("actual_cdas_gi_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualCdasInboundDate)
                    .HasColumnName("actual_cdas_inbound_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualCdasTareDate)
                    .HasColumnName("actual_cdas_tare_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualDeliveryDate)
                    .HasColumnName("actual_delivery_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualDocumentReturn)
                    .HasColumnName("actual_document_return")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualGiDate)
                    .HasColumnName("actual_gi_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualInDestination)
                    .HasColumnName("actual_in_destination")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualInOrigin)
                    .HasColumnName("actual_in_origin")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualInTransit)
                    .HasColumnName("actual_in_transit")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualOpen)
                    .HasColumnName("actual_open")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualOutDestination)
                    .HasColumnName("actual_out_destination")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualOutOrigin)
                    .HasColumnName("actual_out_origin")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualPlan)
                    .HasColumnName("actual_plan")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualTender)
                    .HasColumnName("actual_tender")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualTenderAccept)
                    .HasColumnName("actual_tender_accept")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoBillingDate)
                    .HasColumnName("info_billing_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoCdasBayNo)
                    .HasColumnName("info_cdas_bay_no")
                    .HasMaxLength(10);

                entity.Property(e => e.InfoCdasGiWeight)
                    .HasColumnName("info_cdas_gi_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.InfoCdasSealno)
                    .HasColumnName("info_cdas_sealno")
                    .HasMaxLength(255);

                entity.Property(e => e.InfoCdasTareWeight)
                    .HasColumnName("info_cdas_tare_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.InfoDnAttachDate)
                    .HasColumnName("info_dn_attach_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoGiWeight)
                    .HasColumnName("info_gi_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.InfoGrDate)
                    .HasColumnName("info_gr_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoGrWeight)
                    .HasColumnName("info_gr_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.InfoInvoicePaymentDate)
                    .HasColumnName("info_invoice_payment_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoLpcDocumentDate)
                    .HasColumnName("info_lpc_document_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoPaymentDate)
                    .HasColumnName("info_payment_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoPlanDeliveryDate)
                    .HasColumnName("info_plan_delivery_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoPlanDeliveryExtendMsg)
                    .HasColumnName("info_plan_delivery_extend_msg")
                    .HasMaxLength(255);

                entity.Property(e => e.InfoPlanDeliveryWarnDate)
                    .HasColumnName("info_plan_delivery_warn_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoPodAbcaseDate)
                    .HasColumnName("info_pod_abcase_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoPodAttachEdpDate)
                    .HasColumnName("info_pod_attach_edp_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoPodAttachImgDate)
                    .HasColumnName("info_pod_attach_img_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InfoPodTrackLocDate)
                    .HasColumnName("info_pod_track_loc_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.LastTrackingStatus).HasColumnName("last_tracking_status");

                entity.Property(e => e.LoadLeg).HasColumnName("load_leg");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion");

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ScvcorMasterMatFreightGrp>(entity =>
            {
                entity.HasKey(e => e.MatFreightGrp)
                    .HasName("scvcor_master_mat_freight_grp_pkey");

                entity.ToTable("scvcor_master_mat_freight_grp", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvcor_master_mat_freight_grp_dms_rep_dtt_idx");

                entity.Property(e => e.MatFreightGrp)
                    .HasColumnName("mat_freight_grp")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ScvcorMasterSalesOrg>(entity =>
            {
                entity.HasKey(e => e.SalesOrg)
                    .HasName("scvcor_master_sales_org_pkey");

                entity.ToTable("scvcor_master_sales_org", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvcor_master_sales_org_dms_rep_dtt_idx");

                entity.Property(e => e.SalesOrg)
                    .HasColumnName("sales_org")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ScvcorMasterTrackingStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("scvcor_master_tracking_status_pkey");

                entity.ToTable("scvcor_master_tracking_status", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvcor_master_tracking_status_dms_rep_dtt_idx");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.StatusDescription)
                    .HasColumnName("status_description")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusDisplay)
                    .HasColumnName("status_display")
                    .HasMaxLength(100);

                entity.Property(e => e.StatusField)
                    .IsRequired()
                    .HasColumnName("status_field")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ScvmvcCdasGiInfo>(entity =>
            {
                entity.HasKey(e => new { e.DnNo, e.ItemNo })
                    .HasName("scvmvc_cdas_gi_info_pkey");

                entity.ToTable("scvmvc_cdas_gi_info", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_cdas_gi_info_dms_rep_dtt_idx");

                entity.Property(e => e.DnNo)
                    .HasColumnName("dn_no")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemNo)
                    .HasColumnName("item_no")
                    .HasMaxLength(10);

                entity.Property(e => e.BayNo)
                    .HasColumnName("bay_no")
                    .HasMaxLength(10);

                entity.Property(e => e.BayinDate)
                    .HasColumnName("bayin_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.BayoutDate)
                    .HasColumnName("bayout_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DpboothDate)
                    .HasColumnName("dpbooth_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExitDate)
                    .HasColumnName("exit_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExitWeight)
                    .HasColumnName("exit_weight")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.GiWeight)
                    .HasColumnName("gi_weight")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.Gidate)
                    .HasColumnName("gidate")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InboundDate)
                    .HasColumnName("inbound_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(50);

                entity.Property(e => e.Pono)
                    .HasColumnName("pono")
                    .HasMaxLength(10);

                entity.Property(e => e.Sealno)
                    .HasColumnName("sealno")
                    .HasMaxLength(255);

                entity.Property(e => e.Sealno1)
                    .HasColumnName("sealno1")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingpointId)
                    .HasColumnName("shippingpoint_id")
                    .HasMaxLength(4);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(5);

                entity.Property(e => e.TareDate)
                    .HasColumnName("tare_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.TareWeight)
                    .HasColumnName("tare_weight")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.Trucklicense)
                    .HasColumnName("trucklicense")
                    .HasMaxLength(10);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .IsRequired()
                    .HasColumnName("user_create_name")
                    .HasMaxLength(20);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ScvmvcExtDeliveryHeader>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryNumber, e.DeliveryType, e.LegId })
                    .HasName("scvmvc_ext_delivery_header_pkey");

                entity.ToTable("scvmvc_ext_delivery_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_ext_delivery_header_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryType)
                    .HasColumnName("delivery_type")
                    .HasMaxLength(20);

                entity.Property(e => e.LegId).HasColumnName("leg_id");

                entity.Property(e => e.BatchUpdateDate)
                    .HasColumnName("batch_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.BigLot).HasColumnName("big_lot");

                entity.Property(e => e.CarrierCode)
                    .HasColumnName("carrier_code")
                    .HasMaxLength(32);

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.DeliveredFromDate)
                    .HasColumnName("delivered_from_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeliveredToDate)
                    .HasColumnName("delivered_to_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeliveryCompletedDate)
                    .HasColumnName("delivery_completed_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DestinationCode)
                    .HasColumnName("destination_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DestinationLocType)
                    .HasColumnName("destination_loc_type")
                    .HasMaxLength(10);

                entity.Property(e => e.DestinationName)
                    .HasColumnName("destination_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.DmReceiverTelephone)
                    .HasColumnName("dm_receiver_telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.DmScheduleDate)
                    .HasColumnName("dm_schedule_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DocReturnDate)
                    .HasColumnName("doc_return_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DriverLicenseNumber)
                    .HasColumnName("driver_license_number")
                    .HasMaxLength(255);

                entity.Property(e => e.EndCustomerCode)
                    .HasColumnName("end_customer_code")
                    .HasMaxLength(100);

                entity.Property(e => e.EndCustomerName)
                    .HasColumnName("end_customer_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.EquipmentType)
                    .HasColumnName("equipment_type")
                    .HasMaxLength(20);

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("error_message")
                    .HasMaxLength(1000);

                entity.Property(e => e.FlagCreatedShipment).HasColumnName("flag_created_shipment");

                entity.Property(e => e.FlagDelete).HasColumnName("flag_delete");

                entity.Property(e => e.FlagExecJobSchedule).HasColumnName("flag_exec_job_schedule");

                entity.Property(e => e.FlagGiCompleted).HasColumnName("flag_gi_completed");

                entity.Property(e => e.FlagGrCompleted).HasColumnName("flag_gr_completed");

                entity.Property(e => e.FlagOverrideCharge).HasColumnName("flag_override_charge");

                entity.Property(e => e.FlagOverrideThroughPoint).HasColumnName("flag_override_through_point");

                entity.Property(e => e.FlagPackedCompleted).HasColumnName("flag_packed_completed");

                entity.Property(e => e.FlagPreBuildLoad).HasColumnName("flag_pre_build_load");

                entity.Property(e => e.FlagReceived).HasColumnName("flag_received");

                entity.Property(e => e.FlagRequiredPack).HasColumnName("flag_required_pack");

                entity.Property(e => e.FlagRequiredPallet).HasColumnName("flag_required_pallet");

                entity.Property(e => e.FlagReturn).HasColumnName("flag_return");

                entity.Property(e => e.FlagSuspendLoad).HasColumnName("flag_suspend_load");

                entity.Property(e => e.GiCompletedDate)
                    .HasColumnName("gi_completed_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.GiHeaderText)
                    .HasColumnName("gi_header_text")
                    .HasMaxLength(500);

                entity.Property(e => e.GrCompletedDate)
                    .HasColumnName("gr_completed_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.IncoTermCode)
                    .HasColumnName("inco_term_code")
                    .HasMaxLength(3);

                entity.Property(e => e.IncoTermDesc)
                    .HasColumnName("inco_term_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.KafkaTimeStamp)
                    .HasColumnName("kafka_time_stamp")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.LegHeader)
                    .IsRequired()
                    .HasColumnName("leg_header")
                    .HasMaxLength(30);

                entity.Property(e => e.MergeIntransitCode)
                    .HasColumnName("merge_intransit_code")
                    .HasMaxLength(12);

                entity.Property(e => e.OmsRouteId)
                    .HasColumnName("oms_route_id")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrderDocType)
                    .HasColumnName("order_doc_type")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderPatternId).HasColumnName("order_pattern_id");

                entity.Property(e => e.OrderScheduleLine).HasColumnName("order_schedule_line");

                entity.Property(e => e.OrderScheduleLineNumber).HasColumnName("order_schedule_line_number");

                entity.Property(e => e.OriginCode)
                    .HasColumnName("origin_code")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginLocType)
                    .HasColumnName("origin_loc_type")
                    .HasMaxLength(10);

                entity.Property(e => e.OriginName)
                    .HasColumnName("origin_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.OutsourceCode)
                    .HasColumnName("outsource_code")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentTerm)
                    .HasColumnName("payment_term")
                    .HasMaxLength(4);

                entity.Property(e => e.PickedUpFromDate)
                    .HasColumnName("picked_up_from_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.PickedUpToDate)
                    .HasColumnName("picked_up_to_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.PlannedDeliveryDate)
                    .HasColumnName("planned_delivery_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.PlannerName)
                    .HasColumnName("planner_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PoNumber)
                    .HasColumnName("po_number")
                    .HasMaxLength(100);

                entity.Property(e => e.RefDeliveryNumber)
                    .HasColumnName("ref_delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.RequestedDate)
                    .HasColumnName("requested_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.RetryNumber).HasColumnName("retry_number");

                entity.Property(e => e.SalesOrg)
                    .HasColumnName("sales_org")
                    .HasMaxLength(4);

                entity.Property(e => e.SapShipToCode)
                    .HasColumnName("sap_ship_to_code")
                    .HasMaxLength(10);

                entity.Property(e => e.SapShipToName)
                    .HasColumnName("sap_ship_to_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.ServiceLevel)
                    .HasColumnName("service_level")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceLevelDesc)
                    .HasColumnName("service_level_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(16);

                entity.Property(e => e.ShipFromCode)
                    .HasColumnName("ship_from_code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipFromName)
                    .HasColumnName("ship_from_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.ShipFromType)
                    .HasColumnName("ship_from_type")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCode)
                    .HasColumnName("ship_to_code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipToName)
                    .HasColumnName("ship_to_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.ShipToSpecialCond)
                    .HasColumnName("ship_to_special_cond")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToTel)
                    .HasColumnName("ship_to_tel")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToType)
                    .HasColumnName("ship_to_type")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipmentLegId)
                    .HasColumnName("shipment_leg_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipmentLoadId)
                    .HasColumnName("shipment_load_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipmentMemo)
                    .HasColumnName("shipment_memo")
                    .HasMaxLength(2000);

                entity.Property(e => e.ShipmentNumber)
                    .HasColumnName("shipment_number")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipmentProcessDate)
                    .HasColumnName("shipment_process_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.SoldToCity)
                    .HasColumnName("sold_to_city")
                    .HasMaxLength(140);

                entity.Property(e => e.SoldToDistrict)
                    .HasColumnName("sold_to_district")
                    .HasMaxLength(140);

                entity.Property(e => e.SoldToPostal)
                    .HasColumnName("sold_to_postal")
                    .HasMaxLength(12);

                entity.Property(e => e.SoldToRegion)
                    .HasColumnName("sold_to_region")
                    .HasMaxLength(4);

                entity.Property(e => e.SoldToStreet)
                    .HasColumnName("sold_to_street")
                    .HasMaxLength(140);

                entity.Property(e => e.SoldToTel)
                    .HasColumnName("sold_to_tel")
                    .HasMaxLength(30);

                entity.Property(e => e.SourceSystem)
                    .HasColumnName("source_system")
                    .HasMaxLength(20);

                entity.Property(e => e.SpecialOrderType)
                    .HasColumnName("special_order_type")
                    .HasMaxLength(120);

                entity.Property(e => e.SpotRate)
                    .HasColumnName("spot_rate")
                    .HasColumnType("numeric(13,3)");

                entity.Property(e => e.SpotUnit)
                    .HasColumnName("spot_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.Property(e => e.SystemBatchNumber)
                    .HasColumnName("system_batch_number")
                    .HasMaxLength(25);

                entity.Property(e => e.TrailerLicenseNumber)
                    .HasColumnName("trailer_license_number")
                    .HasMaxLength(255);

                entity.Property(e => e.TransportMode)
                    .HasColumnName("transport_mode")
                    .HasMaxLength(10);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);

                entity.Property(e => e.VehicleTypeId)
                    .HasColumnName("vehicle_type_id")
                    .HasMaxLength(5);

                entity.Property(e => e.VesselName)
                    .HasColumnName("vessel_name")
                    .HasMaxLength(120);

                entity.Property(e => e.WarehouseLocCode)
                    .HasColumnName("warehouse_loc_code")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ScvmvcExtDeliveryItem>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryNumber, e.DeliveryType, e.LegId, e.DeliveryItemNumber })
                    .HasName("scvmvc_ext_delivery_item_pkey");

                entity.ToTable("scvmvc_ext_delivery_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_ext_delivery_item_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryType)
                    .HasColumnName("delivery_type")
                    .HasMaxLength(20);

                entity.Property(e => e.LegId).HasColumnName("leg_id");

                entity.Property(e => e.DeliveryItemNumber).HasColumnName("delivery_item_number");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.FlagDelete).HasColumnName("flag_delete");

                entity.Property(e => e.FlagGi).HasColumnName("flag_gi");

                entity.Property(e => e.FlagGr).HasColumnName("flag_gr");

                entity.Property(e => e.FlagRequestPallet).HasColumnName("flag_request_pallet");

                entity.Property(e => e.GiCompletedDate)
                    .HasColumnName("gi_completed_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.GiQuantity)
                    .HasColumnName("gi_quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.GrCompletedDate)
                    .HasColumnName("gr_completed_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.GrQuantity)
                    .HasColumnName("gr_quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.KafkaTimeStamp)
                    .HasColumnName("kafka_time_stamp")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.LegHeader)
                    .IsRequired()
                    .HasColumnName("leg_header")
                    .HasMaxLength(30);

                entity.Property(e => e.MatBaseUnit)
                    .HasColumnName("mat_base_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.MatFreightGrp)
                    .HasColumnName("mat_freight_grp")
                    .HasMaxLength(8);

                entity.Property(e => e.MatGrossWeight)
                    .HasColumnName("mat_gross_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MatNetWeight)
                    .HasColumnName("mat_net_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MatPricingUnit)
                    .HasColumnName("mat_pricing_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.MatVolume)
                    .HasColumnName("mat_volume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("material_code")
                    .HasMaxLength(30);

                entity.Property(e => e.MaterialName)
                    .HasColumnName("material_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.OrderItemNumber)
                    .HasColumnName("order_item_number")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(30);

                entity.Property(e => e.PackedQuantity)
                    .HasColumnName("packed_quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.PlannerName)
                    .HasColumnName("planner_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(4);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.RefDeliveryNumber)
                    .HasColumnName("ref_delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.ShippingMark)
                    .HasColumnName("shipping_mark")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalGrossWeight)
                    .HasColumnName("total_gross_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.TotalNetWeight)
                    .HasColumnName("total_net_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.TotalVolume)
                    .HasColumnName("total_volume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);

                entity.Property(e => e.VolumeUnit)
                    .HasColumnName("volume_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.WeightUnit)
                    .HasColumnName("weight_unit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ScvmvcExtDeliveryItemGoodsIssue>(entity =>
            {
                entity.HasKey(e => new { e.RefDeliveryNumber, e.DeliveryType, e.LegId, e.DeliveryItemNumber })
                    .HasName("scvmvc_ext_delivery_item_goods_issue_pkey");

                entity.ToTable("scvmvc_ext_delivery_item_goods_issue", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_ext_delivery_item_goods_issue_dms_rep_dtt_idx");

                entity.Property(e => e.RefDeliveryNumber)
                    .HasColumnName("ref_delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryType)
                    .HasColumnName("delivery_type")
                    .HasMaxLength(20);

                entity.Property(e => e.LegId).HasColumnName("leg_id");

                entity.Property(e => e.DeliveryItemNumber).HasColumnName("delivery_item_number");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.FlagCompleted).HasColumnName("flag_completed");

                entity.Property(e => e.FlagDelete).HasColumnName("flag_delete");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issue_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.KafkaTimeStamp)
                    .HasColumnName("kafka_time_stamp")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.MatBaseUnit)
                    .HasColumnName("mat_base_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.MatFreightGrp)
                    .HasColumnName("mat_freight_grp")
                    .HasMaxLength(8);

                entity.Property(e => e.MatGrossWeight)
                    .HasColumnName("mat_gross_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MatNetWeight)
                    .HasColumnName("mat_net_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MatVolume)
                    .HasColumnName("mat_volume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("material_code")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderItemNumber)
                    .HasColumnName("order_item_number")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(30);

                entity.Property(e => e.PlannerName)
                    .HasColumnName("planner_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.SourceSystem)
                    .HasColumnName("source_system")
                    .HasMaxLength(20);

                entity.Property(e => e.StampDate)
                    .HasColumnName("stamp_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.TotalGrossWeight)
                    .HasColumnName("total_gross_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.TotalNetWeight)
                    .HasColumnName("total_net_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.TotalVolume)
                    .HasColumnName("total_volume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(50);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);

                entity.Property(e => e.VolumeUnit)
                    .HasColumnName("volume_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.WeightUnit)
                    .HasColumnName("weight_unit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ScvmvcExtDeliveryItemGoodsReceived>(entity =>
            {
                entity.HasKey(e => new { e.RefDeliveryNumber, e.DeliveryType, e.LegId, e.DeliveryItemNumber })
                    .HasName("scvmvc_ext_delivery_item_goods_received_pkey");

                entity.ToTable("scvmvc_ext_delivery_item_goods_received", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_ext_delivery_item_goods_received_dms_rep_dtt_idx");

                entity.Property(e => e.RefDeliveryNumber)
                    .HasColumnName("ref_delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryType)
                    .HasColumnName("delivery_type")
                    .HasMaxLength(20);

                entity.Property(e => e.LegId).HasColumnName("leg_id");

                entity.Property(e => e.DeliveryItemNumber).HasColumnName("delivery_item_number");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.FlagCompleted).HasColumnName("flag_completed");

                entity.Property(e => e.FlagDelete).HasColumnName("flag_delete");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issue_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.KafkaTimeStamp)
                    .HasColumnName("kafka_time_stamp")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.MatBaseUnit)
                    .HasColumnName("mat_base_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.MatFreightGrp)
                    .HasColumnName("mat_freight_grp")
                    .HasMaxLength(8);

                entity.Property(e => e.MatGrossWeight)
                    .HasColumnName("mat_gross_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MatNetWeight)
                    .HasColumnName("mat_net_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MatVolume)
                    .HasColumnName("mat_volume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("material_code")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderItemNumber)
                    .HasColumnName("order_item_number")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(30);

                entity.Property(e => e.PlannerName)
                    .HasColumnName("planner_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000);

                entity.Property(e => e.SourceSystem)
                    .HasColumnName("source_system")
                    .HasMaxLength(20);

                entity.Property(e => e.StampDate)
                    .HasColumnName("stamp_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.TotalGrossWeight)
                    .HasColumnName("total_gross_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.TotalNetWeight)
                    .HasColumnName("total_net_weight")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.TotalVolume)
                    .HasColumnName("total_volume")
                    .HasColumnType("numeric(18,3)");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasMaxLength(50);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);

                entity.Property(e => e.VolumeUnit)
                    .HasColumnName("volume_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.WeightUnit)
                    .HasColumnName("weight_unit")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ScvmvcMasterTmsLocation>(entity =>
            {
                entity.HasKey(e => e.LocationCode)
                    .HasName("scvmvc_master_tms_location_pkey");

                entity.ToTable("scvmvc_master_tms_location", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_master_tms_location_dms_rep_dtt_idx");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("numeric(13,10)");

                entity.Property(e => e.LocationName)
                    .HasColumnName("location_name")
                    .HasMaxLength(1000);

                entity.Property(e => e.LocationType).HasColumnName("location_type");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("numeric(13,10)");

                entity.Property(e => e.SapLocationCode)
                    .HasColumnName("sap_location_code")
                    .HasMaxLength(20);

                entity.Property(e => e.SapShipToCode)
                    .HasColumnName("sap_ship_to_code")
                    .HasMaxLength(40);

                entity.Property(e => e.SapShippingCode)
                    .HasColumnName("sap_shipping_code")
                    .HasMaxLength(20);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ScvmvcSapDeliveryHeader>(entity =>
            {
                entity.HasKey(e => e.DeliveryNumber)
                    .HasName("scvmvc_sap_delivery_header_pkey");

                entity.ToTable("scvmvc_sap_delivery_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_sap_delivery_header_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(40);

                entity.Property(e => e.DeliveryCreateDate)
                    .HasColumnName("delivery_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeliveryDatetime)
                    .HasColumnName("delivery_datetime")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeliveryType)
                    .HasColumnName("delivery_type")
                    .HasMaxLength(30);

                entity.Property(e => e.DmReceiverTelephone)
                    .HasColumnName("dm_receiver_telephone")
                    .HasMaxLength(20);

                entity.Property(e => e.DmScheduleDate)
                    .HasColumnName("dm_schedule_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.GiDatetime)
                    .HasColumnName("gi_datetime")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.GiStatus)
                    .HasColumnName("gi_status")
                    .HasMaxLength(1);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("gross_weight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.IdocNo)
                    .HasColumnName("idoc_no")
                    .HasMaxLength(40);

                entity.Property(e => e.Incoterm)
                    .HasColumnName("incoterm")
                    .HasMaxLength(3);

                entity.Property(e => e.NonprintableMemo)
                    .HasColumnName("nonprintable_memo")
                    .HasMaxLength(2000);

                entity.Property(e => e.OrderCreateDate)
                    .HasColumnName("order_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(30);

                entity.Property(e => e.PaymentTerm)
                    .HasColumnName("payment_term")
                    .HasMaxLength(4);

                entity.Property(e => e.PiMsgId)
                    .HasColumnName("pi_msg_id")
                    .HasMaxLength(40);

                entity.Property(e => e.PickingDatetime)
                    .HasColumnName("picking_datetime")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.PickingStatus)
                    .HasColumnName("picking_status")
                    .HasMaxLength(1);

                entity.Property(e => e.PoNumber)
                    .HasColumnName("po_number")
                    .HasMaxLength(70);

                entity.Property(e => e.PrintableMemo)
                    .HasColumnName("printable_memo")
                    .HasMaxLength(2000);

                entity.Property(e => e.RequestDeliveryDate)
                    .HasColumnName("request_delivery_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.SalesOrg)
                    .HasColumnName("sales_org")
                    .HasMaxLength(4);

                entity.Property(e => e.Serialization)
                    .HasColumnName("serialization")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipFromCity)
                    .HasColumnName("ship_from_city")
                    .HasMaxLength(70);

                entity.Property(e => e.ShipFromCode)
                    .HasColumnName("ship_from_code")
                    .HasMaxLength(16);

                entity.Property(e => e.ShipFromCountry)
                    .HasColumnName("ship_from_country")
                    .HasMaxLength(3);

                entity.Property(e => e.ShipFromName)
                    .HasColumnName("ship_from_name")
                    .HasMaxLength(70);

                entity.Property(e => e.ShipFromPostal)
                    .HasColumnName("ship_from_postal")
                    .HasMaxLength(12);

                entity.Property(e => e.ShipFromState)
                    .HasColumnName("ship_from_state")
                    .HasMaxLength(4);

                entity.Property(e => e.ShipFromStreet)
                    .HasColumnName("ship_from_street")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToCity)
                    .HasColumnName("ship_to_city")
                    .HasMaxLength(70);

                entity.Property(e => e.ShipToCode)
                    .HasColumnName("ship_to_code")
                    .HasMaxLength(16);

                entity.Property(e => e.ShipToCountry)
                    .HasColumnName("ship_to_country")
                    .HasMaxLength(3);

                entity.Property(e => e.ShipToName)
                    .HasColumnName("ship_to_name")
                    .HasMaxLength(70);

                entity.Property(e => e.ShipToPostal)
                    .HasColumnName("ship_to_postal")
                    .HasMaxLength(12);

                entity.Property(e => e.ShipToState)
                    .HasColumnName("ship_to_state")
                    .HasMaxLength(4);

                entity.Property(e => e.ShipToStreet)
                    .HasColumnName("ship_to_street")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToTel)
                    .HasColumnName("ship_to_tel")
                    .HasMaxLength(30);

                entity.Property(e => e.ShippingPoint)
                    .HasColumnName("shipping_point")
                    .HasMaxLength(20);

                entity.Property(e => e.SoldToCity)
                    .HasColumnName("sold_to_city")
                    .HasMaxLength(70);

                entity.Property(e => e.SoldToCode)
                    .HasColumnName("sold_to_code")
                    .HasMaxLength(20);

                entity.Property(e => e.SoldToCountry)
                    .HasColumnName("sold_to_country")
                    .HasMaxLength(3);

                entity.Property(e => e.SoldToName)
                    .HasColumnName("sold_to_name")
                    .HasMaxLength(70);

                entity.Property(e => e.SoldToPostal)
                    .HasColumnName("sold_to_postal")
                    .HasMaxLength(12);

                entity.Property(e => e.SoldToState)
                    .HasColumnName("sold_to_state")
                    .HasMaxLength(4);

                entity.Property(e => e.SoldToStreet)
                    .HasColumnName("sold_to_street")
                    .HasMaxLength(100);

                entity.Property(e => e.SoldToTel)
                    .HasColumnName("sold_to_tel")
                    .HasMaxLength(30);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.VolumeUnit)
                    .HasColumnName("volume_unit")
                    .HasMaxLength(20);

                entity.Property(e => e.WeightUnit)
                    .HasColumnName("weight_unit")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ScvmvcSapDeliveryItem>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryNumber, e.DeliveryItemNumber })
                    .HasName("scvmvc_sap_delivery_item_pkey");

                entity.ToTable("scvmvc_sap_delivery_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_sap_delivery_item_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryItemNumber)
                    .HasColumnName("delivery_item_number")
                    .HasMaxLength(30);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemGrossWeight)
                    .HasColumnName("item_gross_weight")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.ItemMatDesc)
                    .HasColumnName("item_mat_desc")
                    .HasMaxLength(400);

                entity.Property(e => e.ItemMatFreightGrp)
                    .HasColumnName("item_mat_freight_grp")
                    .HasMaxLength(30);

                entity.Property(e => e.ItemMatNo)
                    .HasColumnName("item_mat_no")
                    .HasMaxLength(30);

                entity.Property(e => e.ItemQuantity)
                    .HasColumnName("item_quantity")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(4);

                entity.Property(e => e.SalesUnit)
                    .HasColumnName("sales_unit")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ScvmvcTmsDeliveryHeader>(entity =>
            {
                entity.HasKey(e => e.DeliveryNumber)
                    .HasName("scvmvc_tms_delivery_header_pkey");

                entity.ToTable("scvmvc_tms_delivery_header", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_tms_delivery_header_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.CommodityCode)
                    .HasColumnName("commodity_code")
                    .HasMaxLength(12);

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryCreateDate)
                    .HasColumnName("delivery_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeliveryShpmId)
                    .HasColumnName("delivery_shpm_id")
                    .HasColumnType("numeric(28,0)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.EventDate)
                    .HasColumnName("event_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.EventName)
                    .HasColumnName("event_name")
                    .HasMaxLength(128);

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.MatFreightGrp)
                    .HasColumnName("mat_freight_grp")
                    .HasMaxLength(8);

                entity.Property(e => e.OrderCreateDate)
                    .HasColumnName("order_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(30);

                entity.Property(e => e.PoNumber)
                    .HasColumnName("po_number")
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCdFrom)
                    .HasColumnName("postal_cd_from")
                    .HasMaxLength(20);

                entity.Property(e => e.PostalCdTo)
                    .HasColumnName("postal_cd_to")
                    .HasMaxLength(20);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(4);

                entity.Property(e => e.ShipToBlock)
                    .HasColumnName("ship_to_block")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipToCity)
                    .HasColumnName("ship_to_city")
                    .HasMaxLength(80);

                entity.Property(e => e.ShipToCode)
                    .HasColumnName("ship_to_code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipToCountry)
                    .HasColumnName("ship_to_country")
                    .HasMaxLength(4);

                entity.Property(e => e.ShipToName)
                    .HasColumnName("ship_to_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToRegion)
                    .HasColumnName("ship_to_region")
                    .HasMaxLength(4);

                entity.Property(e => e.ShipToStreet)
                    .HasColumnName("ship_to_street")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingBlock)
                    .HasColumnName("shipping_block")
                    .HasMaxLength(30);

                entity.Property(e => e.ShippingCity)
                    .HasColumnName("shipping_city")
                    .HasMaxLength(80);

                entity.Property(e => e.ShippingCountry)
                    .HasColumnName("shipping_country")
                    .HasMaxLength(4);

                entity.Property(e => e.ShippingName)
                    .HasColumnName("shipping_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingPoint)
                    .HasColumnName("shipping_point")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingRegion)
                    .HasColumnName("shipping_region")
                    .HasMaxLength(4);

                entity.Property(e => e.ShippingStreet)
                    .HasColumnName("shipping_street")
                    .HasMaxLength(100);

                entity.Property(e => e.SoldToCode)
                    .HasColumnName("sold_to_code")
                    .HasMaxLength(20);

                entity.Property(e => e.SoldToName)
                    .HasColumnName("sold_to_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(20);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ScvmvcTmsDeliveryItem>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryNumber, e.DeliveryItemNumber })
                    .HasName("scvmvc_tms_delivery_item_pkey1");

                entity.ToTable("scvmvc_tms_delivery_item", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_tms_delivery_item_dms_rep_dtt_idx");

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryItemNumber)
                    .HasColumnName("delivery_item_number")
                    .HasMaxLength(30);

                entity.Property(e => e.ContainerCommodityCode)
                    .HasColumnName("container_commodity_code")
                    .HasMaxLength(12);

                entity.Property(e => e.ContainerDesc)
                    .HasColumnName("container_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.ContainerQuantity)
                    .HasColumnName("container_quantity")
                    .HasColumnType("numeric(11,4)");

                entity.Property(e => e.ContainerVolume)
                    .HasColumnName("container_volume")
                    .HasColumnType("numeric(11,4)");

                entity.Property(e => e.ContainerWeight)
                    .HasColumnName("container_weight")
                    .HasColumnType("numeric(11,4)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemDesc)
                    .HasColumnName("item_desc")
                    .HasMaxLength(400);

                entity.Property(e => e.ItemNumber)
                    .HasColumnName("item_number")
                    .HasMaxLength(30);

                entity.Property(e => e.ItemQuantity)
                    .HasColumnName("item_quantity")
                    .HasColumnType("numeric(11,4)");

                entity.Property(e => e.ItemWeight)
                    .HasColumnName("item_weight")
                    .HasColumnType("numeric(11,4)");
            });

            modelBuilder.Entity<ScvmvcTmsLoadLeg>(entity =>
            {
                entity.HasKey(e => e.LoadId)
                    .HasName("scvmvc_tms_load_leg_pkey");

                entity.ToTable("scvmvc_tms_load_leg", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_tms_load_leg_dms_rep_dtt_idx");

                entity.Property(e => e.LoadId)
                    .HasColumnName("load_id")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.CarrierCode)
                    .HasColumnName("carrier_code")
                    .HasMaxLength(20);

                entity.Property(e => e.CarrierName)
                    .HasColumnName("carrier_name")
                    .HasMaxLength(200);

                entity.Property(e => e.ChargeAmount)
                    .HasColumnName("charge_amount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DriverName)
                    .HasColumnName("driver_name")
                    .HasMaxLength(70);

                entity.Property(e => e.EquipmentType)
                    .HasColumnName("equipment_type")
                    .HasMaxLength(5);

                entity.Property(e => e.EventDate)
                    .HasColumnName("event_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.EventName)
                    .HasColumnName("event_name")
                    .HasMaxLength(128);

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.LoadDesc)
                    .HasColumnName("load_desc")
                    .HasMaxLength(280);

                entity.Property(e => e.LoadSeqNo).HasColumnName("load_seq_no");

                entity.Property(e => e.LoadStatus)
                    .HasColumnName("load_status")
                    .HasMaxLength(50);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion");

                entity.Property(e => e.TotalDistance)
                    .HasColumnName("total_distance")
                    .HasColumnType("numeric(18,1)");

                entity.Property(e => e.TotalShipments).HasColumnName("total_shipments");

                entity.Property(e => e.TotalStops).HasColumnName("total_stops");

                entity.Property(e => e.TotalVolume)
                    .HasColumnName("total_volume")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.TotalWeight)
                    .HasColumnName("total_weight")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.TripId)
                    .HasColumnName("trip_id")
                    .HasColumnType("numeric(28,0)");

                entity.Property(e => e.TruckLicense)
                    .HasColumnName("truck_license")
                    .HasMaxLength(70);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("user_create_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCreateName)
                    .HasColumnName("user_create_name")
                    .HasMaxLength(128);

                entity.Property(e => e.UserUpdateDate)
                    .HasColumnName("user_update_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserUpdateName)
                    .HasColumnName("user_update_name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ScvmvcTmsLoadLegDetail>(entity =>
            {
                entity.HasKey(e => new { e.LoadId, e.DeliveryNumber })
                    .HasName("scvmvc_tms_load_leg_detail_pkey");

                entity.ToTable("scvmvc_tms_load_leg_detail", "dom");

                entity.HasIndex(e => e.DeliveryNumber)
                    .HasName("index_dn")
                    .ForNpgsqlHasOperators(new[] { "varchar_ops" });

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_tms_load_leg_detail_dms_rep_dtt_idx");

                entity.Property(e => e.LoadId)
                    .HasColumnName("load_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DeliveryNumber)
                    .HasColumnName("delivery_number")
                    .HasMaxLength(30);

                entity.Property(e => e.CommodityCode)
                    .HasColumnName("commodity_code")
                    .HasMaxLength(12);

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryFromDate)
                    .HasColumnName("delivery_from_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DestinationBlock)
                    .HasColumnName("destination_block")
                    .HasMaxLength(30);

                entity.Property(e => e.DestinationCity)
                    .HasColumnName("destination_city")
                    .HasMaxLength(80);

                entity.Property(e => e.DestinationCode)
                    .HasColumnName("destination_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DestinationCountry)
                    .HasColumnName("destination_country")
                    .HasMaxLength(4);

                entity.Property(e => e.DestinationName)
                    .HasColumnName("destination_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DestinationPostalCode)
                    .HasColumnName("destination_postal_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DestinationRegion)
                    .HasColumnName("destination_region")
                    .HasMaxLength(4);

                entity.Property(e => e.DestinationStreet)
                    .HasColumnName("destination_street")
                    .HasMaxLength(70);

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DropBlock)
                    .HasColumnName("drop_block")
                    .HasMaxLength(30);

                entity.Property(e => e.DropCity)
                    .HasColumnName("drop_city")
                    .HasMaxLength(80);

                entity.Property(e => e.DropCode)
                    .HasColumnName("drop_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DropCountry)
                    .HasColumnName("drop_country")
                    .HasMaxLength(4);

                entity.Property(e => e.DropName)
                    .HasColumnName("drop_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DropPostalCode)
                    .HasColumnName("drop_postal_code")
                    .HasMaxLength(20);

                entity.Property(e => e.DropRegion)
                    .HasColumnName("drop_region")
                    .HasMaxLength(4);

                entity.Property(e => e.DropSeqNo).HasColumnName("drop_seq_no");

                entity.Property(e => e.DropStreet)
                    .HasColumnName("drop_street")
                    .HasMaxLength(70);

                entity.Property(e => e.DropstopSeqNo).HasColumnName("dropstop_seq_no");

                entity.Property(e => e.FromPrevStopDistance)
                    .HasColumnName("from_prev_stop_distance")
                    .HasColumnType("numeric(18,1)");

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.LoadLeg).HasColumnName("load_leg");

                entity.Property(e => e.MatFreightGrp)
                    .HasColumnName("mat_freight_grp")
                    .HasMaxLength(8);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(30);

                entity.Property(e => e.OriginBlock)
                    .HasColumnName("origin_block")
                    .HasMaxLength(30);

                entity.Property(e => e.OriginCity)
                    .HasColumnName("origin_city")
                    .HasMaxLength(80);

                entity.Property(e => e.OriginCode)
                    .HasColumnName("origin_code")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginCountry)
                    .HasColumnName("origin_country")
                    .HasMaxLength(4);

                entity.Property(e => e.OriginName)
                    .HasColumnName("origin_name")
                    .HasMaxLength(255);

                entity.Property(e => e.OriginPostalCode)
                    .HasColumnName("origin_postal_code")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginRegion)
                    .HasColumnName("origin_region")
                    .HasMaxLength(4);

                entity.Property(e => e.OriginStreet)
                    .HasColumnName("origin_street")
                    .HasMaxLength(70);

                entity.Property(e => e.PickSeqNo).HasColumnName("pick_seq_no");

                entity.Property(e => e.PickstopSeqNo).HasColumnName("pickstop_seq_no");

                entity.Property(e => e.PickupBlock)
                    .HasColumnName("pickup_block")
                    .HasMaxLength(30);

                entity.Property(e => e.PickupCity)
                    .HasColumnName("pickup_city")
                    .HasMaxLength(80);

                entity.Property(e => e.PickupCode)
                    .HasColumnName("pickup_code")
                    .HasMaxLength(20);

                entity.Property(e => e.PickupCountry)
                    .HasColumnName("pickup_country")
                    .HasMaxLength(4);

                entity.Property(e => e.PickupName)
                    .HasColumnName("pickup_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PickupPostalCode)
                    .HasColumnName("pickup_postal_code")
                    .HasMaxLength(20);

                entity.Property(e => e.PickupRegion)
                    .HasColumnName("pickup_region")
                    .HasMaxLength(4);

                entity.Property(e => e.PickupStreet)
                    .HasColumnName("pickup_street")
                    .HasMaxLength(70);

                entity.Property(e => e.PoNumber)
                    .HasColumnName("po_number")
                    .HasMaxLength(100);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion");

                entity.Property(e => e.ShipmentId)
                    .HasColumnName("shipment_id")
                    .HasColumnType("numeric(28,0)");

                entity.Property(e => e.ShipmentNonPrtbCtnt)
                    .HasColumnName("shipment_non_prtb_ctnt")
                    .HasMaxLength(2000);

                entity.Property(e => e.ShipmentPrtbCtnt)
                    .HasColumnName("shipment_prtb_ctnt")
                    .HasMaxLength(2000);

                entity.Property(e => e.ShipmentWeight)
                    .HasColumnName("shipment_weight")
                    .HasColumnType("numeric(11,4)");

                entity.Property(e => e.StopExtlCd1)
                    .HasColumnName("stop_extl_cd1")
                    .HasMaxLength(120);

                entity.Property(e => e.StopSeqNo).HasColumnName("stop_seq_no");
            });

            modelBuilder.Entity<ScvmvcTmsLoadMemo>(entity =>
            {
                entity.HasKey(e => e.LoadId)
                    .HasName("scvmvc_tms_load_memo_pkey");

                entity.ToTable("scvmvc_tms_load_memo", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_tms_load_memo_dms_rep_dtt_idx");

                entity.Property(e => e.LoadId)
                    .HasColumnName("load_id")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.LoadNonPrtbCtnt)
                    .HasColumnName("load_non_prtb_ctnt")
                    .HasMaxLength(2000);

                entity.Property(e => e.LoadPrtbCtnt)
                    .HasColumnName("load_prtb_ctnt")
                    .HasMaxLength(2000);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion");
            });

            modelBuilder.Entity<ScvmvcTmsLoadTracking>(entity =>
            {
                entity.HasKey(e => e.LoadId)
                    .HasName("scvmvc_tms_load_tracking_pkey");

                entity.ToTable("scvmvc_tms_load_tracking", "dom");

                entity.HasIndex(e => e.DmsRepDtt)
                    .HasName("scvmvc_tms_load_tracking_dms_rep_dtt_idx");

                entity.Property(e => e.LoadId)
                    .HasColumnName("load_id")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualCancel)
                    .HasColumnName("actual_cancel")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualInTransit)
                    .HasColumnName("actual_in_transit")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualOpen)
                    .HasColumnName("actual_open")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualPlan)
                    .HasColumnName("actual_plan")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualTender)
                    .HasColumnName("actual_tender")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.ActualTenderAccept)
                    .HasColumnName("actual_tender_accept")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.DmsRepDtt)
                    .HasColumnName("dms_rep_dtt")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion");
            });
        }
    }
}
