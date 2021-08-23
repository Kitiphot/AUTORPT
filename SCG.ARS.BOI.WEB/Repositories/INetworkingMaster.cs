using GeoJSON.Net.Feature;
using SCG.ARS.BOI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public interface INetworkingMaster
    {
        string OtherRegion { get; set; }
        List<NetworkingTruckType> TruckType { get; set; }
        List<NetworkingProvince> Province { get; set; }
        List<NetworkingFleet> Fleet { get; set; }
        List<NetworkingCar> Car { get; set; }
        List<NetworkingShippingPoint> ShippingPoint { get; set; }
        FeatureCollection GeoJSON { get; set; }
        //FeatureCollection GeoJSONNoBuengKan { get; set; }
        FeatureCollection GeoJSONFast { get; set; }
        string GetProvinceName(double latitude, double longitude);

        List<MiscDataSelectionModel> GetWheel();

        List<MiscDataSelectionModel> GetTruckType(List<string> wheels);

        List<MiscDataSelectionModel> GetEquipment();

        List<MiscDataSelectionModel> GetFleet();

        List<MiscDataSelectionWithRawModel> GetProvince(List<string> regionCode, string zoneCode);

        List<MiscDataSelectionWithDataModel> GetRegionAndZone();
        List<MiscDataSelectionModel> GetRegion();

        List<MiscDataSelectionModel> GetCarrier(List<string> fleetCode);

        List<MiscDataSelectionModel> GetStatus();

        List<MiscDataSelectionModel> GetFuel();
        List<MiscDataSelectionModel> GetZone(string regionCode);
        List<MiscDataSelectionModel> GetShippingPointGroup(List<string> regionCode, string zoneCode, string province);
        List<NetworkingShippingPoint> GetShippingPoint(List<string> regionCode, string zoneCode, string province);
    }
}
