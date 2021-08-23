using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB.Attributes;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;

namespace SCG.ARS.BOI.WEB.Controllers {
    public class ESCController : Controller {

        private readonly HttpContext _context;
        private IReportRepository _report;
        private readonly IHostingEnvironment _hostingEnvironment;
        public ESCController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IReportRepository report)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _report = report;
        }
        public IActionResult Index () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_ESC_001, Permission.View)]
        public IActionResult WEB_ESC_001 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_ESC_002, Permission.View)]
        public IActionResult WEB_ESC_002 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_ESC_003, Permission.View)]
        public IActionResult WEB_ESC_003 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_ESC_004, Permission.View)]
        public IActionResult WEB_ESC_004 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_ESC_005, Permission.View)]
        public IActionResult WEB_ESC_005 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_ESC_006, Permission.View)]
        public IActionResult WEB_ESC_006 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_ESC_007, Permission.View)]
        public IActionResult WEB_ESC_007 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_ESC_012, Permission.View)]
        public IActionResult WEB_ESC_012()
        {
            return View();
        }



        [HttpPost]
        public JsonResult RPTESC003_InventoryInquiryReport(WarehouseRequestModel request)
        {
            var jsonResult = Json(new { data = _report.RPTESC003_InventoryInquiryReport(request.selectStartDate, request.selectEndDate, request.selectCustomer) });

            return jsonResult;
        }

        [HttpPost]
        public JsonResult RPTESC004_CheckMoveReport(WarehouseESCRequestDateModel request)
        {
            var jsonResult = Json(new { data = _report.RPTESC004_CheckMoveReport(request) });

            return jsonResult;
        }

    }
}