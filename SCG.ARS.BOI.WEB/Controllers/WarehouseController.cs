using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using SCG.ARS.BOI.WEB.Attributes;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Security;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class WarehouseController : Controller
    {

        private readonly HttpContext _context;
        private IReportRepository _report;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ISecurityService ss;
        public WarehouseController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IReportRepository report,
            ISecurityService ss)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _report = report;
            this.ss = ss;
        }

        public IActionResult Index()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_WH_001, Permission.View)]
        public IActionResult WEB_WH_001()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_WH_002, Permission.View)]
        public IActionResult WEB_WH_002()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_WH_003, Permission.View)]
        public IActionResult WEB_WH_003()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_WH_004, Permission.View)]
        public IActionResult WEB_WH_004()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_WH_005, Permission.View)]
        public IActionResult WEB_WH_005()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_WH_006, Permission.View)]
        public IActionResult WEB_WH_006()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_WH_007, Permission.View)]
        public IActionResult WEB_WH_007()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_WH_OVERALL, Permission.View)]
        public IActionResult WEB_WH_OVERALL()
        {
            return View();
        }
        [HttpPost]
        public JsonResult RPT007_ReportForLPC(WarehouseRequestModel request)
        {
            var jsonResult = Json(new { data = _report.RPT007_ReportForLPC(request.selectStartDate, request.selectEndDate, request.selectCustomer) });

            return jsonResult;
        }


        [HttpPost]
        public async Task<JsonResult> RPTCDC001_ReceivedSummary(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);
            WarehouseReceivingSummary data = new WarehouseReceivingSummary()
            {
                datalist = _report.RPTCDC001ReceivedSummary(request),
                xAxislabelString = request.CountByName
            };

            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC001_ReceivedSummary(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            WarehouseESCReceivingSummary data = new WarehouseESCReceivingSummary()
            {
                datalist = _report.RPTESC001ReceivedSummary(request),
                xAxislabelString = request.CountByName
            };
            var jsonResult = Json(data);

            return jsonResult;
        }



        [HttpPost]
        public async Task<JsonResult> RPTCDC001_ReceivedSummaryTable(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC001ReceivedSummaryTable(request) });

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTESC001_ReceivedSummaryTable(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC001ReceivedSummaryTable(request) });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC001_TodayReceivingChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);
            List<RPTCDC001CompareReceivingChartViewModel> rawdata = _report.RPTCDC001_CompareReceivingChart(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();
            int countCustomer = rawdata.Count();

            List<int> lsReceivedQtyToday = rawdata.Select(o => o.putaway_qty_today).ToList();
            List<int> lsOutstandingQtyToday = rawdata.Select(o => o.not_putaway_qty).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<double> valueTH = new List<double>();
            foreach (string number in lsCustomer)
            {
                lsbgcolorQty.Add("rgba(0, 156, 138, 0.8)");
                lsbdcolorQty.Add("rgba(0, 156, 138,0.8)");
                lsbgcolorQty2.Add("rgba(241, 99, 95,0.8)");
                lsbdcolorQty2.Add("rgba(241, 99, 95,0.8)");
            }

            //Mock the data
            BarChartIntegerDataSet datasetReceivedQty = new BarChartIntegerDataSet()
            {
                label = "Receive Done",
                data = lsReceivedQtyToday.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetOutstandingQty2 = new BarChartIntegerDataSet()
            {
                label = "Receive Outstanding",
                data = lsOutstandingQtyToday.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }

            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetReceivedQty, datasetOutstandingQty2 },
                countData = countCustomer
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC001_TodayReceivingChart(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC001CompareReceivingChartViewModel> rawdata = _report.RPTESC001_CompareReceivingChart(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).Distinct().ToList();

            List<double> lsExportReceivedQtyToday = rawdata.Where(o => o.transport_type.Contains("Import")).Select(o => o.putaway_qty_today).ToList();
            List<double> lsExportOutstandingQtyToday = rawdata.Where(o => o.transport_type.Contains("Import")).Select(o => o.not_putaway_qty).ToList();

            List<double> lsDomesticReceivedQtyToday = rawdata.Where(o => o.transport_type.Contains("Domestic")).Select(o => o.putaway_qty_today).ToList();
            List<double> lsDomesticOutstandingQtyToday = rawdata.Where(o => o.transport_type.Contains("Domestic")).Select(o => o.not_putaway_qty).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();
            List<string> lsbgcolorQty4 = new List<string>();
            List<string> lsbdcolorQty4 = new List<string>();
            List<double> valueTH = new List<double>();
            foreach (string number in lsCustomer)
            {
                lsbgcolorQty.Add("rgba(0, 156, 138, 0.8)");
                lsbdcolorQty.Add("rgba(0, 156, 138,0.8)");
                lsbgcolorQty2.Add("rgba(241, 99, 95,0.8)");
                lsbdcolorQty2.Add("rgba(241, 99, 95,0.8)");  
                lsbgcolorQty3.Add("rgba(71, 196, 115, 0.8)");
                lsbdcolorQty3.Add("rgba(71, 196, 115,0.8)");
                lsbgcolorQty4.Add("rgba(250, 162, 145,0.8)");
                lsbdcolorQty4.Add("rgba(250, 162, 145,0.8)");

            }

            //Mock the data
            BarChartDataSet datasetReceivedQty1 = new BarChartDataSet()
            {
                label = "Import Receive Done",
                data = lsExportReceivedQtyToday.ToArray(), // 10 20 30 40 < with 
                stack = "Stack 0",
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetOutstandingQty1 = new BarChartDataSet()
            {
                label = "Import Receive Outstanding",
                data = lsExportOutstandingQtyToday.ToArray(), // 10 20 30 40 < with 
                stack = "Stack 0",
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }

            };

            BarChartDataSet datasetReceivedQty2 = new BarChartDataSet()
            {
                label = "Domestic Receive Done",
                data = lsDomesticReceivedQtyToday.ToArray(), // 10 20 30 40 < with 
                stack = "Stack 1",
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetOutstandingQty2 = new BarChartDataSet()
            {
                label = "Domestic Receive Outstanding",
                data = lsDomesticOutstandingQtyToday.ToArray(), // 10 20 30 40 < with 
                stack = "Stack 1",
                backgroundColor = lsbgcolorQty4.ToArray(),
                borderColor = lsbdcolorQty4.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }

            };

            BarChartData data = new BarChartData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartDataSet [] { datasetReceivedQty1, datasetOutstandingQty1, datasetReceivedQty2, datasetOutstandingQty2 }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC001_YesterdayReceivingChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC001CompareReceivingChartViewModel> rawdata = _report.RPTCDC001_CompareReceivingChart(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();

            List<int> lsReceivedQtyYesterday = rawdata.Select(o => o.received_qty_today).ToList();
            List<int> lsOutstandingQtyYesterday = rawdata.Select(o => o.outstanding_qty_today).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<double> valueTH = new List<double>();
            foreach (string number in lsCustomer)
            {
                lsbgcolorQty.Add("rgba(51, 255, 130, 0.6)");
                lsbdcolorQty.Add("rgba(51, 255, 130,0.6)");
                lsbgcolorQty2.Add("rgba(255, 82, 77,0.8)");
                lsbdcolorQty2.Add("rgba(255, 82, 77,0.8)");
            }

            //Mock the data
            BarChartIntegerDataSet datasetReceivedQty = new BarChartIntegerDataSet()
            {
                label = "Receive Done",
                data = lsReceivedQtyYesterday.ToArray(), 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetOutstandingQty2 = new BarChartIntegerDataSet()
            {
                label = "Receive Outstanding",
                data = lsOutstandingQtyYesterday.ToArray(),
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetReceivedQty, datasetOutstandingQty2 }
            };

            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC001_ReceivedByReceivedTimeBarChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC001ReceivedByCustomerTimeViewModel> rawdata = _report.RPTCDC001ReceivedByReceivedTimeBarChart(request);
            List<string> lsReceivedTime = rawdata.Select(o => o.received_time.ToString() + ":00").Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.received_qty, (key, g) => new { customer_name = key, received_qty = g.ToList() }).ToList();

            List<BarChartIntegerDataSet> chartlist = new List<BarChartIntegerDataSet>();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].received_qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartIntegerDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].received_qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsReceivedTime.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            return jsonResult;
        }


        [HttpPost]
        public async Task<JsonResult> RPTCDC001_ReceivedByTimeBarChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC001ReceivedByCustomerTimeViewModel> rawdata = _report.RPTCDC001ReceivedByCustomerTimeBarChart(request);
            List<string> lsReceivedTime = rawdata.Select(o => o.received_time.ToString() + ":00").Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.received_qty, (key, g) => new { customer_name = key, received_qty = g.ToList() }).ToList();

            List<BarChartIntegerDataSet> chartlist = new List<BarChartIntegerDataSet>();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].received_qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartIntegerDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].received_qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsReceivedTime.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            return jsonResult;
        }




        [HttpPost]
        public async Task<JsonResult> RPTESC001_ReceivedByTimeBarChart(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC001ReceivedByCustomerTimeViewModel> rawdata = _report.RPTESC001ReceivedByCustomerTimeBarChart(request);
            List<string> lsReceivedTime = rawdata.Select(o => o.received_time.ToString() + ":00").Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.received_ton, (key, g) => new { customer_name = key, received_ton = g.ToList() }).ToList();

            List<BarChartDataSet> chartlist = new List<BarChartDataSet>();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].received_ton.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].received_ton.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartData data = new BarChartData()
            {
                labels = lsReceivedTime.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC001_ReceivedByTimePieChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC001ReceivedByTimeViewModel> rawdata = _report.RPTCDC001ReceivedByTimePieChart(request);

            List<string> lsReceivedTime = rawdata.Select(o => o.received_time.ToString() + ":00").ToList();
            List<int> lsTotalQty = rawdata.Select(o => o.total_qty).ToList();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> lsbgTotal = new List<string>();
            List<string> lsbdTotal = new List<string>();

            List<string> UsedColor = new List<string>();
            int color_index = 0;
            foreach (string number in lsReceivedTime)
            {
                UsedColor.Add(Colors_picker[color_index]);
                lsbgTotal.Add("rgba(252, 186, 3,0.9)");
                lsbdTotal.Add("rgba(252, 186, 3,0.9)");
                color_index++;
            }

            BarChartIntegerDataSet Total = new BarChartIntegerDataSet()
            {
                label = "Total",
                data = lsTotalQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = UsedColor.ToArray(),
                borderColor = UsedColor.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsReceivedTime.ToArray(),
                datasets = new BarChartIntegerDataSet[] { Total }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC001_ReceivedByTimePieChart(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC001ReceivedByTimeViewModel> rawdata = _report.RPTESC001ReceivedByTimePieChart(request);

            List<string> lsReceivedTime = rawdata.Select(o => o.received_time.ToString() + ":00").ToList();
            List<double> lsTotalQty = rawdata.Select(o => o.total_ton).ToList();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> lsbgTotal = new List<string>();
            List<string> lsbdTotal = new List<string>();

            List<string> UsedColor = new List<string>();
            int color_index = 0;
            foreach (string number in lsReceivedTime)
            {
                UsedColor.Add(Colors_picker[color_index]);
                lsbgTotal.Add("rgba(252, 186, 3,0.9)");
                lsbdTotal.Add("rgba(252, 186, 3,0.9)");
                color_index++;
            }

            BarChartDataSet Total = new BarChartDataSet()
            {
                label = "Total",
                data = lsTotalQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = UsedColor.ToArray(),
                borderColor = UsedColor.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartData data = new BarChartData()
            {
                labels = lsReceivedTime.ToArray(),
                datasets = new BarChartDataSet[] { Total }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        [HttpPost]
        public async Task<ActionResult> GetDC(string selectDcType)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData, $"{{\"selectDcType\": \"{selectDcType}\"}}");
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTWH_GetDC(selectDcType);

                if (allowData.Count > 0)
                {
                    data = data.Where(c => allowData.Any(f => c.DataValue_Key == f.DataValue_Key)).ToList();
                }
                return Json(new { status = isSuccess, data = data, message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetDCESC(string selectDcType)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData, $"{{\"selectDcType\": \"{selectDcType}\"}}");
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTWHESC_GetDC(selectDcType);

                if (allowData.Count > 0)
                {
                    data = data.Where(c => allowData.Any(f => c.DataValue_Key == f.DataValue_Key)).ToList();
                }
                return Json(new { status = isSuccess, data = data, message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetCustomer(string selectwarehouse, List<string> selectDc)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData, $"{{\"selectwarehouse\": \"{selectwarehouse}\"}}");
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTWH_GetCustomer(selectwarehouse, selectDc);

                if (allowData.Count > 0)
                {
                    data = data.Where(c => allowData.Any(f => c.DataValue_Key == f.DataValue_Key)).ToList();
                }
                return Json(new { status = isSuccess, data = data, message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }        
        
        [HttpPost]
        public async Task<ActionResult> GetProductGroup(string selectwarehouse)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData, $"{{\"selectwarehouse\": \"{selectwarehouse}\"}}");
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTWH_GetProductGroup(selectwarehouse);

                if (allowData.Count > 0)
                {
                    data = data.Where(c => allowData.Any(f => c.DataValue_Key == f.DataValue_Key)).ToList();
                }
                return Json(new { status = isSuccess, data = data, message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetCustomerESC(string selectwarehouse, List<int> selectDc)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData, $"{{\"selectwarehouse\": \"{selectwarehouse}\"}}");
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTWHESC_GetCustomer(selectwarehouse, selectDc);

                if (allowData.Count > 0)
                {
                    data = data.Where(c => allowData.Any(f => c.DataValue_Key == f.DataValue_Key)).ToList();
                }
                return Json(new { status = isSuccess, data = data, message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC001_RecivingReport(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            var jsonResult = Json(new { data = _report.RPTCDC001_RecivingReport(request),success=true });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC001_RecivingReport(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC001_RecivingReport(request),success=true });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC003_DispatchingReport(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC003_DispatchingReport(request),success=true });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC002_DispatchingReport(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC002_DispatchingReport(request),success = true });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC003_DispatchSummary(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);
            WarehouseDispatchingSummary data = new WarehouseDispatchingSummary()
            {
                datalist = _report.RPTCDC003DispatchSummary(request),
                xAxislabelString = request.CountByName
            };
            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC002_DispatchSummary(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            WarehouseESCDispatchingSummary data = new WarehouseESCDispatchingSummary()
            {
                datalist = _report.RPTESC002DispatchSummary(request),
                xAxislabelString = request.CountByName
            };
            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC003_TodayDispatchingChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC003CompareDispatchChartViewModel> rawdata = _report.RPTCDC003_CompareDispatchChart(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();
            int countCustomer = rawdata.Count();

            List<double> lsDispatchQtyToday = rawdata.Select(o => o.gi_qty).ToList();
            List<double> lsOutstandingQtyToday = rawdata.Select(o => o.not_gi_qty).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<double> valueTH = new List<double>();
            foreach (string number in lsCustomer)
            {
                lsbgcolorQty.Add("rgba(0, 156, 138, 0.8)");
                lsbdcolorQty.Add("rgba(0, 156, 138,0.8)");
                lsbgcolorQty2.Add("rgba(241, 99, 95,0.8)");
                lsbdcolorQty2.Add("rgba(241, 99, 95,0.8)");
            }

            //Mock the data
            BarChartDataSet datasetDispatchQty = new BarChartDataSet()
            {
                label = "Dispatch Done",
                data = lsDispatchQtyToday.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetDispatchOutstandingQty = new BarChartDataSet()
            {
                label = "Dispatch Outstanding",
                data = lsOutstandingQtyToday.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartData data = new BarChartData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartDataSet[] { datasetDispatchQty, datasetDispatchOutstandingQty },
                countData = countCustomer
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public async Task<JsonResult> RPTESC002_TodayDispatchingChart(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC002CompareDispatchChartViewModel> rawdata = _report.RPTESC002_CompareDispatchChart(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).Distinct().ToList();

            List<double> lsExportDispatchQtyToday = rawdata.Where(o => o.transport_type.Contains("Export")).Select(o => o.gi_qty).ToList();
            List<double> lsExportOutstandingQtyToday = rawdata.Where(o => o.transport_type.Contains("Export")).Select(o => o.not_gi_qty).ToList();

            List<double> lsDomesticDispatchQtyToday = rawdata.Where(o => o.transport_type.Contains("Domestic")).Select(o => o.gi_qty).ToList();
            List<double> lsDomesticOutstandingQtyToday = rawdata.Where(o => o.transport_type.Contains("Domestic")).Select(o => o.not_gi_qty).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();
            List<string> lsbgcolorQty4 = new List<string>();
            List<string> lsbdcolorQty4 = new List<string>();
            List<double> valueTH = new List<double>();
            foreach (string number in lsCustomer)
            {
                lsbgcolorQty.Add("rgba(0, 156, 138, 0.8)");
                lsbdcolorQty.Add("rgba(0, 156, 138,0.8)");
                lsbgcolorQty2.Add("rgba(241, 99, 95,0.8)");
                lsbdcolorQty2.Add("rgba(241, 99, 95,0.8)");
                lsbgcolorQty3.Add("rgba(71, 196, 115, 0.8)");
                lsbdcolorQty3.Add("rgba(71, 196, 115,0.8)");
                lsbgcolorQty4.Add("rgba(250, 162, 145,0.8)");
                lsbdcolorQty4.Add("rgba(250, 162, 145,0.8)");

            }

            //Mock the data
            BarChartDataSet datasetExportDispatchQty = new BarChartDataSet()
            {
                label = "Export Dispatch Done",
                data = lsExportDispatchQtyToday.ToArray(), 
                stack = "Stack 0",
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetExportDispatchOutstandingQty = new BarChartDataSet()
            {
                label = "Export Dispatch Outstanding",
                data = lsExportOutstandingQtyToday.ToArray(), 
                stack = "Stack 0",
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartDataSet datasetDomesticDispatchQty = new BarChartDataSet()
            {
                label = "Domestic Dispatch Ddonone",
                data = lsDomesticDispatchQtyToday.ToArray(),
                stack = "Stack 1",
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetDomesticDispatchOutstandingQty = new BarChartDataSet()
            {
                label = "Domestic Dispatch Outstanding",
                data = lsDomesticOutstandingQtyToday.ToArray(),
                stack = "Stack 1",
                backgroundColor = lsbgcolorQty4.ToArray(),
                borderColor = lsbdcolorQty4.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartData data = new BarChartData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartDataSet[] { datasetExportDispatchQty, datasetExportDispatchOutstandingQty, datasetDomesticDispatchQty, datasetDomesticDispatchOutstandingQty }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC003_DispatchSummaryTable(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC003_DispatchSummaryTable(request) });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC002_DispatchSummaryTable(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC002_DispatchSummaryTable(request) });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC003_DispatchByTimeBarChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC003DispatchByCustomerTimeViewModel> rawdata = _report.RPTCDC003DispatchByCustomerTimeChart(request);
            List<string> lsDispatchingTime = rawdata.Select(o => o.dispatch_time.ToString() + ":00").Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.dispatch_qty, (key, g) => new { customer_name = key, dispatch_qty = g.ToList() }).ToList();

            List<BarChartIntegerDataSet> chartlist = new List<BarChartIntegerDataSet>();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].dispatch_qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartIntegerDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].dispatch_qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDispatchingTime.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC003_DispatchByCreateTimeBarChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC003DispatchByCustomerTimeViewModel> rawdata = _report.RPTCDC003DispatchByCustomerCreateTimeChart(request);
            List<string> lsDispatchingTime = rawdata.Select(o => o.dispatch_time.ToString() + ":00").Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.dispatch_qty, (key, g) => new { customer_name = key, dispatch_qty = g.ToList() }).ToList();

            List<BarChartIntegerDataSet> chartlist = new List<BarChartIntegerDataSet>();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].dispatch_qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartIntegerDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].dispatch_qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDispatchingTime.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }


        [HttpPost]
        public async Task<JsonResult> RPTESC002_DispatchByTimeBarChart(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC002DispatchByCustomerTimeViewModel> rawdata = _report.RPTESC002DispatchByCustomerTimeChart(request);
            List<string> lsDispatchingTime = rawdata.Select(o => o.dispatch_time.ToString() + ":00").Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.dispatch_qty, (key, g) => new { customer_name = key, dispatch_qty = g.ToList() }).ToList();

            List<BarChartDataSet> chartlist = new List<BarChartDataSet>();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].dispatch_qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].dispatch_qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartData data = new BarChartData()
            {
                labels = lsDispatchingTime.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC003_DispatchByTimePieChart(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC003DispatchByTimeViewModel> rawdata = _report.RPTCDC003DispatchByTimeChart(request);

            List<string> lsReceivedTime = rawdata.Select(o => o.dispatch_time.ToString() + ":00").ToList();
            List<int> lsTotalQty = rawdata.Select(o => o.total_qty).ToList();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> lsbgTotal = new List<string>();
            List<string> lsbdTotal = new List<string>();

            List<string> UsedColor = new List<string>();
            int color_index = 0;
            foreach (string number in lsReceivedTime)
            {
                UsedColor.Add(Colors_picker[color_index]);
                lsbgTotal.Add("rgba(252, 186, 3,0.9)");
                lsbdTotal.Add("rgba(252, 186, 3,0.9)");
                color_index++;
            }

            BarChartIntegerDataSet Total = new BarChartIntegerDataSet()
            {
                label = "Total",
                data = lsTotalQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = UsedColor.ToArray(),
                borderColor = UsedColor.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsReceivedTime.ToArray(),
                datasets = new BarChartIntegerDataSet[] { Total }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC002_DispatchByTimePieChart(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC002DispatchByTimeViewModel> rawdata = _report.RPTESC002DispatchByTimeChart(request);

            List<string> lsReceivedTime = rawdata.Select(o => o.dispatch_time.ToString() + ":00").ToList();
            List<double> lsTotalQty = rawdata.Select(o => o.total_qty).ToList();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> lsbgTotal = new List<string>();
            List<string> lsbdTotal = new List<string>();

            List<string> UsedColor = new List<string>();
            int color_index = 0;
            foreach (string number in lsReceivedTime)
            {
                UsedColor.Add(Colors_picker[color_index]);
                lsbgTotal.Add("rgba(252, 186, 3,0.9)");
                lsbdTotal.Add("rgba(252, 186, 3,0.9)");
                color_index++;
            }

            BarChartDataSet Total = new BarChartDataSet()
            {
                label = "Total",
                data = lsTotalQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = UsedColor.ToArray(),
                borderColor = UsedColor.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartData data = new BarChartData()
            {
                labels = lsReceivedTime.ToArray(),
                datasets = new BarChartDataSet[] { Total }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC002_StockOnHandReport(WarehouseRequestStockModel request)
        {
            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC002_StockOnHandReport(request), success = true });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC003_StockOnHandReport(WarehouseESCRequestStockModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC003_StockOnHandReport(request),success=true });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC002_StockSummary(WarehouseRequestStockModel request)
        {
            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC002_StockSummary(request) });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC003_StockSummary(WarehouseESCRequestStockModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC003_StockSummary(request) });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC002_StockByLocationType(WarehouseRequestStockModel request)
        {
            await FilterCriteria(request);
            List<RPTCDC002StockByLocationTypeViewModel> rawdata = _report.RPTCDC002_StockByLocationType(request);

            List<string> lsLocationType = rawdata.Select(o => o.location_type).ToList();
            List<int> lsPlanLocation = rawdata.Select(o => o.plan_location).ToList();
            List<int> lsUsedLocation = rawdata.Select(o => o.used_location).ToList();
            List<int> lsUtilization = rawdata.Select(o => o.plan_location != 0 ? Convert.ToInt32((Convert.ToDouble(o.used_location) / Convert.ToDouble(o.plan_location)) * 100.00) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();
            foreach (string number in lsLocationType)
            {
                lsbgcolorQty.Add("rgba(94, 190, 228, 0.8)");
                lsbdcolorQty.Add("rgba(94, 190, 228,0.8)");
                lsbgcolorQty2.Add("rgba(76, 214, 176,0.8)");
                lsbdcolorQty2.Add("rgba(76, 214, 176,0.8)");
                lsbgcolorQty3.Add("rgba(152, 220, 86,0.8)");
                lsbdcolorQty3.Add("rgba(152, 220, 86,0.8)");
            }

            BarChartIntegerDataSet datasetPlanQty = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Plan",
                data = lsPlanLocation.ToArray(),
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = true
                }
            };

            BarChartIntegerDataSet datasetUsedQty = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Used",
                data = lsUsedLocation.ToArray(),
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = true
                }
            };

            BarChartIntegerDataSet datasetUtilizationQty = new BarChartIntegerDataSet()
            {
                type = "line",
                label = "Difference",
                data = lsUtilization.ToArray(),
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 3,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    align = "end",
                    anchor = "start",
                    display = true
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsLocationType.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetUtilizationQty ,datasetPlanQty, datasetUsedQty,  }
            };

            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC003_StockByLocationType(WarehouseESCRequestStockModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            List<RPTESC003StockByLocationTypeViewModel> rawdata = _report.RPTESC003_StockByLocationType(request);

            List<string> lsLocationType = rawdata.Select(o => o.location_type).ToList();
            List<double> lsPlanLocation = rawdata.Select(o => o.plan_location).ToList();
            List<double> lsUsedLocation = rawdata.Select(o => o.used_location).ToList();
            List<double> lsUtilization = rawdata.Select(o => o.plan_location !=0 ? (Convert.ToDouble(o.used_location) / Convert.ToDouble(o.plan_location) * 100.00):0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();
            foreach (string number in lsLocationType)
            {
                lsbgcolorQty.Add("rgba(94, 190, 228, 0.8)");
                lsbdcolorQty.Add("rgba(94, 190, 228,0.8)");
                lsbgcolorQty2.Add("rgba(76, 214, 176,0.8)");
                lsbdcolorQty2.Add("rgba(76, 214, 176,0.8)");
                lsbgcolorQty3.Add("rgba(152, 220, 86,0.8)");
                lsbdcolorQty3.Add("rgba(152, 220, 86,0.8)");
            }

            BarChartDataSet datasetPlanQty = new BarChartDataSet()
            {
                type = "bar",
                label = "Plan",
                data = lsPlanLocation.ToArray(),
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = true
                }
            };

            BarChartDataSet datasetUsedQty = new BarChartDataSet()
            {
                type = "bar",
                label = "Used",
                data = lsUsedLocation.ToArray(),
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = true
                }
            };

            BarChartDataSet datasetUtilizationQty = new BarChartDataSet()
            {
                type = "line",
                label = "Utilization",
                data = lsUtilization.ToArray(),
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 3,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    align = "end",
                    anchor = "start",
                    display = true
                }
            };

            BarChartData data = new BarChartData()
            {
                labels = lsLocationType.ToArray(),
                datasets = new BarChartDataSet[] { datasetUtilizationQty, datasetPlanQty, datasetUsedQty, }
            };

            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC002_StorageByCustomerLocationChart(WarehouseRequestStockModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC002StorageByCustomerLocationViewModel> rawdata = _report.RPTCDC002_StorageByCustomerLocation(request);

            List<string> lsLocationType = rawdata.Select(o => o.location_type.ToString()).Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.used_location, (key, g) => new { customer_name = key, used_location = g.ToList() }).ToList();

            List<BarChartIntegerDataSet> chartlist = new List<BarChartIntegerDataSet>();

            List<string> Colors_picker = new List<string>{
                         "rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].used_location.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartIntegerDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].used_location.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }

                });
            }

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsLocationType.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTESC003_StorageByCustomerLocationChart(WarehouseESCRequestStockModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC003StorageByCustomerLocationViewModel> rawdata = _report.RPTESC003_StorageByCustomerLocation(request);

            List<string> lsLocationType = rawdata.Select(o => o.location_type.ToString()).Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.used_location, (key, g) => new { customer_name = key, used_location = g.ToList() }).ToList();

            List<BarChartDataSet> chartlist = new List<BarChartDataSet>();

            List<string> Colors_picker = new List<string>{
                         "rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].used_location.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].used_location.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }

                });
            }

            BarChartData data = new BarChartData()
            {
                labels = lsLocationType.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }


        [HttpPost]
        public async Task<JsonResult> RPTCDC002_StorageByCustomerLocationPieceChart(WarehouseRequestStockModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC002StorageByCustomerLocationPieceViewModel> rawdata = _report.RPTCDC002_StorageByCustomerLocationPiece(request);

            List<string> lsLocationType = rawdata.Select(o => o.location_type.ToString()).Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.qty, (key, g) => new { customer_name = key, qty = g.ToList() }).ToList();

            List<BarChartIntegerDataSet> chartlist = new List<BarChartIntegerDataSet>();

            List<string> Colors_picker = new List<string>{
                         "rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

        List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartIntegerDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsLocationType.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTESC003_StorageByCustomerLocationPieceChart(WarehouseESCRequestStockModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC003StorageByCustomerLocationPieceViewModel> rawdata = _report.RPTESC003_StorageByCustomerLocationPiece(request);

            List<string> lsLocationType = rawdata.Select(o => o.location_type.ToString()).Distinct().ToList();
            List<string> lsCustomerName = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.qty, (key, g) => new { customer_name = key, qty = g.ToList() }).ToList();

            List<BarChartDataSet> chartlist = new List<BarChartDataSet>();

            List<string> Colors_picker = new List<string>{
                         "rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(165, 204, 235,0.6)"
                        ,"rgba(28, 199, 206,0.6)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartData data = new BarChartData()
            {
                labels = lsLocationType.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC002_StockByAging(WarehouseRequestStockModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC002StockByAgingViewModel> rawdata = _report.RPTCDC002_StockByAging(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();
            int countCustomer = rawdata.Count();

            List<int> lsAge1Qty= rawdata.Select(o => o.age1).ToList();
            List<int> lsAge2Qty= rawdata.Select(o => o.age2).ToList();
            List<int> lsAge3Qty= rawdata.Select(o => o.age3).ToList();
            List<int> lsAge4Qty= rawdata.Select(o => o.age4).ToList();
            List<int> lsAge5Qty= rawdata.Select(o => o.age5).ToList();
            List<int> lsAge6Qty= rawdata.Select(o => o.age6).ToList();
            

            List<string> lsbgAge1Qty = new List<string>();
            List<string> lsbdAge1Qty = new List<string>();
            List<string> lsbgAge2Qty = new List<string>();
            List<string> lsbdAge2Qty = new List<string>();
            List<string> lsbgAge3Qty = new List<string>();
            List<string> lsbdAge3Qty = new List<string>();
            List<string> lsbgAge4Qty = new List<string>();
            List<string> lsbdAge4Qty = new List<string>();
            List<string> lsbgAge5Qty = new List<string>();
            List<string> lsbdAge5Qty = new List<string>();
            List<string> lsbgAge6Qty = new List<string>();
            List<string> lsbdAge6Qty = new List<string>();

            foreach (string number in lsCustomer)
            {
                lsbgAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbdAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbdAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbgAge4Qty.Add("rgba(255,153,0,1)");
                lsbdAge4Qty.Add("rgba(255,153,0,1)");
                lsbgAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbdAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbgAge6Qty.Add("rgba(163, 72, 81,0.8)");
                lsbdAge6Qty.Add("rgba(163, 72, 81,0.8)");
            }

            //Mock the data
            BarChartIntegerDataSet datasetAge1Qty = new BarChartIntegerDataSet()
            {
                label = "0-1 เดือน",
                data = lsAge1Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge1Qty.ToArray(),
                borderColor = lsbdAge1Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetAge2Qty = new BarChartIntegerDataSet()
            {
                label = "1-3 เดือน",
                data = lsAge2Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge2Qty.ToArray(),
                borderColor = lsbdAge2Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetAge3Qty = new BarChartIntegerDataSet()
            {
                label = "3-6 เดือน",
                data = lsAge3Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge3Qty.ToArray(),
                borderColor = lsbdAge3Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetAge4Qty = new BarChartIntegerDataSet()
            {
                label = "6-12 เดือน",
                data = lsAge4Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge4Qty.ToArray(),
                borderColor = lsbdAge4Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetAge5Qty = new BarChartIntegerDataSet()
            {
                label = "12-24 เดือน",
                data = lsAge5Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge5Qty.ToArray(),
                borderColor = lsbdAge5Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetAge6Qty = new BarChartIntegerDataSet()
            {
                label = "มากกว่า 2 ปี",
                data = lsAge6Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge6Qty.ToArray(),
                borderColor = lsbdAge6Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };


            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetAge1Qty, datasetAge2Qty, datasetAge3Qty, datasetAge4Qty, datasetAge5Qty, datasetAge6Qty },
                countData = countCustomer
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC003_StockByAging(WarehouseESCRequestStockModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC003StockByAgingViewModel> rawdata = _report.RPTESC003_StockByAging(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();

            List<double> lsAge1Qty = rawdata.Select(o => o.age1).ToList();
            List<double> lsAge2Qty = rawdata.Select(o => o.age2).ToList();
            List<double> lsAge3Qty = rawdata.Select(o => o.age3).ToList();
            List<double> lsAge4Qty = rawdata.Select(o => o.age4).ToList();
            List<double> lsAge5Qty = rawdata.Select(o => o.age5).ToList();
            List<double> lsAge6Qty = rawdata.Select(o => o.age6).ToList();


            List<string> lsbgAge1Qty = new List<string>();
            List<string> lsbdAge1Qty = new List<string>();
            List<string> lsbgAge2Qty = new List<string>();
            List<string> lsbdAge2Qty = new List<string>();
            List<string> lsbgAge3Qty = new List<string>();
            List<string> lsbdAge3Qty = new List<string>();
            List<string> lsbgAge4Qty = new List<string>();
            List<string> lsbdAge4Qty = new List<string>();
            List<string> lsbgAge5Qty = new List<string>();
            List<string> lsbdAge5Qty = new List<string>();
            List<string> lsbgAge6Qty = new List<string>();
            List<string> lsbdAge6Qty = new List<string>();

            foreach (string number in lsCustomer)
            {
                lsbgAge1Qty.Add("rgba(41,177,139,0.8)");
                lsbdAge1Qty.Add("rgba(41,177,139,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbdAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge3Qty.Add("rgba(148,230,208,0.8)");
                lsbdAge3Qty.Add("rgba(148,230,208,0.8)");
                lsbgAge4Qty.Add("rgba(183,239,223,0.8)");
                lsbdAge4Qty.Add("rgba(183,239,223,0.8)");
                lsbgAge5Qty.Add("rgba(255,124,128,0.8)");
                lsbdAge5Qty.Add("rgba(255,124,128,0.8)");
                lsbgAge6Qty.Add("rgba(255,71,71,0.8)");
                lsbdAge6Qty.Add("rgba(255,71,71,0.8)");
            }

            //Mock the data
            BarChartDataSet datasetAge1Qty = new BarChartDataSet()
            {
                label = "1-7",
                data = lsAge1Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge1Qty.ToArray(),
                borderColor = lsbdAge1Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetAge2Qty = new BarChartDataSet()
            {
                label = "8-15",
                data = lsAge2Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge2Qty.ToArray(),
                borderColor = lsbdAge2Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetAge3Qty = new BarChartDataSet()
            {
                label = "16-30  ",
                data = lsAge3Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge3Qty.ToArray(),
                borderColor = lsbdAge3Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetAge4Qty = new BarChartDataSet()
            {
                label = "31-45",
                data = lsAge4Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge4Qty.ToArray(),
                borderColor = lsbdAge4Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetAge5Qty = new BarChartDataSet()
            {
                label = "45-60",
                data = lsAge5Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge5Qty.ToArray(),
                borderColor = lsbdAge5Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartDataSet datasetAge6Qty = new BarChartDataSet()
            {
                label = ">60",
                data = lsAge6Qty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge6Qty.ToArray(),
                borderColor = lsbdAge6Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };


            BarChartData data = new BarChartData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartDataSet[] { datasetAge1Qty, datasetAge2Qty, datasetAge3Qty, datasetAge4Qty, datasetAge5Qty, datasetAge6Qty }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTCDC005_PickPackSummary(WarehouseRequestPickPackModel request)
        {
            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC005_PickPackSummary(request) });

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTESC005_PickPackSummary(WarehouseESCRequestPickPackModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC005_PickPackSummary(request) });

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTCDC005_PickByCustomer(WarehouseRequestPickPackModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC005PickByCustomerViewModel> rawdata = _report.RPTCDC005_PickByCustomer(request);

            List<string> lsPickDate = rawdata.Select(o => o.pick_date.ToString("dd/MM/yyyy")).Distinct().ToList();
            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.pick_qty, (key, g) => new { customer_name = key, pick_qty = g.ToList() }).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();

            List<BarChartIntegerDataSet> chartlist = new List<BarChartIntegerDataSet>();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(28, 199, 206,0.8)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};        

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].pick_qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartIntegerDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].pick_qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsPickDate.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC005_PickByCustomer(WarehouseESCRequestPickPackModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            List<RPTESC005PickByCustomerViewModel> rawdata = _report.RPTESC005_PickByCustomer(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();
            List<double> lsPickQty = rawdata.Select(o => o.pick_ton).ToList();
            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();

            foreach (string number in lsCustomer)
            {

                lsbgcolorQty.Add("rgba(94, 190, 228, 0.8)");
                lsbdcolorQty.Add("rgba(94, 190, 228, 0.8)");
            }

            //Mock the data
            BarChartDataSet datasetPickQty = new BarChartDataSet()
            {
                type = "bar",
                label = "Customer",
                data = lsPickQty.ToArray(), 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };


            BarChartData data = new BarChartData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartDataSet[] { datasetPickQty }
            };


            var jsonResult = Json(data);

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTCDC005_PackByCustomer(WarehouseRequestPickPackModel request)
        {
            await FilterCriteria(request);
            List<RPTCDC005PackByCustomerViewModel> rawdata = _report.RPTCDC005_PackByCustomer(request);

            List<string> lsPackDate = rawdata.Select(o => o.pack_date.ToString("dd/MM/yyyy")).Distinct().ToList();
            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();
            var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.pack_qty, (key, g) => new { customer_name = key, pack_qty = g.ToList() }).ToList();

            List<BarChartIntegerDataSet> chartlist = new List<BarChartIntegerDataSet>();

            List<string> Colors_picker = new List<string>{"rgba(1, 31, 104,0.6)"
                        ,"rgba(56, 99, 178,0.6)"
                        ,"rgba(28, 199, 206,0.8)"
                        ,"rgba(0, 106, 92,0.6)"
                        ,"rgba(0, 102, 52,0.6)"
                        ,"rgba(121, 207, 136,0.6)"
                        ,"rgba(255, 227, 143,0.6)"
                        ,"rgba(255, 167, 33,0.6)"
                        ,"rgba(234, 100, 1,0.6)"
                        ,"rgba(175, 95, 0,0.6)"
                        ,"rgba(81, 0, 9,0.6)"
                        ,"rgba(255, 41, 30,0.6)"
                        ,"rgba(245, 129, 132,0.6)"
                        ,"rgba(249, 218, 190,0.6)"
                        ,"rgba(255, 186, 191,0.6)"
                        ,"rgba(255, 109, 180,0.6)"
                        ,"rgba(242, 31, 128,0.6)"
                        ,"rgba(182, 0, 147,0.6)"
                        ,"rgba(159, 80, 161,0.6)"
                        ,"rgba(180, 137, 193,0.6)"
                        ,"rgba(190, 179, 219,0.6)"
                        ,"rgba(170, 179, 184,0.6)"
                        ,"rgba(101, 118, 125,0.6)"};

            List<string> UsedColor = new List<string>();
            for (int i = 0; i < lsGrpCustomerName.Count; i++)
            {
                UsedColor = new List<string> { };
                for (int j = 0; j < lsGrpCustomerName[i].pack_qty.Count; j++)
                {
                    UsedColor.Add(Colors_picker[i]);
                }
                chartlist.Add(new BarChartIntegerDataSet()
                {
                    type = "bar",
                    backgroundColor = UsedColor.ToArray(),
                    borderColor = UsedColor.ToArray(),
                    label = lsGrpCustomerName[i].customer_name,
                    data = lsGrpCustomerName[i].pack_qty.ToArray(),
                    datalabels = new datalabelsModel
                    {
                        display = false
                    }
                });
            }

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsPackDate.ToArray(),
                datasets = chartlist.ToArray()
            };


            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC005_PackByCustomer(WarehouseESCRequestPickPackModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            List<RPTESC005PackByCustomerViewModel> rawdata = _report.RPTESC005_PackByCustomer(request);

            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();
            List<int> lsPackQty = rawdata.Select(o => o.pack_qty).ToList();
            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();

            foreach (string number in lsCustomer)
            {

                lsbgcolorQty.Add("rgba(94, 190, 228, 0.8)");
                lsbdcolorQty.Add("rgba(94, 190, 228, 0.8)");
            }

            //Mock the data
            BarChartIntegerDataSet datasetPackQty = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Customer",
                data = lsPackQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };


            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetPackQty }
            };


            var jsonResult = Json(data);

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTCDC005_PickPackReport(WarehouseRequestPickPackModel request)
        {
            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC005_PickPackReport(request),success=true });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTESC005_PickPackReport(WarehouseESCRequestPickPackModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC005_PickPackReport(request) });

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTCDC006_CheckMoveQty(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC006_CheckMoveQty(request) });

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTESC004_CheckMoveQty(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC004_CheckMoveQty(request) });

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC006_CheckMoveReport(WarehouseCDCRequestDateModel input)
        {
            await FilterCriteria(input);
            var jsonResult = Json(new { data = _report.RPTCDC006_CheckMoveReport(input),success=true });

            return jsonResult;
        }


        [HttpPost]
        public async Task<JsonResult> RPTESC004_CheckMoveReport(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            var jsonResult = Json(new { data = _report.RPTESC004_CheckMoveReport(request),success=true });

            return jsonResult;
        }


        [HttpPost]
        public async Task<JsonResult> RPTCDC006_CheckMoveByLocation(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);
            List<RPTCDC006CheckMoveByLocationViewModel> rawdata = _report.RPTCDC006_CheckMoveByLocation(request);

            List<string> lsLocationType = rawdata.Select(o => o.location_type+";"+o.count_date?.ToString("yyyy-MM-dd") ?? "").ToList();
            List<string> lsDate = rawdata.Select(o => o.count_date?.ToString("yyyy-MM-dd") ?? "").ToList();
            List<double> lsInventoryQty = rawdata.Select(o => o.inventory_qty).ToList();
            List<double> lsCountQty = rawdata.Select(o => o.count_qty).ToList(); 
            List<double> lsDiffQty = rawdata.Select(o => o.inventory_qty - o.count_qty).ToList(); 

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();
            foreach (string number in lsLocationType)
            {
                lsbgcolorQty.Add("rgba(94, 190, 228, 0.8)");
                lsbdcolorQty.Add("rgba(94, 190, 228,0.8)");
                lsbgcolorQty2.Add("rgba(76, 214, 176,0.8)");
                lsbdcolorQty2.Add("rgba(76, 214, 176,0.8)");
                lsbgcolorQty3.Add("rgba(68,84,106,1)");
                lsbdcolorQty3.Add("rgba(68,84,106,1)");
            }

            BarChartDataSet datasetInventoryQty = new BarChartDataSet()
            {
                type = "bar",
                label = "จำนวนทั้งหมด",
                data = lsInventoryQty.ToArray(),
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = false
                }
            };

            BarChartDataSet datasetCountQty = new BarChartDataSet()
            {
                type = "bar",
                label = "จำนวนที่นับได้",
                data = lsCountQty.ToArray(),
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = false
                }
            };

            BarChartDataSet datasetDiffQty = new BarChartDataSet()
            {
                type = "line",
                label = "จำนวนผลต่าง",
                data = lsDiffQty.ToArray(),
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 1,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = false 
                }
            };

            BarChartData data = new BarChartData()
            {
                labels = lsLocationType.ToArray(),
                Multilabels = lsDate.ToArray(),
                datasets = new BarChartDataSet[] { datasetInventoryQty, datasetCountQty, datasetDiffQty }
            };

            var jsonResult = Json(data);

            return jsonResult;
        }
        [HttpPost]
        public async Task<JsonResult> RPTESC004_CheckMoveByLocation(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");
            List<RPTESC004CheckMoveByLocationViewModel> rawdata = _report.RPTESC004_CheckMoveByLocation(request);

            List<string> lsLocationType = rawdata.Select(o => o.location_type + ";" + o.count_date?.ToString("yyyy-MM-dd") ?? "").ToList();
            List<string> lsDate = rawdata.Select(o => o.count_date?.ToString("yyyy-MM-dd") ?? "").ToList();
            List<double> lsInventoryQty = rawdata.Select(o => o.inventory_weight).ToList();
            List<double> lsCountQty = rawdata.Select(o => o.count_weight).ToList();
            List<double> lsDiffQty = rawdata.Select(o => o.inventory_weight - o.count_weight).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();
            foreach (string number in lsLocationType)
            {
                lsbgcolorQty.Add("rgba(94, 190, 228, 0.8)");
                lsbdcolorQty.Add("rgba(94, 190, 228,0.8)");
                lsbgcolorQty2.Add("rgba(76, 214, 176,0.8)");
                lsbdcolorQty2.Add("rgba(76, 214, 176,0.8)");
                lsbgcolorQty3.Add("rgba(68,84,106,1)");
                lsbdcolorQty3.Add("rgba(68,84,106,1)");
            }

            BarChartDataSet datasetInventoryQty = new BarChartDataSet()
            {
                type = "bar",
                label = "จำนวนทั้งหมด",
                data = lsInventoryQty.ToArray(),
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = false
                }
            };

            BarChartDataSet datasetCountQty = new BarChartDataSet()
            {
                type = "bar",
                label = "จำนวนที่นับได้",
                data = lsCountQty.ToArray(),
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = false
                }
            };

            BarChartDataSet datasetDiffQty = new BarChartDataSet()
            {
                type = "line",
                label = "จำนวนผลต่าง",
                data = lsDiffQty.ToArray(),
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 1,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    align = "top",
                    anchor = "end",
                    display = false
                }
            };

            BarChartData data = new BarChartData()
            {
                labels = lsLocationType.ToArray(),
                Multilabels = lsDate.ToArray(),
                datasets = new BarChartDataSet[] { datasetInventoryQty, datasetCountQty, datasetDiffQty }
            };

            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC006_CheckMoveByLocationSummaryTable(WarehouseCDCRequestDateModel request)
        {

            await FilterCriteria(request);
            var jsonResult = Json(new { data = _report.RPTCDC006_CheckMoveByLocation(request) });

            return jsonResult;

        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC006_CheckMoveByLocationSummaryDetailTable(WarehouseCDCRequestDateModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC006CheckMoveByLocationViewModel> rawdata = _report.RPTCDC006_CheckMoveByLocation(request);


            List<string> lsDate = rawdata.Select(o => o.count_date?.ToString("dd/MM/yyyy") ?? "").Distinct().ToList();
            List<string> lsLocationType = rawdata.Select(o => o.location_type).ToList();

            var lsTempHeader = from rowdata in rawdata
                          group rowdata by rowdata.count_date into rowGroup
                          select new
                          {
                              Date = rowGroup.Key?.ToString("dd/MM/yyyy") ?? "",
                              CountColDate = rowGroup.Count()
                          };
            CheckMoveByLocationSummaryHederViewModel header = new CheckMoveByLocationSummaryHederViewModel()
            {
                date = lsTempHeader.Select(o=>o.Date).ToArray(),
                location_type = lsLocationType.ToArray(),
                CountColDate = lsTempHeader.Select(o=>o.CountColDate).ToArray(),
            };
            
           
            //header = lsDate2.ToList();
            //logins
            //  .GroupBy(l => l.Date)
            //  .Select(g => new
            //  {
            //      Date = g.Key,
            //      Count = g.Select(l => l.Login).Distinct().Count()
            //  });
            //var lsGrpCustomerName = rawdata.GroupBy(g => g.count_date, g => g.count_date.ToString("yyyy-MM-dd")).Distinct().Count() , (key, g) => new { count_date = key, qty = g.ToList() }).ToList();
            //    var lsGrpCustomerName = rawdata.GroupBy(g => g.customer_name, g => g.qty, (key, g) => new { customer_name = key, qty = g.ToList() }).ToList();

            List<string> lsInventoryQty = rawdata.Select(o => o.inventory_qty.ToString()).ToList();
            List<string> lsCountQty = rawdata.Select(o => o.count_qty.ToString()).ToList();
            List<string> lsDiffQty = rawdata.Select(o => (o.inventory_qty - o.count_qty).ToString()).ToList();
            List<string> lsDiffQtyPercent = rawdata.Select(o => (o.inventory_qty != 0 ? (100.0*(o.inventory_qty - o.count_qty)/o.inventory_qty) : 0).ToString("N2")+"%").ToList();

            //CheckMoveByLocationSummaryHederViewModel header = new CheckMoveByLocationSummaryHederViewModel()
            //{
            //    date = ,
            //    location_type = lsLocationType.ToArray()
            //};

            CheckMoveByLocationSummaryDetailViewModel InventoryQty = new CheckMoveByLocationSummaryDetailViewModel()
            {
                rowType = "จำนวนทั้งหมด(ชิ้น)",
                qty = lsInventoryQty.ToArray()
            };

            CheckMoveByLocationSummaryDetailViewModel CountQty = new CheckMoveByLocationSummaryDetailViewModel()
            {
                rowType = "จำนวนนับได้(ชิ้น)",
                qty = lsCountQty.ToArray()
            };            
            CheckMoveByLocationSummaryDetailViewModel DiffQty = new CheckMoveByLocationSummaryDetailViewModel()
            {
                rowType = "จำนวนผลต่าง(ชิ้น)",
                qty = lsDiffQty.ToArray()
            };            
            CheckMoveByLocationSummaryDetailViewModel DiffQtyPercent = new CheckMoveByLocationSummaryDetailViewModel()
            {
                rowType = "% จำนวนผลต่าง",
                qty = lsDiffQtyPercent.ToArray()
            };

            

            var data = new CheckMoveByLocationSummaryDetailViewModel[] { InventoryQty, CountQty, DiffQty , DiffQtyPercent };

            CheckMoveByLocationSummaryTableViewModel dataTable = new CheckMoveByLocationSummaryTableViewModel()
            {
                header = header,
                data = data
            };

            var jsonResult = Json(dataTable);

            return jsonResult;

        }

        [HttpPost]
        public async Task<JsonResult> RPTESC004_CheckMoveByLocationSummaryDetailTable(WarehouseESCRequestDateModel request)
        {
            await FilterCriteriaESC(request, "ESC");

            List<RPTESC004CheckMoveByLocationViewModel> rawdata = _report.RPTESC004_CheckMoveByLocation(request);


            List<string> lsDate = rawdata.Select(o => o.count_date?.ToString("dd/MM/yyyy") ?? "").Distinct().ToList();

            List<string> lsLocationType = rawdata.Select(o => o.location_type).ToList();

            var lsTempHeader = from rowdata in rawdata
                               group rowdata by rowdata.count_date into rowGroup
                               select new
                               {
                                   Date = rowGroup.Key?.ToString("dd/MM/yyyy") ?? "",
                                   CountColDate = rowGroup.Count()
                               };
            CheckMoveByLocationSummaryHederViewModel header = new CheckMoveByLocationSummaryHederViewModel()
            {
                date = lsTempHeader.Select(o => o.Date).ToArray(),
                location_type = lsLocationType.ToArray(),
                CountColDate = lsTempHeader.Select(o => o.CountColDate).ToArray(),
            };

            List<double> lsInventoryQty = rawdata.Select(o => o.inventory_weight).ToList();
            List<double> lsCountQty = rawdata.Select(o => o.count_weight).ToList();
            List<double> lsDiffQty = rawdata.Select(o => o.inventory_weight - o.count_weight).ToList();

            //CheckMoveByLocationSummaryHederViewModel header = new CheckMoveByLocationSummaryHederViewModel()
            //{
            //    date = ,
            //    location_type = lsLocationType.ToArray()
            //};

            ESCCheckMoveByLocationSummaryDetailViewModel InventoryQty = new ESCCheckMoveByLocationSummaryDetailViewModel()
            {
                rowType = "จำนวนทั้งหมด",
                qty = lsInventoryQty.ToArray()
            };

            ESCCheckMoveByLocationSummaryDetailViewModel CountQty = new ESCCheckMoveByLocationSummaryDetailViewModel()
            {
                rowType = "จำนวนนับได้",
                qty = lsCountQty.ToArray()
            };
            ESCCheckMoveByLocationSummaryDetailViewModel DiffQty = new ESCCheckMoveByLocationSummaryDetailViewModel()
            {
                rowType = "จำนวนผลต่าง",
                qty = lsDiffQty.ToArray()
            };



            var data = new ESCCheckMoveByLocationSummaryDetailViewModel[] { InventoryQty, CountQty, DiffQty };

            ESCCheckMoveByLocationSummaryTableViewModel dataTable = new ESCCheckMoveByLocationSummaryTableViewModel()
            {
                header = header,
                data = data
            };

            var jsonResult = Json(dataTable);

            return jsonResult;

        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC000_ReceiveAccuracyOrder(WarehouseOverAllRequestModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC000ReceiveAccuracyViewModel> rawdata = _report.RPTCDC000_ReceiveAccuracy(request);
            List<string> lsReceivedDate = rawdata.Select(o => o.receive_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsPlanOrder = rawdata.Select(o => o.plan_order).ToList();
            List<int> lsReceiveOrder = rawdata.Select(o => o.receive_order).ToList();

            List<int> lsReceiveAccuracy= rawdata.Select(o => o.plan_order != 0 ? Convert.ToInt32((Convert.ToDouble(o.receive_order)/ Convert.ToDouble(o.plan_order)) * 100) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();

            foreach (string number in lsReceivedDate)
            {
                lsbgcolorQty.Add("rgba(152, 220, 86, 0.8)");
                lsbdcolorQty.Add("rgba(0, 0, 0, 0.8)");
                lsbgcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbdcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbgcolorQty3.Add("rgba(35, 158, 297,0.8)");
                lsbdcolorQty3.Add("rgba(35, 158, 297,0.8)");
            }

            BarChartIntegerDataSet datasetPlanOrderQty = new BarChartIntegerDataSet()
            {
                label = "แผนการรับสินค้า (PO)",
                data = lsPlanOrder.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            
            BarChartIntegerDataSet datasetReceiveOrderQty = new BarChartIntegerDataSet()
            {
                label = "รับสินค้าถูกต้อง (PO)",
                data = lsReceiveOrder.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };            
            BarChartIntegerDataSet datasetReceiveAccuracyQty = new BarChartIntegerDataSet()
            {
                type = "line",
                label = "% Receive Accuracy",
                data = lsReceiveAccuracy.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsReceivedDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetPlanOrderQty, datasetReceiveOrderQty, datasetReceiveAccuracyQty }
            };


            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC000_ReceiveAccuracyQty(WarehouseOverAllRequestModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC000ReceiveAccuracyViewModel> rawdata = _report.RPTCDC000_ReceiveAccuracy(request);
            List<string> lsReceivedDate = rawdata.Select(o => o.receive_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsPlanQty = rawdata.Select(o => o.plan_qty).ToList();
            List<int> lsReceiveQty= rawdata.Select(o => o.receive_qty).ToList();

            List<int> lsReceiveAccuracy = rawdata.Select(o => o.plan_qty!= 0 ? Convert.ToInt32((Convert.ToDouble(o.receive_qty) / Convert.ToDouble(o.plan_qty)) * 100) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();

            foreach (string number in lsReceivedDate)
            {
                lsbgcolorQty.Add("rgba(152, 220, 86, 0.8)");
                lsbdcolorQty.Add("rgba(0, 0, 0, 0.8)");
                lsbgcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbdcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbgcolorQty3.Add("rgba(35, 158, 297,0.8)");
                lsbdcolorQty3.Add("rgba(35, 158, 297,0.8)");
            }

            BarChartIntegerDataSet datasetPlanOrderQty = new BarChartIntegerDataSet()
            {
                label = "แผนการรับสินค้า (ชิ้น)",
                data = lsPlanQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetReceiveOrderQty = new BarChartIntegerDataSet()
            {
                label = "รับสินค้าถูกต้อง (ชิ้น)",
                data = lsReceiveQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetReceiveAccuracyQty = new BarChartIntegerDataSet()
            {
                type = "line",
                label = "% Receive Accuracy",
                data = lsReceiveAccuracy.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsReceivedDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetPlanOrderQty, datasetReceiveOrderQty, datasetReceiveAccuracyQty }
            };


            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC000_DispatchAccuracyOrder(WarehouseOverAllRequestModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC000DispatchAccuracyViewModel> rawdata = _report.RPTCDC000_DispatchAccuracy(request);
            List<string> lsDispatchDate = rawdata.Select(o => o.dispatch_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsPlanOrder = rawdata.Select(o => o.plan_order).ToList();
            List<int> lsDispatchOrder = rawdata.Select(o => o.dispatch_order).ToList();

            List<int> lsDispatchAccuracy = rawdata.Select(o => o.plan_order != 0 ? Convert.ToInt32((Convert.ToDouble(o.dispatch_order) / Convert.ToDouble(o.plan_order)) * 100) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();

            foreach (string number in lsDispatchDate)
            {
                lsbgcolorQty.Add("rgba(152, 220, 86, 0.8)");
                lsbdcolorQty.Add("rgba(0, 0, 0, 0.8)");
                lsbgcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbdcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbgcolorQty3.Add("rgba(35, 158, 297,0.8)");
                lsbdcolorQty3.Add("rgba(35, 158, 297,0.8)");
            }

            BarChartIntegerDataSet datasetPlanOrderQty = new BarChartIntegerDataSet()
            {
                label = "แผนการจ่ายสินค้า (SO)",
                data = lsPlanOrder.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetDispatchOrderQty = new BarChartIntegerDataSet()
            {
                label = "จ่ายสินค้าถูกต้อง (SO)",
                data = lsDispatchOrder.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetDispatchAccuracyQty = new BarChartIntegerDataSet()
            {
                type = "line",
                label = "% Dispatch Accuracy",
                data = lsDispatchAccuracy.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDispatchDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetPlanOrderQty, datasetDispatchOrderQty, datasetDispatchAccuracyQty }
            };

            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC000_DispatchAccuracyQty(WarehouseOverAllRequestModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC000DispatchAccuracyViewModel> rawdata = _report.RPTCDC000_DispatchAccuracy(request);
            List<string> lsDispatchDate = rawdata.Select(o => o.dispatch_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsPlanQty = rawdata.Select(o => o.plan_qty).ToList();
            List<int> lsDispatchQty= rawdata.Select(o => o.dispatch_qty).ToList();

            List<int> lsDispatchAccuracy = rawdata.Select(o => o.plan_qty != 0 ? Convert.ToInt32((Convert.ToDouble(o.dispatch_qty) / Convert.ToDouble(o.plan_qty)) * 100) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();

            foreach (string number in lsDispatchDate)
            {
                lsbgcolorQty.Add("rgba(152, 220, 86, 0.8)");
                lsbdcolorQty.Add("rgba(0, 0, 0, 0.8)");
                lsbgcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbdcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbgcolorQty3.Add("rgba(35, 158, 297,0.8)");
                lsbdcolorQty3.Add("rgba(35, 158, 297,0.8)");
            }

            BarChartIntegerDataSet datasetPlanOrderQty = new BarChartIntegerDataSet()
            {
                label = "แผนการจ่ายสินค้า (ชิ้น)",
                data = lsPlanQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetDispatchOrderQty = new BarChartIntegerDataSet()
            {
                label = "จ่ายสินค้าถูกต้อง (ชิ้น)",
                data = lsDispatchQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetDispatchAccuracyQty = new BarChartIntegerDataSet()
            {
                type = "line",
                label = "% Dispatch Accuracy",
                data = lsDispatchAccuracy.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDispatchDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetPlanOrderQty, datasetDispatchOrderQty, datasetDispatchAccuracyQty }
            };

            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC000_ReceiveDispatchQty(WarehouseOverAllRequestModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC000ReceiveDispatchViewModel> rawdata = _report.RPTCDC000_ReceiveDispatch(request);
            List<string> lsDispatchDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsReceivedQty = rawdata.Select(o => o.received_qty).ToList();
            List<int> lsDispatchQty = rawdata.Select(o => o.dispatch_qty).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();

            foreach (string number in lsDispatchDate)
            {
                lsbgcolorQty.Add("rgba(148, 230, 208, 0.8)");
                lsbdcolorQty.Add("rgba(0, 0, 0, 0.8)");
                lsbgcolorQty2.Add("rgba(255, 80, 80,0.8)");
            }

            BarChartIntegerDataSet datasetReceivedQty = new BarChartIntegerDataSet()
            {
                label = "จำนวนที่รับ",
                data = lsReceivedQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetDispatchQty = new BarChartIntegerDataSet()
            {
                label = "จำนวนที่จ่าย",
                data = lsDispatchQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDispatchDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetReceivedQty, datasetDispatchQty }
            };


            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC000_ReceiveDispatchOrder(WarehouseOverAllRequestModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC000ReceiveDispatchViewModel> rawdata = _report.RPTCDC000_ReceiveDispatch(request);
            List<string> lsDispatchDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsReceivedOrder = rawdata.Select(o => o.received_order).ToList();
            List<int> lsDispatchOrder = rawdata.Select(o => o.dispatch_order).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();

            foreach (string number in lsDispatchDate)
            {
                lsbgcolorQty.Add("rgba(148, 230, 208, 0.8)");
                lsbdcolorQty.Add("rgba(0, 0, 0, 0.8)");
                lsbgcolorQty2.Add("rgba(255, 80, 80,0.8)");
            }

            BarChartIntegerDataSet datasetReceivedQty = new BarChartIntegerDataSet()
            {
                label = "จำนวนที่รับ",
                data = lsReceivedOrder.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerDataSet datasetDispatchQty = new BarChartIntegerDataSet()
            {
                label = "จำนวนที่จ่าย",
                data = lsDispatchOrder.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDispatchDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetReceivedQty, datasetDispatchQty }
            };


            var jsonResult = Json(data);

            return jsonResult;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC000_StockUtilization(WarehouseOverAllRequestModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC000StockUtilizationViewModel> rawdata = _report.RPTCDC000_StockUtilization(request);
            var jsonResult = Json(new
            {
                UtilizationDataASRS = RPTCDC000_StockUtilization_ASRS(rawdata),
                UtilizationDataMezzanine = RPTCDC000_StockUtilization_Mezzanine(rawdata),
                UtilizationDataRack = RPTCDC000_StockUtilization_Rack(rawdata),
                UtilizationDataFloor = RPTCDC000_StockUtilization_Floor(rawdata)
            });

            return jsonResult;
        }

        [HttpPost]
        public BarChartNPData RPTCDC000_StockUtilization_ASRS(List<RPTCDC000StockUtilizationViewModel> rawdata)
        {
            List<string> lsTransDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<double> lsTotalLocationQty = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => Convert.ToDouble(o.total_location)).ToList();
            List<double> lsUsedLocationQty = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => Convert.ToDouble(o.used_location)).ToList();
            List<double> lsUtilizationQty = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => o.total_location != 0 ? Math.Round((Convert.ToDouble(o.used_location) / Convert.ToDouble(o.total_location) * 100.0),2) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();

            foreach (string number in lsTransDate)
            {
                lsbdcolorQty.Add("rgba(255, 30, 30, 0.8)");
                lsbgcolorQty.Add("rgba(255, 30, 30, 0.8)");
                lsbgcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbdcolorQty2.Add("rgba(0, 0, 0,0.8)");
                lsbgcolorQty3.Add("rgba(35, 158, 297,0.8)");
                lsbdcolorQty3.Add("rgba(0, 0, 0,0.8)");
            }

            BarChartNPDataSet datasetTotalLocationQty = new BarChartNPDataSet()
            {
                type = "line",
                label = "Cap.Location ใน ASRS",
                data = lsTotalLocationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                radius = 0,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartNPDataSet datasetUsedLocationQty = new BarChartNPDataSet()
            {
                label = "จำนวน Location ใน ASRS ที่ใช้",
                data = lsUsedLocationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartNPDataSet datasetUtilizationQty = new BarChartNPDataSet()
            {
                type = "line",
                label = "% Utilization",
                data = lsUtilizationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 1,
                radius = 3,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartNPData data = new BarChartNPData()
            {
                labels = lsTransDate.ToArray(),
                datasets = new BarChartNPDataSet[] { datasetTotalLocationQty, datasetUsedLocationQty , datasetUtilizationQty }
            };

            return data;
        }

        [HttpPost]
        public BarChartNPData RPTCDC000_StockUtilization_Rack(List<RPTCDC000StockUtilizationViewModel> rawdata)
        {
            List<string> lsTransDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<double> lsTotalLocationQty = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => Convert.ToDouble(o.total_location)).ToList();
            List<double> lsUsedLocationQty = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => Convert.ToDouble(o.used_location)).ToList();
            List<double> lsUtilizationQty = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => o.total_location != 0 ? Math.Round((Convert.ToDouble(o.used_location) / Convert.ToDouble(o.total_location) * 100.0),2) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();

            foreach (string number in lsTransDate)
            {
                lsbgcolorQty.Add("rgba(255, 30, 30, 0.8)");
                lsbdcolorQty.Add("rgba(255, 30, 30, 0.8)");
                lsbgcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbdcolorQty2.Add("rgba(0, 0, 0,0.8)");
                lsbgcolorQty3.Add("rgba(35, 158, 297,0.8)");
                lsbdcolorQty3.Add("rgba(0, 0, 0,0.8)");
            }

            BarChartNPDataSet datasetTotalLocationQty = new BarChartNPDataSet()
            {
                type = "line",
                label = "Cap.Location ใน Selective Rack",
                data = lsTotalLocationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                radius = 0,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartNPDataSet datasetUsedLocationQty = new BarChartNPDataSet()
            {
                label = "จำนวน Location ใน Selective ที่ใช้",
                data = lsUsedLocationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartNPDataSet datasetUtilizationQty = new BarChartNPDataSet()
            {
                type = "line",
                label = "% Utilization",
                data = lsUtilizationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 1,
                radius = 3,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartNPData data = new BarChartNPData()
            {
                labels = lsTransDate.ToArray(),
                datasets = new BarChartNPDataSet[] { datasetTotalLocationQty, datasetUsedLocationQty, datasetUtilizationQty }
            };

            return data;
        }
        [HttpPost]
        public BarChartNPData RPTCDC000_StockUtilization_Mezzanine(List<RPTCDC000StockUtilizationViewModel> rawdata)
        {
            List<string> lsTransDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<double> lsTotalLocationQty = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => Convert.ToDouble(o.total_location)).ToList();
            List<double> lsUsedLocationQty = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => Convert.ToDouble(o.used_location)).ToList();
            List<double> lsUtilizationQty = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => o.total_location != 0 ? Math.Round((Convert.ToDouble(o.used_location) / Convert.ToDouble(o.total_location) * 100.0),2) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();

            foreach (string number in lsTransDate)
            {
                lsbgcolorQty.Add("rgba(255, 30, 30, 0.8)");
                lsbdcolorQty.Add("rgba(255, 30, 30, 0.8)");
                lsbgcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbdcolorQty2.Add("rgba(0, 0, 0,0.8)");
                lsbgcolorQty3.Add("rgba(35, 158, 297,0.8)");
                lsbdcolorQty3.Add("rgba(0, 0, 0,0.8)");
            }

            BarChartNPDataSet datasetTotalLocationQty = new BarChartNPDataSet()
            {
                type = "line",
                label = "Cap. Location ใน Mezzanine",
                data = lsTotalLocationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                radius = 0,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartNPDataSet datasetUsedLocationQty = new BarChartNPDataSet()
            {
                label = "จำนวน Location ใน Mezzanine ที่ใช้",
                data = lsUsedLocationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartNPDataSet datasetUtilizationQty = new BarChartNPDataSet()
            {
                type = "line",
                label = "% Utilization",
                data = lsUtilizationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 1,
                radius = 3,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartNPData data = new BarChartNPData()
            {
                labels = lsTransDate.ToArray(),
                datasets = new BarChartNPDataSet[] { datasetTotalLocationQty, datasetUsedLocationQty, datasetUtilizationQty }
            };

            return data;
        }

        [HttpPost]
        public BarChartNPData RPTCDC000_StockUtilization_Floor(List<RPTCDC000StockUtilizationViewModel> rawdata)
        {
            List<string> lsTransDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<double> lsTotalLocationQty = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => Convert.ToDouble(o.total_location)).ToList();
            List<double> lsUsedLocationQty = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => Convert.ToDouble(o.used_location)).ToList();
            List<double> lsUtilizationQty = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => o.total_location != 0 ? Math.Round((Convert.ToDouble(o.used_location) / Convert.ToDouble(o.total_location) * 100.0),2) : 0).ToList();

            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<string> lsbgcolorQty3 = new List<string>();
            List<string> lsbdcolorQty3 = new List<string>();

            foreach (string number in lsTransDate)
            {
                lsbgcolorQty.Add("rgba(255,30,30, 0.8)");
                lsbdcolorQty.Add("rgba(255,30,30, 0.8)");
                lsbgcolorQty2.Add("rgba(183, 239, 223,0.8)");
                lsbdcolorQty2.Add("rgba(0, 0, 0,0.8)");
                lsbgcolorQty3.Add("rgba(35, 158, 297,0.8)");
                lsbdcolorQty3.Add("rgba(0, 0, 0,0.8)");
            }

            BarChartNPDataSet datasetTotalLocationQty = new BarChartNPDataSet()
            {
                type = "line",
                label = "Cap. Location ใน On Floor ",
                data = lsTotalLocationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1,
                radius = 0,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartNPDataSet datasetUsedLocationQty = new BarChartNPDataSet()
            {
                label = "จำนวน Location ใน On floor ที่ใช้",
                data = lsUsedLocationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 1,
                yAxisID = "left-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartNPDataSet datasetUtilizationQty = new BarChartNPDataSet()
            {
                type = "line",
                label = "% Utilization",
                data = lsUtilizationQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty3.ToArray(),
                borderColor = lsbdcolorQty3.ToArray(),
                borderWidth = 1,
                radius = 3,
                yAxisID = "right-axis",
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartNPData data = new BarChartNPData()
            {
                labels = lsTransDate.ToArray(),
                datasets = new BarChartNPDataSet[] { datasetTotalLocationQty, datasetUsedLocationQty, datasetUtilizationQty }
            };

            return data;
        }

        [HttpPost]
        public async Task<JsonResult> RPTCDC000_AgingProduct(WarehouseOverAllRequestModel request)
        {
            await FilterCriteria(request);

            List<RPTCDC000AgingProductViewModel> rawdata = _report.RPTCDC000_AgingProduct(request);

            var jsonResult = Json(new
            {
                AgingProductDataASRS= RPTCDC000_AgingProduct_ASRS(rawdata),
                AgingProductDataMezzanine = RPTCDC000_AgingProduct_Mezzanine(rawdata),
                AgingProductDataRack = RPTCDC000_AgingProduct_Rack(rawdata),
                AgingProductDataFloor = RPTCDC000_AgingProduct_Floor(rawdata)
            });

            return jsonResult;
        }
        [HttpPost]
        public BarChartIntegerData RPTCDC000_AgingProduct_ASRS(List<RPTCDC000AgingProductViewModel> rawdata)
        {
            List<string> lsTransDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsAgingProductQty1 = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => o.age1).ToList();
            List<int> lsAgingProductQty2 = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => o.age2).ToList();
            List<int> lsAgingProductQty3 = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => o.age3).ToList();
            List<int> lsAgingProductQty4 = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => o.age4).ToList();
            List<int> lsAgingProductQty5 = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => o.age5).ToList();
            List<int> lsAgingProductQty6 = rawdata.Where(o => o.location_type.Contains("ASRS")).Select(o => o.age6).ToList();

            List<string> lsbgAge1Qty = new List<string>();
            List<string> lsbdAge1Qty = new List<string>();
            List<string> lsbgAge2Qty = new List<string>();
            List<string> lsbdAge2Qty = new List<string>();
            List<string> lsbgAge3Qty = new List<string>();
            List<string> lsbdAge3Qty = new List<string>();
            List<string> lsbgAge4Qty = new List<string>();
            List<string> lsbdAge4Qty = new List<string>();
            List<string> lsbgAge5Qty = new List<string>();
            List<string> lsbdAge5Qty = new List<string>();
            List<string> lsbgAge6Qty = new List<string>();
            List<string> lsbdAge6Qty = new List<string>();

            foreach (string number in lsTransDate)
            {
                lsbgAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbdAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbdAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbgAge4Qty.Add("rgba(255,153,0,1)");
                lsbdAge4Qty.Add("rgba(255,153,0,1)");
                lsbgAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbdAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbgAge6Qty.Add("rgba(163, 72, 81,0.8)");
                lsbdAge6Qty.Add("rgba(163, 72, 81,0.8)");
            }

            BarChartIntegerDataSet datasetAgingProductQty1 = new BarChartIntegerDataSet()
            {
                label = "0-1 เดือน",
                data = lsAgingProductQty1.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge1Qty.ToArray(),
                borderColor = lsbdAge1Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty2 = new BarChartIntegerDataSet()
            {
                label = "1-3 เดือน",
                data = lsAgingProductQty2.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge2Qty.ToArray(),
                borderColor = lsbdAge2Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty3 = new BarChartIntegerDataSet()
            {
                label = "3-6 เดือน",
                data = lsAgingProductQty3.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge3Qty.ToArray(),
                borderColor = lsbdAge3Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty4 = new BarChartIntegerDataSet()
            {
                label = "6-12 เดือน",
                data = lsAgingProductQty4.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge4Qty.ToArray(),
                borderColor = lsbdAge4Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty5 = new BarChartIntegerDataSet()
            {
                label = "12-24 เดือน",
                data = lsAgingProductQty5.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge5Qty.ToArray(),
                borderColor = lsbdAge5Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty6 = new BarChartIntegerDataSet()
            {
                label = "มากกว่า 2 ปี",
                data = lsAgingProductQty6.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge6Qty.ToArray(),
                borderColor = lsbdAge6Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsTransDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetAgingProductQty1, datasetAgingProductQty2, datasetAgingProductQty3, datasetAgingProductQty4, datasetAgingProductQty5 , datasetAgingProductQty6 }
            };

            return data;
        }

        [HttpPost]
        public BarChartIntegerData RPTCDC000_AgingProduct_Rack(List<RPTCDC000AgingProductViewModel> rawdata)
        {
            List<string> lsTransDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsAgingProductQty1 = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => o.age1).ToList();
            List<int> lsAgingProductQty2 = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => o.age2).ToList();
            List<int> lsAgingProductQty3 = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => o.age3).ToList();
            List<int> lsAgingProductQty4 = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => o.age4).ToList();
            List<int> lsAgingProductQty5 = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => o.age5).ToList();
            List<int> lsAgingProductQty6 = rawdata.Where(o => o.location_type.Contains("Rack")).Select(o => o.age6).ToList();


            List<string> lsbgAge1Qty = new List<string>();
            List<string> lsbdAge1Qty = new List<string>();
            List<string> lsbgAge2Qty = new List<string>();
            List<string> lsbdAge2Qty = new List<string>();
            List<string> lsbgAge3Qty = new List<string>();
            List<string> lsbdAge3Qty = new List<string>();
            List<string> lsbgAge4Qty = new List<string>();
            List<string> lsbdAge4Qty = new List<string>();
            List<string> lsbgAge5Qty = new List<string>();
            List<string> lsbdAge5Qty = new List<string>();
            List<string> lsbgAge6Qty = new List<string>();
            List<string> lsbdAge6Qty = new List<string>();

            foreach (string number in lsTransDate)
            {
                lsbgAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbdAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbdAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbgAge4Qty.Add("rgba(255,153,0,1)");
                lsbdAge4Qty.Add("rgba(255,153,0,1)");
                lsbgAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbdAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbgAge6Qty.Add("rgba(163, 72, 81,0.8)");
                lsbdAge6Qty.Add("rgba(163, 72, 81,0.8)");
            }

            BarChartIntegerDataSet datasetAgingProductQty1 = new BarChartIntegerDataSet()
            {
                label = "0-1 เดือน",
                data = lsAgingProductQty1.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge1Qty.ToArray(),
                borderColor = lsbdAge1Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty2 = new BarChartIntegerDataSet()
            {
                label = "1-3 เดือน",
                data = lsAgingProductQty2.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge2Qty.ToArray(),
                borderColor = lsbdAge2Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty3 = new BarChartIntegerDataSet()
            {
                label = "3-6 เดือน",
                data = lsAgingProductQty3.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge3Qty.ToArray(),
                borderColor = lsbdAge3Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty4 = new BarChartIntegerDataSet()
            {
                label = "6-12 เดือน",
                data = lsAgingProductQty4.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge4Qty.ToArray(),
                borderColor = lsbdAge4Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty5 = new BarChartIntegerDataSet()
            {
                label = "12-24 เดือน",
                data = lsAgingProductQty5.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge5Qty.ToArray(),
                borderColor = lsbdAge5Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty6 = new BarChartIntegerDataSet()
            {
                label = "มากกว่า 2 ปี",
                data = lsAgingProductQty6.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge6Qty.ToArray(),
                borderColor = lsbdAge6Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsTransDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetAgingProductQty1, datasetAgingProductQty2, datasetAgingProductQty3, datasetAgingProductQty4, datasetAgingProductQty5, datasetAgingProductQty6 }
            };

            return data;
        }

        [HttpPost]
        public BarChartIntegerData RPTCDC000_AgingProduct_Mezzanine(List<RPTCDC000AgingProductViewModel> rawdata)
        {
            List<string> lsTransDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsAgingProductQty1 = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => o.age1).ToList();
            List<int> lsAgingProductQty2 = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => o.age2).ToList();
            List<int> lsAgingProductQty3 = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => o.age3).ToList();
            List<int> lsAgingProductQty4 = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => o.age4).ToList();
            List<int> lsAgingProductQty5 = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => o.age5).ToList();
            List<int> lsAgingProductQty6 = rawdata.Where(o => o.location_type.Contains("Mezzanine")).Select(o => o.age6).ToList();


            List<string> lsbgAge1Qty = new List<string>();
            List<string> lsbdAge1Qty = new List<string>();
            List<string> lsbgAge2Qty = new List<string>();
            List<string> lsbdAge2Qty = new List<string>();
            List<string> lsbgAge3Qty = new List<string>();
            List<string> lsbdAge3Qty = new List<string>();
            List<string> lsbgAge4Qty = new List<string>();
            List<string> lsbdAge4Qty = new List<string>();
            List<string> lsbgAge5Qty = new List<string>();
            List<string> lsbdAge5Qty = new List<string>();
            List<string> lsbgAge6Qty = new List<string>();
            List<string> lsbdAge6Qty = new List<string>();

            foreach (string number in lsTransDate)
            {
                lsbgAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbdAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbdAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbgAge4Qty.Add("rgba(255,153,0,1)");
                lsbdAge4Qty.Add("rgba(255,153,0,1)");
                lsbgAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbdAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbgAge6Qty.Add("rgba(163, 72, 81,0.8)");
                lsbdAge6Qty.Add("rgba(163, 72, 81,0.8)");
            }

            BarChartIntegerDataSet datasetAgingProductQty1 = new BarChartIntegerDataSet()
            {
                label = "0-1 เดือน",
                data = lsAgingProductQty1.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge1Qty.ToArray(),
                borderColor = lsbdAge1Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty2 = new BarChartIntegerDataSet()
            {
                label = "1-3 เดือน",
                data = lsAgingProductQty2.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge2Qty.ToArray(),
                borderColor = lsbdAge2Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty3 = new BarChartIntegerDataSet()
            {
                label = "3-6 เดือน",
                data = lsAgingProductQty3.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge3Qty.ToArray(),
                borderColor = lsbdAge3Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty4 = new BarChartIntegerDataSet()
            {
                label = "6-12 เดือน",
                data = lsAgingProductQty4.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge4Qty.ToArray(),
                borderColor = lsbdAge4Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty5 = new BarChartIntegerDataSet()
            {
                label = "12-24 เดือน",
                data = lsAgingProductQty5.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge5Qty.ToArray(),
                borderColor = lsbdAge5Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty6 = new BarChartIntegerDataSet()
            {
                label = "มากกว่า 2 ปี",
                data = lsAgingProductQty6.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge6Qty.ToArray(),
                borderColor = lsbdAge6Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsTransDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetAgingProductQty1, datasetAgingProductQty2, datasetAgingProductQty3, datasetAgingProductQty4, datasetAgingProductQty5, datasetAgingProductQty6 }
            };

            return data;
        }

        [HttpPost]
        public BarChartIntegerData RPTCDC000_AgingProduct_Floor(List<RPTCDC000AgingProductViewModel> rawdata)
        {
            List<string> lsTransDate = rawdata.Select(o => o.trans_date?.ToString("dd") ?? "").Distinct().ToList();
            List<int> lsAgingProductQty1 = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => o.age1).ToList();
            List<int> lsAgingProductQty2 = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => o.age2).ToList();
            List<int> lsAgingProductQty3 = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => o.age3).ToList();
            List<int> lsAgingProductQty4 = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => o.age4).ToList();
            List<int> lsAgingProductQty5 = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => o.age5).ToList();
            List<int> lsAgingProductQty6 = rawdata.Where(o => o.location_type.Contains("Floor")).Select(o => o.age6).ToList();


            List<string> lsbgAge1Qty = new List<string>();
            List<string> lsbdAge1Qty = new List<string>();
            List<string> lsbgAge2Qty = new List<string>();
            List<string> lsbdAge2Qty = new List<string>();
            List<string> lsbgAge3Qty = new List<string>();
            List<string> lsbdAge3Qty = new List<string>();
            List<string> lsbgAge4Qty = new List<string>();
            List<string> lsbdAge4Qty = new List<string>();
            List<string> lsbgAge5Qty = new List<string>();
            List<string> lsbdAge5Qty = new List<string>();
            List<string> lsbgAge6Qty = new List<string>();
            List<string> lsbdAge6Qty = new List<string>();

            foreach (string number in lsTransDate)
            {
                lsbgAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbdAge1Qty.Add("rgba(0, 156, 138,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge2Qty.Add("rgba(76,214,176,0.8)");
                lsbgAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbdAge3Qty.Add("rgba(255,235,100,0.8)");
                lsbgAge4Qty.Add("rgba(255,153,0,1)");
                lsbdAge4Qty.Add("rgba(255,153,0,1)");
                lsbgAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbdAge5Qty.Add("rgba(255,71,71,0.8)");
                lsbgAge6Qty.Add("rgba(163, 72, 81,0.8)");
                lsbdAge6Qty.Add("rgba(163, 72, 81,0.8)");
            }

            BarChartIntegerDataSet datasetAgingProductQty1 = new BarChartIntegerDataSet()
            {
                label = "0-1 เดือน",
                data = lsAgingProductQty1.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge1Qty.ToArray(),
                borderColor = lsbdAge1Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty2 = new BarChartIntegerDataSet()
            {
                label = "1-3 เดือน",
                data = lsAgingProductQty2.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge2Qty.ToArray(),
                borderColor = lsbdAge2Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty3 = new BarChartIntegerDataSet()
            {
                label = "3-6 เดือน",
                data = lsAgingProductQty3.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge3Qty.ToArray(),
                borderColor = lsbdAge3Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty4 = new BarChartIntegerDataSet()
            {
                label = "6-12 เดือน",
                data = lsAgingProductQty4.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge4Qty.ToArray(),
                borderColor = lsbdAge4Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty5 = new BarChartIntegerDataSet()
            {
                label = "12-24 เดือน",
                data = lsAgingProductQty5.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge5Qty.ToArray(),
                borderColor = lsbdAge5Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };
            BarChartIntegerDataSet datasetAgingProductQty6 = new BarChartIntegerDataSet()
            {
                label = "มากกว่า 2 ปี",
                data = lsAgingProductQty6.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAge6Qty.ToArray(),
                borderColor = lsbdAge6Qty.ToArray(),
                borderWidth = 1,
                datalabels = new datalabelsModel
                {
                    display = false
                }
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsTransDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { datasetAgingProductQty1, datasetAgingProductQty2, datasetAgingProductQty3, datasetAgingProductQty4, datasetAgingProductQty5, datasetAgingProductQty6 }
            };

            return data;
        }

        private async Task FilterCriteria(WarehouseCDCRequestDateModel request, string warehouse = "CDC")
        {
            var allowDC = (await ss.GetAllowData(_context, "/Warehouse/GetDC", $"{{\"selectDcType\": \"{warehouse}\"}}")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowCustomer = (await ss.GetAllowData(_context, "/Warehouse/GetCustomer", $"{{\"selectwarehouse\": \"{warehouse}\"}}")).Select(c => Convert.ToString(c.DataValue_Key));
            if (allowDC.Count() > 0)
            {
                if (request.selectDc?.Count == 0 || request.selectDc == null)
                    request.selectDc = allowDC.ToList();
            }
            if (allowCustomer.Count() > 0)
            {
                if (request.selectCustomer?.Count == 0 || request.selectCustomer == null)
                    request.selectCustomer = allowCustomer.ToList();
            }
        }
        private async Task FilterCriteria(WarehouseRequestStockModel request, string warehouse = "CDC")
        {
            var allowDC = (await ss.GetAllowData(_context, "/Warehouse/GetDC", $"{{\"selectDcType\": \"{warehouse}\"}}")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowCustomer = (await ss.GetAllowData(_context, "/Warehouse/GetCustomer", $"{{\"selectwarehouse\": \"{warehouse}\"}}")).Select(c => Convert.ToString(c.DataValue_Key));
            if (allowDC.Count() > 0)
            {
                if (request.selectDc?.Count == 0 || request.selectDc == null)
                    request.selectDc = allowDC.ToList();
            }
            if (allowCustomer.Count() > 0)
            {
                if (request.selectCustomer?.Count == 0 || request.selectCustomer == null)
                    request.selectCustomer = allowCustomer.ToList();
            }
        }
        private async Task FilterCriteria(WarehouseRequestPickPackModel request, string warehouse = "CDC")
        {
            var allowDC = (await ss.GetAllowData(_context, "/Warehouse/GetDC", $"{{\"selectDcType\": \"{warehouse}\"}}")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowCustomer = (await ss.GetAllowData(_context, "/Warehouse/GetCustomer", $"{{\"selectwarehouse\": \"{warehouse}\"}}")).Select(c => Convert.ToString(c.DataValue_Key));
            if (allowDC.Count() > 0)
            {
                if (request.selectDc?.Count == 0 || request.selectDc == null)
                    request.selectDc = allowDC.ToList();
            }
            if (allowCustomer.Count() > 0)
            {
                if (request.selectCustomer?.Count == 0 || request.selectCustomer == null)
                    request.selectCustomer = allowCustomer.ToList();
            }
        }
        private async Task FilterCriteria(WarehouseOverAllRequestModel request, string warehouse = "CDC")
        {
            var allowDC = (await ss.GetAllowData(_context, "/Warehouse/GetDC", $"{{\"selectDcType\": \"{warehouse}\"}}")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowCustomer = (await ss.GetAllowData(_context, "/Warehouse/GetCustomer", $"{{\"selectwarehouse\": \"{warehouse}\"}}")).Select(c => Convert.ToString(c.DataValue_Key));
            if (allowDC.Count() > 0)
            {
                if (request.selectDc?.Count == 0 || request.selectDc == null)
                    request.selectDc = allowDC.ToList();
            }
            if (allowCustomer.Count() > 0)
            {
                if (request.selectCustomer?.Count == 0 || request.selectCustomer == null)
                    request.selectCustomer = allowCustomer.ToList();
            }
        }

        private async Task FilterCriteriaESC(WarehouseESCRequestDateModel request, string warehouse = "ESC")
        {
            var allowDC = (await ss.GetAllowData(_context, "/Warehouse/GetDC", $"{{\"selectDcType\": \"{warehouse}\"}}")).Select(c => Convert.ToInt32(c.DataValue_Key));
            var allowCustomer = (await ss.GetAllowData(_context, "/Warehouse/GetCustomer", $"{{\"selectwarehouse\": \"{warehouse}\"}}")).Select(c => Convert.ToInt32(c.DataValue_Key));
            if (allowDC.Count() > 0)
            {
                if (request.selectDc?.Count == 0 || request.selectDc == null)
                    request.selectDc = allowDC.ToList();
            }
            if (allowCustomer.Count() > 0)
            {
                if (request.selectCustomer?.Count == 0 || request.selectCustomer == null)
                    request.selectCustomer = allowCustomer.ToList();
            }
        }
        private async Task FilterCriteriaESC(WarehouseESCRequestStockModel request, string warehouse = "ESC")
        {
            var allowDC = (await ss.GetAllowData(_context, "/Warehouse/GetDC", $"{{\"selectDcType\": \"{warehouse}\"}}")).Select(c => Convert.ToInt32(c.DataValue_Key));
            var allowCustomer = (await ss.GetAllowData(_context, "/Warehouse/GetCustomer", $"{{\"selectwarehouse\": \"{warehouse}\"}}")).Select(c => Convert.ToInt32(c.DataValue_Key));
            if (allowDC.Count() > 0)
            {
                if (request.selectDc?.Count == 0 || request.selectDc == null)
                    request.selectDc = allowDC.ToList();
            }
            if (allowCustomer.Count() > 0)
            {
                if (request.selectCustomer?.Count == 0 || request.selectCustomer == null)
                    request.selectCustomer = allowCustomer.ToList();
            }
        }
        private async Task FilterCriteriaESC(WarehouseESCRequestPickPackModel request, string warehouse = "ESC")
        {
            var allowDC = (await ss.GetAllowData(_context, "/Warehouse/GetDC", $"{{\"selectDcType\": \"{warehouse}\"}}")).Select(c => Convert.ToInt32(c.DataValue_Key));
            var allowCustomer = (await ss.GetAllowData(_context, "/Warehouse/GetCustomer", $"{{\"selectwarehouse\": \"{warehouse}\"}}")).Select(c => Convert.ToInt32(c.DataValue_Key));
            if (allowDC.Count() > 0)
            {
                if (request.selectDc?.Count == 0 || request.selectDc == null)
                    request.selectDc = allowDC.ToList();
            }
            if (allowCustomer.Count() > 0)
            {
                if (request.selectCustomer?.Count == 0 || request.selectCustomer == null)
                    request.selectCustomer = allowCustomer.ToList();
            }
        }
    }
}

