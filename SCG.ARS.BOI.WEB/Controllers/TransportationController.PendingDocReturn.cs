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
        public JsonResult PendingDocReturnStatus(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.PendingDocReturnStatus(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "PendingDocReturnStatus", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult PendingDocReturnMonthly(TransportationCriteria criteria)
        {
            try
            {
                List<TransportationMonthlyModel> rawdata = _report.PendingDocReturnMonthly(criteria);
                List<string> lsDate = rawdata.Select(o => o.dn_day?.ToString("dd")??"").ToList();
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
                logger.Error(ex, "PendingDocReturnMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult PendingDocReturnByCarrier(TransportationCriteria criteria)
        {
            try
            {
                List<TransportationByCarrierModel> rawdata = _report.PendingDocReturnByCarrier(criteria);
                List<string> lsCarrier = rawdata.Select(o => o.carrier_name).ToList();
                List<int> ls0_3 = rawdata.Select(o => o.age1).ToList();
                List<int> ls4_5 = rawdata.Select(o => o.age2).ToList();
                List<int> ls6_7 = rawdata.Select(o => o.age3).ToList();
                List<int> ls8_10 = rawdata.Select(o => o.age4).ToList();
                List<int> ls10 = rawdata.Select(o => o.age5).ToList();
                List<string> lsColorDN = new List<string>();

                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(68, 114, 196, 0.9)");
                }
                BarChartIntegerDataSet range0To3 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "0-3",
                    data = ls0_3.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(237, 125, 49, 0.9)");
                }
                BarChartIntegerDataSet range4To5 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "4-5",
                    data = ls4_5.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(165, 165, 165, 0.9)");
                }
                BarChartIntegerDataSet range6To7 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "6-7",
                    data = ls6_7.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(255, 192, 0, 0.9)");
                }
                BarChartIntegerDataSet range8To10 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "8-10",
                    data = ls8_10.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(91, 155, 213, 0.9)");
                }
                BarChartIntegerDataSet range10 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = ">10",
                    data = ls10.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };
                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsCarrier.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { range0To3, range4To5, range6To7, range8To10, range10 }
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "PendingDocReturnByCarrier", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult PendingDocReturnYearly(TransportationCriteria criteria)
        {
            try
            {
                List<TransportationYearlyModel> rawdata = _report.PendingDocReturnYearly(criteria);
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
                logger.Error(ex, "PendingDocReturnYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult PendingDocReturnDetail(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.PendingDocReturnDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "PendingDocReturnDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
