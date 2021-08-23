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
        public async Task<JsonResult> OntimeSummaryMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.OntimeSummaryMonthly(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OntimeSummaryMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
        
        [HttpPost]
        public async Task<JsonResult> OntimeSummaryYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.OntimeSummaryYearly(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OntimeSummaryYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> OntimeMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationOntimeMonthlyModel> rawdata = _report.OntimeMonthly(criteria);
                List<string> lsOrderDate = rawdata.Select(o => o.order_date.ToString("dd")).ToList();
                int countData = rawdata.Count();
                //List<int> lsTotalTon= rawdata.Select(o => o.total_ton).ToList();
                List<int> lsOntimeDelivery= rawdata.Select(o => o.ontime_delivery).ToList();
                List<int> lsDelayDelivery = rawdata.Select(o => o.delay_delivery).ToList();
                List<int> lsOntimeDeliveryPercent = rawdata.Select(o => o.ontime_percent).ToList();
                List<int> lsDelayDeliveryPercent = rawdata.Select(o => o.delay_percent).ToList();
                

                List<string> lsColor = new List<string>();

                lsColor.Clear();
                foreach (string number in lsOrderDate)
                {
                    lsColor.Add("rgba(68, 114, 196, 0.9)");
                }
                BarChartIntegerDataSet deliveryOntime = new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Ontime",
                    data = lsOntimeDelivery.ToArray(),
                    backgroundColor = lsColor.ToArray(),
                    borderColor = lsColor.ToArray(),
                    borderWidth = 1
                };

                //lsColor.Clear();
                //foreach (string number in lsOrderDate)
                //{
                //    lsColor.Add("rgba(76, 214, 176, 0.9)");
                //}
                //BarChartIntegerDataSet deliveryDelay = new BarChartIntegerDataSet()
                //{
                //    type = "line",
                //    label = "Delay",
                //    data = lsDelayDelivery.ToArray(),
                //    backgroundColor = lsColor.ToArray(),
                //    borderColor = lsColor.ToArray(),
                //    borderWidth = 1
                //};                
                
                //lsColor.Clear();
                //foreach (string number in lsOrderDate)
                //{
                //    lsColor.Add("rgba(235, 214, 82, 0.9)");
                //}

                //BarChartIntegerDataSet deliveryOntimePercent = new BarChartIntegerDataSet()
                //{
                //    type = "line",
                //    label = "% Ontime",
                //    data = lsOntimeDeliveryPercent.ToArray(),
                //    backgroundColor = lsColor.ToArray(),
                //    borderColor = lsColor.ToArray(),
                //    //yAxisID = "left-axis",
                //    borderWidth = 1
                //};

                //lsColor.Clear();
                //foreach (string number in lsOrderDate)
                //{
                //    lsColor.Add("rgba(230, 117, 41, 0.9)");
                //}
                //BarChartIntegerDataSet deliveryDelayPercent = new BarChartIntegerDataSet()
                //{
                //    type = "line",
                //    label = "% Delay",
                //    data = lsDelayDeliveryPercent.ToArray(),
                //    backgroundColor = lsColor.ToArray(),
                //    borderColor = lsColor.ToArray(),
                //    //yAxisID = "right-axis",
                //    borderWidth = 1
                //};

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsOrderDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { deliveryOntime },
                    countData = countData
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OntimeMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> OntimeYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationOntimeYearlyModel> rawdata = _report.OntimeYearly(criteria);
                List<string> lsOrderMonth = rawdata.Select(o => o.order_month).ToList();
                int countData = rawdata.Count();
                //List<int> lsTotalTon = rawdata.Select(o => o.total_ton).ToList();
                List<int> lsOntimeDelivery = rawdata.Select(o => o.ontime_delivery).ToList();
                List<int> lsDelayDelivery = rawdata.Select(o => o.delay_delivery).ToList();
                List<int> lsOntimeDeliveryPercent = rawdata.Select(o => o.ontime_percent).ToList();
                List<int> lsDelayDeliveryPercent = rawdata.Select(o => o.delay_percent).ToList();


                List<string> lsColor = new List<string>();

                lsColor.Clear();
                foreach (string number in lsOrderMonth)
                {
                    lsColor.Add("rgba(68, 114, 196, 0.9)");
                }
                BarChartIntegerDataSet deliveryOntime = new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Ontime",
                    data = lsOntimeDelivery.ToArray(),
                    backgroundColor = lsColor.ToArray(),
                    borderColor = lsColor.ToArray(),
                    //yAxisID = "left-axis",
                    borderWidth = 1
                };

                //lsColor.Clear();
                //foreach (string number in lsOrderMonth)
                //{
                //    lsColor.Add("rgba(76, 214, 176, 0.9)");
                //}
                //BarChartIntegerDataSet deliveryDelay = new BarChartIntegerDataSet()
                //{
                //    type = "line",
                //    label = "Delay",
                //    data = lsDelayDelivery.ToArray(),
                //    backgroundColor = lsColor.ToArray(),
                //    borderColor = lsColor.ToArray(),
                //    //yAxisID = "left-axis",
                //    borderWidth = 1
                //};

                //lsColor.Clear();
                //foreach (string number in lsOrderMonth)
                //{
                //    lsColor.Add("rgba(235, 214, 82, 0.9)");
                //}

                //BarChartIntegerDataSet deliveryOntimePercent = new BarChartIntegerDataSet()
                //{
                //    type = "line",
                //    label = "% Ontime",
                //    data = lsOntimeDeliveryPercent.ToArray(),
                //    backgroundColor = lsColor.ToArray(),
                //    borderColor = lsColor.ToArray(),
                //    //yAxisID = "right-axis",
                //    borderWidth = 1
                //};

                //lsColor.Clear();
                //foreach (string number in lsOrderMonth)
                //{
                //    lsColor.Add("rgba(230, 117, 41, 0.9)");
                //}
                //BarChartIntegerDataSet deliveryDelayPercent = new BarChartIntegerDataSet()
                //{
                //    type = "line",
                //    label = "% Delay",
                //    data = lsDelayDeliveryPercent.ToArray(),
                //    backgroundColor = lsColor.ToArray(),
                //    borderColor = lsColor.ToArray(),
                //    //yAxisID = "right-axis",
                //    borderWidth = 1
                //};

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsOrderMonth.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { deliveryOntime},
                    countData = countData
                };

                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OntimeYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }


        [HttpPost]
        public async Task<JsonResult> OntimeMonthlyDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.OntimeMonthlyDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OntimeMonthlyDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> OntimeYearlyDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.OntimeYearlyDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OntimeYearlyDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

    }
}
