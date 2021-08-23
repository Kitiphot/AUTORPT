using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Npgsql;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Security;
using OfficeOpenXml;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using System.Drawing;
using NLog;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public class NetworkingMasterRepository : INetworkingMaster
    {
        private const string PROVINCE_NAME_EN = "name:en";
        static Logger logger = LogManager.GetLogger("Networking");
        public string OtherRegion { get; set; } = "MA";
        public List<NetworkingProvince> Province { get; set; } = null;
        public List<NetworkingFleet> Fleet { get; set; } = null;
        public List<NetworkingCar> Car { get; set; } = null;
        public List<NetworkingTruckType> TruckType { get; set; } = null;
        public List<NetworkingEquipment> Equipment { get; set; } = null;
        public List<NetworkingShippingPoint> ShippingPoint { get; set; } = null;
        public FeatureCollection GeoJSON { get; set; }
        //public FeatureCollection GeoJSONNoBuengKan { get; set; }
        public FeatureCollection GeoJSONFast { get; set; }
        public NetworkingMasterRepository(IHostingEnvironment env)
        {
            string[] masterSheets = new string[] { "Province", "Fleet", "Truck", "Equipment", "ShippingPoint" };
            var fl = new FileInfo(Path.Combine(env.WebRootPath, @"Templates\Networking\Networking.xlsx"));
            using ExcelPackage pack = new ExcelPackage(fl);
            var wb = pack.Workbook;
            var ws = wb.Worksheets["Province"];
            Province = new List<NetworkingProvince>();
            for (int row = 2; row <= ws.Dimension.End.Row; row++)
            {
                if (string.IsNullOrEmpty(ws.Cells[$"B{row}"].Text)) break;
                Province.Add(
                new NetworkingProvince {
                    Province = ws.Cells[$"B{row}"].Text,
                    ProvinceEN = ws.Cells[$"C{row}"].Text,
                    RegionCode = ws.Cells[$"D{row}"].Text,
                    ZoneCode = ws.Cells[$"E{row}"].Text,
                    RegionName = ws.Cells[$"I{row}"].Text,
                });
            }

            ws = wb.Worksheets["Fleet"];
            Fleet = new List<NetworkingFleet>();
            for (int row = 2; row <= ws.Dimension.End.Row; row++)
            {
                if (string.IsNullOrEmpty(ws.Cells[$"A{row}"].Text)) break;
                Fleet.Add(
                new NetworkingFleet
                {
                    //FleetCode = $"F{ws.Cells[$"A{row}"].Text.PadLeft(3, '0')}",
                    FleetCode = $"{ws.Cells[$"A{row}"].Text}",
                    FleetName = ws.Cells[$"B{row}"].Text,
                    PIC = ws.Cells[$"C{row}"].Text,
                });
            }

            Car = new List<NetworkingCar>();
            for (int i = 0; i < wb.Worksheets.Count; i++)
            {
                ws = wb.Worksheets[i];
                if (masterSheets.Contains(ws.Name)) continue;
                for (int row = 2; row <= ws.Dimension.End.Row; row++)
                {
                    if (string.IsNullOrEmpty(ws.Cells[$"D{row}"].Text)) break;
                    Car.Add(
                    new NetworkingCar
                    {
                        //FleetCode = ws.Name,
                        FleetCode = ws.Cells[$"A{row}"].Text,
                        CarrierCode = ws.Cells[$"B{row}"].Text,
                        TruckTypeCode = ws.Cells[$"C{row}"].Text,
                        LicensePlate = LicensePlateFormat(ws.Cells[$"D{row}"].Text),
                        LicensePlateTrailer = ws.Cells[$"E{row}"].Text,
                        Equipment1 = ws.Cells[$"F{row}"].Text,
                        Equipment2 = ws.Cells[$"G{row}"].Text,
                        Equipment3 = ws.Cells[$"H{row}"].Text,
                        Equipment4 = ws.Cells[$"I{row}"].Text,
                        Equipment5 = ws.Cells[$"J{row}"].Text,
                        CarrierName = ws.Cells[$"K{row}"].Text
                    });
                }
            }

            ws = wb.Worksheets["Truck"];
            TruckType = new List<NetworkingTruckType>();
            for (int row = 2; row <= ws.Dimension.End.Row; row++)
            {
                if (string.IsNullOrEmpty(ws.Cells[$"B{row}"].Text)) break;
                TruckType.Add(
                new NetworkingTruckType
                {
                    TruckTypeCode = ws.Cells[$"B{row}"].Text,
                    TruckTypeName = ws.Cells[$"A{row}"].Text,
                });
            }

            ws = wb.Worksheets["Equipment"];
            Equipment = new List<NetworkingEquipment>();
            for (int row = 2; row <= ws.Dimension.End.Row; row++)
            {
                if (string.IsNullOrEmpty(ws.Cells[$"A{row}"].Text)) break;
                Equipment.Add(
                new NetworkingEquipment
                {
                    //FleetCode = $"F{ws.Cells[$"A{row}"].Text.PadLeft(3, '0')}",
                    EquipmentName = ws.Cells[$"A{row}"].Text
                });
            }

            ws = wb.Worksheets["ShippingPoint"];
            ShippingPoint = new List<NetworkingShippingPoint>();
            for (int row = 2; row <= ws.Dimension.End.Row; row++)
            {
                if (string.IsNullOrEmpty(ws.Cells[$"A{row}"].Text)) break;
                ShippingPoint.Add(
                new NetworkingShippingPoint
                {
                    LocationCode = ws.Cells[$"A{row}"].Text,
                    LocationName = ws.Cells[$"B{row}"].Text,
                    Amphur = ws.Cells[$"C{row}"].Text,
                    Province = ws.Cells[$"D{row}"].Text,
                    RegionCode = ws.Cells[$"E{row}"].Text,
                    ShippingPoint = ws.Cells[$"F{row}"].Text,
                    Latitude = Decimal.Parse(ws.Cells[$"H{row}"].Text),
                    Longitude = Decimal.Parse(ws.Cells[$"I{row}"].Text),
                    ShippingPointGroup = ws.Cells[$"J{row}"].Text,
                });
            }

            //GeoJSON = JsonConvert.DeserializeObject<FeatureCollection>(File.ReadAllText(Path.Combine(env.WebRootPath, @"Templates\Networking\thailand.json")));
            //GeoJSONNoBuengKan = JsonConvert.DeserializeObject<FeatureCollection>(File.ReadAllText(Path.Combine(env.WebRootPath, @"Templates\Networking\thailand_no_bueng_kan.json")));
            GeoJSONFast = JsonConvert.DeserializeObject<FeatureCollection>(File.ReadAllText(Path.Combine(env.WebRootPath, @"Templates\Networking\thailand_fast.json")));

            Dictionary<string, string> colorByRegion = new Dictionary<string, string>();
            colorByRegion.Add("M1", "#EBD63D");
            colorByRegion.Add("M2", "#D0E382");
            colorByRegion.Add("M3", "#FF99FF");
            colorByRegion.Add("M4", "#E6AF73");
            colorByRegion.Add("M5", "#69C2C2");
            colorByRegion.Add("M6", "#8A9FD2");

            Dictionary<string, string> colorByZone = new Dictionary<string, string>();
            colorByZone.Add("โซน 1", "#EBD63D");
            colorByZone.Add("โซน 2", "#D0E382");
            colorByZone.Add("โซน 3", "#FF99FF");
            colorByZone.Add("โซน 4", "#E6AF73");
            colorByZone.Add("โซน 5", "#69C2C2");
            colorByZone.Add("โซน 6", "#8A9FD2");
            colorByZone.Add("โซน 7", "#0000ff");
            colorByZone.Add("โซน 8", "#99ff99");

            //string pvAll = "";
            string provincePropName;
            //provincePropName = "NAME_1";
            //foreach (var feature in GeoJSONNoBuengKan.Features)
            //{
            //    feature.Properties.Add("regionCode", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[provincePropName]).RegionCode);
            //    feature.Properties.Add("regionName", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[provincePropName]).RegionName);
            //    feature.Properties.Add("zoneCode", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[provincePropName]).ZoneCode);
            //    feature.Properties.Add("provinceName", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[provincePropName]).Province);
            //    feature.Properties.Add("regionColor", colorByRegion[(string)feature.Properties["regionCode"]]);
            //    if (colorByZone.ContainsKey((string)feature.Properties["zoneCode"]))
            //        feature.Properties.Add("zoneColor", colorByZone[(string)feature.Properties["zoneCode"]]);
            //    else
            //        feature.Properties.Add("zoneColor", colorByRegion[(string)feature.Properties["regionCode"]]);
            //}
            provincePropName = "name";
            foreach (var feature in GeoJSONFast.Features)
            {
                feature.Properties.Add("regionCode", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[provincePropName]).RegionCode);
                feature.Properties.Add("regionName", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[provincePropName]).RegionName);
                feature.Properties.Add("zoneCode", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[provincePropName]).ZoneCode);
                feature.Properties.Add("provinceName", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[provincePropName]).Province);
                feature.Properties.Add("regionColor", colorByRegion[(string)feature.Properties["regionCode"]]);
                if (colorByZone.ContainsKey((string)feature.Properties["zoneCode"]))
                    feature.Properties.Add("zoneColor", colorByZone[(string)feature.Properties["zoneCode"]]);
                else
                    feature.Properties.Add("zoneColor", colorByRegion[(string)feature.Properties["regionCode"]]);
            }
            //string provinces = "";
            //foreach (var feature in GeoJSON.Features)
            //{
            //    //string polyString = "";

            //    feature.Properties.Add("regionCode", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[PROVINCE_NAME_EN]).RegionCode);
            //    feature.Properties.Add("regionName", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[PROVINCE_NAME_EN]).RegionName);
            //    feature.Properties.Add("zoneCode", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[PROVINCE_NAME_EN]).ZoneCode);
            //    feature.Properties.Add("provinceName", Province.FirstOrDefault(c => c.ProvinceEN == (string)feature.Properties[PROVINCE_NAME_EN]).Province);
            //    feature.Properties.Add("regionColor", colorByRegion[(string)feature.Properties["regionCode"]]);
            //    if (colorByZone.ContainsKey((string)feature.Properties["zoneCode"]))
            //        feature.Properties.Add("zoneColor", colorByZone[(string)feature.Properties["zoneCode"]]);
            //    else
            //        feature.Properties.Add("zoneColor", colorByRegion[(string)feature.Properties["regionCode"]]);
            //    provinces += "zoomPosition.set(JSON.stringify({ province: '" + (string)feature.Properties["provinceName"] + "' }), null);";
            //    var poly = feature.Geometry as Polygon;
            //    double minLat = double.MaxValue, maxLat = double.MinValue, minLng = double.MaxValue, maxLng = double.MinValue;
            //    if (poly != null)
            //    {
            //        foreach (var pt in poly.Coordinates[0].Coordinates)
            //        {
            //            if (pt.Latitude > maxLat)
            //                maxLat = pt.Latitude;
            //            if (pt.Latitude < minLat)
            //                minLat = pt.Latitude;
            //            if (pt.Longitude > maxLng)
            //                maxLng = pt.Longitude;
            //            if (pt.Longitude < minLng)
            //                minLng = pt.Longitude;
            //            //if (!string.IsNullOrWhiteSpace(polyString))
            //            //    polyString += ",";
            //            //polyString += $"{pt.Latitude} {pt.Longitude}";
            //        }
            //        //polyString = $"ST_GeomFromText('POLYGON(({polyString}))')";
            //    }
            //    else
            //    {
            //        var mpoly = feature.Geometry as MultiPolygon;
            //        foreach (var ipoly in mpoly.Coordinates)
            //        {
            //            //string tempPolyString = "";
            //            foreach (var pt in ipoly.Coordinates[0].Coordinates)
            //            {
            //                if (pt.Latitude > maxLat)
            //                    maxLat = pt.Latitude;
            //                if (pt.Latitude < minLat)
            //                    minLat = pt.Latitude;
            //                if (pt.Longitude > maxLng)
            //                    maxLng = pt.Longitude;
            //                if (pt.Longitude < minLng)
            //                    minLng = pt.Longitude;

            //                //if (!string.IsNullOrWhiteSpace(tempPolyString))
            //                //    tempPolyString += ",";
            //                //tempPolyString += $"{pt.Latitude} {pt.Longitude}";
            //            }
            //            //if (!string.IsNullOrWhiteSpace(polyString))
            //            //    polyString += ",";
            //            //polyString += $"({tempPolyString})";
            //        }
            //        //polyString = $"ST_GeomFromText('MULTIPOLYGON(({polyString}))')";
            //    }
            //    feature.Properties.Add("MinLat", minLat);
            //    feature.Properties.Add("MaxLat", maxLat);
            //    feature.Properties.Add("MinLng", minLng);
            //    feature.Properties.Add("MaxLng", maxLng);

            //    //string pv = $"'{(string)feature.Properties[PROVINCE_NAME_EN]}', {polyString}";
            //    //pvAll += "Insert into dom.metadata_province_boundary values " + Environment.NewLine + "(" + pv + ");" + Environment.NewLine;
            //}
            //Console.WriteLine(pvAll);
        }

        public string LicensePlateFormat(string licensePlate)
        {
            if (licensePlate.Contains("|"))
                return licensePlate;
            else
            {
                var data = licensePlate.Split("-");
                return $"{data[1]}-{data[2]}|{data[0]}";
            }
        }
        public string GetProvinceName(double latitude, double longitude)
        {
            var possibleFeatures = GeoJSON.Features.Where(feature => 
                (latitude >= (double)feature.Properties["MinLat"] 
                && latitude <= (double)feature.Properties["MaxLat"]
                && longitude >= (double)feature.Properties["MinLng"] 
                && longitude <= (double)feature.Properties["MaxLng"])).ToArray();
            for (int idx = 0; idx < possibleFeatures.Length; idx++)
            {
                var feature = possibleFeatures[idx];

                var province = (string)feature.Properties[PROVINCE_NAME_EN];

                if (feature.Geometry is Polygon poly)
                {
                    //var poly = feature.Geometry as Polygon;
                    var found = IsPointInPolygon(poly.Coordinates[0].Coordinates, latitude, longitude);
                    if (found)
                    {
                        return province;
                    }
                }
                else
                {
                    var mpoly = feature.Geometry as MultiPolygon;
                    for (int i = 0; i < mpoly.Coordinates.Count; i++)
                    {
                        var ipoly = mpoly.Coordinates[i];
                        var found = IsPointInPolygon(ipoly.Coordinates[0].Coordinates, latitude, longitude);
                        if (found)
                        {
                            return province;
                        }
                    }
                }
            }
            return "";
        }
        bool IsPointInPolygon(IList<IPosition> poly, double lat, double lng)
        {
            // ray-casting algorithm based on
            // https://wrf.ecse.rpi.edu/Research/Short_Notes/pnpoly.html/pnpoly.html
            var inside = false;
            for (int i = 0, j = poly.Count - 1; i < poly.Count; j = i++)
            {
                var intersect = ((poly[i].Latitude > lat) != (poly[j].Latitude > lat))
                    && (lng < (poly[j].Longitude - poly[i].Longitude) * (lat - poly[i].Latitude) / (poly[j].Latitude - poly[i].Latitude) + poly[i].Longitude);
                if (intersect) inside = !inside;
            }

            return inside;
        }

        double isLeft(IPosition P0, IPosition P1, IPosition P2)
        {
            return ((P1.Longitude - P0.Longitude) * (P2.Latitude - P0.Latitude)
                    - (P2.Longitude - P0.Longitude) * (P1.Latitude - P0.Latitude));
        }

        public List<MiscDataSelectionModel> GetWheel()
        {
            var list = TruckType
                .Where(c => !string.IsNullOrEmpty(c.TruckTypeCode))
                .Select(c => new { WheelCode = c.TruckTypeCode.Substring(0, 2) })
                .Distinct().OrderBy(c => c.WheelCode).Select(c => new MiscDataSelectionModel
            {
                DataDisplay = $"{c.WheelCode.Substring(0, 2).TrimStart('0')}W",
                DataValue_Key = c.WheelCode.Substring(0, 2)
            }).ToList();
            return list;
        }

        public List<MiscDataSelectionModel> GetTruckType(List<string> wheels)
        {
            return TruckType.Where(c => wheels == null || wheels.Count == 0 ||  wheels.Contains(c.TruckTypeCode.Substring(0, 2)))
                .Where(c => !string.IsNullOrEmpty(c.TruckTypeCode))
                .OrderBy(c => c.TruckTypeName)
                .Select(c => new MiscDataSelectionModel
            {
                DataDisplay = c.TruckTypeName,
                DataValue_Key = c.TruckTypeCode
            }).ToList();
        }

        public List<MiscDataSelectionModel> GetEquipment()
        {
            return Equipment.Select(c => new MiscDataSelectionModel
            {
                DataDisplay = c.EquipmentName,
                DataValue_Key = c.EquipmentName
            }).ToList();
        }

        public List<MiscDataSelectionModel> GetFleet()
        {
            return Fleet.Select(c => new MiscDataSelectionModel
            {
                DataDisplay = c.FleetName,
                DataValue_Key = c.FleetCode
            }).ToList();
        }

        public List<MiscDataSelectionModel> GetProvince()
        {
            return Province.Select(c => new MiscDataSelectionModel
            {
                DataDisplay = c.Province,
                DataValue_Key = c.Province
            }).ToList();
        }

        public List<MiscDataSelectionWithDataModel> GetRegionAndZone()
        {
            var list = new List<MiscDataSelectionWithDataModel>();
            foreach(var regionCode in Province.Where(c => !string.IsNullOrEmpty(c.RegionCode)).Select(c => c.RegionCode).Distinct().OrderBy(c => c))
            {
                string regionText = Province.FirstOrDefault(f => f.RegionCode == regionCode).RegionName;
                list.Add(new MiscDataSelectionWithDataModel
                {
                    DataDisplay = regionText,
                    DataValue_Key = regionCode,
                    IsSubItem = false
                });
                list.AddRange(GetZone(regionCode).Select(c => new MiscDataSelectionWithDataModel
                {
                    DataDisplay = c.DataDisplay,
                    DataValue_Key = @"{""regionCode"":"""+ regionCode + @""",""zoneCode"":""" + c.DataValue_Key + @"""}",
                    IsSubItem = true,
                    ParentKey = regionCode,
                    ParentText = regionText
                }));
            }
            list.Add(new MiscDataSelectionWithDataModel
            {
                DataDisplay = OtherRegion,
                DataValue_Key = OtherRegion,
                IsSubItem = false
            });
            return list;
        }

        public List<MiscDataSelectionModel> GetRegion()
        {
            var list = Province
                .Where(c => !string.IsNullOrEmpty(c.RegionCode))
                .Select(c => c.RegionCode).Distinct().Select(c => new MiscDataSelectionModel
            {
                DataDisplay = Province.FirstOrDefault(f => f.RegionCode == c).RegionName,
                DataValue_Key = c
            }).ToList();
            list.Add(new MiscDataSelectionModel { 
                DataDisplay = OtherRegion,
                DataValue_Key = OtherRegion
            });
            return list;
        }

        public List<MiscDataSelectionModel> GetZone(string regionCode)
        {
            return Province.Where(c => string.IsNullOrEmpty(regionCode) || c.RegionCode == regionCode)
                .Where(c => !string.IsNullOrEmpty(c.ZoneCode))
                .Select(c => c.ZoneCode).Distinct().Select(c => new MiscDataSelectionModel
            {
                DataDisplay = c,
                DataValue_Key = c
            }).OrderBy(c => c.DataValue_Key).ToList();
        }

        public List<MiscDataSelectionWithRawModel> GetProvince(List<string> regionCode, string zoneCode)
        {
            return Province.Where(c => (regionCode == null || regionCode.Count == 0 || regionCode.Contains(c.RegionCode)) 
            && (string.IsNullOrEmpty(zoneCode) || c.ZoneCode == zoneCode))
                .Where(c => !string.IsNullOrEmpty(c.ProvinceEN))
                .Select(c => new MiscDataSelectionWithRawModel
            {
                DataDisplay = c.Province,
                DataValue_Key = c.Province,
                Json = JsonConvert.SerializeObject(c)
                }).ToList();
        }

        public List<MiscDataSelectionModel> GetCarrier(List<string> fleetCode)
        {
            return Car
                .Where(c => (((fleetCode?.Count) ?? 0) == 0) || fleetCode.Contains(c.FleetCode))
                .Select(c => new { c.CarrierCode, c.CarrierName })
                .Where(c => !string.IsNullOrEmpty(c.CarrierCode))
                .Distinct()
                .Select(c => new MiscDataSelectionModel
                {
                    DataDisplay = c.CarrierName,
                    DataValue_Key = c.CarrierCode
                }).ToList();
        }

        public List<MiscDataSelectionModel> GetStatus()
        {
            var list = new List<MiscDataSelectionModel>();
            list.Add(new MiscDataSelectionModel { DataDisplay = "รถหนัก", DataValue_Key = "1" });
            list.Add(new MiscDataSelectionModel { DataDisplay = "รถเบา", DataValue_Key = "2" });
            list.Add(new MiscDataSelectionModel { DataDisplay = "ไม่สตาร์ทรถ", DataValue_Key = "3" });
            return list;
        }
        public List<MiscDataSelectionModel> GetFuel()
        {
            var list = new List<MiscDataSelectionModel>();
            list.Add(new MiscDataSelectionModel { DataDisplay = "NGV", DataValue_Key = "NGV" });
            list.Add(new MiscDataSelectionModel { DataDisplay = "Oil", DataValue_Key = "Oil" });
            return list;
        }
        public List<MiscDataSelectionModel> GetShippingPointGroup(List<string> regionCode, string zoneCode, string province)
        {
            var provinceList = GetProvince(regionCode, zoneCode);
            var list = ShippingPoint.Where(c => (regionCode == null || regionCode.Count == 0 || regionCode.Contains(c.RegionCode))
                    && (string.IsNullOrEmpty(zoneCode) || provinceList.Any(f => f.DataValue_Key == c.Province))
                    && (string.IsNullOrEmpty(province) || c.Province == province)
                )
                .Where(c => !string.IsNullOrEmpty(c.ShippingPointGroup))
                .Select(c => c.ShippingPointGroupDisplay).Distinct()
                .OrderBy(c => c)
                .Select(c => new MiscDataSelectionModel { DataDisplay = c, DataValue_Key = c })
                .ToList();
            return list;
        }
        public List<NetworkingShippingPoint> GetShippingPoint(List<string> regionCode, string zoneCode, string province)
        {
            var provinceList = GetProvince(regionCode, zoneCode);
            var list = ShippingPoint.Where(c => (regionCode == null || regionCode.Count == 0 || regionCode.Contains(c.RegionCode))
                    && (string.IsNullOrEmpty(zoneCode) || provinceList.Any(f => f.DataValue_Key == c.Province))
                    && (string.IsNullOrEmpty(province) || c.Province == province)
                )
                .Where(c => !string.IsNullOrEmpty(c.ShippingPointGroup))
                .OrderBy(c => c.LocationName)
                .ToList();
            return list;
        }
    }
}
