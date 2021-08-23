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
        public async Task<JsonResult> NotShipmentStatus(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.NotShipmentStatus(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotShipmentStatus", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotShipmentMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationMonthlyModel> rawdata = _report.NotShipmentMonthly(criteria);
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
                return Json(new { data, success = true } );
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotShipmentMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotShipmentYearly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationYearlyModel> rawdata = _report.NotShipmentYearly(criteria);
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
                logger.Error(ex, "NotShipmentYearly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotShipmentDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.NotShipmentDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotShipmentDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotShipmentMonitoringDetail(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.NotShipmentMonitoringDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotShipmentDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotShipmentStatusMonitor(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                //return Json(new { data = _report.NotShipmentStatusMonitor(criteria), success = true });
                List<TransportationStatusRawModel> rawdata = _report.NotShipmentStatusMonitor(criteria);
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
                logger.Error(ex, "NotShipmentStatusMonitor", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotShipmentByBusiness(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationNotShipmentByBusinessModel> rawdata = _report.NotShipmentByBusiness(criteria);
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
                logger.Error(ex, "NotDN", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> NotShipmentByPlanner(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<TransportationNotShipmentByPlannerModel> rawdata = _report.NotShipmentByPlanner(criteria);
                List<string> lsPlanner = rawdata.Select(o => o.planner).ToList();
                int countData = rawdata.Count();
                List<int> ls1 = rawdata.Select(o => o.age1).ToList();
                List<int> ls0_3 = rawdata.Select(o => o.age2).ToList();
                List<int> ls4_5 = rawdata.Select(o => o.age3).ToList();
                List<int> ls6_7 = rawdata.Select(o => o.age4).ToList();
                List<int> ls8_10 = rawdata.Select(o => o.age5).ToList();
                List<int> ls10 = rawdata.Select(o => o.age6).ToList();

                List<string> lsColorDN = new List<string>();


                lsColorDN.Clear();
                foreach (string number in lsPlanner)
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
                foreach (string number in lsPlanner)
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
                foreach (string number in lsPlanner)
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
                foreach (string number in lsPlanner)
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
                foreach (string number in lsPlanner)
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
                foreach (string number in lsPlanner)
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
                    labels = lsPlanner.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { range1, range0To3, range4To5, range6To7, range8To10, range10 },
                    countData = countData
                };
                return Json(new { data, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotDN", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
