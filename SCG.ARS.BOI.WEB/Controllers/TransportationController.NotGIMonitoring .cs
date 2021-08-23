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
        public async Task<JsonResult> NotGIMonitoringStatus(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                //return Json(new { data = _report.NotGIMonitoringStatus(criteria), success = true });
                List<TransportationStatusRawModel> rawdata = _report.NotGIMonitoringStatus(criteria);
                List<TransportationStatusMonitorModel> data = new List<TransportationStatusMonitorModel>();
                data.Add(new TransportationStatusMonitorModel
                {
                    age = "1",
                    count_order = rawdata.Select(o => o.age1).FirstOrDefault()
                });
                data.Add(new TransportationStatusMonitorModel
                {
                    age = "2-3",
                    count_order = rawdata.Select(o => o.age2).FirstOrDefault()
                });
                data.Add(new TransportationStatusMonitorModel
                {
                    age = "4-5",
                    count_order = rawdata.Select(o => o.age3).FirstOrDefault()
                });
                data.Add(new TransportationStatusMonitorModel
                {
                    age = "6-7",
                    count_order = rawdata.Select(o => o.age4).FirstOrDefault()
                });
                data.Add(new TransportationStatusMonitorModel
                {
                    age = "8-10",
                    count_order = rawdata.Select(o => o.age5).FirstOrDefault()
                });
                data.Add(new TransportationStatusMonitorModel
                {
                    age = ">10",
                    count_order = rawdata.Select(o => o.age6).FirstOrDefault()
                });
                return Json(new { data = data, success = true });

            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotGIStatus", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotGIMonitoringByBusiness(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationByBusinessModel> rawdata = _report.NotGIMonitoringByBusiness(criteria);
                List<string> lsBusinessGroup = rawdata.Select(o => o.business_group).ToList();
                int countData = rawdata.Count();
                List<int> ls1 = rawdata.Select(o => o.age1).ToList();
                List<int> ls0_3 = rawdata.Select(o => o.age2).ToList();
                List<int> ls4_5 = rawdata.Select(o => o.age3).ToList();
                List<int> ls6_7 = rawdata.Select(o => o.age4).ToList();
                List<int> ls8_10 = rawdata.Select(o => o.age5).ToList();
                List<int> ls10 = rawdata.Select(o => o.age6).ToList();

                List<string> lsColorDN = new List<string>();


                lsColorDN.Clear();
                foreach (string number in lsBusinessGroup)
                {
                    lsColorDN.Add("rgba(94, 190, 228, 0.9)");
                }
                BarChartIntegerDataSet range1 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "1 Day",
                    data = ls1.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };

                lsColorDN.Clear();
                foreach (string number in lsBusinessGroup)
                {
                    lsColorDN.Add("rgba(68, 84, 106, 0.9)");
                }
                BarChartIntegerDataSet range0To3 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "2-3 Days",
                    data = ls0_3.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsBusinessGroup)
                {
                    lsColorDN.Add("rgba(255, 192, 0, 0.9)");
                }
                BarChartIntegerDataSet range4To5 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "4-5 Days",
                    data = ls4_5.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsBusinessGroup)
                {
                    lsColorDN.Add("rgba(180,137,0, 0.9)");
                }
                BarChartIntegerDataSet range6To7 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "6-7 Days",
                    data = ls6_7.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsBusinessGroup)
                {
                    lsColorDN.Add("rgba(255, 5, 5, 0.9)");
                }
                BarChartIntegerDataSet range8To10 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "8-10 Days",
                    data = ls8_10.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsBusinessGroup)
                {
                    lsColorDN.Add("rgba(192, 0,0, 0.9)");
                }
                BarChartIntegerDataSet range10 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = ">10 Days",
                    data = ls10.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };
                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsBusinessGroup.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { range1, range0To3, range4To5, range6To7, range8To10, range10 },
                    countData = countData
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotGI", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotGIMonitoringByCarrier(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationByCarrierMonitoringModel> rawdata = _report.NotGIMonitoringByCarrier(criteria);
                List<string> lsCarrier= rawdata.Select(o => o.carrier).ToList();
                int countData = rawdata.Count();
                List<int> ls1 = rawdata.Select(o => o.age1).ToList();
                List<int> ls0_3 = rawdata.Select(o => o.age2).ToList();
                List<int> ls4_5 = rawdata.Select(o => o.age3).ToList();
                List<int> ls6_7 = rawdata.Select(o => o.age4).ToList();
                List<int> ls8_10 = rawdata.Select(o => o.age5).ToList();
                List<int> ls10 = rawdata.Select(o => o.age6).ToList();

                List<string> lsColorDN = new List<string>();


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(94, 190, 228, 0.9)");
                }
                BarChartIntegerDataSet range1 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "1 Day",
                    data = ls1.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };

                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(68, 84, 106, 0.9)");
                }
                BarChartIntegerDataSet range0To3 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "2-3 Days",
                    data = ls0_3.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(255, 192, 0, 0.9)");
                }
                BarChartIntegerDataSet range4To5 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "4-5 Days",
                    data = ls4_5.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(180,137,0, 0.9)");
                }
                BarChartIntegerDataSet range6To7 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "6-7 Days",
                    data = ls6_7.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(255, 5, 5, 0.9)");
                }
                BarChartIntegerDataSet range8To10 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = "8-10 Days",
                    data = ls8_10.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };


                lsColorDN.Clear();
                foreach (string number in lsCarrier)
                {
                    lsColorDN.Add("rgba(192, 0,0, 0.9)");
                }
                BarChartIntegerDataSet range10 = new BarChartIntegerDataSet()
                {
                    type = "horizontalBar",
                    label = ">10 Days",
                    data = ls10.ToArray(),
                    backgroundColor = lsColorDN.ToArray(),
                    borderColor = lsColorDN.ToArray(),
                    borderWidth = 1
                };
                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsCarrier.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { range1, range0To3, range4To5, range6To7, range8To10, range10 },
                    countData = countData
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotGI", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }


        [HttpPost]
        public async Task<JsonResult> NotGIMonitoringDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.NotGIMonitoringDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotGIDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

    }
}
