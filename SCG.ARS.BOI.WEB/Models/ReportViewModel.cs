using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace SCG.ARS.BOI.WEB.Models {
	public class ReportViewModel {
		public string ActualTenderDate { get; set; }
		public string SONumber { get; set; }
		public string SoldToName { get; set; }
		public string Incoterm1 { get; set; }
		public double TotalWeight { get; set; }
		public string ShiptoDistrict { get; set; }
		public string ShiptoProvince { get; set; }
		public string ShiptoName { get; set; }
		public string ItemDescription { get; set; }
		public string ShiptoRegion { get; set; }
		public string DNNumber { get; set; }
		public string SMNumber { get; set; }
		public string CarrierName { get; set; }
		public string EquipmentTypeName { get; set; }
		public string SMDescription { get; set; }
		public string ShippingPointName { get; set; }
		public string RequestDeliveryDate { get; set; }
		public string GIDate { get; set; }
		public string TruckLicense { get; set; }
		public string ActualDeliveryDate { get; set; }
		public string ActualDocumentReturnDate { get; set; }
		public string PlannerName { get; set; }
	}
	public class RPTCDC003DispatchingViewModel {
		public DateTime? create_date { get; set; }
		public int statusid { get; set; }
		public string statusname { get; set; }
		public string po_invoice { get; set; }
		public string so_number { get; set; }
		public string dn { get; set; }
		public string customercode { get; set; }
		public string customername { get; set; }
		public string doctype { get; set; }
		public string docrefno { get; set; }
		public string inbound { get; set; }
		public string ean { get; set; }
		public string sku { get; set; }
		public string productbarcode { get; set; }
		public string productcode { get; set; }
		public string productdescription { get; set; }
		public string suppliercode { get; set; }
		public string suppliername { get; set; }
		public double weight { get; set; }
		public double volume { get; set; }
		public double qty_in_ewm { get; set; }
		public string unit_code { get; set; }
		public string uom { get; set; }
		public string productgroupcode { get; set; }
		public string productgroupname { get; set; }
		public DateTime? picking_instruction_date { get; set; }
		public DateTime? stock_hold_date { get; set; }
		public DateTime? picking_date { get; set; }
		public DateTime? shippingdate { get; set; }
		public string shipmentnogroup { get; set; }
		public string finaldestinationcode { get; set; }
		public string finaldestinationlongname { get; set; }
		public DateTime? deliverydate { get; set; }
		public string entiled { get; set; }
	}

	public class RPTESC002DispatchingViewModel {
		public DateTime? pickingdate { get; set; }
		public string statusname { get; set; }
		public string po_invoice { get; set; }
		public string dn { get; set; }
		public string customername { get; set; }
		public string sku { get; set; }
		public string productdescription { get; set; }
		public double weight { get; set; }
		public double qty_in_ewm { get; set; }
		public string uom { get; set; }
		public string productgroupname { get; set; }
		public string sonumber { get; set; }
		public DateTime? shippingdate { get; set; }
		public string shipmentnogroup { get; set; }
		public string finaldestinationlongname { get; set; }
		public DateTime? deliverydate { get; set; }
		public string entiled { get; set; }
		public string license_plate { get; set; }
		public string batch_no { get; set; }
		public string lot_no { get; set; }
		public string receive_package_name { get; set; }
		public double actual_weight { get; set; }

	}

	public class RPTCDC004InventoryInquiryViewModel {
		public string warehouse { get; set; }
		public string location { get; set; }
		public string pallet_no { get; set; }
		public string tag_no { get; set; }
		public string product_code { get; set; }
		public string product_name { get; set; }
		public string product_condition { get; set; }
		public double inventory_qty { get; set; }
		public double balance_qty { get; set; }
		public string unit_code { get; set; }
		public BitArray bin_block { get; set; }
		public string product_group { get; set; }
		public string serial { get; set; }
		public string lot_no { get; set; }
		public double weight { get; set; }
		public double volumn { get; set; }
		public DateTime? received_date { get; set; }
		public DateTime? expired_date { get; set; }
		public DateTime? mfg_date { get; set; }
		public DateTime? last_movement { get; set; }
		public string po_no { get; set; }
		public string invoice_no { get; set; }
		public string doc_type { get; set; }
	}
	public class RPTCDC006CheckMoveViewModel {
		public string doc_no { get; set; }
		public int item { get; set; }
		public int doc_year { get; set; }
		public string inventory_status { get; set; }
		public string storage_bin { get; set; }
		public string product { get; set; }
		public string product_desc { get; set; }
		public string high_level_hu { get; set; }
		public double inventory_qty { get; set; }
		public double book_qty { get; set; }
		public double counted_qty { get; set; }
		public double diff_qty { get; set; }
		public DateTime? counted_date { get; set; }
		public TimeSpan? counted_time { get; set; }
		public string count_user { get; set; }
		public string zero_count { get; set; }
	}

	public class RPTESC004CheckMoveViewModel
	{
		public string doc_no { get; set; }
		public int item { get; set; }
		public int doc_year { get; set; }
		public string inventory_status { get; set; }
		public string storage_bin { get; set; }
		public string product { get; set; }
		public string product_desc { get; set; }
		public string high_level_hu { get; set; }
		public double inventory_qty { get; set; }
		public double book_qty { get; set; }
		public double counted_qty { get; set; }
		public double diff_qty { get; set; }
		public DateTime counted_date { get; set; }
		public TimeSpan counted_time { get; set; }
		public string count_user { get; set; }
		public string zero_count { get; set; }
	}
	public class RPTCDC007ReportForLPCViewModel {
		public DateTime curr_date { get; set; }
		public string do_number { get; set; }
		public string customer_code { get; set; }
		public string product_code { get; set; }
		public double sum_qty { get; set; }
		public double sum_weight { get; set; }
		public double sum_volumn { get; set; }
		public string route_id { get; set; }
		public string customer_name { get; set; }
		public string customer_address { get; set; }
		public string city { get; set; }
		public string province { get; set; }
		public double actual_weight { get; set; }
		public string ship_by { get; set; }
		public string route_line_no { get; set; }
		public string pallet_id { get; set; }
		public string shipping_mark { get; set; }
		public string shipto_sub_code { get; set; }
		public DateTime request_date { get; set; }
		public string tu_number { get; set; }
		public string service_type { get; set; }
	}

	public class RPTCDC001ReceivingViewModel {
		public DateTime? receiveddate { get; set; }
		public int statusid { get; set; }
		public string statusname { get; set; }
		public string po_no{ get; set; }
		public string invoice_no { get; set; }
		public string rc { get; set; }
		public string ean { get; set; }
		public string suppliercode { get; set; }
		public string suppliername { get; set; }
		public string sku { get; set; }
		public string productbarcode { get; set; }
		public string productcode { get; set; }
		public string productdescription { get; set; }
		public double weight { get; set; }
		public double volumn { get; set; }
		public double qty_in_ewm { get; set; }
		public string unit_code { get; set; }
		public string uom { get; set; }
		public string productgroupcode { get; set; }
		public string productgroupname { get; set; }
		public string doctype { get; set; }
		public string docrefno { get; set; }
		public string inbound { get; set; }
		public string entiled { get; set; }
		public string chargeunit { get; set; }
		public string chargeitem { get; set; }
		public string customer_name { get; set; }
		public DateTime? arrival_date { get; set; }
		public DateTime? transit_date { get; set; }
	}

	public class RPTLPC001ViewModel {
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

	}
	public class RPTESC001ReceivingViewModel {
		public DateTime receiveddate { get; set; }
		public int statusid { get; set; }
		public string statusname { get; set; }
		public string po_invoice { get; set; }
		public string rc { get; set; }
		public string ean { get; set; }
		public string suppliercode { get; set; }
		public string suppliername { get; set; }
		public string sku { get; set; }
		public string productbarcode { get; set; }
		public string productcode { get; set; }
		public string productdescription { get; set; }
		public double weight { get; set; }
		public double volumn { get; set; }
		public double qty_in_ewm { get; set; }
		public string unit_code { get; set; }
		public string uom { get; set; }
		public string productgroupcode { get; set; }
		public string productgroupname { get; set; }
		public string doctype { get; set; }
		public string docrefno { get; set; }
		public string inbound { get; set; }
		public string entiled { get; set; }
		public string chargeunit { get; set; }
		public string chargeitem { get; set; }
		public string customer_name { get; set; }
		public string license_plate { get; set; }
		public string batch_no { get; set; }
		public string lot_no { get; set; }
		public string receive_package_name { get; set; }
		public double actual_weight { get; set; }
	}

	public class RPT002PROSTAReportViewModel {
		public string customer_name { get; set; }
		public string customer_code { get; set; }
		public string product_code { get; set; }
		public string product_name { get; set; }
		public string receive_qty { get; set; }
		public string putaway_qty { get; set; }
		public string pick_qty { get; set; }
		public string gi_qty { get; set; }
	}
	public class RPT001GRGIReportViewModel {
		public string customer_name { get; set; }
		public string customer_code { get; set; }
		public double gr_quantity { get; set; }
		public double gi_quantity { get; set; }

	}

	public class RPTCDC002StockOnHandViewModel {
		public DateTime? stock_date { get; set; }
		public string lv { get; set; }
		public string storage_type { get; set; }
		public string location_code { get; set; }
		public string handling_unit { get; set; }
		public string sku { get; set; }
		public string sku_desc { get; set; }
		public string status { get; set; }
		public string ean { get; set; }
		public double qty { get; set; }
		public string uom { get; set; }
		public string sticker_uid { get; set; }
		public string entifled { get; set; }
		public double unit_volumn { get; set; }
		public double m3 { get; set; }
		public double weight_uom { get; set; }
		public double weight_kg { get; set; }
		public string cb { get; set; }
		public string vlength { get; set; }
		public string vheight { get; set; }
		public DateTime? gr_date { get; set; }
		public double aging { get; set; }
		public string material_group { get; set; }
		public string product_group { get; set; }
		public string age_range { get; set; }
		public string level { get; set; }
		public DateTime? expire_date { get; set; }
		public DateTime? mfg_date { get; set; }
		public string check_location_type { get; set; }
		public string charge_per_location { get; set; }
		public string check { get; set; }
		public string po_no { get; set; }
		public string invoice_no { get; set; }
	}

	public class RPTESC003StockOnHandViewModel
	{
		public DateTime? stock_date { get; set; }
		public string lv { get; set; }
		public string storage_type { get; set; }
		public string location_code { get; set; }
		public string handling_unit { get; set; }
		public string sku { get; set; }
		public string sku_desc { get; set; }
		public string status { get; set; }
		public string ean { get; set; }
		public double qty { get; set; }
		public string uom { get; set; }
		public string sticker_uid { get; set; }
		public string entifled { get; set; }
		public double unit_volumn { get; set; }
		public double m3 { get; set; }
		public double weight_uom { get; set; }
		public double weight_kg { get; set; }
		public string cb { get; set; }
		public string vlength { get; set; }
		public string vheight { get; set; }
		public DateTime? gr_date { get; set; }
		public double aging { get; set; }
		public string material_group { get; set; }
		public string product_group { get; set; }
		public string age_range { get; set; }
		public string level { get; set; }
		public DateTime? expire_date { get; set; }
		public DateTime? mfg_date { get; set; }
		public string check_location_type { get; set; }
		public string charge_per_location { get; set; }
		public string check { get; set; }
		public string po_no { get; set; }
		public string invoice_no { get; set; }
	}

	public class RPTPKG001DailyMonitorViewModel {
		public string fleet { get; set; }
		public string truck_type { get; set; }
		public int truck_commit { get; set; }
		public int yesterday_pending_day1 { get; set; }
		public int order_count_day1 { get; set; }
		public int truck_wait_day1 { get; set; }
		public int order_wait_day1 { get; set; }
		public int book_count_day1 { get; set; }
		public int yesterday_pending_day2 { get; set; }
		public int order_count_day2 { get; set; }
		public int truck_wait_day2 { get; set; }
		public int order_wait_day2 { get; set; }
		public int book_count_day2 { get; set; }
		public int yesterday_pending_day3 { get; set; }
		public int order_count_day3 { get; set; }
		public int truck_wait_day3 { get; set; }
		public int order_wait_day3 { get; set; }
		public int book_count_day3 { get; set; }
		public int yesterday_pending_day4 { get; set; }
		public int order_count_day4 { get; set; }
		public int truck_wait_day4 { get; set; }
		public int order_wait_day4 { get; set; }
		public int book_count_day4 { get; set; }
		public int yesterday_pending_day5 { get; set; }
		public int order_count_day5 { get; set; }
		public int truck_wait_day5 { get; set; }
		public int order_wait_day5 { get; set; }
		public int book_count_day5 { get; set; }
		public int yesterday_pending_day6 { get; set; }
		public int order_count_day6 { get; set; }
		public int truck_wait_day6 { get; set; }
		public int order_wait_day6 { get; set; }
		public int book_count_day6 { get; set; }
		public int yesterday_pending_day7 { get; set; }
		public int order_count_day7 { get; set; }
		public int truck_wait_day7 { get; set; }
		public int order_wait_day7 { get; set; }
		public int book_count_day7 { get; set; }
		public int yesterday_pending_day8 { get; set; }
		public int order_count_day8 { get; set; }
		public int truck_wait_day8 { get; set; }
		public int order_wait_day8 { get; set; }
		public int book_count_day8 { get; set; }
		public int yesterday_pending_day9 { get; set; }
		public int order_count_day9 { get; set; }
		public int truck_wait_day9 { get; set; }
		public int order_wait_day9 { get; set; }
		public int book_count_day9 { get; set; }
		public int yesterday_pending_day10 { get; set; }
		public int order_count_day10 { get; set; }
		public int truck_wait_day10 { get; set; }
		public int order_wait_day10 { get; set; }
		public int book_count_day10 { get; set; }
		public int yesterday_pending_day11 { get; set; }
		public int order_count_day11 { get; set; }
		public int truck_wait_day11 { get; set; }
		public int order_wait_day11 { get; set; }
		public int book_count_day11 { get; set; }
		public int yesterday_pending_day12 { get; set; }
		public int order_count_day12 { get; set; }
		public int truck_wait_day12 { get; set; }
		public int order_wait_day12 { get; set; }
		public int book_count_day12 { get; set; }
		public int yesterday_pending_day13 { get; set; }
		public int order_count_day13 { get; set; }
		public int truck_wait_day13 { get; set; }
		public int order_wait_day13 { get; set; }
		public int book_count_day13 { get; set; }
		public int yesterday_pending_day14 { get; set; }
		public int order_count_day14 { get; set; }
		public int truck_wait_day14 { get; set; }
		public int order_wait_day14 { get; set; }
		public int book_count_day14 { get; set; }
		public int yesterday_pending_day15 { get; set; }
		public int order_count_day15 { get; set; }
		public int truck_wait_day15 { get; set; }
		public int order_wait_day15 { get; set; }
		public int book_count_day15 { get; set; }
		public int yesterday_pending_day16 { get; set; }
		public int order_count_day16 { get; set; }
		public int truck_wait_day16 { get; set; }
		public int order_wait_day16 { get; set; }
		public int book_count_day16 { get; set; }
		public int yesterday_pending_day17 { get; set; }
		public int order_count_day17 { get; set; }
		public int truck_wait_day17 { get; set; }
		public int order_wait_day17 { get; set; }
		public int book_count_day17 { get; set; }
		public int yesterday_pending_day18 { get; set; }
		public int order_count_day18 { get; set; }
		public int truck_wait_day18 { get; set; }
		public int order_wait_day18 { get; set; }
		public int book_count_day18 { get; set; }
		public int yesterday_pending_day19 { get; set; }
		public int order_count_day19 { get; set; }
		public int truck_wait_day19 { get; set; }
		public int order_wait_day19 { get; set; }
		public int book_count_day19 { get; set; }
		public int yesterday_pending_day20 { get; set; }
		public int order_count_day20 { get; set; }
		public int truck_wait_day20 { get; set; }
		public int order_wait_day20 { get; set; }
		public int book_count_day20 { get; set; }
		public int yesterday_pending_day21 { get; set; }
		public int order_count_day21 { get; set; }
		public int truck_wait_day21 { get; set; }
		public int order_wait_day21 { get; set; }
		public int book_count_day21 { get; set; }
		public int yesterday_pending_day22 { get; set; }
		public int order_count_day22 { get; set; }
		public int truck_wait_day22 { get; set; }
		public int order_wait_day22 { get; set; }
		public int book_count_day22 { get; set; }
		public int yesterday_pending_day23 { get; set; }
		public int order_count_day23 { get; set; }
		public int truck_wait_day23 { get; set; }
		public int order_wait_day23 { get; set; }
		public int book_count_day23 { get; set; }
		public int yesterday_pending_day24 { get; set; }
		public int order_count_day24 { get; set; }
		public int truck_wait_day24 { get; set; }
		public int order_wait_day24 { get; set; }
		public int book_count_day24 { get; set; }
		public int yesterday_pending_day25 { get; set; }
		public int order_count_day25 { get; set; }
		public int truck_wait_day25 { get; set; }
		public int order_wait_day25 { get; set; }
		public int book_count_day25 { get; set; }
		public int yesterday_pending_day26 { get; set; }
		public int order_count_day26 { get; set; }
		public int truck_wait_day26 { get; set; }
		public int order_wait_day26 { get; set; }
		public int book_count_day26 { get; set; }
		public int yesterday_pending_day27 { get; set; }
		public int order_count_day27 { get; set; }
		public int truck_wait_day27 { get; set; }
		public int order_wait_day27 { get; set; }
		public int book_count_day27 { get; set; }
		public int yesterday_pending_day28 { get; set; }
		public int order_count_day28 { get; set; }
		public int truck_wait_day28 { get; set; }
		public int order_wait_day28 { get; set; }
		public int book_count_day28 { get; set; }
		public int yesterday_pending_day29 { get; set; }
		public int order_count_day29 { get; set; }
		public int truck_wait_day29 { get; set; }
		public int order_wait_day29 { get; set; }
		public int book_count_day29 { get; set; }
		public int yesterday_pending_day30 { get; set; }
		public int order_count_day30 { get; set; }
		public int truck_wait_day30 { get; set; }
		public int order_wait_day30 { get; set; }
		public int book_count_day30 { get; set; }
		public int yesterday_pending_day31 { get; set; }
		public int order_count_day31 { get; set; }
		public int truck_wait_day31 { get; set; }
		public int order_wait_day31 { get; set; }
		public int book_count_day31 { get; set; }

	}

	public class RPTPKG002OverallFleetDomesticsViewModel {
		public string fleet { get; set; }
		public string truck_type { get; set; }
		public int truck_commit { get; set; }
		public int pending_count { get; set; }
		public int order_count { get; set; }
		public int book_count { get; set; }
		public int accept_count { get; set; }
		public int truck_wait { get; set; }
	}

	public class RPTPKG003CarrierPerformanceViewModel {
		public string fleet { get; set; }
		public string truck_type { get; set; }
		public string carrier_code { get; set; }
		public string carrier_name { get; set; }
		public int truck_register { get; set; }
		public int truck_commit { get; set; }
		public int book_count { get; set; }
		public decimal book_percentage { get; set; }
		public int accept_count { get; set; }
		public decimal accept_percentage { get; set; }
	}

	public class RPTPKG004SwitchingModelViewModel {
		public int carrier_id { get; set; }
		public string carrier_name { get; set; }
		public string province { get; set; }
		public int order_count { get; set; }
		public int backhaul_count { get; set; }
		public int remain_truck { get; set; }
		public string sub_truck_type { get; set; }
	}

	public class RPTPKG005MonitorTruckActiveViewModel {
		public string fleet { get; set; }
		public string carrier { get; set; }
		public string truck_type { get; set; }
		public string sub_truck_type { get; set; }
		public string truck_license { get; set; }
		public string driver_name { get; set; }
		public string result_day1 { get; set; }
		public string result_day2 { get; set; }
		public string result_day3 { get; set; }
		public string result_day4 { get; set; }
		public string result_day5 { get; set; }
		public string result_day6 { get; set; }
		public string result_day7 { get; set; }
		public string result_day8 { get; set; }
		public string result_day9 { get; set; }
		public string result_day10 { get; set; }
		public string result_day11 { get; set; }
		public string result_day12 { get; set; }
		public string result_day13 { get; set; }
		public string result_day14 { get; set; }
		public string result_day15 { get; set; }
		public string result_day16 { get; set; }
		public string result_day17 { get; set; }
		public string result_day18 { get; set; }
		public string result_day19 { get; set; }
		public string result_day20 { get; set; }
		public string result_day21 { get; set; }
		public string result_day22 { get; set; }
		public string result_day23 { get; set; }
		public string result_day24 { get; set; }
		public string result_day25 { get; set; }
		public string result_day26 { get; set; }
		public string result_day27 { get; set; }
		public string result_day28 { get; set; }
		public string result_day29 { get; set; }
		public string result_day30 { get; set; }
		public string result_day31 { get; set; }
		public int is_working_day1 { get; set; }
		public int is_working_day2 { get; set; }
		public int is_working_day3 { get; set; }
		public int is_working_day4 { get; set; }
		public int is_working_day5 { get; set; }
		public int is_working_day6 { get; set; }
		public int is_working_day7 { get; set; }
		public int is_working_day8 { get; set; }
		public int is_working_day9 { get; set; }
		public int is_working_day10 { get; set; }
		public int is_working_day11 { get; set; }
		public int is_working_day12 { get; set; }
		public int is_working_day13 { get; set; }
		public int is_working_day14 { get; set; }
		public int is_working_day15 { get; set; }
		public int is_working_day16 { get; set; }
		public int is_working_day17 { get; set; }
		public int is_working_day18 { get; set; }
		public int is_working_day19 { get; set; }
		public int is_working_day20 { get; set; }
		public int is_working_day21 { get; set; }
		public int is_working_day22 { get; set; }
		public int is_working_day23 { get; set; }
		public int is_working_day24 { get; set; }
		public int is_working_day25 { get; set; }
		public int is_working_day26 { get; set; }
		public int is_working_day27 { get; set; }
		public int is_working_day28 { get; set; }
		public int is_working_day29 { get; set; }
		public int is_working_day30 { get; set; }
		public int is_working_day31 { get; set; }
		//public string result_total { get; set; }
		public int result_book { get; set; }
		public int result_accept { get; set; }
		public int result_non_accept { get; set; }
		public int result_not_book { get; set; }
	}

	public class RPTPKG006OrientBiddingViewModel {
		public string ship_to;
		public int line_no;
		public int group_no;
		public string route_name;
		public int total_count;
		public int focus_count;
		//public int lac_count;
		public int other_count;
		public int other1;
		public int other2;
		public int other3;
		public int other4;
		public int other5;
		public int other6;
		public int other7;
		public int other8;
		public int other9;
		public int other10;
		public int other11;
		public int other12;
		public int other13;
		public int other14;
		public int other15;
		public int other16;
		public int other17;
		public int other18;
		public int other19;
		public int other20;
		public int other21;
		public int other22;
		public int other23;
		public int other24;
		public int other25;
		public int other26;
		public int other27;
		public int other28;
		public int other29;
		public int other30;

	}

	public class RPTPKG007ProjectSavingViewModel {
		public int shipto_seq { get; set; }
		public string shipto_name { get; set; }
		public int carrier_seq { get; set; }
		public string carrier_name { get; set; }
		public int order_count { get; set; }
		public decimal weight { get; set; }
		public double order_percent { get; set; }
		public decimal? bt_saving { get; set; }
	}

	public class RPTPKG007ProjectSaving2ViewModel {
		public string shipto_name { get; set; }
		public int subtotal { get; set; }
		public string carrier_name1 { get; set; }
		public int order_count1 { get; set; }
		public string carrier_name2 { get; set; }
		public int order_count2 { get; set; }
		public string carrier_name3 { get; set; }
		public int order_count3 { get; set; }
		public string carrier_name4 { get; set; }
		public int order_count4 { get; set; }
		public string carrier_name5 { get; set; }
		public int order_count5 { get; set; }
		public string carrier_name6 { get; set; }
		public int order_count6 { get; set; }
		public string carrier_name7 { get; set; }
		public int order_count7 { get; set; }
		public string carrier_name8 { get; set; }
		public int order_count8 { get; set; }
		public string carrier_name9 { get; set; }
		public int order_count9 { get; set; }
		public string carrier_name10 { get; set; }
		public int order_count10 { get; set; }
		public string carrier_name11 { get; set; }
		public int order_count11 { get; set; }
		public string carrier_name12 { get; set; }
		public int order_count12 { get; set; }
		public string carrier_name13 { get; set; }
		public int order_count13 { get; set; }
		public string carrier_name14 { get; set; }
		public int order_count14 { get; set; }
		public string carrier_name15 { get; set; }
		public int order_count15 { get; set; }
		public string carrier_name16 { get; set; }
		public int order_count16 { get; set; }
		public string carrier_name17 { get; set; }
		public int order_count17 { get; set; }
		public string carrier_name18 { get; set; }
		public int order_count18 { get; set; }
		public string carrier_name19 { get; set; }
		public int order_count19 { get; set; }
		public string carrier_name20 { get; set; }
		public int order_count20 { get; set; }
		public string carrier_name21 { get; set; }
		public int order_count21 { get; set; }
		public string carrier_name22 { get; set; }
		public int order_count22 { get; set; }
		public string carrier_name23 { get; set; }
		public int order_count23 { get; set; }
		public string carrier_name24 { get; set; }
		public int order_count24 { get; set; }
		public string carrier_name25 { get; set; }
		public int order_count25 { get; set; }
	}

	public class RPTPKG008OrderCIPViewModel {
		public string ship_to { get; set; }
		public string ship_to_range { get; set; }
		public int sequence { get; set; }
		public int order_count_range1 { get; set; }
		public int order_count_range2 { get; set; }
		public int order_count_range3 { get; set; }
		public int order_count_range4 { get; set; }
		public int order_count_total { get; set; }
	}

	public class RPGPKGLastRoundViewModel {
		public DateTime? last_date { get; set; }
		public int last_round { get; set; }
	}

	public class RPTCDC001ReceivingChartViewModel
    {
        public DateTime? receiveddate { get; set; }
        public double qty_in_ewm { get; set; }
    }

    public class Report010ViewModel
    {
        public string No { get; set; }
        public string StatusDescription { get; set; }
        public string User { get; set; }
        public string SMCreateDate { get; set; }
        public string ReqID { get; set; }
        public string SMNumber { get; set; }
        public string NumberofDN { get; set; }
        public string TrackingNo { get; set; }
        public string CustomerName { get; set; }
        public string EquipmentTypeName { get; set; }
        public string CarrierCode { get; set; }
        public string TotalStop { get; set; }
        public string TotalWeight { get; set; }
        public string TotalVolume { get; set; }
        public string UtiWeight { get; set; }
        public string UtiVol { get; set; }
        public string Type { get; set; }
    }

    public class Report004ViewModel
    {
        public string No { get; set; }
        public string DestinationName { get; set; }
        public string OrderNumber { get; set; }
        public string SMWeight { get; set; }
        public string DNNumber { get; set; }
        public string GIDate { get; set; }
        public string SMNumber { get; set; }
        public string ActualTenderStatus { get; set; }
        public string EquipmentTypeName { get; set; }
        public string CarrierName { get; set; }
        public string RequestDate { get; set; }
        public string ShippingPointCode { get; set; }
        public string ShippingPointName { get; set; }
        public string TotalDistance { get; set; }
        public string ActualDeliveryDate { get; set; }
        public string SMRemark { get; set; }
        public string TruckLicense { get; set; }
        public string ShiptoCode { get; set; }
        public string ShiptoRegion { get; set; }
        public string CustomerName { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityDescrition { get; set; }
        public string SMDescription { get; set; }
        public string ActualTenderDate { get; set; }
        public string ActualTenderAcceptDate { get; set; }
        public string ShiptoCity { get; set; }
        public string SMStatus { get; set; }
        public string Planner { get; set; }
        public string SMCreateDate { get; set; }
        public string MaterialDescription { get; set; }
        public string PONumber { get; set; }
    }

    public class Report007ViewModel
    {
        public string No { get; set; }
        public string SMCreateDate { get; set; }
        public string SONumber { get; set; }
        public string CustomerName { get; set; }
        public string Incoterm1 { get; set; }
        public string TotalWeight { get; set; }
        public string ShiptoDistrict { get; set; }
        public string ShiptoStreet { get; set; }
        public string ShiptoName { get; set; }
        public string MaterialDescription { get; set; }
        public string ShiptoRegionCode { get; set; }
        public string DNNumber { get; set; }
        public string SMNumber { get; set; }
        public string CarrierName { get; set; }
        public string EquipmentTypeName { get; set; }
        public string SMDescription { get; set; }
        public string ShippingPointName { get; set; }
        public string RequestDeliveryDate { get; set; }
        public string GIDate { get; set; }
        public string TruckLicense { get; set; }
        public string ActualDeliveryDate { get; set; }
        public string ActualDocumentReturnDate { get; set; }
        public string PlannerName { get; set; }
    }

    public class RPTESC003InventoryInquiryViewModel
    {
        public string warehouse { get; set; }
        public string location { get; set; }
        public string pallet_no { get; set; }
        public string tag_no { get; set; }
        public string product_code { get; set; }
        public string product_name { get; set; }
        public string product_condition { get; set; }
        public double inventory_qty { get; set; }
        public double book_qty { get; set; }
        public double balance_qty { get; set; }
        public string unit_code { get; set; }
        public BitArray bin_block { get; set; }
        public string product_group { get; set; }
        public string serial { get; set; }
        public string lot_no { get; set; }
        public double weight { get; set; }
        public double volumn { get; set; }
        public DateTime? received_date { get; set; }
        public DateTime? expired_date { get; set; }
        public DateTime? mfg_date { get; set; }
        public DateTime? last_movement { get; set; }
        public string po_no { get; set; }
        public string invoice_no { get; set; }
        public string doc_type { get; set; }
    }

    public class RPTCDC001CompareReceivingChartViewModel
    {
        public string customer_name { get; set; }
        public int total_qty_today { get; set; }
        public int received_qty_today { get; set; }
        public int putaway_qty_today { get; set; }
        public int outstanding_qty_today { get; set; }
        public int putaway_percent { get; set; }
        public int not_putaway_qty { get; set; }

    }

	public class RPTESC001CompareReceivingChartViewModel
	{
		public string customer_name { get; set; }
		public string transport_type { get; set; }
		public double total_qty_today { get; set; }
		public double received_qty_today { get; set; }
		public double putaway_qty_today { get; set; }
		public double outstanding_qty_today { get; set; }
		public double putaway_percent { get; set; }
		public double not_putaway_qty { get; set; }

	}

	public class RPTCDC003DispatchByCustomerTimeViewModel
    {
        public int dispatch_time { get; set; }
        public string customer_name { get; set; }
        public int dispatch_qty { get; set; }

    }
	public class RPTESC002DispatchByCustomerTimeViewModel
    {
        public int dispatch_time { get; set; }
        public string customer_name { get; set; }
        public double dispatch_qty { get; set; }

    }
    public class RPTCDC003DispatchByTimeViewModel
    {
        public int dispatch_time { get; set; }
        public int total_qty { get; set; }

    }
	public class RPTESC002DispatchByTimeViewModel
	{
		public int dispatch_time { get; set; }
		public double total_qty { get; set; }

	}

	public class RPTCDC001ReceivedByTimeViewModel
    {
        public int received_time { get; set; }
        public int total_qty { get; set; }
    }
	public class RPTESC001ReceivedByTimeViewModel
    {
        public int received_time { get; set; }
        public double total_ton { get; set; }
    }

    public class RPTCDC001ReceivedByCustomerTimeViewModel
    {
        public int received_time { get; set; }
        public string customer_name { get; set; }
        public int received_qty { get; set; }

    }

	public class RPTESC001ReceivedByCustomerTimeViewModel
	{
		public int received_time { get; set; }
		public string customer_name { get; set; }
		public double received_ton { get; set; }

	}


	public class RPTCDC001ReceivedSummaryViewModel
    {
        public string dc_name { get; set; }
        public int total_order { get; set; }
        public int received_order { get; set; }
        public int outstanding_order { get; set; }
    }
	public class RPTESC001ReceivedSummaryViewModel
	{
		public string dc_name { get; set; }
		public double total_order { get; set; }
		public double received_order { get; set; }
		public double outstanding_order { get; set; }
	}


	public class RPTCDC001ReceivedSummaryTableViewModel
    {
        public string customer_name { get; set; }
        public double total_qty_today { get; set; }
		public double issue_qty { get; set; }
		public double incomplete_received_qty { get; set; }
		public double received_qty_today { get; set; }
        public double putaway_qty_today { get; set; }
        public double putaway_percent { get; set; }
        public double not_putaway_qty { get; set; }
    }    
	public class RPTESC001ReceivedSummaryTableViewModel
    {
        public string customer_name { get; set; }
		public string transport_type { get; set; }
		public double total_qty_today { get; set; }
        public double received_qty_today { get; set; }
        public double putaway_qty_today { get; set; }
        public double outstanding_qty_today { get; set; }
        public double putaway_percent { get; set; }
        public double not_putaway_qty { get; set; }
    }

    public class RPTCDC003DispatchSummaryViewModel
    {
        public string dc_name { get; set; }
        public int total_order { get; set; }
        public int dispatch_order { get; set; }
        public int outstanding_order { get; set; }
    }
	public class RPTESC002DispatchSummaryViewModel
	{
		public string dc_name { get; set; }
		public double total_order { get; set; }
		public double total_trip { get; set; }
		public double dispatch_order { get; set; }
		public double outstanding_order { get; set; }
		public double dispatch_trip { get; set; }
		public double outstanding_trip { get; set; }
	}
	public class RPTCDC003CompareDispatchChartViewModel
    {
        public string customer_name { get; set; }
        public double plan_qty { get; set; }
        public double pick_qty { get; set; }
        public double ship_qty { get; set; }
        public double gi_qty { get; set; }
        public double gi_percent { get; set; }
        public double not_gi_qty { get; set; }

    }
	public class RPTESC002CompareDispatchChartViewModel
	{
		public string customer_name { get; set; }
		public string transport_type { get; set; }
		public double plan_qty { get; set; }
		public double pick_qty { get; set; }
		public double ship_qty { get; set; }
		public double gi_qty { get; set; }
		public double outstanding_qty { get; set; }
		public double gi_percent { get; set; }
		public double not_gi_qty { get; set; }

	}

	public class RPTCDC003DispatchSummaryTableViewModel
    {
        public string customer_name { get; set; }
		public double plan_qty { get; set; }
		public double new_qty { get; set; }
		public double book_qty { get; set; }
		public double issue_qty { get; set; }
		public double incomplete_pick_qty { get; set; }
		public double pick_qty { get; set; }
		public double incomplete_ship_qty { get; set; }
		public double ship_qty { get; set; }
		public double gi_qty { get; set; }
		public double gi_percent { get; set; }
		public double not_gi_qt { get; set; }
	}

	public class RPTESC002DispatchSummaryTableViewModel
	{
		public string customer_name { get; set; }
		public string transport_type { get; set; }
		public double plan_qty { get; set; }
		public double plan_trip { get; set; }
		public double pick_qty { get; set; }
		public double pick_trip { get; set; }
		public double ship_qty { get; set; }
		public double ship_trip { get; set; }
		public double gi_qty { get; set; }
		public double gi_trip { get; set; }
		public double outstanding_qty { get; set; }
		public double outstanding_trip { get; set; }
		public double gi_percent { get; set; }
		public double not_gi_qty { get; set; }
		public double not_gi_trip { get; set; }
	}


	public class RPTCDC002StockSummaryViewModel
    {
        public string dc_name { get; set; }
        public int total_location { get; set; }
        public int used_location { get; set; }
        public int avaliable_location { get; set; }
        public int qty { get; set; }
        public double used_percent { get; set; }
        public double avaliable_percent { get; set; }
    }

	public class RPTESC003StockSummaryViewModel
	{
		public string dc_name { get; set; }
		public double total_location { get; set; }
		public double used_location { get; set; }
		public double avaliable_location { get; set; }
		public double qty { get; set; }
		public double used_percent { get; set; }
		public double avaliable_percent { get; set; }
	}

	public class RPTCDC002StockByLocationTypeViewModel
    {
        public string location_type { get; set; }
        public int total_location { get; set; }
        public int plan_location { get; set; }
        public int used_location { get; set; }
    }
	public class RPTESC003StockByLocationTypeViewModel
	{
		public string location_type { get; set; }
		public double total_location { get; set; }
		public double plan_location { get; set; }
		public double used_location { get; set; }
	}
	public class RPTCDC002StorageByCustomerLocationViewModel
    {
        public string location_type { get; set; }
        public string customer_name { get; set; }
        public int used_location { get; set; }
    }
	public class RPTESC003StorageByCustomerLocationViewModel
	{
		public string location_type { get; set; }
		public string customer_name { get; set; }
		public double used_location { get; set; }
	}
	public class RPTCDC002StockByAgingViewModel
    {
        public string customer_name { get; set; }
        public int total_product { get; set; }
        public int age1 { get; set; }
        public int age2 { get; set; }
        public int age3 { get; set; }
        public int age4 { get; set; }
        public int age5 { get; set; }
        public int age6 { get; set; }
    }

	public class RPTESC003StockByAgingViewModel
	{
		public string customer_name { get; set; }
		public double total_product { get; set; }
		public double age1 { get; set; }
		public double age2 { get; set; }
		public double age3 { get; set; }
		public double age4 { get; set; }
		public double age5 { get; set; }
		public double age6 { get; set; }
	}
	public class RPTCDC002StorageByCustomerLocationPieceViewModel
    {
        public string location_type { get; set; }
        public string customer_name { get; set; }
        public int qty { get; set; }
    }    
	public class RPTESC003StorageByCustomerLocationPieceViewModel
    {
        public string location_type { get; set; }
        public string customer_name { get; set; }
        public double qty { get; set; }
    }
    public partial class WarehouseReceivingSummary
    {
        public List<RPTCDC001ReceivedSummaryViewModel> datalist { get; set; }
        public string xAxislabelString { get; set; }
        public string yAxislabelString { get; set; }
    }

	public partial class WarehouseESCReceivingSummary
	{
		public List<RPTESC001ReceivedSummaryViewModel> datalist { get; set; }
		public string xAxislabelString { get; set; }
		public string yAxislabelString { get; set; }
	}

	public partial class WarehouseDispatchingSummary
    {
        public List<RPTCDC003DispatchSummaryViewModel> datalist { get; set; }
        public string xAxislabelString { get; set; }
        public string yAxislabelString { get; set; }
    }

	public partial class WarehouseESCDispatchingSummary
	{
		public List<RPTESC002DispatchSummaryViewModel> datalist { get; set; }
		public string xAxislabelString { get; set; }
		public string yAxislabelString { get; set; }
	}

	public partial class RPTCDC005PickPackSummaryViewModel
    {
        public string dc_name { get; set; }
        public int pick_qty { get; set; }
        public int pack_qty { get; set; }
    }
	public partial class RPTESC005PickPackSummaryViewModel
    {
        public string dc_name { get; set; }
        public double pick_ton { get; set; }
        public int pack_qty { get; set; }
    }

    public partial class RPTCDC005PickByCustomerViewModel
    {
		public DateTime pick_date { get; set; }
        public string customer_name { get; set; }
        public int pick_qty { get; set; }
    }
    public partial class RPTESC005PickByCustomerViewModel
    {
        public string customer_name { get; set; }
        public double pick_ton { get; set; }
    }
   
    public partial class RPTCDC005PackByCustomerViewModel
    {
        public DateTime pack_date { get; set; }
        public string customer_name { get; set; }
        public int pack_qty { get; set; }
    }    
	public partial class RPTESC005PackByCustomerViewModel
    {
        public string customer_name { get; set; }
        public int pack_qty { get; set; }
    }
    public class RPTCDC005PickPackViewModel
    {
        public DateTime? picking_date { get; set; }
        public string invoice_no { get; set; }
        public string final_destination_code { get; set; }
        public string final_destination_name { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public double weight { get; set; }
        public double volumn { get; set; }
        public int installment { get; set; }
        public string shipment_no { get; set; }
        public int product_id { get; set; }
        public string doc_no { get; set; }
        public string type_code { get; set; }
        public string type_name { get; set; }
        public string doc_type { get; set; }
        public double ship_qty { get; set; }
        public string picking_no { get; set; }
        public string product_barcode { get; set; }
        public string product_code { get; set; }
        public string product_name { get; set; }
        public double pick_qty { get; set; }
        public string unit_code { get; set; }
        public double perpcs { get; set; }
        public string uomtn { get; set; }
        public double pcs2 { get; set; }
        public double pick_unit_charge { get; set; }
        public double pick_charge_unit { get; set; }
        public double pick_charge_item { get; set; }
        public string packing_no { get; set; }
        public DateTime? pack_date { get; set; }
        public string shipping_mark { get; set; }
        public string package_code { get; set; }
        public string package_name { get; set; }
        public int box_no { get; set; }
        public double pack_qty { get; set; }
        public string pack_charge_unit { get; set; }
        public string pack_charge_item { get; set; }
        public string void_no { get; set; }
        public double void_charge { get; set; }
    }

	public class RPTESC005PickPackViewModel
	{
		public DateTime? picking_date { get; set; }
		public string invoice_no { get; set; }
		public string final_destination_code { get; set; }
		public string final_destination_name { get; set; }
		public string city { get; set; }
		public string province { get; set; }
		public double weight { get; set; }
		public double volumn { get; set; }
		public int installment { get; set; }
		public string shipment_no { get; set; }
		public int product_id { get; set; }
		public string doc_no { get; set; }
		public string type_code { get; set; }
		public string type_name { get; set; }
		public string doc_type { get; set; }
		public double ship_qty { get; set; }
		public string picking_no { get; set; }
		public string product_barcode { get; set; }
		public string product_code { get; set; }
		public string product_name { get; set; }
		public double pick_qty { get; set; }
		public string unit_code { get; set; }
		public double perpcs { get; set; }
		public string uomtn { get; set; }
		public double pcs2 { get; set; }
		public double pick_unit_charge { get; set; }
		public double pick_charge_unit { get; set; }
		public double pick_charge_item { get; set; }
		public string packing_no { get; set; }
		public DateTime? pack_date { get; set; }
		public string shipping_mark { get; set; }
		public string package_code { get; set; }
		public string package_name { get; set; }
		public int box_no { get; set; }
		public double pack_qty { get; set; }
		public string pack_charge_unit { get; set; }
		public string pack_charge_item { get; set; }
		public string void_no { get; set; }
		public double void_charge { get; set; }
	}
	public partial class RPTCDC006CheckMoveQtyViewModel
    {
        public string dc_name { get; set; }
        public int plan_qty { get; set; }
        public double count_qty { get; set; }
        public double accuracy { get; set; }

    }
	public partial class RPTESC004CheckMoveQtyViewModel
	{
		public string dc_name { get; set; }
		public int plan_location { get; set; }
		public int count_location { get; set; }
		public double location_accuracy { get; set; }
		public double plan_weight { get; set; }
		public double count_weight { get; set; }
		public double weight_accuracy { get; set; }

	}

	public partial class RPTCDC006CheckMoveByLocationViewModel
    {
        public DateTime? count_date { get; set; }
        public string location_type { get; set; }
        public double inventory_qty { get; set; }
        public double count_qty { get; set; }

    }

	public partial class RPTESC004CheckMoveByLocationViewModel
	{
		public DateTime? count_date { get; set; }
		public string location_type { get; set; }
		public double inventory_weight { get; set; }
		public double count_weight { get; set; }

	}

	public partial class CheckMoveByLocationSummaryDetailViewModel
    {
		public string rowType { get; set; }
		public string[] qty { get; set; }
    }

	public partial class ESCCheckMoveByLocationSummaryDetailViewModel
	{
		public string rowType { get; set; }
		public double[] qty { get; set; }
	}
	public partial class CheckMoveByLocationSummaryHederViewModel
    {
		public string[] date { get; set; }
		public string[] location_type { get; set; }
		public int[] CountColDate { get; set; }


	}
	public partial class CheckMoveByLocationSummaryTableViewModel
	{
		public CheckMoveByLocationSummaryHederViewModel header { get; set; }
		public CheckMoveByLocationSummaryDetailViewModel[] data { get; set; }
	}
	public partial class ESCCheckMoveByLocationSummaryTableViewModel
	{
		public CheckMoveByLocationSummaryHederViewModel header { get; set; }
		public ESCCheckMoveByLocationSummaryDetailViewModel[] data { get; set; }
	}

	public partial class RPTCDC000ReceiveAccuracyViewModel
    {
		public DateTime? receive_date { get; set; }
		public int plan_order { get; set; }
		public int receive_order { get; set; }
		public int plan_qty { get; set; }
		public int receive_qty { get; set; }

	}

	public partial class RPTCDC000DispatchAccuracyViewModel
	{
		public DateTime? dispatch_date { get; set; }
		public int plan_order { get; set; }
		public int dispatch_order { get; set; }
		public int plan_qty{ get; set; }
		public int dispatch_qty{ get; set; }
	}

	public partial class RPTCDC000ReceiveDispatchViewModel
	{
		public DateTime? trans_date { get; set; }
		public int received_qty { get; set; }
		public int dispatch_qty { get; set; }		
		public int received_order { get; set; }
		public int dispatch_order { get; set; }
	}

	public partial class RPTCDC000StockUtilizationViewModel
	{
		public DateTime? trans_date { get; set; }
		public string location_type { get; set; }
		public int total_location { get; set; }
		public int used_location { get; set; }

	}

	public partial class RPTCDC000AgingProductViewModel
    {
		public DateTime? trans_date { get; set; }
		public string location_type { get; set; }
		public int age1 { get; set; }
		public int age2 { get; set; }
		public int age3 { get; set; }
		public int age4 { get; set; }
		public int age5 { get; set; }
		public int age6 { get; set; }
    }

}