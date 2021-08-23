using System;
using System.Collections.Generic;
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
using SCG.ARS.BOI.WEB.Security;

namespace SCG.ARS.BOI.WEB.Controllers {
    public partial class ReportController : Controller {
        // GET: Report

        //All Report Index
        private readonly HttpContext _context;
        private IReportRepository _report;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ISecurityService ss;
        public ReportController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IReportRepository report,
            ISecurityService ss)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _report = report;
            this.ss = ss;
        }

        #region Report View
        public ActionResult Index () {
            return View ();
        }

        public ActionResult Report () {
            DateTime startDateTime = DateTime.Now;

            DateTime endDateTime = DateTime.Now;

            ViewBag.PROCESSINGTIME = Math.Round ((endDateTime - startDateTime).TotalSeconds, 1);

            return View ();
        }
        public ActionResult ReportTest () {
            return View ();
        }
        public ActionResult Report_LPC010 () {
            DateTime startDateTime = DateTime.Now;

            DateTime endDateTime = DateTime.Now;

            ViewBag.PROCESSINGTIME = Math.Round ((endDateTime - startDateTime).TotalSeconds, 1);

            return View ();
        }
        public ActionResult Report_LPC007 () {
            DateTime startDateTime = DateTime.Now;

            DateTime endDateTime = DateTime.Now;

            ViewBag.PROCESSINGTIME = Math.Round ((endDateTime - startDateTime).TotalSeconds, 1);

            return View ();
        }
        public ActionResult Report_LPC004 () {
            DateTime startDateTime = DateTime.Now;

            DateTime endDateTime = DateTime.Now;

            ViewBag.PROCESSINGTIME = Math.Round ((endDateTime - startDateTime).TotalSeconds, 1);

            return View ();
        }

        public ActionResult RPT002()
        {
            return View();
        }
        public ActionResult Report_LPC004_Fly_Ash () {
            return View ();
        }
        public ActionResult Report_LPC004_LPC_FIX_ALL_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_LPC_FIX_M1_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_LPC_FIX_M2_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_LPC_FIX_M3_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_LPC_FIX_M4_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_LPC_FIX_M5_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_LPC_FIX_M6_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_LPC_FIX_MA_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_Mortar_Bulk_FLEET_SRB () {
            return View ();
        }
        public ActionResult Report_LPC004_Mortar_Bulk_FLEET_TS () {
            return View ();
        }
        public ActionResult Report_LPC004_PFA_PPD () {
            return View ();
        }
        public ActionResult Report_LPC004_Cement_Bulk_PPD () {
            return View ();
        }
        public ActionResult Report_LPC004_Cement_Bulk_SRC () {
            return View ();
        }
        public ActionResult Report_LPC004_Cement_White_Bulk () {
            return View ();
        }
        public ActionResult Report_LPC004_Cement_Bulk_TS () {
            return View ();
        }
        public ActionResult Report_LPC004_KCL () {
            return View ();
        }
        public ActionResult Report_LPC004_Mortar_Bulk_FLEET_KW () {
            return View ();
        }
        public ActionResult Report_LPC004_Cement_Bulk_FLEET_LP () {
            return View ();
        }
        public ActionResult Report_LPC004_Cementh_Rajasri () {
            return View ();
        }
        public ActionResult Report_LPC004_Barite () {
            return View ();
        }

        public ActionResult Report_LPC010_All () {
            return View ();
        }

        #endregion

        //RecievingReport

        [HttpPost]
        public JsonResult RPTCDC001_RecivingReport(WarehouseCDCRequestDateModel request)
        {
            var jsonResult = Json(new { data = _report.RPTCDC001_RecivingReport(request) });
            
            return jsonResult;
        }

        [HttpPost]
        public JsonResult RPT001_GRGIReport(string selectyear, string selectmonth, string selectday, int selectcustomer)
        {
            var jsonResult = Json(new { data = _report.RPT001_GRGIReports() });

            return jsonResult;
        }

        [HttpPost]
        public JsonResult RPTCDC004_InventoryInquiryReport(WarehouseRequestModel request)
        {
            var jsonResult = Json(new { data = _report.RPTCDC004_InventoryInquiryReport(request.selectStartDate, request.selectEndDate, request.selectCustomer) });

            return jsonResult;
        }


        [HttpPost]
        public async Task<ActionResult> GetCustomer(string selectwarehouse,List<string> selectDc)
        {
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTWH_GetCustomer(selectwarehouse,selectDc);
                return Json(new { status = isSuccess, data = data, message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetBusiness(TransportationRequestCommonModel input)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetBusiness(input);

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
        public async Task<ActionResult> GetCustomerTransport(string[] customerCode,string customer)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetCustomer(customerCode, customer);

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
        public async Task<ActionResult> GetFleet(TransportationRequestCommonModel input)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetFleet(input);
                if(data.Count() == 0)
                {
                    input.selectBusiness = new List<string>();
                    input.selectMatfreight = new List<string>();
                    input.selectFleet = new List<int>();
                    input.selectRegion = new List<string>();
                    input.selectShippingpoint = new List<string>();
                    (isSuccess, data) = await _report.RPTLPC_GetFleet(input);
                }
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
        public async Task<ActionResult> GetShippingPoint(TransportationRequestCommonModel input)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetShippingPoint(input);
                if (data.Count() == 0)
                {
                    input.selectBusiness = new List<string>();
                    input.selectMatfreight = new List<string>();
                    input.selectFleet = new List<int>();
                    input.selectRegion = new List<string>();
                    input.selectShippingpoint = new List<string>();
                    (isSuccess, data) = await _report.RPTLPC_GetShippingPoint(input);
                }

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
        public async Task<ActionResult> GetShiptoRegion(TransportationRequestCommonModel input)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetShiptoRegion(input);
                if(data.Count()==0)
                {
                    input.selectBusiness = new List<string>();
                    input.selectMatfreight = new List<string>();
                    input.selectFleet = new List<int>();
                    input.selectRegion = new List<string>();
                    input.selectShippingpoint = new List<string>();
                    (isSuccess, data) = await _report.RPTLPC_GetShiptoRegion(input);
                }
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
        public async Task<ActionResult> GetMatfrg(TransportationRequestCommonModel input)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetMatfrg(input);

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
        public async Task<ActionResult> GetOrderType(string selectOrderTypeName)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetOrderType(selectOrderTypeName);

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
        public async Task<ActionResult> GetTruckType(string selectEquipmentTypeCode)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetTruckType(selectEquipmentTypeCode);

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
        public async Task<ActionResult> GetPlannerName(string selectPlannerName)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetPlannerName(selectPlannerName);

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
        public async Task<ActionResult> GetOrderPlannerName(string selectPlannerName)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetOrderPlannerName(selectPlannerName);

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
        public async Task<ActionResult> GetPlannerCombo(string selectPlannerName,string term)
        {
            //var allowData = await ss.GetAllowDataTest(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataTestComboModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetOrderPlannerNameTest(selectPlannerName,term);
                return Json(new { status = isSuccess, data = data,data_count = data.Count(), message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetCustomerCombo(string selectCustomer,string term)
        {
            //var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTLPC_GetCustomerTest(selectCustomer,term);

                return Json(new { status = isSuccess, data = data ,data_count = data.Count(), message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }
    }
}