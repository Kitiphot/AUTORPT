using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLog;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Models.ILB;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public partial class ReportController : Controller
    {
        static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        //Warut S.
        [HttpPost]

        public JsonResult RPTILB001_Report(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.RPTILB001_Report(request), success = true });
                return jsonResult;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB001_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]

        public JsonResult RPTILB002_Report(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.RPTILB002_Report(request), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB001_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult RPTILB003_Report(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.RPTILB003_Report(request), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB001_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]
        public JsonResult RPTILB004_Report(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.RPTILB004_Report(request), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB001_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }


        #region ILB005
        public JsonResult RPTILB005_Report(ILBRequestModel request, string dateType)
        {
            try
            {
                var jsonResult = Json(new { data = _report.RPTILB005_Report(request, dateType), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB005_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
        #endregion

        #region ILB006
        public JsonResult RPTILB006_Report(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.RPTILB006_Report(request), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB001_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
        #endregion

        [HttpPost]
        public JsonResult RPTILB007_Report(ILBRequestModel request)
        {
            try
            {
                var jsonResult = Json(new { data = _report.RPTILB007_Report(request), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB001_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }


		#region ILB008
		public JsonResult RPTILB008_Report(ILBRequestModel request, string dateType) {
			try {
				var jsonResult = Json(new { data = _report.RPTILB008_Report(request, dateType), success = true });
				return jsonResult;
			} catch (Exception ex) {
				logger.Error(ex, "RPTILB008_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
				return Json(new { data = ex.Message, success = false });
			}
		}
		#endregion


		public JsonResult RPTILB009_Report(ILBRequestModel request, string dateType) {
			try {
				var jsonResult = Json(new { data = _report.RPTILB009_Report(request, dateType), success = true });
				return jsonResult;
			} catch (Exception ex) {
				logger.Error(ex, "RPTILB009_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
				return Json(new { data = ex.Message, success = false });
			}
		}

        public JsonResult RPTILB010_Report(ILBRequestModel request, string dateType)
        {
            try
            {
                var jsonResult = Json(new { data = _report.RPTILB010_Report(request, dateType), success = true });
                return jsonResult;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RPTILB010_Report", Newtonsoft.Json.JsonConvert.SerializeObject(request));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
