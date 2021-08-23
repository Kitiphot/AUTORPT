using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLog;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Services;
//using SCG.ARS.BOI.WEB.ViewModels;

namespace SCG.ARS.BOI.WEB.Controllers {
    [Authorize]
    //[ServiceFilter (typeof (LogFilter))]
    public class TemplateMappingController : Controller {
        private readonly IHostingEnvironment _hostingEnvironment;
        static Logger logger = LogManager.GetCurrentClassLogger ();
        //MyDbContext db = new MyDbContext ();

        ClaimsPrincipal _user;
        //private string _userCode;

        private Task _startingTask;

        private ILogger<HomeController> _logger;

        private IMasterRepository _master;
        public TemplateMappingController (
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            ILogger<HomeController> logger,
            IMasterRepository master) {
            _logger = logger;
            var httpContext = httpContextAccessor.HttpContext;
            _hostingEnvironment = hostingEnvironment;
            _user = httpContext.User;
            //_userCode = _user.FindFirst(ClaimTypes.Sid).Value;

            _master = master;
        }

        [Authorize]
        public IActionResult Index () {
            if (_user == null) {
                return Redirect ("/Account/Login");
            }

            return View ();

        }

        [HttpPost]
        public ActionResult LoadSchemas () {
            try {
                var data = _master.GetSchemas ();
                return Json (new { data = data, status = true, message = "Successful" });
            } catch (Exception ex) {
                logger.Error (ex, ex.Message);
                return Json (new { status = false, message = "Fail" });
            }
        }

        public IActionResult Error () {
            // Retrieve error information in case of internal errors
            var error = HttpContext
                .Features
                .Get<IExceptionHandlerFeature> ();
            if (error == null)
                return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

            // Use the information about the exception 
            var exception = error.Error;
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}