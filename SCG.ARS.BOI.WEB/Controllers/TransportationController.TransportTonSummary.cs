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
        public async Task<JsonResult> TonSummaryMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.TonSummaryMonthly(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ShipmentSummary", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }        
        
        [HttpPost]
        public async Task<JsonResult> TonSummaryYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.TonSummaryYearly(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ShipmentSummary", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> TonMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationPerformanceMonthlyModel> rawdata = _report.TonMonthly(criteria);
                List<string> lsShipmentDate = rawdata.Select(o => o.shipment_date.ToString("dd")).ToList();
                int countData = rawdata.Count();
                //List<int> lsTotalTon= rawdata.Select(o => o.total_ton).ToList();
                List<int> lsDeliveryTon= rawdata.Select(o => o.delivery).ToList();
                

                List<string> lsColor = new List<string>();

                lsColor.Clear();
                foreach (string number in lsShipmentDate)
                {
                    lsColor.Add("rgba(68, 114, 196, 0.9)");
                }
                BarChartIntegerDataSet deliveryTon= new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Actual",
                    data = lsDeliveryTon.ToArray(),
                    backgroundColor = lsColor.ToArray(),
                    borderColor = lsColor.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsShipmentDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { deliveryTon},
                    countData = countData
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "TonMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> TonYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationPerformanceYearlyModel> rawdata = _report.TonYearly(criteria);
                List<string> lsShipmentMonth = rawdata.Select(o => o.shipment_month).ToList();
                int countData = rawdata.Count();
                //List<int> lsTotalTon = rawdata.Select(o => o.total_ton).ToList();
                List<int> lsDeliveryTon = rawdata.Select(o => o.delivery).ToList();


                List<string> lsColor = new List<string>();


                //lsColor.Clear();
                //foreach (string number in lsShipmentMonth)
                //{
                //    lsColor.Add("rgba(68, 255, 196, 0.9)");
                //}

                lsColor.Clear();
                foreach (string number in lsShipmentMonth)
                {
                    lsColor.Add("rgba(68, 114, 196, 0.9)");
                }
                BarChartIntegerDataSet deliveryTon= new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Actual",
                    data = lsDeliveryTon.ToArray(),
                    backgroundColor = lsColor.ToArray(),
                    borderColor = lsColor.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsShipmentMonth.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { deliveryTon},
                    countData = countData
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ShipmentYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }


        [HttpPost]
        public async Task<JsonResult> TonMonthlyDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.TonMonthlyDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "TonMonthlyDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> TonYearlyDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.TonYearlyDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "TonYearlyDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

    }
}
