using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB.GENZ.Repositories;
using SCG.ARS.BOI.WEB.Models.Generwiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.GENZ.Controllers
{
    public class OrderPendingController : Controller
    {
        IOrderPendingRepository orderRepo;

        public OrderPendingController(IOrderPendingRepository orderRepository)
        {
            orderRepo = orderRepository;
        }
        string[] uriParams;

        protected string[] decodeUri(string id)
        {
            
            var e = Encoding.GetEncoding("iso-8859-1");
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(id);
            string returnValue = e.GetString(encodedDataAsBytes);
            //return returnValue;
            uriParams = returnValue.Split('|');
            return uriParams;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PendingTable(string Id)
        {
            this.decodeUri(Id);
            string Businessgroup = this.uriParams[0];
            string Customergroup = this.uriParams[1];
            string Productgroup = this.uriParams[2];
            string Status = this.uriParams[3];
            string OriginRegions = this.uriParams[4];
            //OriginRegions = OriginRegions.Replace(",", "|");
            string DestinationRegions = this.uriParams[5];
            //DestinationRegions = DestinationRegions.Replace(",", "|");
            string TruckTypes = this.uriParams[6];


            List<OrderPendingDetailModel> orderList = new List<OrderPendingDetailModel>();

            if (Status == "waitinglisttoday14" || Status == "waitinglisttoday13")
            {
                orderList = orderRepo.GetDetailWaitingList(Businessgroup, Customergroup, Productgroup, Status, OriginRegions, DestinationRegions, TruckTypes);
            }
            else
            {
                orderList = orderRepo.GetDetailBookingList(Businessgroup, Customergroup, Productgroup, Status, OriginRegions, DestinationRegions, TruckTypes);
            }

            foreach (var item in orderList)
            {
                //zone
                if (item.shiptoregioncode == "4" || item.shiptoregioncode == "M4")
                {

                    if (item.provincecode == "36" || item.provincecode == "40" || item.provincecode == "42")
                    {
                        item.zone = "1";
                    }
                    else if (item.provincecode == "39" || item.provincecode == "41" || item.provincecode == "47")
                    {
                        item.zone = "2";
                    }
                    else if (item.provincecode == "43" || item.provincecode == "38" || item.provincecode == "48" || item.provincecode == "49")
                    {
                        item.zone = "3";
                    }
                    else if (item.provincecode == "44" || item.provincecode == "45" || item.provincecode == "46" || item.provincecode == "35")
                    {
                        item.zone = "4";
                    }
                    else if (item.provincecode == "31" || item.provincecode == "32")
                    {
                        item.zone = "5";
                    }
                    else if (item.provincecode == "33" || item.provincecode == "34" || item.provincecode == "37")
                    {
                        item.zone = "6";
                    }
                    else if (item.provincecode == "30")
                    {
                        item.zone = "7";
                    }
                    else
                    {
                        item.zone = "";
                    }
                }

                //region
                if (item.shiptoregioncode == "1" || item.shiptoregioncode == "2" || item.shiptoregioncode == "3" || item.shiptoregioncode == "4" ||
                    item.shiptoregioncode == "5" || item.shiptoregioncode == "6" || item.shiptoregioncode == "7")
                {
                    if (item.shiptoregioncode == "1")
                    {
                        item.shiptoregioncode = "M1";
                    }
                    else if (item.shiptoregioncode == "2")
                    {
                        item.shiptoregioncode = "M2";
                    }
                    else if (item.shiptoregioncode == "3")
                    {
                        item.shiptoregioncode = "M3";
                    }
                    else if (item.shiptoregioncode == "4")
                    {
                        item.shiptoregioncode = "M4";
                    }
                    else if (item.shiptoregioncode == "5")
                    {
                        item.shiptoregioncode = "M5";
                    }
                    else if (item.shiptoregioncode == "6")
                    {
                        item.shiptoregioncode = "M6";
                    }
                    else if (item.shiptoregioncode == "7")
                    {
                        item.shiptoregioncode = "MA";
                    }
                }
            }

            ViewBag.ParamList = this.uriParams;
            ViewBag.OrderPendingList = orderList;

            return View();
        }

        public IActionResult PendingPlan()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoadOrderPending(string trucktype, string shipto, string origin)
        {
            try
            {
                List<OrderPendingModel> orderList = orderRepo.GetWaitingList(trucktype, shipto, origin);

                return Json(new { data = orderList, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                //logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        //[HttpPost]
        //public ActionResult LoadDetailBookingList(string Businessgroup, string Customergroup, string Productgroup, string Status)
        //{
        //    try
        //    {
        //        List<OrderPendingDetailModel> orderList = orderRepo.GetDetailBookingList(Businessgroup, Customergroup, Productgroup, Status);

        //        return Json(new { data = orderList, status = true, message = "Successful" });
        //    }
        //    catch (Exception ex)
        //    {
        //        //logger.Error(ex, ex.Message);
        //        return Json(new { status = false, message = "Fail" });
        //    }
        //}

    }
}
