using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public partial class ReportChartController : Controller
    {

        #region Dashbord
        //get_daily_shipment_status
        [HttpPost]
        public JsonResult RPTLPC001_ShipmentSummary(TransportationCriteria request)
        {
            List<RPTLPC001_ShipmentDailyStatusViewModel> rawdata = _report.RPTLPC001_ShipmentDailyStatus(request);
            List<TransportationStatusMonitorModel> data = new List<TransportationStatusMonitorModel>();
            data.Add(new TransportationStatusMonitorModel
            {
                status = "total dn",
                count_order = rawdata.Select(o => o.total_dn).FirstOrDefault()
            });
            data.Add(new TransportationStatusMonitorModel
            {
                status = "total tender",
                count_order = rawdata.Select(o => o.total_tender).FirstOrDefault()
            });
            data.Add(new TransportationStatusMonitorModel
            {
                status = "total accepct",
                count_order = rawdata.Select(o => o.total_accept).FirstOrDefault()
            });
            data.Add(new TransportationStatusMonitorModel
            {
                status = "total gi",
                count_order = rawdata.Select(o => o.total_gi).FirstOrDefault()
            });
            data.Add(new TransportationStatusMonitorModel
            {
                status = "total delivery",
                count_order = rawdata.Select(o => o.total_delivery).FirstOrDefault()
            });
            return Json(new { data = data, success = true });
            //jsonResult.MaxJsonLength = int.MaxValue;

            //return jsonResult;
        }

        #endregion

        #region Chart
        //20200730 Warut S.
        [HttpPost]
        public JsonResult RPTLPC001_ShipmentMonthlyStatus(TransportationCriteria request)
        {

            List<RPTLPC001_ShipmentMonthlyStatusViewModel> rawdata = _report.RPTLPC001_ShipmentMonthlyStatus(request);
            List<string> lsDate = rawdata.Select(o => o.dn_day.ToString("dd-MM-yyyy")).ToList();
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
                lsbgCompleteDelivery.Add("rgba(50, 168, 82,0.9)");
                lsbdCompleteDelivery.Add("rgba(50, 168, 82,0.9)");
                lsbgGI.Add("rgba(252, 186, 3,0.9)");
                lsbdGI.Add("rgba(252, 186, 3,0.9)");
                lsbgAccept.Add("rgba(127, 133, 129, 0.9)");
                lsbdAccept.Add("rgba(127, 133, 129,0.9)");
                lsbgTender.Add("rgba(235, 119, 52,0.9)");
                lsbdTender.Add("rgba(235, 119, 52,0.9)");
                lsbgTotalShipment.Add("rgba(52, 140, 235,0.9)");
                lsbdTotalShipment.Add("rgba(52, 140, 235,0.9)");
            }

            //Mock the data
            BarChartIntegerDataSet CompleteDelivery = new BarChartIntegerDataSet()
            {
                type = "bar",
                label = "CompleteDelivery",
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
                datasets = new BarChartIntegerDataSet[] { CompleteDelivery, GI, Accept, Tender, TotalShipment }
            };


            var jsonResult = Json(data);
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
            List<double> valueTH = new List<double>();
            foreach (string number in lsDate)
            {
                valueTH.Add(10000);
                lsbgcolorQty.Add("rgba(19, 171, 14,0.9");
                lsbdcolorQty.Add("rgba(51, 255, 88,0.9)");
                lsbgcolorQty2.Add("rgba(50, 50, 50,1)");
                lsbdcolorQty2.Add("rgba(252, 186, 3,1)");
                lsbgCompleteDelivery.Add("rgba(50, 168, 82,0.9)");
                lsbdCompleteDelivery.Add("rgba(50, 168, 82,0.9)");
                lsbgGI.Add("rgba(252, 186, 3,0.9)");
                lsbdGI.Add("rgba(252, 186, 3,0.9)");
                lsbgAccept.Add("rgba(127, 133, 129, 0.9)");
                lsbdAccept.Add("rgba(127, 133, 129,0.9)");
                lsbgTender.Add("rgba(235, 119, 52,0.9)");
                lsbdTender.Add("rgba(235, 119, 52,0.9)");
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
            BarChartIntegerData Outdata = new BarChartIntegerData()
            {
                labels = lsDate.ToArray(),
                datasets = new BarChartIntegerDataSet[] { CompleteDelivery, GI, Accept, Tender, TotalShipment }
            };


            var jsonResult = Json(Outdata);
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
            List<string> lsyAxes = new List<string>();
            lsyAxes.Add("Complete Delivery");
            lsyAxes.Add("GI");
            lsyAxes.Add("Accept");
            lsyAxes.Add("Tender");


            //List<int> lsTotalShipmentQty = rawdata.Select(o => o.total_dn).ToList();
            //List<string> lsbgCompleteDelivery = new List<string>();
            //List<string> lsbgGI = new List<string>();
            //List<string> lsbgAccept = new List<string>();
            //List<string> lsbgTender = new List<string>();
            //List<string> lsbgTotalShipment = new List<string>();
            //List<double> valueTH = new List<double>();

            List<string>[] lsbarColor = new List<string>[5];
            for (int i = 0; i < 5; i++)
            {
                lsbarColor[i] = new List<string>();
            }

            for (int i = 0; i < lsAging.Count(); i++)
            {
                //valueTH.Add(10000);
                lsbarColor[0].Add("rgba(68, 114, 196,0.9)");
                lsbarColor[1].Add("rgba(237, 125, 49,0.9)");
                lsbarColor[2].Add("rgba(127, 133, 129, 0.9)");
                lsbarColor[3].Add("rgba(252, 186, 3,0.9)");
                //lsbarColor[4].Add("rgba(52, 140, 235,0.9)");
            }

            //lsbgCompleteDelivery.Add("rgba(50, 168, 82,0.9)");
            //lsbgGI.Add("rgba(252, 186, 3,0.9)");
            //lsbgAccept.Add("rgba(127, 133, 129, 0.9)");
            //lsbgTender.Add("rgba(235, 119, 52,0.9)");
            //lsbgTotalShipment.Add("rgba(52, 140, 235,0.9)");

            //lsyAxes.
            //List<BarChartIntegerDataSet> barset = new List<BarChartIntegerDataSet>();
            //for (int i = 0; i < lsAging.Count(); i++)
            //{
            //    BarChartIntegerDataSet bardetail = new BarChartIntegerDataSet()
            //    {
            //        //type = "bar",
            //        label = lsAging[i],
            //        data = rawdata.Where(o => o.status_aging.Equals(lsAging[i])).Select(o => o.total_delivery).ToArray(),
            //        backgroundColor = lsbarColor[i].ToArray(),
            //        borderColor = lsbarColor[i].ToArray(),
            //        borderWidth = i+1
            //    };
            //    barset.Add(bardetail);
            //}



            BarChartIntegerDataSet CompleteDelivery = new BarChartIntegerDataSet()
            {
                //type = "bar",
                label = lsAging[0],
                data = lsCompleteDeliveryQty.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[0])).Select(o => o.total_delivery).ToArray(),
                backgroundColor = lsbarColor[0].ToArray(),
                borderColor = lsbarColor[0].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet GI = new BarChartIntegerDataSet()
            {
                //type = "bar",
                label = lsAging[1],
                data = lsGIQty.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[1])).Select(o => o.total_gi).ToArray(),
                backgroundColor = lsbarColor[1].ToArray(),
                borderColor = lsbarColor[1].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet Accept = new BarChartIntegerDataSet()
            {
                //type = "bar",
                label = lsAging[2],
                data = lsAcceptQty.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[2])).Select(o => o.total_accept).ToArray(),
                backgroundColor = lsbarColor[2].ToArray(),
                borderColor = lsbarColor[2].ToArray(),
                borderWidth = 1
            };

            BarChartIntegerDataSet Tender = new BarChartIntegerDataSet()
            {
                //type = "bar",
                label = lsAging[3],
                data = lsTenderQty.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[3])).Select(o => o.total_tender).ToArray(),
                backgroundColor = lsbarColor[3].ToArray(),
                borderColor = lsbarColor[3].ToArray(),
                borderWidth = 1
            };

            //BarChartIntegerDataSet TotalShipment = new BarChartIntegerDataSet()
            //{
            //    type = "line",
            //    label = "TotalShipment",
            //    data = lsTotalShipmentQty.ToArray(), // 10 20 30 40 < with 
            //    backgroundColor = lsbgTotalShipment.ToArray(),
            //    borderColor = lsbdTotalShipment.ToArray(),
            //    borderWidth = 1
            //};
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
                labels = lsyAxes.ToArray(),
                datasets = new BarChartIntegerDataSet[] { CompleteDelivery, GI, Accept, Tender }//barset.ToArray()
            };

            var jsonResult = Json(data);
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
                lsbarColor[1].Add("rgba(252, 186, 3,0.9)");
                lsbarColor[2].Add("rgba(91, 155, 213,0.9)");

                //lsbarColor[0].Add("rgba(50, 168, 82,0.9)");
                //lsbarColor[1].Add("rgba(252, 186, 3,0.9)");
                //lsbarColor[2].Add("rgba(127, 133, 129, 0.9)");
                //lsbarColor[3].Add("rgba(235, 119, 52,0.9)");
                //lsbarColor[4].Add("rgba(52, 140, 235,0.9)");




            }

            BarChartIntegerDataSet CompleteDelivery = new BarChartIntegerDataSet()
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

            BarChartIntegerDataSet Accept = new BarChartIntegerDataSet()

            {
                //type = "bar",
                label = "Complete Delivery",
                data = lsCompleteDeliveryQty.ToArray(),//rawdata.Where(o => o.status_aging.Equals(lsAging[2])).Select(o => o.total_accept).ToArray(),


                backgroundColor = lsbarColor[2].ToArray(),
                borderColor = lsbarColor[2].ToArray(),
                borderWidth = 1
            };

            //BarChartIntegerDataSet Tender = new BarChartIntegerDataSet()
            //{
            //    //type = "bar",
            //    label = lsAging[3],
            //    data = lsTenderQty.ToArray(), //rawdata.Where(o => o.status_aging.Equals(lsAging[3])).Select(o => o.total_tender).ToArray(),
            //    backgroundColor = lsbarColor[3].ToArray(),
            //    borderColor = lsbarColor[3].ToArray(),
            //    borderWidth = 1
            //};

            //BarChartIntegerDataSet TotalShipment = new BarChartIntegerDataSet()
            //{
            //    type = "line",
            //    label = "TotalShipment",
            //    data = lsTotalShipmentQty.ToArray(), // 10 20 30 40 < with 
            //    backgroundColor = lsbgTotalShipment.ToArray(),
            //    borderColor = lsbdTotalShipment.ToArray(),
            //    borderWidth = 1
            //};
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
                labels = lsCarrier.ToArray(),//lsyAxes.ToArray(),
                datasets = new BarChartIntegerDataSet[] { CompleteDelivery, GI, Accept },//barset.ToArray()
                countData = countData

            };


            var jsonResult = Json(data);
            //jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;

        }
        #endregion

    }
}
