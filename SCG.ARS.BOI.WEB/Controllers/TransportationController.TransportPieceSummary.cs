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
        public async Task<JsonResult> PieceSummaryMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.PieceSummaryMonthly(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "PieceSummaryMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }        
        
        [HttpPost]
        public async Task<JsonResult> PieceSummaryYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.PieceSummaryYearly(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "PieceSummaryYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> PieceMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationPerformanceMonthlyModel> rawdata = _report.PieceMonthly(criteria);
                List<string> lsShipmentDate = rawdata.Select(o => o.shipment_date.ToString("dd")).ToList();
                int countData = rawdata.Count();
                //List<int> lsTotalTon= rawdata.Select(o => o.total_ton).ToList();
                List<int> lsDeliveryQty = rawdata.Select(o => o.delivery).ToList();
                

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
                    data = lsDeliveryQty.ToArray(),
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
                logger.Error(ex, "PieceMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> PieceYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationPerformanceYearlyModel> rawdata = _report.PieceYearly(criteria);
                List<string> lsShipmentMonth = rawdata.Select(o => o.shipment_month).ToList();
                int countData = rawdata.Count();
                //List<int> lsTotalTon = rawdata.Select(o => o.total_ton).ToList();
                List<int> lsDeliveryQty = rawdata.Select(o => o.delivery).ToList();


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
                    data = lsDeliveryQty.ToArray(),
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
        public async Task<JsonResult> PieceMonthlyDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.PieceMonthlyDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "TonMonthlyDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> PieceYearlyDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.PieceYearlyDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "TonYearlyDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

    }
}
