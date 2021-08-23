using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeWHDb
{
    public partial class QaWHContext : DbContext
    {
        public QaWHContext()
        {
        }

        public QaWHContext(DbContextOptions<QaWHContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<DmslsmTblActivity> DmslsmTblActivity { get; set; }
        //public virtual DbSet<DmslsmTblAddress> DmslsmTblAddress { get; set; }
        //public virtual DbSet<DmslsmTblAddressBackup> DmslsmTblAddressBackup { get; set; }
        //public virtual DbSet<DmslsmTblAmphur> DmslsmTblAmphur { get; set; }
        //public virtual DbSet<DmslsmTblCar> DmslsmTblCar { get; set; }
        //public virtual DbSet<DmslsmTblCarType> DmslsmTblCarType { get; set; }
        //public virtual DbSet<DmslsmTblCarrier> DmslsmTblCarrier { get; set; }
        //public virtual DbSet<DmslsmTblCustomer> DmslsmTblCustomer { get; set; }
        //public virtual DbSet<DmslsmTblDistribution> DmslsmTblDistribution { get; set; }
        //public virtual DbSet<DmslsmTblDistributionBackup> DmslsmTblDistributionBackup { get; set; }
        //public virtual DbSet<DmslsmTblDivision> DmslsmTblDivision { get; set; }
        //public virtual DbSet<DmslsmTblDriver> DmslsmTblDriver { get; set; }
        //public virtual DbSet<DmslsmTblDriverLog> DmslsmTblDriverLog { get; set; }
        //public virtual DbSet<DmslsmTblDriverRealtimeInfo> DmslsmTblDriverRealtimeInfo { get; set; }
        //public virtual DbSet<DmslsmTblFileAttachment> DmslsmTblFileAttachment { get; set; }
        //public virtual DbSet<DmslsmTblFleet> DmslsmTblFleet { get; set; }
        //public virtual DbSet<DmslsmTblFleetUser> DmslsmTblFleetUser { get; set; }
        //public virtual DbSet<DmslsmTblGroup> DmslsmTblGroup { get; set; }
        //public virtual DbSet<DmslsmTblHub> DmslsmTblHub { get; set; }
        //public virtual DbSet<DmslsmTblIdentifyProblem> DmslsmTblIdentifyProblem { get; set; }
        //public virtual DbSet<DmslsmTblIdentifyProblemRemark> DmslsmTblIdentifyProblemRemark { get; set; }
        //public virtual DbSet<DmslsmTblInvoice> DmslsmTblInvoice { get; set; }
        //public virtual DbSet<DmslsmTblInvoiceItem> DmslsmTblInvoiceItem { get; set; }
        //public virtual DbSet<DmslsmTblInvoiceReport> DmslsmTblInvoiceReport { get; set; }
        //public virtual DbSet<DmslsmTblJoinFleetCarrier> DmslsmTblJoinFleetCarrier { get; set; }
        //public virtual DbSet<DmslsmTblJoinGroupUser> DmslsmTblJoinGroupUser { get; set; }
        //public virtual DbSet<DmslsmTblLoginFailedAttempt> DmslsmTblLoginFailedAttempt { get; set; }
        //public virtual DbSet<DmslsmTblManualCloseRemark> DmslsmTblManualCloseRemark { get; set; }
        //public virtual DbSet<DmslsmTblMasterSetting> DmslsmTblMasterSetting { get; set; }
        //public virtual DbSet<DmslsmTblNumberStore> DmslsmTblNumberStore { get; set; }
        //public virtual DbSet<DmslsmTblOverspeedLog> DmslsmTblOverspeedLog { get; set; }
        //public virtual DbSet<DmslsmTblPermission> DmslsmTblPermission { get; set; }
        //public virtual DbSet<DmslsmTblProduct> DmslsmTblProduct { get; set; }
        //public virtual DbSet<DmslsmTblProvince> DmslsmTblProvince { get; set; }
        //public virtual DbSet<DmslsmTblRegion> DmslsmTblRegion { get; set; }
        //public virtual DbSet<DmslsmTblSegment> DmslsmTblSegment { get; set; }
        //public virtual DbSet<DmslsmTblShipment> DmslsmTblShipment { get; set; }
        //public virtual DbSet<DmslsmTblShipmentImportLog> DmslsmTblShipmentImportLog { get; set; }
        //public virtual DbSet<DmslsmTblShipmentItem> DmslsmTblShipmentItem { get; set; }
        //public virtual DbSet<DmslsmTblShippingMark> DmslsmTblShippingMark { get; set; }
        //public virtual DbSet<DmslsmTblSystemPreference> DmslsmTblSystemPreference { get; set; }
        //public virtual DbSet<DmslsmTblTmsImportHistory> DmslsmTblTmsImportHistory { get; set; }
        //public virtual DbSet<DmslsmTblTmsImportLog> DmslsmTblTmsImportLog { get; set; }
        //public virtual DbSet<DmslsmTblUser> DmslsmTblUser { get; set; }
        //public virtual DbSet<DmslsmTblUserCredential> DmslsmTblUserCredential { get; set; }
        //public virtual DbSet<DmslsmTblUserData> DmslsmTblUserData { get; set; }
        //public virtual DbSet<DmslsmTblUserProfile> DmslsmTblUserProfile { get; set; }
        //public virtual DbSet<DmslsmTblUserRememberMeToken> DmslsmTblUserRememberMeToken { get; set; }
        //public virtual DbSet<EscdbTbmClassification> EscdbTbmClassification { get; set; }
        //public virtual DbSet<EscdbTbmCommand> EscdbTbmCommand { get; set; }
        //public virtual DbSet<EscdbTbmContainnertype> EscdbTbmContainnertype { get; set; }
        //public virtual DbSet<EscdbTbmCountryzone> EscdbTbmCountryzone { get; set; }
        //public virtual DbSet<EscdbTbmCustomer> EscdbTbmCustomer { get; set; }
        //public virtual DbSet<EscdbTbmCustomerportmapping> EscdbTbmCustomerportmapping { get; set; }
        //public virtual DbSet<EscdbTbmCustomerspcommandmapping> EscdbTbmCustomerspcommandmapping { get; set; }
        //public virtual DbSet<EscdbTbmCustomerstoragecharge> EscdbTbmCustomerstoragecharge { get; set; }
        //public virtual DbSet<EscdbTbmCustshippingcustmapping> EscdbTbmCustshippingcustmapping { get; set; }
        //public virtual DbSet<EscdbTbmCustshippingstuffcharge> EscdbTbmCustshippingstuffcharge { get; set; }
        //public virtual DbSet<EscdbTbmDccustomermapping> EscdbTbmDccustomermapping { get; set; }
        //public virtual DbSet<EscdbTbmDeadstock> EscdbTbmDeadstock { get; set; }
        //public virtual DbSet<EscdbTbmDefaultinitialtransitzone> EscdbTbmDefaultinitialtransitzone { get; set; }
        //public virtual DbSet<EscdbTbmDistributioncenter> EscdbTbmDistributioncenter { get; set; }
        //public virtual DbSet<EscdbTbmFinaldestination> EscdbTbmFinaldestination { get; set; }
        //public virtual DbSet<EscdbTbmFumigate> EscdbTbmFumigate { get; set; }
        //public virtual DbSet<EscdbTbmHaulage> EscdbTbmHaulage { get; set; }
        //public virtual DbSet<EscdbTbmKanbanstatus> EscdbTbmKanbanstatus { get; set; }
        //public virtual DbSet<EscdbTbmLocation> EscdbTbmLocation { get; set; }
        //public virtual DbSet<EscdbTbmLocationLayout> EscdbTbmLocationLayout { get; set; }
        //public virtual DbSet<EscdbTbmLogoimage> EscdbTbmLogoimage { get; set; }
        //public virtual DbSet<EscdbTbmMisc> EscdbTbmMisc { get; set; }
        //public virtual DbSet<EscdbTbmOtp> EscdbTbmOtp { get; set; }
        //public virtual DbSet<EscdbTbmPackage> EscdbTbmPackage { get; set; }
        //public virtual DbSet<EscdbTbmPackageoutbound> EscdbTbmPackageoutbound { get; set; }
        //public virtual DbSet<EscdbTbmPackageoutboundd> EscdbTbmPackageoutboundd { get; set; }
        //public virtual DbSet<EscdbTbmPlantmapping> EscdbTbmPlantmapping { get; set; }
        //public virtual DbSet<EscdbTbmPort> EscdbTbmPort { get; set; }
        //public virtual DbSet<EscdbTbmProduct> EscdbTbmProduct { get; set; }
        //public virtual DbSet<EscdbTbmProductDetail> EscdbTbmProductDetail { get; set; }
        //public virtual DbSet<EscdbTbmProductcondition> EscdbTbmProductcondition { get; set; }
        //public virtual DbSet<EscdbTbmProductdefaultunit> EscdbTbmProductdefaultunit { get; set; }
        //public virtual DbSet<EscdbTbmProductdefaultzonetransit> EscdbTbmProductdefaultzonetransit { get; set; }
        //public virtual DbSet<EscdbTbmProducthandingcharge> EscdbTbmProducthandingcharge { get; set; }
        //public virtual DbSet<EscdbTbmProductnotification> EscdbTbmProductnotification { get; set; }
        //public virtual DbSet<EscdbTbmReceivepackage> EscdbTbmReceivepackage { get; set; }
        //public virtual DbSet<EscdbTbmRicetype> EscdbTbmRicetype { get; set; }
        //public virtual DbSet<EscdbTbmRoute> EscdbTbmRoute { get; set; }
        //public virtual DbSet<EscdbTbmRouted> EscdbTbmRouted { get; set; }
        //public virtual DbSet<EscdbTbmShipping> EscdbTbmShipping { get; set; }
        //public virtual DbSet<EscdbTbmShippingarea> EscdbTbmShippingarea { get; set; }
        //public virtual DbSet<EscdbTbmShippingcontainer> EscdbTbmShippingcontainer { get; set; }
        //public virtual DbSet<EscdbTbmShippingcustomer> EscdbTbmShippingcustomer { get; set; }
        //public virtual DbSet<EscdbTbmSpcommandcountryzonemapping> EscdbTbmSpcommandcountryzonemapping { get; set; }
        //public virtual DbSet<EscdbTbmSpcommandmapping> EscdbTbmSpcommandmapping { get; set; }
        //public virtual DbSet<EscdbTbmSpcommandmonthmapping> EscdbTbmSpcommandmonthmapping { get; set; }
        //public virtual DbSet<EscdbTbmSpecialcommand> EscdbTbmSpecialcommand { get; set; }
        //public virtual DbSet<EscdbTbmSubtypeofgoods> EscdbTbmSubtypeofgoods { get; set; }
        //public virtual DbSet<EscdbTbmSupplier> EscdbTbmSupplier { get; set; }
        //public virtual DbSet<EscdbTbmTransporttype> EscdbTbmTransporttype { get; set; }
        //public virtual DbSet<EscdbTbmTransportunstaffingcharge> EscdbTbmTransportunstaffingcharge { get; set; }
        //public virtual DbSet<EscdbTbmTruckcompany> EscdbTbmTruckcompany { get; set; }
        //public virtual DbSet<EscdbTbmTrucktransporttypemapping> EscdbTbmTrucktransporttypemapping { get; set; }
        //public virtual DbSet<EscdbTbmTypeofgoods> EscdbTbmTypeofgoods { get; set; }
        //public virtual DbSet<EscdbTbmTypeofunit> EscdbTbmTypeofunit { get; set; }
        //public virtual DbSet<EscdbTbmVessel> EscdbTbmVessel { get; set; }
        //public virtual DbSet<EscdbTbmWorkmethod> EscdbTbmWorkmethod { get; set; }
        //public virtual DbSet<EscdbTbmWorkmethodsetting> EscdbTbmWorkmethodsetting { get; set; }
        //public virtual DbSet<EscdbTbmZone> EscdbTbmZone { get; set; }
        //public virtual DbSet<EscdbTbmZonecustomermapping> EscdbTbmZonecustomermapping { get; set; }
        //public virtual DbSet<EscdbTbsAcJobnoRunning> EscdbTbsAcJobnoRunning { get; set; }
        //public virtual DbSet<EscdbTbsAmphur> EscdbTbsAmphur { get; set; }
        //public virtual DbSet<EscdbTbsControlbag> EscdbTbsControlbag { get; set; }
        //public virtual DbSet<EscdbTbsControlbatchno> EscdbTbsControlbatchno { get; set; }
        //public virtual DbSet<EscdbTbsControllot> EscdbTbsControllot { get; set; }
        //public virtual DbSet<EscdbTbsControlmixlot> EscdbTbsControlmixlot { get; set; }
        //public virtual DbSet<EscdbTbsControlpack> EscdbTbsControlpack { get; set; }
        //public virtual DbSet<EscdbTbsControlpallet> EscdbTbsControlpallet { get; set; }
        //public virtual DbSet<EscdbTbsControlpicking> EscdbTbsControlpicking { get; set; }
        //public virtual DbSet<EscdbTbsControlserial> EscdbTbsControlserial { get; set; }
        //public virtual DbSet<EscdbTbsControlshelflife> EscdbTbsControlshelflife { get; set; }
        //public virtual DbSet<EscdbTbsControlspecialcommand> EscdbTbsControlspecialcommand { get; set; }
        //public virtual DbSet<EscdbTbsControlvoid> EscdbTbsControlvoid { get; set; }
        //public virtual DbSet<EscdbTbsControlweight> EscdbTbsControlweight { get; set; }
        //public virtual DbSet<EscdbTbsDistrictOld> EscdbTbsDistrictOld { get; set; }
        //public virtual DbSet<EscdbTbsDoctype> EscdbTbsDoctype { get; set; }
        //public virtual DbSet<EscdbTbsFiletype> EscdbTbsFiletype { get; set; }
        //public virtual DbSet<EscdbTbsGeneratedocumentno> EscdbTbsGeneratedocumentno { get; set; }
        //public virtual DbSet<EscdbTbsItemexpiredtype> EscdbTbsItemexpiredtype { get; set; }
        //public virtual DbSet<EscdbTbsModule> EscdbTbsModule { get; set; }
        //public virtual DbSet<EscdbTbsMonth> EscdbTbsMonth { get; set; }
        //public virtual DbSet<EscdbTbsNotificationitem> EscdbTbsNotificationitem { get; set; }
        //public virtual DbSet<EscdbTbsOrderpattern> EscdbTbsOrderpattern { get; set; }
        //public virtual DbSet<EscdbTbsOtpmaster> EscdbTbsOtpmaster { get; set; }
        //public virtual DbSet<EscdbTbsPallettype> EscdbTbsPallettype { get; set; }
        //public virtual DbSet<EscdbTbsPortclassification> EscdbTbsPortclassification { get; set; }
        //public virtual DbSet<EscdbTbsProvince> EscdbTbsProvince { get; set; }
        //public virtual DbSet<EscdbTbsRankaging> EscdbTbsRankaging { get; set; }
        //public virtual DbSet<EscdbTbsRegion> EscdbTbsRegion { get; set; }
        //public virtual DbSet<EscdbTbsReportconfig> EscdbTbsReportconfig { get; set; }
        //public virtual DbSet<EscdbTbsScantype> EscdbTbsScantype { get; set; }
        //public virtual DbSet<EscdbTbsStatus> EscdbTbsStatus { get; set; }
        //public virtual DbSet<EscdbTbsSystemconfig> EscdbTbsSystemconfig { get; set; }
        //public virtual DbSet<EscdbTbsUnitconverttable> EscdbTbsUnitconverttable { get; set; }
        //public virtual DbSet<EscdbTbtPacking> EscdbTbtPacking { get; set; }
        //public virtual DbSet<EscdbTbtPackingd> EscdbTbtPackingd { get; set; }
        //public virtual DbSet<EscdbTbtPackingvoid> EscdbTbtPackingvoid { get; set; }
        //public virtual DbSet<EscdbTbtPalletmapping> EscdbTbtPalletmapping { get; set; }
        //public virtual DbSet<EscdbTbtPickingdetail> EscdbTbtPickingdetail { get; set; }
        //public virtual DbSet<EscdbTbtPickingdetailconfirmed> EscdbTbtPickingdetailconfirmed { get; set; }
        //public virtual DbSet<EscdbTbtPickingheader> EscdbTbtPickingheader { get; set; }
        //public virtual DbSet<EscdbTbtReceivingconfirmed> EscdbTbtReceivingconfirmed { get; set; }
        //public virtual DbSet<EscdbTbtReceivinginstructiondetail> EscdbTbtReceivinginstructiondetail { get; set; }
        //public virtual DbSet<EscdbTbtReceivinginstructionheader> EscdbTbtReceivinginstructionheader { get; set; }
        //public virtual DbSet<EscdbTbtReceivingstatus> EscdbTbtReceivingstatus { get; set; }
        //public virtual DbSet<EscdbTbtShippinginstruction> EscdbTbtShippinginstruction { get; set; }
        //public virtual DbSet<EscdbTbtShippingstatus> EscdbTbtShippingstatus { get; set; }
        //public virtual DbSet<EscdbTbtShippingtransportation> EscdbTbtShippingtransportation { get; set; }
        //public virtual DbSet<EscdbTbtStockbylocation> EscdbTbtStockbylocation { get; set; }
        //public virtual DbSet<EscdbTbtStockcountingdetail> EscdbTbtStockcountingdetail { get; set; }
        //public virtual DbSet<EscdbTbtStockcountingheader> EscdbTbtStockcountingheader { get; set; }
        //public virtual DbSet<EscdbTbtStockmovement> EscdbTbtStockmovement { get; set; }
        //public virtual DbSet<EscdbTbtSuggestpickinglocation> EscdbTbtSuggestpickinglocation { get; set; }
        //public virtual DbSet<EscdbTbtTagmapping> EscdbTbtTagmapping { get; set; }
        public virtual DbSet<TbmStockmaster> TbmStockmaster { get; set; }
        //public virtual DbSet<WmsdbTbmClassification> WmsdbTbmClassification { get; set; }
        //public virtual DbSet<WmsdbTbmCustomer> WmsdbTbmCustomer { get; set; }
        //public virtual DbSet<WmsdbTbmCustomerportmapping> WmsdbTbmCustomerportmapping { get; set; }
        //public virtual DbSet<WmsdbTbmCustshippingcustmapping> WmsdbTbmCustshippingcustmapping { get; set; }
        //public virtual DbSet<WmsdbTbmDccodemapping> WmsdbTbmDccodemapping { get; set; }
        //public virtual DbSet<WmsdbTbmDccustomermapping> WmsdbTbmDccustomermapping { get; set; }
        //public virtual DbSet<WmsdbTbmDeadstock> WmsdbTbmDeadstock { get; set; }
        //public virtual DbSet<WmsdbTbmDefaultinitialtransitzone> WmsdbTbmDefaultinitialtransitzone { get; set; }
        //public virtual DbSet<WmsdbTbmDistributioncenter> WmsdbTbmDistributioncenter { get; set; }
        //public virtual DbSet<WmsdbTbmFinaldestination> WmsdbTbmFinaldestination { get; set; }
        //public virtual DbSet<WmsdbTbmKanbanstatus> WmsdbTbmKanbanstatus { get; set; }
        //public virtual DbSet<WmsdbTbmLocation> WmsdbTbmLocation { get; set; }
        //public virtual DbSet<WmsdbTbmLocationLayout> WmsdbTbmLocationLayout { get; set; }
        //public virtual DbSet<WmsdbTbmLogoimage> WmsdbTbmLogoimage { get; set; }
        //public virtual DbSet<WmsdbTbmMisc> WmsdbTbmMisc { get; set; }
        //public virtual DbSet<WmsdbTbmOtp> WmsdbTbmOtp { get; set; }
        //public virtual DbSet<WmsdbTbmPackage> WmsdbTbmPackage { get; set; }
        //public virtual DbSet<WmsdbTbmPackageoutbound> WmsdbTbmPackageoutbound { get; set; }
        //public virtual DbSet<WmsdbTbmPackageoutboundd> WmsdbTbmPackageoutboundd { get; set; }
        //public virtual DbSet<WmsdbTbmPlantmapping> WmsdbTbmPlantmapping { get; set; }
        //public virtual DbSet<WmsdbTbmPort> WmsdbTbmPort { get; set; }
        //public virtual DbSet<WmsdbTbmProduct> WmsdbTbmProduct { get; set; }
        //public virtual DbSet<WmsdbTbmProductDetail> WmsdbTbmProductDetail { get; set; }
        //public virtual DbSet<WmsdbTbmProductcondition> WmsdbTbmProductcondition { get; set; }
        //public virtual DbSet<WmsdbTbmProductdefaultunit> WmsdbTbmProductdefaultunit { get; set; }
        //public virtual DbSet<WmsdbTbmProductdefaultzonetransit> WmsdbTbmProductdefaultzonetransit { get; set; }
        //public virtual DbSet<WmsdbTbmProducthandingcharge> WmsdbTbmProducthandingcharge { get; set; }
        //public virtual DbSet<WmsdbTbmProductnotification> WmsdbTbmProductnotification { get; set; }
        //public virtual DbSet<WmsdbTbmRoute> WmsdbTbmRoute { get; set; }
        //public virtual DbSet<WmsdbTbmRouted> WmsdbTbmRouted { get; set; }
        //public virtual DbSet<WmsdbTbmShippingarea> WmsdbTbmShippingarea { get; set; }
        //public virtual DbSet<WmsdbTbmShippingcontainer> WmsdbTbmShippingcontainer { get; set; }
        //public virtual DbSet<WmsdbTbmShippingcustomer> WmsdbTbmShippingcustomer { get; set; }
        //public virtual DbSet<WmsdbTbmSubtypeofgoods> WmsdbTbmSubtypeofgoods { get; set; }
        //public virtual DbSet<WmsdbTbmSupplier> WmsdbTbmSupplier { get; set; }
        //public virtual DbSet<WmsdbTbmTransporttype> WmsdbTbmTransporttype { get; set; }
        //public virtual DbSet<WmsdbTbmTransportunstaffingcharge> WmsdbTbmTransportunstaffingcharge { get; set; }
        //public virtual DbSet<WmsdbTbmTruckcompany> WmsdbTbmTruckcompany { get; set; }
        //public virtual DbSet<WmsdbTbmTrucktransporttypemapping> WmsdbTbmTrucktransporttypemapping { get; set; }
        //public virtual DbSet<WmsdbTbmTypeofgoods> WmsdbTbmTypeofgoods { get; set; }
        //public virtual DbSet<WmsdbTbmTypeofunit> WmsdbTbmTypeofunit { get; set; }
        //public virtual DbSet<WmsdbTbmWorkmethod> WmsdbTbmWorkmethod { get; set; }
        //public virtual DbSet<WmsdbTbmWorkmethodsetting> WmsdbTbmWorkmethodsetting { get; set; }
        //public virtual DbSet<WmsdbTbmZone> WmsdbTbmZone { get; set; }
        //public virtual DbSet<WmsdbTbmZonecustomermapping> WmsdbTbmZonecustomermapping { get; set; }
        //public virtual DbSet<WmsdbTbmZoneusermapping> WmsdbTbmZoneusermapping { get; set; }
        //public virtual DbSet<WmsdbTbsAcJobnoRunning> WmsdbTbsAcJobnoRunning { get; set; }
        //public virtual DbSet<WmsdbTbsAmphur> WmsdbTbsAmphur { get; set; }
        //public virtual DbSet<WmsdbTbsControlbag> WmsdbTbsControlbag { get; set; }
        //public virtual DbSet<WmsdbTbsControllot> WmsdbTbsControllot { get; set; }
        //public virtual DbSet<WmsdbTbsControlmixlot> WmsdbTbsControlmixlot { get; set; }
        //public virtual DbSet<WmsdbTbsControlpack> WmsdbTbsControlpack { get; set; }
        //public virtual DbSet<WmsdbTbsControlpallet> WmsdbTbsControlpallet { get; set; }
        //public virtual DbSet<WmsdbTbsControlpicking> WmsdbTbsControlpicking { get; set; }
        //public virtual DbSet<WmsdbTbsControlserial> WmsdbTbsControlserial { get; set; }
        //public virtual DbSet<WmsdbTbsControlshelflife> WmsdbTbsControlshelflife { get; set; }
        //public virtual DbSet<WmsdbTbsControlvoid> WmsdbTbsControlvoid { get; set; }
        //public virtual DbSet<WmsdbTbsDistrictOld> WmsdbTbsDistrictOld { get; set; }
        //public virtual DbSet<WmsdbTbsDoctype> WmsdbTbsDoctype { get; set; }
        //public virtual DbSet<WmsdbTbsFiletype> WmsdbTbsFiletype { get; set; }
        //public virtual DbSet<WmsdbTbsGeneratedocumentno> WmsdbTbsGeneratedocumentno { get; set; }
        //public virtual DbSet<WmsdbTbsItemexpiredtype> WmsdbTbsItemexpiredtype { get; set; }
        //public virtual DbSet<WmsdbTbsModule> WmsdbTbsModule { get; set; }
        //public virtual DbSet<WmsdbTbsNotificationitem> WmsdbTbsNotificationitem { get; set; }
        //public virtual DbSet<WmsdbTbsOrderpattern> WmsdbTbsOrderpattern { get; set; }
        //public virtual DbSet<WmsdbTbsOrordertype> WmsdbTbsOrordertype { get; set; }
        //public virtual DbSet<WmsdbTbsOtpmaster> WmsdbTbsOtpmaster { get; set; }
        //public virtual DbSet<WmsdbTbsPallettype> WmsdbTbsPallettype { get; set; }
        //public virtual DbSet<WmsdbTbsPoordertype> WmsdbTbsPoordertype { get; set; }
        //public virtual DbSet<WmsdbTbsPortclassification> WmsdbTbsPortclassification { get; set; }
        //public virtual DbSet<WmsdbTbsProvince> WmsdbTbsProvince { get; set; }
        //public virtual DbSet<WmsdbTbsRankaging> WmsdbTbsRankaging { get; set; }
        //public virtual DbSet<WmsdbTbsRegion> WmsdbTbsRegion { get; set; }
        //public virtual DbSet<WmsdbTbsReportconfig> WmsdbTbsReportconfig { get; set; }
        //public virtual DbSet<WmsdbTbsScantype> WmsdbTbsScantype { get; set; }
        //public virtual DbSet<WmsdbTbsStatus> WmsdbTbsStatus { get; set; }
        //public virtual DbSet<WmsdbTbsSystemconfig> WmsdbTbsSystemconfig { get; set; }
        //public virtual DbSet<WmsdbTbsUnitconverttable> WmsdbTbsUnitconverttable { get; set; }
        //public virtual DbSet<WmsdbTbtPacking> WmsdbTbtPacking { get; set; }
        //public virtual DbSet<WmsdbTbtPackingd> WmsdbTbtPackingd { get; set; }
        //public virtual DbSet<WmsdbTbtPackingvoid> WmsdbTbtPackingvoid { get; set; }
        //public virtual DbSet<WmsdbTbtPalletmapping> WmsdbTbtPalletmapping { get; set; }
        //public virtual DbSet<WmsdbTbtPickingdetail> WmsdbTbtPickingdetail { get; set; }
        //public virtual DbSet<WmsdbTbtPickingdetailconfirmed> WmsdbTbtPickingdetailconfirmed { get; set; }
        //public virtual DbSet<WmsdbTbtPickingheader> WmsdbTbtPickingheader { get; set; }
        //public virtual DbSet<WmsdbTbtReceivingconfirmed> WmsdbTbtReceivingconfirmed { get; set; }
        //public virtual DbSet<WmsdbTbtReceivinginstructiondetail> WmsdbTbtReceivinginstructiondetail { get; set; }
        //public virtual DbSet<WmsdbTbtReceivinginstructionheader> WmsdbTbtReceivinginstructionheader { get; set; }
        //public virtual DbSet<WmsdbTbtReceivingstatus> WmsdbTbtReceivingstatus { get; set; }
        //public virtual DbSet<WmsdbTbtShippinginstruction> WmsdbTbtShippinginstruction { get; set; }
        //public virtual DbSet<WmsdbTbtShippingstatus> WmsdbTbtShippingstatus { get; set; }
        //public virtual DbSet<WmsdbTbtStockbylocation> WmsdbTbtStockbylocation { get; set; }
        //public virtual DbSet<WmsdbTbtStockcountingdetail> WmsdbTbtStockcountingdetail { get; set; }
        //public virtual DbSet<WmsdbTbtStockcountingheader> WmsdbTbtStockcountingheader { get; set; }
        //public virtual DbSet<WmsdbTbtStockmovement> WmsdbTbtStockmovement { get; set; }
        //public virtual DbSet<WmsdbTbtSuggestpickinglocation> WmsdbTbtSuggestpickinglocation { get; set; }
        //public virtual DbSet<WmsdbTbtTagmapping> WmsdbTbtTagmapping { get; set; }

        // Unable to generate entity type for table 'wh.dmslsm_tbl_join_group_permission'. Please see the warning messages.
        // Unable to generate entity type for table 'wh.dmslsm_tbl_join_user_role'. Please see the warning messages.
        // Unable to generate entity type for table 'wh.dmslsm_tbl_logoms'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=qa-datalake-pg.cluster-ro-ctg0nvlybzpq.ap-southeast-1.rds.amazonaws.com; Username =csi_report; Password =CSI@SCGL; Database =pd_datalake", x => x.UseNodaTime());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("postgis")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            //modelBuilder.Entity<DmslsmTblActivity>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_activity", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Action)
            //        .HasColumnName("action")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Json).HasColumnName("json");

            //    entity.Property(e => e.Namespace)
            //        .HasColumnName("namespace")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Note).HasColumnName("note");

            //    entity.Property(e => e.ObjectId).HasColumnName("object_id");

            //    entity.Property(e => e.RequestId)
            //        .HasColumnName("request_id")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.SessionId)
            //        .HasColumnName("session_id")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<DmslsmTblAddress>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_address", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Building)
            //        .HasColumnName("building")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CheckInScanBarcode).HasColumnName("check_in_scan_barcode");

            //    entity.Property(e => e.CheckIngps).HasColumnName("check_ingps");

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DestinationInvoice).HasColumnName("destination_invoice");

            //    entity.Property(e => e.DestinationShippingMark).HasColumnName("destination_shipping_mark");

            //    entity.Property(e => e.DestinationSku).HasColumnName("destination_sku");

            //    entity.Property(e => e.DestinationSkuOneByOne).HasColumnName("destination_sku_one_by_one");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Latitude).HasColumnName("latitude");

            //    entity.Property(e => e.Location)
            //        .HasColumnName("location")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Longitude).HasColumnName("longitude");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Radius).HasColumnName("radius");

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RegionId).HasColumnName("region_id");

            //    entity.Property(e => e.ReturnDay).HasColumnName("return_day");

            //    entity.Property(e => e.Street)
            //        .HasColumnName("street")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.SuggestedLatitude).HasColumnName("suggested_latitude");

            //    entity.Property(e => e.SuggestedLongitude).HasColumnName("suggested_longitude");

            //    entity.Property(e => e.Type)
            //        .HasColumnName("type")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblAddressBackup>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_address_backup", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Building)
            //        .HasColumnName("building")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CheckInScanBarcode).HasColumnName("check_in_scan_barcode");

            //    entity.Property(e => e.CheckIngps).HasColumnName("check_ingps");

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DestinationInvoice).HasColumnName("destination_invoice");

            //    entity.Property(e => e.DestinationShippingMark).HasColumnName("destination_shipping_mark");

            //    entity.Property(e => e.DestinationSku).HasColumnName("destination_sku");

            //    entity.Property(e => e.DestinationSkuOneByOne).HasColumnName("destination_sku_one_by_one");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Latitude).HasColumnName("latitude");

            //    entity.Property(e => e.Location)
            //        .HasColumnName("location")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Longitude).HasColumnName("longitude");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Radius).HasColumnName("radius");

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RegionId).HasColumnName("region_id");

            //    entity.Property(e => e.ReturnDay).HasColumnName("return_day");

            //    entity.Property(e => e.Street)
            //        .HasColumnName("street")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.SuggestedLatitude).HasColumnName("suggested_latitude");

            //    entity.Property(e => e.SuggestedLongitude).HasColumnName("suggested_longitude");

            //    entity.Property(e => e.Type)
            //        .HasColumnName("type")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblAmphur>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_amphur", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Code)
            //        .HasColumnName("code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ProvinceId).HasColumnName("province_id");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblCar>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_car", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.CarAbsentType)
            //        .HasColumnName("car_absent_type")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CarId).HasColumnName("car_id");

            //    entity.Property(e => e.CarTaxExpiry)
            //        .HasColumnName("car_tax_expiry")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CarTypeId).HasColumnName("car_type_id");

            //    entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Editable).HasColumnName("editable");

            //    entity.Property(e => e.FleetId).HasColumnName("fleet_id");

            //    entity.Property(e => e.IsBusy).HasColumnName("is_busy");

            //    entity.Property(e => e.License)
            //        .HasColumnName("license")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.LicenseRegister)
            //        .HasColumnName("license_register")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblCarType>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_car_type", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.LifeSpan).HasColumnName("life_span");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");

            //    entity.Property(e => e.Wheels)
            //        .HasColumnName("wheels")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<DmslsmTblCarrier>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_carrier", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.AmphurId).HasColumnName("amphur_id");

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Email)
            //        .HasColumnName("email")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Fax)
            //        .HasColumnName("fax")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ProvinceId).HasColumnName("province_id");

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.Tel)
            //        .HasColumnName("tel")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.TripPerMonth).HasColumnName("trip_per_month");

            //    entity.Property(e => e.TruckSupplyPercentage).HasColumnName("truck_supply_percentage");

            //    entity.Property(e => e.UserStatus).HasColumnName("user_status");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblCustomer>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_customer", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.CustomerCode)
            //        .HasColumnName("customer_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblDistribution>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_distribution", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.AddressId).HasColumnName("address_id");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RegionId).HasColumnName("region_id");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblDistributionBackup>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_distribution_backup", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.AddressId).HasColumnName("address_id");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RegionId).HasColumnName("region_id");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblDivision>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_division", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblDriver>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_driver", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.ActiveTime)
            //        .HasColumnName("active_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.BatteryRemaining).HasColumnName("battery_remaining");

            //    entity.Property(e => e.Birthday)
            //        .HasColumnName("birthday")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Block).HasColumnName("block");

            //    entity.Property(e => e.BlockCounter).HasColumnName("block_counter");

            //    entity.Property(e => e.BlockedCause)
            //        .HasColumnName("blocked_cause")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.BlockedOn)
            //        .HasColumnName("blocked_on")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CarId).HasColumnName("car_id");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.CurrentSpeed).HasColumnName("current_speed");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Editable).HasColumnName("editable");

            //    entity.Property(e => e.Fname)
            //        .HasColumnName("fname")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ForwardShipmentId).HasColumnName("forward_shipment_id");

            //    entity.Property(e => e.LastJob)
            //        .HasColumnName("last_job")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.LastOnlineTime)
            //        .HasColumnName("last_online_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.LastOverspeedTime)
            //        .HasColumnName("last_overspeed_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.LatestLatitude).HasColumnName("latest_latitude");

            //    entity.Property(e => e.LatestLongitude).HasColumnName("latest_longitude");

            //    entity.Property(e => e.LicenseExpiry)
            //        .HasColumnName("license_expiry")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Lname)
            //        .HasColumnName("lname")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Mobile)
            //        .HasColumnName("mobile")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Nname)
            //        .HasColumnName("nname")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.PersonalId)
            //        .HasColumnName("personal_id")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Ready).HasColumnName("ready");

            //    entity.Property(e => e.RegionId).HasColumnName("region_id");

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.ReturnDocWithin).HasColumnName("return_doc_within");

            //    entity.Property(e => e.SdccertificateExpiry)
            //        .HasColumnName("sdccertificate_expiry")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.UserStatus).HasColumnName("user_status");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblDriverLog>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_driver_log", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Block).HasColumnName("block");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Driver).HasColumnName("driver");

            //    entity.Property(e => e.DriverId).HasColumnName("driver_id");

            //    entity.Property(e => e.DriverLog).HasColumnName("driver_log");

            //    entity.Property(e => e.ForwardShipmentId).HasColumnName("forward_shipment_id");

            //    entity.Property(e => e.Inactive).HasColumnName("inactive");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.OverSpeedAction).HasColumnName("over_speed_action");

            //    entity.Property(e => e.OverSpeedNote).HasColumnName("over_speed_note");

            //    entity.Property(e => e.OverSpeedObservation).HasColumnName("over_speed_observation");

            //    entity.Property(e => e.OverSpeedRootCause).HasColumnName("over_speed_root_cause");

            //    entity.Property(e => e.Overspeed).HasColumnName("overspeed");

            //    entity.Property(e => e.Rejection).HasColumnName("rejection");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Speed).HasColumnName("speed");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblDriverRealtimeInfo>(entity =>
            //{
            //    entity.HasKey(e => e.DriverId)
            //        .HasName("dmslsm_tbl_driver_realtime_info_pkey");

            //    entity.ToTable("dmslsm_tbl_driver_realtime_info", "wh");

            //    entity.Property(e => e.DriverId)
            //        .HasColumnName("driver_id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.BatteryRemaining).HasColumnName("battery_remaining");

            //    entity.Property(e => e.CurrentSpeed).HasColumnName("current_speed");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.LastOnlineTime)
            //        .HasColumnName("last_online_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.LatestLatitude).HasColumnName("latest_latitude");

            //    entity.Property(e => e.LatestLongitude).HasColumnName("latest_longitude");
            //});

            //modelBuilder.Entity<DmslsmTblFileAttachment>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_file_attachment", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

            //    entity.Property(e => e.Metadata).HasColumnName("metadata");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Path)
            //        .HasColumnName("path")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

            //    entity.Property(e => e.ShipmentItemId).HasColumnName("shipment_item_id");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblFleet>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_fleet", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.HubId).HasColumnName("hub_id");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RegionId).HasColumnName("region_id");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblFleetUser>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_fleet_user", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.FleetId).HasColumnName("fleet_id");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.UserId).HasColumnName("user_id");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblGroup>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_group", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasColumnName("name")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Title)
            //        .HasColumnName("title")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<DmslsmTblHub>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_hub", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.AddressId).HasColumnName("address_id");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RegionId).HasColumnName("region_id");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblIdentifyProblem>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_identify_problem", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Action).HasColumnName("action");

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DriverId).HasColumnName("driver_id");

            //    entity.Property(e => e.IdentifyProblemStatus).HasColumnName("identify_problem_status");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Note).HasColumnName("note");

            //    entity.Property(e => e.Number)
            //        .HasColumnName("number")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Observation).HasColumnName("observation");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ReporterId).HasColumnName("reporter_id");

            //    entity.Property(e => e.RootCause).HasColumnName("root_cause");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblIdentifyProblemRemark>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_identify_problem_remark", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Code)
            //        .HasColumnName("code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Reason).HasColumnName("reason");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblInvoice>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_invoice", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.CustomerCode)
            //        .HasColumnName("customer_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CustomerId).HasColumnName("customer_id");

            //    entity.Property(e => e.CustomerName)
            //        .HasColumnName("customer_name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Damaged).HasColumnName("damaged");

            //    entity.Property(e => e.DelayedRemarkId).HasColumnName("delayed_remark_id");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DivisionCode)
            //        .HasColumnName("division_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DivisionId).HasColumnName("division_id");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DnNumber)
            //        .HasColumnName("dn_number")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DocReturnStatus)
            //        .HasColumnName("doc_return_status")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DocReturnTime)
            //        .HasColumnName("doc_return_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.FreightNumber)
            //        .HasColumnName("freight_number")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.FromAddressId)
            //        .HasColumnName("from_address_id")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.FromCityName)
            //        .HasColumnName("from_city_name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.FromCountryCode)
            //        .HasColumnName("from_country_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.FromId).HasColumnName("from_id");

            //    entity.Property(e => e.FromName)
            //        .HasColumnName("from_name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.FromPostalCode)
            //        .HasColumnName("from_postal_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.FromRegionCode)
            //        .HasColumnName("from_region_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.HasBeenRemoved).HasColumnName("has_been_removed");

            //    entity.Property(e => e.HasChanged).HasColumnName("has_changed");

            //    entity.Property(e => e.HasRevised).HasColumnName("has_revised");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.NeedRevise).HasColumnName("need_revise");

            //    entity.Property(e => e.Number)
            //        .HasColumnName("number")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.OriginalCreated)
            //        .HasColumnName("original_created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.OriginalIdentifier)
            //        .HasColumnName("original_identifier")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.OriginalUpdated)
            //        .HasColumnName("original_updated")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.PlannedDocReturnTime)
            //        .HasColumnName("planned_doc_return_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.RemovedShipment)
            //        .HasColumnName("removed_shipment")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.SegmentCode)
            //        .HasColumnName("segment_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.SegmentId).HasColumnName("segment_id");

            //    entity.Property(e => e.ShipmentItemId).HasColumnName("shipment_item_id");

            //    entity.Property(e => e.ShippedFromCode)
            //        .HasColumnName("shipped_from_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ShippedFromEnum)
            //        .HasColumnName("shipped_from_enum")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ShippedToCode)
            //        .HasColumnName("shipped_to_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ShippedToEnum)
            //        .HasColumnName("shipped_to_enum")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.State)
            //        .HasColumnName("state")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.TempShipmentItemId).HasColumnName("temp_shipment_item_id");

            //    entity.Property(e => e.ToAddressId)
            //        .HasColumnName("to_address_id")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ToCityName)
            //        .HasColumnName("to_city_name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ToCountryCode)
            //        .HasColumnName("to_country_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ToId).HasColumnName("to_id");

            //    entity.Property(e => e.ToName)
            //        .HasColumnName("to_name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ToPostalCode)
            //        .HasColumnName("to_postal_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ToRegionCode)
            //        .HasColumnName("to_region_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblInvoiceItem>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_invoice_item", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.Damaged).HasColumnName("damaged");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

            //    entity.Property(e => e.ManualBarcode)
            //        .HasColumnName("manual_barcode")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ManualCloseRemark).HasColumnName("manual_close_remark");

            //    entity.Property(e => e.MatBarCode)
            //        .HasColumnName("mat_bar_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Number)
            //        .HasColumnName("number")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.OriginalComponentId)
            //        .HasColumnName("original_component_id")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.OriginalIdentifier)
            //        .HasColumnName("original_identifier")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.OriginalInvoiceId)
            //        .HasColumnName("original_invoice_id")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Quantity).HasColumnName("quantity");

            //    entity.Property(e => e.QuantityFromGi).HasColumnName("quantity_from_gi");

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.ReturnedQuantity).HasColumnName("returned_quantity");

            //    entity.Property(e => e.ScannedQuantity).HasColumnName("scanned_quantity");

            //    entity.Property(e => e.ShippingMarkBarcode)
            //        .HasColumnName("shipping_mark_barcode")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblInvoiceReport>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_invoice_report", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.FileAttachmentId).HasColumnName("file_attachment_id");

            //    entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblJoinFleetCarrier>(entity =>
            //{
            //    entity.HasKey(e => new { e.CarrierId, e.FleetId })
            //        .HasName("dmslsm_tbl_join_fleet_carrier_pkey");

            //    entity.ToTable("dmslsm_tbl_join_fleet_carrier", "wh");

            //    entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

            //    entity.Property(e => e.FleetId).HasColumnName("fleet_id");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<DmslsmTblJoinGroupUser>(entity =>
            //{
            //    entity.HasKey(e => new { e.GroupId, e.UserId })
            //        .HasName("dmslsm_tbl_join_group_user_pkey");

            //    entity.ToTable("dmslsm_tbl_join_group_user", "wh");

            //    entity.Property(e => e.GroupId).HasColumnName("group_id");

            //    entity.Property(e => e.UserId).HasColumnName("user_id");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<DmslsmTblLoginFailedAttempt>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_login_failed_attempt", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Username)
            //        .HasColumnName("username")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<DmslsmTblManualCloseRemark>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_manual_close_remark", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Code)
            //        .HasColumnName("code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Reason).HasColumnName("reason");

            //    entity.Property(e => e.Response).HasColumnName("response");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblMasterSetting>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_master_setting", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.AcceptJobTime).HasColumnName("accept_job_time");

            //    entity.Property(e => e.ActiveResetTime).HasColumnName("active_reset_time");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DocReturnDay).HasColumnName("doc_return_day");
            //});

            //modelBuilder.Entity<DmslsmTblNumberStore>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_number_store", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.CurrentNumber).HasColumnName("current_number");

            //    entity.Property(e => e.DateId)
            //        .HasColumnName("date_id")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.EntityKey)
            //        .HasColumnName("entity_key")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<DmslsmTblOverspeedLog>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_overspeed_log", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.AverageSpeed).HasColumnName("average_speed");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DriverId).HasColumnName("driver_id");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.OverspeedRemarkId).HasColumnName("overspeed_remark_id");

            //    entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblPermission>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_permission", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Ability)
            //        .IsRequired()
            //        .HasColumnName("ability")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Component)
            //        .IsRequired()
            //        .HasColumnName("component")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Enabled).HasColumnName("enabled");

            //    entity.Property(e => e.Module)
            //        .IsRequired()
            //        .HasColumnName("module")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasColumnName("name")
            //        .HasMaxLength(60);

            //    entity.Property(e => e.SortingOrder).HasColumnName("sorting_order");

            //    entity.Property(e => e.Title)
            //        .HasColumnName("title")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<DmslsmTblProduct>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_product", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Height).HasColumnName("height");

            //    entity.Property(e => e.Length).HasColumnName("length");

            //    entity.Property(e => e.MatBarCode).HasColumnName("mat_bar_code");

            //    entity.Property(e => e.MatDealer).HasColumnName("mat_dealer");

            //    entity.Property(e => e.Matscgl).HasColumnName("matscgl");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name).HasColumnName("name");

            //    entity.Property(e => e.Version).HasColumnName("version");

            //    entity.Property(e => e.Volume).HasColumnName("volume");

            //    entity.Property(e => e.Weight).HasColumnName("weight");

            //    entity.Property(e => e.Width).HasColumnName("width");
            //});

            //modelBuilder.Entity<DmslsmTblProvince>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_province", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Abbreviation)
            //        .HasColumnName("abbreviation")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Code)
            //        .HasColumnName("code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RegionId).HasColumnName("region_id");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblRegion>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_region", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Code)
            //        .HasColumnName("code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.MCode)
            //        .HasColumnName("m_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblSegment>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_segment", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ExternalCode)
            //        .HasColumnName("external_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblShipment>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_shipment", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.AcceptTime)
            //        .HasColumnName("accept_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.ActualChargeAmount).HasColumnName("actual_charge_amount");

            //    entity.Property(e => e.AssignTime)
            //        .HasColumnName("assign_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CarId).HasColumnName("car_id");

            //    entity.Property(e => e.CarrierCode)
            //        .HasColumnName("carrier_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

            //    entity.Property(e => e.ChargeAmount).HasColumnName("charge_amount");

            //    entity.Property(e => e.CheckInManually).HasColumnName("check_in_manually");

            //    entity.Property(e => e.CheckInPlanRemarkId).HasColumnName("check_in_plan_remark_id");

            //    entity.Property(e => e.CheckInTime)
            //        .HasColumnName("check_in_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CheckOutManually).HasColumnName("check_out_manually");

            //    entity.Property(e => e.CheckOutPlanRemarkId).HasColumnName("check_out_plan_remark_id");

            //    entity.Property(e => e.CheckOutTime)
            //        .HasColumnName("check_out_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.CustomerCode)
            //        .HasColumnName("customer_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CustomerName)
            //        .HasColumnName("customer_name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Damaged).HasColumnName("damaged");

            //    entity.Property(e => e.DeliveryDate)
            //        .HasColumnName("delivery_date")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DeplayedRemarkId).HasColumnName("deplayed_remark_id");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DirectDistance).HasColumnName("direct_distance");

            //    entity.Property(e => e.DisableAlert).HasColumnName("disable_alert");

            //    entity.Property(e => e.DivisionCode)
            //        .HasColumnName("division_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DivisionId).HasColumnName("division_id");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DriverId).HasColumnName("driver_id");

            //    entity.Property(e => e.EndActiveTime)
            //        .HasColumnName("end_active_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.EndTime)
            //        .HasColumnName("end_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.EquipmentType)
            //        .HasColumnName("equipment_type")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.FirstAddressId).HasColumnName("first_address_id");

            //    entity.Property(e => e.FleetId).HasColumnName("fleet_id");

            //    entity.Property(e => e.FrstShpgLocCd)
            //        .HasColumnName("frst_shpg_loc_cd")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.HasChanged).HasColumnName("has_changed");

            //    entity.Property(e => e.HasLowProgress).HasColumnName("has_low_progress");

            //    entity.Property(e => e.HasRevised).HasColumnName("has_revised");

            //    entity.Property(e => e.LastAddressId).HasColumnName("last_address_id");

            //    entity.Property(e => e.LastShpgLocCd)
            //        .HasColumnName("last_shpg_loc_cd")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.LatestLatitude).HasColumnName("latest_latitude");

            //    entity.Property(e => e.LatestLongitude).HasColumnName("latest_longitude");

            //    entity.Property(e => e.MileDistance).HasColumnName("mile_distance");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.NeedRevise).HasColumnName("need_revise");

            //    entity.Property(e => e.Number)
            //        .HasColumnName("number")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.OriginalCreated)
            //        .HasColumnName("original_created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.OriginalUpdated)
            //        .HasColumnName("original_updated")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.PlannedAcceptTime)
            //        .HasColumnName("planned_accept_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.PlannedCheckInTime)
            //        .HasColumnName("planned_check_in_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.PlannedCheckOutTime)
            //        .HasColumnName("planned_check_out_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Progress).HasColumnName("progress");

            //    entity.Property(e => e.ProgressRemarkId).HasColumnName("progress_remark_id");

            //    entity.Property(e => e.RefCode)
            //        .HasColumnName("ref_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.RejectedCount).HasColumnName("rejected_count");

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.ReverseShipmentId).HasColumnName("reverse_shipment_id");

            //    entity.Property(e => e.SegmentCode)
            //        .HasColumnName("segment_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.SegmentId).HasColumnName("segment_id");

            //    entity.Property(e => e.ShipmentImportLogId).HasColumnName("shipment_import_log_id");

            //    entity.Property(e => e.ShipmentTimeOut)
            //        .HasColumnName("shipment_time_out")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ShippedFromEnum)
            //        .HasColumnName("shipped_from_enum")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ShippedToEnum)
            //        .HasColumnName("shipped_to_enum")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.StartActiveTime)
            //        .HasColumnName("start_active_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.StartTime)
            //        .HasColumnName("start_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.State)
            //        .HasColumnName("state")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.StateCode).HasColumnName("state_code");

            //    entity.Property(e => e.TotalDrivingHours).HasColumnName("total_driving_hours");

            //    entity.Property(e => e.Type)
            //        .HasColumnName("type")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");

            //    entity.Property(e => e.Volume).HasColumnName("volume");

            //    entity.Property(e => e.Weight).HasColumnName("weight");
            //});

            //modelBuilder.Entity<DmslsmTblShipmentImportLog>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_shipment_import_log", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.FileAttachmentId).HasColumnName("file_attachment_id");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblShipmentItem>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_shipment_item", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.AddressId).HasColumnName("address_id");

            //    entity.Property(e => e.CheckInTime)
            //        .HasColumnName("check_in_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CheckOutTime)
            //        .HasColumnName("check_out_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.Damaged).HasColumnName("damaged");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DnNumber).HasColumnName("dn_number");

            //    entity.Property(e => e.DnNumberLongtext).HasColumnName("dn_number_longtext");

            //    entity.Property(e => e.HasRevised).HasColumnName("has_revised");

            //    entity.Property(e => e.HasSignature).HasColumnName("has_signature");

            //    entity.Property(e => e.LongText)
            //        .HasColumnName("long_text")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.OriginalIdentifier)
            //        .HasColumnName("original_identifier")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.OriginalShipmentId)
            //        .HasColumnName("original_shipment_id")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.PlannedCheckInTime)
            //        .HasColumnName("planned_check_in_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.PlannedCheckOutTime)
            //        .HasColumnName("planned_check_out_time")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Remark).HasColumnName("remark");

            //    entity.Property(e => e.RoughDistance).HasColumnName("rough_distance");

            //    entity.Property(e => e.SequenceNumber)
            //        .HasColumnName("sequence_number")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

            //    entity.Property(e => e.ShippedToCode)
            //        .HasColumnName("shipped_to_code")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.State)
            //        .HasColumnName("state")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Type)
            //        .HasColumnName("type")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblShippingMark>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_shipping_mark", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.InvoiceItemId).HasColumnName("invoice_item_id");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.Number)
            //        .HasColumnName("number")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Quantity).HasColumnName("quantity");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblSystemPreference>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_system_preference", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Value)
            //        .HasColumnName("value")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblTmsImportHistory>(entity =>
            //{
            //    entity.HasKey(e => e.LoadLegId)
            //        .HasName("dmslsm_tbl_tms_import_history_pkey");

            //    entity.ToTable("dmslsm_tbl_tms_import_history", "wh");

            //    entity.Property(e => e.LoadLegId)
            //        .HasColumnName("load_leg_id")
            //        .HasMaxLength(255)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.LastUpdate)
            //        .HasColumnName("last_update")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<DmslsmTblTmsImportLog>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_tms_import_log", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ImportEnd)
            //        .HasColumnName("import_end")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ImportStart)
            //        .HasColumnName("import_start")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.NumRows).HasColumnName("num_rows");
            //});

            //modelBuilder.Entity<DmslsmTblUser>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_user", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DefaultRole)
            //        .HasColumnName("default_role")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Disabled).HasColumnName("disabled");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Email)
            //        .HasColumnName("email")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Expiry)
            //        .HasColumnName("expiry")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Locked).HasColumnName("locked");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Username)
            //        .HasColumnName("username")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<DmslsmTblUserCredential>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_user_credential", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Expiry)
            //        .HasColumnName("expiry")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.HashedPassword)
            //        .HasColumnName("hashed_password")
            //        .HasMaxLength(128);

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Password)
            //        .HasColumnName("password")
            //        .HasMaxLength(128);

            //    entity.Property(e => e.Salt)
            //        .HasColumnName("salt")
            //        .HasMaxLength(128);

            //    entity.Property(e => e.UserId).HasColumnName("user_id");
            //});

            //modelBuilder.Entity<DmslsmTblUserData>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_user_data", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

            //    entity.Property(e => e.Created)
            //        .HasColumnName("created")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            //    entity.Property(e => e.CustomerId).HasColumnName("customer_id");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DriverId).HasColumnName("driver_id");

            //    entity.Property(e => e.Modified)
            //        .HasColumnName("modified")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

            //    entity.Property(e => e.UserId).HasColumnName("user_id");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<DmslsmTblUserProfile>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_user_profile", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Firstname)
            //        .HasColumnName("firstname")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Lastname)
            //        .HasColumnName("lastname")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Locale)
            //        .HasColumnName("locale")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.UserId).HasColumnName("user_id");
            //});

            //modelBuilder.Entity<DmslsmTblUserRememberMeToken>(entity =>
            //{
            //    entity.ToTable("dmslsm_tbl_user_remember_me_token", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Date)
            //        .HasColumnName("date")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Series)
            //        .HasColumnName("series")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.TokenValue)
            //        .HasColumnName("token_value")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Username)
            //        .HasColumnName("username")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<EscdbTbmClassification>(entity =>
            //{
            //    entity.HasKey(e => e.Classificationid)
            //        .HasName("escdb_tbm_classification_pkey");

            //    entity.ToTable("escdb_tbm_classification", "wh");

            //    entity.Property(e => e.Classificationid)
            //        .HasColumnName("classificationid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Classificationcode)
            //        .IsRequired()
            //        .HasColumnName("classificationcode")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Classificationname)
            //        .HasColumnName("classificationname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmCommand>(entity =>
            //{
            //    entity.HasKey(e => e.Commandid)
            //        .HasName("escdb_tbm_command_pkey");

            //    entity.ToTable("escdb_tbm_command", "wh");

            //    entity.Property(e => e.Commandid)
            //        .HasColumnName("commandid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Commandname)
            //        .IsRequired()
            //        .HasColumnName("commandname")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");
            //});

            //modelBuilder.Entity<EscdbTbmContainnertype>(entity =>
            //{
            //    entity.HasKey(e => e.Containnertypeid)
            //        .HasName("escdb_tbm_containnertype_pkey");

            //    entity.ToTable("escdb_tbm_containnertype", "wh");

            //    entity.Property(e => e.Containnertypeid)
            //        .HasColumnName("containnertypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Containnertypename)
            //        .IsRequired()
            //        .HasColumnName("containnertypename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");
            //});

            //modelBuilder.Entity<EscdbTbmCountryzone>(entity =>
            //{
            //    entity.HasKey(e => e.Countryzoneid)
            //        .HasName("escdb_tbm_countryzone_pkey");

            //    entity.ToTable("escdb_tbm_countryzone", "wh");

            //    entity.Property(e => e.Countryzoneid)
            //        .HasColumnName("countryzoneid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Countryzonecode)
            //        .HasColumnName("countryzonecode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Remark).HasColumnName("remark");
            //});

            //modelBuilder.Entity<EscdbTbmCustomer>(entity =>
            //{
            //    entity.HasKey(e => e.Customerid)
            //        .HasName("escdb_tbm_customer_pkey");

            //    entity.ToTable("escdb_tbm_customer", "wh");

            //    entity.Property(e => e.Customerid)
            //        .HasColumnName("customerid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Businesstype)
            //        .HasColumnName("businesstype")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customeraddress)
            //        .HasColumnName("customeraddress")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Customercode)
            //        .IsRequired()
            //        .HasColumnName("customercode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customername)
            //        .IsRequired()
            //        .HasColumnName("customername")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Defaultinventoryunit).HasColumnName("defaultinventoryunit");

            //    entity.Property(e => e.Defaultreceivingdatetype).HasColumnName("defaultreceivingdatetype");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Emailaddress)
            //        .HasColumnName("emailaddress")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Stateorprovince)
            //        .HasColumnName("stateorprovince")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmCustomerportmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Portid })
            //        .HasName("escdb_tbm_customerportmapping_pkey");

            //    entity.ToTable("escdb_tbm_customerportmapping", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Portid).HasColumnName("portid");
            //});

            //modelBuilder.Entity<EscdbTbmCustomerspcommandmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Specialcommandid })
            //        .HasName("escdb_tbm_customerspcommandmapping_pkey");

            //    entity.ToTable("escdb_tbm_customerspcommandmapping", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Specialcommandid).HasColumnName("specialcommandid");
            //});

            //modelBuilder.Entity<EscdbTbmCustomerstoragecharge>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Effectivedate })
            //        .HasName("escdb_tbm_customerstoragecharge_pkey");

            //    entity.ToTable("escdb_tbm_customerstoragecharge", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Effectivedate)
            //        .HasColumnName("effectivedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Extrastoragecharge)
            //        .HasColumnName("extrastoragecharge")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Minstorage)
            //        .HasColumnName("minstorage")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Minstoragechargeprice)
            //        .HasColumnName("minstoragechargeprice")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockover)
            //        .HasColumnName("stockover")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<EscdbTbmCustshippingcustmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Shippingcustomerid })
            //        .HasName("escdb_tbm_custshippingcustmapping_pkey");

            //    entity.ToTable("escdb_tbm_custshippingcustmapping", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");
            //});

            //modelBuilder.Entity<EscdbTbmCustshippingstuffcharge>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shippingcustomerid, e.Effectivedate })
            //        .HasName("escdb_tbm_custshippingstuffcharge_pkey");

            //    entity.ToTable("escdb_tbm_custshippingstuffcharge", "wh");

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");

            //    entity.Property(e => e.Effectivedate)
            //        .HasColumnName("effectivedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Stuffingcharge)
            //        .HasColumnName("stuffingcharge")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<EscdbTbmDccustomermapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Dcid, e.Customerid })
            //        .HasName("escdb_tbm_dccustomermapping_pkey");

            //    entity.ToTable("escdb_tbm_dccustomermapping", "wh");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");
            //});

            //modelBuilder.Entity<EscdbTbmDeadstock>(entity =>
            //{
            //    entity.HasKey(e => e.Codename)
            //        .HasName("escdb_tbm_deadstock_pkey");

            //    entity.ToTable("escdb_tbm_deadstock", "wh");

            //    entity.Property(e => e.Codename)
            //        .HasColumnName("codename")
            //        .HasMaxLength(50)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Codedescription)
            //        .HasColumnName("codedescription")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Databasename)
            //        .HasColumnName("databasename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Emptystockday).HasColumnName("emptystockday");

            //    entity.Property(e => e.Expbillingcostday).HasColumnName("expbillingcostday");

            //    entity.Property(e => e.Expbillingdataday).HasColumnName("expbillingdataday");

            //    entity.Property(e => e.Exphistoryday).HasColumnName("exphistoryday");

            //    entity.Property(e => e.Expreceivecompleteday).HasColumnName("expreceivecompleteday");

            //    entity.Property(e => e.Expreceiveincompleteday).HasColumnName("expreceiveincompleteday");

            //    entity.Property(e => e.Expserialdataday).HasColumnName("expserialdataday");

            //    entity.Property(e => e.Expshippingcompleteday).HasColumnName("expshippingcompleteday");

            //    entity.Property(e => e.Expshippingincompleteday).HasColumnName("expshippingincompleteday");

            //    entity.Property(e => e.Expstocktaking).HasColumnName("expstocktaking");

            //    entity.Property(e => e.Login)
            //        .HasColumnName("login")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Password)
            //        .HasColumnName("password")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Servername)
            //        .HasColumnName("servername")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmDefaultinitialtransitzone>(entity =>
            //{
            //    entity.HasKey(e => new { e.Dccode, e.Ownercode, e.Zonecode, e.Productconditioncode })
            //        .HasName("escdb_tbm_defaultinitialtransitzone_pkey");

            //    entity.ToTable("escdb_tbm_defaultinitialtransitzone", "wh");

            //    entity.Property(e => e.Dccode)
            //        .HasColumnName("dccode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Ownercode)
            //        .HasColumnName("ownercode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Zonecode)
            //        .HasColumnName("zonecode")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Productconditioncode)
            //        .HasColumnName("productconditioncode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmDistributioncenter>(entity =>
            //{
            //    entity.HasKey(e => e.Dcid)
            //        .HasName("escdb_tbm_distributioncenter_pkey");

            //    entity.ToTable("escdb_tbm_distributioncenter", "wh");

            //    entity.Property(e => e.Dcid)
            //        .HasColumnName("dcid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Address1)
            //        .HasColumnName("address1")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Address2)
            //        .HasColumnName("address2")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Controlpackid).HasColumnName("controlpackid");

            //    entity.Property(e => e.Controlpalletid).HasColumnName("controlpalletid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Dccode)
            //        .IsRequired()
            //        .HasColumnName("dccode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Dclongname)
            //        .HasColumnName("dclongname")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Defaultdamageroutecode)
            //        .HasColumnName("defaultdamageroutecode")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Externaldivisionflag).HasColumnName("externaldivisionflag");

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Inchargeemail)
            //        .HasColumnName("inchargeemail")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Manpower).HasColumnName("manpower");

            //    entity.Property(e => e.Maxcapacity)
            //        .HasColumnName("maxcapacity")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Maxm2)
            //        .HasColumnName("maxm2")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Maxm3)
            //        .HasColumnName("maxm3")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Maxpallet).HasColumnName("maxpallet");

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Noofforklift).HasColumnName("noofforklift");

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Staginglocationcode)
            //        .HasColumnName("staginglocationcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmFinaldestination>(entity =>
            //{
            //    entity.HasKey(e => e.Finaldestinationid)
            //        .HasName("escdb_tbm_finaldestination_pkey");

            //    entity.ToTable("escdb_tbm_finaldestination", "wh");

            //    entity.Property(e => e.Finaldestinationid)
            //        .HasColumnName("finaldestinationid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Countryzoneid).HasColumnName("countryzoneid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Finaldestinationaddress)
            //        .HasColumnName("finaldestinationaddress")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Finaldestinationcode)
            //        .IsRequired()
            //        .HasColumnName("finaldestinationcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Finaldestinationdetail)
            //        .HasColumnName("finaldestinationdetail")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Finaldestinationlongname)
            //        .HasColumnName("finaldestinationlongname")
            //        .HasMaxLength(250);

            //    entity.Property(e => e.Imagefile).HasColumnName("imagefile");

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Km)
            //        .HasColumnName("km")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Leadtimedays).HasColumnName("leadtimedays");

            //    entity.Property(e => e.Leadtimehr)
            //        .HasColumnName("leadtimehr")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");

            //    entity.Property(e => e.Stateorprovince)
            //        .HasColumnName("stateorprovince")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmFumigate>(entity =>
            //{
            //    entity.HasKey(e => e.Fumigateid)
            //        .HasName("escdb_tbm_fumigate_pkey");

            //    entity.ToTable("escdb_tbm_fumigate", "wh");

            //    entity.Property(e => e.Fumigateid)
            //        .HasColumnName("fumigateid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Fumigatename)
            //        .IsRequired()
            //        .HasColumnName("fumigatename")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbmHaulage>(entity =>
            //{
            //    entity.HasKey(e => e.Haulageid)
            //        .HasName("escdb_tbm_haulage_pkey");

            //    entity.ToTable("escdb_tbm_haulage", "wh");

            //    entity.Property(e => e.Haulageid)
            //        .HasColumnName("haulageid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Haulagename)
            //        .IsRequired()
            //        .HasColumnName("haulagename")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbmKanbanstatus>(entity =>
            //{
            //    entity.HasKey(e => e.Kanbanstatusid)
            //        .HasName("escdb_tbm_kanbanstatus_pkey");

            //    entity.ToTable("escdb_tbm_kanbanstatus", "wh");

            //    entity.Property(e => e.Kanbanstatusid)
            //        .HasColumnName("kanbanstatusid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Kanbanstatus)
            //        .HasColumnName("kanbanstatus")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmLocation>(entity =>
            //{
            //    entity.HasKey(e => e.Locationid)
            //        .HasName("escdb_tbm_location_pkey");

            //    entity.ToTable("escdb_tbm_location", "wh");

            //    entity.Property(e => e.Locationid)
            //        .HasColumnName("locationid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Capacityunitid).HasColumnName("capacityunitid");

            //    entity.Property(e => e.Controlmixlotid).HasColumnName("controlmixlotid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Fullcapacityflag).HasColumnName("fullcapacityflag");

            //    entity.Property(e => e.Layoutid).HasColumnName("layoutid");

            //    entity.Property(e => e.Level)
            //        .HasColumnName("level")
            //        .HasMaxLength(2);

            //    entity.Property(e => e.Locationcode)
            //        .IsRequired()
            //        .HasColumnName("locationcode")
            //        .HasMaxLength(17);

            //    entity.Property(e => e.Locationlogoff).HasColumnName("locationlogoff");

            //    entity.Property(e => e.Locationname)
            //        .IsRequired()
            //        .HasColumnName("locationname")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Locationtypeid).HasColumnName("locationtypeid");

            //    entity.Property(e => e.Maxcapacity)
            //        .HasColumnName("maxcapacity")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Maxm2)
            //        .HasColumnName("maxm2")
            //        .HasColumnType("numeric(18,5)");

            //    entity.Property(e => e.Maxm3)
            //        .HasColumnName("maxm3")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Maxunit).HasColumnName("maxunit");

            //    entity.Property(e => e.Noofpallet).HasColumnName("noofpallet");

            //    entity.Property(e => e.Pickingpriority).HasColumnName("pickingpriority");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Rackno)
            //        .IsRequired()
            //        .HasColumnName("rackno")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Sequencepick).HasColumnName("sequencepick");

            //    entity.Property(e => e.Stack).HasColumnName("stack");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            //});

            //modelBuilder.Entity<EscdbTbmLocationLayout>(entity =>
            //{
            //    entity.HasKey(e => e.Layoutid)
            //        .HasName("escdb_tbm_location_layout_pkey");

            //    entity.ToTable("escdb_tbm_location_layout", "wh");

            //    entity.Property(e => e.Layoutid)
            //        .HasColumnName("layoutid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Captionposition)
            //        .IsRequired()
            //        .HasColumnName("captionposition")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.Height).HasColumnName("height");

            //    entity.Property(e => e.Locationlayoutcode)
            //        .IsRequired()
            //        .HasColumnName("locationlayoutcode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Locationlayoutname)
            //        .IsRequired()
            //        .HasColumnName("locationlayoutname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Positionx).HasColumnName("positionx");

            //    entity.Property(e => e.Positiony).HasColumnName("positiony");

            //    entity.Property(e => e.Type)
            //        .IsRequired()
            //        .HasColumnName("type")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Width).HasColumnName("width");
            //});

            //modelBuilder.Entity<EscdbTbmLogoimage>(entity =>
            //{
            //    entity.HasKey(e => e.Logoid)
            //        .HasName("escdb_tbm_logoimage_pkey");

            //    entity.ToTable("escdb_tbm_logoimage", "wh");

            //    entity.Property(e => e.Logoid)
            //        .HasColumnName("logoid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Logofilename).HasColumnName("logofilename");
            //});

            //modelBuilder.Entity<EscdbTbmMisc>(entity =>
            //{
            //    entity.HasKey(e => new { e.Propertyfield, e.Propertyid })
            //        .HasName("escdb_tbm_misc_pkey");

            //    entity.ToTable("escdb_tbm_misc", "wh");

            //    entity.Property(e => e.Propertyfield)
            //        .HasColumnName("propertyfield")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Propertyid).HasColumnName("propertyid");

            //    entity.Property(e => e.Isactive).HasColumnName("isactive");

            //    entity.Property(e => e.Propertycode)
            //        .IsRequired()
            //        .HasColumnName("propertycode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Propertydescription)
            //        .HasColumnName("propertydescription")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Propertyname)
            //        .HasColumnName("propertyname")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Propertysequence).HasColumnName("propertysequence");
            //});

            //modelBuilder.Entity<EscdbTbmOtp>(entity =>
            //{
            //    entity.ToTable("escdb_tbm_otp", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Otpcode)
            //        .HasColumnName("otpcode")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.Otpexpired)
            //        .HasColumnName("otpexpired")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Usercode)
            //        .HasColumnName("usercode")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmPackage>(entity =>
            //{
            //    entity.HasKey(e => e.Packageid)
            //        .HasName("escdb_tbm_package_pkey");

            //    entity.ToTable("escdb_tbm_package", "wh");

            //    entity.Property(e => e.Packageid)
            //        .HasColumnName("packageid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Packagecode)
            //        .IsRequired()
            //        .HasColumnName("packagecode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Packagename)
            //        .HasColumnName("packagename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(2550);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmPackageoutbound>(entity =>
            //{
            //    entity.HasKey(e => e.Packageid)
            //        .HasName("escdb_tbm_packageoutbound_pkey");

            //    entity.ToTable("escdb_tbm_packageoutbound", "wh");

            //    entity.Property(e => e.Packageid)
            //        .HasColumnName("packageid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Packagecode)
            //        .IsRequired()
            //        .HasColumnName("packagecode")
            //        .HasMaxLength(12);

            //    entity.Property(e => e.Packagename)
            //        .HasColumnName("packagename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(2550);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmPackageoutboundd>(entity =>
            //{
            //    entity.HasKey(e => new { e.Effectivedate, e.Packageid, e.Servicetypeid })
            //        .HasName("escdb_tbm_packageoutboundd_pkey");

            //    entity.ToTable("escdb_tbm_packageoutboundd", "wh");

            //    entity.Property(e => e.Effectivedate).HasColumnName("effectivedate");

            //    entity.Property(e => e.Packageid).HasColumnName("packageid");

            //    entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Servicecharge)
            //        .HasColumnName("servicecharge")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<EscdbTbmPlantmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Plant, e.Dccode, e.Ownercode })
            //        .HasName("escdb_tbm_plantmapping_pkey");

            //    entity.ToTable("escdb_tbm_plantmapping", "wh");

            //    entity.Property(e => e.Plant)
            //        .HasColumnName("plant")
            //        .HasMaxLength(8);

            //    entity.Property(e => e.Dccode)
            //        .HasColumnName("dccode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Ownercode)
            //        .HasColumnName("ownercode")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmPort>(entity =>
            //{
            //    entity.HasKey(e => e.Portid)
            //        .HasName("escdb_tbm_port_pkey");

            //    entity.ToTable("escdb_tbm_port", "wh");

            //    entity.Property(e => e.Portid)
            //        .HasColumnName("portid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Countrycode)
            //        .HasColumnName("countrycode")
            //        .HasMaxLength(4);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Leadtimedays).HasColumnName("leadtimedays");

            //    entity.Property(e => e.Leadtimehr)
            //        .HasColumnName("leadtimehr")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Portaddress)
            //        .HasColumnName("portaddress")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Portclassification).HasColumnName("portclassification");

            //    entity.Property(e => e.Portcode)
            //        .IsRequired()
            //        .HasColumnName("portcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Portlongname)
            //        .HasColumnName("portlongname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmProduct>(entity =>
            //{
            //    entity.HasKey(e => e.Productid)
            //        .HasName("escdb_tbm_product_pkey");

            //    entity.ToTable("escdb_tbm_product", "wh");

            //    entity.Property(e => e.Productid)
            //        .HasColumnName("productid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Accpaclocation)
            //        .HasColumnName("accpaclocation")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Classificationid).HasColumnName("classificationid");

            //    entity.Property(e => e.Controlbagid).HasColumnName("controlbagid");

            //    entity.Property(e => e.Controlbatchno).HasColumnName("controlbatchno");

            //    entity.Property(e => e.Controllotid).HasColumnName("controllotid");

            //    entity.Property(e => e.Controlpalletid).HasColumnName("controlpalletid");

            //    entity.Property(e => e.Controlpickingid).HasColumnName("controlpickingid");

            //    entity.Property(e => e.Controlserialid).HasColumnName("controlserialid");

            //    entity.Property(e => e.Controlspecialcommand).HasColumnName("controlspecialcommand");

            //    entity.Property(e => e.Controlvoidid).HasColumnName("controlvoidid");

            //    entity.Property(e => e.Controlweight).HasColumnName("controlweight");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Estimatevalue)
            //        .HasColumnName("estimatevalue")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Firstnooflevel).HasColumnName("firstnooflevel");

            //    entity.Property(e => e.Firstnoperrow).HasColumnName("firstnoperrow");

            //    entity.Property(e => e.Firststandardarrangement).HasColumnName("firststandardarrangement");

            //    entity.Property(e => e.Freeofcharge).HasColumnName("freeofcharge");

            //    entity.Property(e => e.Imagefile).HasColumnName("imagefile");

            //    entity.Property(e => e.Itemexpiredtypeid).HasColumnName("itemexpiredtypeid");

            //    entity.Property(e => e.Kanbancontrol).HasColumnName("kanbancontrol");

            //    entity.Property(e => e.Lotcontrol).HasColumnName("lotcontrol");

            //    entity.Property(e => e.Maker)
            //        .HasColumnName("maker")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Needqc).HasColumnName("needqc");

            //    entity.Property(e => e.Nooflevel).HasColumnName("nooflevel");

            //    entity.Property(e => e.Noperrow).HasColumnName("noperrow");

            //    entity.Property(e => e.Pallettypeid).HasColumnName("pallettypeid");

            //    entity.Property(e => e.Prefixdomestic)
            //        .HasColumnName("prefixdomestic")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Prefixexport)
            //        .HasColumnName("prefixexport")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Prefiximport)
            //        .HasColumnName("prefiximport")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Price)
            //        .HasColumnName("price")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Productbarcode)
            //        .HasColumnName("productbarcode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Productcode)
            //        .IsRequired()
            //        .HasColumnName("productcode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Productlongname)
            //        .HasColumnName("productlongname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Productmask)
            //        .HasColumnName("productmask")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Safetystock)
            //        .HasColumnName("safetystock")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Scantype).HasColumnName("scantype");

            //    entity.Property(e => e.Seriallength).HasColumnName("seriallength");

            //    entity.Property(e => e.Serialmask)
            //        .HasColumnName("serialmask")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Shelflife).HasColumnName("shelflife");

            //    entity.Property(e => e.Shelflifepicking).HasColumnName("shelflifepicking");

            //    entity.Property(e => e.Shelflifereceive).HasColumnName("shelflifereceive");

            //    entity.Property(e => e.Standardarrangement).HasColumnName("standardarrangement");

            //    entity.Property(e => e.Subtypeofgoodsid).HasColumnName("subtypeofgoodsid");

            //    entity.Property(e => e.Syncdate)
            //        .HasColumnName("syncdate")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Typeofgoodsid).HasColumnName("typeofgoodsid");

            //    entity.Property(e => e.Unitlevelreceivinglabel).HasColumnName("unitlevelreceivinglabel");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmProductDetail>(entity =>
            //{
            //    entity.HasKey(e => new { e.Productid, e.Plant })
            //        .HasName("escdb_tbm_product_detail_pkey");

            //    entity.ToTable("escdb_tbm_product_detail", "wh");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Plant)
            //        .HasColumnName("plant")
            //        .HasMaxLength(4);

            //    entity.Property(e => e.Countryoforigin)
            //        .HasColumnName("countryoforigin")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Hierachyfirst3char)
            //        .HasColumnName("hierachyfirst3char")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Materialgroup2)
            //        .HasColumnName("materialgroup2")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Materialgroup3)
            //        .HasColumnName("materialgroup3")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Materialgroup4)
            //        .HasColumnName("materialgroup4")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Materialtype)
            //        .HasColumnName("materialtype")
            //        .HasMaxLength(4);

            //    entity.Property(e => e.Sku)
            //        .HasColumnName("sku")
            //        .HasMaxLength(18);

            //    entity.Property(e => e.Skudescription)
            //        .HasColumnName("skudescription")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Status)
            //        .HasColumnName("status")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.Stc)
            //        .HasColumnName("stc")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Uom)
            //        .HasColumnName("uom")
            //        .HasMaxLength(3);
            //});

            //modelBuilder.Entity<EscdbTbmProductcondition>(entity =>
            //{
            //    entity.HasKey(e => e.Productconditionid)
            //        .HasName("escdb_tbm_productcondition_pkey");

            //    entity.ToTable("escdb_tbm_productcondition", "wh");

            //    entity.Property(e => e.Productconditionid)
            //        .HasColumnName("productconditionid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Productconditioncode)
            //        .IsRequired()
            //        .HasColumnName("productconditioncode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Productconditionname)
            //        .IsRequired()
            //        .HasColumnName("productconditionname")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmProductdefaultunit>(entity =>
            //{
            //    entity.HasKey(e => new { e.Productid, e.Packageid })
            //        .HasName("escdb_tbm_productdefaultunit_pkey");

            //    entity.ToTable("escdb_tbm_productdefaultunit", "wh");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Packageid).HasColumnName("packageid");

            //    entity.Property(e => e.Barcodeofunitlevel1)
            //        .HasColumnName("barcodeofunitlevel1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Barcodeofunitlevel2)
            //        .HasColumnName("barcodeofunitlevel2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Barcodeofunitlevel3)
            //        .HasColumnName("barcodeofunitlevel3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Barcodeofunitlevel4)
            //        .HasColumnName("barcodeofunitlevel4")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Grossweight)
            //        .HasColumnName("grossweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.M3)
            //        .HasColumnName("m3")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Netweight)
            //        .HasColumnName("netweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Numberofunitlevel2)
            //        .HasColumnName("numberofunitlevel2")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Numberofunitlevel3)
            //        .HasColumnName("numberofunitlevel3")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Numberofunitlevel4)
            //        .HasColumnName("numberofunitlevel4")
            //        .HasColumnType("numeric(18,5)");

            //    entity.Property(e => e.Rpttypeofunitlevel1).HasColumnName("rpttypeofunitlevel1");

            //    entity.Property(e => e.Rpttypeofunitlevel2).HasColumnName("rpttypeofunitlevel2");

            //    entity.Property(e => e.Rpttypeofunitlevel3).HasColumnName("rpttypeofunitlevel3");

            //    entity.Property(e => e.Rpttypeofunitlevel4).HasColumnName("rpttypeofunitlevel4");

            //    entity.Property(e => e.Typeofunitdisplay).HasColumnName("typeofunitdisplay");

            //    entity.Property(e => e.Typeofunitinventory).HasColumnName("typeofunitinventory");

            //    entity.Property(e => e.Typeofunitlevel1).HasColumnName("typeofunitlevel1");

            //    entity.Property(e => e.Typeofunitlevel2).HasColumnName("typeofunitlevel2");

            //    entity.Property(e => e.Typeofunitlevel3).HasColumnName("typeofunitlevel3");

            //    entity.Property(e => e.Typeofunitlevel4).HasColumnName("typeofunitlevel4");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Volumeofunitlevel1)
            //        .HasColumnName("volumeofunitlevel1")
            //        .HasColumnType("numeric(19,5)");
            //});

            //modelBuilder.Entity<EscdbTbmProductdefaultzonetransit>(entity =>
            //{
            //    entity.HasKey(e => new { e.Productid, e.Productconditionid, e.Zoneid, e.Locationid })
            //        .HasName("escdb_tbm_productdefaultzonetransit_pkey");

            //    entity.ToTable("escdb_tbm_productdefaultzonetransit", "wh");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmProducthandingcharge>(entity =>
            //{
            //    entity.HasKey(e => e.Seqno)
            //        .HasName("escdb_tbm_producthandingcharge_pkey");

            //    entity.ToTable("escdb_tbm_producthandingcharge", "wh");

            //    entity.Property(e => e.Seqno)
            //        .HasColumnName("seqno")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Effectivedate).HasColumnName("effectivedate");

            //    entity.Property(e => e.Incomingcharge)
            //        .HasColumnName("incomingcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Outgoingcharge)
            //        .HasColumnName("outgoingcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Packageid).HasColumnName("packageid");

            //    entity.Property(e => e.Pickingcharge)
            //        .HasColumnName("pickingcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Status).HasColumnName("status");

            //    entity.Property(e => e.Transitcharge)
            //        .HasColumnName("transitcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Typeofunitincoming).HasColumnName("typeofunitincoming");

            //    entity.Property(e => e.Typeofunitoutgoing).HasColumnName("typeofunitoutgoing");

            //    entity.Property(e => e.Typeofunitpicking).HasColumnName("typeofunitpicking");

            //    entity.Property(e => e.Typeofunittransit).HasColumnName("typeofunittransit");

            //    entity.Property(e => e.Typeofunitvoid).HasColumnName("typeofunitvoid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Voidcharge)
            //        .HasColumnName("voidcharge")
            //        .HasColumnType("numeric(18,2)");
            //});

            //modelBuilder.Entity<EscdbTbmProductnotification>(entity =>
            //{
            //    entity.HasKey(e => new { e.Productid, e.Notificationitemid })
            //        .HasName("escdb_tbm_productnotification_pkey");

            //    entity.ToTable("escdb_tbm_productnotification", "wh");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Notificationitemid).HasColumnName("notificationitemid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmReceivepackage>(entity =>
            //{
            //    entity.HasKey(e => e.Receivepackageid)
            //        .HasName("escdb_tbm_receivepackage_pkey");

            //    entity.ToTable("escdb_tbm_receivepackage", "wh");

            //    entity.Property(e => e.Receivepackageid)
            //        .HasColumnName("receivepackageid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Receivepackagename)
            //        .IsRequired()
            //        .HasColumnName("receivepackagename")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbmRicetype>(entity =>
            //{
            //    entity.HasKey(e => e.Ricetypeid)
            //        .HasName("escdb_tbm_ricetype_pkey");

            //    entity.ToTable("escdb_tbm_ricetype", "wh");

            //    entity.Property(e => e.Ricetypeid)
            //        .HasColumnName("ricetypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Ricetype)
            //        .IsRequired()
            //        .HasColumnName("ricetype")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbmRoute>(entity =>
            //{
            //    entity.HasKey(e => e.Routeid)
            //        .HasName("escdb_tbm_route_pkey");

            //    entity.ToTable("escdb_tbm_route", "wh");

            //    entity.Property(e => e.Routeid)
            //        .HasColumnName("routeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Routecode)
            //        .IsRequired()
            //        .HasColumnName("routecode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Routename)
            //        .HasColumnName("routename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmRouted>(entity =>
            //{
            //    entity.HasKey(e => new { e.Routeid, e.Sequenceno })
            //        .HasName("escdb_tbm_routed_pkey");

            //    entity.ToTable("escdb_tbm_routed", "wh");

            //    entity.Property(e => e.Routeid).HasColumnName("routeid");

            //    entity.Property(e => e.Sequenceno).HasColumnName("sequenceno");

            //    entity.Property(e => e.Amphurid).HasColumnName("amphurid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Finaldestinationid).HasColumnName("finaldestinationid");

            //    entity.Property(e => e.Provinceid).HasColumnName("provinceid");

            //    entity.Property(e => e.Routeseqno).HasColumnName("routeseqno");
            //});

            //modelBuilder.Entity<EscdbTbmShipping>(entity =>
            //{
            //    entity.HasKey(e => e.Shippingid)
            //        .HasName("escdb_tbm_shipping_pkey");

            //    entity.ToTable("escdb_tbm_shipping", "wh");

            //    entity.Property(e => e.Shippingid)
            //        .HasColumnName("shippingid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Shippingname)
            //        .IsRequired()
            //        .HasColumnName("shippingname")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbmShippingarea>(entity =>
            //{
            //    entity.HasKey(e => e.Shippingareaid)
            //        .HasName("escdb_tbm_shippingarea_pkey");

            //    entity.ToTable("escdb_tbm_shippingarea", "wh");

            //    entity.Property(e => e.Shippingareaid)
            //        .HasColumnName("shippingareaid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shippingareacode)
            //        .IsRequired()
            //        .HasColumnName("shippingareacode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Shippingareaname)
            //        .IsRequired()
            //        .HasColumnName("shippingareaname")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmShippingcontainer>(entity =>
            //{
            //    entity.ToTable("escdb_tbm_shippingcontainer", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Containerno)
            //        .HasColumnName("containerno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Shippingdate)
            //        .HasColumnName("shippingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shippingno)
            //        .HasColumnName("shippingno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Shippingqty)
            //        .HasColumnName("shippingqty")
            //        .HasColumnType("numeric(18,2)");
            //});

            //modelBuilder.Entity<EscdbTbmShippingcustomer>(entity =>
            //{
            //    entity.HasKey(e => e.Shippingcustomerid)
            //        .HasName("escdb_tbm_shippingcustomer_pkey");

            //    entity.ToTable("escdb_tbm_shippingcustomer", "wh");

            //    entity.Property(e => e.Shippingcustomerid)
            //        .HasColumnName("shippingcustomerid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Address)
            //        .HasColumnName("address")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Businesstype)
            //        .HasColumnName("businesstype")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Emailaddress)
            //        .HasColumnName("emailaddress")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Shippingcustomercode)
            //        .IsRequired()
            //        .HasColumnName("shippingcustomercode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shippingcustomername)
            //        .IsRequired()
            //        .HasColumnName("shippingcustomername")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Stateorprovince)
            //        .HasColumnName("stateorprovince")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmSpcommandcountryzonemapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Specialcommandid, e.Countryzoneid })
            //        .HasName("escdb_tbm_spcommandcountryzonemapping_pkey");

            //    entity.ToTable("escdb_tbm_spcommandcountryzonemapping", "wh");

            //    entity.Property(e => e.Specialcommandid).HasColumnName("specialcommandid");

            //    entity.Property(e => e.Countryzoneid).HasColumnName("countryzoneid");
            //});

            //modelBuilder.Entity<EscdbTbmSpcommandmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Specialcommandid, e.Commandid })
            //        .HasName("escdb_tbm_spcommandmapping_pkey");

            //    entity.ToTable("escdb_tbm_spcommandmapping", "wh");

            //    entity.Property(e => e.Specialcommandid).HasColumnName("specialcommandid");

            //    entity.Property(e => e.Commandid).HasColumnName("commandid");
            //});

            //modelBuilder.Entity<EscdbTbmSpcommandmonthmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Specialcommandid, e.Monthid })
            //        .HasName("escdb_tbm_spcommandmonthmapping_pkey");

            //    entity.ToTable("escdb_tbm_spcommandmonthmapping", "wh");

            //    entity.Property(e => e.Specialcommandid).HasColumnName("specialcommandid");

            //    entity.Property(e => e.Monthid).HasColumnName("monthid");
            //});

            //modelBuilder.Entity<EscdbTbmSpecialcommand>(entity =>
            //{
            //    entity.HasKey(e => e.Specialcommandid)
            //        .HasName("escdb_tbm_specialcommand_pkey");

            //    entity.ToTable("escdb_tbm_specialcommand", "wh");

            //    entity.Property(e => e.Specialcommandid)
            //        .HasColumnName("specialcommandid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Active).HasColumnName("active");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Othercommand).HasColumnName("othercommand");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Ricetype).HasColumnName("ricetype");

            //    entity.Property(e => e.Specialcommandcode)
            //        .IsRequired()
            //        .HasColumnName("specialcommandcode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Startyear).HasColumnName("startyear");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmSubtypeofgoods>(entity =>
            //{
            //    entity.HasKey(e => e.Subtypeofgoodsid)
            //        .HasName("escdb_tbm_subtypeofgoods_pkey");

            //    entity.ToTable("escdb_tbm_subtypeofgoods", "wh");

            //    entity.Property(e => e.Subtypeofgoodsid)
            //        .HasColumnName("subtypeofgoodsid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Subtypeofgoodscode)
            //        .IsRequired()
            //        .HasColumnName("subtypeofgoodscode")
            //        .HasMaxLength(25);

            //    entity.Property(e => e.Subtypeofgoodsname)
            //        .IsRequired()
            //        .HasColumnName("subtypeofgoodsname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Typeofgoodsid).HasColumnName("typeofgoodsid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmSupplier>(entity =>
            //{
            //    entity.HasKey(e => e.Supplierid)
            //        .HasName("escdb_tbm_supplier_pkey");

            //    entity.ToTable("escdb_tbm_supplier", "wh");

            //    entity.Property(e => e.Supplierid)
            //        .HasColumnName("supplierid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Emailaddress)
            //        .HasColumnName("emailaddress")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Km).HasColumnName("km");

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Recordid)
            //        .HasColumnName("recordid")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Stateorprovince)
            //        .HasColumnName("stateorprovince")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Supplieraddress1)
            //        .HasColumnName("supplieraddress1")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Supplieraddress2)
            //        .HasColumnName("supplieraddress2")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Suppliercode)
            //        .IsRequired()
            //        .HasColumnName("suppliercode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Supplierlongname)
            //        .HasColumnName("supplierlongname")
            //        .HasMaxLength(60);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmTransporttype>(entity =>
            //{
            //    entity.HasKey(e => e.Transporttypeid)
            //        .HasName("escdb_tbm_transporttype_pkey");

            //    entity.ToTable("escdb_tbm_transporttype", "wh");

            //    entity.Property(e => e.Transporttypeid)
            //        .HasColumnName("transporttypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Containerweight)
            //        .HasColumnName("containerweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Height)
            //        .HasColumnName("height")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Length)
            //        .HasColumnName("length")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Maxm3)
            //        .HasColumnName("maxm3")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Transporttypecode)
            //        .IsRequired()
            //        .HasColumnName("transporttypecode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Transporttypename)
            //        .IsRequired()
            //        .HasColumnName("transporttypename")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Width)
            //        .HasColumnName("width")
            //        .HasColumnType("numeric(18,2)");
            //});

            //modelBuilder.Entity<EscdbTbmTransportunstaffingcharge>(entity =>
            //{
            //    entity.HasKey(e => e.Transportunstaffingid)
            //        .HasName("escdb_tbm_transportunstaffingcharge_pkey");

            //    entity.ToTable("escdb_tbm_transportunstaffingcharge", "wh");

            //    entity.Property(e => e.Transportunstaffingid)
            //        .HasColumnName("transportunstaffingid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Charge)
            //        .HasColumnName("charge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Effectivedate).HasColumnName("effectivedate");

            //    entity.Property(e => e.Finaldestinationid).HasColumnName("finaldestinationid");

            //    entity.Property(e => e.Fuelprice)
            //        .HasColumnName("fuelprice")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");

            //    entity.Property(e => e.Transporttypeid).HasColumnName("transporttypeid");

            //    entity.Property(e => e.Truckcompanyid).HasColumnName("truckcompanyid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmTruckcompany>(entity =>
            //{
            //    entity.HasKey(e => e.Truckcompanyid)
            //        .HasName("escdb_tbm_truckcompany_pkey");

            //    entity.ToTable("escdb_tbm_truckcompany", "wh");

            //    entity.Property(e => e.Truckcompanyid)
            //        .HasColumnName("truckcompanyid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Truckcompanyaddress)
            //        .HasColumnName("truckcompanyaddress")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Truckcompanycode)
            //        .IsRequired()
            //        .HasColumnName("truckcompanycode")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Truckcompanylongname)
            //        .HasColumnName("truckcompanylongname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmTrucktransporttypemapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Truckcompanyid, e.Transporttypeid })
            //        .HasName("escdb_tbm_trucktransporttypemapping_pkey");

            //    entity.ToTable("escdb_tbm_trucktransporttypemapping", "wh");

            //    entity.Property(e => e.Truckcompanyid).HasColumnName("truckcompanyid");

            //    entity.Property(e => e.Transporttypeid).HasColumnName("transporttypeid");
            //});

            //modelBuilder.Entity<EscdbTbmTypeofgoods>(entity =>
            //{
            //    entity.HasKey(e => e.Typeofgoodsid)
            //        .HasName("escdb_tbm_typeofgoods_pkey");

            //    entity.ToTable("escdb_tbm_typeofgoods", "wh");

            //    entity.Property(e => e.Typeofgoodsid)
            //        .HasColumnName("typeofgoodsid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Typeofgoodscode)
            //        .IsRequired()
            //        .HasColumnName("typeofgoodscode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Typeofgoodsname)
            //        .IsRequired()
            //        .HasColumnName("typeofgoodsname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmTypeofunit>(entity =>
            //{
            //    entity.HasKey(e => e.Unitid)
            //        .HasName("escdb_tbm_typeofunit_pkey");

            //    entity.ToTable("escdb_tbm_typeofunit", "wh");

            //    entity.Property(e => e.Unitid)
            //        .HasColumnName("unitid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(2550);

            //    entity.Property(e => e.Unitcode)
            //        .IsRequired()
            //        .HasColumnName("unitcode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Unitname)
            //        .IsRequired()
            //        .HasColumnName("unitname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmVessel>(entity =>
            //{
            //    entity.HasKey(e => e.Vesselid)
            //        .HasName("escdb_tbm_vessel_pkey");

            //    entity.ToTable("escdb_tbm_vessel", "wh");

            //    entity.Property(e => e.Vesselid)
            //        .HasColumnName("vesselid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Vesselname)
            //        .IsRequired()
            //        .HasColumnName("vesselname")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbmWorkmethod>(entity =>
            //{
            //    entity.HasKey(e => e.Workmethodid)
            //        .HasName("escdb_tbm_workmethod_pkey");

            //    entity.ToTable("escdb_tbm_workmethod", "wh");

            //    entity.Property(e => e.Workmethodid)
            //        .HasColumnName("workmethodid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Workmethodcode)
            //        .IsRequired()
            //        .HasColumnName("workmethodcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Workmethodname)
            //        .HasColumnName("workmethodname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmWorkmethodsetting>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Dcid, e.Workmethodid, e.Moduleid })
            //        .HasName("escdb_tbm_workmethodsetting_pkey");

            //    entity.ToTable("escdb_tbm_workmethodsetting", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Workmethodid).HasColumnName("workmethodid");

            //    entity.Property(e => e.Moduleid).HasColumnName("moduleid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmZone>(entity =>
            //{
            //    entity.HasKey(e => e.Zoneid)
            //        .HasName("escdb_tbm_zone_pkey");

            //    entity.ToTable("escdb_tbm_zone", "wh");

            //    entity.Property(e => e.Zoneid)
            //        .HasColumnName("zoneid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Floor).HasColumnName("floor");

            //    entity.Property(e => e.Locationmoreonepalletflag).HasColumnName("locationmoreonepalletflag");

            //    entity.Property(e => e.Maxcapacityperpallet)
            //        .HasColumnName("maxcapacityperpallet")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stack).HasColumnName("stack");

            //    entity.Property(e => e.Storagelocation)
            //        .HasColumnName("storagelocation")
            //        .HasMaxLength(4);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Zonecategoryid).HasColumnName("zonecategoryid");

            //    entity.Property(e => e.Zonecode)
            //        .IsRequired()
            //        .HasColumnName("zonecode")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Zonecolor)
            //        .HasColumnName("zonecolor")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.Zonename)
            //        .HasColumnName("zonename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbmZonecustomermapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Zoneid, e.Customerid })
            //        .HasName("escdb_tbm_zonecustomermapping_pkey");

            //    entity.ToTable("escdb_tbm_zonecustomermapping", "wh");

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsAcJobnoRunning>(entity =>
            //{
            //    entity.HasKey(e => e.Seq)
            //        .HasName("escdb_tbs_ac_jobno_running_pkey");

            //    entity.ToTable("escdb_tbs_ac_jobno_running", "wh");

            //    entity.Property(e => e.Seq)
            //        .HasColumnName("seq")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Date).HasColumnName("date");

            //    entity.Property(e => e.InvoiceNo)
            //        .HasColumnName("invoice_no")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.RunningNo).HasColumnName("running_no");
            //});

            //modelBuilder.Entity<EscdbTbsAmphur>(entity =>
            //{
            //    entity.HasKey(e => e.Amphurid)
            //        .HasName("escdb_tbs_amphur_pkey");

            //    entity.ToTable("escdb_tbs_amphur", "wh");

            //    entity.Property(e => e.Amphurid)
            //        .HasColumnName("amphurid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Amphurname)
            //        .HasColumnName("amphurname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Provinceid).HasColumnName("provinceid");
            //});

            //modelBuilder.Entity<EscdbTbsControlbag>(entity =>
            //{
            //    entity.HasKey(e => e.Controlbagid)
            //        .HasName("escdb_tbs_controlbag_pkey");

            //    entity.ToTable("escdb_tbs_controlbag", "wh");

            //    entity.Property(e => e.Controlbagid)
            //        .HasColumnName("controlbagid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlbagname)
            //        .IsRequired()
            //        .HasColumnName("controlbagname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlbatchno>(entity =>
            //{
            //    entity.HasKey(e => e.Controlbatchnoid)
            //        .HasName("escdb_tbs_controlbatchno_pkey");

            //    entity.ToTable("escdb_tbs_controlbatchno", "wh");

            //    entity.Property(e => e.Controlbatchnoid)
            //        .HasColumnName("controlbatchnoid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlbatchnoname)
            //        .IsRequired()
            //        .HasColumnName("controlbatchnoname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControllot>(entity =>
            //{
            //    entity.HasKey(e => e.Controllotid)
            //        .HasName("escdb_tbs_controllot_pkey");

            //    entity.ToTable("escdb_tbs_controllot", "wh");

            //    entity.Property(e => e.Controllotid)
            //        .HasColumnName("controllotid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controllotname)
            //        .IsRequired()
            //        .HasColumnName("controllotname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlmixlot>(entity =>
            //{
            //    entity.HasKey(e => e.Controlmixlotid)
            //        .HasName("escdb_tbs_controlmixlot_pkey");

            //    entity.ToTable("escdb_tbs_controlmixlot", "wh");

            //    entity.Property(e => e.Controlmixlotid)
            //        .HasColumnName("controlmixlotid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlmixlotname)
            //        .IsRequired()
            //        .HasColumnName("controlmixlotname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlpack>(entity =>
            //{
            //    entity.HasKey(e => e.Controlpackid)
            //        .HasName("escdb_tbs_controlpack_pkey");

            //    entity.ToTable("escdb_tbs_controlpack", "wh");

            //    entity.Property(e => e.Controlpackid)
            //        .HasColumnName("controlpackid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlpackname)
            //        .IsRequired()
            //        .HasColumnName("controlpackname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlpallet>(entity =>
            //{
            //    entity.HasKey(e => e.Controlpalletid)
            //        .HasName("escdb_tbs_controlpallet_pkey");

            //    entity.ToTable("escdb_tbs_controlpallet", "wh");

            //    entity.Property(e => e.Controlpalletid)
            //        .HasColumnName("controlpalletid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlpalletname)
            //        .IsRequired()
            //        .HasColumnName("controlpalletname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlpicking>(entity =>
            //{
            //    entity.HasKey(e => e.Controlpickingid)
            //        .HasName("escdb_tbs_controlpicking_pkey");

            //    entity.ToTable("escdb_tbs_controlpicking", "wh");

            //    entity.Property(e => e.Controlpickingid)
            //        .HasColumnName("controlpickingid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlpickingname)
            //        .IsRequired()
            //        .HasColumnName("controlpickingname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlserial>(entity =>
            //{
            //    entity.HasKey(e => e.Controlserialid)
            //        .HasName("escdb_tbs_controlserial_pkey");

            //    entity.ToTable("escdb_tbs_controlserial", "wh");

            //    entity.Property(e => e.Controlserialid)
            //        .HasColumnName("controlserialid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlserialname)
            //        .IsRequired()
            //        .HasColumnName("controlserialname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlshelflife>(entity =>
            //{
            //    entity.HasKey(e => e.Controlshelflifeid)
            //        .HasName("escdb_tbs_controlshelflife_pkey");

            //    entity.ToTable("escdb_tbs_controlshelflife", "wh");

            //    entity.Property(e => e.Controlshelflifeid)
            //        .HasColumnName("controlshelflifeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlshelflifename)
            //        .IsRequired()
            //        .HasColumnName("controlshelflifename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlspecialcommand>(entity =>
            //{
            //    entity.HasKey(e => e.Controlspecialcommandid)
            //        .HasName("escdb_tbs_controlspecialcommand_pkey");

            //    entity.ToTable("escdb_tbs_controlspecialcommand", "wh");

            //    entity.Property(e => e.Controlspecialcommandid)
            //        .HasColumnName("controlspecialcommandid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlspecialcommandname)
            //        .HasColumnName("controlspecialcommandname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlvoid>(entity =>
            //{
            //    entity.HasKey(e => e.Controlvoidid)
            //        .HasName("escdb_tbs_controlvoid_pkey");

            //    entity.ToTable("escdb_tbs_controlvoid", "wh");

            //    entity.Property(e => e.Controlvoidid)
            //        .HasColumnName("controlvoidid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlvoidname)
            //        .IsRequired()
            //        .HasColumnName("controlvoidname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsControlweight>(entity =>
            //{
            //    entity.HasKey(e => e.Controlweightid)
            //        .HasName("escdb_tbs_controlweight_pkey");

            //    entity.ToTable("escdb_tbs_controlweight", "wh");

            //    entity.Property(e => e.Controlweightid)
            //        .HasColumnName("controlweightid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlweightname)
            //        .HasColumnName("controlweightname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsDistrictOld>(entity =>
            //{
            //    entity.HasKey(e => new { e.Provinceid, e.Districtid })
            //        .HasName("escdb_tbs_district_old_pkey");

            //    entity.ToTable("escdb_tbs_district_old", "wh");

            //    entity.Property(e => e.Provinceid).HasColumnName("provinceid");

            //    entity.Property(e => e.Districtid).HasColumnName("districtid");

            //    entity.Property(e => e.Districtnameen)
            //        .HasColumnName("districtnameen")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Districtnameth)
            //        .HasColumnName("districtnameth")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbsDoctype>(entity =>
            //{
            //    entity.HasKey(e => e.Doctypeid)
            //        .HasName("escdb_tbs_doctype_pkey");

            //    entity.ToTable("escdb_tbs_doctype", "wh");

            //    entity.Property(e => e.Doctypeid)
            //        .HasColumnName("doctypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createdby)
            //        .HasColumnName("createdby")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Doctypecode)
            //        .HasColumnName("doctypecode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Doctypedesc)
            //        .HasColumnName("doctypedesc")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsFiletype>(entity =>
            //{
            //    entity.HasKey(e => e.Filetypeid)
            //        .HasName("escdb_tbs_filetype_pkey");

            //    entity.ToTable("escdb_tbs_filetype", "wh");

            //    entity.Property(e => e.Filetypeid)
            //        .HasColumnName("filetypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Filetypename)
            //        .IsRequired()
            //        .HasColumnName("filetypename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsGeneratedocumentno>(entity =>
            //{
            //    entity.HasKey(e => e.Docnocode)
            //        .HasName("escdb_tbs_generatedocumentno_pkey");

            //    entity.ToTable("escdb_tbs_generatedocumentno", "wh");

            //    entity.Property(e => e.Docnocode)
            //        .HasColumnName("docnocode")
            //        .HasMaxLength(50)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Docnodescription)
            //        .HasColumnName("docnodescription")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Incrementstep).HasColumnName("incrementstep");

            //    entity.Property(e => e.Lastupdate)
            //        .HasColumnName("lastupdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Leadingtext)
            //        .HasColumnName("leadingtext")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Presentno).HasColumnName("presentno");

            //    entity.Property(e => e.Runningdigit)
            //        .HasColumnName("runningdigit")
            //        .HasMaxLength(10);
            //});

            //modelBuilder.Entity<EscdbTbsItemexpiredtype>(entity =>
            //{
            //    entity.HasKey(e => e.Itemexpiredtypeid)
            //        .HasName("escdb_tbs_itemexpiredtype_pkey");

            //    entity.ToTable("escdb_tbs_itemexpiredtype", "wh");

            //    entity.Property(e => e.Itemexpiredtypeid)
            //        .HasColumnName("itemexpiredtypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Itemexpiredtypename)
            //        .HasColumnName("itemexpiredtypename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsModule>(entity =>
            //{
            //    entity.HasKey(e => e.Moduleid)
            //        .HasName("escdb_tbs_module_pkey");

            //    entity.ToTable("escdb_tbs_module", "wh");

            //    entity.Property(e => e.Moduleid)
            //        .HasColumnName("moduleid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Modulename)
            //        .HasColumnName("modulename")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbsMonth>(entity =>
            //{
            //    entity.HasKey(e => e.Monthid)
            //        .HasName("escdb_tbs_month_pkey");

            //    entity.ToTable("escdb_tbs_month", "wh");

            //    entity.Property(e => e.Monthid)
            //        .HasColumnName("monthid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Monthname)
            //        .IsRequired()
            //        .HasColumnName("monthname")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Monthshortname)
            //        .IsRequired()
            //        .HasColumnName("monthshortname")
            //        .HasMaxLength(5);
            //});

            //modelBuilder.Entity<EscdbTbsNotificationitem>(entity =>
            //{
            //    entity.HasKey(e => e.Notificationitemid)
            //        .HasName("escdb_tbs_notificationitem_pkey");

            //    entity.ToTable("escdb_tbs_notificationitem", "wh");

            //    entity.Property(e => e.Notificationitemid)
            //        .HasColumnName("notificationitemid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Notificationicon)
            //        .HasColumnName("notificationicon")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Notificationitemename)
            //        .IsRequired()
            //        .HasColumnName("notificationitemename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsOrderpattern>(entity =>
            //{
            //    entity.HasKey(e => e.Orderpatternid)
            //        .HasName("escdb_tbs_orderpattern_pkey");

            //    entity.ToTable("escdb_tbs_orderpattern", "wh");

            //    entity.Property(e => e.Orderpatternid)
            //        .HasColumnName("orderpatternid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Orderpatternname)
            //        .HasColumnName("orderpatternname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsOtpmaster>(entity =>
            //{
            //    entity.HasKey(e => e.Otpid)
            //        .HasName("escdb_tbs_otpmaster_pkey");

            //    entity.ToTable("escdb_tbs_otpmaster", "wh");

            //    entity.Property(e => e.Otpid)
            //        .HasColumnName("otpid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Otpname)
            //        .HasColumnName("otpname")
            //        .HasMaxLength(20);
            //});

            //modelBuilder.Entity<EscdbTbsPallettype>(entity =>
            //{
            //    entity.HasKey(e => e.Pallettypeid)
            //        .HasName("escdb_tbs_pallettype_pkey");

            //    entity.ToTable("escdb_tbs_pallettype", "wh");

            //    entity.Property(e => e.Pallettypeid)
            //        .HasColumnName("pallettypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Pallettypename)
            //        .IsRequired()
            //        .HasColumnName("pallettypename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsPortclassification>(entity =>
            //{
            //    entity.HasKey(e => e.Portclassificationid)
            //        .HasName("escdb_tbs_portclassification_pkey");

            //    entity.ToTable("escdb_tbs_portclassification", "wh");

            //    entity.Property(e => e.Portclassificationid)
            //        .HasColumnName("portclassificationid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Portclassificationname)
            //        .HasColumnName("portclassificationname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbsProvince>(entity =>
            //{
            //    entity.HasKey(e => e.Provinceid)
            //        .HasName("escdb_tbs_province_pkey");

            //    entity.ToTable("escdb_tbs_province", "wh");

            //    entity.Property(e => e.Provinceid)
            //        .HasColumnName("provinceid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Provincename)
            //        .IsRequired()
            //        .HasColumnName("provincename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Regioncode)
            //        .HasColumnName("regioncode")
            //        .HasMaxLength(30);
            //});

            //modelBuilder.Entity<EscdbTbsRankaging>(entity =>
            //{
            //    entity.HasKey(e => e.Rankagingid)
            //        .HasName("escdb_tbs_rankaging_pkey");

            //    entity.ToTable("escdb_tbs_rankaging", "wh");

            //    entity.Property(e => e.Rankagingid)
            //        .HasColumnName("rankagingid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Rankagingfrom).HasColumnName("rankagingfrom");

            //    entity.Property(e => e.Rankagingname)
            //        .HasColumnName("rankagingname")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Rankagingto).HasColumnName("rankagingto");
            //});

            //modelBuilder.Entity<EscdbTbsRegion>(entity =>
            //{
            //    entity.HasKey(e => e.Regioncode)
            //        .HasName("escdb_tbs_region_pkey");

            //    entity.ToTable("escdb_tbs_region", "wh");

            //    entity.Property(e => e.Regioncode)
            //        .HasColumnName("regioncode")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Countrycode)
            //        .HasColumnName("countrycode")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Regionname)
            //        .HasColumnName("regionname")
            //        .HasMaxLength(30);
            //});

            //modelBuilder.Entity<EscdbTbsReportconfig>(entity =>
            //{
            //    entity.HasKey(e => e.Configid)
            //        .HasName("escdb_tbs_reportconfig_pkey");

            //    entity.ToTable("escdb_tbs_reportconfig", "wh");

            //    entity.Property(e => e.Configid)
            //        .HasColumnName("configid")
            //        .HasMaxLength(10)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Configvalue)
            //        .HasColumnName("configvalue")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbsScantype>(entity =>
            //{
            //    entity.HasKey(e => e.Scantypeid)
            //        .HasName("escdb_tbs_scantype_pkey");

            //    entity.ToTable("escdb_tbs_scantype", "wh");

            //    entity.Property(e => e.Scantypeid)
            //        .HasColumnName("scantypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Scantypename)
            //        .HasColumnName("scantypename")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbsStatus>(entity =>
            //{
            //    entity.HasKey(e => e.Statusid)
            //        .HasName("escdb_tbs_status_pkey");

            //    entity.ToTable("escdb_tbs_status", "wh");

            //    entity.Property(e => e.Statusid)
            //        .HasColumnName("statusid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Statusname)
            //        .IsRequired()
            //        .HasColumnName("statusname")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbsSystemconfig>(entity =>
            //{
            //    entity.HasKey(e => e.Configid)
            //        .HasName("escdb_tbs_systemconfig_pkey");

            //    entity.ToTable("escdb_tbs_systemconfig", "wh");

            //    entity.Property(e => e.Configid)
            //        .HasColumnName("configid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Configitem)
            //        .IsRequired()
            //        .HasColumnName("configitem")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Configvalue)
            //        .IsRequired()
            //        .HasColumnName("configvalue")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Description).HasColumnName("description");

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Orderrow).HasColumnName("orderrow");
            //});

            //modelBuilder.Entity<EscdbTbsUnitconverttable>(entity =>
            //{
            //    entity.HasKey(e => new { e.Fromunitid, e.Tounitid })
            //        .HasName("escdb_tbs_unitconverttable_pkey");

            //    entity.ToTable("escdb_tbs_unitconverttable", "wh");

            //    entity.Property(e => e.Fromunitid).HasColumnName("fromunitid");

            //    entity.Property(e => e.Tounitid).HasColumnName("tounitid");

            //    entity.Property(e => e.Ratio)
            //        .HasColumnName("ratio")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<EscdbTbtPacking>(entity =>
            //{
            //    entity.HasKey(e => new { e.Packingno, e.Shipmentnogroup, e.Shipmentno, e.Installment, e.Pickingno })
            //        .HasName("escdb_tbt_packing_pkey");

            //    entity.ToTable("escdb_tbt_packing", "wh");

            //    entity.Property(e => e.Packingno)
            //        .HasColumnName("packingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Shipmentnogroup)
            //        .HasColumnName("shipmentnogroup")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Boxno).HasColumnName("boxno");

            //    entity.Property(e => e.Confirmgiflag).HasColumnName("confirmgiflag");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Grossweight)
            //        .HasColumnName("grossweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.M3)
            //        .HasColumnName("m3")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Packagecloseflag).HasColumnName("packagecloseflag");

            //    entity.Property(e => e.Packageid).HasColumnName("packageid");

            //    entity.Property(e => e.Packdate).HasColumnName("packdate");

            //    entity.Property(e => e.Packshippingmark)
            //        .HasColumnName("packshippingmark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Palletid)
            //        .HasColumnName("palletid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Shipqty).HasColumnName("shipqty");

            //    entity.Property(e => e.Sono)
            //        .HasColumnName("sono")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbtPackingd>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Packingno, e.Skubarcode, e.Lotno })
            //        .HasName("escdb_tbt_packingd_pkey");

            //    entity.ToTable("escdb_tbt_packingd", "wh");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Packingno)
            //        .HasColumnName("packingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Skubarcode)
            //        .HasColumnName("skubarcode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Controlvoidid).HasColumnName("controlvoidid");

            //    entity.Property(e => e.Notification)
            //        .HasColumnName("notification")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Packqty)
            //        .HasColumnName("packqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Qtyofinventoryunit).HasColumnName("qtyofinventoryunit");

            //    entity.Property(e => e.Qtyofsku)
            //        .HasColumnName("qtyofsku")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Unitofsku).HasColumnName("unitofsku");
            //});

            //modelBuilder.Entity<EscdbTbtPackingvoid>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Packingno, e.Skubarcode, e.Lotno, e.Voidno })
            //        .HasName("escdb_tbt_packingvoid_pkey");

            //    entity.ToTable("escdb_tbt_packingvoid", "wh");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Packingno)
            //        .HasColumnName("packingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Skubarcode)
            //        .HasColumnName("skubarcode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Voidno)
            //        .HasColumnName("voidno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Controlvoidid).HasColumnName("controlvoidid");
            //});

            //modelBuilder.Entity<EscdbTbtPalletmapping>(entity =>
            //{
            //    entity.HasKey(e => e.Stickeruid)
            //        .HasName("escdb_tbt_palletmapping_pkey");

            //    entity.ToTable("escdb_tbt_palletmapping", "wh");

            //    entity.HasIndex(e => e.Palletid)
            //        .HasName("wh_escdb_tbt_palletmapping_9");

            //    entity.Property(e => e.Stickeruid)
            //        .HasColumnName("stickeruid")
            //        .HasMaxLength(100)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Palletid)
            //        .IsRequired()
            //        .HasColumnName("palletid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Routeid).HasColumnName("routeid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbtPickingdetail>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno })
            //        .HasName("escdb_tbt_pickingdetail_pkey");

            //    entity.ToTable("escdb_tbt_pickingdetail", "wh");

            //    entity.HasIndex(e => e.Lotno)
            //        .HasName("wh_escdb_tbt_pickingdetail_3");

            //    entity.HasIndex(e => e.Receivingno)
            //        .HasName("wh_escdb_tbt_pickingdetail_4");

            //    entity.HasIndex(e => new { e.Productid, e.Assignqty, e.Serial })
            //        .HasName("wh_escdb_tbt_pickingdetail_2");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.AcctCd)
            //        .HasColumnName("acct_cd")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Assignqty)
            //        .HasColumnName("assignqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Batchno)
            //        .HasColumnName("batchno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.CostDept)
            //        .HasColumnName("cost_dept")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerorder)
            //        .HasColumnName("customerorder")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Damageqty)
            //        .HasColumnName("damageqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Datasourceflag).HasColumnName("datasourceflag");

            //    entity.Property(e => e.Detailremark)
            //        .HasColumnName("detailremark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Dnlineno)
            //        .HasColumnName("dnlineno")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.Dnno)
            //        .HasColumnName("dnno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Flgtoas400).HasColumnName("flgtoas400");

            //    entity.Property(e => e.Goodqty)
            //        .HasColumnName("goodqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Inpackage)
            //        .HasColumnName("inpackage")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Kanbanqty).HasColumnName("kanbanqty");

            //    entity.Property(e => e.Keyimportref)
            //        .HasColumnName("keyimportref")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Lostqty)
            //        .HasColumnName("lostqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.M3)
            //        .HasColumnName("m3")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Materialcode)
            //        .HasColumnName("materialcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Materialfreightgroup)
            //        .HasColumnName("materialfreightgroup")
            //        .HasMaxLength(8);

            //    entity.Property(e => e.Materialgrossweight)
            //        .HasColumnName("materialgrossweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Materialvolume)
            //        .HasColumnName("materialvolume")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Materialvolumeunit)
            //        .HasColumnName("materialvolumeunit")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Materialweightunit)
            //        .HasColumnName("materialweightunit")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Orderqty)
            //        .HasColumnName("orderqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Plannername)
            //        .HasColumnName("plannername")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Plant)
            //        .HasColumnName("plant")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Pono)
            //        .HasColumnName("pono")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Recinstallment).HasColumnName("recinstallment");

            //    entity.Property(e => e.Reclineno).HasColumnName("reclineno");

            //    entity.Property(e => e.Referenceno)
            //        .HasColumnName("referenceno")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Requirepalletflag).HasColumnName("requirepalletflag");

            //    entity.Property(e => e.Serial)
            //        .HasColumnName("serial")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shippingmark)
            //        .HasColumnName("shippingmark")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Shipqty)
            //        .HasColumnName("shipqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Soitem).HasColumnName("soitem");

            //    entity.Property(e => e.Sonumber)
            //        .HasColumnName("sonumber")
            //        .HasMaxLength(24);

            //    entity.Property(e => e.Tolerancegireason)
            //        .HasColumnName("tolerancegireason")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Totalgrossweight)
            //        .HasColumnName("totalgrossweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Totalnetweight)
            //        .HasColumnName("totalnetweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Totalvolume)
            //        .HasColumnName("totalvolume")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Typeofpackageid).HasColumnName("typeofpackageid");

            //    entity.Property(e => e.Unitofinpackage).HasColumnName("unitofinpackage");

            //    entity.Property(e => e.Unitoforderqty).HasColumnName("unitoforderqty");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Weight)
            //        .HasColumnName("weight")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<EscdbTbtPickingdetailconfirmed>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Pickinglineseq, e.Locationid })
            //        .HasName("escdb_tbt_pickingdetailconfirmed_pkey");

            //    entity.ToTable("escdb_tbt_pickingdetailconfirmed", "wh");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Pickinglineseq).HasColumnName("pickinglineseq");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Confirmflag).HasColumnName("confirmflag");

            //    entity.Property(e => e.Lastupdateby)
            //        .HasColumnName("lastupdateby")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Lastupdatedate)
            //        .HasColumnName("lastupdatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Pickingqty)
            //        .HasColumnName("pickingqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Receiveseq).HasColumnName("receiveseq");

            //    entity.Property(e => e.Remainpack)
            //        .HasColumnName("remainpack")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Remainpackofinventoryunit)
            //        .HasColumnName("remainpackofinventoryunit")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Returnqty)
            //        .HasColumnName("returnqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Serial)
            //        .HasColumnName("serial")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shipqty)
            //        .HasColumnName("shipqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stickeruid)
            //        .HasColumnName("stickeruid")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Stockactualqty)
            //        .HasColumnName("stockactualqty")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<EscdbTbtPickingheader>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno })
            //        .HasName("escdb_tbt_pickingheader_pkey");

            //    entity.ToTable("escdb_tbt_pickingheader", "wh");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Agentseal)
            //        .HasColumnName("agentseal")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Cancelpickingflag).HasColumnName("cancelpickingflag");

            //    entity.Property(e => e.Completeinfoflag).HasColumnName("completeinfoflag");

            //    entity.Property(e => e.Controlpackid).HasColumnName("controlpackid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Doissueddate)
            //        .HasColumnName("doissueddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Generatediffdate)
            //        .HasColumnName("generatediffdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Inspectionseal)
            //        .HasColumnName("inspectionseal")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

            //    entity.Property(e => e.Numberofdetails).HasColumnName("numberofdetails");

            //    entity.Property(e => e.Palletqty).HasColumnName("palletqty");

            //    entity.Property(e => e.Pickingcompletedate)
            //        .HasColumnName("pickingcompletedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pickingdate)
            //        .HasColumnName("pickingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pickingissueddate)
            //        .HasColumnName("pickingissueddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shippingareaid).HasColumnName("shippingareaid");

            //    entity.Property(e => e.Shippingresultgenerated).HasColumnName("shippingresultgenerated");

            //    entity.Property(e => e.Sonumber)
            //        .HasColumnName("sonumber")
            //        .HasMaxLength(24);

            //    entity.Property(e => e.Sourcesystem)
            //        .HasColumnName("sourcesystem")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Stockoutcontrolflag).HasColumnName("stockoutcontrolflag");

            //    entity.Property(e => e.Transportationdate)
            //        .HasColumnName("transportationdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Vanningdate)
            //        .HasColumnName("vanningdate")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<EscdbTbtReceivingconfirmed>(entity =>
            //{
            //    entity.HasKey(e => new { e.Receivingno, e.Installment, e.Lineno, e.Receiveseq })
            //        .HasName("escdb_tbt_receivingconfirmed_pkey");

            //    entity.ToTable("escdb_tbt_receivingconfirmed", "wh");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Receiveseq).HasColumnName("receiveseq");

            //    entity.Property(e => e.ActuallyReceiveddate)
            //        .HasColumnName("actually_receiveddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Expireddate).HasColumnName("expireddate");

            //    entity.Property(e => e.Invoiceno)
            //        .HasColumnName("invoiceno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Receiveddate)
            //        .HasColumnName("receiveddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Receiveqty)
            //        .HasColumnName("receiveqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Transitcompleteflag).HasColumnName("transitcompleteflag");
            //});

            //modelBuilder.Entity<EscdbTbtReceivinginstructiondetail>(entity =>
            //{
            //    entity.HasKey(e => new { e.Receivingno, e.Installment, e.Lineno })
            //        .HasName("escdb_tbt_receivinginstructiondetail_pkey");

            //    entity.ToTable("escdb_tbt_receivinginstructiondetail", "wh");

            //    entity.HasIndex(e => new { e.Customerid, e.Invoiceno, e.Lotno })
            //        .HasName("wh_escdb_tbt_receivinginstructiondetail_2");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Actuallotno)
            //        .HasColumnName("actuallotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.ActuallyUpdatedate)
            //        .HasColumnName("actually_updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Actualproductconditionid).HasColumnName("actualproductconditionid");

            //    entity.Property(e => e.Batchno)
            //        .HasColumnName("batchno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Currencycode)
            //        .HasColumnName("currencycode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Datasourceflag).HasColumnName("datasourceflag");

            //    entity.Property(e => e.Detailremark)
            //        .HasColumnName("detailremark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Exchangerate)
            //        .HasColumnName("exchangerate")
            //        .HasColumnType("numeric(18,5)");

            //    entity.Property(e => e.Expireddate).HasColumnName("expireddate");

            //    entity.Property(e => e.Flgtoac)
            //        .HasColumnName("flgtoac")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Flgtoas400).HasColumnName("flgtoas400");

            //    entity.Property(e => e.Inpackage)
            //        .HasColumnName("inpackage")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Inpackageunitid).HasColumnName("inpackageunitid");

            //    entity.Property(e => e.Instructionqty)
            //        .HasColumnName("instructionqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Invoicedate)
            //        .HasColumnName("invoicedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Invoiceno)
            //        .HasColumnName("invoiceno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Keyimportref)
            //        .HasColumnName("keyimportref")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Netweight)
            //        .HasColumnName("netweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Palletnoref)
            //        .IsRequired()
            //        .HasColumnName("palletnoref")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Polineno)
            //        .HasColumnName("polineno")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Pono)
            //        .HasColumnName("pono")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Price)
            //        .HasColumnName("price")
            //        .HasColumnType("numeric(18,5)");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("qty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Qtyunitid).HasColumnName("qtyunitid");

            //    entity.Property(e => e.Receiveqty)
            //        .HasColumnName("receiveqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Referenceno)
            //        .HasColumnName("referenceno")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Shippingnotificationno)
            //        .HasColumnName("shippingnotificationno")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Shippingnotificationnoline)
            //        .HasColumnName("shippingnotificationnoline")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.Tolerancegrreason)
            //        .HasColumnName("tolerancegrreason")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Typeofpackageid).HasColumnName("typeofpackageid");

            //    entity.Property(e => e.Unitvolume)
            //        .HasColumnName("unitvolume")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbtReceivinginstructionheader>(entity =>
            //{
            //    entity.HasKey(e => new { e.Receivingno, e.Installment })
            //        .HasName("escdb_tbt_receivinginstructionheader_pkey");

            //    entity.ToTable("escdb_tbt_receivinginstructionheader", "wh");

            //    entity.HasIndex(e => new { e.Dcid, e.Arrivaldate, e.PoNo })
            //        .HasName("wh_escdb_tbt_receivinginstructionheader_2");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.ActuallyUpdatedate)
            //        .HasColumnName("actually_updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Arrivaldate)
            //        .HasColumnName("arrivaldate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Cancelslipflag).HasColumnName("cancelslipflag");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Datasource).HasColumnName("datasource");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Districtid).HasColumnName("districtid");

            //    entity.Property(e => e.Docrefcreatedate)
            //        .HasColumnName("docrefcreatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Docrefexpiredate)
            //        .HasColumnName("docrefexpiredate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Docrefno)
            //        .HasColumnName("docrefno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Doctypecode)
            //        .HasColumnName("doctypecode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Doctypeid).HasColumnName("doctypeid");

            //    entity.Property(e => e.Finaldestinationid).HasColumnName("finaldestinationid");

            //    entity.Property(e => e.Generatediffdate)
            //        .HasColumnName("generatediffdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Genxpgenerated).HasColumnName("genxpgenerated");

            //    entity.Property(e => e.Importgroupno)
            //        .HasColumnName("importgroupno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Invoiceno)
            //        .HasColumnName("invoiceno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Licenseplate)
            //        .HasColumnName("licenseplate")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Palletqty).HasColumnName("palletqty");

            //    entity.Property(e => e.PoNo)
            //        .HasColumnName("po_no")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Provinceid).HasColumnName("provinceid");

            //    entity.Property(e => e.Receivingresultgenerated).HasColumnName("receivingresultgenerated");

            //    entity.Property(e => e.Refserviceid).HasColumnName("refserviceid");

            //    entity.Property(e => e.Refshiptoid).HasColumnName("refshiptoid");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Routeid).HasColumnName("routeid");

            //    entity.Property(e => e.ShipmentnogroupRev)
            //        .HasColumnName("shipmentnogroup_rev")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Slipcompletedate)
            //        .HasColumnName("slipcompletedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Slipno)
            //        .HasColumnName("slipno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Supplierid).HasColumnName("supplierid");

            //    entity.Property(e => e.Transferdate).HasColumnName("transferdate");

            //    entity.Property(e => e.Transfertype).HasColumnName("transfertype");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbtReceivingstatus>(entity =>
            //{
            //    entity.HasKey(e => new { e.Receivingno, e.Installment, e.Lineno })
            //        .HasName("escdb_tbt_receivingstatus_pkey");

            //    entity.ToTable("escdb_tbt_receivingstatus", "wh");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.ActuallyReceivingdate)
            //        .HasColumnName("actually_receivingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ActuallyTransitdate)
            //        .HasColumnName("actually_transitdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Canceldate)
            //        .HasColumnName("canceldate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Interfacereceiveddate)
            //        .HasColumnName("interfacereceiveddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Receivingdate)
            //        .HasColumnName("receivingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Receivingentrydate)
            //        .HasColumnName("receivingentrydate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Statusid).HasColumnName("statusid");

            //    entity.Property(e => e.Transitdate)
            //        .HasColumnName("transitdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Transitinstructionissueddate)
            //        .HasColumnName("transitinstructionissueddate")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<EscdbTbtShippinginstruction>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment })
            //        .HasName("escdb_tbt_shippinginstruction_pkey");

            //    entity.ToTable("escdb_tbt_shippinginstruction", "wh");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Customerid, e.Shipmentnogroup, e.Doctypeid })
            //        .HasName("wh_escdb_tbt_shippinginstruction_2");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Agent)
            //        .HasColumnName("agent")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Agentowner)
            //        .HasColumnName("agentowner")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Bookingno)
            //        .HasColumnName("bookingno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Containnerno)
            //        .HasColumnName("containnerno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Containnertype).HasColumnName("containnertype");

            //    entity.Property(e => e.Contractor)
            //        .HasColumnName("contractor")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Cutdate)
            //        .HasColumnName("cutdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Cydate)
            //        .HasColumnName("cydate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Cyplace)
            //        .HasColumnName("cyplace")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Deliverytype)
            //        .HasColumnName("deliverytype")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Destinationlocationtypeid).HasColumnName("destinationlocationtypeid");

            //    entity.Property(e => e.Doctypeid).HasColumnName("doctypeid");

            //    entity.Property(e => e.Eta)
            //        .HasColumnName("eta")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Etd)
            //        .HasColumnName("etd")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Finaldestinationid).HasColumnName("finaldestinationid");

            //    entity.Property(e => e.Finalno)
            //        .HasColumnName("finalno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Fumigate).HasColumnName("fumigate");

            //    entity.Property(e => e.Giconfirmdate)
            //        .HasColumnName("giconfirmdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Giconfirmuser)
            //        .HasColumnName("giconfirmuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Haulage).HasColumnName("haulage");

            //    entity.Property(e => e.Importgroupno)
            //        .HasColumnName("importgroupno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Invoiceno)
            //        .HasColumnName("invoiceno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Isaccepttendered).HasColumnName("isaccepttendered");

            //    entity.Property(e => e.Islastmile).HasColumnName("islastmile");

            //    entity.Property(e => e.Legid).HasColumnName("legid");

            //    entity.Property(e => e.Package)
            //        .HasColumnName("package")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Plannername)
            //        .HasColumnName("plannername")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Port)
            //        .HasColumnName("port")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Portofdischargeid).HasColumnName("portofdischargeid");

            //    entity.Property(e => e.Portofloadingid).HasColumnName("portofloadingid");

            //    entity.Property(e => e.Refdnnumber)
            //        .HasColumnName("refdnnumber")
            //        .HasMaxLength(26);

            //    entity.Property(e => e.Refinstallmentversion).HasColumnName("refinstallmentversion");

            //    entity.Property(e => e.Refshipmentversion)
            //        .HasColumnName("refshipmentversion")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Ricetypeid).HasColumnName("ricetypeid");

            //    entity.Property(e => e.Routeid).HasColumnName("routeid");

            //    entity.Property(e => e.Sealno)
            //        .HasColumnName("sealno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Servicelevelid).HasColumnName("servicelevelid");

            //    entity.Property(e => e.Shade)
            //        .HasColumnName("shade")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shipcompletedate)
            //        .HasColumnName("shipcompletedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shipcompleteflag).HasColumnName("shipcompleteflag");

            //    entity.Property(e => e.Shipmentgroupcreatedate)
            //        .HasColumnName("shipmentgroupcreatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shipmentmemo)
            //        .HasColumnName("shipmentmemo")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Shipmentnogroup)
            //        .HasColumnName("shipmentnogroup")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Shipping).HasColumnName("shipping");

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");

            //    entity.Property(e => e.Shiptodestinationid).HasColumnName("shiptodestinationid");

            //    entity.Property(e => e.Sonumber)
            //        .HasColumnName("sonumber")
            //        .HasMaxLength(24);

            //    entity.Property(e => e.Tareweight)
            //        .HasColumnName("tareweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Tmsinterfaceid).HasColumnName("tmsinterfaceid");

            //    entity.Property(e => e.Tmsloadid)
            //        .HasColumnName("tmsloadid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Transferdate)
            //        .HasColumnName("transferdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Transfertype).HasColumnName("transfertype");

            //    entity.Property(e => e.Transportmodecode).HasColumnName("transportmodecode");

            //    entity.Property(e => e.Transportordertypeid).HasColumnName("transportordertypeid");

            //    entity.Property(e => e.Transporttype)
            //        .HasColumnName("transporttype")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Vessel).HasColumnName("vessel");

            //    entity.Property(e => e.Vesselname1)
            //        .HasColumnName("vesselname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Vesselname2)
            //        .HasColumnName("vesselname2")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<EscdbTbtShippingstatus>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Pickingno, e.Installment, e.Lineno })
            //        .HasName("escdb_tbt_shippingstatus_pkey");

            //    entity.ToTable("escdb_tbt_shippingstatus", "wh");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Statusid })
            //        .HasName("wh_escdb_tbt_shippingstatus_10");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Canceldate)
            //        .HasColumnName("canceldate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Entrydate)
            //        .HasColumnName("entrydate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pcidriverissueddate)
            //        .HasColumnName("pcidriverissueddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pciwarehouseissueddate)
            //        .HasColumnName("pciwarehouseissueddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pickingdate)
            //        .HasColumnName("pickingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shippingdate)
            //        .HasColumnName("shippingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Statusid).HasColumnName("statusid");

            //    entity.Property(e => e.Stockcontroldate)
            //        .HasColumnName("stockcontroldate")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<EscdbTbtShippingtransportation>(entity =>
            //{
            //    entity.HasKey(e => e.Transportseq)
            //        .HasName("escdb_tbt_shippingtransportation_pkey");

            //    entity.ToTable("escdb_tbt_shippingtransportation", "wh");

            //    entity.Property(e => e.Transportseq)
            //        .HasColumnName("transportseq")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Actualin)
            //        .HasColumnName("actualin")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Actualout)
            //        .HasColumnName("actualout")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Containerno)
            //        .HasColumnName("containerno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Drivername)
            //        .HasColumnName("drivername")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Outgoingcharge)
            //        .HasColumnName("outgoingcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Planin)
            //        .HasColumnName("planin")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Planout)
            //        .HasColumnName("planout")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Registrationno)
            //        .HasColumnName("registrationno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Shipmentno)
            //        .IsRequired()
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Totalshipweight)
            //        .HasColumnName("totalshipweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Transportcharge)
            //        .HasColumnName("transportcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Transporttypeid).HasColumnName("transporttypeid");

            //    entity.Property(e => e.Truckcompanyid).HasColumnName("truckcompanyid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<EscdbTbtStockbylocation>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Dcid, e.Locationid, e.Productid, e.Productconditionid, e.Palletno, e.Lotno })
            //        .HasName("escdb_tbt_stockbylocation_pkey");

            //    entity.ToTable("escdb_tbt_stockbylocation", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Beginqty)
            //        .HasColumnName("beginqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Lastupdatesince)
            //        .HasColumnName("lastupdatesince")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Quantity)
            //        .HasColumnName("quantity")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<EscdbTbtStockcountingdetail>(entity =>
            //{
            //    entity.HasKey(e => new { e.Docno, e.Lineno })
            //        .HasName("escdb_tbt_stockcountingdetail_pkey");

            //    entity.ToTable("escdb_tbt_stockcountingdetail", "wh");

            //    entity.Property(e => e.Docno)
            //        .HasColumnName("docno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Adjusteddate)
            //        .HasColumnName("adjusteddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Adjustedqty)
            //        .HasColumnName("adjustedqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Adjusteduser)
            //        .HasColumnName("adjusteduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Batchno)
            //        .HasColumnName("batchno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Cancelleddate)
            //        .HasColumnName("cancelleddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Cancelleduser)
            //        .HasColumnName("cancelleduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Counteddate)
            //        .HasColumnName("counteddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Countedqty)
            //        .HasColumnName("countedqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Counteduser)
            //        .HasColumnName("counteduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Inventoryqty)
            //        .HasColumnName("inventoryqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Palletno)
            //        .IsRequired()
            //        .HasColumnName("palletno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Reasonofadjustment)
            //        .HasColumnName("reasonofadjustment")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Unitid).HasColumnName("unitid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            //});

            //modelBuilder.Entity<EscdbTbtStockcountingheader>(entity =>
            //{
            //    entity.HasKey(e => e.Docno)
            //        .HasName("escdb_tbt_stockcountingheader_pkey");

            //    entity.ToTable("escdb_tbt_stockcountingheader", "wh");

            //    entity.Property(e => e.Docno)
            //        .HasColumnName("docno")
            //        .HasMaxLength(50)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Adjusteddate)
            //        .HasColumnName("adjusteddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Adjusteduser)
            //        .HasColumnName("adjusteduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Cancelleddate)
            //        .HasColumnName("cancelleddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Cancelleduser)
            //        .HasColumnName("cancelleduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Checkmoveflag).HasColumnName("checkmoveflag");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Plancountingdate)
            //        .HasColumnName("plancountingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Statusid).HasColumnName("statusid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            //});

            //modelBuilder.Entity<EscdbTbtStockmovement>(entity =>
            //{
            //    entity.HasKey(e => e.Seq)
            //        .HasName("escdb_tbt_stockmovement_pkey");

            //    entity.ToTable("escdb_tbt_stockmovement", "wh");

            //    entity.HasIndex(e => new { e.Customerid, e.Dcid, e.Receiveseq, e.Productid, e.Productconditionid, e.Lotno, e.Stockactual, e.Recordcancel, e.Palletno })
            //        .HasName("wh_escdb_tbt_stockmovement_22");

            //    entity.Property(e => e.Seq)
            //        .HasColumnName("seq")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Action)
            //        .IsRequired()
            //        .HasColumnName("action")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.ActuallyTransactiondate)
            //        .HasColumnName("actually_transactiondate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Postflag).HasColumnName("postflag");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Receiveseq).HasColumnName("receiveseq");

            //    entity.Property(e => e.Recordcancel).HasColumnName("recordcancel");

            //    entity.Property(e => e.Referenceslipno)
            //        .IsRequired()
            //        .HasColumnName("referenceslipno")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Stockactual)
            //        .HasColumnName("stockactual")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockhold)
            //        .HasColumnName("stockhold")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockpicking)
            //        .HasColumnName("stockpicking")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockreceive)
            //        .HasColumnName("stockreceive")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockshipping)
            //        .HasColumnName("stockshipping")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stocktransit)
            //        .HasColumnName("stocktransit")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stocktransportation)
            //        .HasColumnName("stocktransportation")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Transactiondate)
            //        .HasColumnName("transactiondate")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<EscdbTbtSuggestpickinglocation>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Pickinglineseq })
            //        .HasName("escdb_tbt_suggestpickinglocation_pkey");

            //    entity.ToTable("escdb_tbt_suggestpickinglocation", "wh");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Pickinglineseq).HasColumnName("pickinglineseq");

            //    entity.Property(e => e.Fullpallet).HasColumnName("fullpallet");

            //    entity.Property(e => e.Ispicked).HasColumnName("ispicked");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Lot)
            //        .HasColumnName("lot")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Palletid)
            //        .HasColumnName("palletid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Pickingqty)
            //        .HasColumnName("pickingqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Quantity)
            //        .HasColumnName("quantity")
            //        .HasColumnType("numeric(18,8)");

            //    entity.Property(e => e.Receiveseq).HasColumnName("receiveseq");

            //    entity.Property(e => e.Serial)
            //        .HasColumnName("serial")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Stickeruid)
            //        .HasColumnName("stickeruid")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Stockqty)
            //        .HasColumnName("stockqty")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<EscdbTbtTagmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Stickeruid, e.Receivingno, e.Lineno, e.Docrefno, e.Lotno })
            //        .HasName("escdb_tbt_tagmapping_pkey");

            //    entity.ToTable("escdb_tbt_tagmapping", "wh");

            //    entity.HasIndex(e => e.Productid)
            //        .HasName("wh_escdb_tbt_tagmapping_2");

            //    entity.HasIndex(e => new { e.Receivingno, e.Qty })
            //        .HasName("wh_escdb_tbt_tagmapping_4");

            //    entity.Property(e => e.Stickeruid)
            //        .HasColumnName("stickeruid")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Docrefno)
            //        .HasColumnName("docrefno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Actualweight)
            //        .HasColumnName("actualweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Batchno)
            //        .HasColumnName("batchno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Boxplno)
            //        .HasColumnName("boxplno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Checkroutedate)
            //        .HasColumnName("checkroutedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Checkrouteflag).HasColumnName("checkrouteflag");

            //    entity.Property(e => e.Checkrouteuser)
            //        .HasColumnName("checkrouteuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Doctype).HasColumnName("doctype");

            //    entity.Property(e => e.Expiredate).HasColumnName("expiredate");

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Mfgdate).HasColumnName("mfgdate");

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.PoNo)
            //        .HasColumnName("po_no")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("qty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Receiveddate)
            //        .HasColumnName("receiveddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Receivedunit).HasColumnName("receivedunit");

            //    entity.Property(e => e.Receivepackageid).HasColumnName("receivepackageid");

            //    entity.Property(e => e.Recseq).HasColumnName("recseq");

            //    entity.Property(e => e.Serial)
            //        .HasColumnName("serial")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            modelBuilder.Entity<TbmStockmaster>(entity =>
            {
                entity.HasKey(e => e.StockmasterId)
                    .HasName("tbm_stockmaster_pkey");

                entity.ToTable("tbm_stockmaster", "wh");

                entity.Property(e => e.StockmasterId)
                    .HasColumnName("stockmaster_id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DcType)
                    .IsRequired()
                    .HasColumnName("dc_type")
                    .HasMaxLength(50);

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("effective_date")
                    .HasColumnType("timestamp without time zone");

                entity.Property(e => e.LocationAreaM3)
                    .HasColumnName("location_area_m3")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.LocationCharge)
                    .HasColumnName("location_charge")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.LocationPlan).HasColumnName("location_plan");

                entity.Property(e => e.StorageTypeId).HasColumnName("storage_type_id");
            });

            //modelBuilder.Entity<WmsdbTbmClassification>(entity =>
            //{
            //    entity.HasKey(e => e.Classificationid)
            //        .HasName("wmsdb_tbm_classification_pkey");

            //    entity.ToTable("wmsdb_tbm_classification", "wh");

            //    entity.Property(e => e.Classificationid)
            //        .HasColumnName("classificationid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Classificationcode)
            //        .IsRequired()
            //        .HasColumnName("classificationcode")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Classificationname)
            //        .HasColumnName("classificationname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmCustomer>(entity =>
            //{
            //    entity.HasKey(e => e.Customerid)
            //        .HasName("wmsdb_tbm_customer_pkey");

            //    entity.ToTable("wmsdb_tbm_customer", "wh");

            //    entity.Property(e => e.Customerid)
            //        .HasColumnName("customerid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Alloweditdeleteinfplan).HasColumnName("alloweditdeleteinfplan");

            //    entity.Property(e => e.Businesstype)
            //        .HasColumnName("businesstype")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customeraddress)
            //        .HasColumnName("customeraddress")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Customercode)
            //        .IsRequired()
            //        .HasColumnName("customercode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customername)
            //        .IsRequired()
            //        .HasColumnName("customername")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Defaultinventoryunit).HasColumnName("defaultinventoryunit");

            //    entity.Property(e => e.Defaultreceivingdatetype).HasColumnName("defaultreceivingdatetype");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Emailaddress)
            //        .HasColumnName("emailaddress")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Ischkserial).HasColumnName("ischkserial");

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Serialproductlen).HasColumnName("serialproductlen");

            //    entity.Property(e => e.Stateorprovince)
            //        .HasColumnName("stateorprovince")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Tuprefix)
            //        .HasColumnName("tuprefix")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmCustomerportmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Portid })
            //        .HasName("wmsdb_tbm_customerportmapping_pkey");

            //    entity.ToTable("wmsdb_tbm_customerportmapping", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Portid).HasColumnName("portid");
            //});

            //modelBuilder.Entity<WmsdbTbmCustshippingcustmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Shippingcustomerid })
            //        .HasName("wmsdb_tbm_custshippingcustmapping_pkey");

            //    entity.ToTable("wmsdb_tbm_custshippingcustmapping", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");
            //});

            //modelBuilder.Entity<WmsdbTbmDccodemapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Rubixdccode, e.Sapdccode })
            //        .HasName("wmsdb_tbm_dccodemapping_pkey");

            //    entity.ToTable("wmsdb_tbm_dccodemapping", "wh");

            //    entity.Property(e => e.Rubixdccode)
            //        .HasColumnName("rubixdccode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Sapdccode)
            //        .HasColumnName("sapdccode")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmDccustomermapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Dcid, e.Customerid })
            //        .HasName("wmsdb_tbm_dccustomermapping_pkey");

            //    entity.ToTable("wmsdb_tbm_dccustomermapping", "wh");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");
            //});

            //modelBuilder.Entity<WmsdbTbmDeadstock>(entity =>
            //{
            //    entity.HasKey(e => e.Codename)
            //        .HasName("wmsdb_tbm_deadstock_pkey");

            //    entity.ToTable("wmsdb_tbm_deadstock", "wh");

            //    entity.Property(e => e.Codename)
            //        .HasColumnName("codename")
            //        .HasMaxLength(50)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Codedescription)
            //        .HasColumnName("codedescription")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Databasename)
            //        .HasColumnName("databasename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Emptystockday).HasColumnName("emptystockday");

            //    entity.Property(e => e.Expbillingcostday).HasColumnName("expbillingcostday");

            //    entity.Property(e => e.Expbillingdataday).HasColumnName("expbillingdataday");

            //    entity.Property(e => e.Exphistoryday).HasColumnName("exphistoryday");

            //    entity.Property(e => e.Expreceivecompleteday).HasColumnName("expreceivecompleteday");

            //    entity.Property(e => e.Expreceiveincompleteday).HasColumnName("expreceiveincompleteday");

            //    entity.Property(e => e.Expserialdataday).HasColumnName("expserialdataday");

            //    entity.Property(e => e.Expshippingcompleteday).HasColumnName("expshippingcompleteday");

            //    entity.Property(e => e.Expshippingincompleteday).HasColumnName("expshippingincompleteday");

            //    entity.Property(e => e.Expstocktaking).HasColumnName("expstocktaking");

            //    entity.Property(e => e.Login)
            //        .HasColumnName("login")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Password)
            //        .HasColumnName("password")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Servername)
            //        .HasColumnName("servername")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmDefaultinitialtransitzone>(entity =>
            //{
            //    entity.HasKey(e => new { e.Dccode, e.Ownercode, e.Zonecode, e.Productconditioncode, e.Typeofgoodscode })
            //        .HasName("wmsdb_tbm_defaultinitialtransitzone_pkey");

            //    entity.ToTable("wmsdb_tbm_defaultinitialtransitzone", "wh");

            //    entity.Property(e => e.Dccode)
            //        .HasColumnName("dccode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Ownercode)
            //        .HasColumnName("ownercode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Zonecode)
            //        .HasColumnName("zonecode")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Productconditioncode)
            //        .HasColumnName("productconditioncode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Typeofgoodscode)
            //        .HasColumnName("typeofgoodscode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmDistributioncenter>(entity =>
            //{
            //    entity.HasKey(e => e.Dcid)
            //        .HasName("wmsdb_tbm_distributioncenter_pkey");

            //    entity.ToTable("wmsdb_tbm_distributioncenter", "wh");

            //    entity.Property(e => e.Dcid)
            //        .HasColumnName("dcid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Address1)
            //        .HasColumnName("address1")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Address2)
            //        .HasColumnName("address2")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Controlpackid).HasColumnName("controlpackid");

            //    entity.Property(e => e.Controlpalletid).HasColumnName("controlpalletid");

            //    entity.Property(e => e.Controlqcpickid).HasColumnName("controlqcpickid");

            //    entity.Property(e => e.Controlresourceid).HasColumnName("controlresourceid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Dccode)
            //        .IsRequired()
            //        .HasColumnName("dccode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Dclongname)
            //        .HasColumnName("dclongname")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Defaultdamageroutecode)
            //        .HasColumnName("defaultdamageroutecode")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Externaldivisionflag).HasColumnName("externaldivisionflag");

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Inchargeemail)
            //        .HasColumnName("inchargeemail")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Manpower).HasColumnName("manpower");

            //    entity.Property(e => e.Maxcapacity)
            //        .HasColumnName("maxcapacity")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Maxm2)
            //        .HasColumnName("maxm2")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Maxm3)
            //        .HasColumnName("maxm3")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Maxpallet).HasColumnName("maxpallet");

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Noofforklift).HasColumnName("noofforklift");

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Staginglocationcode)
            //        .HasColumnName("staginglocationcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmFinaldestination>(entity =>
            //{
            //    entity.HasKey(e => e.Finaldestinationid)
            //        .HasName("wmsdb_tbm_finaldestination_pkey");

            //    entity.ToTable("wmsdb_tbm_finaldestination", "wh");

            //    entity.Property(e => e.Finaldestinationid)
            //        .HasColumnName("finaldestinationid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Finaldestinationaddress)
            //        .HasColumnName("finaldestinationaddress")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Finaldestinationcode)
            //        .IsRequired()
            //        .HasColumnName("finaldestinationcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Finaldestinationdetail)
            //        .HasColumnName("finaldestinationdetail")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Finaldestinationlongname)
            //        .HasColumnName("finaldestinationlongname")
            //        .HasMaxLength(250);

            //    entity.Property(e => e.Imagefile).HasColumnName("imagefile");

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Km)
            //        .HasColumnName("km")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Leadtimedays).HasColumnName("leadtimedays");

            //    entity.Property(e => e.Leadtimehr)
            //        .HasColumnName("leadtimehr")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");

            //    entity.Property(e => e.Stateorprovince)
            //        .HasColumnName("stateorprovince")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmKanbanstatus>(entity =>
            //{
            //    entity.HasKey(e => e.Kanbanstatusid)
            //        .HasName("wmsdb_tbm_kanbanstatus_pkey");

            //    entity.ToTable("wmsdb_tbm_kanbanstatus", "wh");

            //    entity.Property(e => e.Kanbanstatusid)
            //        .HasColumnName("kanbanstatusid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Kanbanstatus)
            //        .HasColumnName("kanbanstatus")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmLocation>(entity =>
            //{
            //    entity.HasKey(e => e.Locationid)
            //        .HasName("wmsdb_tbm_location_pkey");

            //    entity.ToTable("wmsdb_tbm_location", "wh");

            //    entity.HasIndex(e => new { e.Locationid, e.Zoneid, e.Productconditionid, e.Deleteflag, e.Locationlogoff })
            //        .HasName("wh_wmsdb_tbm_location_28");

            //    entity.Property(e => e.Locationid)
            //        .HasColumnName("locationid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Capacityunitid).HasColumnName("capacityunitid");

            //    entity.Property(e => e.Controlmixlotid).HasColumnName("controlmixlotid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customlocationcode)
            //        .HasColumnName("customlocationcode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Fullcapacityflag).HasColumnName("fullcapacityflag");

            //    entity.Property(e => e.Layoutid).HasColumnName("layoutid");

            //    entity.Property(e => e.Level)
            //        .HasColumnName("level")
            //        .HasMaxLength(2);

            //    entity.Property(e => e.Locationcode)
            //        .IsRequired()
            //        .HasColumnName("locationcode")
            //        .HasMaxLength(17);

            //    entity.Property(e => e.Locationlogoff).HasColumnName("locationlogoff");

            //    entity.Property(e => e.Locationname)
            //        .IsRequired()
            //        .HasColumnName("locationname")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Locationtypeid).HasColumnName("locationtypeid");

            //    entity.Property(e => e.Maxcapacity)
            //        .HasColumnName("maxcapacity")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Maxm2)
            //        .HasColumnName("maxm2")
            //        .HasColumnType("numeric(18,5)");

            //    entity.Property(e => e.Maxm3)
            //        .HasColumnName("maxm3")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Maxunit).HasColumnName("maxunit");

            //    entity.Property(e => e.Movementtypeid).HasColumnName("movementtypeid");

            //    entity.Property(e => e.Noofpallet).HasColumnName("noofpallet");

            //    entity.Property(e => e.Pickingpriority).HasColumnName("pickingpriority");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Rackno)
            //        .IsRequired()
            //        .HasColumnName("rackno")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Sequencepick).HasColumnName("sequencepick");

            //    entity.Property(e => e.Stack).HasColumnName("stack");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            //});

            //modelBuilder.Entity<WmsdbTbmLocationLayout>(entity =>
            //{
            //    entity.HasKey(e => e.Layoutid)
            //        .HasName("wmsdb_tbm_location_layout_pkey");

            //    entity.ToTable("wmsdb_tbm_location_layout", "wh");

            //    entity.Property(e => e.Layoutid)
            //        .HasColumnName("layoutid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Captionposition)
            //        .IsRequired()
            //        .HasColumnName("captionposition")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.Height).HasColumnName("height");

            //    entity.Property(e => e.Locationlayoutcode)
            //        .IsRequired()
            //        .HasColumnName("locationlayoutcode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Locationlayoutname)
            //        .IsRequired()
            //        .HasColumnName("locationlayoutname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Positionx).HasColumnName("positionx");

            //    entity.Property(e => e.Positiony).HasColumnName("positiony");

            //    entity.Property(e => e.Type)
            //        .IsRequired()
            //        .HasColumnName("type")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Width).HasColumnName("width");
            //});

            //modelBuilder.Entity<WmsdbTbmLogoimage>(entity =>
            //{
            //    entity.HasKey(e => e.Logoid)
            //        .HasName("wmsdb_tbm_logoimage_pkey");

            //    entity.ToTable("wmsdb_tbm_logoimage", "wh");

            //    entity.Property(e => e.Logoid)
            //        .HasColumnName("logoid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Logofilename).HasColumnName("logofilename");
            //});

            //modelBuilder.Entity<WmsdbTbmMisc>(entity =>
            //{
            //    entity.HasKey(e => new { e.Propertyfield, e.Propertyid })
            //        .HasName("wmsdb_tbm_misc_pkey");

            //    entity.ToTable("wmsdb_tbm_misc", "wh");

            //    entity.Property(e => e.Propertyfield)
            //        .HasColumnName("propertyfield")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Propertyid).HasColumnName("propertyid");

            //    entity.Property(e => e.Isactive).HasColumnName("isactive");

            //    entity.Property(e => e.Propertycode)
            //        .IsRequired()
            //        .HasColumnName("propertycode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Propertydescription)
            //        .HasColumnName("propertydescription")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Propertyname)
            //        .HasColumnName("propertyname")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Propertysequence).HasColumnName("propertysequence");
            //});

            //modelBuilder.Entity<WmsdbTbmOtp>(entity =>
            //{
            //    entity.ToTable("wmsdb_tbm_otp", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Otpcode)
            //        .HasColumnName("otpcode")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.Otpexpired)
            //        .HasColumnName("otpexpired")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Usercode)
            //        .HasColumnName("usercode")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmPackage>(entity =>
            //{
            //    entity.HasKey(e => e.Packageid)
            //        .HasName("wmsdb_tbm_package_pkey");

            //    entity.ToTable("wmsdb_tbm_package", "wh");

            //    entity.Property(e => e.Packageid)
            //        .HasColumnName("packageid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Packagecode)
            //        .IsRequired()
            //        .HasColumnName("packagecode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Packagename)
            //        .HasColumnName("packagename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(2550);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmPackageoutbound>(entity =>
            //{
            //    entity.HasKey(e => e.Packageid)
            //        .HasName("wmsdb_tbm_packageoutbound_pkey");

            //    entity.ToTable("wmsdb_tbm_packageoutbound", "wh");

            //    entity.Property(e => e.Packageid)
            //        .HasColumnName("packageid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Packagecode)
            //        .IsRequired()
            //        .HasColumnName("packagecode")
            //        .HasMaxLength(12);

            //    entity.Property(e => e.Packagename)
            //        .HasColumnName("packagename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(2550);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmPackageoutboundd>(entity =>
            //{
            //    entity.HasKey(e => new { e.Effectivedate, e.Packageid, e.Servicetypeid })
            //        .HasName("wmsdb_tbm_packageoutboundd_pkey");

            //    entity.ToTable("wmsdb_tbm_packageoutboundd", "wh");

            //    entity.Property(e => e.Effectivedate).HasColumnName("effectivedate");

            //    entity.Property(e => e.Packageid).HasColumnName("packageid");

            //    entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Servicecharge)
            //        .HasColumnName("servicecharge")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<WmsdbTbmPlantmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Plant, e.Dccode, e.Ownercode })
            //        .HasName("wmsdb_tbm_plantmapping_pkey");

            //    entity.ToTable("wmsdb_tbm_plantmapping", "wh");

            //    entity.Property(e => e.Plant)
            //        .HasColumnName("plant")
            //        .HasMaxLength(8);

            //    entity.Property(e => e.Dccode)
            //        .HasColumnName("dccode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Ownercode)
            //        .HasColumnName("ownercode")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmPort>(entity =>
            //{
            //    entity.HasKey(e => e.Portid)
            //        .HasName("wmsdb_tbm_port_pkey");

            //    entity.ToTable("wmsdb_tbm_port", "wh");

            //    entity.Property(e => e.Portid)
            //        .HasColumnName("portid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Countrycode)
            //        .HasColumnName("countrycode")
            //        .HasMaxLength(4);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Leadtimedays).HasColumnName("leadtimedays");

            //    entity.Property(e => e.Leadtimehr)
            //        .HasColumnName("leadtimehr")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Portaddress)
            //        .HasColumnName("portaddress")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Portclassification).HasColumnName("portclassification");

            //    entity.Property(e => e.Portcode)
            //        .IsRequired()
            //        .HasColumnName("portcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Portlongname)
            //        .HasColumnName("portlongname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmProduct>(entity =>
            //{
            //    entity.HasKey(e => e.Productid)
            //        .HasName("wmsdb_tbm_product_pkey");

            //    entity.ToTable("wmsdb_tbm_product", "wh");

            //    entity.HasIndex(e => new { e.Productid, e.Controlpalletid })
            //        .HasName("wh_wmsdb_tbm_product_36");

            //    entity.Property(e => e.Productid)
            //        .HasColumnName("productid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Accpaclocation)
            //        .HasColumnName("accpaclocation")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Classificationid).HasColumnName("classificationid");

            //    entity.Property(e => e.Controlbagid).HasColumnName("controlbagid");

            //    entity.Property(e => e.Controllotid).HasColumnName("controllotid");

            //    entity.Property(e => e.Controlpalletid).HasColumnName("controlpalletid");

            //    entity.Property(e => e.Controlpickingid).HasColumnName("controlpickingid");

            //    entity.Property(e => e.Controlserialid).HasColumnName("controlserialid");

            //    entity.Property(e => e.Controlvoidid).HasColumnName("controlvoidid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Estimatevalue)
            //        .HasColumnName("estimatevalue")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Freeofcharge).HasColumnName("freeofcharge");

            //    entity.Property(e => e.Imagefile).HasColumnName("imagefile");

            //    entity.Property(e => e.Itemexpiredtypeid).HasColumnName("itemexpiredtypeid");

            //    entity.Property(e => e.Kanbancontrol).HasColumnName("kanbancontrol");

            //    entity.Property(e => e.Lotcontrol).HasColumnName("lotcontrol");

            //    entity.Property(e => e.Maker)
            //        .HasColumnName("maker")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Movementtypeid).HasColumnName("movementtypeid");

            //    entity.Property(e => e.Needqc).HasColumnName("needqc");

            //    entity.Property(e => e.Pallettypeid).HasColumnName("pallettypeid");

            //    entity.Property(e => e.Prefixdomestic)
            //        .HasColumnName("prefixdomestic")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Prefixexport)
            //        .HasColumnName("prefixexport")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Prefiximport)
            //        .HasColumnName("prefiximport")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Price)
            //        .HasColumnName("price")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Productbarcode)
            //        .HasColumnName("productbarcode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Productcode)
            //        .IsRequired()
            //        .HasColumnName("productcode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Productlongname)
            //        .HasColumnName("productlongname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Productmask)
            //        .HasColumnName("productmask")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Safetystock)
            //        .HasColumnName("safetystock")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Scantype).HasColumnName("scantype");

            //    entity.Property(e => e.Seriallength).HasColumnName("seriallength");

            //    entity.Property(e => e.Serialmask)
            //        .HasColumnName("serialmask")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Shelflife).HasColumnName("shelflife");

            //    entity.Property(e => e.Shelflifepicking).HasColumnName("shelflifepicking");

            //    entity.Property(e => e.Shelflifereceive).HasColumnName("shelflifereceive");

            //    entity.Property(e => e.Subtypeofgoodsid).HasColumnName("subtypeofgoodsid");

            //    entity.Property(e => e.Syncdate)
            //        .HasColumnName("syncdate")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Typeofgoodsid).HasColumnName("typeofgoodsid");

            //    entity.Property(e => e.Unitlevelreceivinglabel).HasColumnName("unitlevelreceivinglabel");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmProductDetail>(entity =>
            //{
            //    entity.HasKey(e => new { e.Productid, e.Plant })
            //        .HasName("wmsdb_tbm_product_detail_pkey");

            //    entity.ToTable("wmsdb_tbm_product_detail", "wh");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Plant)
            //        .HasColumnName("plant")
            //        .HasMaxLength(4);

            //    entity.Property(e => e.Countryoforigin)
            //        .HasColumnName("countryoforigin")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Hierachyfirst3char)
            //        .HasColumnName("hierachyfirst3char")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Materialgroup2)
            //        .HasColumnName("materialgroup2")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Materialgroup3)
            //        .HasColumnName("materialgroup3")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Materialgroup4)
            //        .HasColumnName("materialgroup4")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Materialtype)
            //        .HasColumnName("materialtype")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Sku)
            //        .HasColumnName("sku")
            //        .HasMaxLength(18);

            //    entity.Property(e => e.Skudescription)
            //        .HasColumnName("skudescription")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Status)
            //        .HasColumnName("status")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.Stc)
            //        .HasColumnName("stc")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Uom)
            //        .HasColumnName("uom")
            //        .HasMaxLength(3);
            //});

            //modelBuilder.Entity<WmsdbTbmProductcondition>(entity =>
            //{
            //    entity.HasKey(e => e.Productconditionid)
            //        .HasName("wmsdb_tbm_productcondition_pkey");

            //    entity.ToTable("wmsdb_tbm_productcondition", "wh");

            //    entity.Property(e => e.Productconditionid)
            //        .HasColumnName("productconditionid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Acerallowreconcileflg).HasColumnName("acerallowreconcileflg");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Locationgroup)
            //        .HasColumnName("locationgroup")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Productconditioncode)
            //        .IsRequired()
            //        .HasColumnName("productconditioncode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Productconditionname)
            //        .IsRequired()
            //        .HasColumnName("productconditionname")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmProductdefaultunit>(entity =>
            //{
            //    entity.HasKey(e => new { e.Productid, e.Packageid })
            //        .HasName("wmsdb_tbm_productdefaultunit_pkey");

            //    entity.ToTable("wmsdb_tbm_productdefaultunit", "wh");

            //    entity.HasIndex(e => e.Productid)
            //        .HasName("wh_wmsdb_tbm_productdefaultunit_28");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Packageid).HasColumnName("packageid");

            //    entity.Property(e => e.Barcodeofunitlevel1)
            //        .HasColumnName("barcodeofunitlevel1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Barcodeofunitlevel2)
            //        .HasColumnName("barcodeofunitlevel2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Barcodeofunitlevel3)
            //        .HasColumnName("barcodeofunitlevel3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Barcodeofunitlevel4)
            //        .HasColumnName("barcodeofunitlevel4")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Grossweight)
            //        .HasColumnName("grossweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.M3)
            //        .HasColumnName("m3")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Netweight)
            //        .HasColumnName("netweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Numberofunitlevel2)
            //        .HasColumnName("numberofunitlevel2")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Numberofunitlevel3)
            //        .HasColumnName("numberofunitlevel3")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Numberofunitlevel4)
            //        .HasColumnName("numberofunitlevel4")
            //        .HasColumnType("numeric(18,5)");

            //    entity.Property(e => e.Rpttypeofunitlevel1).HasColumnName("rpttypeofunitlevel1");

            //    entity.Property(e => e.Rpttypeofunitlevel2).HasColumnName("rpttypeofunitlevel2");

            //    entity.Property(e => e.Rpttypeofunitlevel3).HasColumnName("rpttypeofunitlevel3");

            //    entity.Property(e => e.Rpttypeofunitlevel4).HasColumnName("rpttypeofunitlevel4");

            //    entity.Property(e => e.Typeofunitdisplay).HasColumnName("typeofunitdisplay");

            //    entity.Property(e => e.Typeofunitinventory).HasColumnName("typeofunitinventory");

            //    entity.Property(e => e.Typeofunitlevel1).HasColumnName("typeofunitlevel1");

            //    entity.Property(e => e.Typeofunitlevel2).HasColumnName("typeofunitlevel2");

            //    entity.Property(e => e.Typeofunitlevel3).HasColumnName("typeofunitlevel3");

            //    entity.Property(e => e.Typeofunitlevel4).HasColumnName("typeofunitlevel4");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Volumeofunitlevel1)
            //        .HasColumnName("volumeofunitlevel1")
            //        .HasColumnType("numeric(19,5)");
            //});

            //modelBuilder.Entity<WmsdbTbmProductdefaultzonetransit>(entity =>
            //{
            //    entity.HasKey(e => new { e.Productid, e.Productconditionid, e.Zoneid, e.Locationid })
            //        .HasName("wmsdb_tbm_productdefaultzonetransit_pkey");

            //    entity.ToTable("wmsdb_tbm_productdefaultzonetransit", "wh");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmProducthandingcharge>(entity =>
            //{
            //    entity.HasKey(e => e.Seqno)
            //        .HasName("wmsdb_tbm_producthandingcharge_pkey");

            //    entity.ToTable("wmsdb_tbm_producthandingcharge", "wh");

            //    entity.Property(e => e.Seqno)
            //        .HasColumnName("seqno")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Effectivedate).HasColumnName("effectivedate");

            //    entity.Property(e => e.Incomingcharge)
            //        .HasColumnName("incomingcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Outgoingcharge)
            //        .HasColumnName("outgoingcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Packageid).HasColumnName("packageid");

            //    entity.Property(e => e.Pickingcharge)
            //        .HasColumnName("pickingcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Status).HasColumnName("status");

            //    entity.Property(e => e.Transitcharge)
            //        .HasColumnName("transitcharge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Typeofunitincoming).HasColumnName("typeofunitincoming");

            //    entity.Property(e => e.Typeofunitoutgoing).HasColumnName("typeofunitoutgoing");

            //    entity.Property(e => e.Typeofunitpicking).HasColumnName("typeofunitpicking");

            //    entity.Property(e => e.Typeofunittransit).HasColumnName("typeofunittransit");

            //    entity.Property(e => e.Typeofunitvoid).HasColumnName("typeofunitvoid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Voidcharge)
            //        .HasColumnName("voidcharge")
            //        .HasColumnType("numeric(18,2)");
            //});

            //modelBuilder.Entity<WmsdbTbmProductnotification>(entity =>
            //{
            //    entity.HasKey(e => new { e.Productid, e.Notificationitemid })
            //        .HasName("wmsdb_tbm_productnotification_pkey");

            //    entity.ToTable("wmsdb_tbm_productnotification", "wh");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Notificationitemid).HasColumnName("notificationitemid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmRoute>(entity =>
            //{
            //    entity.HasKey(e => e.Routeid)
            //        .HasName("wmsdb_tbm_route_pkey");

            //    entity.ToTable("wmsdb_tbm_route", "wh");

            //    entity.Property(e => e.Routeid)
            //        .HasColumnName("routeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Routecode)
            //        .IsRequired()
            //        .HasColumnName("routecode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Routename)
            //        .HasColumnName("routename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmRouted>(entity =>
            //{
            //    entity.HasKey(e => new { e.Routeid, e.Sequenceno })
            //        .HasName("wmsdb_tbm_routed_pkey");

            //    entity.ToTable("wmsdb_tbm_routed", "wh");

            //    entity.Property(e => e.Routeid).HasColumnName("routeid");

            //    entity.Property(e => e.Sequenceno).HasColumnName("sequenceno");

            //    entity.Property(e => e.Amphurid).HasColumnName("amphurid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Finaldestinationid).HasColumnName("finaldestinationid");

            //    entity.Property(e => e.Provinceid).HasColumnName("provinceid");

            //    entity.Property(e => e.Routeseqno).HasColumnName("routeseqno");
            //});

            //modelBuilder.Entity<WmsdbTbmShippingarea>(entity =>
            //{
            //    entity.HasKey(e => e.Shippingareaid)
            //        .HasName("wmsdb_tbm_shippingarea_pkey");

            //    entity.ToTable("wmsdb_tbm_shippingarea", "wh");

            //    entity.Property(e => e.Shippingareaid)
            //        .HasColumnName("shippingareaid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shippingareacode)
            //        .IsRequired()
            //        .HasColumnName("shippingareacode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Shippingareaname)
            //        .IsRequired()
            //        .HasColumnName("shippingareaname")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmShippingcontainer>(entity =>
            //{
            //    entity.ToTable("wmsdb_tbm_shippingcontainer", "wh");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Containerno)
            //        .HasColumnName("containerno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Shippingdate)
            //        .HasColumnName("shippingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shippingno)
            //        .HasColumnName("shippingno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Shippingqty)
            //        .HasColumnName("shippingqty")
            //        .HasColumnType("numeric(18,2)");
            //});

            //modelBuilder.Entity<WmsdbTbmShippingcustomer>(entity =>
            //{
            //    entity.HasKey(e => e.Shippingcustomerid)
            //        .HasName("wmsdb_tbm_shippingcustomer_pkey");

            //    entity.ToTable("wmsdb_tbm_shippingcustomer", "wh");

            //    entity.Property(e => e.Shippingcustomerid)
            //        .HasColumnName("shippingcustomerid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Address)
            //        .HasColumnName("address")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Businesstype)
            //        .HasColumnName("businesstype")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Emailaddress)
            //        .HasColumnName("emailaddress")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Shippingcustomercode)
            //        .IsRequired()
            //        .HasColumnName("shippingcustomercode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shippingcustomername)
            //        .IsRequired()
            //        .HasColumnName("shippingcustomername")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Stateorprovince)
            //        .HasColumnName("stateorprovince")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmSubtypeofgoods>(entity =>
            //{
            //    entity.HasKey(e => e.Subtypeofgoodsid)
            //        .HasName("wmsdb_tbm_subtypeofgoods_pkey");

            //    entity.ToTable("wmsdb_tbm_subtypeofgoods", "wh");

            //    entity.Property(e => e.Subtypeofgoodsid)
            //        .HasColumnName("subtypeofgoodsid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Subtypeofgoodscode)
            //        .IsRequired()
            //        .HasColumnName("subtypeofgoodscode")
            //        .HasMaxLength(25);

            //    entity.Property(e => e.Subtypeofgoodsname)
            //        .IsRequired()
            //        .HasColumnName("subtypeofgoodsname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Typeofgoodsid).HasColumnName("typeofgoodsid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmSupplier>(entity =>
            //{
            //    entity.HasKey(e => e.Supplierid)
            //        .HasName("wmsdb_tbm_supplier_pkey");

            //    entity.ToTable("wmsdb_tbm_supplier", "wh");

            //    entity.Property(e => e.Supplierid)
            //        .HasColumnName("supplierid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.City)
            //        .HasColumnName("city")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Country)
            //        .HasColumnName("country")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Emailaddress)
            //        .HasColumnName("emailaddress")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Km).HasColumnName("km");

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Postalcode)
            //        .HasColumnName("postalcode")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Recordid)
            //        .HasColumnName("recordid")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Stateorprovince)
            //        .HasColumnName("stateorprovince")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Supplieraddress1)
            //        .HasColumnName("supplieraddress1")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Supplieraddress2)
            //        .HasColumnName("supplieraddress2")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Suppliercode)
            //        .IsRequired()
            //        .HasColumnName("suppliercode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Supplierlongname)
            //        .HasColumnName("supplierlongname")
            //        .HasMaxLength(60);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmTransporttype>(entity =>
            //{
            //    entity.HasKey(e => e.Transporttypeid)
            //        .HasName("wmsdb_tbm_transporttype_pkey");

            //    entity.ToTable("wmsdb_tbm_transporttype", "wh");

            //    entity.Property(e => e.Transporttypeid)
            //        .HasColumnName("transporttypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Containerweight)
            //        .HasColumnName("containerweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Height)
            //        .HasColumnName("height")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Length)
            //        .HasColumnName("length")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Maxm3)
            //        .HasColumnName("maxm3")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Transporttypecode)
            //        .IsRequired()
            //        .HasColumnName("transporttypecode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Transporttypename)
            //        .IsRequired()
            //        .HasColumnName("transporttypename")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Width)
            //        .HasColumnName("width")
            //        .HasColumnType("numeric(18,2)");
            //});

            //modelBuilder.Entity<WmsdbTbmTransportunstaffingcharge>(entity =>
            //{
            //    entity.HasKey(e => e.Transportunstaffingid)
            //        .HasName("wmsdb_tbm_transportunstaffingcharge_pkey");

            //    entity.ToTable("wmsdb_tbm_transportunstaffingcharge", "wh");

            //    entity.Property(e => e.Transportunstaffingid)
            //        .HasColumnName("transportunstaffingid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Charge)
            //        .HasColumnName("charge")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Effectivedate).HasColumnName("effectivedate");

            //    entity.Property(e => e.Finaldestinationid).HasColumnName("finaldestinationid");

            //    entity.Property(e => e.Fuelprice)
            //        .HasColumnName("fuelprice")
            //        .HasColumnType("numeric(18,2)");

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");

            //    entity.Property(e => e.Transporttypeid).HasColumnName("transporttypeid");

            //    entity.Property(e => e.Truckcompanyid).HasColumnName("truckcompanyid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmTruckcompany>(entity =>
            //{
            //    entity.HasKey(e => e.Truckcompanyid)
            //        .HasName("wmsdb_tbm_truckcompany_pkey");

            //    entity.ToTable("wmsdb_tbm_truckcompany", "wh");

            //    entity.Property(e => e.Truckcompanyid)
            //        .HasColumnName("truckcompanyid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Contactname1)
            //        .HasColumnName("contactname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname2)
            //        .HasColumnName("contactname2")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Contactname3)
            //        .HasColumnName("contactname3")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Extension)
            //        .HasColumnName("extension")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Faxno)
            //        .HasColumnName("faxno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Mobileno)
            //        .HasColumnName("mobileno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Phoneno)
            //        .HasColumnName("phoneno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Truckcompanyaddress)
            //        .HasColumnName("truckcompanyaddress")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Truckcompanycode)
            //        .IsRequired()
            //        .HasColumnName("truckcompanycode")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Truckcompanylongname)
            //        .HasColumnName("truckcompanylongname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmTrucktransporttypemapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Truckcompanyid, e.Transporttypeid })
            //        .HasName("wmsdb_tbm_trucktransporttypemapping_pkey");

            //    entity.ToTable("wmsdb_tbm_trucktransporttypemapping", "wh");

            //    entity.Property(e => e.Truckcompanyid).HasColumnName("truckcompanyid");

            //    entity.Property(e => e.Transporttypeid).HasColumnName("transporttypeid");
            //});

            //modelBuilder.Entity<WmsdbTbmTypeofgoods>(entity =>
            //{
            //    entity.HasKey(e => e.Typeofgoodsid)
            //        .HasName("wmsdb_tbm_typeofgoods_pkey");

            //    entity.ToTable("wmsdb_tbm_typeofgoods", "wh");

            //    entity.Property(e => e.Typeofgoodsid)
            //        .HasColumnName("typeofgoodsid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Typeofgoodscode)
            //        .IsRequired()
            //        .HasColumnName("typeofgoodscode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Typeofgoodsname)
            //        .IsRequired()
            //        .HasColumnName("typeofgoodsname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmTypeofunit>(entity =>
            //{
            //    entity.HasKey(e => e.Unitid)
            //        .HasName("wmsdb_tbm_typeofunit_pkey");

            //    entity.ToTable("wmsdb_tbm_typeofunit", "wh");

            //    entity.Property(e => e.Unitid)
            //        .HasColumnName("unitid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(2550);

            //    entity.Property(e => e.Unitcode)
            //        .IsRequired()
            //        .HasColumnName("unitcode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Unitname)
            //        .IsRequired()
            //        .HasColumnName("unitname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmWorkmethod>(entity =>
            //{
            //    entity.HasKey(e => e.Workmethodid)
            //        .HasName("wmsdb_tbm_workmethod_pkey");

            //    entity.ToTable("wmsdb_tbm_workmethod", "wh");

            //    entity.Property(e => e.Workmethodid)
            //        .HasColumnName("workmethodid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Description)
            //        .HasColumnName("description")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Workmethodcode)
            //        .IsRequired()
            //        .HasColumnName("workmethodcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Workmethodname)
            //        .HasColumnName("workmethodname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmWorkmethodsetting>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Dcid, e.Workmethodid, e.Moduleid })
            //        .HasName("wmsdb_tbm_workmethodsetting_pkey");

            //    entity.ToTable("wmsdb_tbm_workmethodsetting", "wh");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Workmethodid).HasColumnName("workmethodid");

            //    entity.Property(e => e.Moduleid).HasColumnName("moduleid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmZone>(entity =>
            //{
            //    entity.HasKey(e => e.Zoneid)
            //        .HasName("wmsdb_tbm_zone_pkey");

            //    entity.ToTable("wmsdb_tbm_zone", "wh");

            //    entity.Property(e => e.Zoneid)
            //        .HasColumnName("zoneid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Floor).HasColumnName("floor");

            //    entity.Property(e => e.Locationmoreonepalletflag).HasColumnName("locationmoreonepalletflag");

            //    entity.Property(e => e.Maxcapacityperpallet)
            //        .HasColumnName("maxcapacityperpallet")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stack).HasColumnName("stack");

            //    entity.Property(e => e.Storagelocation)
            //        .HasColumnName("storagelocation")
            //        .HasMaxLength(4);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Zonecategoryid).HasColumnName("zonecategoryid");

            //    entity.Property(e => e.Zonecode)
            //        .IsRequired()
            //        .HasColumnName("zonecode")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.Zonecolor)
            //        .HasColumnName("zonecolor")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.Zonename)
            //        .HasColumnName("zonename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmZonecustomermapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Zoneid, e.Customerid })
            //        .HasName("wmsdb_tbm_zonecustomermapping_pkey");

            //    entity.ToTable("wmsdb_tbm_zonecustomermapping", "wh");

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbmZoneusermapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Zoneid, e.Userid })
            //        .HasName("wmsdb_tbm_zoneusermapping_pkey");

            //    entity.ToTable("wmsdb_tbm_zoneusermapping", "wh");

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");

            //    entity.Property(e => e.Userid)
            //        .HasColumnName("userid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsAcJobnoRunning>(entity =>
            //{
            //    entity.HasKey(e => e.Seq)
            //        .HasName("wmsdb_tbs_ac_jobno_running_pkey");

            //    entity.ToTable("wmsdb_tbs_ac_jobno_running", "wh");

            //    entity.Property(e => e.Seq)
            //        .HasColumnName("seq")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Date).HasColumnName("date");

            //    entity.Property(e => e.InvoiceNo)
            //        .HasColumnName("invoice_no")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.RunningNo).HasColumnName("running_no");
            //});

            //modelBuilder.Entity<WmsdbTbsAmphur>(entity =>
            //{
            //    entity.HasKey(e => e.Amphurid)
            //        .HasName("wmsdb_tbs_amphur_pkey");

            //    entity.ToTable("wmsdb_tbs_amphur", "wh");

            //    entity.Property(e => e.Amphurid)
            //        .HasColumnName("amphurid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Amphurname)
            //        .HasColumnName("amphurname")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Provinceid).HasColumnName("provinceid");
            //});

            //modelBuilder.Entity<WmsdbTbsControlbag>(entity =>
            //{
            //    entity.HasKey(e => e.Controlbagid)
            //        .HasName("wmsdb_tbs_controlbag_pkey");

            //    entity.ToTable("wmsdb_tbs_controlbag", "wh");

            //    entity.Property(e => e.Controlbagid)
            //        .HasColumnName("controlbagid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlbagname)
            //        .IsRequired()
            //        .HasColumnName("controlbagname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsControllot>(entity =>
            //{
            //    entity.HasKey(e => e.Controllotid)
            //        .HasName("wmsdb_tbs_controllot_pkey");

            //    entity.ToTable("wmsdb_tbs_controllot", "wh");

            //    entity.Property(e => e.Controllotid)
            //        .HasColumnName("controllotid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controllotname)
            //        .IsRequired()
            //        .HasColumnName("controllotname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsControlmixlot>(entity =>
            //{
            //    entity.HasKey(e => e.Controlmixlotid)
            //        .HasName("wmsdb_tbs_controlmixlot_pkey");

            //    entity.ToTable("wmsdb_tbs_controlmixlot", "wh");

            //    entity.Property(e => e.Controlmixlotid)
            //        .HasColumnName("controlmixlotid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlmixlotname)
            //        .IsRequired()
            //        .HasColumnName("controlmixlotname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsControlpack>(entity =>
            //{
            //    entity.HasKey(e => e.Controlpackid)
            //        .HasName("wmsdb_tbs_controlpack_pkey");

            //    entity.ToTable("wmsdb_tbs_controlpack", "wh");

            //    entity.Property(e => e.Controlpackid)
            //        .HasColumnName("controlpackid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlpackname)
            //        .IsRequired()
            //        .HasColumnName("controlpackname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsControlpallet>(entity =>
            //{
            //    entity.HasKey(e => e.Controlpalletid)
            //        .HasName("wmsdb_tbs_controlpallet_pkey");

            //    entity.ToTable("wmsdb_tbs_controlpallet", "wh");

            //    entity.Property(e => e.Controlpalletid)
            //        .HasColumnName("controlpalletid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlpalletname)
            //        .IsRequired()
            //        .HasColumnName("controlpalletname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsControlpicking>(entity =>
            //{
            //    entity.HasKey(e => e.Controlpickingid)
            //        .HasName("wmsdb_tbs_controlpicking_pkey");

            //    entity.ToTable("wmsdb_tbs_controlpicking", "wh");

            //    entity.Property(e => e.Controlpickingid)
            //        .HasColumnName("controlpickingid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlpickingname)
            //        .IsRequired()
            //        .HasColumnName("controlpickingname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsControlserial>(entity =>
            //{
            //    entity.HasKey(e => e.Controlserialid)
            //        .HasName("wmsdb_tbs_controlserial_pkey");

            //    entity.ToTable("wmsdb_tbs_controlserial", "wh");

            //    entity.Property(e => e.Controlserialid)
            //        .HasColumnName("controlserialid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlserialname)
            //        .IsRequired()
            //        .HasColumnName("controlserialname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsControlshelflife>(entity =>
            //{
            //    entity.HasKey(e => e.Controlshelflifeid)
            //        .HasName("wmsdb_tbs_controlshelflife_pkey");

            //    entity.ToTable("wmsdb_tbs_controlshelflife", "wh");

            //    entity.Property(e => e.Controlshelflifeid)
            //        .HasColumnName("controlshelflifeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Controlshelflifename)
            //        .IsRequired()
            //        .HasColumnName("controlshelflifename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsControlvoid>(entity =>
            //{
            //    entity.HasKey(e => e.Controlvoidid)
            //        .HasName("wmsdb_tbs_controlvoid_pkey");

            //    entity.ToTable("wmsdb_tbs_controlvoid", "wh");

            //    entity.Property(e => e.Controlvoidid)
            //        .HasColumnName("controlvoidid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Canduplicate).HasColumnName("canduplicate");

            //    entity.Property(e => e.Controlvoidname)
            //        .IsRequired()
            //        .HasColumnName("controlvoidname")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Iscontrolvoid).HasColumnName("iscontrolvoid");
            //});

            //modelBuilder.Entity<WmsdbTbsDistrictOld>(entity =>
            //{
            //    entity.HasKey(e => new { e.Provinceid, e.Districtid })
            //        .HasName("wmsdb_tbs_district_old_pkey");

            //    entity.ToTable("wmsdb_tbs_district_old", "wh");

            //    entity.Property(e => e.Provinceid).HasColumnName("provinceid");

            //    entity.Property(e => e.Districtid).HasColumnName("districtid");

            //    entity.Property(e => e.Districtnameen)
            //        .HasColumnName("districtnameen")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Districtnameth)
            //        .HasColumnName("districtnameth")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<WmsdbTbsDoctype>(entity =>
            //{
            //    entity.HasKey(e => e.Doctypeid)
            //        .HasName("wmsdb_tbs_doctype_pkey");

            //    entity.ToTable("wmsdb_tbs_doctype", "wh");

            //    entity.Property(e => e.Doctypeid)
            //        .HasColumnName("doctypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createdby)
            //        .HasColumnName("createdby")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Doctypecode)
            //        .HasColumnName("doctypecode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Doctypedesc)
            //        .HasColumnName("doctypedesc")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsFiletype>(entity =>
            //{
            //    entity.HasKey(e => e.Filetypeid)
            //        .HasName("wmsdb_tbs_filetype_pkey");

            //    entity.ToTable("wmsdb_tbs_filetype", "wh");

            //    entity.Property(e => e.Filetypeid)
            //        .HasColumnName("filetypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Filetypename)
            //        .IsRequired()
            //        .HasColumnName("filetypename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsGeneratedocumentno>(entity =>
            //{
            //    entity.HasKey(e => e.Docnocode)
            //        .HasName("wmsdb_tbs_generatedocumentno_pkey");

            //    entity.ToTable("wmsdb_tbs_generatedocumentno", "wh");

            //    entity.Property(e => e.Docnocode)
            //        .HasColumnName("docnocode")
            //        .HasMaxLength(50)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Docnodescription)
            //        .HasColumnName("docnodescription")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Incrementstep).HasColumnName("incrementstep");

            //    entity.Property(e => e.Lastupdate)
            //        .HasColumnName("lastupdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Leadingtext)
            //        .HasColumnName("leadingtext")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Presentno).HasColumnName("presentno");

            //    entity.Property(e => e.Runningdigit)
            //        .HasColumnName("runningdigit")
            //        .HasMaxLength(10);
            //});

            //modelBuilder.Entity<WmsdbTbsItemexpiredtype>(entity =>
            //{
            //    entity.HasKey(e => e.Itemexpiredtypeid)
            //        .HasName("wmsdb_tbs_itemexpiredtype_pkey");

            //    entity.ToTable("wmsdb_tbs_itemexpiredtype", "wh");

            //    entity.Property(e => e.Itemexpiredtypeid)
            //        .HasColumnName("itemexpiredtypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Itemexpiredtypename)
            //        .HasColumnName("itemexpiredtypename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsModule>(entity =>
            //{
            //    entity.HasKey(e => e.Moduleid)
            //        .HasName("wmsdb_tbs_module_pkey");

            //    entity.ToTable("wmsdb_tbs_module", "wh");

            //    entity.Property(e => e.Moduleid)
            //        .HasColumnName("moduleid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Modulename)
            //        .HasColumnName("modulename")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<WmsdbTbsNotificationitem>(entity =>
            //{
            //    entity.HasKey(e => e.Notificationitemid)
            //        .HasName("wmsdb_tbs_notificationitem_pkey");

            //    entity.ToTable("wmsdb_tbs_notificationitem", "wh");

            //    entity.Property(e => e.Notificationitemid)
            //        .HasColumnName("notificationitemid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Notificationicon)
            //        .HasColumnName("notificationicon")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Notificationitemename)
            //        .IsRequired()
            //        .HasColumnName("notificationitemename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsOrderpattern>(entity =>
            //{
            //    entity.HasKey(e => e.Orderpatternid)
            //        .HasName("wmsdb_tbs_orderpattern_pkey");

            //    entity.ToTable("wmsdb_tbs_orderpattern", "wh");

            //    entity.Property(e => e.Orderpatternid)
            //        .HasColumnName("orderpatternid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Orderpatternname)
            //        .HasColumnName("orderpatternname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsOrordertype>(entity =>
            //{
            //    entity.HasKey(e => e.Ordertypeid)
            //        .HasName("wmsdb_tbs_orordertype_pkey");

            //    entity.ToTable("wmsdb_tbs_orordertype", "wh");

            //    entity.Property(e => e.Ordertypeid)
            //        .HasColumnName("ordertypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Defaultflag).HasColumnName("defaultflag");

            //    entity.Property(e => e.Ordertypedesc)
            //        .IsRequired()
            //        .HasColumnName("ordertypedesc")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Ordertypename)
            //        .IsRequired()
            //        .HasColumnName("ordertypename")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Ownercode)
            //        .IsRequired()
            //        .HasColumnName("ownercode")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsOtpmaster>(entity =>
            //{
            //    entity.HasKey(e => e.Otpid)
            //        .HasName("wmsdb_tbs_otpmaster_pkey");

            //    entity.ToTable("wmsdb_tbs_otpmaster", "wh");

            //    entity.Property(e => e.Otpid)
            //        .HasColumnName("otpid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Otpname)
            //        .HasColumnName("otpname")
            //        .HasMaxLength(20);
            //});

            //modelBuilder.Entity<WmsdbTbsPallettype>(entity =>
            //{
            //    entity.HasKey(e => e.Pallettypeid)
            //        .HasName("wmsdb_tbs_pallettype_pkey");

            //    entity.ToTable("wmsdb_tbs_pallettype", "wh");

            //    entity.Property(e => e.Pallettypeid)
            //        .HasColumnName("pallettypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Pallettypename)
            //        .IsRequired()
            //        .HasColumnName("pallettypename")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Weight)
            //        .HasColumnName("weight")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<WmsdbTbsPoordertype>(entity =>
            //{
            //    entity.HasKey(e => new { e.Ownercode, e.Ordertypeid })
            //        .HasName("wmsdb_tbs_poordertype_pkey");

            //    entity.ToTable("wmsdb_tbs_poordertype", "wh");

            //    entity.Property(e => e.Ownercode)
            //        .HasColumnName("ownercode")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

            //    entity.Property(e => e.Defaultflag).HasColumnName("defaultflag");

            //    entity.Property(e => e.Lotcontrol).HasColumnName("lotcontrol");

            //    entity.Property(e => e.Ordertypedesc)
            //        .IsRequired()
            //        .HasColumnName("ordertypedesc")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Ordertypename)
            //        .IsRequired()
            //        .HasColumnName("ordertypename")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsPortclassification>(entity =>
            //{
            //    entity.HasKey(e => e.Portclassificationid)
            //        .HasName("wmsdb_tbs_portclassification_pkey");

            //    entity.ToTable("wmsdb_tbs_portclassification", "wh");

            //    entity.Property(e => e.Portclassificationid)
            //        .HasColumnName("portclassificationid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Portclassificationname)
            //        .HasColumnName("portclassificationname")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbsProvince>(entity =>
            //{
            //    entity.HasKey(e => e.Provinceid)
            //        .HasName("wmsdb_tbs_province_pkey");

            //    entity.ToTable("wmsdb_tbs_province", "wh");

            //    entity.Property(e => e.Provinceid)
            //        .HasColumnName("provinceid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Provincename)
            //        .IsRequired()
            //        .HasColumnName("provincename")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Regioncode)
            //        .HasColumnName("regioncode")
            //        .HasMaxLength(30);
            //});

            //modelBuilder.Entity<WmsdbTbsRankaging>(entity =>
            //{
            //    entity.HasKey(e => e.Rankagingid)
            //        .HasName("wmsdb_tbs_rankaging_pkey");

            //    entity.ToTable("wmsdb_tbs_rankaging", "wh");

            //    entity.Property(e => e.Rankagingid)
            //        .HasColumnName("rankagingid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Rankagingfrom).HasColumnName("rankagingfrom");

            //    entity.Property(e => e.Rankagingname)
            //        .HasColumnName("rankagingname")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Rankagingto).HasColumnName("rankagingto");
            //});

            //modelBuilder.Entity<WmsdbTbsRegion>(entity =>
            //{
            //    entity.HasKey(e => e.Regioncode)
            //        .HasName("wmsdb_tbs_region_pkey");

            //    entity.ToTable("wmsdb_tbs_region", "wh");

            //    entity.Property(e => e.Regioncode)
            //        .HasColumnName("regioncode")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Countrycode)
            //        .HasColumnName("countrycode")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Regionname)
            //        .HasColumnName("regionname")
            //        .HasMaxLength(30);
            //});

            //modelBuilder.Entity<WmsdbTbsReportconfig>(entity =>
            //{
            //    entity.HasKey(e => e.Configid)
            //        .HasName("wmsdb_tbs_reportconfig_pkey");

            //    entity.ToTable("wmsdb_tbs_reportconfig", "wh");

            //    entity.Property(e => e.Configid)
            //        .HasColumnName("configid")
            //        .HasMaxLength(10)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Configvalue)
            //        .HasColumnName("configvalue")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<WmsdbTbsScantype>(entity =>
            //{
            //    entity.HasKey(e => e.Scantypeid)
            //        .HasName("wmsdb_tbs_scantype_pkey");

            //    entity.ToTable("wmsdb_tbs_scantype", "wh");

            //    entity.Property(e => e.Scantypeid)
            //        .HasColumnName("scantypeid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Scantypename)
            //        .HasColumnName("scantypename")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<WmsdbTbsStatus>(entity =>
            //{
            //    entity.HasKey(e => e.Statusid)
            //        .HasName("wmsdb_tbs_status_pkey");

            //    entity.ToTable("wmsdb_tbs_status", "wh");

            //    entity.Property(e => e.Statusid)
            //        .HasColumnName("statusid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Statusname)
            //        .IsRequired()
            //        .HasColumnName("statusname")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<WmsdbTbsSystemconfig>(entity =>
            //{
            //    entity.HasKey(e => e.Configid)
            //        .HasName("wmsdb_tbs_systemconfig_pkey");

            //    entity.ToTable("wmsdb_tbs_systemconfig", "wh");

            //    entity.Property(e => e.Configid)
            //        .HasColumnName("configid")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Configitem)
            //        .IsRequired()
            //        .HasColumnName("configitem")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Configvalue)
            //        .IsRequired()
            //        .HasColumnName("configvalue")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Deleteflag).HasColumnName("deleteflag");

            //    entity.Property(e => e.Description).HasColumnName("description");

            //    entity.Property(e => e.Issystem).HasColumnName("issystem");

            //    entity.Property(e => e.Orderrow).HasColumnName("orderrow");
            //});

            //modelBuilder.Entity<WmsdbTbsUnitconverttable>(entity =>
            //{
            //    entity.HasKey(e => new { e.Fromunitid, e.Tounitid })
            //        .HasName("wmsdb_tbs_unitconverttable_pkey");

            //    entity.ToTable("wmsdb_tbs_unitconverttable", "wh");

            //    entity.Property(e => e.Fromunitid).HasColumnName("fromunitid");

            //    entity.Property(e => e.Tounitid).HasColumnName("tounitid");

            //    entity.Property(e => e.Ratio)
            //        .HasColumnName("ratio")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<WmsdbTbtPacking>(entity =>
            //{
            //    entity.HasKey(e => new { e.Packingno, e.Shipmentnogroup, e.Shipmentno, e.Installment, e.Pickingno })
            //        .HasName("wmsdb_tbt_packing_pkey");

            //    entity.ToTable("wmsdb_tbt_packing", "wh");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Pickingno })
            //        .HasName("wh_wmsdb_tbt_packing_24");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Packingno, e.Packageid, e.Boxno })
            //        .HasName("wh_wmsdb_tbt_packing_22");

            //    entity.Property(e => e.Packingno)
            //        .HasColumnName("packingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Shipmentnogroup)
            //        .HasColumnName("shipmentnogroup")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Boxno).HasColumnName("boxno");

            //    entity.Property(e => e.Confirmgiflag).HasColumnName("confirmgiflag");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Grossweight)
            //        .HasColumnName("grossweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.M3)
            //        .HasColumnName("m3")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Packagecloseflag).HasColumnName("packagecloseflag");

            //    entity.Property(e => e.Packageid).HasColumnName("packageid");

            //    entity.Property(e => e.Packdate).HasColumnName("packdate");

            //    entity.Property(e => e.Packingline).HasColumnName("packingline");

            //    entity.Property(e => e.Packshippingmark)
            //        .HasColumnName("packshippingmark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Palletid)
            //        .HasColumnName("palletid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Qcpickby)
            //        .HasColumnName("qcpickby")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Qcpickdate)
            //        .HasColumnName("qcpickdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Qcpickqty)
            //        .HasColumnName("qcpickqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Shipqty).HasColumnName("shipqty");

            //    entity.Property(e => e.Sono)
            //        .HasColumnName("sono")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbtPackingd>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Packingno, e.Skubarcode, e.Lotno })
            //        .HasName("wmsdb_tbt_packingd_pkey");

            //    entity.ToTable("wmsdb_tbt_packingd", "wh");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Packingno)
            //        .HasColumnName("packingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Skubarcode)
            //        .HasColumnName("skubarcode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Controlvoidid).HasColumnName("controlvoidid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Notification)
            //        .HasColumnName("notification")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Packqty)
            //        .HasColumnName("packqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Qtyofinventoryunit).HasColumnName("qtyofinventoryunit");

            //    entity.Property(e => e.Qtyofsku)
            //        .HasColumnName("qtyofsku")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Unitofsku).HasColumnName("unitofsku");
            //});

            //modelBuilder.Entity<WmsdbTbtPackingvoid>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Packingno, e.Skubarcode, e.Lotno, e.Voidno })
            //        .HasName("wmsdb_tbt_packingvoid_pkey");

            //    entity.ToTable("wmsdb_tbt_packingvoid", "wh");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Packingno)
            //        .HasColumnName("packingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Skubarcode)
            //        .HasColumnName("skubarcode")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Voidno)
            //        .HasColumnName("voidno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Controlvoidid).HasColumnName("controlvoidid");

            //    entity.Property(e => e.Packingline).HasColumnName("packingline");
            //});

            //modelBuilder.Entity<WmsdbTbtPalletmapping>(entity =>
            //{
            //    entity.HasKey(e => e.Stickeruid)
            //        .HasName("wmsdb_tbt_palletmapping_pkey");

            //    entity.ToTable("wmsdb_tbt_palletmapping", "wh");

            //    entity.HasIndex(e => e.Palletid)
            //        .HasName("wh_wmsdb_tbt_palletmapping_9");

            //    entity.HasIndex(e => new { e.Stickeruid, e.Dcid })
            //        .HasName("wh_wmsdb_tbt_palletmapping_11");

            //    entity.Property(e => e.Stickeruid)
            //        .HasColumnName("stickeruid")
            //        .HasMaxLength(100)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Palletid)
            //        .IsRequired()
            //        .HasColumnName("palletid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Routeid).HasColumnName("routeid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<WmsdbTbtPickingdetail>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno })
            //        .HasName("wmsdb_tbt_pickingdetail_pkey");

            //    entity.ToTable("wmsdb_tbt_pickingdetail", "wh");

            //    entity.HasIndex(e => e.Lotno)
            //        .HasName("wh_wmsdb_tbt_pickingdetail_3");

            //    entity.HasIndex(e => e.Pickingno)
            //        .HasName("wh_wmsdb_tbt_pickingdetail_27");

            //    entity.HasIndex(e => e.Receivingno)
            //        .HasName("wh_wmsdb_tbt_pickingdetail_4");

            //    entity.HasIndex(e => new { e.Productid, e.Palletno })
            //        .HasName("wh_wmsdb_tbt_pickingdetail_36");

            //    entity.HasIndex(e => new { e.Productid, e.Assignqty, e.Serial })
            //        .HasName("wh_wmsdb_tbt_pickingdetail_2");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Pickingno })
            //        .HasName("wh_wmsdb_tbt_pickingdetail_47");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.AcctCd)
            //        .HasColumnName("acct_cd")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Assignqty)
            //        .HasColumnName("assignqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.CostDept)
            //        .HasColumnName("cost_dept")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerorder)
            //        .HasColumnName("customerorder")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Damageqty)
            //        .HasColumnName("damageqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Datasourceflag).HasColumnName("datasourceflag");

            //    entity.Property(e => e.Detailremark)
            //        .HasColumnName("detailremark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Dnlineno)
            //        .HasColumnName("dnlineno")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.Dnno)
            //        .HasColumnName("dnno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Flgtoas400).HasColumnName("flgtoas400");

            //    entity.Property(e => e.Goodqty)
            //        .HasColumnName("goodqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Inpackage)
            //        .HasColumnName("inpackage")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Kanbanqty).HasColumnName("kanbanqty");

            //    entity.Property(e => e.Keyimportref)
            //        .HasColumnName("keyimportref")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Loadaction)
            //        .HasColumnName("loadaction")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Loaddate)
            //        .HasColumnName("loaddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Loaduser)
            //        .HasColumnName("loaduser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Lostqty)
            //        .HasColumnName("lostqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.M3)
            //        .HasColumnName("m3")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Materialcode)
            //        .HasColumnName("materialcode")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Materialfreightgroup)
            //        .HasColumnName("materialfreightgroup")
            //        .HasMaxLength(8);

            //    entity.Property(e => e.Materialgrossweight)
            //        .HasColumnName("materialgrossweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Materialvolume)
            //        .HasColumnName("materialvolume")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Materialvolumeunit)
            //        .HasColumnName("materialvolumeunit")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Materialweightunit)
            //        .HasColumnName("materialweightunit")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Orderqty)
            //        .HasColumnName("orderqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Plannername)
            //        .HasColumnName("plannername")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Plant)
            //        .HasColumnName("plant")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Pono)
            //        .HasColumnName("pono")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Recinstallment).HasColumnName("recinstallment");

            //    entity.Property(e => e.Reclineno).HasColumnName("reclineno");

            //    entity.Property(e => e.Referenceno)
            //        .HasColumnName("referenceno")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Requirepalletflag).HasColumnName("requirepalletflag");

            //    entity.Property(e => e.Serial)
            //        .HasColumnName("serial")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shippingmark)
            //        .HasColumnName("shippingmark")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Shipqty)
            //        .HasColumnName("shipqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Soitem).HasColumnName("soitem");

            //    entity.Property(e => e.Sonumber)
            //        .HasColumnName("sonumber")
            //        .HasMaxLength(24);

            //    entity.Property(e => e.Tolerancegireason)
            //        .HasColumnName("tolerancegireason")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Totalgrossweight)
            //        .HasColumnName("totalgrossweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Totalnetweight)
            //        .HasColumnName("totalnetweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Totalvolume)
            //        .HasColumnName("totalvolume")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Typeofpackageid).HasColumnName("typeofpackageid");

            //    entity.Property(e => e.Unitofinpackage).HasColumnName("unitofinpackage");

            //    entity.Property(e => e.Unitoforderqty).HasColumnName("unitoforderqty");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Weight)
            //        .HasColumnName("weight")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<WmsdbTbtPickingdetailconfirmed>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Pickinglineseq, e.Locationid })
            //        .HasName("wmsdb_tbt_pickingdetailconfirmed_pkey");

            //    entity.ToTable("wmsdb_tbt_pickingdetailconfirmed", "wh");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Pickinglineseq).HasColumnName("pickinglineseq");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Confirmflag).HasColumnName("confirmflag");

            //    entity.Property(e => e.Lastupdateby)
            //        .HasColumnName("lastupdateby")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Lastupdatedate)
            //        .HasColumnName("lastupdatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Pickingqty)
            //        .HasColumnName("pickingqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Qcpickby)
            //        .HasColumnName("qcpickby")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Qcpickdate)
            //        .HasColumnName("qcpickdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Qcpickqty)
            //        .HasColumnName("qcpickqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Receiveseq).HasColumnName("receiveseq");

            //    entity.Property(e => e.Remainpack)
            //        .HasColumnName("remainpack")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Remainpackofinventoryunit)
            //        .HasColumnName("remainpackofinventoryunit")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Returnqty)
            //        .HasColumnName("returnqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Serial)
            //        .HasColumnName("serial")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Shipqty)
            //        .HasColumnName("shipqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stickeruid)
            //        .HasColumnName("stickeruid")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Stockactualqty)
            //        .HasColumnName("stockactualqty")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<WmsdbTbtPickingheader>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno })
            //        .HasName("wmsdb_tbt_pickingheader_pkey");

            //    entity.ToTable("wmsdb_tbt_pickingheader", "wh");

            //    entity.HasIndex(e => e.Customerid)
            //        .HasName("wh_wmsdb_tbt_pickingheader_26");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment })
            //        .HasName("wh_wmsdb_tbt_pickingheader_29");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Dcid, e.Controlpackid })
            //        .HasName("wh_wmsdb_tbt_pickingheader_27");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Agentseal)
            //        .HasColumnName("agentseal")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Cancelpickingflag).HasColumnName("cancelpickingflag");

            //    entity.Property(e => e.Completeinfoflag).HasColumnName("completeinfoflag");

            //    entity.Property(e => e.Controlpackid).HasColumnName("controlpackid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Doissueddate)
            //        .HasColumnName("doissueddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Generatediffdate)
            //        .HasColumnName("generatediffdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Inspectionseal)
            //        .HasColumnName("inspectionseal")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Isprebuildload).HasColumnName("isprebuildload");

            //    entity.Property(e => e.Numberofdetails).HasColumnName("numberofdetails");

            //    entity.Property(e => e.Palletqty).HasColumnName("palletqty");

            //    entity.Property(e => e.Pickingcompletedate)
            //        .HasColumnName("pickingcompletedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pickingdate)
            //        .HasColumnName("pickingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pickingissueddate)
            //        .HasColumnName("pickingissueddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shippingareaid).HasColumnName("shippingareaid");

            //    entity.Property(e => e.Shippingresultgenerated).HasColumnName("shippingresultgenerated");

            //    entity.Property(e => e.Sonumber)
            //        .HasColumnName("sonumber")
            //        .HasMaxLength(24);

            //    entity.Property(e => e.Sourcesystem)
            //        .HasColumnName("sourcesystem")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Stockoutcontrolflag).HasColumnName("stockoutcontrolflag");

            //    entity.Property(e => e.Transportationdate)
            //        .HasColumnName("transportationdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Vanningdate)
            //        .HasColumnName("vanningdate")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<WmsdbTbtReceivingconfirmed>(entity =>
            //{
            //    entity.HasKey(e => new { e.Receivingno, e.Installment, e.Lineno, e.Receiveseq })
            //        .HasName("wmsdb_tbt_receivingconfirmed_pkey");

            //    entity.ToTable("wmsdb_tbt_receivingconfirmed", "wh");

            //    entity.HasIndex(e => e.Receiveddate)
            //        .HasName("IDX_RCVCONFIRM_RECEIVEDDATE");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Receiveseq).HasColumnName("receiveseq");

            //    entity.Property(e => e.ActuallyReceiveddate)
            //        .HasColumnName("actually_receiveddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Expireddate).HasColumnName("expireddate");

            //    entity.Property(e => e.Invoiceno)
            //        .HasColumnName("invoiceno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Receiveddate)
            //        .HasColumnName("receiveddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Receiveqty)
            //        .HasColumnName("receiveqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Transitcompleteflag).HasColumnName("transitcompleteflag");
            //});

            //modelBuilder.Entity<WmsdbTbtReceivinginstructiondetail>(entity =>
            //{
            //    entity.HasKey(e => new { e.Receivingno, e.Installment, e.Lineno })
            //        .HasName("wmsdb_tbt_receivinginstructiondetail_pkey");

            //    entity.ToTable("wmsdb_tbt_receivinginstructiondetail", "wh");

            //    entity.HasIndex(e => new { e.Customerid, e.Invoiceno, e.Lotno })
            //        .HasName("wh_wmsdb_tbt_receivinginstructiondetail_2");

            //    entity.HasIndex(e => new { e.Customerid, e.Receivingno, e.Installment, e.Lineno, e.Productid })
            //        .HasName("wh_wmsdb_tbt_receivinginstructiondetail_33");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Actuallotno)
            //        .HasColumnName("actuallotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.ActuallyUpdatedate)
            //        .HasColumnName("actually_updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Actualproductconditionid).HasColumnName("actualproductconditionid");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Currencycode)
            //        .HasColumnName("currencycode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Datasourceflag).HasColumnName("datasourceflag");

            //    entity.Property(e => e.Detailremark)
            //        .HasColumnName("detailremark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Exchangerate)
            //        .HasColumnName("exchangerate")
            //        .HasColumnType("numeric(18,5)");

            //    entity.Property(e => e.Expireddate).HasColumnName("expireddate");

            //    entity.Property(e => e.Flgtoac)
            //        .HasColumnName("flgtoac")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Flgtoas400).HasColumnName("flgtoas400");

            //    entity.Property(e => e.Inpackage)
            //        .HasColumnName("inpackage")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Inpackageunitid).HasColumnName("inpackageunitid");

            //    entity.Property(e => e.Instructionqty)
            //        .HasColumnName("instructionqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Invoicedate)
            //        .HasColumnName("invoicedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Invoiceno)
            //        .HasColumnName("invoiceno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Keyimportref)
            //        .HasColumnName("keyimportref")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Netweight)
            //        .HasColumnName("netweight")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Palletnoref)
            //        .IsRequired()
            //        .HasColumnName("palletnoref")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Polineno)
            //        .HasColumnName("polineno")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.Pono)
            //        .HasColumnName("pono")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Price)
            //        .HasColumnName("price")
            //        .HasColumnType("numeric(18,5)");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("qty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Qtyunitid).HasColumnName("qtyunitid");

            //    entity.Property(e => e.Receiveqty)
            //        .HasColumnName("receiveqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Receivingresultgenerated).HasColumnName("receivingresultgenerated");

            //    entity.Property(e => e.Referenceno)
            //        .HasColumnName("referenceno")
            //        .HasMaxLength(15);

            //    entity.Property(e => e.Shippingnotificationno)
            //        .HasColumnName("shippingnotificationno")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Shippingnotificationnoline)
            //        .HasColumnName("shippingnotificationnoline")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.Tolerancegrreason)
            //        .HasColumnName("tolerancegrreason")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Typeofpackageid).HasColumnName("typeofpackageid");

            //    entity.Property(e => e.Unitvolume)
            //        .HasColumnName("unitvolume")
            //        .HasColumnType("numeric(19,5)");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbtReceivinginstructionheader>(entity =>
            //{
            //    entity.HasKey(e => new { e.Receivingno, e.Installment })
            //        .HasName("wmsdb_tbt_receivinginstructionheader_pkey");

            //    entity.ToTable("wmsdb_tbt_receivinginstructionheader", "wh");

            //    entity.HasIndex(e => new { e.Invoiceno, e.Haveshippingmark })
            //        .HasName("wh_wmsdb_tbt_receivinginstructionheader_33");

            //    entity.HasIndex(e => new { e.Dcid, e.Arrivaldate, e.PoNo })
            //        .HasName("wh_wmsdb_tbt_receivinginstructionheader_2");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.ActuallyUpdatedate)
            //        .HasColumnName("actually_updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Arrivaldate)
            //        .HasColumnName("arrivaldate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Cancelslipflag).HasColumnName("cancelslipflag");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Datasource).HasColumnName("datasource");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Districtid).HasColumnName("districtid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Docrefcreatedate)
            //        .HasColumnName("docrefcreatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Docrefexpiredate)
            //        .HasColumnName("docrefexpiredate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Docrefno)
            //        .HasColumnName("docrefno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Doctypecode)
            //        .HasColumnName("doctypecode")
            //        .HasMaxLength(10);

            //    entity.Property(e => e.Doctypeid).HasColumnName("doctypeid");

            //    entity.Property(e => e.Finaldestinationid).HasColumnName("finaldestinationid");

            //    entity.Property(e => e.Generatediffdate)
            //        .HasColumnName("generatediffdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Genxpgenerated).HasColumnName("genxpgenerated");

            //    entity.Property(e => e.Haveshippingmark).HasColumnName("haveshippingmark");

            //    entity.Property(e => e.Importgroupno)
            //        .HasColumnName("importgroupno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Invoiceno)
            //        .HasColumnName("invoiceno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Licenseplate)
            //        .HasColumnName("licenseplate")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

            //    entity.Property(e => e.Palletqty).HasColumnName("palletqty");

            //    entity.Property(e => e.PoNo)
            //        .HasColumnName("po_no")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Provinceid).HasColumnName("provinceid");

            //    entity.Property(e => e.Receivingresultgenerated).HasColumnName("receivingresultgenerated");

            //    entity.Property(e => e.Refserviceid).HasColumnName("refserviceid");

            //    entity.Property(e => e.Refshiptoid).HasColumnName("refshiptoid");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Routeid).HasColumnName("routeid");

            //    entity.Property(e => e.ShipmentnogroupRev)
            //        .HasColumnName("shipmentnogroup_rev")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Slipcompletedate)
            //        .HasColumnName("slipcompletedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Slipno)
            //        .HasColumnName("slipno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Supplierid).HasColumnName("supplierid");

            //    entity.Property(e => e.Transferdate).HasColumnName("transferdate");

            //    entity.Property(e => e.Transfertype).HasColumnName("transfertype");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<WmsdbTbtReceivingstatus>(entity =>
            //{
            //    entity.HasKey(e => new { e.Receivingno, e.Installment, e.Lineno })
            //        .HasName("wmsdb_tbt_receivingstatus_pkey");

            //    entity.ToTable("wmsdb_tbt_receivingstatus", "wh");

            //    entity.HasIndex(e => e.Receivingno)
            //        .HasName("wh_wmsdb_tbt_receivingstatus_12");

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.ActuallyReceivingdate)
            //        .HasColumnName("actually_receivingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.ActuallyTransitdate)
            //        .HasColumnName("actually_transitdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Canceldate)
            //        .HasColumnName("canceldate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Interfacereceiveddate)
            //        .HasColumnName("interfacereceiveddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Receivingdate)
            //        .HasColumnName("receivingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Receivingentrydate)
            //        .HasColumnName("receivingentrydate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Statusid).HasColumnName("statusid");

            //    entity.Property(e => e.Transitdate)
            //        .HasColumnName("transitdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Transitinstructionissueddate)
            //        .HasColumnName("transitinstructionissueddate")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<WmsdbTbtShippinginstruction>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment })
            //        .HasName("wmsdb_tbt_shippinginstruction_pkey");

            //    entity.ToTable("wmsdb_tbt_shippinginstruction", "wh");

            //    entity.HasIndex(e => e.Customerid)
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_52");

            //    entity.HasIndex(e => e.Refdnnumber)
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_53");

            //    entity.HasIndex(e => e.Shipcompletedate)
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_56");

            //    entity.HasIndex(e => e.Shipmentno)
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_54");

            //    entity.HasIndex(e => new { e.Shipmentnogroup, e.Tmsloadid })
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_55");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Shipmentnogroup })
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_51");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Eta, e.Shipmentnogroup })
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_45");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Invoiceno, e.Doctypeid, e.Haveshippingmark })
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_44");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Customerid, e.Shipmentnogroup, e.Doctypeid })
            //        .HasName("wh_wmsdb_tbt_shippinginstruction_33");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Agentowner)
            //        .HasColumnName("agentowner")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Bookingno)
            //        .HasColumnName("bookingno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Cutdate)
            //        .HasColumnName("cutdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Deliverytype)
            //        .HasColumnName("deliverytype")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Destinationlocationtypeid).HasColumnName("destinationlocationtypeid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Doctypeid).HasColumnName("doctypeid");

            //    entity.Property(e => e.Eta)
            //        .HasColumnName("eta")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Etd)
            //        .HasColumnName("etd")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Exportresultdate)
            //        .HasColumnName("exportresultdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Finaldestinationid).HasColumnName("finaldestinationid");

            //    entity.Property(e => e.Giconfirmdate)
            //        .HasColumnName("giconfirmdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Giconfirmuser)
            //        .HasColumnName("giconfirmuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Haveshippingmark).HasColumnName("haveshippingmark");

            //    entity.Property(e => e.Importgroupno)
            //        .HasColumnName("importgroupno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Invoiceno)
            //        .HasColumnName("invoiceno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Isaccepttendered).HasColumnName("isaccepttendered");

            //    entity.Property(e => e.Isexportresult).HasColumnName("isexportresult");

            //    entity.Property(e => e.Islastmile).HasColumnName("islastmile");

            //    entity.Property(e => e.Legid).HasColumnName("legid");

            //    entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

            //    entity.Property(e => e.Plannername)
            //        .HasColumnName("plannername")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Portofdischargeid).HasColumnName("portofdischargeid");

            //    entity.Property(e => e.Portofloadingid).HasColumnName("portofloadingid");

            //    entity.Property(e => e.Qcpickconfirmby)
            //        .HasColumnName("qcpickconfirmby")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Qcpickconfirmdate)
            //        .HasColumnName("qcpickconfirmdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Refdnnumber)
            //        .HasColumnName("refdnnumber")
            //        .HasMaxLength(26);

            //    entity.Property(e => e.Refinstallmentversion).HasColumnName("refinstallmentversion");

            //    entity.Property(e => e.Refshipmentversion)
            //        .HasColumnName("refshipmentversion")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Routeid).HasColumnName("routeid");

            //    entity.Property(e => e.Servicelevelid).HasColumnName("servicelevelid");

            //    entity.Property(e => e.Shipcompletedate)
            //        .HasColumnName("shipcompletedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shipcompleteflag).HasColumnName("shipcompleteflag");

            //    entity.Property(e => e.Shipmentgroupcreatedate)
            //        .HasColumnName("shipmentgroupcreatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shipmentmemo)
            //        .HasColumnName("shipmentmemo")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Shipmentnogroup)
            //        .HasColumnName("shipmentnogroup")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Shippingcustomerid).HasColumnName("shippingcustomerid");

            //    entity.Property(e => e.Shiptodestinationid).HasColumnName("shiptodestinationid");

            //    entity.Property(e => e.Sonumber)
            //        .HasColumnName("sonumber")
            //        .HasMaxLength(24);

            //    entity.Property(e => e.Tmsinterfaceid).HasColumnName("tmsinterfaceid");

            //    entity.Property(e => e.Tmsloadid)
            //        .HasColumnName("tmsloadid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Transferdate)
            //        .HasColumnName("transferdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Transfertype).HasColumnName("transfertype");

            //    entity.Property(e => e.Transportmodecode).HasColumnName("transportmodecode");

            //    entity.Property(e => e.Transportordertypeid).HasColumnName("transportordertypeid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Vesselname1)
            //        .HasColumnName("vesselname1")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Vesselname2)
            //        .HasColumnName("vesselname2")
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<WmsdbTbtShippingstatus>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Pickingno, e.Installment, e.Lineno })
            //        .HasName("wmsdb_tbt_shippingstatus_pkey");

            //    entity.ToTable("wmsdb_tbt_shippingstatus", "wh");

            //    entity.HasIndex(e => e.Pickingno)
            //        .HasName("wh_wmsdb_tbt_shippingstatus_15");

            //    entity.HasIndex(e => e.Statusid)
            //        .HasName("wh_wmsdb_tbt_shippingstatus_12");

            //    entity.HasIndex(e => new { e.Installment, e.Pickingno, e.Lineno })
            //        .HasName("wh_wmsdb_tbt_shippingstatus_13");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Statusid })
            //        .HasName("wh_wmsdb_tbt_shippingstatus_10");

            //    entity.HasIndex(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Shippingdate, e.Statusid })
            //        .HasName("wh_wmsdb_tbt_shippingstatus_14");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Canceldate)
            //        .HasColumnName("canceldate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Entrydate)
            //        .HasColumnName("entrydate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pcidriverissueddate)
            //        .HasColumnName("pcidriverissueddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pciwarehouseissueddate)
            //        .HasColumnName("pciwarehouseissueddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Pickingdate)
            //        .HasColumnName("pickingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Shippingdate)
            //        .HasColumnName("shippingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Statusid).HasColumnName("statusid");

            //    entity.Property(e => e.Stockcontroldate)
            //        .HasColumnName("stockcontroldate")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<WmsdbTbtStockbylocation>(entity =>
            //{
            //    entity.HasKey(e => new { e.Customerid, e.Dcid, e.Locationid, e.Productid, e.Productconditionid, e.Palletno, e.Lotno })
            //        .HasName("wmsdb_tbt_stockbylocation_pkey");

            //    entity.ToTable("wmsdb_tbt_stockbylocation", "wh");

            //    entity.HasIndex(e => new { e.Dcid, e.Locationid, e.Productid, e.Quantity })
            //        .HasName("wh_wmsdb_tbt_stockbylocation_11");

            //    entity.HasIndex(e => new { e.Customerid, e.Dcid, e.Locationid, e.Productid, e.Productconditionid, e.Palletno, e.Lotno, e.Quantity })
            //        .HasName("wh_wmsdb_tbt_stockbylocation_12");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Beginqty)
            //        .HasColumnName("beginqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Lastupdatesince)
            //        .HasColumnName("lastupdatesince")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Quantity)
            //        .HasColumnName("quantity")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<WmsdbTbtStockcountingdetail>(entity =>
            //{
            //    entity.HasKey(e => new { e.Docno, e.Lineno })
            //        .HasName("wmsdb_tbt_stockcountingdetail_pkey");

            //    entity.ToTable("wmsdb_tbt_stockcountingdetail", "wh");

            //    entity.Property(e => e.Docno)
            //        .HasColumnName("docno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Adjusteddate)
            //        .HasColumnName("adjusteddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Adjustedqty)
            //        .HasColumnName("adjustedqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Adjusteduser)
            //        .HasColumnName("adjusteduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Cancelleddate)
            //        .HasColumnName("cancelleddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Cancelleduser)
            //        .HasColumnName("cancelleduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Counteddate)
            //        .HasColumnName("counteddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Countedqty)
            //        .HasColumnName("countedqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Counteduser)
            //        .HasColumnName("counteduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Inventoryqty)
            //        .HasColumnName("inventoryqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Palletno)
            //        .IsRequired()
            //        .HasColumnName("palletno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Reasonofadjustment)
            //        .HasColumnName("reasonofadjustment")
            //        .HasMaxLength(500);

            //    entity.Property(e => e.Unitid).HasColumnName("unitid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            //});

            //modelBuilder.Entity<WmsdbTbtStockcountingheader>(entity =>
            //{
            //    entity.HasKey(e => e.Docno)
            //        .HasName("wmsdb_tbt_stockcountingheader_pkey");

            //    entity.ToTable("wmsdb_tbt_stockcountingheader", "wh");

            //    entity.Property(e => e.Docno)
            //        .HasColumnName("docno")
            //        .HasMaxLength(50)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Adjusteddate)
            //        .HasColumnName("adjusteddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Adjusteduser)
            //        .HasColumnName("adjusteduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Cancelleddate)
            //        .HasColumnName("cancelleddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Cancelleduser)
            //        .HasColumnName("cancelleduser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Checkmoveflag).HasColumnName("checkmoveflag");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .HasColumnName("createuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Plancountingdate)
            //        .HasColumnName("plancountingdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Remark)
            //        .HasColumnName("remark")
            //        .HasMaxLength(1000);

            //    entity.Property(e => e.Statusid).HasColumnName("statusid");

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            //});

            //modelBuilder.Entity<WmsdbTbtStockmovement>(entity =>
            //{
            //    entity.HasKey(e => e.Seq)
            //        .HasName("wmsdb_tbt_stockmovement_pkey");

            //    entity.ToTable("wmsdb_tbt_stockmovement", "wh");

            //    entity.HasIndex(e => new { e.Transactiondate, e.Customerid, e.Dcid, e.Productid, e.Productconditionid, e.Lotno, e.Action, e.Palletno })
            //        .HasName("wh_wmsdb_tbt_stockmovement_25");

            //    entity.HasIndex(e => new { e.Customerid, e.Dcid, e.Receiveseq, e.Productid, e.Productconditionid, e.Lotno, e.Stockactual, e.Recordcancel, e.Palletno })
            //        .HasName("wh_wmsdb_tbt_stockmovement_26");

            //    entity.Property(e => e.Seq)
            //        .HasColumnName("seq")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Action)
            //        .IsRequired()
            //        .HasColumnName("action")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.ActuallyTransactiondate)
            //        .HasColumnName("actually_transactiondate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Postflag).HasColumnName("postflag");

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Receiveseq).HasColumnName("receiveseq");

            //    entity.Property(e => e.Recordcancel).HasColumnName("recordcancel");

            //    entity.Property(e => e.Referenceslipno)
            //        .IsRequired()
            //        .HasColumnName("referenceslipno")
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Stockactual)
            //        .HasColumnName("stockactual")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockhold)
            //        .HasColumnName("stockhold")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockpicking)
            //        .HasColumnName("stockpicking")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockreceive)
            //        .HasColumnName("stockreceive")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stockshipping)
            //        .HasColumnName("stockshipping")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stocktransit)
            //        .HasColumnName("stocktransit")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Stocktransportation)
            //        .HasColumnName("stocktransportation")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Transactiondate)
            //        .HasColumnName("transactiondate")
            //        .HasColumnType("timestamp without time zone");
            //});

            //modelBuilder.Entity<WmsdbTbtSuggestpickinglocation>(entity =>
            //{
            //    entity.HasKey(e => new { e.Shipmentno, e.Installment, e.Pickingno, e.Lineno, e.Pickinglineseq })
            //        .HasName("wmsdb_tbt_suggestpickinglocation_pkey");

            //    entity.ToTable("wmsdb_tbt_suggestpickinglocation", "wh");

            //    entity.HasIndex(e => new { e.Ispicked, e.Stickeruid })
            //        .HasName("wh_wmsdb_tbt_suggestpickinglocation_16");

            //    entity.Property(e => e.Shipmentno)
            //        .HasColumnName("shipmentno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Pickingno)
            //        .HasColumnName("pickingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Pickinglineseq).HasColumnName("pickinglineseq");

            //    entity.Property(e => e.Fullpallet).HasColumnName("fullpallet");

            //    entity.Property(e => e.Ispicked).HasColumnName("ispicked");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Lot)
            //        .HasColumnName("lot")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Palletid)
            //        .HasColumnName("palletid")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.Pickingqty)
            //        .HasColumnName("pickingqty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Quantity)
            //        .HasColumnName("quantity")
            //        .HasColumnType("numeric(18,8)");

            //    entity.Property(e => e.Receiveseq).HasColumnName("receiveseq");

            //    entity.Property(e => e.Serial)
            //        .HasColumnName("serial")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Stickeruid)
            //        .HasColumnName("stickeruid")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Stockqty)
            //        .HasColumnName("stockqty")
            //        .HasColumnType("numeric(18,3)");
            //});

            //modelBuilder.Entity<WmsdbTbtTagmapping>(entity =>
            //{
            //    entity.HasKey(e => new { e.Stickeruid, e.Receivingno, e.Lineno, e.Docrefno, e.Lotno })
            //        .HasName("wmsdb_tbt_tagmapping_pkey");

            //    entity.ToTable("wmsdb_tbt_tagmapping", "wh");

            //    entity.HasIndex(e => e.Productid)
            //        .HasName("wh_wmsdb_tbt_tagmapping_26");

            //    entity.HasIndex(e => new { e.Receivingno, e.Qty })
            //        .HasName("wh_wmsdb_tbt_tagmapping_29");

            //    entity.HasIndex(e => new { e.Stickeruid, e.Dcid })
            //        .HasName("wh_wmsdb_tbt_tagmapping_36");

            //    entity.HasIndex(e => new { e.Dcid, e.Productid, e.Serial })
            //        .HasName("wh_wmsdb_tbt_tagmapping_32");

            //    entity.HasIndex(e => new { e.Stickeruid, e.Dcid, e.Productid, e.Qty, e.Doctype })
            //        .HasName("wh_wmsdb_tbt_tagmapping_37");

            //    entity.HasIndex(e => new { e.Dcid, e.Receivingno, e.Lineno, e.Productid, e.Qty, e.Locationid })
            //        .HasName("wh_wmsdb_tbt_tagmapping_31");

            //    entity.HasIndex(e => new { e.Dcid, e.Customerid, e.Recseq, e.Productid, e.Lotno, e.Productconditionid, e.Palletno, e.Doctype })
            //        .HasName("wh_wmsdb_tbt_tagmapping_35");

            //    entity.HasIndex(e => new { e.Stickeruid, e.Dcid, e.Customerid, e.Receivingno, e.Installment, e.Lineno, e.Recseq, e.Productid, e.Lotno, e.Qty, e.Productconditionid, e.Palletno, e.Locationid, e.Receiveddate, e.Expiredate, e.Mfgdate, e.PoNo, e.Boxplno, e.Serial })
            //        .HasName("wh_wmsdb_tbt_tagmapping_30");

            //    entity.Property(e => e.Stickeruid)
            //        .HasColumnName("stickeruid")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Receivingno)
            //        .HasColumnName("receivingno")
            //        .HasMaxLength(22);

            //    entity.Property(e => e.Lineno).HasColumnName("lineno");

            //    entity.Property(e => e.Docrefno)
            //        .HasColumnName("docrefno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Lotno)
            //        .HasColumnName("lotno")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Boxplno)
            //        .HasColumnName("boxplno")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Checkroutedate)
            //        .HasColumnName("checkroutedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Checkrouteflag).HasColumnName("checkrouteflag");

            //    entity.Property(e => e.Checkrouteuser)
            //        .HasColumnName("checkrouteuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnName("createdate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Createuser)
            //        .IsRequired()
            //        .HasColumnName("createuser")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Customerid).HasColumnName("customerid");

            //    entity.Property(e => e.Dcid).HasColumnName("dcid");

            //    entity.Property(e => e.DmsRepDtt)
            //        .HasColumnName("dms_rep_dtt")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Doctype).HasColumnName("doctype");

            //    entity.Property(e => e.Expiredate).HasColumnName("expiredate");

            //    entity.Property(e => e.Installment).HasColumnName("installment");

            //    entity.Property(e => e.Locationid).HasColumnName("locationid");

            //    entity.Property(e => e.Mfgdate).HasColumnName("mfgdate");

            //    entity.Property(e => e.Palletno)
            //        .HasColumnName("palletno")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.PoNo)
            //        .HasColumnName("po_no")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Productconditionid).HasColumnName("productconditionid");

            //    entity.Property(e => e.Productid).HasColumnName("productid");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("qty")
            //        .HasColumnType("numeric(18,3)");

            //    entity.Property(e => e.Receiveddate)
            //        .HasColumnName("receiveddate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Receivedunit).HasColumnName("receivedunit");

            //    entity.Property(e => e.Recseq).HasColumnName("recseq");

            //    entity.Property(e => e.Serial)
            //        .HasColumnName("serial")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Updatedate)
            //        .HasColumnName("updatedate")
            //        .HasColumnType("timestamp without time zone");

            //    entity.Property(e => e.Updateuser)
            //        .HasColumnName("updateuser")
            //        .HasMaxLength(50);
            //});
        }
    }
}
