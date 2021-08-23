using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models
{
    public class TransportationCriteria
    {
        public List<string> business { get; set; }
        public List<int> fleet { get; set; }
        public List<string> customer { get; set; }
        public List<string> shippingPoint { get; set; }
        public List<string> shipToRegion { get; set; }
        public List<string> matGroup { get; set; }
        public List<string> orderType { get; set; }
        public List<string> truckType { get; set; }
        public List<string> plannerName { get; set; }
        public int? day { get; set; }
        public int? month { get; set; }
        public int? year { get; set; }
        public DateTime? orderStartDate { get; set; }
        public DateTime? orderEndDate { get; set; }
        public DateTime? yearStartDate { get; set; }
        public DateTime? yearEndDate { get; set; }
        public string status { get; set; }
        public string carrier { get; set; }
        public string filter_group { get; set; }
        public int? aging { get; set; }
        public string product_group { get; set; }
        public string aging_lpc { get; set; }
    }

    public class TransportationStatusModel
    {
        public DateTime? dn_day { get; set; }
        public int count_order { get; set; }
    }

    public class WaitingListStatusModel
    {
        public DateTime? commit_date { get; set; }
        public int waiting_list { get; set; }
    }

    public class TransportationStatusNotDNModel
    {
        public int age1{ get; set; }
        public int age2{ get; set; }
        public int age3{ get; set; }
        public int age4{ get; set; }
        public int age5{ get; set; }
        public int age6{ get; set; }
    }        
    
    public class TransportationStatusRawModel
    {
        public int age1{ get; set; }
        public int age2{ get; set; }
        public int age3{ get; set; }
        public int age4{ get; set; }
        public int age5{ get; set; }
        public int age6{ get; set; }
    }    
    public class TransportationStatusMonitorModel
    {
        public string status { get; set; }
        public string age{ get; set; }
        public int count_order{ get; set; }
    }
    public class TransportationDocReturnStatusMonitorModel
    {
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }

    }

    public class TransportationMonthlyModel
    {
        public DateTime? dn_day { get; set; }
        public int total_dn { get; set; }
    }

    public class TransportationDamageMonthlyModel
    {
        public DateTime? delivery_date { get; set; }
        public int total_damage { get; set; }
    }

    public class TransportationDamageYearlyModel
    {
        public string delivery_month { get; set; }
        public int total_damage { get; set; }
    }
    public class TransportationYearlyModel
    {
        public string dn_month { get; set; }
        public int month_no { get; set; }
        public int dn_year { get; set; }
        public int total_dn { get; set; }
    }

    public class NotShipmentMonitoringDetailModel
    {
        public string delivery_number { get; set; }
        public string order_number { get; set; }
        public DateTime? order_date { get; set; }
        public string po_number { get; set; }
        public string customer_code { get; set; }
        public string customer_name { get; set; }
        public string origin_code { get; set; }
        public string origin_name { get; set; }
        public string origin_amphur { get; set; }
        public string origin_province { get; set; }
        public string destination_code { get; set; }
        public string destination_name { get; set; }
        public string destination_amphur { get; set; }
        public string destination_province { get; set; }
        public string amphur_name { get; set; }
        public string province_name { get; set; }
        public string destination_region { get; set; }
        public string destination_postal_code { get; set; }
        public string mat_freight_grp { get; set; }
        public DateTime? request_delivery_date { get; set; }
        public string incoterm { get; set; }
        public string item_number { get; set; }
        public string item_desc { get; set; }
        public decimal? item_quantity { get; set; }
        public decimal? item_weight { get; set; }
        public int order_aging { get; set; }
        public string order_doc_type { get; set; }

    }

    public class NotDNMonitoringDetailModel
    {
        public string so_number { get; set; }
        public DateTime? order_date { get; set; }
        public string po_number { get; set; }
        public string doctype { get; set; }
        public string customer_code { get; set; }
        public string customer_name { get; set; }
        public string shipping_point { get; set; }
        public string shipping_point_desc { get; set; }
        public string origin_code { get; set; }
        public string origin_name { get; set; }
        public string origin_amphur { get; set; }
        public string origin_province { get; set; }
        public string destination_code { get; set; }
        public string destination_name { get; set; }
        public string destination_amphur { get; set; }
        public string destination_province { get; set; }
        public string destination_region { get; set; }
        public string commodity_code { get; set; }
        public string mat_freight_grp { get; set; }
        public DateTime? request_delivery_date { get; set; }
        public string incoterm { get; set; }
        public decimal? total_netweight { get; set; }
        public decimal? total_grossweight { get; set; }
        public string item_number { get; set; }
        public string item_desc { get; set; }
        public decimal? item_quantity { get; set; }
        public decimal? item_weight { get; set; }
        public string container_desc { get; set; }
        public string shipping_condition { get; set; }
        public string shipment_memo { get; set; }
        public int order_aging { get; set; }
        public string order_doc_type{ get; set; }

    }


    public class NotShipmentDetailModel
    {
        public string delivery_number { get; set; }
        public string order_number { get; set; }
        public DateTime? order_date { get; set; }
        public string po_number { get; set; }
        public string customer_code { get; set; }
        public string customer_name { get; set; }
        public string origin_code { get; set; }
        public string origin_name { get; set; }
        public string origin_amphur { get; set; }
        public string origin_province { get; set; }
        public string destination_code { get; set; }
        public string destination_name { get; set; }
        public string destination_amphur { get; set; }
        public string destination_province { get; set; }
        public string destination_region { get; set; }
        public string destination_postal_code { get; set; }
        public string mat_freight_grp { get; set; }
        public DateTime? request_delivery_date { get; set; }
        public string incoterm { get; set; }
        public string item_number { get; set; }
        public string item_desc { get; set; }
        public decimal? item_quantity { get; set; }
        public decimal? item_weight { get; set; }

    }

    public class NotGIDetailModel
    {
        public string load_id { get; set; }
        public string carrier_code { get; set; }
        public string carrier_name { get; set; }
        public string driver_name { get; set; }
        public string truck_license { get; set; }
        public string equipment_type { get; set; }
        public decimal? total_distance { get; set; }
        public decimal? total_volume { get; set; }
        public decimal? total_weight { get; set; }
        public decimal? total_shipments { get; set; }
        public decimal? total_stops { get; set; }
        public DateTime? user_create_date { get; set; }
        public string load_prtb_ctnt { get; set; }
        public string delivery_number { get; set; }
        public string order_number { get; set; }
        public DateTime? orderdate { get; set; }
        public string po_number { get; set; }
        public decimal? load_leg { get; set; }
        public string customer_code { get; set; }
        public string customer_name { get; set; }
        public string origin_code { get; set; }
        public string origin_name { get; set; }
        public string origin_address { get; set; }
        public string origin_region { get; set; }
        public string origin_country { get; set; }
        public string origin_postal_code { get; set; }
        public string destination_code { get; set; }
        public string destination_name { get; set; }
        public string destination_address { get; set; }
        public string destination_region { get; set; }
        public string destination_country { get; set; }
        public string destination_postal_code { get; set; }
        public string commodity_code { get; set; }
        public string mat_freight_grp { get; set; }
        public string shipment_prtb_ctnt { get; set; }
        public decimal? shipment_weight { get; set; }
        public string pickup_code { get; set; }
        public string pickup_name { get; set; }
        public string pickup_block { get; set; }
        public string pickup_street { get; set; }
        public string pickup_city { get; set; }
        public string pickup_region { get; set; }
        public string pickup_country { get; set; }
        public string pickup_postal_code { get; set; }
        public string drop_code { get; set; }
        public string drop_name { get; set; }
        public string drop_block { get; set; }
        public string drop_street { get; set; }
        public string drop_city { get; set; }
        public string drop_region { get; set; }
        public string drop_country { get; set; }
        public string drop_postal_code { get; set; }
        public string request_delivery_date { get; set; }
        public string incoterm { get; set; }
        public string status_display { get; set; }
        public DateTime? actual_tender_accept { get; set; }
        public DateTime? actual_in_origin { get; set; }
        public DateTime? actual_gi_date { get; set; }
        public DateTime? actual_in_transit { get; set; }
        public DateTime? actual_out_origin { get; set; }
        public DateTime? actual_in_destination { get; set; }
        public DateTime? actual_delivery_date { get; set; }
        public DateTime? actual_out_destination { get; set; }
        public DateTime? completedate { get; set; }
        public string item_number { get; set; }
        public string item_desc { get; set; }
        public decimal? item_quantity { get; set; }
        public decimal? item_weight { get; set; }
        public string plannername { get; set; }
    }

    public class TransportationByCarrierModel
    {
        public string carrier_code { get; set; }
        public string carrier_name { get; set; }
        public int total_dn { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }

    public class TransportationNotDNByBusinessModel
    {
        public string business_group { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }

    public class TransportationPerformanceMonthlyModel {
        public DateTime shipment_date { get; set; }
        public int total { get; set; }
        public int delivery { get; set; }
    }

    public class TransportationOntimeMonthlyModel {
        public DateTime order_date { get; set; }
        public int total_shipment { get; set; }
        public int ontime_delivery { get; set; }
        public int delay_delivery { get; set; }
        public int ontime_percent { get; set; }
        public int delay_percent { get; set; }
    }

    public class TransportationPerformanceYearlyModel {
        public string shipment_month { get; set; }
        public int total { get; set; }
        public int delivery { get; set; }
    }

    public class TransportationOntimeYearlyModel
    {
        public string order_month { get; set; }
        public int total_shipment { get; set; }
        public int ontime_delivery { get; set; }
        public int delay_delivery { get; set; }
        public int ontime_percent { get; set; }
        public int delay_percent { get; set; }
    }

    public class TransportationPerformanceSummaryMonthlyModel {
        public int total { get; set; }
        public int total_delivery { get; set; }
        public decimal delivery_percent { get; set; }
    }

    public class TransportationPerformanceSummaryYearlyModel {
        public int total { get; set; }
        public int total_delivery { get; set; }
        public decimal delivery_percent { get; set; }
    }

    public class TransportationOntimeSummaryMonthlyModel {
        public int total_shipment { get; set; }
        public int ontime_delivery { get; set; }
        public int delay_delivery { get; set; }
        public decimal ontime_percent { get; set; }
        public decimal delay_percent { get; set; }
    }

    public class TransportationOntimeSummaryYearlyModel {
        public int total_shipment { get; set; }
        public int ontime_delivery { get; set; }
        public int delay_delivery { get; set; }
        public decimal ontime_percent { get; set; }
        public decimal delay_percent { get; set; }
    }
    
    public class TransportationPerformanceMonthlyDetailModel {
        public string department { get; set; }
        public string section { get; set; }
        public string mat_freight { get; set; }
        public int total_delivery { get; set; }
        public int delivery1 { get; set; }
        public int delivery2 { get; set; }
        public int delivery3 { get; set; }
        public int delivery4 { get; set; }
        public int delivery5 { get; set; }
        public int delivery6 { get; set; }
        public int delivery7 { get; set; }
        public int delivery8 { get; set; }
        public int delivery9 { get; set; }
        public int delivery10 { get; set; }
        public int delivery11 { get; set; }
        public int delivery12 { get; set; }
        public int delivery13 { get; set; }
        public int delivery14 { get; set; }
        public int delivery15 { get; set; }
        public int delivery16 { get; set; }
        public int delivery17 { get; set; }
        public int delivery18 { get; set; }
        public int delivery19 { get; set; }
        public int delivery20 { get; set; }
        public int delivery21 { get; set; }
        public int delivery22 { get; set; }
        public int delivery23 { get; set; }
        public int delivery24 { get; set; }
        public int delivery25 { get; set; }
        public int delivery26 { get; set; }
        public int delivery27 { get; set; }
        public int delivery28 { get; set; }
        public int delivery29 { get; set; }
        public int delivery30 { get; set; }
        public int delivery31 { get; set; }
        public int total_type { get; set; }

    }

    public class TransportationPerformanceYearlyDetailModel {
        public string department { get; set; }
        public string section { get; set; }
        public string mat_freight { get; set; }
        public int total_delivery { get; set; }
        public int delivery1 { get; set; }
        public int delivery2 { get; set; }
        public int delivery3 { get; set; }
        public int delivery4 { get; set; }
        public int delivery5 { get; set; }
        public int delivery6 { get; set; }
        public int delivery7 { get; set; }
        public int delivery8 { get; set; }
        public int delivery9 { get; set; }
        public int delivery10 { get; set; }
        public int delivery11 { get; set; }
        public int delivery12 { get; set; }
        public int total_type { get; set; }

    }

    public class TransportationNotAcceptedByCarrierModel
    {
        public string carrier { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }
    public class TransportationNotDNByPlannerModel
    {
        public string planner { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }    
    public class TransportationNotShipmentByPlannerModel
    {
        public string planner { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }

    public class TransportationNotShipmentByBusinessModel
    {
        public string business_group { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }

    public class PendingDocReturnDetailModel
    {
        public string carrier_code { get; set; }
        public string carrier_name { get; set; }
        public string truck_license { get; set; }
        public string fleet_name { get; set; }
        public string po_number { get; set; }
        public string shipment_no { get; set; }
        public string dn_number { get; set; }
        public string origin_code { get; set; }
        public string origin_name { get; set; }
        public string destination_code { get; set; }
        public string destination_name { get; set; }
        public string destination_address { get; set; }
        public string destination_region { get; set; }
        public string destination_postal_code { get; set; }
    }

    public class LoadByDayModel
    {
        public string carrier_name { get; set; }
        public decimal acc_plan_percent { get; set; }
        public decimal acc_actual_percent { get; set; }
        public decimal plan { get; set; }
        public decimal actual { get; set; }
        public decimal plan_percent { get; set; }
        public decimal actual_percent { get; set; }
        public decimal diff_percent { get; set; }
        public decimal add { get; set; }
        public decimal min_diff_percent { get; set; }
        public decimal max_diff_percent { get; set; }
    }

    public class LoadByCarrierModel
    {
        public string carrier_name { get; set; }
        public string distance_group { get; set; }
        public double dist_percent { get; set; }
    }

    public class LoadDetailModel
    {
        public string load_id { get; set; }
        public string carrier_code { get; set; }
        public string carrier_name { get; set; }
        public string shiptoname { get; set; }
        public string shipto_amphur { get; set; }
        public string shipto_province { get; set; }
        public decimal total_distance { get; set; }
        public decimal charge_amount { get; set; }
        public string sapshippingpointdescription { get; set; }
        public string shiptoregioncode { get; set; }
        public string distance_group { get; set; }
        public string bussiness_group { get; set; }
        public string mat_freight { get; set; }
        public string order_doc_type { get; set; }
        public string fleet_name { get; set; }
        public string truck_name { get; set; }
    }
    public class OrderMonitoringCriteria
    {
        public string delivery_by { get; set; }
        public string destination_region { get; set; }
        public string customer { get; set; }
        public string po_invoice { get; set; }
        public int? day { get; set; }
        public int? month { get; set; }
        public int? year { get; set; }
        public string date_type { get; set; }
    }

    public class OrderMonitoringStatusModel
    {
        public DateTime? order_date { get; set; }
        public decimal total_qty { get; set; }
        public decimal complete_qty { get; set; }
        public decimal onprocess_qty { get; set; }
        public decimal? ontime_percent { get; set; }
        public decimal? success_qty { get; set; }
        public decimal? fail_qty { get; set; }
        public decimal? damage_qty { get; set; }
    }

    public class OrderMonitoringSummaryModel
    {
        public decimal all_order { get; set; }
        public decimal at_origin { get; set; }
        public decimal inbound_cdc { get; set; }
        public string location_type { get; set; }
        public decimal at_cdc { get; set; }
        public decimal inbound_hub { get; set; }
        public decimal at_hub { get; set; }
        public decimal delivering { get; set; }
        public decimal delivered { get; set; }
    }

    public class OrderMonitoringByHubModel : OrderMonitoringSummaryModel
    {
        public string hub_name { get; set; }
    }

    public class OrderMonitoringSummaryOtherTypeModel
    {
        public decimal all_order { get; set; }
        public decimal at_origin { get; set; }
        public decimal delivering { get; set; }
        public decimal delivered { get; set; }
    }

    public class OrderMonitoringShipmentModel
    {
        public string po_number { get; set; }
        public string datetype { get; set; }
        public string gi_customer_date { get; set; }
        public DateTime? gr_cdc_date { get; set; }
        public DateTime? gi_cdc_date { get; set; }
        public DateTime? gr_rdc_date { get; set; }
        public DateTime? gi_rdc_date { get; set; }
        public DateTime? deliverydate { get; set; }
        public string delivery_number { get; set; }
        public string shipmentfirstmile { get; set; }
        public string shipmentlinehual { get; set; }
        public string shipmentlastmile { get; set; }
        public string customer_name { get; set; }
        public string matfrtgrpdesc { get; set; }
        public string origin_name { get; set; }
        public string destination_name { get; set; }
        public string orderdate { get; set; }
        public string requesteddate { get; set; }
    }
    public class OntimeDetailModel
    {
        public string department_name { get; set; }
        public string section_name { get; set; }
        public string fleet_name { get; set; }
        public string mat_name { get; set; }
        public decimal total_dn { get; set; }
        public decimal ontime_dn { get; set; }
        public decimal docreturn_dn { get; set; }
        public decimal ontime_percent { get; set; }
        public decimal docreturn_percent { get; set; }
        public int total_type { get; set; }
    }
    public class DamageDetailModel
    {
        public DateTime delivery_date { get; set; }
        public string invoice_no { get; set; }
        public string customer_name { get; set; }
        public string from_name { get; set; }
        public string to_name { get; set; }
        public decimal quantity { get; set; }
        public string item_name { get; set; }
        public string menual_close_remark { get; set; }
        public string carrier_name { get; set; }
        public string driver_name { get; set; }
        public string license_no { get; set; }
    }

    public class TransportationByBusinessModel
    {
        public string business_group { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }

    public class TransportationByPlannerModel
    {
        public string planner { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }

    public class TransportationByCarrierMonitoringModel
    {
        public string carrier { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }
    public class NotAcceptedDetailModel
    {
        public string load_id{ get; set; }
        public string carrier_code{ get; set; }
        public string carrier_name{ get; set; }
        public string driver_name{ get; set; }
        public string truck_license{ get; set; }
        public string equipment_type{ get; set; }
        public double total_distance{ get; set; }
        public double total_volume{ get; set; }
        public double total_weight{ get; set; }
        public int total_shipments{ get; set; }
        public int total_stops{ get; set; }
        public DateTime? user_create_date{ get; set; }
        public string load_prtb_ctnt{ get; set; }
        public string delivery_number{ get; set; }
        public string order_number{ get; set; }
        public string orderdate{ get; set; }
        public string po_number{ get; set; }
        public int load_leg{ get; set; }
        public string customer_code{ get; set; }
        public string customer_name{ get; set; }
        public string origin_code{ get; set; }
        public string origin_name{ get; set; }
        public string origin_amphur { get; set; }
        public string origin_province { get; set; }
        public string origin_address{ get; set; }
        public string origin_region{ get; set; }
        public string origin_country{ get; set; }
        public string origin_postal_code{ get; set; }
        public string destination_code{ get; set; }
        public string destination_name{ get; set; }
        public string destination_amphur { get; set; }
        public string destination_province { get; set; }
        public string destination_address{ get; set; }
        public string destination_region{ get; set; }
        public string destination_country{ get; set; }
        public string destination_postal_code{ get; set; }
        public string commodity_code{ get; set; }
        public string mat_freight_grp{ get; set; }
        public string shipment_prtb_ctnt{ get; set; }
        public double shipment_weight{ get; set; }
        public string pickup_code{ get; set; }
        public string pickup_name{ get; set; }
        public string pickup_block{ get; set; }
        public string pickup_street{ get; set; }
        public string pickup_city{ get; set; }
        public string pickup_amphur { get; set; }
        public string pickup_province { get; set; }
        public string pickup_region{ get; set; }
        public string pickup_country{ get; set; }
        public string pickup_postal_code{ get; set; }
        public string drop_code{ get; set; }
        public string drop_name{ get; set; }
        public string drop_amphur { get; set; }
        public string drop_province { get; set; }
        public string drop_block{ get; set; }
        public string drop_street{ get; set; }
        public string drop_city{ get; set; }
        public string drop_region{ get; set; }
        public string drop_country{ get; set; }
        public string drop_postal_code{ get; set; }
        public string request_delivery_date{ get; set; }
        public string incoterm{ get; set; }
        public int last_tracking_status{ get; set; }
        public string status_display{ get; set; }
        public DateTime? actual_tender_accept{ get; set; }
        public DateTime? actual_in_origin{ get; set; }
        public DateTime? actual_gi_date{ get; set; }
        public DateTime? actual_in_transit{ get; set; }
        public DateTime? actual_out_origin { get; set; }
        public DateTime? actual_in_destination { get; set; }
        public DateTime? actual_delivery_date { get; set; }
        public DateTime? actual_out_destination { get; set; }
        public DateTime? completedate { get; set; }
        public string item_number{ get; set; }
        public string item_desc{ get; set; }
        public double item_quantity{ get; set; }
        public double item_weight{ get; set; }
        public string plannername{ get; set; }
        public int order_aging { get; set; }
    }

    public class NotGIMonitoringDetailModel
    {
        public string load_id { get; set; }
        public string carrier_code { get; set; }
        public string carrier_name { get; set; }
        public string driver_name { get; set; }
        public string truck_license { get; set; }
        public string equipment_type { get; set; }
        public double total_distance { get; set; }
        public double total_volume { get; set; }
        public double total_weight { get; set; }
        public int total_shipments { get; set; }
        public int total_stops { get; set; }
        public DateTime? user_create_date { get; set; }
        public string load_prtb_ctnt { get; set; }
        public string delivery_number { get; set; }
        public string order_number { get; set; }
        public string orderdate { get; set; }
        public string po_number { get; set; }
        public int load_leg { get; set; }
        public string customer_code { get; set; }
        public string customer_name { get; set; }
        public string origin_code { get; set; }
        public string origin_name { get; set; }
        public string origin_address { get; set; }
        public string origin_amphur { get; set; }
        public string origin_province { get; set; }
        public string origin_region { get; set; }
        public string origin_country { get; set; }
        public string origin_postal_code { get; set; }
        public string destination_code { get; set; }
        public string destination_name { get; set; }
        public string destination_amphur { get; set; }
        public string destination_province { get; set; }
        public string destination_address { get; set; }
        public string destination_region { get; set; }
        public string destination_country { get; set; }
        public string destination_postal_code { get; set; }
        public string commodity_code { get; set; }
        public string mat_freight_grp { get; set; }
        public string shipment_prtb_ctnt { get; set; }
        public double shipment_weight { get; set; }
        public string pickup_code { get; set; }
        public string pickup_name { get; set; }
        public string pickup_block { get; set; }
        public string pickup_street { get; set; }
        public string pickup_city { get; set; }
        public string pickup_amphur { get; set; }
        public string pickup_province { get; set; }
        public string pickup_region { get; set; }
        public string pickup_country { get; set; }
        public string pickup_postal_code { get; set; }
        public string drop_code { get; set; }
        public string drop_name { get; set; }
        public string drop_block { get; set; }
        public string drop_street { get; set; }
        public string drop_city { get; set; }
        public string drop_amphur { get; set; }
        public string drop_province { get; set; }
        public string drop_region { get; set; }
        public string drop_country { get; set; }
        public string drop_postal_code { get; set; }
        public string request_delivery_date { get; set; }
        public string incoterm { get; set; }
        public int last_tracking_status { get; set; }
        public string status_display { get; set; }
        public DateTime? actual_tender_accept { get; set; }
        public DateTime? actual_in_origin { get; set; }
        public DateTime? actual_gi_date { get; set; }
        public DateTime? actual_in_transit { get; set; }
        public DateTime? actual_out_origin { get; set; }
        public DateTime? actual_in_destination { get; set; }
        public DateTime? actual_delivery_date { get; set; }
        public DateTime? actual_out_destination { get; set; }
        public DateTime? completedate { get; set; }
        public string item_number { get; set; }
        public string item_desc { get; set; }
        public double item_quantity { get; set; }
        public double item_weight { get; set; }
        public string plannername { get; set; }
        public int order_aging { get; set; }
    }

    public class DocReturnMonitoringDetailModel
    {
        public string carrier_code { get; set; }
        public string carrier_name { get; set; }
        public string customer_code { get; set; }
        public string customer_name { get; set; }
        public string truck_license { get; set; }
        public string fleet_name { get; set; }
        public string po_number { get; set; }
        public string shipment_no { get; set; }
        public string dn_number { get; set; }
        public string origin_code { get; set; }
        public string origin_name { get; set; }
        public string origin_amphur { get; set; }
        public string origin_province { get; set; }
        public string destination_code { get; set; }
        public string destination_name { get; set; }
        public string destination_address { get; set; }
        public string destination_amphur { get; set; }
        public string destination_province { get; set; }
        public string destination_region { get; set; }
        public string destination_postal_code { get; set; }
        public int order_aging { get; set; }
    }
    public class WaitingListMonthlyModel
    {
        public DateTime? commit_date{ get; set; }
        public int total_book{ get; set; }
        public int total_rest{ get; set; }
        public int total_waiting{ get; set; }
        public int total_committed{ get; set; }
    }

    public class RPTLPC004_ReportViewModel
    {
        public DateTime created_date{ get; set; }
        public string shipping_point{ get; set; }
        public string order_no{ get; set; }
        public string order_line{ get; set; }
        public string customer_name{ get; set; }
        public string incoterm{ get; set; }
        public double weight{ get; set; }
        public string shipto_district{ get; set; }
        public string shipto_city{ get; set; }
        public string shipto_name{ get; set; }
        public string material_name{ get; set; }
        public string shipto_region{ get; set; }
        public string dn_number{ get; set; }
        public string load{ get; set; }
        public string phrm{ get; set; }
        public string equipment_type{ get; set; }
        public string remark{ get; set; }
        public string queued_date{ get; set; }
        public DateTime booked_date { get; set; }
        public string po_no{ get; set; }
        public string fleet_name{ get; set; }
        public string waiting_flag{ get; set; }
    }

    public class RejectMonthlyModel
    {
        public DateTime? tender_date { get; set; }
        public string reject_carrier_name { get; set; }
        public int total_carrier_new { get; set; }
        public int total_carrier_old { get; set; }
    }

    public class RejectYearlyModel
    {
        public string tender_month { get; set; }
        public string reject_carrier_name { get; set; }
        public int total_carrier_new { get; set; }
        public int total_carrier_old { get; set; }
    }

    public class RPTLPC010_ReportViewModel
    {
        public DateTime? tender_date { get; set; }
        public string shipment_no { get; set; }
        public string reject_carrier_code { get; set; }
        public string reject_carrier_name { get; set; }
        public string reject_remark { get; set; }
        public string carrier_code { get; set; }
        public string carrier_name { get; set; }
        public string fleet_name { get; set; }
        public string destination_name { get; set; }
        public string destination_amphur { get; set; }
        public string destination_province { get; set; }
        public string destination_region { get; set; }
        public DateTime? reject_date { get; set; }
        public string truck_type { get; set; }
        public string carrier_change { get; set; }
        public string planner_name { get; set; }
        public string mat_freight_group { get; set; }
        public string mat_freight_name { get; set; }
        public string business_group { get; set; }
        public string order_type { get; set; }
    }
    public class TranshareModel
    {
        public DateTime? GIDate { get; set; }
        public string SALEORDNO { get; set; }
        public string SALESORG { get; set; }
        public string ShippingPoint { get; set; }
        public string ShippingPointName { get; set; }
        public string SoldToCode { get; set; }
        public string SoldToName { get; set; }
        public string Region_Soldto { get; set; }
        public string Region_SoletoName { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToName_SAP { get; set; }
        public string ShipToName { get; set; }
        public string Region_Shipto { get; set; }
        public string Region_ShiptoName { get; set; }
        public string DISTRICT { get; set; }
        public string CITY { get; set; }
        public string CUSTGRP { get; set; }
        public string CUSTGRP_NAME { get; set; }
        public string CUSTGRP_GROUP { get; set; }
        public string CustomerType { get; set; }
        public string Agency { get; set; }
        public string PLANT { get; set; }
        public string Factory { get; set; }
        public string MATFRIGRP { get; set; }
        public string MATNAME { get; set; }
        public string ProductType { get; set; }
        public double? QTY { get; set; }
        public double? WgTon { get; set; }
        public string ROUTE { get; set; }
        public string ROUTE_DESP { get; set; }
        public string DISTCHNNAL { get; set; }
        public string FWDAGENT { get; set; }
        public string INCOTERM { get; set; }
        public string SHPMNTNO { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierName { get; set; }
        public string EquipmentType { get; set; }
        public string TruckLicense { get; set; }
        public string DELVNO { get; set; }
        public double? CostPerLoad { get; set; }
        public double? LoadWgTon { get; set; }
        public double? PricePerDN { get; set; }
        public string EQMT_TYP { get; set; }
        public double? MILE_DIST { get; set; }
        public DateTime? ORDERDATE { get; set; }
        public string Transportby { get; set; }
        public string ProductGroup { get; set; }
        public string Totalrows { get; set; }
        public TranshareOriginalModel original { get; set; }

    }
    public class TranshareOriginalModel
    {
        public string endDate { get; set; }
        public string startDate { get; set; }
    }
}
