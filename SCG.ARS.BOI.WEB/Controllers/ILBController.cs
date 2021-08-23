using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB.Attributes;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.ILB;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Security;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class ILBController : Controller
    {
        private readonly HttpContext _context;
        private IReportRepository _report;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ISecurityService ss;
        public ILBController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IReportRepository report,
            ISecurityService ss)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _report = report;
            this.ss = ss;
        }

        // GET: ILBController
        #region AcrionResult
        public IActionResult Index()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_ILB_001, Permission.View)]
        public IActionResult WEB_ILB_001()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_ILB_002, Permission.View)]
        public IActionResult WEB_ILB_002()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_ILB_003, Permission.View)]
        public IActionResult WEB_ILB_003()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_ILB_004, Permission.View)]
        public IActionResult WEB_ILB_004()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_ILB_005, Permission.View)]
        public IActionResult WEB_ILB_005()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_ILB_006, Permission.View)]
        public IActionResult WEB_ILB_006()
        {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_ILB_007, Permission.View)]
        public IActionResult WEB_ILB_007()
        {
            return View();
        }
		[WebAuthorize(ScreenID.WEB_ILB_008, Permission.View)]
		public IActionResult WEB_ILB_008() {
			return View();
		}
		[WebAuthorize(ScreenID.WEB_ILB_009, Permission.View)]
		public IActionResult WEB_ILB_009() {
			return View();
		}
		[WebAuthorize(ScreenID.WEB_ILB_010, Permission.View)]
		public IActionResult WEB_ILB_010() {
			return View();
		}
		#endregion

		#region ColumnTable
		[HttpPost]
        public JsonResult getViewTableColumnILB006()
        {
            List<ViewColumn> columnView = new List<ViewColumn>();
            columnView.Add(new ViewColumn() { data = "hl_plan_id", name = "hl_plan_id", title = "HL Plan Id", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "status", name = "status", title = "Status", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "tendercompleted", name = "tendercompleted", title = "TenderCompleted", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "order_type", name = "order_type", title = "Order Type", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "customer_ref", name = "customer_ref", title = "Customer Ref.*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "customer", name = "customer", title = "Customer*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "exporter", name = "exporter", title = "Exporter", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "customer_address", name = "customer_address", title = "Customer Address", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "carrier_booking_no", name = "carrier_booking_no", title = "Carrier Booking No.*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "customs_vendor", name = "customs_vendor", title = "Customs Vendor", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "contact", name = "contact", title = "Contact", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "freight_agent", name = "freight_agent", title = "Freight Agent*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "forwarder", name = "forwarder", title = "Forwarder", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "fumigate", name = "fumigate", title = "Fumigate", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "survey", name = "survey", title = "Survey", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "invoice_no", name = "invoice_no", title = "Invoice No.", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "cargo", name = "cargo", title = "Cargo*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "package", name = " package", title = "Package", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "cargo_weight", name = "cargo_weight", title = "Cargo Weight(Ton)", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "note", name = "note", title = "Note", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "port_country", name = "port_country", title = "Port/Country*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "frd", name = " frd", title = "FRD*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "feeder_vessel", name = "feeder_vessel", title = "Feeder Vessel*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "ocean_vessel", name = "ocean_vessel", title = "Ocean Vessel", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "si_cutoff", name = " si_cutoff", title = "SI Cutoff", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "vgm_cutoff", name = "vgm_cutoff", title = "VGM Cutoff", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "etd", name = " etd", title = "ETD", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "eta", name = " eta", title = "ETA", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "code_paperless", name = "code_paperless", title = "Code Paperless", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "total_container", name = " total_container", title = "Total Container*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "closing_datetime", name = "closing_datetime", title = "Closing Datetime*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "cy_place", name = "cy_place", title = "CY Place*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "cy_date", name = "cy_date", title = "CY Date*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "container_qty", name = "container_qty", title = "Qty*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "container_type", name = "container_type", title = "Container Type*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "return_place", name = "return_place", title = "Return Place*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "return_date", name = "return_date", title = "Return Date*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "factory", name = " factory", title = "Factory*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "contact", name = " contact", title = "Contact*", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "hl_carrier", name = "hl_carrier", title = "HL Carrier", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "shore", name = "shore", title = "Shore", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "qty", name = "qty", title = "Qty", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "truck_type", name = "truck_type", title = "Truck Type", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "truck_load_empty_container", name = "truck_load_empty_container", title = "Truck Load (Empty Container)", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "truck_load_full_container", name = "truck_load_full_container", title = "Truck Load (Full Container)", autoWidth = true, className = "text-nowrap" });            
            var jsonResult = Json(columnView);
            return jsonResult;
        }

        [HttpPost]
        public JsonResult getViewTableContainerTypeColumn()
        {
            List<ViewColumn> columnView = new List<ViewColumn>();

			List<ILBContainerTypeViewModel> columns = _report.RPTILB_GetContainerType();
            foreach (var col in columns)
            {
                columnView.Add(new ViewColumn()
                {
                    data = "container_" + col.container_code.ToLower(),
                    name = col.container_code.ToLower(),
                    title = col.container_name,
                    autoWidth = true,
                    className = "text-nowrap"

                });
            }

            var jsonResult = Json(columnView);
            return jsonResult;
        }


        [HttpPost]
        public JsonResult getViewTableColumnILB007()
        {
            List<ViewColumn> columnView = new List<ViewColumn>();
            columnView.Add(new ViewColumn() { data = "service_group", name = "service_group", title = "Service Group", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "bu", name = "bu", title = "BU", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "importer", name = "importer", title = "Importer", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "po_no", name = "po_no", title = "PO No.", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "ship_no", name = "ship_no", title = "Ship Noti No.", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "document_status", name = "document_status", title = "Document Status", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "plan_etd_date", name = "plan_etd_date", title = "Plan ETD Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "request_delivery_date", name = "request_delivery_date", title = "Request Delivery Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "est_readiness_date", name = "est_readiness_date", title = "EST Cargo Readiness Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "request_etd_date", name = "request_etd_date", title = "Request ETD Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "mode", name = "mode", title = "Mode", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "incoterms", name = "incoterms", title = "Incoterms", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "supplier", name = "supplier", title = "Supplier", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "received_complete_date", name = "received_complete_date", title = "Received Complete Shipment Document Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "invoice_no", name = "invoice_no", title = "Invoice No", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "invoice_amount", name = "invoice_amount", title = "Invoice Amount", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "invoice_currency", name = "invoice_currency", title = "Invoice Currency", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "awb_no", name = "awb_no", title = "AWB/BL No", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "carrier", name = "carrier", title = "Carrier", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "forwarder", name = "forwarder", title = "Forwarder", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "pol", name = "pol", title = "POL", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "pod", name = "pod", title = "POD", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "first_cargo_description", name = "first_cargo_description", title = "First Cargo Description", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "net_weight", name = "net_weight", title = "Container Type / NET Weight", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "gross_weight", name = "gross_weight", title = "Container QTY / Gross Wegith", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "actual_etd_date", name = "actual_etd_date", title = "Actual ETD Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "eta_date", name = "eta_date", title = "ETA Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "ata_port_date", name = "ata_port_date", title = "ATA Port Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "ata_complete_container_date", name = "ata_complete_container_date", title = "ATA Complete Container Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "vessel_name", name = "vessel_name", title = "Vessel Name/Flight No.", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "privilege_type", name = "privilege_type", title = "Privilege Type", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "license", name = "license", title = "License/Permission", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "or_no", name = "or_no", title = "OR", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "po_service_no", name = "po_service_no", title = "PO Service no.", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "customs_broker", name = "customs_broker", title = "Customs Broker", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "import_tax_withdraw_date", name = "import_tax_withdraw_date", title = "Import Tax Withdraw Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "import_entry_no", name = "import_entry_no", title = "Import Entry No", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "tax_debit_date", name = "tax_debit_date", title = "Tax Debit Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "customs_released_date", name = "customs_released_date", title = "Customs Released Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "customs_released_place", name = "customs_released_place", title = "Customs Released Place", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "empty_return_place", name = "empty_return_place", title = "Empty Return Place", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "delivery_place", name = "delivery_place", title = "Delivery Place", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "require_payment", name = "require_payment", title = "Require Payment", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "rent_day", name = "rent_day", title = "Rent Day", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "rent_charge", name = "rent_charge", title = "Rent Charge", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "dem_day", name = "dem_day", title = "DEM Day", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "dem_charge", name = "dem_charge", title = "DEM Charge", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "det_day", name = "det_day", title = "DET Day", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "det_charge", name = "det_charge", title = "DET Charge", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "rent_date", name = "rent_date", title = "Rent Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "dem_date", name = "dem_date", title = "DEM Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "det_date", name = "det_date", title = "DET Date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "shipment_remark", name = "shipment_remark", title = "Shipment Remark", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "active", name = "active", title = "Active", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "created_by", name = "created_by", title = "Created by", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "created_date", name = "created_date", title = "Created date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "updated_by", name = "updated_by", title = "Updated by", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "updated_date", name = "updated_date", title = "Updated date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "locked_by", name = "locked_by", title = "Locked by", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "locked_date", name = "locked_date", title = "Locked date", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "manual_shipment", name = "manual_shipment", title = "Manual Shipment", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "customer_status", name = "customer_status", title = "Customer Status", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "shipment_id", name = "shipment_id", title = "Shipment ID", autoWidth = true, className = "text-nowrap" });
            columnView.Add(new ViewColumn() { data = "value_date", name = "value_date", title = "Value Date", autoWidth = true, className = "text-nowrap" });

            var jsonResult = Json(columnView);
            return jsonResult;
        }

		#endregion

		#region Getcriteria

		[HttpPost]
        public async Task<ActionResult> GetServiceGroup(string selectwarehouse, List<int> selectDc)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTILB_GetService();

                if (allowData.Count > 0)
                {
                    data = data.Where(c => allowData.Any(f => c.DataValue_Key == f.DataValue_Key)).ToList();
                }
                return Json(new { status = isSuccess, data = data, message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }
        
        [HttpPost]
        public async Task<ActionResult> GetWarehouseType(string selectwarehouse, List<int> selectDc)
        {
            var allowData = await ss.GetAllowData(_context, this.ControllerContext.RouteData);
            var isSuccess = false;
            var message = string.Empty;
            var data = new List<MiscDataSelectionModel>();
            try
            {
                (isSuccess, data) = await _report.RPTILB_GetWarehouseType();

                if (allowData.Count > 0)
                {
                    data = data.Where(c => allowData.Any(f => c.DataValue_Key == f.DataValue_Key)).ToList();
                }
                return Json(new { status = isSuccess, data = data, message = message });
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(null);
            }
        }



        #endregion
    }
}
