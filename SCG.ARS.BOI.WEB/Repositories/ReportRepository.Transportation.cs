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
    public partial class ReportRepository
    {
        #region "Not Shipment"
        public List<TransportationStatusModel> NotShipmentStatus(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationStatusModel>(
$@"select dn_day,total_dn
from dom.getreport02_notshipment_status(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationYearlyModel> NotShipmentYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationYearlyModel>(
$@"select dn_month, month_no, dn_year,total_dn
from dom.getreport02_yearly_notshipment(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationMonthlyModel> NotShipmentMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationMonthlyModel>(
$@"select dn_day,total_dn
from dom.getreport02_monthly_notshipment(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<NotShipmentDetailModel> NotShipmentDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<NotShipmentDetailModel>(
                $@"select delivery_number
                , order_number
                , order_date
                , po_number
                , customer_code
                , customer_name
                , origin_code
                , origin_name
                , origin_amphur
                , origin_province
                , destination_code
                , destination_name
                , destination_amphur
                , destination_province
                , destination_region
                , destination_postal_code
                , mat_freight_grp
                , request_delivery_date
                , incoterm
                , item_number
                , item_desc
                , item_quantity
                , item_weight
                from dom.get_trans_report02(
                @business, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType
                , @truckType, @plannerName
                , @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<NotShipmentMonitoringDetailModel> NotShipmentMonitoringDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<NotShipmentMonitoringDetailModel>(
                $@"select delivery_number
                , order_number
                , order_date
                , po_number
                , customer_code
                , customer_name
                , origin_code
                , origin_name
                , origin_amphur
                , origin_province
                , destination_code
                , destination_name
                , destination_amphur
                , destination_province
                , destination_region
                , destination_postal_code
                , mat_freight_grp
                , request_delivery_date
                , incoterm
                , item_number
                , item_desc
                , item_quantity
                , item_weight
                , order_aging
                , order_doc_type
                from dom.getreport12_trans(
                @business,@customer,@fleet,@matGroup, @shippingPoint
                , @shipToRegion, @orderType, @plannerName,@orderStartDate::date,@orderEndDate::date,@aging,@product_group)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.matGroup,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.orderType,
                    input.plannerName,
                    input.orderStartDate,
                    input.orderEndDate,
                    input.status,
                    input.aging,
                    input.product_group
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<NotDNMonitoringDetailModel> NotDNDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<NotDNMonitoringDetailModel>(
                $@"select
                so_number,
                order_date,
                po_number,
                doctype,
                customer_code,
                customer_name,
                shipping_point,
                shipping_point_desc,
                origin_code,
                origin_name,
                origin_amphur,
                origin_province,
                destination_code,
                destination_name,
                destination_amphur,
                destination_province,
                destination_region,
                commodity_code,
                mat_freight_grp,
                request_delivery_date,
                incoterm,
                total_netweight,
                total_grossweight,
                item_number,
                item_desc,
                item_quantity,
                item_weight,
                container_desc,
                shipping_condition,
                shipment_memo,
                order_aging,
                order_doc_type
                from dom.getreport11_trans(
                    @business,@customer,@fleet,@matGroup, @shippingPoint
                , @shipToRegion, @orderType, @plannerName,@orderStartDate::date,@orderEndDate::date,@aging,@product_group)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.matGroup,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.orderType,
                    input.plannerName,
                    input.orderStartDate,
                    input.orderEndDate,
                    input.aging,
                    input.product_group
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        #endregion

        #region "WaitingList"
        public List<WaitingListStatusModel> WaitingListStatus(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<WaitingListStatusModel>(
            $@"select commit_date,waiting_list
            from dom.getreport04_waiting_status(@fleet)"
                , param: new
                {
                    input.fleet
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<WaitingListMonthlyModel> WaitingListMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<WaitingListMonthlyModel>(
            $@"select commit_date,total_book,total_rest,total_waiting,total_committed
            from dom.getreport04_monthly_waiting(@fleet,@orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.fleet,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<RPTLPC004_ReportViewModel> RPTLPC004_Report(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<RPTLPC004_ReportViewModel>(
            $@"select created_date,
                shipping_point,
                order_no,
                order_line,
                customer_name,
                incoterm,
                weight,
                shipto_district,
                shipto_city,
                shipto_name,
                material_name,
                shipto_region,
                dn_number,
                load,
                phrm,
                equipment_type,
                remark,
                queued_date,
                booked_date,
                po_no,
                fleet_name,
                waiting_flag
            from dom.getreport04_trans(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date)"
                , param: new
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
        #endregion

        #region "Reject"

        public List<RejectMonthlyModel> RejectMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<RejectMonthlyModel>(
            $@"select tender_date,
                reject_carrier_name,
                total_carrier_new,
                total_carrier_old
            from dom.getreport10_monthly_reject(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date)"
                , param: new
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
        
        public List<RejectYearlyModel> RejectYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<RejectYearlyModel>(
            $@"select tender_month,
                reject_carrier_name,
                total_carrier_new,
                total_carrier_old
            from dom.getreport10_yearly_reject(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date)"
                , param: new
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

        public List<RPTLPC010_ReportViewModel> RPTLPC010_Report(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<RPTLPC010_ReportViewModel>(
            $@"select tender_date,
                shipment_no,
                reject_carrier_code,
                reject_carrier_name,
                reject_remark,
                carrier_code,
                carrier_name,
                fleet_name,
                destination_name,
                destination_amphur,
                destination_province,
                destination_region,
                reject_date,
                truck_type,
                carrier_change,
                planner_name,
                mat_freight_group,
                mat_freight_name,
                business_group,
                order_type
            from dom.getreport10_trans(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@truckType,@plannerName,@orderStartDate::date,@orderEndDate::date)"
                , param: new
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
        #endregion
        #region "Not GI"
        public List<TransportationStatusModel> NotGIStatus(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationStatusModel>(
$@"select dn_day,total_dn
from dom.getreport03_notgi_status(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationYearlyModel> NotGIYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationYearlyModel>(
$@"select dn_month, month_no, dn_year,total_dn
from dom.getreport03_yearly_notgi(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationMonthlyModel> NotGIMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationMonthlyModel>(
$@"select dn_day,total_dn
from dom.getreport03_monthly_notgi(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<NotGIDetailModel> NotGIDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<NotGIDetailModel>(
$@"select load_id
,carrier_code
,carrier_name
,driver_name
,truck_license
,equipment_type
,total_distance
,total_volume
,total_weight
,total_shipments
,total_stops
,user_create_date
,load_prtb_ctnt
,delivery_number
,order_number
,orderdate
,po_number
,load_leg
,customer_code
,customer_name
,origin_code
,origin_name
,origin_address
,origin_region
,origin_country
,origin_postal_code
,destination_code
,destination_name
,destination_address
,destination_region
,destination_country
,destination_postal_code
,commodity_code
,mat_freight_grp
,shipment_prtb_ctnt
,shipment_weight
,pickup_code
,pickup_name
,pickup_block
,pickup_street
,pickup_city
,pickup_region
,pickup_country
,pickup_postal_code
,drop_code
,drop_name
,drop_block
,drop_street
,drop_city
,drop_region
,drop_country
,drop_postal_code
,request_delivery_date
,incoterm
,status_display
,actual_tender_accept
,actual_in_origin
,actual_gi_date
,actual_in_transit
,actual_out_origin
,actual_in_destination
,actual_delivery_date
,actual_out_destination
,completedate
,item_number
,item_desc
,item_quantity
,item_weight
,plannername

from dom.get_trans_report03(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        #endregion
        #region "Pending Doc Return"
        public List<TransportationStatusModel> PendingDocReturnStatus(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationStatusModel>(
            $@"select dn_day,total_dn
            from dom.getreport07_pendingdoc_status(
            @business, @fleet, @shippingPoint
            , @shipToRegion, @matGroup, @orderType
            , @truckType, @plannerName
            , @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationStatusRawModel> NotDNStatus(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationStatusRawModel>(
            $@"select age1,age2,age3,age4,age5,age6 from dom.getreport11_notdn_status(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@plannerName)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationStatusRawModel> NotShipmentStatusMonitor(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationStatusRawModel>(
            $@"select age1,age2,age3,age4,age5,age6 from dom.getreport12_notshipment_status(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@plannerName)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationYearlyModel> PendingDocReturnYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationYearlyModel>(
$@"select dn_month, month_no, dn_year,total_dn
from dom.getreport07_yearly_pendingdoc(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationMonthlyModel> PendingDocReturnMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationMonthlyModel>(
$@"select dn_day,total_dn
from dom.getreport07_monthly_pendingdoc(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationByCarrierModel> PendingDocReturnByCarrier(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationByCarrierModel>(
$@"select carrier_code,carrier_name,total_dn,age1,age2,age3,age4,age5 
from dom.getreport07_aging_bycarrier(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationNotDNByBusinessModel> NotDNByBusiness(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationNotDNByBusinessModel>(
$@"select business_group,age1,age2,age3,age4,age5,age6
from dom.getreport11_notdn_bybusiness(
@business,@customer, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType, @plannerName)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationNotShipmentByBusinessModel> NotShipmentByBusiness(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationNotShipmentByBusinessModel>(
                $@"select business_group,age1,age2,age3,age4,age5,age6
                from dom.getreport12_notshipment_bybusiness(
                @business,@customer, @fleet, @shippingPoint, @shipToRegion, @matGroup, @orderType, @plannerName)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationNotDNByPlannerModel> NotDNByPlanner(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationNotDNByPlannerModel>(
$@"select planner,age1,age2,age3,age4,age5,age6
from dom.getreport11_notdn_byplanner(
@business,@customer, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType, @plannerName)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationNotShipmentByPlannerModel> NotShipmentByPlanner(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationNotShipmentByPlannerModel>(
$@"select planner,age1,age2,age3,age4,age5,age6
from dom.getreport12_notshipment_byplanner(
@business,@customer, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType, @plannerName)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<PendingDocReturnDetailModel> PendingDocReturnDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<PendingDocReturnDetailModel>(
$@"select carrier_code
,carrier_name
,truck_license
,fleet_name
,po_number
,shipment_no
,dn_number
,origin_code
,origin_name
,destination_code
,destination_name
,destination_address
,destination_region
,destination_postal_code
from dom.get_trans_report07(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year
, @carrier, @filter_group)"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                    input.carrier,
                    input.filter_group //aging
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        #endregion

        public List<LoadByDayModel> LoadByDay(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<LoadByDayModel>(
                $@"select carrier_name
                ,acc_plan_percent
                ,acc_actual_percent
                ,plan
                ,actual
                ,plan_percent
                ,actual_percent
                ,diff_percent
                ,add
                from dom.getreport06_loadbyday(@business, @customer, @fleet, @shippingPoint, @shipToRegion, @matGroup, @orderType, @truckType, @plannerName,@orderStartDate::date)"
                , param: new
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
                   input.orderStartDate
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<LoadByCarrierModel> LoadByCarrier(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<LoadByCarrierModel>(
                $@"select carrier_name
                ,distance_group
                ,dist_percent
                from dom.getreport06_loadbycarrier(@business, @customer, @fleet, @shippingPoint, @shipToRegion, @matGroup, @orderType, @truckType, @plannerName, @orderStartDate::date, @orderEndDate::date)"
                , param: new
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
        public List<LoadDetailModel> LoadDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<LoadDetailModel>(
                $@"select load_id
                , carrier_code
                , carrier_name
                , shiptoname
                , shipto_amphur
                , shipto_province
                , total_distance
                , charge_amount
                , sapshippingpointdescription
                , shiptoregioncode
                , distance_group
                , bussiness_group
                , mat_freight
                , order_doc_type
                , fleet_name
                , truck_name
                from dom.getreport06_trans(@business, @customer, @fleet, @shippingPoint, 
                    @shipToRegion, @matGroup, @orderType, @truckType, @plannerName, 
                    @orderStartDate::date, @orderEndDate::date, @carrier, @filter_group)"
                , param: new
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
                    input.orderEndDate,
                    input.carrier,
                    input.filter_group //distance_group
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<OrderMonitoringStatusModel> OrderMonitoringStatus(OrderMonitoringCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            string dateType = input.date_type;
            var data = dbConnection.Query<OrderMonitoringStatusModel>(
            $@"select dn_date order_date
            , total_dn total_qty
            , complete_dn complete_qty
            , onprocess_dn onprocess_qty
            , ontime_percent
            , success_dn success_qty
            , fail_dn fail_qty
            , damage_dn damage_qty
            from dom.getreport_order_monitoring_status(@dateType)"
                , param: new
                {
                    dateType
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<OrderMonitoringStatusModel> ReturnOrderMonitoringStatus(OrderMonitoringCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            string dateType = input.date_type;
            var data = dbConnection.Query<OrderMonitoringStatusModel>(
            $@"select dn_date order_date
            , total_dn total_qty
            , complete_dn complete_qty
            , onprocess_dn onprocess_qty
            , ontime_percent
            , success_dn success_qty
            , fail_dn fail_qty
            , damage_dn damage_qty
            from dom.getreport_order_monitoring_return_status(@dateType)"
                , param: new
                {
                    dateType
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        [Obsolete]
        public OrderMonitoringSummaryModel OrderMonitoringSummary(OrderMonitoringCriteria input)
        {
#if DEBUG
            return new OrderMonitoringSummaryModel { all_order = 2680, at_origin = 50, inbound_cdc = 40, at_cdc = 50, inbound_hub = 300, at_hub = 150, delivering = 1905, delivered = 165 };
#else
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<OrderMonitoringSummaryModel>(
$@"select all_order
, at_origin
, inbound_cdc
, at_cdc
, inbound_hub
, at_hub
, delivering
, delivered
from dom.get_trans_report06(@day, @month, @year
, @delivery_by, @destination_region, @customer, @po_invoice)"
                , param: new
                {
                    input.day,
                    input.month,
                    input.year,
                    input.delivery_by,
                    input.destination_region,
                    input.customer,
                    input.po_invoice
                }
                , commandTimeout: 3000);
            return data.FirstOrDefault();
#endif
        }
        public List<OrderMonitoringByHubModel> OrderMonitoringByHub(OrderMonitoringCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            string dateType = input.date_type;
            dbConnection.Open();
            var searchDate = new DateTime(input.year.Value, input.month.Value, input.day.Value);
            var data = dbConnection.Query<OrderMonitoringByHubModel>(
            $@"select distributor hub_name
            , totalorder all_order
            , atorigin at_origin
            , location_type
            , tocdc inbound_cdc
            , atcdc at_cdc
            , tordc inbound_hub
            , atrdc at_hub
            , todestination delivering
            , atdestination delivered
            from dom.getreport_order_monitoring_sum(@searchDate::date, @dateType
            , @delivery_by, @destination_region, @customer, @po_invoice)"
                , param: new
                {
                    searchDate,
                    dateType,
                    input.delivery_by,
                    input.destination_region,
                    input.customer,
                    input.po_invoice
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<OrderMonitoringByHubModel> ReturnOrderMonitoringByHub(OrderMonitoringCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            string dateType = input.date_type;
            dbConnection.Open();
            var searchDate = new DateTime(input.year.Value, input.month.Value, input.day.Value);
            var data = dbConnection.Query<OrderMonitoringByHubModel>(
$@"select distributor hub_name
, totalorder all_order
, location_type 
, atorigin at_origin
, tocdc inbound_cdc
, atcdc at_cdc
, tordc inbound_hub
, atrdc at_hub
, todestination delivering
, atdestination delivered
from dom.getreport_order_monitoring_return_sum(@searchDate::date, @dateType
, @delivery_by, @destination_region, @customer, @po_invoice)"
                , param: new
                {
                    searchDate,
                    dateType,
                    input.delivery_by,
                    input.destination_region,
                    input.customer,
                    input.po_invoice
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<OrderMonitoringShipmentModel> OrderMonitoringShipment(OrderMonitoringCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            string dateType = input.date_type;
            dbConnection.Open();
            var searchDate = new DateTime(input.year.Value, input.month.Value, input.day.Value);
            var data = dbConnection.Query<OrderMonitoringShipmentModel>(
$@"select po_number
, datetype
, gi_customer_date
, gr_cdc_date
, gi_cdc_date
, gr_rdc_date
, gi_rdc_date
, delivery_date deliverydate
, dn_number delivery_number
, shipment_first_mile shipmentfirstmile
, shipment_line_hual shipmentlinehual
, shipment_last_mile shipmentlastmile
, customer_name
, mat_freight_group matfrtgrpdesc
, origin_name
, destination_name
, order_date orderdate
, request_date requesteddate
from dom.getreport_order_monitoring_trans(@searchDate::date, @dateType
, @delivery_by, @destination_region, @customer, @po_invoice)"
                , param: new
                {
                    searchDate,
                    dateType,
                    input.delivery_by,
                    input.destination_region,
                    input.customer,
                    input.po_invoice
                }
                , commandTimeout: 3000);
            return data.OrderBy(c => c.po_number).ThenBy(c => c.delivery_number).ThenByDescending(c => c.datetype).ToList();
        }

        public List<OrderMonitoringShipmentModel> ReturnOrderMonitoringShipment(OrderMonitoringCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            string dateType = input.date_type;
            dbConnection.Open();
            var searchDate = new DateTime(input.year.Value, input.month.Value, input.day.Value);
            var data = dbConnection.Query<OrderMonitoringShipmentModel>(
$@"select po_number
, datetype
, gi_customer_date
, gr_cdc_date
, gi_cdc_date
, gr_rdc_date
, gi_rdc_date
, delivery_date deliverydate
, dn_number delivery_number
, shipment_first_mile shipmentfirstmile
, shipment_line_hual shipmentlinehual
, shipment_last_mile shipmentlastmile
, customer_name
, mat_freight_group matfrtgrpdesc
, origin_name
, destination_name
, order_date orderdate
, request_date requesteddate
from dom.getreport_order_monitoring_return_trans(@searchDate::date, @dateType
, @delivery_by, @destination_region, @customer, @po_invoice)"
                , param: new
                {
                    searchDate,
                    dateType,
                    input.delivery_by,
                    input.destination_region,
                    input.customer,
                    input.po_invoice
                }
                , commandTimeout: 3000);
            return data.OrderBy(c => c.po_number).ThenBy(c => c.delivery_number).ThenByDescending(c => c.datetype).ToList();
        }

        public List<MiscDataSelectionModel> GetCarrier()
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<MiscDataSelectionModel>(
$@"select carriercode DataValue_Key, carriercode || ': ' || carriername DataDisplay
from dom.omsord_master_sap_carrier");
            return data.ToList();
        }

        public List<OntimeDetailModel> OntimeDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<OntimeDetailModel>(
$@"select 
department_name
,section_name
,fleet_name
,mat_name
,total_dn
,ontime_dn
,docreturn_dn
,ontime_percent
,docreturn_percent
,total_type
from dom.get_trans_report08(
@business, @fleet, @shippingPoint
, @shipToRegion, @matGroup, @orderType
, @truckType, @plannerName
, @day, @month, @year)
"
                , param: new
                {
                    input.business,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.plannerName,
                    input.day,
                    input.month,
                    input.year,
                }
                , commandTimeout: 3000);
            return data.ToList();
        }
        public List<TransportationDamageYearlyModel> DamageYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationDamageYearlyModel>(
                $@"select delivery_month, total_damage
                from dom.getreport09_yearly_damage(
                @business, @customer, @fleet, @shippingPoint, 
                @shipToRegion, @matGroup, @orderType, @truckType, @plannerName, 
                @orderStartDate::date,@orderEndDate::date)"
                , param: new
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
        public List<TransportationDamageMonthlyModel> DamageMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationDamageMonthlyModel>(
                $@"select delivery_date,total_damage
                from dom.getreport09_monthly_damage(
                @business, @customer, @fleet, @shippingPoint, 
                @shipToRegion, @matGroup, @orderType, @truckType, @plannerName, 
                @orderStartDate::date, @orderEndDate::date)"
                , param: new
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
        public List<DamageDetailModel> DamageDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<DamageDetailModel>(
            $@"select delivery_date,
                    invoice_no,
                    customer_name,
                    from_name,
                    to_name,
                    quantity,
                    item_name,
                    manual_close_remark,
                    carrier_name,
                    driver_name,
                    license_no
            from dom.getreport09_trans(
                @business, @customer, @fleet, @shippingPoint, 
                @shipToRegion, @matGroup, @orderType, @truckType, @plannerName, 
                @orderStartDate::date, @orderEndDate::date)"
                , param: new
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
        public List<TransportationStatusRawModel> NotAcceptedStatus(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationStatusRawModel>(
            $@"select age1,age2,age3,age4,age5,age6 from dom.getreport13_notaccept_status(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationByBusinessModel> NotAcceptedByBusiness(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationByBusinessModel>(
                $@"select business_group,age1,age2,age3,age4,age5,age6
                from dom.getreport13_notaccept_bybusiness(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType, @plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationNotAcceptedByCarrierModel> NotAcceptedByCarrier(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationNotAcceptedByCarrierModel>(
                $@"select carrier,age1,age2,age3,age4,age5,age6
                from dom.getreport13_notaccept_bycarrier(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType, @plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<NotAcceptedDetailModel> NotAcceptedDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<NotAcceptedDetailModel>(
                $@"select load_id,
                carrier_code,
                carrier_name,
                driver_name,
                truck_license,
                equipment_type,
                total_distance,
                total_volume,
                total_weight,
                total_shipments,
                total_stops,
                user_create_date,
                load_prtb_ctnt,
                delivery_number,
                order_number,
                orderdate,
                po_number,
                load_leg,
                customer_code,
                customer_name,
                origin_code,
                origin_name,
                origin_amphur,
                origin_province,
                origin_address,
                origin_region,
                origin_country,
                origin_postal_code,
                destination_code,
                destination_name,
                destination_amphur,
                destination_province,
                destination_address,
                destination_region,
                destination_country,
                destination_postal_code,
                commodity_code,
                mat_freight_grp,
                shipment_prtb_ctnt,
                shipment_weight,
                pickup_code,
                pickup_name,
                pickup_amphur,
                pickup_province,
                pickup_block,
                pickup_street,
                pickup_city,
                pickup_region,
                pickup_country,
                pickup_postal_code,
                drop_code,
                drop_name,
                drop_block,
                drop_street,
                drop_city,
                drop_amphur,
                drop_province,
                drop_region,
                drop_country,
                drop_postal_code,
                request_delivery_date,
                incoterm,
                last_tracking_status,
                status_display,
                actual_tender_accept,
                actual_in_origin,
                actual_gi_date,
                actual_in_transit,
                actual_out_origin,
                actual_in_destination,
                actual_delivery_date,
                actual_out_destination,
                completedate,
                item_number,
                item_desc,
                item_quantity,
                item_weight,
                plannername,
                order_aging
                from dom.getreport13_trans(
                @business,
                @customer, 
                @fleet,
                @matGroup, 
                @shippingPoint, 
                @shipToRegion,
                @truckType,
                @orderType, 
                @plannerName,
                @orderStartDate::date,
                @orderEndDate::date,
                @aging,
                @product_group,
                @carrier)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.matGroup,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.truckType,
                    input.orderType,
                    input.plannerName,
                    input.orderStartDate,
                    input.orderEndDate,
                    input.aging,
                    input.product_group,
                    input.carrier
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationStatusRawModel> NotGIMonitoringStatus(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationStatusRawModel>(
            $@"select age1,age2,age3,age4,age5,age6 from dom.getreport14_notgi_status(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationByBusinessModel> NotGIMonitoringByBusiness(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationByBusinessModel>(
                $@"select business_group,age1,age2,age3,age4,age5,age6
                from dom.getreport14_notgi_bybusiness(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType, @plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationByCarrierMonitoringModel> NotGIMonitoringByCarrier (TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationByCarrierMonitoringModel>(
                $@"select carrier,age1,age2,age3,age4,age5,age6
                from dom.getreport14_notgi_bycarrier(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType, @plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<NotGIMonitoringDetailModel> NotGIMonitoringDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<NotGIMonitoringDetailModel>(
                $@"select load_id,
                carrier_code,
                carrier_name,
                driver_name,
                truck_license,
                equipment_type,
                total_distance,
                total_volume,
                total_weight,
                total_shipments,
                total_stops,
                user_create_date,
                load_prtb_ctnt,
                delivery_number,
                order_number,
                orderdate,
                po_number,
                load_leg,
                customer_code,
                customer_name,
                origin_code,
                origin_name,
                origin_address,
                origin_amphur,
                origin_province,
                origin_region,
                origin_country,
                origin_postal_code,
                destination_code,
                destination_name,
                destination_amphur,
                destination_province,
                destination_address,
                destination_region,
                destination_country,
                destination_postal_code,
                commodity_code,
                mat_freight_grp,
                shipment_prtb_ctnt,
                shipment_weight,
                pickup_code,
                pickup_name,
                pickup_block,
                pickup_street,
                pickup_city,
                pickup_amphur,
                pickup_province,
                pickup_region,
                pickup_country,
                pickup_postal_code,
                drop_code,
                drop_name,
                drop_block,
                drop_street,
                drop_city,
                drop_amphur,
                drop_province,
                drop_region,
                drop_country,
                drop_postal_code,
                request_delivery_date,
                incoterm,
                last_tracking_status,
                status_display,
                actual_tender_accept,
                actual_in_origin,
                actual_gi_date,
                actual_in_transit,
                actual_out_origin,
                actual_in_destination,
                actual_delivery_date,
                actual_out_destination,
                completedate,
                item_number,
                item_desc,
                item_quantity,
                item_weight,
                plannername,
                order_aging
                from dom.getreport14_trans(
                @business,
                @customer, 
                @fleet,
                @matGroup, 
                @shippingPoint, 
                @shipToRegion,
                @truckType,
                @orderType, 
                @plannerName,
                @orderStartDate::date,
                @orderEndDate::date,
                @aging,
                @product_group)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.matGroup,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.truckType,
                    input.orderType,
                    input.plannerName,
                    input.orderStartDate,
                    input.orderEndDate,
                    input.aging,
                    input.product_group
                }
                , commandTimeout: 3000);
            return data.ToList();
        }

        public List<TransportationDocReturnStatusMonitorModel> DocReturnStatus(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationDocReturnStatusMonitorModel>(
            $@"select age1,age2,age3,age4,age5,age6 from dom.getreport15_docreturn_status(@business,@customer,@fleet,@shippingPoint,@shipToRegion,@matGroup,@orderType,@plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationByBusinessModel> DocReturnByBusiness(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationByBusinessModel>(
                $@"select business_group,age1,age2,age3,age4,age5,age6
                from dom.getreport15_docreturn_bybusiness(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType, @plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationByCarrierMonitoringModel> DocReturnByCarrier(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationByCarrierMonitoringModel>(
                $@"select carrier,age1,age2,age3,age4,age5,age6
                from dom.getreport15_docreturn_bycarrier(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType, @plannerName,@truckType)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.plannerName,
                    input.truckType
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<DocReturnMonitoringDetailModel> DocReturnDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<DocReturnMonitoringDetailModel>(
                $@"select 
                carrier_code,
                carrier_name,
                customer_code,
                customer_name,
                truck_license,
                fleet_name,
                po_number,
                shipment_no,
                dn_number,
                origin_code,
                origin_name,
                origin_amphur,
                origin_province,
                destination_code,
                destination_name,
                destination_amphur,
                destination_province,
                destination_address,
                destination_region,
                destination_postal_code,
                order_aging
                from dom.getreport15_trans(
                @business,
                @customer, 
                @fleet,
                @matGroup, 
                @shippingPoint, 
                @shipToRegion,
                @truckType,
                @orderType, 
                @plannerName,
                @orderStartDate::date,
                @orderEndDate::date,
                @aging,
                @product_group)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.matGroup,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.truckType,
                    input.orderType,
                    input.plannerName,
                    input.orderStartDate,
                    input.orderEndDate,
                    input.aging,
                    input.product_group
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceMonthlyModel> ShipmentMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceMonthlyModel>(
                $@"select shipment_date,total_shipment AS total,delivery_shipment AS delivery from dom.getreport16_shipment_monthly(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceYearlyModel> ShipmentYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceYearlyModel>(
                $@"select shipment_month,total_shipment AS total, delivery_shipment AS delivery from dom.getreport16_shipment_yearly(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceSummaryMonthlyModel> ShipmentSummaryMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceSummaryMonthlyModel>(
                $@"select total_shipment AS total, total_delivery,delivery_percent from dom.getreport16_shipment_summary(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceSummaryYearlyModel> ShipmentSummaryYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceSummaryYearlyModel>(
                $@"select total_shipment AS total, total_delivery,delivery_percent from dom.getreport16_shipment_summary(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceMonthlyDetailModel> ShipmentMonthlyDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceMonthlyDetailModel>(
                $@"select * from dom.getreport16_shipment_group(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date) 
                order by case when department is null then 0 else 1 end, department
                ,case when section is null then 0 else 1 end, section
                ,case when mat_freight is null then 0 else 1 end, mat_freight"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceYearlyDetailModel> ShipmentYearlyDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceYearlyDetailModel>(
                $@"select * from dom.getreport16_shipment_group_year(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date) 
                order by case when department is null then 0 else 1 end, department
                ,case when section is null then 0 else 1 end, section
                ,case when mat_freight is null then 0 else 1 end, mat_freight"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceMonthlyModel> TonMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceMonthlyModel>(
                $@"select shipment_date,total_ton AS total, delivery_ton AS delivery from dom.getreport17_ton_monthly(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceYearlyModel> TonYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceYearlyModel>(
                $@"select shipment_month,total_ton AS total, delivery_ton AS delivery from dom.getreport17_ton_yearly(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceSummaryMonthlyModel> TonSummaryMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceSummaryMonthlyModel>(
                $@"select total_ton AS total,total_delivery,delivery_percent from dom.getreport17_ton_summary(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceSummaryYearlyModel> TonSummaryYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceSummaryYearlyModel>(
                $@"select total_ton AS total,total_delivery,delivery_percent from dom.getreport17_ton_summary(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceMonthlyDetailModel> TonMonthlyDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceMonthlyDetailModel>(
                $@"select * from dom.getreport17_ton_group(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date) 
                order by case when department is null then 0 else 1 end, department
                ,case when section is null then 0 else 1 end, section
                ,case when mat_freight is null then 0 else 1 end, mat_freight"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceYearlyDetailModel> TonYearlyDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceYearlyDetailModel>(
                $@"select * from dom.getreport17_ton_group_year(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date) 
                order by case when department is null then 0 else 1 end, department
                ,case when section is null then 0 else 1 end, section
                ,case when mat_freight is null then 0 else 1 end, mat_freight"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }        
        
        public List<TransportationPerformanceMonthlyModel> PieceMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceMonthlyModel>(
                $@"select shipment_date,total_qty AS total,delivery_qty AS delivery from dom.getreport18_piece_monthly(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceYearlyModel> PieceYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceYearlyModel>(
                $@"select shipment_month,total_qty AS total, delivery_qty AS total from dom.getreport18_piece_yearly(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceSummaryMonthlyModel> PieceSummaryMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceSummaryMonthlyModel>(
                $@"select total_qty AS total, total_delivery,delivery_percent from dom.getreport18_piece_summary(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceSummaryYearlyModel> PieceSummaryYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceSummaryYearlyModel>(
                $@"select total_qty AS total,total_delivery,delivery_percent from dom.getreport18_piece_summary(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceMonthlyDetailModel> PieceMonthlyDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceMonthlyDetailModel>(
                $@"select * from dom.getreport18_piece_group(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date) 
                order by case when department is null then 0 else 1 end, department
                ,case when section is null then 0 else 1 end, section
                ,case when mat_freight is null then 0 else 1 end, mat_freight"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceYearlyDetailModel> PieceYearlyDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceYearlyDetailModel>(
                $@"select * from dom.getreport18_piece_group_year(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date) 
                order by case when department is null then 0 else 1 end, department
                ,case when section is null then 0 else 1 end, section
                ,case when mat_freight is null then 0 else 1 end, mat_freight"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationOntimeMonthlyModel> OntimeMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationOntimeMonthlyModel>(
                $@"select order_date,total_shipment,ontime_delivery,delay_delivery,ontime_percent,delay_percent from dom.getreport19_ontime_monthly(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationOntimeYearlyModel> OntimeYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationOntimeYearlyModel>(
                $@"select order_month,total_shipment,ontime_delivery,delay_delivery,ontime_percent,delay_percent from dom.getreport19_ontime_yearly(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationOntimeSummaryMonthlyModel> OntimeSummaryMonthly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationOntimeSummaryMonthlyModel>(
                $@"select total_shipment,ontime_delivery,delay_delivery,ontime_percent,delay_percent from dom.getreport19_ontime_summary(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationOntimeSummaryYearlyModel> OntimeSummaryYearly(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationOntimeSummaryYearlyModel>(
                $@"select total_shipment,ontime_delivery,delay_delivery,ontime_percent,delay_percent from dom.getreport19_ontime_summary(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date)"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }

        public List<TransportationPerformanceMonthlyDetailModel> OntimeMonthlyDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceMonthlyDetailModel>(
                $@"select * from dom.getreport19_ontime_group(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @orderStartDate::date,@orderEndDate::date) 
                order by case when department is null then 0 else 1 end, department
                ,case when section is null then 0 else 1 end, section
                ,case when mat_freight is null then 0 else 1 end, mat_freight"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.orderStartDate,
                    input.orderEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }


        public List<TransportationPerformanceYearlyDetailModel> OntimeYearlyDetail(TransportationCriteria input)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();
            var data = dbConnection.Query<TransportationPerformanceYearlyDetailModel>(
                $@"select * from dom.getreport19_ontime_group_year(
                @business,@customer, @fleet, @shippingPoint
                , @shipToRegion, @matGroup, @orderType,@truckType, @yearStartDate::date,@yearEndDate::date) 
                order by case when department is null then 0 else 1 end, department
                ,case when section is null then 0 else 1 end, section
                ,case when mat_freight is null then 0 else 1 end, mat_freight"
                , param: new
                {
                    input.business,
                    input.customer,
                    input.fleet,
                    input.shippingPoint,
                    input.shipToRegion,
                    input.matGroup,
                    input.orderType,
                    input.truckType,
                    input.yearStartDate,
                    input.yearEndDate
                }
                , commandTimeout: 0);
            return data.ToList();
        }
    }
}
