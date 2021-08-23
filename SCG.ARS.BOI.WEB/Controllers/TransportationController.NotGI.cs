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
        public JsonResult NotGIStatus(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.NotGIStatus(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotGIStatus", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult NotGIMonthly(TransportationCriteria criteria)
        {
            try
            {
                List<TransportationMonthlyModel> rawdata = _report.NotGIMonthly(criteria);
                List<string> lsDate = rawdata.Select(o => o.dn_day?.ToString("dd") ?? "").ToList();
                List<int> lsDN = rawdata.Select(o => o.total_dn).ToList();
                List<string> lsColorDN = new List<string>();
                foreach (string number in lsDate)
                {
                    lsColorDN.Add("rgba(68, 114, 196, 0.9)");
                }

                BarChartIntegerDataSet DN = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Shipment",
                    data = lsDN.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };
                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { DN }
                };
                return Json(new { data, success = true } );
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotGIMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult NotGIYearly(TransportationCriteria criteria)
        {
            try
            {
                List<TransportationYearlyModel> rawdata = _report.NotGIYearly(criteria);
                List<string> lsDate = rawdata.Select(o => o.dn_month).ToList();
                List<int> lsDN = rawdata.Select(o => o.total_dn).ToList();
                List<string> lsColorDN = new List<string>();
                foreach (string number in lsDate)
                {
                    lsColorDN.Add("rgba(68, 114, 196, 0.9)");
                }

                BarChartIntegerDataSet DN = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Shipment",
                    data = lsDN.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };
                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { DN }
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotGIYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult NotGIDetail(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.NotGIDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotGIDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
