using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;

namespace SCG.ARS.BOI.WEB.Controllers {
    public partial class ReportController : Controller {
		[HttpPost]
		public JsonResult RPTPKG001_DailyMonitorReport(string dateFrom, string dateTo, int round) {
			var jsonResult = Json(new { data = _report.RPTPKG001_DailyMonitorReport(dateFrom, dateTo, round) });

			return jsonResult;
		}

		[HttpPost]
		public JsonResult RPTPKG002_OverallFleetDomesticsReport(string dateFrom, string dateTo, int round) {
			var jsonResult = Json(new { data = _report.RPTPKG002_OverallFleetDomesticsReport(dateFrom, dateTo, round) });

			return jsonResult;
		}

		[HttpPost]
        public JsonResult RPTPKG003_CarrierPerformanceReport(string dateFrom, string dateTo, int round) {
            var jsonResult = Json(new { data = _report.RPTPKG003_CarrierPerformanceReport(dateFrom, dateTo, round) });

            return jsonResult;
        }

		[HttpPost]
		public JsonResult RPTPKG004_SwitchingModelReport(string dateFrom, string dateTo, int[] shipToId) {
			var jsonResult = Json(new { data = _report.RPTPKG004_SwitchingModelReport(dateFrom, dateTo, shipToId) });

			return jsonResult;
		}

		[HttpPost]
        public JsonResult RPTPKG005_MonitorTruckActiveReport(SKICTruckRequestModel param) {
			var jsonResult = Json(new { data = _report.RPTPKG005_MonitorTruckActiveReport(param) });

			return jsonResult;
        }

		[HttpPost]
		public JsonResult RPTPKG006_OrientBiddingReport(string dateFrom, string dateTo, string shipTo, string carrier) {
			var tableData = _report.RPTPKG006_OrientBiddingReport(dateFrom, dateTo, shipTo, carrier);
			var biddingCarrier = _report.RPTPKG_GetBiddingCarrier(shipTo, carrier);
			var jsonResult = Json(new { data = tableData, carrier = biddingCarrier });

			return jsonResult;
		}

		[HttpPost]
        public JsonResult RPTPKG007_ProjectSavingReport(string dateFrom, string dateTo, string custGroup) {
			var rawData = _report.RPTPKG007_ProjectSavingReport(dateFrom, dateTo, custGroup);			

			var jsonResult = Json(new { data = rawData });

			return jsonResult;
        }

		[HttpPost]
		public JsonResult RPTPKG008_OrderCIPReport(string dateFrom, string dateTo, string custGroup) {
			var rawData = _report.RPTPKG008_OrderCIPReport(dateFrom, dateTo, custGroup);

			var shipTo = rawData.Select(o => o.ship_to).ToArray();
			var ranges = rawData.Select(o => o.ship_to_range).ToArray();

			var gridLineColor = Enumerable.Repeat("rgba(0, 0, 0, 0.1)", ranges.Length).ToArray(); // create array of grid line color

			var distinctRange = rawData.Select(o => o.ship_to_range).Distinct().ToArray();
			var countEachRange = new int[distinctRange.Length];
			var secondLabels = new string[ranges.Length];

			for(var (i, lastIndex) = (0, 0); i < distinctRange.Length; i++) {
				int count = ranges.Count(r => r == distinctRange[i]);

				secondLabels[lastIndex + (count - 1) / 2] = distinctRange[i];

				lastIndex += count;
				// not last range
				if (i < distinctRange.Length - 1) {
					gridLineColor[lastIndex] = "rgba(0, 0, 0, 1)";
				}
			}

			var orderCountSet1 = rawData.Select(o => o.order_count_range1).ToArray();
			var orderCountSet2 = rawData.Select(o => o.order_count_range2).ToArray();
			var orderCountSet3 = rawData.Select(o => o.order_count_range3).ToArray();
			var orderCountSet4 = rawData.Select(o => o.order_count_range4).ToArray();

			const string GreenColor = "rgba(0, 176, 80, 1)";
			const string BlueColor = "rgba(38, 155, 255, 1)";
			const string RedColor = "rgba(241, 99, 95, 1)";
			const string YellowColor = "rgba(254, 186, 71, 1)";

			var dataSetRange1 = new BarChartIntegerDataSet() {
				type = "bar",
				label = "ออกก่อน 10 โมง",
				data = orderCountSet1,
				backgroundColor = Enumerable.Repeat(BlueColor, rawData.Count).ToArray(), 
				borderColor = Enumerable.Repeat(BlueColor, rawData.Count).ToArray(), 
				borderWidth = 1,
				yAxisID = "left-axis",
				datalabels = new datalabelsModel {
					align = "top",
					anchor = "end",
					display = true
				}
			};

			var dataSetRange2 = new BarChartIntegerDataSet() {
				type = "bar",
				label = "ช่วงกลางวัน 10-14",
				data = orderCountSet2,
				backgroundColor = Enumerable.Repeat(GreenColor, rawData.Count).ToArray(), 
				borderColor = Enumerable.Repeat(GreenColor, rawData.Count).ToArray(), 
				borderWidth = 1,
				yAxisID = "left-axis",
				datalabels = new datalabelsModel {
					align = "top",
					anchor = "end",
					display = true
				}
			};

			var dataSetRange3 = new BarChartIntegerDataSet() {
				type = "bar",
				label = "ช่วงบ่าย 14-18",
				data = orderCountSet3,              
				backgroundColor = Enumerable.Repeat(YellowColor, rawData.Count).ToArray(), 
				borderColor = Enumerable.Repeat(YellowColor, rawData.Count).ToArray(),
				borderWidth = 1,
				yAxisID = "left-axis",
				datalabels = new datalabelsModel {
					align = "top",
					anchor = "end",
					display = true
				}
			};

			var dataSetRange4 = new BarChartIntegerDataSet() {
				type = "bar",
				label = "ช่วงหลัง 18:00 น.",
				data = orderCountSet4,
				backgroundColor = Enumerable.Repeat(RedColor, rawData.Count).ToArray(), 
				borderColor = Enumerable.Repeat(RedColor, rawData.Count).ToArray(), 
				borderWidth = 1,
				yAxisID = "left-axis",
				datalabels = new datalabelsModel {
					align = "top",
					anchor = "end",
					display = true
				}
			};

			var chartData = new BarChartIntegerData() {
				labels = shipTo,
				Multilabels = secondLabels,
				datasets = new BarChartIntegerDataSet[] { dataSetRange1, dataSetRange2, dataSetRange3, dataSetRange4 }
			};

			var jsonResult = Json(new { ChartData = chartData, TableData = rawData, ChartGridLine = gridLineColor });

			return jsonResult;
		}

		[HttpPost]
        public async Task<ActionResult> GetCarrierDropDownList() {
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try {
                (isSuccess, data) = await _report.RPTPKG_GetCarrierDropDownList();
                return Json(new { status = isSuccess, data = data, message = message });
            } catch (Exception ex) {
                message = ex.Message;
                return Json(null);
            }
        }

		[HttpPost]
		public async Task<ActionResult> GetFleetDropDownList() {
			var isSuccess = false;
			var message = string.Empty;
			var data = new List<MiscDataSelectionModel>();
			try {
				(isSuccess, data) = await _report.RPTPKG_GetFleetDropDownList();
				return Json(new { status = isSuccess, data = data, message = message });
			} catch (Exception ex) {
				message = ex.Message;
				return Json(null);
			}
		}


		[HttpPost]
		public async Task<ActionResult> GetTruckTypeDropDownList() {
			var isSuccess = false;
			var message = string.Empty;
			var data = new List<MiscDataSelectionModel>();
			try {
				(isSuccess, data) = await _report.RPTPKG_GetTruckTypeDropDownList();
				return Json(new { status = isSuccess, data = data, message = message });
			} catch (Exception ex) {
				message = ex.Message;
				return Json(null);
			}
		}


		[HttpPost]
		public async Task<ActionResult> GetSubTruckTypeDropDownList(string[] truckType) {
			var isSuccess = false;
			var message = string.Empty;
			var data = new List<MiscDataSelectionModel>();
			try {
				(isSuccess, data) = await _report.RPTPKG_GetSubTruckTypeDropDownList(truckType);
				return Json(new { status = isSuccess, data = data, message = message });
			} catch (Exception ex) {
				message = ex.Message;
				return Json(null);
			}
		}
		
		[HttpPost]
		public async Task<ActionResult> GetRoundDropDownList() {
			var isSuccess = false;
			var message = string.Empty;
			var data = new List<MiscDataSelectionModel>();
			try {
				(isSuccess, data) = await _report.RPTPKG_GetRoundDropDownList();
				return Json(new { status = isSuccess, data = data, message = message });
			} catch (Exception ex) {
				message = ex.Message;
				return Json(null);
			}
		}

		[HttpPost]
		public async Task<ActionResult> GetBackhaulShiptoDropDownList() {
			var isSuccess = false;
			var message = string.Empty;
			var data = new List<MiscDataSelectionModel>();
			try {
				(isSuccess, data) = await _report.RPTPKG_GetBackhaulShiptoDropDownList();
				return Json(new { status = isSuccess, data = data, message = message });
			} catch (Exception ex) {
				message = ex.Message;
				return Json(null);
			}
		}

		[HttpPost]
		public async Task<ActionResult> GetCIPShiptoDropDownList() {
			var isSuccess = false;
			var message = string.Empty;
			var data = new List<MiscDataSelectionModel>();
			try {
				(isSuccess, data) = await _report.RPTPKG_GetCIPShiptoDropDownList();
				return Json(new { status = isSuccess, data = data, message = message });
			} catch (Exception ex) {
				message = ex.Message;
				return Json(null);
			}
		}

		[HttpPost]
		public JsonResult GetPKGLastWorkingDate() {
			var rawData = _report.RPTPKG_GetLastWorkingDate();

			var jsonResult = Json(new { last_date = rawData });

			return jsonResult;
		}

		[HttpPost]
		public JsonResult GetPKGLastWorkingRound() {
			var rawData = _report.RPTPKG_GetLastWorkingRound();

			var jsonResult = Json(new { rawData.last_date, rawData.last_round });

			return jsonResult;
		}

	}
}