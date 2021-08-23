using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Packaging;

namespace SCG.ARS.BOI.WEB.Repositories {
	public partial interface IReportRepository {

		List<SummaryPerformanceModel> GetSummaryPerformance();

		List<LineMessageModel> GetPKGLineMessage02();

		List<RPTPKG001DailyMonitorViewModel> RPTPKG001_DailyMonitorReport(string dateFromText, string dateToText, int round);

		List<RPTPKG002OverallFleetDomesticsViewModel> RPTPKG002_OverallFleetDomesticsReport(string dateFromText, string dateToText, int round);

		List<RPTPKG003CarrierPerformanceViewModel> RPTPKG003_CarrierPerformanceReport(string dateFromText, string dateToText, int round);

		List<RPTPKG004SwitchingModelViewModel> RPTPKG004_SwitchingModelReport(string dateFromText, string dateToText, int[] shiptoId);

		List<RPTPKG005MonitorTruckActiveViewModel> RPTPKG005_MonitorTruckActiveReport(SKICTruckRequestModel requestModel);

		List<RPTPKG006OrientBiddingViewModel> RPTPKG006_OrientBiddingReport(string dateFromText, string dateToText, string shipTo, string carrier);

		List<RPTPKG007ProjectSavingViewModel> RPTPKG007_ProjectSavingReport(string dateFromText, string dateToText, string custGroup);
		List<RPTPKG007ProjectSaving2ViewModel> RPTPKG007_ProjectSavingReport2(string dateFromText, string dateToText);

		List<RPTPKG008OrderCIPViewModel> RPTPKG008_OrderCIPReport(string dateFromText, string dateToText, string custGroup);

		Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetCarrierDropDownList();
		Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetFleetDropDownList();
		Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetTruckTypeDropDownList();
		Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetSubTruckTypeDropDownList(string[] truckType);
		Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetRoundDropDownList();
		Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetBackhaulShiptoDropDownList();
		Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetCIPShiptoDropDownList();
		DateTime RPTPKG_GetLastWorkingDate();
		RPGPKGLastRoundViewModel RPTPKG_GetLastWorkingRound();
		List<MiscDataSelectionModel> RPTPKG_GetBiddingCarrier(string shipTo, string carrier);
	}
}
