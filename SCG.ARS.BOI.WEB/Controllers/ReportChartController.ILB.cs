using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLog;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.ILB;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public partial class ReportChartController : Controller
    {
        static NLog.Logger logger = LogManager.GetCurrentClassLogger();

        [HttpPost]
        public JsonResult RPTILB010_Summary_Status(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.ILB010_Summary_Status(request), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB010_Summary_Status", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }

        }

        #region ILB008
        [HttpPost]
		public JsonResult ILB008_CYDate_Chart(ILBRequestModel request) {
			try {
				List<RPTILB_export_monthy_carrier> rawdata = _report.ILB008_CYDate_Chart(request);

				var formattedData = ILB008_Chart_FormatData(rawdata);
				var jsonResult = Json(new { data = formattedData, success = true });

				return jsonResult;
			} catch (Exception ex) {
				logger.Error(ex, "ILB008_Chart_LoadDate", Newtonsoft.Json.JsonConvert.SerializeObject(request));
				return Json(new { data = ex.Message, success = false });
			}
		}

		[HttpPost]
		public JsonResult ILB008_ReturnDate_Chart(ILBRequestModel request) {
			try {
				List<RPTILB_export_monthy_carrier> rawdata = _report.ILB008_ReturnDate_Chart(request);

				var formattedData = ILB008_Chart_FormatData(rawdata);
				var jsonResult = Json(new { data = formattedData, success = true });

				return jsonResult;
			} catch (Exception ex) {
				logger.Error(ex, "ILB008_Chart_ReturnDate", Newtonsoft.Json.JsonConvert.SerializeObject(request));
				return Json(new { data = ex.Message, success = false });
			}
		}

		private BarChartIntegerData ILB008_Chart_FormatData(List<RPTILB_export_monthy_carrier> rawdata) {
			var lsDate = rawdata.Select(o => o.booking_date.ToString("dd-MM-yyyy")).ToArray();
			var lsAllTotal = rawdata.Select(o => o.total).ToArray();
			var lsKpiPlus = rawdata.Select(o => o.kpi_plus).ToArray();
			var lsKpiMinus = rawdata.Select(o => o.kpi_minus).ToArray();
			var lsbgKPIPlus = Enumerable.Repeat("rgba(50, 168, 82, 0.9)", lsDate.Length);
			var lsbgKPIMinus = Enumerable.Repeat("rgba(255, 84, 84, 0.9)", lsDate.Length);
			var lsbgAllTotal = Enumerable.Repeat("rgba(52, 140, 235, 0.9)", lsDate.Length);
			//List<double> valueTH = new List<double>();
			//foreach (string number in lsDate)
			//{
			//    valueTH.Add(10000);
			//    lsbgKPIPlus.Add("rgba(50, 168, 82,0.9)");
			//    lsbgKPIMinus.Add("rgba(252, 186, 3,0.9)");
			//    lsbgAllTotal.Add("rgba(52, 140, 235,0.9)");
			//}

			//Mock the data
			BarChartIntegerDataSet KPIPlus = new BarChartIntegerDataSet() {
				type = "bar",
				label = "On time",
				data = lsKpiPlus, // 10 20 30 40 < with 
				backgroundColor = lsbgKPIPlus.ToArray(),
				borderColor = lsbgKPIPlus.ToArray(),
				borderWidth = 1
			};

			BarChartIntegerDataSet KPIMinus = new BarChartIntegerDataSet() {
				type = "bar",
				label = "Delay",
				data = lsKpiMinus, // 10 20 30 40 < with 
				backgroundColor = lsbgKPIMinus.ToArray(),
				borderColor = lsbgKPIMinus.ToArray(),
				borderWidth = 2
			};

			BarChartIntegerDataSet AllTotal = new BarChartIntegerDataSet() {
				type = "line",
				label = "Total confirm",
				data = lsAllTotal, // 10 20 30 40 < with 
				backgroundColor = lsbgAllTotal.ToArray(),
				borderColor = lsbgAllTotal.ToArray(),
				borderWidth = 1
			};

			BarChartIntegerData data = new BarChartIntegerData() {
				labels = lsDate,
				datasets = new BarChartIntegerDataSet[] { KPIPlus, KPIMinus, AllTotal }
			};

			return data;
		}

		[HttpPost]
		public JsonResult RPTILB008_Summary_Status(ILBRequestModel request) {
			try {
				var jsonResult = Json(new { data = _report.ILB008_Summary_Status(request), success = true });
				return jsonResult;
			} catch (Exception ex) {
				logger.Error(ex, "RPTILB008_Summary_Status", Newtonsoft.Json.JsonConvert.SerializeObject(request));
				return Json(new { data = ex.Message, success = false });
			}

		}
		#endregion

		#region ILB007
		public JsonResult ILB007_Summary_Shpmnt_Chart(ILBRequestModel request)
        {
            try
            {
                List<RPTILB07_Summary_Shpmnt_Chart> rawdata = _report.ILB007_Summary_Chart(request);
                List<string> lsDate = rawdata.Select(o => o.eta_date.ToString("dd-MM-yyyy")).ToList();
                List<int> lsSeaShipment = rawdata.Select(o => o.sea_shipment).ToList();
                List<int> lsAirShipment = rawdata.Select(o => o.air_shipment).ToList();

                List<double> valueTH = new List<double>();

                List<string> lsbgcolorQty = new List<string>();
                List<string> lsbdcolorQty = new List<string>();
                List<string> lsbgcolorQty2 = new List<string>();
                List<string> lsbdcolorQty2 = new List<string>();

                foreach (string number in lsDate)
                {
                    valueTH.Add(10000);
                    lsbgcolorQty.Add("rgba(12, 202, 142,0.8)");
                    lsbdcolorQty.Add("rgba(12, 202, 142,0.8)");
                    lsbgcolorQty2.Add("rgba(38, 154, 255, 0.8)");
                    lsbdcolorQty2.Add("rgba(38, 154, 255, 0.8)");
                }
          
                BarChartIntegerDataSet datasetSeaShipment = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Sea Freight ",
                    data = lsSeaShipment.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgcolorQty.ToArray(),
                    borderColor = lsbgcolorQty.ToArray(),
                    borderWidth = 1,
                    datalabels = new datalabelsModel
                    {
                        anchor = "end",
                        align = "end",
                        display = true
                    }
                };                
                BarChartIntegerDataSet datasetAirShipment = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Air Freight",
                    data = lsAirShipment.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgcolorQty2.ToArray(),
                    borderColor = lsbgcolorQty2.ToArray(),
                    borderWidth = 1,
                    datalabels = new datalabelsModel
                    {
                        anchor = "end",
                        align = "end",
                        display = true
                    }
                };
                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { datasetAirShipment, datasetSeaShipment }
                };

                var jsonResult = Json(new { data, success = true });

                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB005_Summary_Status", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }

        public JsonResult RPTILB007_Summary_Status(ILBRequestModel request)
        {
            var jsonResult = Json(new { data = _report.ILB007_Summary_Status(request) });

            return jsonResult;
        }

        #endregion

        #region ILB006
        [HttpPost]
        public JsonResult ILB006_Summary_Chart(ILBRequestModel request)
        {

			try {
				List<RPTILB_Haulage_Chart> rawdata = _report.ILB006_Summary_Chart(request);
				var lsDate = rawdata.Select(o => o.cy_date.ToString("dd-MM-yyyy")).ToArray();

				var not_tendered = rawdata.Select(o => o.not_tendered).ToArray();
				var tendered = rawdata.Select(o => o.tendered).ToArray();

				const string GreenColor = "rgba(0, 156, 138, 0.9)";
				const string RedColor = "rgba(241, 99, 95, 0.9)";

				BarChartIntegerDataSet tenderedDataSet = new BarChartIntegerDataSet() {
					type = "bar",
					label = "Not Tendered",
					data = not_tendered,
					backgroundColor = Enumerable.Repeat(RedColor, rawdata.Count).ToArray(),
					borderColor = Enumerable.Repeat(RedColor, rawdata.Count).ToArray(),
					borderWidth = 1
				};

				BarChartIntegerDataSet notTenderedDataSet = new BarChartIntegerDataSet() {
					type = "bar",
					label = "Tendered",
					data = tendered,
					backgroundColor = Enumerable.Repeat(GreenColor, rawdata.Count).ToArray(),
					borderColor = Enumerable.Repeat(GreenColor, rawdata.Count).ToArray(),
					borderWidth = 1
				};

				BarChartIntegerData data = new BarChartIntegerData() {
					labels = lsDate.ToArray(),
					datasets = new BarChartIntegerDataSet[] { tenderedDataSet, notTenderedDataSet }
				};


                var jsonResult = Json(new { data, success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB006_Summary_Status", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
		#endregion

		#region ILB005
		[HttpPost]
		public JsonResult ILB005_CYDate_Chart(ILBRequestModel request) {
			try {
				List<RPTILB_export_monthy_carrier> rawdata = _report.ILB005_CYDate_Chart(request);

				var formattedData = ILB005_Chart_FormatData(rawdata);
				var jsonResult = Json(new { data = formattedData, success = true });

				return jsonResult;
			} catch (Exception ex) {
				logger.Error(ex, "ILB005_Chart_LoadDate", Newtonsoft.Json.JsonConvert.SerializeObject(request));
				return Json(new { data = ex.Message, success = false });
			}
		}

		[HttpPost]
		public JsonResult ILB005_ReturnDate_Chart(ILBRequestModel request) {
			try {
				List<RPTILB_export_monthy_carrier> rawdata = _report.ILB005_ReturnDate_Chart(request);

				var formattedData = ILB005_Chart_FormatData(rawdata);
				var jsonResult = Json(new { data = formattedData, success = true });

				return jsonResult;
			} catch (Exception ex) {
				logger.Error(ex, "ILB005_Chart_ReturnDate", Newtonsoft.Json.JsonConvert.SerializeObject(request));
				return Json(new { data = ex.Message, success = false });
			}
		}

		private BarChartIntegerData ILB005_Chart_FormatData(List<RPTILB_export_monthy_carrier> rawdata) {
			var lsDate = rawdata.Select(o => o.booking_date.ToString("dd-MM-yyyy")).ToArray();
			var lsAllTotal = rawdata.Select(o => o.total).ToArray();
			var lsKpiPlus = rawdata.Select(o => o.kpi_plus).ToArray();
			var lsKpiMinus = rawdata.Select(o => o.kpi_minus).ToArray();
			var lsbgKPIPlus = Enumerable.Repeat("rgba(50, 168, 82,0.9)", lsDate.Length);
			var lsbgKPIMinus = Enumerable.Repeat("rgba(252, 186, 3,0.9)", lsDate.Length);
			var lsbgAllTotal = Enumerable.Repeat("rgba(52, 140, 235,0.9)", lsDate.Length);
			//List<double> valueTH = new List<double>();
			//foreach (string number in lsDate)
			//{
			//    valueTH.Add(10000);
			//    lsbgKPIPlus.Add("rgba(50, 168, 82,0.9)");
			//    lsbgKPIMinus.Add("rgba(252, 186, 3,0.9)");
			//    lsbgAllTotal.Add("rgba(52, 140, 235,0.9)");
			//}

			//Mock the data
			BarChartIntegerDataSet KPIPlus = new BarChartIntegerDataSet() {
				type = "bar",
				label = "Pass",
				data = lsKpiPlus, // 10 20 30 40 < with 
				backgroundColor = lsbgKPIPlus.ToArray(),
				borderColor = lsbgKPIPlus.ToArray(),
				borderWidth = 1
			};

			BarChartIntegerDataSet KPIMinus = new BarChartIntegerDataSet() {
				type = "bar",
				label = "Fail",
				data = lsKpiMinus, // 10 20 30 40 < with 
				backgroundColor = lsbgKPIMinus.ToArray(),
				borderColor = lsbgKPIMinus.ToArray(),
				borderWidth = 2
			};

			BarChartIntegerDataSet AllTotal = new BarChartIntegerDataSet() {
				type = "line",
				label = "Total confirm",
				data = lsAllTotal, // 10 20 30 40 < with 
				backgroundColor = lsbgAllTotal.ToArray(),
				borderColor = lsbgAllTotal.ToArray(),
				borderWidth = 1
			};

			BarChartIntegerData data = new BarChartIntegerData() {
				labels = lsDate,
				datasets = new BarChartIntegerDataSet[] { KPIPlus, KPIMinus, AllTotal }
			};

			return data;
		}

		[HttpPost]
        public JsonResult RPTILB005_Summary_Status(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.ILB005_Summary_Status(request), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB005_Summary_Status", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }

        }
        #endregion

        #region ILB004
        [HttpPost]
        public JsonResult ILB004_Summary_Mothly_Chart(ILBRequestModel request)
        {
            try
            {
                List<RPTILB_monthy_shpmnt_kpi> rawdata = _report.ILB004_Summary_Chart(request);

                var jsonResult = Json(new
                {
                    data1 = ILB004_ShipSea_data(rawdata),
                    data2 = ILB004_ShipAir_data(rawdata),
                    data3 = ILB004_ClearSea_data(rawdata),
                    data4 = ILB004_ClearAir_data(rawdata),
                    success = true
                });

                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ILB004_Summary_Mothly_Chart", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public BarChartIntegerData ILB004_ShipSea_data(List<RPTILB_monthy_shpmnt_kpi> rawdata)
        {
            List<string> lsDate = rawdata.Select(o => o.delivery_date.ToString("dd-MM-yyyy")).ToList();
            List<int> lsShipSeaDelay = rawdata.Select(o => o.receive_ship_sea_delay).ToList();
            List<int> lsShipSeaOntime = rawdata.Select(o => o.receive_ship_sea_ontime).ToList();

            List<string> lsbgGood = new List<string>();
            List<string> lsbgWarn = new List<string>();
            List<string> lsbgBad = new List<string>();

            foreach (string number in lsDate)
            {
                lsbgGood.Add("rgba(0, 156, 138,0.9)");
                lsbgWarn.Add("rgba(252, 186, 3,0.9)");
                lsbgBad.Add("rgba(241, 99, 95, 0.9)");
            }

            BarChartIntegerDataSet datasetShipSeaOntime = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Pass",
                data = lsShipSeaOntime.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgGood.ToArray(),
                borderColor = lsbgGood.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet datasetShipSeaDelay = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Fail",
                data = lsShipSeaDelay.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgBad.ToArray(),
                borderColor = lsbgBad.ToArray(),
                borderWidth = 1
            };


            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetShipSeaOntime, datasetShipSeaDelay }
            };

            return data;
        }

        [HttpPost]
        public BarChartIntegerData ILB004_ShipAir_data(List<RPTILB_monthy_shpmnt_kpi> rawdata)
        {
            List<string> lsDate = rawdata.Select(o => o.delivery_date.ToString("dd-MM-yyyy")).ToList();
            List<int> lsShipAirDelay = rawdata.Select(o => o.receive_ship_air_delay).ToList();
            List<int> lsShipAirOntime = rawdata.Select(o => o.receive_ship_air_ontime).ToList();

            List<string> lsbgGood = new List<string>();
            List<string> lsbgWarn = new List<string>();
            List<string> lsbgBad = new List<string>();

            foreach (string number in lsDate)
            {
                lsbgGood.Add("rgba(0, 156, 138,0.9)");
                lsbgWarn.Add("rgba(252, 186, 3,0.9)");
                lsbgBad.Add("rgba(241, 99, 95, 0.9)");
            }

            BarChartIntegerDataSet datasetShipAirOntime = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Pass",
                data = lsShipAirOntime.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgGood.ToArray(),
                borderColor = lsbgGood.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet datasetShipAirDelay = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Fail",
                data = lsShipAirDelay.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgBad.ToArray(),
                borderColor = lsbgBad.ToArray(),
                borderWidth = 1
            };


            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetShipAirOntime, datasetShipAirDelay }
            };

            return data;
        }

        [HttpPost]
        public BarChartIntegerData ILB004_ClearSea_data(List<RPTILB_monthy_shpmnt_kpi> rawdata)
        {
            List<string> lsDate = rawdata.Select(o => o.delivery_date.ToString("dd-MM-yyyy")).ToList();

            List<int> lsClearSeaDelay = rawdata.Select(o => o.custom_clear_sea_delay).ToList();
            List<int> lsClearSeaOntime = rawdata.Select(o => o.custom_clear_sea_ontime).ToList();

            List<string> lsbgGood = new List<string>();
            List<string> lsbgWarn = new List<string>();
            List<string> lsbgBad = new List<string>();

            foreach (string number in lsDate)
            {
                lsbgGood.Add("rgba(0, 156, 138,0.9)");
                lsbgWarn.Add("rgba(252, 186, 3,0.9)");
                lsbgBad.Add("rgba(241, 99, 95, 0.9)");
            }

            BarChartIntegerDataSet datasetClearSeaOntime = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Pass",
                data = lsClearSeaOntime.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgGood.ToArray(),
                borderColor = lsbgGood.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet datasetClearSeaDelay = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Fail",
                data = lsClearSeaDelay.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgBad.ToArray(),
                borderColor = lsbgBad.ToArray(),
                borderWidth = 1
            };


            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetClearSeaOntime, datasetClearSeaDelay }
            };

            return data;
        }

        [HttpPost]
        public BarChartIntegerData ILB004_ClearAir_data(List<RPTILB_monthy_shpmnt_kpi> rawdata)
        {
            List<string> lsDate = rawdata.Select(o => o.delivery_date.ToString("dd-MM-yyyy")).ToList();
            List<int> lsClearAirDelay = rawdata.Select(o => o.custom_clear_air_delay).ToList();
            List<int> lsClearAirOntime = rawdata.Select(o => o.custom_clear_air_ontime).ToList();

            List<string> lsbgGood = new List<string>();
            List<string> lsbgWarn = new List<string>();
            List<string> lsbgBad = new List<string>();

            foreach (string number in lsDate)
            {
                lsbgGood.Add("rgba(0, 156, 138,0.9)");
                lsbgWarn.Add("rgba(252, 186, 3,0.9)");
                lsbgBad.Add("rgba(241, 99, 95, 0.9)");
            }

            BarChartIntegerDataSet datasetClearAirOntime = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Pass",
                data = lsClearAirOntime.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgGood.ToArray(),
                borderColor = lsbgGood.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet datasetClearAirDelay = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Fail",
                data = lsClearAirDelay.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgBad.ToArray(),
                borderColor = lsbgBad.ToArray(),
                borderWidth = 1
            };


            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetClearAirOntime, datasetClearAirDelay }
            };

            return data;
        }

        [HttpPost]
        public JsonResult RPTILB004_Summary_Status(ILBRequestModel request)
        {
            var jsonResult = Json(new { data = _report.ILB004_Summary_Status(request) });

            return jsonResult;
        }
        #endregion


        #region ILB003
        [HttpPost]
        public JsonResult ILB003_Summary_PO_Mothly_Chart(ILBRequestModel request)
        {
            try
            {
                List<RPTILB_Po_Kpi_monthly_Status> rawdata = _report.ILB003_Summary_PO_Monthly_Status(request);

                var jsonResult = Json(new
                {
                    data1 = ILB003_Issue_data(rawdata),
                    data2 = ILB003_SentSupp_data(rawdata),
                    data3 = ILB003_OrderConfirm_data(rawdata),
                    success = true
                });

                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ILB003_Summary_PO_Mothly_Chart", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public BarChartIntegerData ILB003_Issue_data(List<RPTILB_Po_Kpi_monthly_Status> rawdata)
        {
            List<string> lsDate = rawdata.Select(o => o.po_date.ToString("dd-MM-yyyy")).Distinct().ToList();
            List<int> lsIssueDelay = rawdata.Select(o => o.issue_delay).ToList();
            List<int> lsIssueOntime = rawdata.Select(o => o.issue_ontime).ToList();

            List<string> lsbgGood = new List<string>();
            List<string> lsbgWarn = new List<string>();
            List<string> lsbgBad = new List<string>();

            foreach (string number in lsDate)
            {
                lsbgGood.Add("rgba(0, 156, 138,0.9)");
                lsbgWarn.Add("rgba(252, 186, 3,0.9)");
                lsbgBad.Add("rgba(241, 99, 95, 0.9)");
            }

            BarChartIntegerDataSet datasetIssueDelay = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Fail",
                data = lsIssueDelay.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgBad.ToArray(),
                borderColor = lsbgBad.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetIssueOntime = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Pass",
                data = lsIssueOntime.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgGood.ToArray(),
                borderColor = lsbgGood.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetIssueOntime,datasetIssueDelay  }
            };

            return data;
        }

        [HttpPost]
        public BarChartIntegerData ILB003_SentSupp_data(List<RPTILB_Po_Kpi_monthly_Status> rawdata)
        {
            List<string> lsDate = rawdata.Select(o => o.po_date.ToString("dd-MM-yyyy")).ToList();
            List<int> lsSentSuppDelay = rawdata.Select(o => o.sent_supp_delay).ToList();
            List<int> lsSentSuppOntime = rawdata.Select(o => o.sent_supp_ontime).ToList();

            List<string> lsbgGood = new List<string>();
            List<string> lsbgWarn = new List<string>();
            List<string> lsbgBad = new List<string>();

            foreach (string number in lsDate)
            {
                lsbgGood.Add("rgba(0, 156, 138,0.9)");
                lsbgWarn.Add("rgba(252, 186, 3,0.9)");
                lsbgBad.Add("rgba(241, 99, 95, 0.9)");
            }

            BarChartIntegerDataSet datasetSentSuppDelay = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Fail",
                data = lsSentSuppDelay.ToArray(), 
                backgroundColor = lsbgBad.ToArray(),
                borderColor = lsbgBad.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetSentSuppOntime = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Pass",
                data = lsSentSuppOntime.ToArray(), 
                backgroundColor = lsbgGood.ToArray(),
                borderColor = lsbgGood.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetSentSuppOntime, datasetSentSuppDelay }
            };

            return data;
        }

        [HttpPost]
        public BarChartIntegerData ILB003_OrderConfirm_data(List<RPTILB_Po_Kpi_monthly_Status> rawdata)
        {
            List<string> lsDate = rawdata.Select(o => o.po_date.ToString("dd-MM-yyyy")).ToList();
            List<int> lsOrderConfirmDelay = rawdata.Select(o => o.order_confirm_delay).ToList();
            List<int> lsOrderConfirmOntime = rawdata.Select(o => o.order_confirm_ontime).ToList();

            List<string> lsbgGood = new List<string>();
            List<string> lsbgWarn = new List<string>();
            List<string> lsbgBad = new List<string>();

            foreach (string number in lsDate)
            {
                lsbgGood.Add("rgba(0, 156, 138,0.9)");
                lsbgWarn.Add("rgba(252, 186, 3,0.9)");
                lsbgBad.Add("rgba(241, 99, 95, 0.9)");
            }

            BarChartIntegerDataSet datasetOrderConfirmDelay = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Fail",
                data = lsOrderConfirmDelay.ToArray(), 
                backgroundColor = lsbgBad.ToArray(),
                borderColor = lsbgBad.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetOrderConfirmOntime = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Pass",
                data = lsOrderConfirmOntime.ToArray(),
                backgroundColor = lsbgGood.ToArray(),
                borderColor = lsbgGood.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetOrderConfirmOntime, datasetOrderConfirmDelay }
            };

            return data;
        }

        [HttpPost]
        public JsonResult RPTILB003_PO_Summary_Status(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.ILB003_Summary_Status(request), success = true });

                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB003_PO_Summary_Status", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
        #endregion

        #region ILB002
        [HttpPost]
        public JsonResult ILB002_Summary_Shpmnt_Chart(ILBRequestModel request)
        {
            try
            {
                List<RPTILB_Summary_Shpmnt_Chart> rawdata = _report.ILB002_Summary_Shpmnt_Chart(request);
                List<string> lsDate = rawdata.Select(o => o.etd_date.ToString("dd-MM-yyyy")).ToList();
                List<int> lsTotalShpmnt = rawdata.Select(o => o.total_shpmnt).ToList();
                List<int> lsNoReadiness = rawdata.Select(o => o.total_no_readiness).ToList();
                List<int> lsNoActualETD = rawdata.Select(o => o.total_no_act_etd).ToList();
                List<int> lsNoDelivery = rawdata.Select(o => o.total_no_delivery).ToList();
                List<int> lsNoCloseShpmnt = rawdata.Select(o => o.total_no_cl_shpmnt).ToList();
                List<int> lsPendingShipdoc = rawdata.Select(o => o.pending_shipdoc).ToList();
                List<int> lsPendingCustomRelease = rawdata.Select(o => o.pending_custom_release).ToList();
                List<int> lsPendingClose= rawdata.Select(o => o.pending_close).ToList();


                List<string> lsbgTotalShpmnt = new List<string>();
                //List<string> lsbd = new List<string>();
                List<string> lsbgNoReadiness = new List<string>();
                List<string> lsbgNoActualETD = new List<string>();
                List<string> lsbgNoDelivery = new List<string>();
                List<string> lsbgNoCloseShpmnt = new List<string>();
                List<string> lsbgPendingShipdoc = new List<string>();
                List<string> lsbgPendingCustomRelease = new List<string>();
                List<string> lsbgPendingClose = new List<string>();
                List<double> valueTH = new List<double>();
                foreach (string number in lsDate)
                {
                    valueTH.Add(10000);
                    lsbgTotalShpmnt.Add("rgba(38, 154, 255,0.9)");
                    lsbgNoReadiness.Add("rgba(12, 202, 142,0.9)");
                    lsbgNoActualETD.Add("rgba(254, 187, 71,0.9)");
                    lsbgPendingShipdoc.Add("rgba(235, 119, 52,0.9)");
                    lsbgPendingCustomRelease.Add("rgba(241, 99, 95,0.9)");
                    lsbgNoDelivery.Add("rgba(99, 99, 99,0.9)");
                    lsbgNoCloseShpmnt.Add("rgba(204, 121, 224,0.9)");
                    lsbgPendingClose.Add("rgba(43, 46, 207,0.9)");
                }

                //Mock the data


                BarChartIntegerDataSet TotalShpmnt = new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Total Shipment",
                    data = lsTotalShpmnt.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgTotalShpmnt.ToArray(),
                    borderColor = lsbgTotalShpmnt.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerDataSet No_Cargo_Readiness = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "No Cargo Readiness Date",
                    data = lsNoReadiness.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgNoReadiness.ToArray(),
                    borderColor = lsbgNoReadiness.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerDataSet No_actual_edt = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ติดตาม Actual ETD",
                    data = lsNoActualETD.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgNoActualETD.ToArray(),
                    borderColor = lsbgNoActualETD.ToArray(),
                    borderWidth = 2
                };

                BarChartIntegerDataSet Pending_Ship_No = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ติดตามสถานะ Receive Ship Docs",
                    data = lsPendingShipdoc.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgPendingShipdoc.ToArray(),
                    borderColor = lsbgPendingShipdoc.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerDataSet Pending_Custom_Release = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ติดตามสถานะ Custom Release",
                    data = lsPendingCustomRelease.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgPendingCustomRelease.ToArray(),
                    borderColor = lsbgPendingCustomRelease.ToArray(),
                    borderWidth = 1
                };


                BarChartIntegerDataSet No_delivery = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ติดตามสถานะ Delivery",
                    data = lsNoDelivery.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgNoDelivery.ToArray(),
                    borderColor = lsbgNoDelivery.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerDataSet No_close_shpmnt = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ติดตามสถานะ Update Payment",
                    data = lsNoCloseShpmnt.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgNoCloseShpmnt.ToArray(),
                    borderColor = lsbgNoCloseShpmnt.ToArray(),
                    borderWidth = 1
                };                
                BarChartIntegerDataSet Pending_close = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ติดตามสถานะ Close",
                    data = lsPendingClose.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgPendingClose.ToArray(),
                    borderColor = lsbgPendingClose.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { TotalShpmnt, No_Cargo_Readiness, No_actual_edt , Pending_Ship_No, Pending_Custom_Release, No_delivery, No_close_shpmnt, Pending_close }
                };


                var jsonResult = Json(new { data, success = true });

                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ILB002_Summary_Shpmnt_Chart", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult RPTILB002_SOSummary_Status(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.ILB002_Summary_Status(request), success = true });

                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ILB002_Summary_Status", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
        #endregion

        #region ILB001
        [HttpPost]
        public JsonResult RPTILB001_POSummary_Status(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.ILB001_Summary_Status(request), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB001_POSummary_Status", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult RPTLPC001_POMonthlyStatus(ILBRequestModel request)
        {
            try
            {
                List<RPTILB_Summary_Chart> rawdata = _report.ILB001_Summary_Chart(request);
                List<string> lsDate = rawdata.Select(o => o.po_date.ToString("dd-MM-yyyy")).ToList();
                List<int> lsTotalPO = rawdata.Select(o => o.total_po).ToList();
                List<int> lsNoPO = rawdata.Select(o => o.total_no_po).ToList();
                List<int> lsNoSentDate = rawdata.Select(o => o.total_no_ss).ToList();
                List<int> lsNoConfirm = rawdata.Select(o => o.total_no_co).ToList();
                List<int> lsNoClosePO = rawdata.Select(o => o.total_no_cl_po).ToList();
                List<int> lsNoShipment = rawdata.Select(o => o.total_no_shipment).ToList();
                List<string> lsbgNoPOColor = new List<string>();
                List<string> lsbgNoSentDateColor = new List<string>();
                List<string> lsbgNoConfirmColor = new List<string>();
                List<string> lsbgNoClosePOColor = new List<string>();
                List<string> lsbgTotalPOColor = new List<string>();
                List<string> lsbgTotalNoShipmentColor = new List<string>();
                List<double> valueTH = new List<double>();
                foreach (string number in lsDate)
                {
                    valueTH.Add(10000);
                    lsbgNoPOColor.Add("rgba(50, 168, 82,0.9)");
                    lsbgNoSentDateColor.Add("rgba(252, 186, 3,0.9)");
                    lsbgNoConfirmColor.Add("rgba(235, 119, 52, 0.9)");
                    lsbgNoClosePOColor.Add("rgba(255, 84, 84,0.9)");
                    lsbgTotalPOColor.Add("rgba(52, 140, 235,0.9)");
                    lsbgTotalNoShipmentColor.Add("rgba(99, 99, 99,0.9)");
                }

                //Mock the data
                BarChartIntegerDataSet No_po_no = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Pending PO Creation",
                    data = lsNoPO.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgNoPOColor.ToArray(),
                    borderColor = lsbgNoPOColor.ToArray(),
                    borderWidth = 1,
                    order = 6
                };

                BarChartIntegerDataSet No_po_sent_date = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Pending PO Sent to Supplier",
                    data = lsNoSentDate.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgNoSentDateColor.ToArray(),
                    borderColor = lsbgNoSentDateColor.ToArray(),
                    borderWidth = 2,
                    order = 2
                };

                BarChartIntegerDataSet No_order_confirm = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Pending Order Confirmation",
                    data = lsNoConfirm.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgNoConfirmColor.ToArray(),
                    borderColor = lsbgNoConfirmColor.ToArray(),
                    borderWidth = 1,
                    order = 3
                };

                BarChartIntegerDataSet Po_not_close = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Pending to Close PO",
                    data = lsNoClosePO.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgNoClosePOColor.ToArray(),
                    borderColor = lsbgNoClosePOColor.ToArray(),
                    borderWidth = 1,
                    order = 4
                };

                BarChartIntegerDataSet TotalPO = new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Total PR/PO",
                    data = lsTotalPO.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgTotalPOColor.ToArray(),
                    borderColor = lsbgTotalPOColor.ToArray(),
                    borderWidth = 1,
                    order = 5
                };                
                BarChartIntegerDataSet TotalNoShipment= new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Pending Shipment Creation",
                    data = lsNoShipment.ToArray(), // 10 20 30 40 < with 
                    backgroundColor = lsbgTotalNoShipmentColor.ToArray(),
                    borderColor = lsbgTotalNoShipmentColor.ToArray(),
                    borderWidth = 1,
                    order = 1
                };

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { TotalPO, No_po_no, No_po_sent_date, No_order_confirm, TotalNoShipment, Po_not_close }
                };


                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTLPC001_POMonthlyStatus", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
        #endregion
    }
}
