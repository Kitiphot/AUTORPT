using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Security;

namespace SCG.ARS.BOI.WEB.Models
{
    public class NetworkDetail
    {
        public string LicensePlate { get; set; }
        public string FleetName { get; set; }
        public string TruckTypeName { get; set; }
        public string CarrierName { get; set; }
        public string DriverName { get; set; }
        public string FuelTypeName { get; set; }
        public string MobileNo { get; set; } = string.Empty;
        public string RegionName { get; set; }
        public string ZoneName { get; set; }
        public string Province { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public int Status { get; set; }
        //tooltip - show when mouse over marker
        public string Title { get { return LicensePlate; } }
        //show on marker - use as icon
        public string Label { get; set; }
        public string HashCode { get; set; }
        public bool IsDelete { get; set; } = false;
        public string TruckTypeCode { get; set; }
        public string RegionCode { get; set; }
        public string ZoneCode { get; set; }
        public string ProvinceEN { get; set; }
        public string CarrierCode { get; set; }
        public string FleetCode { get; set; }
        public decimal StartLat { get; set; }
        public decimal StartLong { get; set; }
        public string Locate { get; set; }
        public string Equipment1 { get; set; }
        public string Equipment2 { get; set; }
        public string Equipment3 { get; set; }
        public string Equipment4 { get; set; }
        public string Equipment5 { get; set; }
        public string LoadID { get; set; }
        public List<NetworkingShippingPointDistance> NearBy { get; set; } = new List<NetworkingShippingPointDistance>();

        public NetworkDetail()
        {
            Status = 2; // (int)(new Random()).Next(1, 3);
        }

        public NetworkDetail SetCar(NetworkingCar car)
        {

            this.CarrierCode = car.CarrierCode;
            this.CarrierName = car.CarrierName;
            this.FleetCode = car.FleetCode;
            this.TruckTypeCode = car.TruckTypeCode;
            this.Equipment1 = car.Equipment1;
            this.Equipment2 = car.Equipment2;
            this.Equipment3 = car.Equipment3;
            this.Equipment4 = car.Equipment4;
            this.Equipment5 = car.Equipment5;
            return this;
        }

        public NetworkDetail SetStatus(NetworkingTruckStatus st)
        {
            if (st != null)
            {
                if (st.Status >= 90 && st.Status <= 98)
                    this.Status = 2;
                else
                    this.Status = 1;
                this.LoadID = st.LoadID;
            }

            return this;
        }

        public NetworkDetail setFleet(NetworkingFleet fleet)
        {

            this.FleetName = fleet?.FleetName;
            return this;
        }

        public NetworkDetail setTruck(NetworkingTruckType truck)
        {
            this.TruckTypeName = truck?.TruckTypeName;
            return this;
        }
        public NetworkDetail setProvince(NetworkingProvince pv)
        {
            this.Province = pv?.Province;
            this.ProvinceEN = pv?.ProvinceEN;
            this.RegionCode = pv?.RegionCode ?? "MA";
            this.RegionName = pv?.RegionName ?? "MA";
            this.ZoneCode = pv?.ZoneCode;
            this.ZoneName = pv?.ZoneCode;
            this.HashCode = JsonConvert.SerializeObject(this).ToHash();
            return this;
        }
    }
    public class NetworkingTruckStatus
    {
        public string LoadID { get; set; }
        public string DriverName { get; set; }
        public string LicensePlate { get; set; }
        public int Status { get; set; }
    }
    public class NetworkingShippingPointDistance
    {
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string ShippingPoint { get; set; }
        public string ShippingPointGroup { get; set; }
        public string ShippingPointGroupDisplay { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public double DistanceInKiloMeter { get; set; }
    }
    public class NetworkSummaryGroupByRegion
    {
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string TruckTypeCode { get; set; }
        public string TruckTypeName { get; set; }
        public int LightCar { get; set; }
        public int HeavyCar { get; set; }
    }
    public class NetworkSummaryGroupByZone
    {
        public string ZoneCode { get; set; }
        public string ZoneName { get; set; }
        public string TruckTypeCode { get; set; }
        public string TruckTypeName { get; set; }
        public int LightCar { get; set; }
        public int HeavyCar { get; set; }
    }
    public class NetworkSummaryGroupByShippingPoint
    {
        public string ShippingPointCode { get; set; }
        public string ShippingPointName { get; set; }
        public string TruckTypeCode { get; set; }
        public string TruckTypeName { get; set; }
        public int LightCar { get; set; }
        public int HeavyCar { get; set; }
    }
    public class NetworkingShippingPointCriteria
    {
        public string ShippingPoint { get; set; }
        public double Distanct { get; set; }
    }
    public class NetworkingCriteria
    {
        public List<string> Wheel { get; set; }
        public List<string> TruckTypeCode { get; set; }
        public List<string> Equipment { get; set; }
        public List<string> FleetCode { get; set; }
        public List<string> RegionCode { get; set; }
        public string ZoneCode { get; set; }
        public string Province { get; set; }
        public List<NetworkingShippingPointCriteria> ShippingPoint { get; set; }
        public double Distance { get; set; } = 10;
        public List<string> CarrierCode { get; set; }
        public string Status { get; set; }
        public string Fuel { get; set; }
        public MapBound mapBound { get; set; }
        public List<string> licensePlates { get; set; }
        public string search { get; set; }
        public int page { get; set; }

        public string File { get; set; }
    }
    public class MapBound
    {
        public MapLatLng SouthWest { get; set; }
        public MapLatLng NorthEast { get; set; }
    }
    public class MapLatLng
    {
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }

    public class NetworkingProvince
    {
        public string Province { get; set; }
        public string ProvinceEN { get; set; }
        public string RegionCode { get; set; }
        public string ZoneCode { get; set; }
        public string RegionName { get; set; }
    }

    public class NetworkingFleet
    {
        public string FleetCode { get; set; }
        public string FleetName { get; set; }
        public string PIC { get; set; }
    }

    public class NetworkingCar
    {
        public string FleetCode { get; set; }
        public string CarrierCode { get; set; }
        public string TruckTypeCode { get; set; }
        public string LicensePlate { get; set; }
        public string LicensePlateTrailer { get; set; }
        public string Equipment1 { get; set; }
        public string Equipment2 { get; set; }
        public string Equipment3 { get; set; }
        public string Equipment4 { get; set; }
        public string Equipment5 { get; set; }
        public string CarrierName { get; set; }
    }

    public class NetworkingTruckType
    {
        public string TruckTypeCode { get; set; }
        public string TruckTypeName { get; set; }
    }

    public class NetworkingEquipment
    {
        public string EquipmentName { get; set; }
    }

    public class NetworkingShippingPoint
    {
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string Amphur { get; set; }
        public string Province { get; set; }
        public string RegionCode { get; set; }
        public string ShippingPoint { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string ShippingPointGroup { get; set; }
        public string ShippingPointGroupDisplay
        {
            get
            {
                return $"{this.ShippingPointGroup} {this.Province}";
            }
        }
    }

    public class Select2ResultModel
    {
        public List<Select2ItemModel> Result { get; set; }
        public Select2PaginationModel Pagination { get; set; }
    }
    public class Select2ItemModel
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }
    public class Select2PaginationModel
    {
        public bool More { get; set; }
    }

    public class VehicleResult
    {
        public string Job { get; set; }
        public VehicleResponse Response { get; set; }
    }

    public class VehicleResponse
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public List<VehicleInfo> Vehicles { get; set; }
    }

    public class VehicleInfo
    {
        public decimal VehicleId { get; set; }
        public string VehicleName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal EngineStatus { get; set; }
        public decimal FuelRate { get; set; }
        public string VehicleStatus { get; set; }
        public decimal Speed { get; set; }
        public string Locatio { get; set; }
        public DateTime GpsTime { get; set; }
        public string Sensor { get; set; }
    }
    public class TestDF
    {
        public string Output { get; set; }
        public string Web { get; set; }
    }
}
