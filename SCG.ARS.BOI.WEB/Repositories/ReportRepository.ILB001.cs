using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NLog;
using Npgsql;
using Quartz.Util;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.ILB;
using SCG.ARS.BOI.WEB.Models.Packaging;


namespace SCG.ARS.BOI.WEB.Repositories
{
	public partial class ReportRepository
	{
		#region ILB001
		public List<RPTILB_Summary_Chart> ILB001_Summary_Chart(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectEndDate = DateTime.Parse(input.selectEndDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Summary_Chart>($@"SELECT *
																 from ilb.get_ilb01_summary(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup);"
															   ,
															   param: new
															   {
																   selectStartDate,
																   selectEndDate,
																   input.selectDaySearch,
																   input.selectMonth,
																   input.selectYear,
																   serviceGroup = input.selectServiceGroup ?? new string[] { }
															   }, commandTimeout: 3000);

				return data.ToList();
			}
		}

		public List<RPTILB_Summary_Status> ILB001_Summary_Status(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectEndDate = DateTime.Parse(input.selectEndDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Summary_Status>($@"SELECT *
																 from ilb.get_ilb01_summary_status(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup);"
															  ,
															   param: new
															   {
																   selectStartDate,
																   selectEndDate,
																   input.selectDaySearch,
																   input.selectMonth,
																   input.selectYear,
																   serviceGroup = input.selectServiceGroup ?? new string[] { }
															   }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB001ViewModel> RPTILB001_Report(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.ParseExact(input.selectStartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			DateTime selectEndDate = DateTime.ParseExact(input.selectEndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB001ViewModel>($@"select scgl_po_id
																	, service_group
																	, document_status
																	, customer_status
																	, importer
																	, bu
																	, contact_name
																	, pr_received_date
																	, pr_no
																	, plan_condition_date
																	, ""mode""
																	, po_no
																	, shipment_noti_no
																	, po_date
																	, supplier_date
																	, order_cofirm_date
																	, currency
																	, po_amount
																	, po_balance
																	, plan_etd_date
																	, po_type
																	, product_type
																	, supplier
																	, payment_term
																	, incoterms
																	, forwarder
																	, po_remark
																	, payment_remark
																	, privilege_type
																	, license
																	, tolerance
																	, terminated
																	, created_by
																	, created_date
																	, updated_by
																	, updated_date
																	, locked_by
																	, locked_date
																	FROM ilb.get_report_ilb001(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup,@selectCriteria); ",
															   param: new
															   {
																   selectStartDate,
																   selectEndDate,
																   input.selectDaySearch,
																   input.selectMonth,
																   input.selectYear,
																   serviceGroup = input.selectServiceGroup ?? new string[] { },
																   input.selectCriteria
															   }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		#endregion

		#region ILB002
		public List<RPTILB002ViewModel> RPTILB002_Report(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.ParseExact(input.selectStartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			DateTime selectEndDate = DateTime.ParseExact(input.selectEndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB002ViewModel>($@"select service_group
																	, bu
																	, importer
																	, po_no
																	, ship_no
																	, document_status
																	, plan_etd_date
																	, request_delivery_date
																	, est_readiness_date
																	, request_etd_date
																	, ""mode""
																	, incoterms
																	, supplier
																	, received_complete_date
																	, invoice_no
																	, invoice_amount
																	, invoice_currency
																	, awb_no
																	, carrier
																	, forwarder
																	, pol
																	, pod
																	, first_cargo_description
																	, net_weight
																	, gross_weight
																	, actual_etd_date
																	, eta_date
																	, ata_port_date
																	, ata_complete_container_date
																	, vessel_name
																	, privilege_type
																	, license
																	, or_no
																	, po_service_no
																	, customs_broker
																	, import_tax_withdraw_date
																	, import_entry_no
																	, tax_debit_date
																	, customs_released_date
																	, customs_released_place
																	, empty_return_place
																	, delivery_place
																	, delivery_date
																	, require_payment
																	, rent_day
																	, rent_charge
																	, dem_day
																	, dem_charge
																	, det_day
																	, det_charge
																	, rent_date
																	, dem_date
																	, det_date
																	, shipment_remark
																	, active
																	, created_by
																	, created_date
																	, updated_by
																	, updated_date
																	, locked_by
																	, locked_date
																	, manual_shipment
																	, customer_status
																	, shipment_id
																	, value_date
																   FROM ilb.get_report_ilb002(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup,@selectCriteria);"
																   , param: new
																   {
																	   selectStartDate,
																	   selectEndDate,
																	   input.selectDaySearch,
																	   input.selectMonth,
																	   input.selectYear,
																	   serviceGroup = input.selectServiceGroup ?? new string[] { },
																	   input.selectCriteria
																   }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB_Summary_Shpmnt_Status> ILB002_Summary_Status(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectEndDate = DateTime.Parse(input.selectEndDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Summary_Shpmnt_Status>($@"SELECT *
																 from ilb.get_ilb02_summary_status(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup);"
																, param: new
																{
																	selectStartDate,
																	selectEndDate,
																	input.selectDaySearch,
																	input.selectMonth,
																	input.selectYear,
																	serviceGroup = input.selectServiceGroup ?? new string[] { }
																}, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB_Summary_Shpmnt_Chart> ILB002_Summary_Shpmnt_Chart(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectEndDate = DateTime.Parse(input.selectEndDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Summary_Shpmnt_Chart>($@"SELECT *
																 from ilb.get_ilb02_monthly_status(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup); "
																  , param: new
																  {
																	  selectStartDate,
																	  selectEndDate,
																	  input.selectDaySearch,
																	  input.selectMonth,
																	  input.selectYear,
																	  serviceGroup = input.selectServiceGroup ?? new string[] { }
																  }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		#endregion

		#region ILB003
		public List<RPTILB003ViewModel> RPTILB003_Report(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.ParseExact(input.selectStartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			DateTime selectEndDate = DateTime.ParseExact(input.selectEndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB003ViewModel>($@"select scgl_po_id
																	, service_group
																	, document_status
																	, customer_status
																	, importer
																	, bu
																	, contact_name
																	, pr_received_date
																	, pr_no
																	, plan_condition_date
																	, ""mode""
																	, po_no
																	, po_date
																	, supplier_date
																	, order_cofirm_date
																	, currency
																	, po_amount
																	, po_balance
																	, plan_etd_date
																	, po_type
																	, product_type
																	, supplier
																	, payment_term
																	, incoterms
																	, forwarder
																	, po_remark
																	, payment_remark
																	, privilege_type
																	, license
																	, tolerance
																	, terminated
																	, created_by
																	, created_date
																	, updated_by
																	, updated_date
																	, locked_by
																	, locked_date
																	, kpi_issue_po
																	, kpi_sent_po_supplier
																	, kpi_order_confirm_received
																   FROM ilb.get_report_ilb003 (@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup,@selectCriteria); "
																	, param: new
																	{
																		selectStartDate,
																		selectEndDate,
																		input.selectDaySearch,
																		input.selectMonth,
																		input.selectYear,
																		serviceGroup = input.selectServiceGroup ?? new string[] { },
																		input.selectCriteria
																	}, commandTimeout: 3000);
				return data.ToList();
			}
		}
		public List<RPTILB_Po_Kpi_monthly_Status> ILB003_Summary_PO_Monthly_Status(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectEndDate = DateTime.Parse(input.selectEndDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Po_Kpi_monthly_Status>($@"SELECT *
																  from ilb.get_ilb03_monthly_status(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup);"
																   , param: new
																   {
																	   selectStartDate,
																	   selectEndDate,
																	   input.selectDaySearch,
																	   input.selectMonth,
																	   input.selectYear,
																	   serviceGroup = input.selectServiceGroup ?? new string[] { }
																   }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB_Po_Kpi_Status> ILB003_Summary_Status(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectEndDate = DateTime.Parse(input.selectEndDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Po_Kpi_Status>($@"SELECT *
																 from ilb.get_ilb03_summary_status(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup); "
																  , param: new
																  {
																	  selectStartDate,
																	  selectEndDate,
																	  input.selectDaySearch,
																	  input.selectMonth,
																	  input.selectYear,
																	  serviceGroup = input.selectServiceGroup ?? new string[] { }
																  }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		#endregion

		#region ILB004
		public List<RPTILB004ViewModel> RPTILB004_Report(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.ParseExact(input.selectStartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			DateTime selectEndDate = DateTime.ParseExact(input.selectEndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB004ViewModel>($@"select service_group
																	, bu
																	, importer
																	, po_no
																	, ship_no
																	, document_status
																	, plan_etd_date
																	, request_delivery_date
																	, est_readiness_date
																	, request_etd_date
																	, ""mode""
																	, incoterms
																	, supplier
																	, received_complete_date
																	, invoice_no
																	, invoice_amount
																	, invoice_currency
																	, awb_no
																	, carrier
																	, forwarder
																	, pol
																	, pod
																	, first_cargo_description
																	, net_weight
																	, gross_weight
																	, actual_etd_date
																	, eta_date
																	, ata_port_date
																	, ata_complete_container_date
																	, vessel_name
																	, privilege_type
																	, license
																	, or_no
																	, po_service_no
																	, customs_broker
																	, import_tax_withdraw_date
																	, import_entry_no
																	, tax_debit_date
																	, customs_released_date
																	, customs_released_place
																	, empty_return_place
																	, delivery_place
																	, delivery_date
																	, require_payment
																	, rent_day
																	, rent_charge
																	, dem_day
																	, dem_charge
																	, det_day
																	, det_charge
																	, rent_date
																	, dem_date
																	, det_date
																	, shipment_remark
																	, active
																	, created_by
																	, created_date
																	, updated_by
																	, updated_date
																	, locked_by
																	, locked_date
																	, manual_shipment
																	, customer_status
																	, shipment_id
																	, value_date
																	, kpi_receive_shipdoc_sea
																	, kpi_receive_shipdoc_air
																	, kpi_custom_clearance_sea
																	, kpi_custom_clearance_air
																	, remark
																   FROM ilb.get_report_ilb004(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup,@selectCriteria); "
																	, param: new
																	{
																		selectStartDate,
																		selectEndDate,
																		input.selectDaySearch,
																		input.selectMonth,
																		input.selectYear,
																		serviceGroup = input.selectServiceGroup ?? new string[] { },
																		input.selectCriteria
																	}, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB_Summary_shpmnt_kpi_Status> ILB004_Summary_Status(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectEndDate = DateTime.Parse(input.selectEndDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Summary_shpmnt_kpi_Status>($@"SELECT *
																 from ilb.get_ilb04_summary_status(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup); "
																  , param: new
																  {
																	  selectStartDate,
																	  selectEndDate,
																	  input.selectDaySearch,
																	  input.selectMonth,
																	  input.selectYear,
																	  serviceGroup = input.selectServiceGroup ?? new string[] { }
																  }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB_monthy_shpmnt_kpi> ILB004_Summary_Chart(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectEndDate = DateTime.Parse(input.selectEndDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_monthy_shpmnt_kpi>($@"SELECT *
																 from ilb.get_ilb04_monthly_status(@selectStartDate,@selectEndDate,@selectDaySearch,@selectMonth,@selectYear,@ServiceGroup);"
																  , param: new
																  {
																	  selectStartDate,
																	  selectEndDate,
																	  input.selectDaySearch,
																	  input.selectMonth,
																	  input.selectYear,
																	  serviceGroup = input.selectServiceGroup ?? new string[] { }
																  }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		#endregion

		#region ILB005
		public DataTable RPTILB005_Report(ILBRequestModel request, string dateType)
		{
			var list = RPTILB_GetContainerType();
			var col = list.Select(o => "\"container_" + o.container_code + "\"").ToArray(); // ["container_01", "container_02", ...]
			var colParam = "{" + list.Select(o => "\"" + o.container_code + "\"").ToArray().Join() + "}"; // '{"01", "02", ...}
			var serviceGroup = "{" + (request.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join()  + "}";

			var sql = $@"SELECT *
						 from ilb.get_report_ilb005('{colParam}'
												, '{dateType}'
												, {GetNullDbDateString(request.selectStartDate)}
												, {GetNullDbDateString(request.selectEndDate)}
												, '{serviceGroup}'
												, {getNullDb(request.selectCriteria)}
												) as t  
						 (""no"" bigint,
						   status character varying,
						   booking_id character varying,
						   booker character varying,
						   shiper character varying,
						   cust_ref_1 character varying,
						   cust_ref_2 character varying,
						   carrier_bkg_no character varying,
						   ""mode"" character varying,
						   incoterm character varying,
						   carrier character varying,
						   carrier_request_date text,
						   carrier_response_date text,
						   time_to_response int,
						   pol character varying,
						   country_pol character varying,
						   pod character varying,
						   country_pod character varying,
						   etd text,
						   eta text,
						   {string.Join("  bigint, ", col)} bigint,
						   cy_place character varying,
						   cy_date text,
						   return_place character varying,
						   return_date text,
						   scgl_confirm_load_date text,
						   closing_date_time text,
						   vessel_name character varying,
						   scgl_ref_no character varying,
						   cargo_desc character varying,
						   move_perspective character varying,
						   group_rate character varying,
						   rate_type character varying)
						 ;";
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				NpgsqlCommand com = new NpgsqlCommand(sql, (NpgsqlConnection)(Connection));
				com.CommandTimeout = 3000;
				NpgsqlDataAdapter ad = new NpgsqlDataAdapter(com);
				//var data = dbConnection.Query<R PTILB005ViewModel>(sql, commandTimeout: 3000);
				DataTable dt = new DataTable();
				ad.Fill(dt);
				return dt;
			}
		}
		public List<ILBContainerTypeViewModel> RPTILB_GetContainerType()
		{
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<ILBContainerTypeViewModel>($@"select container_code, container_name
																			  from ilb.get_container_type(); ", commandTimeout: 3000);

				return data.ToList();
			}
		}

		public List<RPTILB_export_monthy_carrier> ILB005_CYDate_Chart(ILBRequestModel input) {
			var serviceGroup = "{" + (input.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var sql = $@"SELECT *
							from ilb.get_ilb05_chart_cydate({GetNullDbDateString(input.selectStartDate)},
															{GetNullDbDateString(input.selectEndDate)},
															{getNullDb(input.selectDaySearch)},
															{getNullDb(input.selectMonth)},
															{getNullDb(input.selectYear)},
															'{serviceGroup}')
						; ";

				var data = dbConnection.Query<RPTILB_export_monthy_carrier>(sql, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB_export_monthy_carrier> ILB005_ReturnDate_Chart(ILBRequestModel input) {
			var serviceGroup = "{" + (input.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";
			using (IDbConnection dbConnection = Connection) {
				dbConnection.Open();
				var sql = $@"SELECT *
							from ilb.get_ilb05_chart_returndate({GetNullDbDateString(input.selectStartDate)},
															{GetNullDbDateString(input.selectEndDate)},
															{getNullDb(input.selectDaySearch)},
															{getNullDb(input.selectMonth)},
															{getNullDb(input.selectYear)},
															'{serviceGroup}')
						; ";

				var data = dbConnection.Query<RPTILB_export_monthy_carrier>(sql, commandTimeout: 3000);

				return data.ToList();
			}
		}

		public List<RPTILB_export_summary_carrier> ILB005_Summary_Status(ILBRequestModel input) {
			var serviceGroup = "{" + (input.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";
			var sql = $@"SELECT *
					   from ilb.get_ilb05_summary_status({GetNullDbDateString(input.selectStartDate)},
														 {GetNullDbDateString(input.selectEndDate)},
														 {getNullDb(input.selectDaySearch)},
														 {getNullDb(input.selectMonth)},
														 {getNullDb(input.selectYear)},
														  '{serviceGroup}')
														; ";
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_export_summary_carrier>(sql, commandTimeout: 3000);

				return data.ToList();
			}
		}

		#endregion

		#region ILB006
		public List<RPTILB006ViewModel> RPTILB006_Report(ILBRequestModel request)
		{
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB006ViewModel>($@"select *
																	 from ilb.get_report_ilb006({GetNullDbDateString(request.selectStartDate)},
																								{GetNullDbDateString(request.selectStartDate)})
																	 ; ", commandTimeout: 3000);
				return data.ToList();
			}
		}

		public List<RPTILB_Haulage_Chart> ILB006_Summary_Chart(ILBRequestModel input)
		{
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				//dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Haulage_Chart>($@"select *
																	   from ilb.get_ilb06_weekly_status('{input.selectStartDate}', '{input.selectEndDate}')
																	   ; ", commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB_Summary_Haulage> ILB006_Summary_Status(ILBRequestModel input)
		{
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Summary_Haulage>($@"select *
																		 from ilb.get_ilb06_summary_status({GetNullDbDateString(input.selectStartDate)},
																										   {GetNullDbDateString(input.selectEndDate)},
																										   {getNullDb(input.selectDaySearch)},
																										   {getNullDb(input.selectMonth)},
																										   {getNullDb(input.selectYear)})
																		 ; ", commandTimeout: 3000);

				return data.ToList();
			}
		}

		#endregion

		#region ILB007
		public List<RPTILB007ViewModel> RPTILB007_Report(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			//DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			DateTime selectStartDate = DateTime.ParseExact(input.selectStartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB007ViewModel>($@"select service_group
																	, bu
																	, importer
																	, po_no
																	, ship_no
																	, document_status
																	, plan_etd_date
																	, request_delivery_date
																	, est_readiness_date
																	, request_etd_date
																	, ""mode""
																	, incoterms
																	, supplier
																	, received_complete_date
																	, invoice_no
																	, invoice_amount
																	, invoice_currency
																	, awb_no
																	, carrier
																	, forwarder
																	, pol
																	, pod
																	, first_cargo_description
																	, net_weight
																	, gross_weight
																	, actual_etd_date
																	, eta_date
																	, ata_port_date
																	, ata_complete_container_date
																	, vessel_name
																	, privilege_type
																	, license
																	, or_no
																	, po_service_no
																	, customs_broker
																	, import_tax_withdraw_date
																	, import_entry_no
																	, tax_debit_date
																	, customs_released_date
																	, customs_released_place
																	, empty_return_place
																	, delivery_place
																	, require_payment
																	, rent_day
																	, rent_charge
																	, dem_day
																	, dem_charge
																	, det_day
																	, det_charge
																	, rent_date
																	, dem_date
																	, det_date
																	, shipment_remark
																	, active
																	, created_by
																	, created_date
																	, updated_by
																	, updated_date
																	, locked_by
																	, locked_date
																	, manual_shipment
																	, customer_status
																	, shipment_id
																	, value_date
																   FROM ilb.get_report_ilb007(@selectStartDate,@ServiceGroup,@flagDate,@selectCriteria);"
																	, param: new
																	{
																		selectStartDate,
																		serviceGroup = input.selectServiceGroup ?? new string[] { },
																		input.flagDate,
																		input.selectCriteria
																	}, commandTimeout: 3000);
				return data.ToList();
			}
		}
		public List<RPTILB07_Summary_Shpmnt_Status> ILB007_Summary_Status(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB07_Summary_Shpmnt_Status>($@"SELECT *
																				from ilb.get_ilb07_summary_status(@selectStartDate,@ServiceGroup); "
																				 , param: new
																				 {
																					 selectStartDate,
																					 serviceGroup = input.selectServiceGroup ?? new string[] { }
																				 }, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB07_Summary_Shpmnt_Chart> ILB007_Summary_Chart(ILBRequestModel input)
		{
			//int[] ServiceGroup = input.selectServiceGroup?.ToArray() ?? new int[] { };
			DateTime selectStartDate = DateTime.Parse(input.selectStartDate);
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB07_Summary_Shpmnt_Chart>($@"SELECT *
																	from ilb.get_ilb07_monthly_status(@selectStartDate,@ServiceGroup); "
																	 , param: new
																	 {
																		 selectStartDate,
																		 serviceGroup = input.selectServiceGroup ?? new string[] { }
																	 }, commandTimeout: 3000);


				return data.ToList();
			}
		}
		#endregion

		#region ILB008
		public DataTable RPTILB008_Report(ILBRequestModel request, string dateType) {
			var list = RPTILB_GetContainerType();
			var col = list.Select(o => "\"container_" + o.container_code + "\"").ToArray(); // ["container_01", "container_02", ...]
			var colParam = "{" + list.Select(o => "\"" + o.container_code + "\"").ToArray().Join() + "}"; // '{"01", "02", ...}
			var serviceGroup = "{" + (request.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";

			var sql = $@"SELECT *
						 from ilb.get_report_ilb008('{colParam}'
												, '{dateType}'
												, {GetNullDbDateString(request.selectStartDate)}
												, {GetNullDbDateString(request.selectEndDate)}
												, '{serviceGroup}'
												, {getNullDb(request.selectCriteria)}
												) as t  
						 (""no"" bigint,
						   status character varying,
						   booking_id character varying,
						   booker character varying,
						   shiper character varying,
						   cust_ref_1 character varying,
						   cust_ref_2 character varying,
						   carrier_bkg_no character varying,
						   ""mode"" character varying,
						   incoterm character varying,
						   carrier character varying,
						   carrier_request_date text,
						   carrier_response_date text,
						   pol character varying,
						   country_pol character varying,
						   pod character varying,
						   country_pod character varying,
						   etd_first text,
						   etd text,
						   delay int,
						   eta text,
						   {string.Join("  bigint, ", col)} bigint,
						   cy_place character varying,
						   cy_date text,
						   return_place character varying,
						   return_date text,
						   scgl_confirm_load_date text,
						   closing_date_time text,
						   vessel_name_first character varying,
						   vessel_name character varying,
						   scgl_ref_no character varying,
						   cargo_desc character varying,
						   move_perspective character varying,
						   group_rate character varying,
						   rate_type character varying)
						 ;";
			using (IDbConnection dbConnection = Connection) {
				dbConnection.Open();
				NpgsqlCommand com = new NpgsqlCommand(sql, (NpgsqlConnection)(Connection));
				com.CommandTimeout = 3000;
				NpgsqlDataAdapter ad = new NpgsqlDataAdapter(com);
				//var data = dbConnection.Query<R PTILB005ViewModel>(sql, commandTimeout: 3000);
				DataTable dt = new DataTable();
				ad.Fill(dt);
				return dt;
			}
		}

		public List<RPTILB_export_monthy_carrier> ILB008_CYDate_Chart(ILBRequestModel input) {
			var serviceGroup = "{" + (input.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";
			using (IDbConnection dbConnection = Connection) {
				dbConnection.Open();
				var sql = $@"SELECT *
							from ilb.get_ilb08_chart_cydate({GetNullDbDateString(input.selectStartDate)},
															{GetNullDbDateString(input.selectEndDate)},
															{getNullDb(input.selectDaySearch)},
															{getNullDb(input.selectMonth)},
															{getNullDb(input.selectYear)},
															'{serviceGroup}')
						; ";

				var data = dbConnection.Query<RPTILB_export_monthy_carrier>(sql, commandTimeout: 3000);

				return data.ToList();
			}
		}
		public List<RPTILB_export_monthy_carrier> ILB008_ReturnDate_Chart(ILBRequestModel input) {
			var serviceGroup = "{" + (input.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";
			using (IDbConnection dbConnection = Connection) {
				dbConnection.Open();
				var sql = $@"SELECT *
							from ilb.get_ilb08_chart_returndate({GetNullDbDateString(input.selectStartDate)},
															{GetNullDbDateString(input.selectEndDate)},
															{getNullDb(input.selectDaySearch)},
															{getNullDb(input.selectMonth)},
															{getNullDb(input.selectYear)},
															'{serviceGroup}')
						; ";

				var data = dbConnection.Query<RPTILB_export_monthy_carrier>(sql, commandTimeout: 3000);

				return data.ToList();
			}
		}

		public List<RPTILB_export_summary_carrier> ILB008_Summary_Status(ILBRequestModel input) {
			var serviceGroup = "{" + (input.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";
			var sql = $@"SELECT *
					   from ilb.get_ilb05_summary_status({GetNullDbDateString(input.selectStartDate)},
														 {GetNullDbDateString(input.selectEndDate)},
														 {getNullDb(input.selectDaySearch)},
														 {getNullDb(input.selectMonth)},
														 {getNullDb(input.selectYear)},
														  '{serviceGroup}')
														; ";
			using (IDbConnection dbConnection = Connection) {
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_export_summary_carrier>(sql, commandTimeout: 3000);

				return data.ToList();
			}
		}

		#endregion


		public DataTable RPTILB009_Report(ILBRequestModel request, string dateType) {
			var list = RPTILB_GetContainerType();
			var col = list.Select(o => "\"container_" + o.container_code + "\"").ToArray(); // ["container_01", "container_02", ...]
			var colParam = "{" + list.Select(o => "\"" + o.container_code + "\"").ToArray().Join() + "}"; // '{"01", "02", ...}
			var serviceGroup = "{" + (request.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";

			var sql = $@"SELECT *
						 from ilb.get_report_ilb009('{colParam}'
												, '{dateType}'
												, {GetNullDbDateString(request.selectStartDate)}
												, {GetNullDbDateString(request.selectEndDate)}
												, '{serviceGroup}'
												, {getNullDb(request.selectCriteria)}
												) as t  
						 (""no"" bigint,
						   aging varchar,
						   assign_job varchar,
						   status varchar,
						   jobid varchar,
						   cust_ref_1 varchar,
						   cust_ref_2 varchar,
						   shipper varchar,
						   carrier_booking_number varchar,
						   carrier_name varchar,
						   pol varchar,
						   pod varchar,
						   mode varchar,	
						   {string.Join("  bigint, ", col)} bigint,
						   etl text,
						   etd text,
						   eta text,
						   cargo_desc varchar,
						   consignee varchar,
						   booking_confirmed_date text,
						   booking_request_date text,
						   carrier_response_date text)
						 ;";
			using (IDbConnection dbConnection = Connection) {
				dbConnection.Open();
				NpgsqlCommand com = new NpgsqlCommand(sql, (NpgsqlConnection)(Connection));
				com.CommandTimeout = 3000;
				NpgsqlDataAdapter ad = new NpgsqlDataAdapter(com);
				//var data = dbConnection.Query<R PTILB005ViewModel>(sql, commandTimeout: 3000);
				DataTable dt = new DataTable();
				ad.Fill(dt);
				return dt;
			}
		}


		public List<RPTILB_Export_Summary_Order_Status> ILB010_Summary_Status(ILBRequestModel input)
		{
			var serviceGroup = "{" + (input.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";
			var sql = $@"SELECT *
					   from ilb.get_ilb10_summary_status({GetNullDbDateString(input.selectStartDate)},
														 {GetNullDbDateString(input.selectEndDate)},
														  '{serviceGroup}')
														; ";
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				var data = dbConnection.Query<RPTILB_Export_Summary_Order_Status>(sql, commandTimeout: 3000);

				return data.ToList();
			}
		}

		public DataTable RPTILB010_Report(ILBRequestModel request, string dateType)
		{
			var list = RPTILB_GetContainerType();
			var col = list.Select(o => "\"container_" + o.container_code + "\"").ToArray(); // ["container_01", "container_02", ...]
			var colParam = "{" + list.Select(o => "\"" + o.container_code + "\"").ToArray().Join() + "}"; // '{"01", "02", ...}
			var serviceGroup = "{" + (request.selectServiceGroup ?? new string[] { }).Select(o => "\"" + o + "\"").ToArray().Join() + "}";

			var sql = $@"SELECT *
						 from ilb.get_report_ilb009('{colParam}'
												, '{dateType}'
												, {GetNullDbDateString(request.selectStartDate)}
												, {GetNullDbDateString(request.selectEndDate)}
												, '{serviceGroup}'
												, {getNullDb(request.selectCriteria)}
												) as t  
						 (""no"" bigint,
						   aging varchar,
						   assign_job varchar,
						   status varchar,
						   jobid varchar,
						   cust_ref_1 varchar,
						   cust_ref_2 varchar,
						   shipper varchar,
						   carrier_booking_number varchar,
						   carrier_name varchar,
						   pol varchar,
						   pod varchar,
						   mode varchar,	
						   {string.Join("  bigint, ", col)} bigint,
						   etl text,
						   etd text,
						   eta text,
						   cargo_desc varchar,
						   consignee varchar,
						   booking_confirmed_date text,
						   booking_request_date text,
						   carrier_response_date text)
						 ;";
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				NpgsqlCommand com = new NpgsqlCommand(sql, (NpgsqlConnection)(Connection));
				com.CommandTimeout = 3000;
				NpgsqlDataAdapter ad = new NpgsqlDataAdapter(com);
				//var data = dbConnection.Query<R PTILB005ViewModel>(sql, commandTimeout: 3000);
				DataTable dt = new DataTable();
				ad.Fill(dt);
				return dt;
			}
		}

		#region GetCriteria
		public async Task<(bool, List<MiscDataSelectionModel>)> RPTILB_GetService()
		{
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try
			{
				using (IDbConnection dbConnection = Connection)
				{
					dbConnection.Open();
					var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select 
							service_group_id as DataValue_Key
							,service_group_name as DataDisplay 
							from ilb.get_common_service_group()");
					data = datatmp.ToList();
					isSuccess = true;
				}
			}
			catch (Exception ex)
			{
				// NLog: catch any exception and log it.
				if (ex.InnerException != null)
				{
					logger.Error(ex.InnerException, $"Exception on Get Service Group");
				}
				else
				{
					logger.Error(ex, $"Exception on Get Service Group");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}

		public async Task<(bool, List<MiscDataSelectionModel>)> RPTILB_GetWarehouseType()
		{
			var isSuccess = false;
			var data = new List<MiscDataSelectionModel>();
			try
			{
				using (IDbConnection dbConnection = Connection)
				{
					dbConnection.Open();
					var datatmp = dbConnection.Query<MiscDataSelectionModel>($@"select 
							dc_type as DataValue_Key
							,dc_type as DataDisplay 
							from wh.get_common_dc_type()");
					data = datatmp.ToList();
					isSuccess = true;
				}
			}
			catch (Exception ex)
			{
				// NLog: catch any exception and log it.
				if (ex.InnerException != null)
				{
					logger.Error(ex.InnerException, $"Exception on Get Service Group");
				}
				else
				{
					logger.Error(ex, $"Exception on Get Service Group");
				}
			}

			var result = (isSuccess, data);
			return await Task.FromResult(result);
		}
		#endregion
	}
}
