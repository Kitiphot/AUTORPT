using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public partial class TransportationController
    {
        [HttpPost]
        public JsonResult OrderMonitoringStatus(OrderMonitoringCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.OrderMonitoringStatus(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OrderMonitoringStatus", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]
        public JsonResult OrderMonitoringSummary(OrderMonitoringCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.OrderMonitoringSummary(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OrderMonitoringSummary", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]
        public JsonResult OrderMonitoringByHub(OrderMonitoringCriteria criteria)
        {
            try
            {
                var data = _report.OrderMonitoringByHub(criteria).Where(o => o.location_type.Equals("2")).ToList();
                var dataOtherType = _report.OrderMonitoringByHub(criteria).Where(o => !o.location_type.Equals("2")).ToList();
                return Json(new { data , dataOtherType, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OrderMonitoringByHub", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]
        public JsonResult OrderMonitoringShipment(OrderMonitoringCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.OrderMonitoringShipment(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OrderMonitoringShipment", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]
        public JsonResult Carrier()
        {
            try
            {
                return Json(new { data = _report.GetCarrier(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Carrier");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult ReturnOrderMonitoringStatus(OrderMonitoringCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.ReturnOrderMonitoringStatus(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ReturnOrderMonitoringStatus", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]
        public JsonResult ReturnOrderMonitoringByHub(OrderMonitoringCriteria criteria)
        {
            try
            {
                var data = _report.ReturnOrderMonitoringByHub(criteria).Where(o => o.location_type.Equals("2")).ToList();
                var dataOtherType = _report.ReturnOrderMonitoringByHub(criteria).Where(o => !o.location_type.Equals("2")).ToList();
                return Json(new { data, dataOtherType, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ReturnOrderMonitoringByHub", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]
        public JsonResult ReturnOrderMonitoringShipment(OrderMonitoringCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.ReturnOrderMonitoringShipment(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ReturnOrderMonitoringShipment", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
