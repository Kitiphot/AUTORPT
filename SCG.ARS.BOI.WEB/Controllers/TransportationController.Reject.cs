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
        public async Task<JsonResult> RejectMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<RejectMonthlyModel> rawdata = _report.RejectMonthly(criteria);
                var summaryRawdata = rawdata
                            .GroupBy(a => a.reject_carrier_name)
                            .Select(cl => new RejectMonthlyModel
                            {
                                reject_carrier_name = cl.First().reject_carrier_name,
                                total_carrier_new= cl.Sum(c => c.total_carrier_new),
                                total_carrier_old = cl.Sum(c => c.total_carrier_old),
                            }).Where(b=>b.reject_carrier_name != null).ToList();
                List<string> lsDate = rawdata.Select(o => o.tender_date?.ToString("dd/MM/yyyy") ?? "").Distinct().ToList();
                //List<string> lsDateTable = rawdata.Select(o => o.tender_date?.ToString("dd") ?? "").ToList();
                List<int> lsNewCarrier = rawdata.Select(o => o.total_carrier_new).ToList();
                List<int> lsOldCarrier = rawdata.Select(o => o.total_carrier_old).ToList();

                List<string> lsCarrierName = rawdata.Select(o => o.reject_carrier_name).ToList();


                List<string> lsColorNew = new List<string>();
                List<string> lsColorOld = new List<string>();

                foreach (string number in lsDate)
                {
                    lsColorOld.Add("rgba(128, 193, 255,0.9)");//Light Blue
                    lsColorNew.Add("rgba(255, 230, 204,0.9)");//Light Orange
                }

                BarChartIntegerDataSet totalOldCarrier = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ผรม. เดิม",
                    data = lsOldCarrier.ToArray(),
                    backgroundColor = lsColorOld.ToArray(),
                    borderColor = lsColorOld.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerDataSet totalNewCarrier = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ผรม. ใหม่",
                    data = lsNewCarrier.ToArray(),
                    backgroundColor = lsColorNew.ToArray(),
                    borderColor = lsColorNew.ToArray(),
                    borderWidth = 1
                    //borderDash = "[10,5]"
                };

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { totalOldCarrier, totalNewCarrier }
                };

                var result = new
                {
                    data = data,
                    success = true
                };

                return Json(new { result,dataTable = summaryRawdata });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RejectMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> RejectYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<RejectYearlyModel> rawdata = _report.RejectYearly(criteria);
                var summaryRawdata = rawdata
                                    .GroupBy(a => a.reject_carrier_name)
                                    .Select(cl => new RejectYearlyModel
                                    {
                                        reject_carrier_name = cl.First().reject_carrier_name,
                                        total_carrier_new = cl.Sum(c => c.total_carrier_new),
                                        total_carrier_old = cl.Sum(c => c.total_carrier_old),
                                    }).Where(b => b.reject_carrier_name != null).ToList();
                List<string> lsDate = rawdata.Select(o => o.tender_month).Distinct().ToList();
                //List<string> lsDateTable = rawdata.Select(o => o.tender_date?.ToString("dd") ?? "").ToList();
                List<int> lsNewCarrier = rawdata.Select(o => o.total_carrier_new).ToList();
                List<int> lsOldCarrier = rawdata.Select(o => o.total_carrier_old).ToList();

                List<string> lsCarrierName = rawdata.Select(o => o.reject_carrier_name).ToList();


                List<string> lsColorNew = new List<string>();
                List<string> lsColorOld = new List<string>();

                foreach (string number in lsDate)
                {
                    lsColorOld.Add("rgba(128, 193, 255,0.9)");//Light Blue
                    lsColorNew.Add("rgba(255, 230, 204,0.9)");//Light Orange
                }

                BarChartIntegerDataSet totalOldCarrier = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ผรม. เดิม",
                    data = lsOldCarrier.ToArray(),
                    backgroundColor = lsColorOld.ToArray(),
                    borderColor = lsColorOld.ToArray(),
                    borderWidth = 1
                };

                BarChartIntegerDataSet totalNewCarrier = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "ผรม. ใหม่",
                    data = lsNewCarrier.ToArray(),
                    backgroundColor = lsColorNew.ToArray(),
                    borderColor = lsColorNew.ToArray(),
                    borderWidth = 1
                    //borderDash = "[10,5]"
                };

                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { totalOldCarrier, totalNewCarrier }
                };

                var result = new
                {
                    data = data,
                    success = true
                };

                return Json(new { result, dataTable = summaryRawdata });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RejectMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult RPTLPC010_Report(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.RPTLPC010_Report(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Reject", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
