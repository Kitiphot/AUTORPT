using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using OfficeOpenXml;
using SCG.ARS.BOI.WEB.Attributes;
using SCG.ARS.BOI.WEB.Entities.MasterDb;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.ViewModels;

namespace SCG.ARS.BOI.WEB.Controllers
{
    [Authorize]
    public class MasterController : Controller
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        //private ILogger<MasterController> _logger;
        private readonly HttpContext _context;
        private IMasterRepository _data;
        private readonly IHostingEnvironment _hostingEnvironment;
        public MasterController(IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IMasterRepository data)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _data = data;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Schemas()
        {
            return View();
        }

        [WebAuthorize(ScreenID.WEB_STOCK_MASTER, Permission.View)]
        public IActionResult StockMaster()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoadSourceSchema()
        {
            try
            {
                var data = _data.GetSourceSchema();
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult LoadSchemas()
        {
            try
            {
                var data = _data.GetSchemas();

                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }
        public ActionResult LoadCustomer(string p_warehouse)
        {
            try
            {
                var data = _data.GetCustomers(p_warehouse);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }
        public ActionResult LoadStorageType(string p_warehouse)
        {
            try
            {
                var data = _data.GetStorageType(p_warehouse);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }
        public ActionResult LoadDCType()
        {
            try
            {
                var data = _data.GetDCType();
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }
        public ActionResult LoadStockMaster()
        {
            try
            {
                var data = _data.GetStockMaster();
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        public ActionResult LoadStock()
        {
            try
            {
                var data = _data.GetStock();
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }
        [HttpPost]
        public async Task<IActionResult> SaveStock(StockMaster request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.SaveStock(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        [HttpPost]
        public async Task<IActionResult> SaveSchema(Schema request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            request.update_by = this.User.Identities.ToList()[0].Name;
            try
            {
                (status, data, message) = await _data.SaveSchema(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }
        [HttpPost]
        public async Task<IActionResult> DeleteSchema(Schema request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.DeleteSchema(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });
        }

        public IActionResult Tables()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoadTables(string schema)
        {
            try
            {
                var data = _data.GetTables(schema);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        public IActionResult Columns()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoadColumns(string schema, string table)
        {
            try
            {
                var data = _data.GetColumns(schema, table);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        public IActionResult Functions()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoadSourceFunctions(string schema_name)
        {
            try
            {
                var data = _data.GetSourceFunctions(schema_name);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult LoadFunctions(int? schema_id, int? report_id, int? function_id)
        {
            try
            {
                var data = _data.GetFunctions(schema_id, report_id, function_id);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveFunction(MasterFunction request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.SaveFunction(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        [HttpPost]
        public async Task<IActionResult> DeleteFunction(MasterFunction request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.DeleteFunction(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        public IActionResult Parameters()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoadParameters(string schema, string function_name)
        {
            try
            {
                var data = _data.GetFunctionParameters(schema, function_name);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult LoadTemplateReportMapping(string schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null)
        {
            try
            {
                var data = _data.GetTemplateReportMapping(schema_name, p_template_report_mapping_id, p_function_id, p_report_id);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveTemplateReportMapping(TemplateReportMapping request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.SaveTemplateReportMapping(request);

                return Json(new { data = data, status = status, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        /// <summary>
        /// Generwiz - Pittaya J. 2021-02-19
        /// </summary>
        /// <returns></returns>
        public ActionResult LoadReportGroups()
        {
            try
            {
                var data = _data.GetReportGroups();
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        //new function 23/2/2021
        [HttpPost]
        public ActionResult LoadReportGroupsNew(int? p_schema_id = null, int? p_group_id = null)
        {
            try
            {
                var data = _data.GetReportGroups(p_schema_id, p_group_id);
                foreach (var item in data)
                {
                    item.updated_date_string = item.updated_date.ToString("dd/MM/yyyy HH:mm:ss");
                    item.created_date_string = item.created_date.ToString("dd/MM/yyyy HH:mm:ss");
                }
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        //new function 8/3/2021
        [HttpPost]
        public ActionResult LoadGetGroupReports(int? schema_id = null, int? group_id = null)
        {
            try
            {
                var data = _data.GetGroupReports(schema_id, group_id);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveGroup(ReportGroup request)
        {
            request.created_by = this.User.Identities.ToList()[0].Name;
            request.updated_by = this.User.Identities.ToList()[0].Name;
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                //status = true;
                (status, data, message) = await _data.SaveGroup(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        [HttpPost]
        public async Task<IActionResult> DeleteGroup(ReportGroup request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                //status = true;
                (status, data, message) = await _data.DeleteGroup(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        [HttpPost]
        public async Task<IActionResult> SaveReport(ReportGroup request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            request.created_by = this.User.Identities.ToList()[0].Name;
            request.updated_by = this.User.Identities.ToList()[0].Name;
            try
            {
                //status = true;
                (status, data, message) = await _data.SaveReport(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        [HttpPost]
        public async Task<IActionResult> UpdateReportActive(ReportGroup request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            request.updated_by = this.User.Identities.ToList()[0].Name;
            try
            {
                //status = true;
                (status, data, message) = await _data.UpdateReportActive(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        [HttpPost]
        public async Task<IActionResult> DeleteReportGroup(ReportGroup request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                //status = true;
                (status, data, message) = await _data.DeleteReportGroup(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        [HttpPost]
        public ActionResult LoadReports(int? schema_id, int? report_id, int? group_id)
        {
            List<Report> data = new List<Report>();
            try
            {
                //if (group_id == null)
                //{
                //    data = _data.GetReports();
                //}
                //else
                //{
                //    data = _data.GetReports(schema_id, report_id, group_id);
                //}

                data = _data.GetReports(schema_id, report_id, group_id);

                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddReports(List<Report> request)
        {
            var status = false;
            var data = new List<Report>();
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.AddReports(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });

        }

        [HttpPost]
        public async Task<IActionResult> DeleteReports(Report request)
        {
            var status = false;
            var data = new List<Report>();
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.DeleteReports(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });
        }

        [HttpPost]
        public ActionResult LoadParameterTypes()
        {
            try
            {
                var data = _data.GetParameterTypes();
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult saveUpload(List<StockMasterShow> list)
        {
            try
            {
                List<StockMaster> dataStock = new List<StockMaster>();

                foreach (StockMasterShow source in list)
                {
                    var record = new StockMaster
                    {
                        dc_type = source.dc_type,
                        customer_id = Convert.ToInt32(source.customer_id),
                        customer_name = source.customer_name,
                        customer_code = source.customer_code,
                        storage_type_id = Convert.ToInt32(source.storage_type_id),
                        storage_type_name = source.storage_type_name,
                        location_area_m3 = Convert.ToDecimal(source.location_area),
                        location_charge = Convert.ToDecimal(source.location_charge),
                        location_plan = Convert.ToInt32(source.location_plan),
                        effective_date = Convert.ToDateTime(source.effective_date)
                    };
                    dataStock.Add(record);
                }

                var data = _data.saveUpload(dataStock);
                return Json(new { status = true, message = "Upload datas Successful!" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult DeleteStock(int? id)
        {
            try
            {
                var data = _data.DeleteStock(id);
                return Json(new { status = true, message = "Success" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult LoadTemplateParameterMapping(string schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null, int? p_parameter_id = null)
        {
            try
            {
                var data = _data.GetTemplateParameterMapping(schema_name, p_template_report_mapping_id, p_function_id, p_report_id, p_parameter_id);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveTemplateParameterMapping([FromBody] TemplateReportMapping header, [FromBody] List<TemplateParameterMapping> list)
        {
            var status = false;
            var data = list;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.SaveTemplateParameterMapping(header, list);

                return Json(new { data = data, status = status, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTemplateParameterMapping(TemplateParameterMapping request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.RemoveTemplateParameterMapping(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });
        }

        [HttpPost]
        public ActionResult LoadTemplateColumnMapping(string schema_name = null, int? p_template_report_mapping_id = null, int? p_function_id = null, int? p_report_id = null, int? p_column_id = null)
        {
            try
            {
                var data = _data.GetTemplateColumnMapping(schema_name, p_template_report_mapping_id, p_function_id, p_report_id, p_column_id);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveTemplateColumnMapping([FromBody] List<TemplateColumnMapping> request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _data.SaveTemplateColumnMapping(request);

                return Json(new { data = data, status = status, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            string warehouseType = Request.Form.Where(x => x.Key == "warehouseType").FirstOrDefault().Value;

            if (file == null || file.Length == 0)
                return Json(new { success = false, message = "error" });

            var path = Path.GetTempFileName();
            using ExcelPackage pack = new ExcelPackage(file.OpenReadStream());
            var wb = pack.Workbook;
            var ws = wb.Worksheets[0];
            var allData = ws.Cells[$"{OfficeOpenXml.ExcelAddress.GetAddress(ws.Dimension.Start.Column, ws.Dimension.Start.Row)}:{OfficeOpenXml.ExcelAddress.GetAddress(ws.Dimension.End.Column, ws.Dimension.End.Row)}"];
            bool flag_err = false;
            string customerID = null;
            string customerName = null;
            string customerCode = null;
            string storageTypeID = null;
            string storageTypeName = null;
            double locationAreaM3;
            double locationCharge;
            int locationPlan;
            DateTime EffectiveDate;
            List<Customer> customerMaster = _data.GetCustomers(warehouseType);
            List<StorageType> storageTypeMaster = _data.GetStorageType(warehouseType);
            List<StockMasterShow> dataStock = new List<StockMasterShow>();
            string err_msg = null;

            for (int row = ws.Dimension.Start.Row + 2; row <= ws.Dimension.End.Row; row++)
            {
                if (ws.Cells[$"A{row}"].Text.Equals("") || ws.Cells[$"B{row}"].Text.Equals("") || ws.Cells[$"F{row}"].Text.Equals(""))
                {
                    continue;
                }
                else
                {
                    err_msg = null;
                    var customerCondition = customerMaster.Where(o => o.customer_name.Contains(ws.Cells[$"A{row}"].Text));
                    var storageTypeCondition = storageTypeMaster.Where(o => o.storage_type_name.Contains(ws.Cells[$"B{row}"].Text));
                    var locationAreaCondition = Double.TryParse(ws.Cells[$"C{row}"].Text, out locationAreaM3);
                    var locationChargeCondition = Double.TryParse(ws.Cells[$"D{row}"].Text, out locationCharge);
                    var locationPlanCondition = Int32.TryParse(ws.Cells[$"E{row}"].Text, out locationPlan);
                    var EffectiveDateCondition = DateTime.TryParse(ws.Cells[$"F{row}"].Text, out EffectiveDate);

                    if (!customerCondition.Any())
                    {
                        flag_err = true;
                        err_msg = "Error Customer can't find in database,";
                        customerName = ws.Cells[$"A{row}"].Text;
                    }
                    else
                    {
                        customerID = customerCondition.First().customer_id.ToString();
                        customerName = customerCondition.First().customer_name.ToString();
                        customerCode = customerCondition.First().customer_code.ToString();
                    }
                    if (!storageTypeCondition.Any())
                    {
                        flag_err = true;
                        err_msg += "Error Storage Type can't find in database,";
                        storageTypeName = ws.Cells[$"A{row}"].Text;
                    }
                    else
                    {
                        storageTypeID = storageTypeCondition.First().storage_type_id.ToString();
                        storageTypeName = storageTypeCondition.First().storage_type_name;
                    }
                    if (!locationAreaCondition)
                    {
                        flag_err = true;
                        err_msg += "Error Cannot Convert Location Area to Double,";
                    }
                    if (!locationChargeCondition)
                    {
                        flag_err = true;
                        err_msg += "Error Cannot Convert Location Charge to Double,";
                    }
                    if (!locationPlanCondition)
                    {
                        flag_err = true;
                        err_msg += "Error Cannot Convert Location Plan to Integer,";
                    }
                    if (!EffectiveDateCondition)
                    {
                        flag_err = true;
                        err_msg += "Error Cannot Convert Effective Date to Datetime,";
                    }
                    var record = new StockMasterShow
                    {
                        dc_type = warehouseType,
                        customer_id = customerID,
                        customer_name = customerName,
                        customer_code = customerCode,
                        storage_type_id = storageTypeID,
                        storage_type_name = storageTypeName,//storageTypeMaster.Where(o => o.storage_type_name.Contains(ws.Cells[$"B{row}"].Text)).Select(o => o.storage_type_name).FirstOrDefault(),
                        location_area = ws.Cells[$"C{row}"].Text,
                        location_charge = ws.Cells[$"D{row}"].Text,
                        location_plan = ws.Cells[$"E{row}"].Text,
                        effective_date = ws.Cells[$"F{row}"].Text,
                        err_msg = err_msg
                    };
                    dataStock.Add(record);
                }
            }

            return Json(new { data = dataStock, status = true, flag_err = flag_err });
        }
    }
}