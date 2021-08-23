using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public partial class ReportChartController : Controller
    {

        private readonly HttpContext _context;
        private IReportRepository _report;
        private readonly IHostingEnvironment _hostingEnvironment;
        public ReportChartController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IReportRepository report)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _report = report;
        }
        public ActionResult Index(){
            return View();
        }

        // GET: ReportChart
        public ActionResult ReportChart()
        {
            DateTime startDateTime = DateTime.Now;

            var cs = "Host=qa-datalake-pg.cluster-ctg0nvlybzpq.ap-southeast-1.rds.amazonaws.com; Username =liluna_datalake; Password =Liluna@SCGL; Database =pd_datalake";
            var con = new NpgsqlConnection(cs);
            con.Open();

            #region old
            ////SM_Tender
            //var sql_SM_Tender = "select* from dom.\"Reporting_SM_Tender\"";
            //var cmd_SM_Tender = new NpgsqlCommand(sql_SM_Tender, con);
            //var dr_SM_Tender = cmd_SM_Tender.ExecuteScalar();

            ////SM_Accept
            //var sql_SM_Accept = "select* from dom.\"Reporting_SM_Accept\"";
            //var cmd_SM_Accept = new NpgsqlCommand(sql_SM_Accept, con);
            //var dr_SM_Accept = cmd_SM_Accept.ExecuteScalar();

            ////SM_Inbound
            //var sql_SM_Inbound = "select* from dom.\"Reporting_SM_Inbound\"";
            //var cmd_SM_Inbound = new NpgsqlCommand(sql_SM_Inbound, con);
            //var dr_SM_Inbound = cmd_SM_Inbound.ExecuteScalar();

            ////SM_GI
            //var sql_SM_GI = "select* from dom.\"Reporting_SM_GI\"";
            //var cmd_SM_GI = new NpgsqlCommand(sql_SM_GI, con);
            //var dr_SM_GI = cmd_SM_GI.ExecuteScalar();
            #endregion

            var sql_SM_status = "select* from dom.\"Reporting_SM_Status\"";
            var cmd_SM_status = new NpgsqlCommand(sql_SM_status, con);
            NpgsqlDataReader dr_SM_status = cmd_SM_status.ExecuteReader();

            string SM_Tender = string.Empty;
            string SM_Accept = string.Empty;
            string SM_Inbound = string.Empty;
            string SM_GI = string.Empty;

            while (dr_SM_status.Read())
            {
               SM_Tender = dr_SM_status[0].ToString();
               SM_Accept = dr_SM_status[1].ToString();
               SM_Inbound = dr_SM_status[2].ToString();
               SM_GI = dr_SM_status[3].ToString();
            }
            dr_SM_status.Close();

            con.Close();

            DateTime endDateTime = DateTime.Now;

            ViewBag.SM_Tender = SM_Tender;
            ViewBag.SM_Accept = SM_Accept;
            ViewBag.SM_Inbound = SM_Inbound;
            ViewBag.SM_GI = SM_GI;

            ViewBag.PROCESSINGTIME = Math.Round((endDateTime - startDateTime).TotalSeconds,1);

            return View();
        }
        public ActionResult ReportChartTest()
        {
            return View();
        }
        public ActionResult ReportChartTest2()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetData()
        {
            #region old
            var cs = "Host=qa-datalake-pg.cluster-ctg0nvlybzpq.ap-southeast-1.rds.amazonaws.com; Username =liluna_datalake; Password =Liluna@SCGL; Database =pd_datalake";
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "select * from dom.\"Reporting_MonthlySummary2\"";
            var cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            List<double> lsTotalSM = new List<double>();
            List<double> lsTotalWeight = new List<double>();
            List<string> lsLabel = new List<string>();
            List<string> lsbgcolorTotalSM = new List<string>();
            List<string> lsbdcolorTotalSM = new List<string>();
            List<string> lsbgcolorTotalWeight = new List<string>();
            List<string> lsbdcolorTotalWeight = new List<string>();

            string c1 = "rgba(255, 99, 132, 0.2)";
            string c2 = "rgba(54, 162, 235, 0.2)";
            // string c3 = "rgba(255, 206, 86, 0.2)";
            // string c4 = "rgba(75, 192, 192, 0.2)";
            // string c5 = "rgba(153, 102, 255, 0.2)";
            // string c6 = "rgba(255, 159, 64, 0.2)";

            while (dr.Read())
            {
                lsLabel.Add(dr[0].ToString());

                if(!string.IsNullOrEmpty(dr[2].ToString())) lsTotalSM.Add(Convert.ToInt32(dr[2].ToString()));
                if (!string.IsNullOrEmpty(dr[2].ToString())) lsTotalWeight.Add(Convert.ToDouble(dr[3]));

                lsbgcolorTotalSM.Add(c1);
                lsbdcolorTotalSM.Add(c1);

                lsbgcolorTotalWeight.Add(c2);
                lsbdcolorTotalWeight.Add(c2);
            }


            //Mock the data
            BarChartDataSet datasetTotalSM = new BarChartDataSet()
            {
                type = "bar",
                label = "จำนวน Shipment",
                data = lsTotalSM.ToArray(),
                backgroundColor = lsbgcolorTotalSM.ToArray(),
                borderColor = lsbdcolorTotalSM.ToArray(),
                borderWidth = 1
            };

            BarChartDataSet datasetTotalWeight = new BarChartDataSet()
            {
                type = "bar",
                label = "จำนวน Volumn (x 100 Ton.)",
                data = lsTotalWeight.ToArray(),
                backgroundColor = lsbgcolorTotalWeight.ToArray(),
                borderColor = lsbdcolorTotalWeight.ToArray(),
                borderWidth = 1
            };

            BarChartData data = new BarChartData()
            {
                labels = lsLabel.ToArray(),
                datasets = new BarChartDataSet[] { datasetTotalSM, datasetTotalWeight }
            };

            return Json(data);
            #endregion
        }
        [HttpPost]
        public JsonResult RPTCDC001_RecivingReportChart(WarehouseRequestModel request)
        {
            List<RPTCDC001ReceivingChartViewModel> rawdata = _report.RPTCDC001_RecivingReportChart(request.selectStartDate, request.selectEndDate,request.selectCustomer);

            List<string> lsDate = rawdata.Select(o => o.receiveddate?.ToString("yyyy/MM/dd") ?? "").ToList();
            List<double> lsQty = rawdata.Select(o => o.qty_in_ewm).ToList();
            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<double> valueTH = new List<double>();
            foreach (string number in lsDate)
            {
                valueTH.Add(10000);
                lsbgcolorQty.Add("rgba(19, 171, 14,0.5");
                lsbdcolorQty.Add("rgba(51, 255, 88,0.5)");
                lsbgcolorQty2.Add("rgba(252, 186, 3,1)");
                lsbdcolorQty2.Add("rgba(252, 186, 3,1)");
            }
            
            //Mock the data
            BarChartDataSet datasetQty = new BarChartDataSet()
            {
                type = "bar",
                label = "Receving (Pc./Day)",
                data = lsQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1
            };

            BarChartDataSet datasetQty2 = new BarChartDataSet()
            {
                type = "line",
                label = "Receving (Pc./Day)",
                data = lsQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 2
            };
            //foreach a in b
            //    {
            //    color = Random color 
            //    List<BarChartDataSet> chartlist = new BarChartDataSet()
            //    {
            //        type : fix
            //        label loop by a
            //        data = rawdata column 1.Select where a , rawdata column 2.select where a 
            //        color = color 

            //    }

            //    }
            BarChartData data = new BarChartData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartDataSet[] { datasetQty2 , datasetQty }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public JsonResult RPT001_GRGIReportChart(string selectyear, string selectmonth, string reporttype)
        {
            List<RPT001GRGIReportViewModel> rawdata = _report.RPT001_GRGIReports();

            List<RPT002PROSTAReportViewModel> rawdata2 = _report.RPT002_PROSTAReports();

            List<string> lsProduct = rawdata2.Select(o => o.product_name).ToList();

            //List<string> lsDate = rawdata.Select(o => o.receiveddate.ToString("yyyy/MM/dd")).ToList();
            List<string> lsCustomer = rawdata.Select(o => o.customer_name).ToList();
            List<double> lsGRQty = rawdata.Select(o => o.gr_quantity).ToList();
            List<double> lsGIQty = rawdata.Select(o => o.gi_quantity).ToList();
            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<double> valueTH = new List<double>();
            foreach (string number in lsCustomer)
            {
                valueTH.Add(10000);
                lsbgcolorQty.Add("rgba(19, 171, 14,0.5");
                lsbdcolorQty.Add("rgba(51, 255, 88,0.5)");
                lsbgcolorQty2.Add("rgba(255, 99, 132, 0.5)");
                lsbdcolorQty2.Add("rgba(255, 99, 132, 0.5)");
            }

            //Mock the data
            BarChartDataSet datasetGRQty = new BarChartDataSet()
            {
                type = "bar",
                label = "GR",
                data = lsGRQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty.ToArray(),
                borderColor = lsbdcolorQty.ToArray(),
                borderWidth = 1
            };

            BarChartDataSet datasetGIQty = new BarChartDataSet()
            {
                type = "line",
                label = "GI",
                data = lsGIQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgcolorQty2.ToArray(),
                borderColor = lsbdcolorQty2.ToArray(),
                borderWidth = 2
            };
            BarChartData data = new BarChartData()
            {
                labels = lsCustomer.ToArray(),
                datasets = new BarChartDataSet[] { datasetGRQty, datasetGIQty }
            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }      

    }
}