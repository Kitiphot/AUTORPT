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
        public JsonResult LoadByDay(TransportationCriteria criteria)
        {
            try
            {
                var list = _report.LoadByDay(criteria);
                list.Add(new LoadByDayModel
                {
                    carrier_name = "รวม",
                    acc_actual_percent = 100m,
                    acc_plan_percent = 100m,
                    actual = list.Sum(c => c.actual),
                    plan = list.Sum(c => c.plan),
                    actual_percent = 100m,
                    plan_percent = 100m,
                    diff_percent = 0m,
                    add = list.Sum(c => c.actual) - list.Sum(c => c.plan)
                });
                if (list.Count > 0)
                {
                    list[0].max_diff_percent = list.Max(c => c.diff_percent);
                    list[0].min_diff_percent = list.Min(c => c.diff_percent);
                }
                return Json(new { data = list, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "LoadByDay", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message + (ex.InnerException == null? "": $".{Environment.NewLine}{ex.InnerException.Message}"), success = false });
            }
        }

        [HttpPost]
        public JsonResult LoadByCarrier(TransportationCriteria criteria)
        {
            try
            {
                List<LoadByCarrierModel> rawdata = _report.LoadByCarrier(criteria).OrderBy(c => c.carrier_name).ToList();
                IEnumerable<string> lsCarrier = rawdata.Select(o => o.carrier_name).Distinct();
                int CountData = rawdata.Select(o=>o.carrier_name).Distinct().Count();
                List<double> oneData = rawdata.Where(w => w.distance_group.Equals("0-100")).Select(o => o.dist_percent).ToList();
                List<double> twoData = rawdata.Where(w => w.distance_group.Equals("101-200")).Select(o => o.dist_percent).ToList();
                List<double> threeData = rawdata.Where(w => w.distance_group.Equals("201-300")).Select(o => o.dist_percent).ToList();
                List<double> fourData = rawdata.Where(w => w.distance_group.Equals("301-400")).Select(o => o.dist_percent).ToList();
                List<double> fiveData = rawdata.Where(w => w.distance_group.Equals("401-500")).Select(o => o.dist_percent).ToList();
                List<double> sixData = rawdata.Where(w => w.distance_group.Equals("501-600")).Select(o => o.dist_percent).ToList();
                List<double> sevenData = rawdata.Where(w => w.distance_group.Equals("600++")).Select(o => o.dist_percent).ToList();
                //foreach (string carrier in lsCarrier)
                //{
                    //oneData = ;
                    //rawdata.Where(w => w.distance_group.Equals("101-200")).Select(o => o.dist_percent == null ? 0 : o.dist_percent).ToList();
                    //rawdata.Where(w => w.distance_group.Equals("201-300")).Select(o => o.dist_percent == null ? 0 : o.dist_percent).ToList();
                    //rawdata.Where(w => w.distance_group.Equals("301-400")).Select(o => o.dist_percent == null ? 0 : o.dist_percent).ToList();
                    //rawdata.Where(w => w.distance_group.Equals("401-500")).Select(o => o.dist_percent == null ? 0 : o.dist_percent).ToList();
                    //rawdata.Where(w => w.distance_group.Equals("501-600")).Select(o => o.dist_percent == null ? 0 : o.dist_percent).ToList();
                    //rawdata.Where(w => w.distance_group.Equals("600++")).Select(o => o.dist_percent == null ? 0 : o.dist_percent).ToList();
                //}

                //var one = from LoadByCarrierModel e in rawdata
                //          where e.distance_group.Equals("0-100")
                //            select new
                //                   {
                //                       value = e.dist_percent != null ? e.dist_percent : 0,
                //                       carrier = e.carrier_name
                //                   };


                List<string> lsColorDN = new List<string>();
                List<BarChartDataSet> barData = new List<BarChartDataSet>();
                string[] colorSet = {
                    "rgba(47, 70, 173, 0.8)", //blue
                    "rgba(95, 167, 245, 0.8)", //light blue
                    "rgba(57, 204, 123,0.9)", //green
                    "rgba(255,205,80, 0.9)", //yellow
                    "rgba(240, 134, 72, 0.9)", //orange
                    "rgba(199, 56, 56, 0.9)", //red
                    "rgba(143, 143, 143, 0.9)" //gray
                };
                int colorIdx = 0;
                foreach (var distance_group in rawdata.Select(c => c.distance_group).Distinct().OrderBy(c => c))
                {
                    
                    lsColorDN.Clear();
                    foreach (string number in lsCarrier)
                    {
                        lsColorDN.Add(colorSet[colorIdx]);
                    }
                    colorIdx++;
                    barData.Add(new BarChartDataSet()
                    {
                        type = "bar",
                        label = distance_group,
                        data = lsCarrier.Select(c => (rawdata.FirstOrDefault(f => f.carrier_name == c && f.distance_group == distance_group)?.dist_percent) ?? 0f).ToArray(), 
                        backgroundColor = lsColorDN.ToArray(),
                        borderColor = lsColorDN.ToArray(),
                        borderWidth = 1
                    });
                }
                BarChartData data = new BarChartData()
                {
                    labels = lsCarrier.ToArray(),
                    datasets = barData.ToArray()
                };

                DataTableDataDetailViewModel oneQty = new DataTableDataDetailViewModel()
                {
                    rowType = "0-100",
                    dqty = oneData.ToArray()
                };

                DataTableDataDetailViewModel twoQty = new DataTableDataDetailViewModel()
                {
                    rowType = "101-200",
                    dqty = twoData.ToArray()
                };

                DataTableDataDetailViewModel threeQty = new DataTableDataDetailViewModel()
                {
                    rowType = "201-300",
                    dqty = threeData.ToArray()
                };

                DataTableDataDetailViewModel fourQty = new DataTableDataDetailViewModel()
                {
                    rowType = "301-400",
                    dqty = fourData.ToArray()
                };                
                
                DataTableDataDetailViewModel fiveQty = new DataTableDataDetailViewModel()
                {
                    rowType = "401-500",
                    dqty = fiveData.ToArray()
                };                
                
                
                DataTableDataDetailViewModel sixQty = new DataTableDataDetailViewModel()
                {
                    rowType = "501-600",
                    dqty = sixData.ToArray()
                };                
                
                DataTableDataDetailViewModel sevenQty = new DataTableDataDetailViewModel()
                {
                    rowType = "600++",
                    dqty = sevenData.ToArray()
                };

                var dataDetail = new DataTableDataDetailViewModel[] { oneQty, twoQty, threeQty, fourQty,fiveQty,sixQty,sevenQty};

                DataTableDataHeaderViewModel dataTable = new DataTableDataHeaderViewModel()
                {
                    header = lsCarrier.ToArray(),
                    dataDetail = dataDetail
                };
                var result = new
                {
                    data = data,
                    success = true
                };
                return Json(new { result ,CountData, dataTable });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "LoadByCarrier", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message + (ex.InnerException == null ? "" : $".{Environment.NewLine}{ex.InnerException.Message}"), success = false });
            }
        }

        [HttpPost]
        public JsonResult LoadDetail(TransportationCriteria criteria)
        {
            try
            {
                var list = _report.LoadDetail(criteria);
                list.Add(new LoadDetailModel {
                    load_id = "Total",
                    total_distance =  list.Sum(c => c.total_distance),
                    charge_amount = list.Sum(c => c.charge_amount),
                });
                return Json(new { data = list, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "LoadDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message + (ex.InnerException == null ? "" : $".{Environment.NewLine}{ex.InnerException.Message}"), success = false });
            }
        }
    }
}
