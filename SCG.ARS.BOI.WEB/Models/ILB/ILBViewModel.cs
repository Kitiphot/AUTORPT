using SCG.ARS.BOI.WEB.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.ILB
{
	public class ILBViewModel
	{
	}

	public class RPTILB001ViewModel
	{
		public string scgl_po_id { get; set; }
		public string service_group { get; set; }
		public string document_status { get; set; }
		public string customer_status { get; set; }
		public string importer { get; set; }
		public string bu { get; set; }
		public string contact_name { get; set; }
		public string pr_received_date { get; set; }
		public string pr_no { get; set; }
		public string plan_condition_date { get; set; }
		public string mode { get; set; }
		public string po_no { get; set; }
		public string shipment_noti_no { get; set; }
		public string po_date { get; set; }
		public string supplier_date { get; set; }
		public string order_cofirm_date { get; set; }
		public string currency { get; set; }
		public string po_amount { get; set; }
		public string po_balance { get; set; }
		public string plan_etd_date { get; set; }
		public string po_type { get; set; }
		public string product_type { get; set; }
		public string supplier { get; set; }
		public string payment_term { get; set; }
		public string incoterms { get; set; }
		public string forwarder { get; set; }
		public string po_remark { get; set; }
		public string payment_remark { get; set; }
		public string privilege_type { get; set; }
		public string license { get; set; }
		public string tolerance { get; set; }
		public string terminated { get; set; }
		public string created_by { get; set; }
		public string created_date { get; set; }
		public string updated_by { get; set; }
		public string updated_date { get; set; }
		public string locked_by { get; set; }
		public string locked_date { get; set; }
	}
	public class RPTILB002ViewModel
	{
		public string service_group { get; set; }
		public string bu { get; set; }
		public string importer { get; set; }
		public string po_no { get; set; }
		public string ship_no { get; set; }
		public string document_status { get; set; }
		public string plan_etd_date { get; set; }
		public string request_delivery_date { get; set; }
		public string est_readiness_date { get; set; }
		public string request_etd_date { get; set; }
		public string mode { get; set; }
		public string incoterms { get; set; }
		public string supplier { get; set; }
		public string received_complete_date { get; set; }
		public string invoice_no { get; set; }
		public string invoice_amount { get; set; }
		public string invoice_currency { get; set; }
		public string awb_no { get; set; }
		public string carrier { get; set; }
		public string forwarder { get; set; }
		public string pol { get; set; }
		public string pod { get; set; }
		public string first_cargo_description { get; set; }
		public string net_weight { get; set; }
		public string gross_weight { get; set; }
		public string actual_etd_date { get; set; }
		public string eta_date { get; set; }
		public string ata_port_date { get; set; }
		public string ata_complete_container_date { get; set; }
		public string vessel_name { get; set; }
		public string privilege_type { get; set; }
		public string license { get; set; }
		public string or_no { get; set; }
		public string po_service_no { get; set; }
		public string customs_broker { get; set; }
		public string import_tax_withdraw_date { get; set; }
		public string import_entry_no { get; set; }
		public string tax_debit_date { get; set; }
		public string customs_released_date { get; set; }
		public string customs_released_place { get; set; }
		public string empty_return_place { get; set; }
		public string delivery_place { get; set; }
		public string delivery_date { get; set; }
		public string require_payment { get; set; }
		public string rent_day { get; set; }
		public string rent_charge { get; set; }
		public string dem_day { get; set; }
		public string dem_charge { get; set; }
		public string det_day { get; set; }
		public string det_charge { get; set; }
		public string rent_date { get; set; }
		public string dem_date { get; set; }
		public string det_date { get; set; }
		public string shipment_remark { get; set; }
		public string active { get; set; }
		public string created_by { get; set; }
		public string created_date { get; set; }
		public string updated_by { get; set; }
		public string updated_date { get; set; }
		public string locked_by { get; set; }
		public string locked_date { get; set; }
		public string manual_shipment { get; set; }
		public string customer_status { get; set; }
		public string shipment_id { get; set; }
		public string value_date { get; set; }
	}
	public class RPTILB003ViewModel
	{
		public string scgl_po_id { get; set; }
		public string service_group { get; set; }
		public string document_status { get; set; }
		public string customer_status { get; set; }
		public string importer { get; set; }
		public string bu { get; set; }
		public string contact_name { get; set; }
		public string pr_received_date { get; set; }
		public string pr_no { get; set; }
		public string plan_condition_date { get; set; }
		public string mode { get; set; }
		public string po_no { get; set; }
		public string po_date { get; set; }
		public string supplier_date { get; set; }
		public string order_cofirm_date { get; set; }
		public string currency { get; set; }
		public string po_amount { get; set; }
		public string po_balance { get; set; }
		public string plan_etd_date { get; set; }
		public string po_type { get; set; }
		public string product_type { get; set; }
		public string supplier { get; set; }
		public string payment_term { get; set; }
		public string incoterms { get; set; }
		public string forwarder { get; set; }
		public string po_remark { get; set; }
		public string payment_remark { get; set; }
		public string privilege_type { get; set; }
		public string license { get; set; }
		public string tolerance { get; set; }
		public string terminated { get; set; }
		public string created_by { get; set; }
		public string created_date { get; set; }
		public string updated_by { get; set; }
		public string updated_date { get; set; }
		public string locked_by { get; set; }
		public string locked_date { get; set; }
		public int kpi_issue_po { get; set; }
		public int kpi_sent_po_supplier { get; set; }
		public int kpi_order_confirm_received { get; set; }

	}
	public class RPTILB004ViewModel
	{
		public string service_group { get; set; }
		public string bu { get; set; }
		public string importer { get; set; }
		public string po_no { get; set; }
		public string ship_no { get; set; }
		public string document_status { get; set; }
		public string plan_etd_date { get; set; }
		public string request_delivery_date { get; set; }
		public string est_readiness_date { get; set; }
		public string request_etd_date { get; set; }
		public string mode { get; set; }
		public string incoterms { get; set; }
		public string supplier { get; set; }
		public string received_complete_date { get; set; }
		public string invoice_no { get; set; }
		public string invoice_amount { get; set; }
		public string invoice_currency { get; set; }
		public string awb_no { get; set; }
		public string carrier { get; set; }
		public string forwarder { get; set; }
		public string pol { get; set; }
		public string pod { get; set; }
		public string first_cargo_description { get; set; }
		public string net_weight { get; set; }
		public string gross_weight { get; set; }
		public string actual_etd_date { get; set; }
		public string eta_date { get; set; }
		public string ata_port_date { get; set; }
		public string ata_complete_container_date { get; set; }
		public string vessel_name { get; set; }
		public string privilege_type { get; set; }
		public string license { get; set; }
		public string or_no { get; set; }
		public string po_service_no { get; set; }
		public string customs_broker { get; set; }
		public string import_tax_withdraw_date { get; set; }
		public string import_entry_no { get; set; }
		public string tax_debit_date { get; set; }
		public string customs_released_date { get; set; }
		public string customs_released_place { get; set; }
		public string empty_return_place { get; set; }
		public string delivery_place { get; set; }
		public string delivery_date { get; set; }
		public string require_payment { get; set; }
		public string rent_day { get; set; }
		public string rent_charge { get; set; }
		public string dem_day { get; set; }
		public string dem_charge { get; set; }
		public string det_day { get; set; }
		public string det_charge { get; set; }
		public string rent_date { get; set; }
		public string dem_date { get; set; }
		public string det_date { get; set; }
		public string shipment_remark { get; set; }
		public string active { get; set; }
		public string created_by { get; set; }
		public string created_date { get; set; }
		public string updated_by { get; set; }
		public string updated_date { get; set; }
		public string locked_by { get; set; }
		public string locked_date { get; set; }
		public string manual_shipment { get; set; }
		public string customer_status { get; set; }
		public string shipment_id { get; set; }
		public string value_date { get; set; }
		public int? kpi_receive_shipdoc_sea { get; set; }
		public int? kpi_receive_shipdoc_air { get; set; }
		public int? kpi_custom_clearance_sea { get; set; }
		public int? kpi_custom_clearance_air { get; set; }
		public string remark { get; set; }
	}

	public class RPTILB005GetColumnViewModel
	{
		public string column_code { get; set; }
		public string column_desc { get; set; }
	}

	public class ILBContainerTypeViewModel {
		public string container_code { get; set; }
		public string container_name { get; set; }
	}

	public class RPTILB006ViewModel
	{
		public string hl_plan_id { get; set; }
		public string status { get; set; }
		public string tendercompleted { get; set; }
		public string order_type { get; set; }
		public string customer_ref { get; set; }
		public string customer { get; set; }
		public string exporter { get; set; }
		public string customer_address { get; set; }
		public string carrier_booking_no { get; set; }
		public string customs_vendor { get; set; }
		public string contact { get; set; }
		public string freight_agent { get; set; }
		public string forwarder { get; set; }
		public string fumigate { get; set; }
		public string survey { get; set; }
		public string invoice_no { get; set; }
		public string cargo { get; set; }
		public string package { get; set; }
		public string cargo_weight { get; set; }
		public string note { get; set; }
		public string port_country { get; set; }
		public string frd { get; set; }
		public string feeder_vessel { get; set; }
		public string ocean_vessel { get; set; }
		public string si_cutoff { get; set; }
		public string vgm_cutoff { get; set; }
		public string etd { get; set; }
		public string eta { get; set; }
		public string code_paperless { get; set; }
		public string total_container { get; set; }
		public string closing_datetime { get; set; }
		public string cy_place { get; set; }
		public string cy_date { get; set; }
		public string container_qty { get; set; }
		public string container_type { get; set; }
		public string return_place { get; set; }
		public string return_date { get; set; }
		public string factory { get; set; }
		public string contact_2 { get; set; }
		public string hl_carrier { get; set; }
		public string shore { get; set; }
		public string qty { get; set; }
		public string truck_type { get; set; }
		public string truck_load_empty_container { get; set; }
		public string truck_load_full_container { get; set; }
	}
	public class RPTILB007ViewModel
	{
		public string service_group { get; set; }
		public string bu { get; set; }
		public string importer { get; set; }
		public string po_no { get; set; }
		public string ship_no { get; set; }
		public string document_status { get; set; }
		public string plan_etd_date { get; set; }
		public string request_delivery_date { get; set; }
		public string est_readiness_date { get; set; }
		public string request_etd_date { get; set; }
		public string mode { get; set; }
		public string incoterms { get; set; }
		public string supplier { get; set; }
		public string received_complete_date { get; set; }
		public string invoice_no { get; set; }
		public string invoice_amount { get; set; }
		public string invoice_currency { get; set; }
		public string awb_no { get; set; }
		public string carrier { get; set; }
		public string forwarder { get; set; }
		public string pol { get; set; }
		public string pod { get; set; }
		public string first_cargo_description { get; set; }
		public string net_weight { get; set; }
		public string gross_weight { get; set; }
		public string actual_etd_date { get; set; }
		public string eta_date { get; set; }
		public string ata_port_date { get; set; }
		public string ata_complete_container_date { get; set; }
		public string vessel_name { get; set; }
		public string privilege_type { get; set; }
		public string license { get; set; }
		public string or_no { get; set; }
		public string po_service_no { get; set; }
		public string customs_broker { get; set; }
		public string import_tax_withdraw_date { get; set; }
		public string import_entry_no { get; set; }
		public string tax_debit_date { get; set; }
		public string customs_released_date { get; set; }
		public string customs_released_place { get; set; }
		public string empty_return_place { get; set; }
		public string delivery_place { get; set; }
		public string require_payment { get; set; }
		public string rent_day { get; set; }
		public string rent_charge { get; set; }
		public string dem_day { get; set; }
		public string dem_charge { get; set; }
		public string det_day { get; set; }
		public string det_charge { get; set; }
		public string rent_date { get; set; }
		public string dem_date { get; set; }
		public string det_date { get; set; }
		public string shipment_remark { get; set; }
		public string active { get; set; }
		public string created_by { get; set; }
		public string created_date { get; set; }
		public string updated_by { get; set; }
		public string updated_date { get; set; }
		public string locked_by { get; set; }
		public string locked_date { get; set; }
		public string manual_shipment { get; set; }
		public string customer_status { get; set; }
		public string shipment_id { get; set; }
		public string value_date { get; set; }
	}
	public class RPTILB_Summary_Chart
	{
		public DateTime po_date { get; set; }
		public int total_po { get; set; }
		public int total_no_po { get; set; }
		public int total_no_ss { get; set; }
		public int total_no_co { get; set; }
		public int total_no_cl_po { get; set; }
		public int total_no_shipment{ get; set; }
	}
	public class RPTILB_Summary_Status
	{
		public int total_po { get; set; }
		public int total_no_po { get; set; }
		public int total_no_ss { get; set; }
		public int total_no_co { get; set; }
		public int total_no_cl_po { get; set; }
		public int total_no_shipment { get; set; }
	}

	public class RPTILB_Po_Kpi_monthly_Status
	{
		public DateTime po_date { get; set; }
		public int total_po { get; set; }
		public int issue_delay { get; set; }
		public int issue_ontime { get; set; }
		public int sent_supp_delay { get; set; }
		public int sent_supp_ontime { get; set; }
		public int order_confirm_delay { get; set; }
		public int order_confirm_ontime { get; set; }
	}

	public class RPTILB_Po_Kpi_Status
	{
		public int total_po { get; set; }
		public int issue_delay { get; set; }
		public int issue_ontime { get; set; }
		public int sent_supp_delay { get; set; }
		public int sent_supp_ontime { get; set; }
		public int order_confirm_delay { get; set; }
		public int order_confirm_ontime { get; set; }
	}

	public class RPTILB_Summary_Shpmnt_Chart
	{
		public DateTime etd_date { get; set; }
		public int total_shpmnt { get; set; }
		public int total_no_readiness { get; set; }
		public int total_no_act_etd { get; set; }
		public int total_no_delivery { get; set; }
		public int total_no_cl_shpmnt { get; set; }
		public int pending_shipdoc { get; set; }
		public int pending_custom_release { get; set; }
		public int pending_close { get; set; }

	}
	public class RPTILB07_Summary_Shpmnt_Chart
	{
		public DateTime eta_date { get; set; }
		public int sea_shipment { get; set; }
		public int air_shipment { get; set; }
	}
	public class RPTILB_Summary_Shpmnt_Status
	{
		public int total_shpmnt { get; set; }
		public int total_no_readiness { get; set; }
		public int total_no_act_etd { get; set; }
		public int total_no_delivery { get; set; }
		public int total_no_cl_shpmnt { get; set; }
		public int pending_shipdoc { get; set; }
		public int pending_custom_release { get; set; }
		public int pending_close { get; set; }
		

	}

	public class RPTILB07_Summary_Shpmnt_Status
	{
		public int total_shipment { get; set; }
		public int sea_shipment { get; set; }
		public int air_shipment { get; set; }

	}

	public class RPTILB_monthy_shpmnt_kpi
	{
		public DateTime delivery_date { get; set; }
		public int receive_ship_sea_delay { get; set; }
		public int receive_ship_sea_ontime { get; set; }
		public int receive_ship_air_delay { get; set; }
		public int receive_ship_air_ontime { get; set; }
		public int custom_clear_sea_delay { get; set; }
		public int custom_clear_sea_ontime { get; set; }
		public int custom_clear_air_delay { get; set; }
		public int custom_clear_air_ontime { get; set; }

	}
	public class RPTILB_Summary_shpmnt_kpi_Status
	{

		public int receive_ship_sea_delay { get; set; }
		public int receive_ship_sea_ontime { get; set; }
		public int receive_ship_air_delay { get; set; }
		public int receive_ship_air_ontime { get; set; }
		public int custom_clear_sea_delay { get; set; }
		public int custom_clear_sea_ontime { get; set; }
		public int custom_clear_air_delay { get; set; }
		public int custom_clear_air_ontime { get; set; }
	}



	public class RPTILB_export_monthy_carrier
	{
		public DateTime booking_date { get; set; }
		public int kpi_plus { get; set; }
		public int kpi_minus { get; set; }
		public int total { get; set; }

	}
	public class RPTILB_export_summary_carrier
	{
		public int kpi_pass { get; set; }
		public int kpi_fail { get; set; }
		public int booking_incomplete { get; set; }
		public int total { get; set; }

	}

	public class RPTILB_Export_Summary_Order_Status { 
		public int new_order { get; set; }
		public int processing { get; set; }
		public int wait_confirm { get; set; }
		public int confirmed { get; set; }
		public int completed { get; set; }
		public int total { get; set; }
	}

	public class RPTILB_Summary_Haulage
	{
		public int total_haulage { get; set; }
	}
	public class RPTILB_Haulage_Chart
	{
		public DateTime cy_date { get; set; }
		public int tendered { get; set; }
		public int not_tendered { get; set; }
	}
}