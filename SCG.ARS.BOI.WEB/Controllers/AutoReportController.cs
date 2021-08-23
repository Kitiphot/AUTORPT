using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Models.Master;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Services;

namespace SCG.ARS.BOI.WEB.Controllers
{
    [Authorize]
    public class AutoReportController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        static Logger logger = LogManager.GetCurrentClassLogger();
        //MyDbContext db = new MyDbContext ();
        //private readonly List<LinkRolesMenus> _permissions;

        ClaimsPrincipal _user;
        private string _userCode;

        private Task _startingTask;

        private ILogger<HomeController> _logger;

        private IMasterRepository _master;
        private string _tempPath;
        public AutoReportController(
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            ILogger<HomeController> logger,
            IMasterRepository master)
        {
            _logger = logger;
            var httpContext = httpContextAccessor.HttpContext;
            _hostingEnvironment = hostingEnvironment;
            _user = httpContext.User;
            //_userCode = _user.FindFirst(ClaimTypes.Sid).Value;
            //_permissions = _userService.GetPermissions(_user, "TPM001");
            _tempPath = Path.GetTempPath();

            _master = master;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoadSourceTree()
        {
            var status = false;
            var data = new List<TreeView>();
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.GetTreeView();

                return Json(new { data = data, status = status, message = message });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, data, message = ex.Message });
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> LoadReportsCustomization()
        //{
        //    var status = true;
        //    var data = new List<ReportsCustomizationDetailModel>();
        //    List<ReportsCustomizationItemModel> customizitemList = new List<ReportsCustomizationItemModel>();
        //    List<ReportsCustomizationModel> customizList = new List<ReportsCustomizationModel>();
        //    List<ReportsCustomizationGroupModel> customizGroupList = new List<ReportsCustomizationGroupModel>();
        //    var message = string.Empty;
        //    try
        //    {
        //        (status, data, message) = await _master.GetReportsCustomization();

        //        var cusList = from row in data
        //                       group row by new { schema_id = row.schema_id, schema_name = row.schema_name } into grp
        //                       select new ReportsCustomizationModel
        //                       {
        //                           schema_id = grp.Key.schema_id,
        //                           schema_name = grp.Key.schema_name
        //                       };
        //        customizList = cusList.ToList();

        //        var cusGruopList = from row in data
        //                      group row by new { schema_id = row.schema_id, group_id = row.group_id, group_name = row.group_name } into grp
        //                      select new ReportsCustomizationGroupModel
        //                      {
        //                          schema_id = grp.Key.schema_id,
        //                          group_id = grp.Key.group_id,
        //                          group_name = grp.Key.group_name
        //                      };
        //        customizGroupList = cusGruopList.ToList();

        //        var cusItemList = from row in data
        //                           group row by new { schema_id = row.schema_id, group_id = row.group_id, function_name = row.function_name, report_name = row.report_name } into grp
        //                           select new ReportsCustomizationItemModel
        //                           {
        //                               schema_id = grp.Key.schema_id,
        //                               group_id = grp.Key.group_id,
        //                               function_name = grp.Key.function_name,
        //                               report_name = grp.Key.report_name
        //                           };
        //        customizitemList = cusItemList.ToList();

        //        customizList.ForEach(sm =>
        //        {
        //            sm.CustomizationGroups = customizGroupList.Where(smi => smi.schema_id == sm.schema_id).ToList();
        //            sm.CustomizationGroups.ForEach(dn =>
        //            {
        //                dn.CustomizationItems = customizitemList.Where(dni => dni.schema_id == dn.schema_id && dni.group_id == dn.group_id).ToList();
        //                dn.CustomizationItems.ForEach(item =>
        //                {
        //                    item.CustomizationDetails = data.Where(its => its.schema_id == item.schema_id && its.group_id == item.group_id && its.function_name == item.function_name).ToList();

        //                });

        //            });
        //        });


        //        return Json(new { data = customizList, status = status, message = message });
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex, ex.Message);
        //        return Json(new { status = false, data, message = ex.Message });
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> SaveTemplateReportMapping(TemplateReportMapping request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.SaveTemplateReportMapping(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });
        }

        [HttpPost]
        public async Task<IActionResult> CopyTemplateReportMapping(TemplateReportMapping request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.CopyTemplateReportMapping(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });
        }

        [HttpPost]
        public async Task<IActionResult> DownloadTemplateReportMapping(TemplateReportMapping request, int? limit = null)
        {
            var status = false;
            var url = string.Empty;
            var message = string.Empty;
            try
            {
                (status, url, message) = await _master.DownloadTemplateReportMapping(request, limit);
                //url = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, path);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { url = url, status = status, message = message });
        }

        //[HttpGet]
        //public ActionResult DownloadTemplateReportMapping(TemplateReportMapping request)
        //{
        //    var status = false;
        //    var path = string.Empty;
        //    var message = string.Empty;
        //    try
        //    {
        //        Task.Factory.StartNew(async () =>
        //        {
        //            (status, path, message) = await _master.DownloadTemplateReportMapping(request);
        //        }).Wait();

        //        byte[] fileBytes = Helper.GetFile(path);
        //        return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, Path.GetFileName(path));
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex, ex.Message);
        //        return null;
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> DownloadWithTemplateReportMapping(TemplateReportMapping request)
        {
            var status = false;
            var url = string.Empty;
            FileContentResult file = null;
            var message = string.Empty;
            try
            {
                (status, url, message) = await _master.DownloadWithTemplateReportMapping(request);
                //url = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, path);

                //byte[] fileBytes = Helper.GetFile(path);
                //file = File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, path);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { status = status, url = url, file = file, message = message });
        }

        //[HttpGet]
        //public ActionResult DownloadWithTemplateReportMapping(TemplateReportMapping request)
        //{
        //    var status = false;
        //    var message = string.Empty;
        //    try
        //    {
        //        var path = string.Empty;
        //        Task.Factory.StartNew(async () =>
        //        {
        //            (status, path, message) = await _master.DownloadWithTemplateReportMapping(request);
        //        }).Wait();

        //        byte[] fileBytes = Helper.GetFile(path);
        //        return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, Path.GetFileName(path));
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex, ex.Message);
        //        return null;
        //    }
        //}

        [HttpGet]
        public ActionResult DownloadFile(string path)
        {
            try
            {
                var fullPath = Path.Combine(_tempPath, path);

                byte[] fileBytes = Helper.GetFile(fullPath);
                return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, Path.GetFileName(fullPath));
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return null;
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(List<IFormFile> files, int template_id)
        {
            try
            {
                var status = false;
                TemplateReportMapping data = null;
                var message = string.Empty;
                if (files.Count() > 0)
                {
                    //string folderRoot = Path.Combine(_hostingEnvironment.WebRootPath, "Templates", template_id.ToString());
                    string folderRoot = Path.Combine(_tempPath, "Templates", template_id.ToString());

                    foreach (var file in files)
                    {
                        string filePath = Path.Combine(folderRoot, file.FileName);

                        if (!Directory.Exists(folderRoot)) Directory.CreateDirectory(folderRoot);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        (status, data, message) = await _master.UploadTemplateReportMapping(filePath, template_id);
                    }
                }
                return Ok(new { status = true, data = data, message = "File Uploaded" });
            }
            catch (Exception)
            {
                return BadRequest(new { status = false, message = "Error file failed to upload" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveTemplate(TemplateReportMapping request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                var filePath = data.template_path;
                (status, data, message) = await _master.RemoveTemplate(request);
                if (status && System.IO.File.Exists(filePath))
                    System.IO.File.Delete(filePath);

                return Json(new { data = data, status = status, message = message });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTemplateReportMapping(TemplateReportMapping request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.DeleteTemplateReportMapping(request);

                return Json(new { data = data, status = status, message = message });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> ResetTemplateReportMapping(TemplateReportMapping request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.ResetTemplateReportMapping(request);

                return Json(new { data = data, status = status, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult LoadFunctionParameters(string schema_name = null, string function_name = null)
        {
            try
            {
                var data = _master.GetFunctionParameters(schema_name, function_name);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public ActionResult LoadColumnParameters(string schema_name = null, string function_name = null)
        {
            try
            {
                var data = _master.GetColumnParameters(schema_name, function_name);
                return Json(new { data = data, status = true, message = "Successful" });
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
                var data = _master.GetTemplateParameterMapping(schema_name, p_template_report_mapping_id, p_function_id, p_report_id, p_parameter_id);
                return Json(new { data = data, status = true, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveTemplateParameterMapping(TemplateReportMapping header, List<TemplateParameterMapping> list)
        {
            var status = false;
            var data = list;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.SaveTemplateParameterMapping(header, list);

            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            return Json(new { data = data, status = status, message = message });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTemplateParameterMapping(TemplateParameterMapping request)
        {
            var status = false;
            var data = request;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.RemoveTemplateParameterMapping(request);
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
                var data = _master.GetTemplateColumnMapping(schema_name, p_template_report_mapping_id, p_function_id, p_report_id, p_column_id);
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
                (status, data, message) = await _master.SaveTemplateColumnMapping(request);

                return Json(new { data = data, status = status, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveAddNewTemplateColumnMapping(List<TemplateColumnMapping> items)
        {
            var status = false;
            var data = items;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.SaveAddNewTemplateColumnMapping(items);

                return Json(new { data = data, status = status, message = "Successful" });
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                return Json(new { status = false, message = "Fail" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> LoadColumnSelection(TemplateReportMapping report, List<TemplateColumnMapping> selectedColumns)
        {
            var status = false;
            List<TemplateColumnMapping> data = null;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.GetColumnSelection(report, selectedColumns);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                message = ex.Message;
            }

            return Json(new { data = data, status = status, message = message });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveTemplateColumnMapping(TemplateColumnMapping[] request)
        {
            var status = false;
            TemplateColumnMapping[] data = null;
            var message = string.Empty;
            try
            {
                (status, data, message) = await _master.DeleteTemplateColumnMapping(request);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                message = ex.Message;
            }

            return Json(new { data = data, status = status, message = message });
        }
    }
}