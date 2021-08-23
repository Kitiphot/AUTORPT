using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Packaging;

namespace SCG.ARS.BOI.WEB.Repositories {
	public partial class ReportRepository {
		public async Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetCarrierDropDownList() {
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try {
				using IDbConnection dbConnection = Connection;
				dbConnection.Open();
				var datatmp = dbConnection.Query<MiscDataSelectionModel>("select item_value as datavalue_key, item_text as datadisplay from pkg.get_dropdownlist_carrier()");
				data = datatmp.ToList();
				isSuccess = true;
			} catch (Exception ex) {
				// NLog: catch any exception and log it.
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
				} else {
					logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}

		public async Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetFleetDropDownList() {
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try {
				using IDbConnection dbConnection = Connection;
				dbConnection.Open();
				var datatmp = dbConnection.Query<MiscDataSelectionModel>("select item_value as datavalue_key, item_text as datadisplay from pkg.get_dropdownlist_fleet()");
				data = datatmp.ToList();
				isSuccess = true;
			} catch (Exception ex) {
				// NLog: catch any exception and log it.
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
				} else {
					logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}
		public async Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetTruckTypeDropDownList() {
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try {
				using IDbConnection dbConnection = Connection;
				dbConnection.Open();
				var datatmp = dbConnection.Query<MiscDataSelectionModel>("select item_value as datavalue_key, item_text as datadisplay from pkg.get_dropdownlist_trucktype()");
				data = datatmp.ToList();
				isSuccess = true;
			} catch (Exception ex) {
				// NLog: catch any exception and log it.
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
				} else {
					logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}
		public async Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetSubTruckTypeDropDownList(string[] truckType = null) {
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try {
				using IDbConnection dbConnection = Connection;
				dbConnection.Open();
				//string param;
				//if (truckType == null || truckType.Length == 0)
				//	param = "null";
				//else
				//	param = $"ARRAY[{ string.Join(',', truckType.Select(t => "'" + t + "'").ToArray()) }]";

				var datatmp = dbConnection.Query<MiscDataSelectionModel>(@$"
select item_value  as datavalue_key, item_text as datadisplay 
from pkg.get_dropdownlist_subtrucktype(@truck_type)",
						//param: new { truck_type = truckType ?? new string[] { } });
						param: new { truck_type = truckType ?? new string[0] });
				data = datatmp.ToList();
				isSuccess = true;
			} catch (Exception ex) {
				// NLog: catch any exception and log it.
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
				} else {
					logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}

		public async Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetRoundDropDownList() {
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try {
				using IDbConnection dbConnection = Connection;
				dbConnection.Open();
				var datatmp = dbConnection.Query<MiscDataSelectionModel>("select item_value as datavalue_key, item_text as datadisplay from pkg.get_dropdownlist_round()");
				data = datatmp.ToList();
				isSuccess = true;
			} catch (Exception ex) {
				// NLog: catch any exception and log it.
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
				} else {
					logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}

		public async Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetBackhaulShiptoDropDownList() {
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try {
				using IDbConnection dbConnection = Connection;
				dbConnection.Open(); 
				var datatmp = dbConnection.Query<MiscDataSelectionModel>("select item_value as datavalue_key, item_text as datadisplay from pkg.get_dropdownlist_backhaulshipto()");

				data = datatmp.ToList();
				isSuccess = true;
			} catch (Exception ex) {
				// NLog: catch any exception and log it.
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
				} else {
					logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}

		public async Task<(bool, List<MiscDataSelectionModel>)> RPTPKG_GetCIPShiptoDropDownList() {
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try {
				using IDbConnection dbConnection = Connection;
				dbConnection.Open();
				var datatmp = dbConnection.Query<MiscDataSelectionModel>("select item_value as datavalue_key, item_text as datadisplay from pkg.get_dropdownlist_CIPshipto()");

				data = datatmp.ToList();
				isSuccess = true;
			} catch (Exception ex) {
				// NLog: catch any exception and log it.
				if (ex.InnerException != null) {
					logger.Error(ex.InnerException, $"Exception on MaintainAccountCodeTransaction");
				} else {
					logger.Error(ex, $"Exception on MaintainAccountCodeTransaction");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}

		public List<SummaryPerformanceModel> GetSummaryPerformance() {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();
			var result = dbConnection.Query<SummaryPerformanceModel>($"SELECT * FROM pkg.line_message_01();").ToList();
			return result;
		}

		public List<LineMessageModel> GetPKGLineMessage02() {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();
			var result = dbConnection.Query<LineMessageModel>($"SELECT * FROM pkg.line_message_02();").ToList();
			return result;
		}

		public List<RPTPKG001DailyMonitorViewModel> RPTPKG001_DailyMonitorReport(string dateFromText, string dateToText, int round) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();
			var data = dbConnection.Query<RPTPKG001DailyMonitorViewModel>($@"
SELECT *
FROM pkg.getreport01('{dateFromText}', '{dateToText}', {round})"
				);
			return data.ToList();
		}

		public List<RPTPKG002OverallFleetDomesticsViewModel> RPTPKG002_OverallFleetDomesticsReport(string dateFromText, string dateToText, int round) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();
			var data = dbConnection.Query<RPTPKG002OverallFleetDomesticsViewModel>($@"
SELECT fleet, truck_type, truck_register, truck_commit, 
		pending_count,
		order_count,
		book_count, 
		accept_count,
		truck_wait
from pkg.getreport02('{dateFromText}', '{dateToText}', {round})"
				);
			return data.ToList();
		}

		public List<RPTPKG003CarrierPerformanceViewModel> RPTPKG003_CarrierPerformanceReport(string dateFromText, string dateToText, int round) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();
			var data = dbConnection.Query<RPTPKG003CarrierPerformanceViewModel>($@"
 select 
    fleet, truck_type, carrier_code, carrier_name, 
    truck_register, truck_commit, 
    book_count, book_percentage, accept_count, accept_percentage
from pkg.getreport03('{dateFromText}', '{dateToText}', {round})"
				);
			return data.ToList();
		}

		public List<RPTPKG004SwitchingModelViewModel> RPTPKG004_SwitchingModelReport(string dateFromText, string dateToText, int[] shipToId) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();
			var data = dbConnection.Query<RPTPKG004SwitchingModelViewModel>($@"
select 
	carrier_id, carrier_name, province, order_count, backhaul_count, remain_truck, sub_truck_type
from pkg.getreport04(@shipto_id, '{dateFromText}', '{dateToText}')",
				param: new {
					shipto_id = shipToId
			});
			return data.ToList();
		}

		public List<RPTPKG005MonitorTruckActiveViewModel> RPTPKG005_MonitorTruckActiveReport(SKICTruckRequestModel requestModel) {
			
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();
			var data = dbConnection.Query<RPTPKG005MonitorTruckActiveViewModel>(@$"
select 
	fleet, carrier, truck_type, sub_truck_type, truck_license, driver_name,
	result_day1, result_day2, result_day3, result_day4, result_day5,
	result_day6, result_day7, result_day8, result_day9, result_day10,
	result_day11, result_day12, result_day13, result_day14, result_day15,
	result_day16, result_day17, result_day18, result_day19, result_day20, 
	result_day21, result_day22, result_day23, result_day24, result_day25,
	result_day26, result_day27, result_day28, result_day29, result_day30,
	result_day31,
	result_book,
	result_accept,
	result_non_accept,
	result_not_book
	,
	is_working_day1, is_working_day2, is_working_day3, is_working_day4, is_working_day5,
	is_working_day6, is_working_day7, is_working_day8, is_working_day9, is_working_day10,
	is_working_day11, is_working_day12, is_working_day13, is_working_day14, is_working_day15,
	is_working_day16, is_working_day17, is_working_day18, is_working_day19, is_working_day20, 
	is_working_day21, is_working_day22, is_working_day23, is_working_day24, is_working_day25,
	is_working_day26, is_working_day27, is_working_day28, is_working_day29, is_working_day30,
	is_working_day31

from pkg.getreport05(@month, @year, @carrierCode, @fleet, @truckType, @subTruckType)",
				param: new {
					requestModel.Month,
					requestModel.Year,
					requestModel.CarrierCode,
					requestModel.Fleet,
					requestModel.TruckType,
					requestModel.SubTruckType
				},
				commandTimeout: 3000);
			return data.ToList();
		}

		public List<RPTPKG006OrientBiddingViewModel> RPTPKG006_OrientBiddingReport(string dateFromText, string dateToText, string shipTo, string carrier) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();

			var data = dbConnection.Query<RPTPKG006OrientBiddingViewModel>($@"
select *
    --line_no, group_no, route_name, total_count, spk_count, lac_count, other_count
from pkg.getreport06('{dateFromText}', '{dateToText}', '{shipTo}', '{carrier}')"
				);
			return data.ToList();
		}

		public List<RPTPKG007ProjectSavingViewModel> RPTPKG007_ProjectSavingReport(string dateFromText, string dateToText, string custGroup) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();

			var data = dbConnection.Query<RPTPKG007ProjectSavingViewModel>($@"
select 
    shipto_seq, shipto_name, carrier_seq, carrier_name, 
	order_count, weight, 
	order_percent,
	bt_saving
from pkg.getreport07('{dateFromText}', '{dateToText}', '{custGroup}')"
				);
			return data.ToList();
		}

		public List<RPTPKG007ProjectSaving2ViewModel> RPTPKG007_ProjectSavingReport2(string dateFromText, string dateToText) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();

			var data = dbConnection.Query<RPTPKG007ProjectSaving2ViewModel>($@"
select *
from pkg.getreport07('{dateFromText}', '{dateToText}')"
				);
			return data.ToList();
		}

		public List<RPTPKG008OrderCIPViewModel> RPTPKG008_OrderCIPReport(string dateFromText, string dateToText, string custGroup) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();

			var data = dbConnection.Query<RPTPKG008OrderCIPViewModel>($@"
select 
    *
from pkg.getreport08('{dateFromText}', '{dateToText}', '{custGroup}')"
				);
			return data.ToList();
		}

		public DateTime RPTPKG_GetLastWorkingDate() {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();

			var data = dbConnection.QueryFirstOrDefault<RPGPKGLastRoundViewModel>($@"select last_date from pkg.get_last_working_date();");
			return data.last_date?? DateTime.Today.AddDays(-1);
		}

		public RPGPKGLastRoundViewModel RPTPKG_GetLastWorkingRound() {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();

			var data = dbConnection.QueryFirstOrDefault<RPGPKGLastRoundViewModel>($@"select last_date, last_round from pkg.get_last_working_round();");
			return data;
		}

		public List<MiscDataSelectionModel> RPTPKG_GetBiddingCarrier(string shipTo, string carrier) {
			using IDbConnection dbConnection = Connection;
			dbConnection.Open();

			var data = dbConnection.Query<MiscDataSelectionModel>($@"select carrier_code as datavalue_key, carrier_name as datadisplay from pkg.get_bidding_carrier('{shipTo}', '{carrier}');");
			return data.ToList();
		}
	}
}
