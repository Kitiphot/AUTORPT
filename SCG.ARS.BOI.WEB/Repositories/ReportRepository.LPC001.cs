using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NLog;
using Npgsql;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Packaging;

namespace SCG.ARS.BOI.WEB.Repositories
{
    public partial class ReportRepository : IReportRepository
    {
        #region Transportation
        //20200729 Warut S. Start
        public string getNullDb(int? i_data)
        {
            if (i_data == null)
            {
                return "null";
            }
            else
            {
                return $@"'{i_data}'";
            }

        }

        public string getNullDbString(string i_data)
        {
            if (i_data == null || string.IsNullOrEmpty(i_data))
            {
                return "null";
            }
            else
            {
                return $@"'{i_data}'";
            }

        }

        public string GetNullDbDateString(string i_data)
        {
            if (i_data == null || string.IsNullOrEmpty(i_data))
            {
                return "null";
            }
            else
            {
                return $@"'{i_data.Substring(0,10)}'";
            }

        }

        public List<RPTLPC001_ShipmentMonthlyStatusViewModel> RPTLPC001_ShipmentMonthlyStatus(TransportationCriteria input)
        {
            using (IDbConnection dbConnection = Connection)
            {
                //int daySearch;
                dbConnection.Open();
                var data = dbConnection.Query<RPTLPC001_ShipmentMonthlyStatusViewModel>($@"select dn_day,
                    0 as total_dn,
                    total_tender,
                    total_accept,
                    total_gi,
                    total_delivery
                    from dom.getreport01_monthly_shipment(@business,null,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date,null)",
                    param:new
                    {
                        input.business,
                        input.customer,
                        input.fleet,
                        input.shippingPoint,
                        input.shipToRegion,
                        input.matGroup,
                        input.orderType,
                        input.truckType,
                        input.plannerName,
                        input.orderStartDate,
                        input.orderEndDate
                    }, commandTimeout: 3000);
                return data.ToList();
            }
        }

        public List<RPTLPC001_ShipmentYearlyStatusViewModel> RPTLPC001_ShipmentYearlyStatus(TransportationCriteria input)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var data = dbConnection.Query<RPTLPC001_ShipmentYearlyStatusViewModel>($@"select shipment_month,
                    total_dn,
                    total_tender,
                    total_accept,
                    total_gi,
                    total_delivery
                    from dom.getreport01_yearly_shipment(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date)",
                    param:new
                    {
                        input.business,
                        input.customer,
                        input.fleet,
                        input.shippingPoint,
                        input.shipToRegion,
                        input.matGroup,
                        input.orderType,
                        input.truckType,
                        input.plannerName,
                        input.orderStartDate,
                        input.orderEndDate
                    }, commandTimeout: 3000);
                return data.ToList();
            }
        }

        public List<RPTLPC001_ShipmentMonthlyStatusAgingViewModel> RPTLPC001_ShipmentMonthlyStatusAging(TransportationCriteria input)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var data = dbConnection.Query<RPTLPC001_ShipmentMonthlyStatusAgingViewModel>($@"select status_aging,
                    total_tender,
                    total_accept,
                    total_gi,
                    total_delivery
                    from dom.getreport01_aging_status(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date)",
                    param:new
                    {
                        input.business,
                        input.customer,
                        input.fleet,
                        input.shippingPoint,
                        input.shipToRegion,
                        input.matGroup,
                        input.orderType,
                        input.truckType,
                        input.plannerName,
                        input.orderStartDate,
                        input.orderEndDate
                    }, commandTimeout: 3000);
                return data.ToList();
            }
        }

        public List<RPTLPC001_ShipmentMonthlyCarrierStatusViewModel> RPTLPC001_ShipmentMonthlyCarrierStatus(TransportationCriteria input)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var data = dbConnection.Query<RPTLPC001_ShipmentMonthlyCarrierStatusViewModel>($@"select carrier_name,
                    total_accept,
                    total_gi,
                    total_delivery,
                    total_tender
                    from dom.getreport01_carrier_status(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date)",
                    param:new
                    {
                        input.business,
                        input.customer,
                        input.fleet,
                        input.shippingPoint,
                        input.shipToRegion,
                        input.matGroup,
                        input.orderType,
                        input.truckType,
                        input.plannerName,
                        input.orderStartDate,
                        input.orderEndDate
                    }
                    , commandTimeout: 3000);
                return data.ToList();
            }
        }


        public List<RPTLPC001_ShipmentDailyStatusViewModel> RPTLPC001_ShipmentDailyStatus(TransportationCriteria input)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var data = dbConnection.Query<RPTLPC001_ShipmentDailyStatusViewModel>($@"select 
                    0 as total_dn,
                    total_tender,
                    total_accept,
                    total_gi,
                    total_delivery
                    from dom.getreport01_shipment_status(@business,null,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date,null)",
                    param:new
                    {
                        input.business,
                        input.customer,
                        input.fleet,
                        input.shippingPoint,
                        input.shipToRegion,
                        input.matGroup,
                        input.orderType,
                        input.truckType,
                        input.plannerName,
                        input.orderStartDate,
                        input.orderEndDate
                    }, commandTimeout: 3000);
                return data.ToList();
            }
        }
        //20200729 Warut S. End
        #endregion

    }
}
