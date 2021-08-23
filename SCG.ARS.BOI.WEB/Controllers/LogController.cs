using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using SCG.ARS.BOI.WEB.Repositories;

namespace SCG.ARS.BOI.WEB.Controllers
{

    [Authorize]
    public class LogController : Controller
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        private ILogger<LogController> _logger;
        private readonly HttpContext _context;
        private ILogRepository _data;
        private readonly IHostingEnvironment _hostingEnvironment;
        public LogController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            ILogRepository data)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _data = data;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoadData(DateTime? created_date, string level)
        {
            try
            {
                var data = _data.GetLogs(created_date, level);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Clear()
        {
            var status = false;
            var message = string.Empty;
            try
            {
                (status, message) = await _data.ClearLog();
                return Json(new { status = status, message = message });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = ex.Message });
            }
        }
    }
}