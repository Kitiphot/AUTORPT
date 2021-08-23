using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;
using Microsoft.AspNetCore.Http;
using System.IO;
using OfficeOpenXml;
using System.Net.Http;
using System.Net;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class NetworkingController : Controller
    {
        private readonly INetworking nw;
        private readonly INetworkingMaster nwm;
        static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public NetworkingController(INetworking nw, INetworkingMaster nwm)
        {
            this.nw = nw;
            this.nwm = nwm;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }

        public IActionResult Summary()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public async Task<IActionResult> SummaryCarByProvince(NetworkingCriteria criteria)
        {
            try
            {
                var list = await nw.ListCarLocation(criteria);
                var grouped = list.GroupBy(c => c.Province)
                    .Select(c => new {
                        Province = c.Key,
                        ZoneCode = c.Max(g => g.ZoneCode),
                        ZoneName = c.Max(g => g.ZoneName),
                        RegionCode = c.Max(g => g.RegionCode),
                        RegionName = c.Max(g => g.RegionName),
                        LightCount = c.Count(g => g.Status == 2),
                        HeavyCount = c.Count(g => g.Status == 1)
                    });
                return Json(new { data = grouped, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SummaryCarByRegion");
                return Json(new { data = ex.Message, success = false });
            }
        }

        public async Task<IActionResult> SummaryCarByRegion(NetworkingCriteria criteria)
        {
            try
            {
                var list = await nw.ListCarLocation(criteria);
                var grouped = list.GroupBy(c => c.RegionCode)
                    .Select(c => new { 
                        RegionCode = c.Key, 
                        RegionName = c.Max(g => g.RegionName), 
                        LightCount = c.Count(g => g.Status == 2), 
                        HeavyCount = c.Count(g => g.Status == 1) });
                return Json(new { data = grouped, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SummaryCarByRegion");
                return Json(new { data = ex.Message, success = false });
            }
        }

        public async Task<IActionResult> SummaryCarByZone(NetworkingCriteria criteria)
        {
            try
            {
                var list = await nw.ListCarLocation(criteria);
                var grouped = list.GroupBy(c => c.ZoneCode)
                    .Select(c => new { 
                        ZoneCode = c.Key, 
                        ZoneName = c.Max(g => g.ZoneName), 
                        RegionCode = c.Max(g => g.RegionCode), 
                        RegionName = c.Max(g => g.RegionName), 
                        LightCount = c.Count(g => g.Status == 2), 
                        HeavyCount = c.Count(g => g.Status == 1) });
                return Json(new { data = grouped, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SummaryCarByZone");
                return Json(new { data = ex.Message, success = false });
            }
        }

        public async Task<IActionResult> ListCarLocation(NetworkingCriteria criteria)
        {
            List<double> timeList = new List<double>();
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);
            try
            {
                var result = await nw.ListCarLocation(criteria);
                start = new TimeSpan(DateTime.Now.Ticks);
                return Json(new { data = result.ToList(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ListCarLocation");
                return Json(new { data = ex.Message, success = false });
            }
            finally
            {
                stop = new TimeSpan(DateTime.Now.Ticks);
                timeList.Add(stop.Subtract(start).TotalMilliseconds);
            }
        }

        public IActionResult GetCar(NetworkingCriteria criteria)
        {
            try
            {
                List<NetworkDetail> list = new List<NetworkDetail>();
                //list = await nw.GetCar(criteria);
                //var result = list.Select(c =>
                //new MiscDataSelectionModel
                //{
                //    DataDisplay = c.LicensePlate,
                //    DataValue_Key = c.LicensePlate
                //}).OrderBy(c => c.DataDisplay);
                return Json(new { data = list, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetCar");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetWheel()
        {
            try
            {
                return Json(new { data = nwm.GetWheel(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetWheel");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetProvince(NetworkingCriteria criteria)
        {
            try
            {
                return Json(new { data = nwm.GetProvince(criteria.RegionCode, criteria.ZoneCode), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetProvince");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetRegionAndZone()
        {
            try
            {
                return Json(new { data = nwm.GetRegionAndZone(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetRegionAndZone");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetRegion()
        {
            try
            {
                return Json(new { data = nwm.GetRegion(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetRegion");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetTruckType(NetworkingCriteria criteria)
        {
            try
            {
                return Json(new { data = nwm.GetTruckType(criteria.Wheel), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetTruckType");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetZone(NetworkingCriteria criteria)
        {
            try
            {
                return Json(new { data = nwm.GetZone(criteria.RegionCode.FirstOrDefault()), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetZone");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetEquipment()
        {
            try
            {
                return Json(new { data = nwm.GetEquipment(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetEquipment");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetCarrier(NetworkingCriteria criteria)
        {
            try
            {
                return Json(new { data = nwm.GetCarrier(criteria.FleetCode), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetCarrier");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetFleet()
        {
            try
            {
                return Json(new { data = nwm.GetFleet(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetFleet");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetProvinceByShippingPoint(string shippingPointGroup)
        {
            try
            {
                return Json(new { data = nwm.ShippingPoint.FirstOrDefault(c => c.ShippingPointGroup == shippingPointGroup)?.Province, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetProvinceByShippingPoint");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetShippingPoint(NetworkingCriteria criteria)
        {
            try
            {
                return Json(new { data = nwm.GetShippingPoint(criteria.RegionCode, criteria.ZoneCode, criteria.Province), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetShippingPoint");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetStatus()
        {
            try
            {
                return Json(new { data = nwm.GetStatus(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetStatus");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetFuel()
        {
            try
            {
                return Json(new { data = nwm.GetFuel(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetFuel");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetShippingPointGroup(NetworkingCriteria criteria)
        {
            try
            {
                return Json(new { data = nwm.GetShippingPointGroup(criteria.RegionCode, criteria.ZoneCode, criteria.Province), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetShippingPointGroup");
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        public IActionResult GetBound(NetworkingCriteria criteria)
        {
            try
            {
                return Json(new { data = nw.GetBound(criteria.RegionCode, criteria.ZoneCode, criteria.File), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetBound");
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
