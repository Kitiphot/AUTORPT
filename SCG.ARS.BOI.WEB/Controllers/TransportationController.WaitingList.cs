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
        public async Task<JsonResult> WaitingListStatus(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                return Json(new { data = _report.WaitingListStatus(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "WaitingListStatus", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public async Task<JsonResult> WaitingListMonthly(TransportationCriteria criteria)
        {
            await FilterCriteria(criteria);
            try
            {
                List<WaitingListMonthlyModel> rawdata = _report.WaitingListMonthly(criteria);
                List<string> lsDate = rawdata.Select(o => o.commit_date?.ToString("dd/MM/yyyy") ?? "").ToList();
                List<string> lsDateTable = rawdata.Select(o => o.commit_date?.ToString("dd") ?? "").ToList();
                List<int> lsBook = rawdata.Select(o => o.total_book).ToList();
                List<int> lsRest = rawdata.Select(o => o.total_rest).ToList();
                List<int> lsWaiting = rawdata.Select(o => o.total_waiting).ToList();
                List<int> lsCommitted = rawdata.Select(o => o.total_committed).ToList();
                List<string> lsColorBook = new List<string>();
                List<string> lsColorRest = new List<string>();
                List<string> lsColorWaiting = new List<string>();
                List<string> lsColorCommitted = new List<string>();
                foreach (string number in lsDate)
                {
                    lsColorBook.Add("rgba(57, 204, 123, 0.9)");//Green
                    lsColorRest.Add("rgba(255,205,80, 0.9)");//Yellow
                    lsColorWaiting.Add("rgba(232, 81, 81, 0.9)");//Red
                    lsColorCommitted.Add("rgba(200, 200, 200, 0.9)");//Gray
                }

                BarChartIntegerDataSet totalBook = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Booked",
                    data = lsBook.ToArray(),
                    backgroundColor = lsColorBook.ToArray(),
                    borderColor = lsColorBook.ToArray(),
                    borderWidth = 1
                    //borderDash = "[10,5]"
                };                
                
                BarChartIntegerDataSet totalRest = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "รอบรถเหลือ (ท.)",
                    data = lsRest.ToArray(),
                    backgroundColor = lsColorRest.ToArray(),
                    borderColor = lsColorRest.ToArray(),
                    borderWidth = 1
                };                
                
                BarChartIntegerDataSet totalWaiting = new BarChartIntegerDataSet()
                {
                    type = "bar",
                    label = "Waiting List",
                    data = lsWaiting.ToArray(),
                    backgroundColor = lsColorWaiting.ToArray(),
                    borderColor = lsColorWaiting.ToArray(),
                    borderWidth = 1
                };                
                
                
                BarChartIntegerDataSet totalCommitted = new BarChartIntegerDataSet()
                {
                    type = "line",
                    label = "Truck Commit (ท.)",
                    data = lsCommitted.ToArray(),
                    backgroundColor = lsColorCommitted.ToArray(),
                    borderColor = lsColorCommitted.ToArray(),
                    borderWidth = 1
                };

                DataTableDataDetailViewModel Commit = new DataTableDataDetailViewModel()
                {
                    rowType = "Truck Commit (ท.)",
                    qty = lsCommitted.ToArray()
                };

                DataTableDataDetailViewModel Book = new DataTableDataDetailViewModel()
                {
                    rowType = "Booked",
                    qty = lsBook.ToArray()
                };

                DataTableDataDetailViewModel Rest = new DataTableDataDetailViewModel()
                {
                    rowType = "รอบรถเหลือ (ท.)",
                    qty = lsRest.ToArray()
                };

                DataTableDataDetailViewModel Waiting = new DataTableDataDetailViewModel()
                {
                    rowType = "Waiting List",
                    qty = lsWaiting.ToArray()
                };

                var dataDetail = new DataTableDataDetailViewModel[] { Commit, Book, Rest, Waiting };

                DataTableDataHeaderViewModel dataTable = new DataTableDataHeaderViewModel()
                {
                    header = lsDateTable.ToArray(),
                    dataDetail = dataDetail
                };


                BarChartIntegerData data = new BarChartIntegerData()
                {
                    labels = lsDate.ToArray(),
                    datasets = new BarChartIntegerDataSet[] { totalCommitted,totalBook, totalRest,totalWaiting }
                };
                var result = new
                {
                    data = data,
                    success = true
                };

                return Json(new { result,dataTable });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "NotShipmentMonthly", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public JsonResult RPTLPC004_Report(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.RPTLPC004_Report(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Waiting List", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
