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
        public JsonResult DamageMonthly(TransportationCriteria criteria)
        {
            try
            {
                List<TransportationDamageMonthlyModel> rawdata = _report.DamageMonthly(criteria);
                List<string> lsDate = rawdata.Select(o => o.delivery_date?.ToString("dd-MM-yyyy") ?? "").ToList();
                List<int> lsDN = rawdata.Select(o => o.total_damage).ToList();
                List<string> lsColorDN = new List<string>();
                foreach (string number in lsDate)
                {
                    lsColorDN.Add("rgba(68, 114, 196, 0.9)");
                }

                BarChartIntegerDataSet DN = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "DN",
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
                logger.Error(ex, "DamageMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult DamageYearly(TransportationCriteria criteria)
        {
            try
            {
                List<TransportationDamageYearlyModel> rawdata = _report.DamageYearly(criteria);
                List<string> lsDate = rawdata.Select(o => o.delivery_month).ToList();
                List<int> lsDN = rawdata.Select(o => o.total_damage).ToList();
                List<string> lsColorDN = new List<string>();
                foreach (string number in lsDate)
                {
                    lsColorDN.Add("rgba(68, 114, 196, 0.9)");
                }

                BarChartIntegerDataSet DN = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "DN",
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

                return Json(new {data,success = true});
            }
            catch (Exception ex)
            {
                logger.Error(ex, "DamageYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult DamageDetail(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.DamageDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "DamageDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
