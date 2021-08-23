using GeoJSON.Net.Feature;
using SCG.ARS.BOI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public interface INetworking
    {
        Task<IOrderedEnumerable<NetworkDetail>> ListCarLocation(NetworkingCriteria criteria);
        //Task<List<NetworkDetail>> GetCar(NetworkingCriteria criteria);
        List<NetworkSummaryGroupByRegion> GetNetworkSummaryGroupByRegion(NetworkingCriteria criteria);
        List<NetworkSummaryGroupByZone> GetNetworkSummaryGroupByZone(NetworkingCriteria criteria);
        List<NetworkSummaryGroupByShippingPoint> GetNetworkSummaryGroupByShippingPoint(NetworkingCriteria criteria);
        FeatureCollection GetBound(List<string> regionCode, string zoneCode, string file);
        TestDF Test();
    }
}
