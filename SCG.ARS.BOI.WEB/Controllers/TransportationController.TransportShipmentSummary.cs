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
        public async Task<JsonResult> ShipmentSummaryMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.ShipmentSummaryMonthly(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ShipmentSummary", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }        
        
        [HttpPost]
        public async Task<JsonResult> ShipmentSummaryYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.ShipmentSummaryYearly(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ShipmentSummary", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> ShipmentMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationPerformanceMonthlyModel> rawdata = _report.ShipmentMonthly(criteria);
                List<string> lsShipmentDate = rawdata.Select(o => o.shipment_date.ToString("dd")).ToList();
                int countData = rawdata.Count();
                List<int> lsDeliveryShipment = rawdata.Select(o => o.delivery).ToList();
                

                List<string> lsColor = new List<string>();

                lsColor.Clear();
                foreach (string number in lsShipmentDate)
                {
                    lsColor.Add("rgba(68, 114, 196, 0.9)");
                }
                BarChartIntegerDataSet deliveryShipment = new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Actual",
                    data = lsDeliveryShipment.ToArray(),
                    backgroundColor = lsColor.ToArray(),
                    borderColor = lsColor.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsShipmentDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { deliveryShipment },
                    countData = countData
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ShipmentMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> ShipmentYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationPerformanceYearlyModel> rawdata = _report.ShipmentYearly(criteria);
                List<string> lsShipmentDate = rawdata.Select(o => o.shipment_month).ToList();
                int countData = rawdata.Count();
                List<int> lsDeliveryShipment = rawdata.Select(o => o.delivery).ToList();


                List<string> lsColor = new List<string>();

                lsColor.Clear();
                foreach (string number in lsShipmentDate)
                {
                    lsColor.Add("rgba(68, 114, 196, 0.9)");
                }
                BarChartIntegerDataSet deliveryShipment = new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Actual",
                    data = lsDeliveryShipment.ToArray(),
                    backgroundColor = lsColor.ToArray(),
                    borderColor = lsColor.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsShipmentDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { deliveryShipment },
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
        public async Task<JsonResult> ShipmentMonthlyDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.ShipmentMonthlyDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotDNDetailMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> ShipmentYearlyDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.ShipmentYearlyDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotDNDetailYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

    }
}
