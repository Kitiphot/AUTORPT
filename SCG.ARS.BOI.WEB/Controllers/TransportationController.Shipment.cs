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
        public JsonResult RPTLPC001_Report(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.RPTLPC001_Report(criteria), success = true });

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Shipment", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [HttpPost]
        public JsonResult RPTLPC001_ShipmentSummary(TransportationCriteria request)
        {
            var jsonResult = Json(new { data = _report.RPTLPC001_ShipmentDailyStatus(request) });

            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        #region Chart
        //20200730 Warut S.
        [HttpPost]
        public JsonResult RPTLPC001_ShipmentMonthlyStatus(TransportationCriteria request)
        {
            List<RPTLPC001_ShipmentMonthlyStatusViewModel> rawdata = _report.RPTLPC001_ShipmentMonthlyStatus(request);
            List<string> lsDate = rawdata.Select(o => o.dn_day.ToString("dd\\/MM\\/yyyy")).ToList();
            List<int> lsCompleteDeliveryQty = rawdata.Select(o => o.total_delivery).ToList();
            List<int> lsGIQty = rawdata.Select(o => o.total_gi).ToList();
            List<int> lsAcceptQty = rawdata.Select(o => o.total_accept).ToList();
            List<int> lsTenderQty = rawdata.Select(o => o.total_tender).ToList();
            List<int> lsTotalShipmentQty = rawdata.Select(o => o.total_dn).ToList();
            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgCompleteDelivery = new List<string>();
            List<string> lsbdCompleteDelivery = new List<string>();
            List<string> lsbgGI = new List<string>();
            List<string> lsbdGI = new List<string>();
            List<string> lsbgAccept = new List<string>();
            List<string> lsbdAccept = new List<string>();
            List<string> lsbgTender = new List<string>();
            List<string> lsbdTender = new List<string>();
            List<string> lsbgTotalShipment = new List<string>();
            List<string> lsbdTotalShipment = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();
            List<double> valueTH = new List<double>();
            foreach (string number in lsDate)
            {
                valueTH.Add(10000);
                lsbgcolorQty.Add("rgba(19, 171, 14,0.9");
                lsbdcolorQty.Add("rgba(51, 255, 88,0.9)");
                lsbgcolorQty2.Add("rgba(50, 50, 50,1)");
                lsbdcolorQty2.Add("rgba(252, 186, 3,1)");
                lsbgCompleteDelivery.Add("rgba(57, 204, 123,0.9)");
                lsbdCompleteDelivery.Add("rgba(57, 204, 123,0.9)");
                lsbgGI.Add("rgba(255,205,80,0.9)");
                lsbdGI.Add("rgba(255,205,80,0.9)");
                lsbgAccept.Add("rgba(127, 133, 129, 0.8)");
                lsbdAccept.Add("rgba(127, 133, 129,0.8)");
                lsbgTender.Add("rgba(235, 119, 52,0.8)");
                lsbdTender.Add("rgba(235, 119, 52,0.8)");
                lsbgTotalShipment.Add("rgba(52, 140, 235,0.9)");
                lsbdTotalShipment.Add("rgba(52, 140, 235,0.9)");
            }

            //Mock the data
            BarChartIntegerDataSet CompleteDelivery = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Complete Delivery",
                data = lsCompleteDeliveryQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgCompleteDelivery.ToArray(),
                borderColor = lsbdCompleteDelivery.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet GI = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "GI",
                data = lsGIQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgGI.ToArray(),
                borderColor = lsbdGI.ToArray(),
                borderWidth = 2
            };

            BarChartIntegerDataSet Accept = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Accept",
                data = lsAcceptQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAccept.ToArray(),
                borderColor = lsbdAccept.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet Tender = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Tender",
                data = lsTenderQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgTender.ToArray(),
                borderColor = lsbdTender.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet TotalShipment = new BarChartIntegerDataSet()
            {
                type = "line",
                label = "TotalShipment",
                data = lsTotalShipmentQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgTotalShipment.ToArray(),
                borderColor = lsbdTotalShipment.ToArray(),
                borderWidth = 1
            };

            DataTableDataDetailViewModel TenderQty = new DataTableDataDetailViewModel()
            {
                rowType = "Tender",
                qty = lsTenderQty.ToArray()
            };

            DataTableDataDetailViewModel AccepctQty = new DataTableDataDetailViewModel()
            {
                rowType = "Accept",
                qty = lsAcceptQty.ToArray()
            };

            DataTableDataDetailViewModel GIQty = new DataTableDataDetailViewModel()
            {
                rowType = "GI",
                qty = lsGIQty.ToArray()
            };

            DataTableDataDetailViewModel CompleteDeliveryQty = new DataTableDataDetailViewModel()
            {
                rowType = "Complete Delivery",
                qty = lsCompleteDeliveryQty.ToArray()
            };

            var dataDetail = new DataTableDataDetailViewModel[] { TenderQty, AccepctQty, GIQty, CompleteDeliveryQty };

            DataTableDataHeaderViewModel dataTable = new DataTableDataHeaderViewModel()
            {
                header = lsDate.ToArray(),
                dataDetail = dataDetail
            };

            //foreach a in b
            //    {
            //    color = Random color 
            //    List<BarChartDataSet> chartlist = new BarChartDataSet()
            //    {
            //        type : fix
            //        label loop by a
            //        data = rawdata column 1.Select where a , rawdata column 2.select where a 
            //        color = color 

            //    }

            //    }
            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { TotalShipment,Tender,Accept,GI,CompleteDelivery  }
            };


            var jsonResult = Json(new { data ,dataTable});
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public JsonResult RPTLPC001_ShipmentYearlyStatus(TransportationCriteria data)
        {
            //List<RPTCDC001ReceivingChartViewModel> rawdata = _report.RPTCDC001_RecivingReportChart(request.selectStartDate, request.selectEndDate, request.selectCustomer);
            List<RPTLPC001_ShipmentYearlyStatusViewModel> rawdata = _report.RPTLPC001_ShipmentYearlyStatus(data);

            List<string> lsDate = rawdata.Select(o => o.shipment_month).Distinct().ToList();

            List<int> lsCompleteDeliveryQty = rawdata.Select(o => o.total_delivery).ToList();
            List<int> lsGIQty = rawdata.Select(o => o.total_gi).ToList();
            List<int> lsAcceptQty = rawdata.Select(o => o.total_accept).ToList();
            List<int> lsTenderQty = rawdata.Select(o => o.total_tender).ToList();
            List<int> lsTotalShipmentQty = rawdata.Select(o => o.total_dn).ToList();
            List<string> lsbgcolorQty = new List<string>();
            List<string> lsbdcolorQty = new List<string>();
            List<string> lsbgCompleteDelivery = new List<string>();
            List<string> lsbdCompleteDelivery = new List<string>();
            List<string> lsbgGI = new List<string>();
            List<string> lsbdGI = new List<string>();
            List<string> lsbgAccept = new List<string>();
            List<string> lsbdAccept = new List<string>();
            List<string> lsbgTender = new List<string>();
            List<string> lsbdTender = new List<string>();
            List<string> lsbgTotalShipment = new List<string>();
            List<string> lsbdTotalShipment = new List<string>();
            List<string> lsbgcolorQty2 = new List<string>();
            List<string> lsbdcolorQty2 = new List<string>();

            foreach (string number in lsDate)
            {
                lsbgcolorQty.Add("rgba(19, 171, 14,0.9");
                lsbdcolorQty.Add("rgba(51, 255, 88,0.9)");
                lsbgcolorQty2.Add("rgba(50, 50, 50,1)");
                lsbdcolorQty2.Add("rgba(252, 186, 3,1)");
                lsbgCompleteDelivery.Add("rgba(57, 204, 123,0.9)");
                lsbdCompleteDelivery.Add("rgba(57, 204, 123,0.9)");
                lsbgGI.Add("rgba(255,205,80,0.9)");
                lsbdGI.Add("rgba(255,205,80,0.9)");
                lsbgAccept.Add("rgba(127, 133, 129, 0.8)");
                lsbdAccept.Add("rgba(127, 133, 129,0.8)");
                lsbgTender.Add("rgba(235, 119, 52,0.8)");
                lsbdTender.Add("rgba(235, 119, 52,0.8)");
                lsbgTotalShipment.Add("rgba(52, 140, 235,0.9)");
                lsbdTotalShipment.Add("rgba(52, 140, 235,0.9)");
            }

            //Mock the data
            BarChartIntegerDataSet CompleteDelivery = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Complete Delivery",
                data = lsCompleteDeliveryQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgCompleteDelivery.ToArray(),
                borderColor = lsbdCompleteDelivery.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet GI = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "GI",
                data = lsGIQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgGI.ToArray(),
                borderColor = lsbdGI.ToArray(),
                borderWidth = 2
            };

            BarChartIntegerDataSet Accept = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Accept",
                data = lsAcceptQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgAccept.ToArray(),
                borderColor = lsbdAccept.ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet Tender = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "Tender",
                data = lsTenderQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgTender.ToArray(),
                borderColor = lsbdTender.ToArray(),
                borderWidth = 1
            };
            BarChartIntegerDataSet TotalShipment = new BarChartIntegerDataSet()
            {
                type = "line",
                label = "TotalShipment",
                data = lsTotalShipmentQty.ToArray(), // 10 20 30 40 < with 
                backgroundColor = lsbgTotalShipment.ToArray(),
                borderColor = lsbdTotalShipment.ToArray(),
                borderWidth = 1
            };


            DataTableDataDetailViewModel TenderQty = new DataTableDataDetailViewModel()
            {
                rowType = "Tender",
                qty = lsTenderQty.ToArray()
            };

            DataTableDataDetailViewModel AccepctQty = new DataTableDataDetailViewModel()
            {
                rowType = "Accept",
                qty = lsAcceptQty.ToArray()
            };

            DataTableDataDetailViewModel GIQty = new DataTableDataDetailViewModel()
            {
                rowType = "GI",
                qty = lsGIQty.ToArray()
            };

            DataTableDataDetailViewModel CompleteDeliveryQty = new DataTableDataDetailViewModel()
            {
                rowType = "Complete Delivery",
                qty = lsCompleteDeliveryQty.ToArray()
            };

            var dataDetail = new DataTableDataDetailViewModel[] { TenderQty, AccepctQty, GIQty, CompleteDeliveryQty };

            DataTableDataHeaderViewModel dataTable = new DataTableDataHeaderViewModel()
            {
                header = lsDate.ToArray(),
                dataDetail = dataDetail
            };

            BarChartIntegerData outData = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { TotalShipment, Tender, Accept,GI, CompleteDelivery }
            };


            var jsonResult = Json(new { outData ,dataTable});
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public JsonResult RPTLPC001_ShipmentMonthlyStatusAging(TransportationCriteria request)
        {
            List<RPTLPC001_ShipmentMonthlyStatusAgingViewModel> rawdata = _report.RPTLPC001_ShipmentMonthlyStatusAging(request);

            List<string> lsAging = rawdata.Select(o => o.status_aging).Distinct().ToList();
            //List<int> lsCompleteDeliveryQty = rawdata.Select(o => o.total_delivery)  .ToList();
            List<int> lsCompleteDeliveryQty = rawdata.Select(o => o.total_delivery).ToList();
            List<int> lsGIQty = rawdata.Select(o => o.total_gi).ToList();
            List<int> lsAcceptQty = rawdata.Select(o => o.total_accept).ToList();
            List<int> lsTenderQty = rawdata.Select(o => o.total_tender).ToList();
            List<int> oneData = new List<int>()
            {
                rawdata.Where(x => x.status_aging.Equals("0-1")).Select(o => o.total_tender).FirstOrDefault(),
                rawdata.Where(x => x.status_aging.Equals("0-1")).Select(o => o.total_accept).FirstOrDefault(),
                rawdata.Where(x => x.status_aging.Equals("0-1")).Select(o => o.total_gi).FirstOrDefault(),
                rawdata.Where(x => x.status_aging.Equals("0-1")).Select(o => o.total_delivery).FirstOrDefault()
            };            
            
            List<int> twoData = new List<int>()
            {
                rawdata.Where(x=>x.status_aging.Equals("2-3")).Select(o=>o.total_tender).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals("2-3")).Select(o=>o.total_accept).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals("2-3")).Select(o=>o.total_gi).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals("2-3")).Select(o=>o.total_delivery).FirstOrDefault()
            };            
            
            List<int> threeData = new List<int>()
            {
                rawdata.Where(x=>x.status_aging.Equals("4-5")).Select(o=>o.total_tender).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals("4-5")).Select(o=>o.total_accept).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals("4-5")).Select(o=>o.total_gi).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals("4-5")).Select(o=>o.total_delivery).FirstOrDefault()
            };            
            
            List<int> fourData = new List<int>()
            {
                rawdata.Where(x=>x.status_aging.Equals(">5")).Select(o=>o.total_tender).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals(">5")).Select(o=>o.total_accept).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals(">5")).Select(o=>o.total_gi).FirstOrDefault(),
                rawdata.Where(x=>x.status_aging.Equals(">5")).Select(o=>o.total_delivery).FirstOrDefault()
            };


            List<string> lsyAxes = new List<string>();
            lsyAxes.Add("Tender");
            lsyAxes.Add("Accept");
            lsyAxes.Add("GI");
            lsyAxes.Add("Complete Delivery");
            
            List<string>[] lsbarColor = new List<string>[5];
            for (int i = 0; i < 5; i++)
            {
                lsbarColor[i] = new List<string>();
            }

            for (int i = 0; i < lsAging.Count(); i++)
            {
                //valueTH.Add(10000);
                lsbarColor[0].Add("rgba(20, 156, 138,0.8)");
                lsbarColor[1].Add("rgba(255,235,100,0.8)");
                lsbarColor[2].Add("rgba(255,153,0,0.8)");
                lsbarColor[3].Add("rgba(255,71,71,0.8)");
                //lsbarColor[4].Add("rgba(52, 140, 235,0.9)");
            }
            BarChartIntegerDataSet CompleteDelivery = new BarChartIntegerDataSet()
            {
                //type = "bar",
                label = lsAging[0],
                data = oneData.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[0])).Select(o => o.total_delivery).ToArray(),
                backgroundColor = lsbarColor[0].ToArray(),
                borderColor = lsbarColor[0].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet GI = new BarChartIntegerDataSet()
            {
                //type = "bar",
                label = lsAging[1],
                data = twoData.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[1])).Select(o => o.total_gi).ToArray(),
                backgroundColor = lsbarColor[1].ToArray(),
                borderColor = lsbarColor[1].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet Accept = new BarChartIntegerDataSet()
            {
                //type = "bar",
                label = lsAging[2],
                data = threeData.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[2])).Select(o => o.total_accept).ToArray(),
                backgroundColor = lsbarColor[2].ToArray(),
                borderColor = lsbarColor[2].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet Tender = new BarChartIntegerDataSet()
            {
                //type = "bar",
                label = lsAging[3],
                data = fourData.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[3])).Select(o => o.total_tender).ToArray(),
                backgroundColor = lsbarColor[3].ToArray(),
                borderColor = lsbarColor[3].ToArray(),
                borderWidth = 1
            };

            DataTableDataDetailViewModel oneQty = new DataTableDataDetailViewModel()
            {
                rowType = "0-1",
                qty = oneData.ToArray()
            };

            DataTableDataDetailViewModel twoQty = new DataTableDataDetailViewModel()
            {
                rowType = "2-3",
                qty = twoData.ToArray()
            };

            DataTableDataDetailViewModel threeQty = new DataTableDataDetailViewModel()
            {
                rowType = "4-5",
                qty = threeData.ToArray()
            };

            DataTableDataDetailViewModel fourQty = new DataTableDataDetailViewModel()
            {
                rowType = ">5",
                qty = fourData.ToArray()
            };

            var dataDetail = new DataTableDataDetailViewModel[] { oneQty, twoQty, threeQty, fourQty };

            DataTableDataHeaderViewModel dataTable = new DataTableDataHeaderViewModel()
            {
                header = lsyAxes.ToArray(),
                dataDetail = dataDetail
            };

            BarChartIntegerData data = new BarChartIntegerData()
            {
                labels = lsyAxes.ToArray(),
                datasets = new BarChartIntegerDataSet[] { CompleteDelivery , GI, Accept, Tender }//barset.ToArray()
            };

            var jsonResult = Json(new { data, dataTable});
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }

        [HttpPost]
        public JsonResult RPTLPC001_ShipmentMonthlyCarrierStatus(TransportationCriteria request)
        {

            //List<RPTCDC001ReceivingChartViewModel> rawdata = _report.RPTCDC001_RecivingReportChart(request.selectStartDate, request.selectEndDate, request.selectCustomer);

            List<RPTLPC001_ShipmentMonthlyCarrierStatusViewModel> rawdata = _report.RPTLPC001_ShipmentMonthlyCarrierStatus(request);



            List<string> lsCarrier = rawdata.Select(o => o.carrier_name).Distinct().ToList();
            int countData = rawdata.Count();
            //List<int> lsCompleteDeliveryQty = rawdata.Select(o => o.total_delivery)  .ToList();
            List<int> lsCompleteDeliveryQty = rawdata.Select(o => o.total_delivery).ToList();
            List<int> lsGIQty = rawdata.Select(o => o.total_gi).ToList();
            List<int> lsAcceptQty = rawdata.Select(o => o.total_accept).ToList();
            List<int> lsTenderQty = rawdata.Select(o => o.total_tender).ToList();
            List<string> lsyAxes = new List<string>();



            List<string>[] lsbarColor = new List<string>[5];
            for (int i = 0; i < 5; i++)
            {
                lsbarColor[i] = new List<string>();
            }


            for (int i = 0; i < lsCarrier.Count(); i++)


            {
                //valueTH.Add(10000);
                lsbarColor[0].Add("rgba(127, 133, 129, 0.9)");
                lsbarColor[1].Add("rgba(255,205,80,0.9)");
                lsbarColor[2].Add("rgba(57, 204, 123,0.9)");
                lsbarColor[3].Add("rgba(235, 119, 52,0.9)");

                //lsbarColor[0].Add("rgba(50, 168, 82,0.9)");
                //lsbarColor[1].Add("rgba(252, 186, 3,0.9)");
                //lsbarColor[2].Add("rgba(127, 133, 129, 0.9)");
                //lsbarColor[3].Add("rgba(235, 119, 52,0.9)");
                //lsbarColor[4].Add("rgba(52, 140, 235,0.9)");
            }

            BarChartIntegerDataSet Accept = new BarChartIntegerDataSet()
            {
                //type = "bar",

                label = "Accept",//lsCarrier[2],
                data = lsAcceptQty.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[0])).Select(o => o.total_delivery).ToArray(),
                backgroundColor = lsbarColor[0].ToArray(),
                borderColor = lsbarColor[0].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet GI = new BarChartIntegerDataSet()


            {
                //type = "bar",
                label = "GI",
                data = lsGIQty.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[1])).Select(o => o.total_gi).ToArray(),

                backgroundColor = lsbarColor[1].ToArray(),
                borderColor = lsbarColor[1].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet CompleteDelivery = new BarChartIntegerDataSet()

            {
                //type = "bar",
                label = "Complete Delivery",
                data = lsCompleteDeliveryQty.ToArray(),//rawdata.Where(o => o.status_aging.Equals(lsAging[2])).Select(o => o.total_accept).ToArray(),
                backgroundColor = lsbarColor[2].ToArray(),
                borderColor = lsbarColor[2].ToArray(),
                borderWidth = 1
            };            
            
            BarChartIntegerDataSet Tender = new BarChartIntegerDataSet()

            {
                //type = "bar",
                label = "Tender",
                data = lsTenderQty.ToArray(),//rawdata.Where(o => o.status_aging.Equals(lsAging[2])).Select(o => o.total_accept).ToArray(),
                backgroundColor = lsbarColor[3].ToArray(),
                borderColor = lsbarColor[3].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerData data = new BarChartIntegerData()

            {
                labels = lsCarrier.ToArray(),//lsyAxes.ToArray(),
                datasets = new BarChartIntegerDataSet[] { Tender, Accept,GI,CompleteDelivery},//barset.ToArray()
                countData = countData

            };


            DataTableDataDetailViewModel TenderQty = new DataTableDataDetailViewModel()
            {
                rowType = "Tender",
                qty = lsTenderQty.ToArray()
            };

            DataTableDataDetailViewModel AccepctQty = new DataTableDataDetailViewModel()
            {
                rowType = "Accepct",
                qty = lsAcceptQty.ToArray()
            };

            DataTableDataDetailViewModel GIQty = new DataTableDataDetailViewModel()
            {
                rowType = "GI",
                qty = lsGIQty.ToArray()
            };

            DataTableDataDetailViewModel DeliveryQty = new DataTableDataDetailViewModel()
            {
                rowType = "Delivery",
                qty = lsCompleteDeliveryQty.ToArray()
            };

            var dataDetail = new DataTableDataDetailViewModel[] { TenderQty, AccepctQty, GIQty, DeliveryQty };

            DataTableDataHeaderViewModel dataTable = new DataTableDataHeaderViewModel()
            {
                header = lsCarrier.ToArray(),
                dataDetail = dataDetail
            };

            var jsonResult = Json(new { data, dataTable });
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;

        }
        #endregion
    }
}
