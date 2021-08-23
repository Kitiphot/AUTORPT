using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using SCG.ARS.BOI.WEB.Attributes;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Security;

namespace SCG.ARS.BOI.WEB.Controllers {
    public partial class TransportationController : Controller
    {
        private readonly HttpContext _context;
        private IReportRepository _report;
        private ILogger<TransportationController> _logger;
        static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        private readonly ISecurityService ss;
        public TransportationController(IHttpContextAccessor httpContextAccessor,
            IReportRepository report,
            ILogger<TransportationController> logger,
            ISecurityService ss)
        {
            _context = httpContextAccessor.HttpContext;
            _report = report;
            _logger = logger;
            this.ss = ss;
        }
        public IActionResult Index () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_001, Permission.View)]
        public IActionResult WEB_LPC_001 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_002, Permission.View)]
        public IActionResult WEB_LPC_002 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_003, Permission.View)]
        public IActionResult WEB_LPC_003 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_004, Permission.View)]
        public IActionResult WEB_LPC_004 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_005, Permission.View)]
        public IActionResult WEB_LPC_005 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_006, Permission.View)]
        public IActionResult WEB_LPC_006 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_007, Permission.View)]
        public IActionResult WEB_LPC_007 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_008, Permission.View)]
        public IActionResult WEB_LPC_008 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_009, Permission.View)]
        public IActionResult WEB_LPC_009 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_010, Permission.View)]
        public IActionResult WEB_LPC_010 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_011, Permission.View)]
        public IActionResult WEB_LPC_011 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_012, Permission.View)]
        public IActionResult WEB_LPC_012 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_013, Permission.View)]
        public IActionResult WEB_LPC_013 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_LPC_014, Permission.View)]
        public IActionResult WEB_LPC_014()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_015, Permission.View)]
        public IActionResult WEB_LPC_015()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_016, Permission.View)]
        public IActionResult WEB_LPC_016()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_017, Permission.View)]
        public IActionResult WEB_LPC_017()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_018, Permission.View)]
        public IActionResult WEB_LPC_018()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_019, Permission.View)]
        public IActionResult WEB_LPC_019()
        {
            return View();
        }

        [WebAuthorize(ScreenID.WEB_LPC_020, Permission.View)]
        public IActionResult WEB_LPC_020()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_021, Permission.View)]
        public IActionResult WEB_LPC_021()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_022, Permission.View)]
        public IActionResult WEB_LPC_022()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_023, Permission.View)]
        public IActionResult WEB_LPC_023()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_024, Permission.View)]
        public IActionResult WEB_LPC_024()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_LPC_025, Permission.View)]
        public IActionResult WEB_LPC_025()
        {
            return View();
        }
        //[WebAuthorize(ScreenID.WEB_LPC_025, Permission.View)]
        public IActionResult WEB_LPC_026()
        {
            return View();
        }        
        
        public IActionResult WEB_LPC_027()
        {
            return View();
        }

        public IActionResult WEB_LPC_028()
        {
            return View();
        }

        //[WebAuthorize(ScreenID.TransportSummary, Permission.View)]
        public IActionResult Summary() {
            return View();
        }

        private async Task FilterCriteria(TransportationCriteria request)
        {
            var allowBusiness = (await ss.GetAllowData(_context, "/Report/GetBusiness")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowFleet= (await ss.GetAllowData(_context, "/Report/GetFleet")).Select(c => Convert.ToInt32(c.DataValue_Key));
            var allowCustomer= (await ss.GetAllowData(_context, "/Report/GetCustomerTransport")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowShippingPoint = (await ss.GetAllowData(_context, "/Report/GetShippingPoint")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowShipToRegion = (await ss.GetAllowData(_context, "/Report/GetShiptoRegion")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowMatGroup = (await ss.GetAllowData(_context, "/Report/GetMatfrg")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowOrderType = (await ss.GetAllowData(_context, "/Report/GetOrderType")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowTruckType = (await ss.GetAllowData(_context, "/Report/GetTruckType")).Select(c => Convert.ToString(c.DataValue_Key));
            var allowPlannerName = (await ss.GetAllowData(_context, "/Report/GetPlannerName")).Select(c => Convert.ToString(c.DataValue_Key));

            if (allowBusiness.Count() > 0)
            {
                if (request.business?.Count == 0 || request.business == null)
                    request.business = allowBusiness.ToList();
            }
            if (allowFleet.Count() > 0)
            {
                if (request.fleet?.Count == 0 || request.fleet == null)
                    request.fleet = allowFleet.ToList();
            }
            if (allowCustomer.Count() > 0)
            {
                if (request.customer?.Count == 0 || request.customer == null)
                    request.customer = allowCustomer.ToList();
            }
            if (allowShippingPoint.Count() > 0)
            {
                if (request.shippingPoint?.Count == 0 || request.shippingPoint == null)
                    request.shippingPoint = allowShippingPoint.ToList();
            }
            if (allowShipToRegion.Count() > 0)
            {
                if (request.shipToRegion?.Count == 0 || request.shipToRegion == null)
                    request.shipToRegion = allowShipToRegion.ToList();
            }
            if (allowMatGroup.Count() > 0)
            {
                if (request.matGroup?.Count == 0 || request.matGroup== null)
                    request.matGroup = allowMatGroup.ToList();
            }
            if (allowOrderType.Count() > 0)
            {
                if (request.orderType?.Count == 0 || request.orderType == null)
                    request.orderType = allowOrderType.ToList();
            }
            if (allowTruckType.Count() > 0)
            {
                if (request.truckType?.Count == 0 || request.truckType == null)
                    request.truckType = allowTruckType.ToList();
            }
            if (allowPlannerName.Count() > 0)
            {
                if (request.plannerName?.Count == 0 || request.plannerName == null)
                    request.plannerName = allowPlannerName.ToList();
            }
        }

        //public async Task<IActionResult> ListPartial()
        //{
        //    var store = await _report.ListAsync();
        //    var models = store
        //      .Where(u => u.Totalrows == null)
        //      .OrderBy(u => u.GIDate);
        //    var total = store.FirstOrDefault(u => u.Totalrows != null)?.Totalrows ?? "0";
        //    return Json(new { data = total, success = true });
        //}
    }
}