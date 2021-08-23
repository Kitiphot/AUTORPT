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
using GeoJSON.Net.Feature;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Data.SqlClient;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public class NetworkingRepository : INetworking
    {
        private string connectionString;
        private ConnectionStrings _connections;
        private string connectionString2;
        private INetworkingMaster nwm;
        static NLog.Logger logger = NLog.LogManager.GetLogger("SecurityLog");
        public NetworkingRepository(IConfiguration configuration,
            IOptions<ConnectionStrings> connections,
            INetworkingMaster nwm)
        {
            _connections = connections.Value;
            connectionString = _connections.PDLakeNetworkingConnection;
            connectionString2 = _connections.DFConnection;
            this.nwm = nwm;
        }

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        internal IDbConnection Connection2
        {
            get
            {
                return new SqlConnection(connectionString2);
            }
        }
        public TestDF Test()
        {
            try
            {
                using IDbConnection dbConnection = Connection2;
                dbConnection.Open();
                var data = dbConnection.Query<TestDF>("Select top 1 Cast(LoadID as nvarchar(20)) Output from T_Load");
                return data.FirstOrDefault();
            }
            catch(Exception ex)
            {
                return new TestDF { Output = ex.Message };
            }
        }

        //        public async Task<List<NetworkDetail>> GetCar(NetworkingCriteria criteria)
        //        {
        //            using IDbConnection dbConnection = Connection;
        //            dbConnection.Open();

        //            var sql_Where = "";

        //            //            var fixedlicensePlates = nwm.Car.Select(c => c.LicensePlate).ToList();
        //            //            //criteria.licensePlates.Clear();
        //            //            if ((fixedlicensePlates?.Count ?? 0) > 0)
        //            //            {
        //            //                sql_Where += @"
        //            //And a.plate = ANY(@fixedlicensePlates)
        //            //";
        //            //            }

        //            List<NetworkingShippingPoint> shippingPointList = new List<NetworkingShippingPoint>();
        //            if (!string.IsNullOrEmpty(criteria.Province) || ((criteria.ShippingPoint?.Count) ?? 0) > 0)
        //            {
        //                shippingPointList.AddRange(nwm.ShippingPoint.Where(c => !string.IsNullOrWhiteSpace(c.ShippingPointGroup)
        //                    && (c.Province == criteria.Province || string.IsNullOrWhiteSpace(criteria.Province))));

        //                if ((criteria.ShippingPoint?.Count ?? 0) > 0)
        //                {
        //                    shippingPointList.RemoveAll(c => !criteria.ShippingPoint.Any(f => f.ShippingPoint == c.ShippingPointGroup));
        //                }
        //            }

        //            var data = dbConnection.Query<NetworkDetail>(
        //$@"select  a.plate licenseplate
        //, a.latitude lat
        //, a.longitude long
        //from dom.gpssmc_alertlog a
        //Inner join (
        //	select  af.plate, max(af.create_time) create_time
        //	from	dom.gpssmc_alertlog af
        //	Group by
        //			af.plate
        //) f
        //On a.plate = f.plate
        //And a.create_time = f.create_time
        //Where 1 = 1
        //"
        //+ sql_Where
        //                , null
        //                , commandTimeout: 3000);

        //            var list = data.ToList();
        //            var rmCnt = list.RemoveAll(c => !nwm.Car.Any(f => f.LicensePlate == c.LicensePlate));
        //            foreach (var item in list)
        //            {
        //                item.HashCode = JsonConvert.SerializeObject(item).ToHash();
        //                var info = nwm.Car.FirstOrDefault(c => c.LicensePlate == item.LicensePlate);
        //                item.CarrierCode = info.CarrierCode;
        //                item.CarrierName = info.CarrierName;
        //                var fleet = nwm.Fleet.FirstOrDefault(c => c.FleetCode == info.FleetCode);
        //                item.FleetCode = fleet?.FleetCode;
        //                item.FleetName = fleet?.FleetName;
        //                var truckType = nwm.TruckType.FirstOrDefault(c => c.TruckTypeCode == info.TruckTypeCode);
        //                item.TruckTypeCode = truckType?.TruckTypeCode;
        //                item.TruckTypeName = truckType?.TruckTypeName;
        //                item.Province = nwm.GetProvinceName((double)item.Lat, (double)item.Long);
        //                var pvInfo = nwm.Province.FirstOrDefault(c => c.ProvinceEN == item.Province);
        //                item.ProvinceEN = pvInfo?.ProvinceEN;
        //                item.Province = pvInfo?.Province;
        //                item.ZoneCode = pvInfo?.ZoneCode;
        //                item.ZoneName = pvInfo?.ZoneCode;
        //                item.RegionCode = (pvInfo?.RegionCode ?? nwm.OtherRegion);
        //                item.RegionName = (pvInfo?.RegionCode ?? nwm.OtherRegion);

        //                item.IsDelete = item.IsDelete || (criteria.Wheel != null && !criteria.Wheel.Contains(truckType?.TruckTypeCode?.Substring(0, 2)) && criteria.Wheel.Count > 0);
        //                item.IsDelete = item.IsDelete || (criteria.TruckTypeCode != null && !criteria.TruckTypeCode.Contains(truckType?.TruckTypeCode) && criteria.TruckTypeCode.Count > 0);
        //                item.IsDelete = item.IsDelete || (!(criteria.RegionCode == null || criteria.RegionCode.Count == 0) && !criteria.RegionCode.Contains(pvInfo?.RegionCode));
        //                item.IsDelete = item.IsDelete || (!string.IsNullOrEmpty(criteria.ZoneCode) && criteria.ZoneCode != pvInfo?.ZoneCode);
        //                item.IsDelete = item.IsDelete || (!string.IsNullOrEmpty(criteria.Province) && criteria.Province != pvInfo?.Province);
        //                item.IsDelete = item.IsDelete || (!(criteria.FleetCode == null || criteria.FleetCode.Count == 0) && !criteria.FleetCode.Contains(fleet?.FleetCode));
        //                item.IsDelete = item.IsDelete || (!(criteria.CarrierCode == null || criteria.CarrierCode.Count == 0) && !criteria.CarrierCode.Contains(info?.CarrierCode));
        //                item.IsDelete = item.IsDelete || (criteria.Equipment != null && !(criteria.Equipment.Contains(info?.Equipment1)
        //                    || criteria.Equipment.Contains(info?.Equipment2)
        //                    || criteria.Equipment.Contains(info?.Equipment3)
        //                    || criteria.Equipment.Contains(info?.Equipment4)
        //                    || criteria.Equipment.Contains(info?.Equipment5)) && criteria.Equipment.Count > 0);
        //                item.IsDelete = item.IsDelete || (!string.IsNullOrEmpty(criteria.Status) && criteria.Status != Convert.ToString(item.Status));
        //                if (shippingPointList.Count > 0)
        //                {
        //                    foreach (var sp in shippingPointList)
        //                    {
        //                        var distance = GetDistinct(item.Lat, item.Long, sp.Latitude, sp.Longitude);
        //                        if (distance > 100) continue;
        //                        item.NearBy.Add(new NetworkingShippingPointDistance {
        //                            LocationCode = sp.LocationCode,
        //                            LocationName = sp.LocationName,
        //                            ShippingPoint = sp.ShippingPoint,
        //                            ShippingPointGroup = sp.ShippingPointGroup,
        //                            Latitude = sp.Latitude,
        //                            Longitude = sp.Longitude,
        //                            DistanceInKiloMeter = distance
        //                        });
        //                    }
        //                }
        //            }
        //            return list.Where(c => !c.IsDelete)
        //                .OrderBy(c => c.CarrierName)
        //                .ThenBy(c => c.RegionCode)
        //                .ThenBy(c => c.TruckTypeCode)
        //                .ThenBy(c => c.Province)
        //                .ThenBy(c => c.LicensePlate)
        //                .ToList();
        //        }
        public Task<IOrderedEnumerable<NetworkDetail>> ListCarLocation(NetworkingCriteria criteria)
        {
            return ListCarLocationFromDB(criteria);
        }
        public Task<IOrderedEnumerable<NetworkDetail>> ListCarLocationFromDB(NetworkingCriteria criteria)
        {

            return Task.Run(() =>
            {
                //await ListCarLocationFromAPI(criteria);
                List<double> timeList = new List<double>();
                TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
                TimeSpan stop;

                using IDbConnection dbConnection = Connection;
                dbConnection.Open();

                var sql_Where = "";
                if (criteria.mapBound != null)
                {
                    sql_Where += @"
And Case 
    when @nelng < @swlng then 
        Case when a.long < @nelng Or a.long > @swlng then 1 else 0 end
    else
        Case when a.long < @nelng And a.long > @swlng then 1 else 0 end
End 
+ Case when a.lat > @swlat And a.lat < @nelat then 1 else 0 end
= 2
";
                }

                List<NetworkingShippingPoint> shippingPointList = new List<NetworkingShippingPoint>();
                if (!string.IsNullOrEmpty(criteria.Province) || ((criteria.ShippingPoint?.Count) ?? 0) > 0)
                {
                    shippingPointList.AddRange(nwm.ShippingPoint.Where(c => !string.IsNullOrWhiteSpace(c.ShippingPointGroup)
                        && (c.Province == criteria.Province || string.IsNullOrWhiteSpace(criteria.Province))));

                    if ((criteria.ShippingPoint?.Count ?? 0) > 0)
                    {
                        shippingPointList.RemoveAll(c => !criteria.ShippingPoint.Any( f=> f.ShippingPoint == c.ShippingPointGroupDisplay));
                    }
                }

                var data = dbConnection.Query<NetworkDetail>(
//@"
//select  distinct on (a.plate) 
//a.plate licenseplate
//, a.fleet_name fleetName
//, c.driver_name drivername
//, c.driver_phone mobileNo
//, a.latitude lat
//, a.longitude long
//, a.first_time_latitude startlat
//, a.first_time_longitude startlong
//, a.position_name locate
//, Case when bs.status is null then 
//	Case when date_trunc('day', a.create_time) = CURRENT_DATE then 2 else 3 end
//when bs.status between 90 and 98 then 
//	2 
//else 
//	1 
//end status
//, bs.load_id loadid
//, substring(a.position_name, length(a.position_name)- length(regexp_replace(a.position_name, '.*' || ':','')) + 1, length(a.position_name)) province
//from dom.gpssmc_alertlog a
//Left join dom.gpssmc_vehicles c
//On a.plate = c.vehicle_plate
//And a.box_id = c.box_id
//Inner join (
//	select  af.plate, max(af.create_time) create_time
//	from	dom.gpssmc_alertlog af
//	Group by
//			af.plate
//) f
//On a.plate = f.plate
//And a.create_time = f.create_time
//Left join (
//	Select	case when date_trunc('day', ll.user_create_date) = CURRENT_DATE Or Min(ts.last_tracking_status) < 90 then ll.load_id else null end load_id
//			, Max(ll.driver_name) driver_name, ll.truck_license, Min(ts.last_tracking_status) status
//	From	dom.scvmvc_tms_load_leg ll
//			Inner join (
//				Select	mbs.truck_license, Max(mbs.user_create_date) user_create_date
//				From	dom.scvmvc_tms_load_leg mbs
//				Group by
//						mbs.truck_license
//			) mbs
//			On ll.truck_license = mbs.truck_license
//			And ll.user_create_date = mbs.user_create_date
//			Inner join dom.scvcor_delivery_tracking_status ts
//			On ll.load_id = ts.load_id
//	Group by
//			ll.load_id, ll.truck_license
//) bs
//On a.plate = bs.truck_license
//Where 1=1
//"
//@"
//select  distinct on (a.plate) 
//a.plate licenseplate
//, a.fleet_name fleetName
//, c.driver_name drivername
//, c.driver_phone mobileNo
//, a.latitude lat
//, a.longitude long
//, a.first_time_latitude startlat
//, a.first_time_longitude startlong
//, a.position_name locate
//, Case when date_trunc('day', a.create_time) = CURRENT_DATE then 2 else 3 end status
//, substring(a.position_name, length(a.position_name)- length(regexp_replace(a.position_name, '.*' || ':','')) + 1, length(a.position_name)) province
//from dom.gpssmc_alertlog a
//Left join dom.gpssmc_vehicles c
//On a.plate = c.vehicle_plate
//And a.box_id = c.box_id
//Inner join (
//	select  af.plate, max(af.create_time) create_time
//	from	dom.gpssmc_alertlog af
//	Group by
//			af.plate
//) f
//On a.plate = f.plate
//And a.create_time = f.create_time
//Where 1=1
//"
@"Select  * from target.networking_truck a Where 1=1 "
    + sql_Where + " Order by licenseplate"
                    , param: new
                    {
                        nelat = criteria.mapBound?.NorthEast?.Lat,
                        swlat = criteria.mapBound?.SouthWest?.Lat,
                        nelng = criteria.mapBound?.NorthEast?.Lng,
                        swlng = criteria.mapBound?.SouthWest?.Lng,
                    }
                    , commandTimeout: 3000);
                var truckStatus = dbConnection.Query<NetworkingTruckStatus>(
//@"
//	Select	case when date_trunc('day', ll.user_create_date) = CURRENT_DATE Or Min(ts.last_tracking_status) < 90 then ll.load_id else null end loadid
//			, Max(ll.driver_name) drivername, ll.truck_license LicensePlate, Min(ts.last_tracking_status) status
//	From	dom.scvmvc_tms_load_leg ll
//			Inner join (
//				Select	mbs.truck_license, Max(mbs.user_create_date) user_create_date
//				From	dom.scvmvc_tms_load_leg mbs
//				Group by
//						mbs.truck_license
//			) mbs
//			On ll.truck_license = mbs.truck_license
//			And ll.user_create_date = mbs.user_create_date
//			Inner join dom.scvcor_delivery_tracking_status ts
//			On ll.load_id = ts.load_id
//	Group by
//			ll.load_id, ll.truck_license
//"
@"Select * from target.networking_load"
                    , commandTimeout: 3000);
                stop = new TimeSpan(DateTime.Now.Ticks);
                //timeList.Add(stop.Subtract(start).TotalMilliseconds);
                //logger.Warn($"ListCarLocation: {stop.Subtract(start).TotalMilliseconds}");

                var list = data.Join(nwm.Car, gps => gps.LicensePlate, car => car.LicensePlate, (gps, car) => gps.SetCar(car));

                list = list.GroupJoin(truckStatus, gps => gps.LicensePlate, st => st.LicensePlate, (gps, st) => new { gps, st })
                    .SelectMany(c => c.st.DefaultIfEmpty(), (gpsSt, st) => gpsSt.gps.SetStatus(st));

                if (criteria.Wheel != null && criteria.Wheel.Count > 0)
                    list = list.Where(c => criteria.Wheel.Contains(c.TruckTypeCode.Substring(0, 2)));
                if (criteria.FleetCode != null && criteria.FleetCode.Count > 0)
                    list = list.Where(c => criteria.FleetCode.Contains(c.FleetCode));
                if (criteria.CarrierCode != null && criteria.CarrierCode.Count > 0)
                    list = list.Where(c => criteria.CarrierCode.Contains(c.CarrierCode));
                if (criteria.Equipment != null && criteria.Equipment.Count > 0)
                    list = list.Where(c => criteria.Equipment.Contains(c.Equipment1)
                        || criteria.Equipment.Contains(c.Equipment2)
                        || criteria.Equipment.Contains(c.Equipment3)
                        || criteria.Equipment.Contains(c.Equipment4)
                        || criteria.Equipment.Contains(c.Equipment5));

                list = list.GroupJoin(nwm.Fleet, gps => gps.FleetCode, fleet => fleet.FleetCode, (gps, fleet) => new { gps, fleet })
                    .SelectMany(c => c.fleet.DefaultIfEmpty(), (gpsFleet, fleet) => gpsFleet.gps.setFleet(fleet));

                list = list.GroupJoin(nwm.TruckType, gps => gps.TruckTypeCode, truck => truck.TruckTypeCode, (gps, truck) => new { gps, truck })
                    .SelectMany(c => c.truck.DefaultIfEmpty(), (gpsTruck, truck) => gpsTruck.gps.setTruck(truck));
                if (criteria.TruckTypeCode != null && criteria.TruckTypeCode.Count > 0)
                    list = list.Where(c => criteria.TruckTypeCode.Contains(c.TruckTypeCode));

                foreach (var region in nwm.GetRegion())
                {
                    var regionCode = region.DataValue_Key;
                    var provinces = nwm.Province.Where(c => c.RegionCode == regionCode).Select(c => c.ProvinceEN);
                    list = list.GroupJoin(nwm.Province, gps => gps.Province/*nwm.GetProvinceName((double)gps.Lat, (double)gps.Long)*/, pv => pv.Province, (gps, pv) => new { gps, pv })
                        .SelectMany(c => c.pv.DefaultIfEmpty(), (gpsPv, pv) => gpsPv.gps.setProvince(pv));
                }
                if (criteria.RegionCode != null && criteria.RegionCode.Count > 0)
                    list = list.Where(c => criteria.RegionCode.Contains(c.RegionCode));
                if (!string.IsNullOrWhiteSpace(criteria.ZoneCode))
                    list = list.Where(c => criteria.ZoneCode == c.ZoneCode);
                if (!string.IsNullOrWhiteSpace(criteria.Province))
                    list = list.Where(c => criteria.Province == c.Province);

                if (!string.IsNullOrWhiteSpace(criteria.Status))
                    list = list.Where(c => criteria.Status == Convert.ToString(c.Status));

                if (shippingPointList.Count > 0 || (criteria.licensePlates?.Count ?? 0) > 0)
                {
                    foreach (var item in list)
                    {
                        if (shippingPointList.Count > 0)
                        {
                            foreach (var sp in shippingPointList)
                            {
                                var dist = GetDistinct(item.Lat, item.Long, sp.Latitude, sp.Longitude);
                                if (((criteria.ShippingPoint?.Count ?? 0) > 0 && dist > ((criteria.ShippingPoint.FirstOrDefault(c => c.ShippingPoint == sp.ShippingPointGroupDisplay)?.Distanct) ?? 0))
                                || ((criteria.ShippingPoint?.Count ?? 0) <= 0 && dist > 100)) continue;
                                item.NearBy.Add(new NetworkingShippingPointDistance
                                {
                                    LocationCode = sp.LocationCode,
                                    LocationName = sp.LocationName,
                                    ShippingPoint = sp.ShippingPoint,
                                    ShippingPointGroup = sp.ShippingPointGroup,
                                    ShippingPointGroupDisplay = sp.ShippingPointGroupDisplay,
                                    Latitude = sp.Latitude,
                                    Longitude = sp.Longitude,
                                    DistanceInKiloMeter = dist
                                });
                            }
                            item.NearBy = item.NearBy.OrderBy(c => c.DistanceInKiloMeter).ToList();
                        }
                        else
                        {
                            if ((criteria.licensePlates?.Count ?? 0) > 0)
                            {
                                foreach (var sp in nwm.ShippingPoint.Where(c => c.Province == item.Province && !string.IsNullOrEmpty(c.ShippingPointGroup)))
                                {
                                    var dist = GetDistinct(item.Lat, item.Long, sp.Latitude, sp.Longitude);
                                    if (dist > 100) continue;
                                    item.NearBy.Add(new NetworkingShippingPointDistance
                                    {
                                        LocationCode = sp.LocationCode,
                                        LocationName = sp.LocationName,
                                        ShippingPoint = sp.ShippingPoint,
                                        ShippingPointGroup = sp.ShippingPointGroup,
                                        ShippingPointGroupDisplay = sp.ShippingPointGroupDisplay,
                                        Latitude = sp.Latitude,
                                        Longitude = sp.Longitude,
                                        DistanceInKiloMeter = dist
                                    });
                                }
                                item.NearBy = item.NearBy.OrderBy(c => c.DistanceInKiloMeter).ToList();
                            }
                        }
                    }

                    if ((criteria.licensePlates?.Count ?? 0) <= 0 && (criteria.ShippingPoint?.Count ?? 0) > 0)
                    {
                        list = list.Where(c => ((c.NearBy?.Count) ?? 0) > 0);
                    }
                }

                var result = list
                    .OrderBy(c => c.CarrierName)
                    .ThenBy(c => c.RegionCode)
                    .ThenBy(c => c.TruckTypeCode)
                    .ThenBy(c => c.Province)
                    .ThenBy(c => c.LicensePlate);
                return result;
            });
        }
        public async Task ListCarLocationFromAPI(NetworkingCriteria criteria)
        {
            List<VehicleInfo> allVehicles = new List<VehicleInfo>();
            int offset = 0;
            int cnt = 0;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan stop;
            while (offset == 0 || cnt > 0)
            {
                var licenses = nwm.Car.Skip(offset).Take(1000).Select(c => c.LicensePlate);
                cnt = licenses.Count();
                offset += 1000;
                string allLicenses = string.Join(",", licenses);
                HttpClient client = new HttpClient();
                var content = new StringContent($"{{ \"Job\":\"DISPLAY_VEHICLE_INFO\", \"Request\":{{ \"VehicleName\":\"{allLicenses}\" }} }}", Encoding.UTF8, "application/json");
                content.Headers.Add("x-access-token", "6qa9LzK)Phy;il+");
                var result = await client.PostAsync("https://apiws.xsense.co.th/giztix/vehicle/info", content);
                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    var vhicleResult = JsonConvert.DeserializeObject<VehicleResult>(data);
                    if (vhicleResult.Response.Result)
                    {
                        allVehicles.AddRange(vhicleResult.Response.Vehicles);
                    }
                }
            }
            stop = new TimeSpan(DateTime.Now.Ticks);
            //timeList.Add(stop.Subtract(start).TotalMilliseconds);
            logger.Warn($"ListCarLocationFromAPI: Execute {stop.Subtract(start).TotalMilliseconds} ms {allVehicles.Count} rows");
        }

        private double GetDistinct(decimal latitude1, decimal longitude1, decimal latitude2, decimal longitude2)
        {
            double lon1 = toRadians(longitude1);
            double lon2 = toRadians(longitude2);
            double lat1 = toRadians(latitude1);
            double lat2 = toRadians(latitude2);

            // Haversine formula  
            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Pow(Math.Sin(dlon / 2), 2);

            double c = 2 * Math.Asin(Math.Sqrt(a));

            // Radius of earth in  
            // kilometers. Use 3956  
            // for miles 
            double r = 6371;

            // calculate the result 
            return (c * r);
        }
        private double toRadians(decimal angleIn10thofaDegree)
        {
            // Angle in 10th 
            // of a degree 
            return ((double)angleIn10thofaDegree * Math.PI) / 180.0;
        }

        public List<NetworkSummaryGroupByRegion> GetNetworkSummaryGroupByRegion(NetworkingCriteria criteria)
        {
            return null;
        }
        
        public List<NetworkSummaryGroupByZone> GetNetworkSummaryGroupByZone(NetworkingCriteria criteria)
        {
            return null;
        }

        public List<NetworkSummaryGroupByShippingPoint> GetNetworkSummaryGroupByShippingPoint(NetworkingCriteria criteria)
        {
            return null;
        }

        public FeatureCollection GetBound(List<string> regionCode, string zoneCode, string file)
        {
            FeatureCollection result = new FeatureCollection();
            //if (string.IsNullOrEmpty(file))
                result.Features.AddRange(nwm.GeoJSONFast.Features.Where(c => 
                    (regionCode == null || regionCode.Contains((string)c.Properties["regionCode"]))
                    && (string.IsNullOrEmpty(zoneCode) || (string)c.Properties["zoneCode"] == zoneCode)));
            //else if (file == "1")
            //    result.Features.AddRange(nwm.GeoJSON.Features.Where(c =>
            //        (regionCode == null || regionCode.Contains((string)c.Properties["regionCode"]))
            //        && (string.IsNullOrEmpty(zoneCode) || (string)c.Properties["zoneCode"] == zoneCode)));

            return result;
        }
    }
}
