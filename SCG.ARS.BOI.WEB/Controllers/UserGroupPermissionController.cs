using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;
using SCG.ARS.BOI.WEB;
using SCG.ARS.BOI.WEB.Services;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class UserGroupPermissionController : Controller
    {
        private DbContext _context;
        private readonly IUserService _userService;
        private string _userCode;
        private readonly List<LinkRolesMenus> _permissions;
        static Logger logger = LogManager.GetCurrentClassLogger();
        public UserGroupPermissionController(DbContext context,
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IUserService userService
            )
        {
            _context = context;
            _userService = userService;
            var httpContext = httpContextAccessor.HttpContext;
            var user = httpContext.User;
            _permissions = _userService.GetPermissions(user, "AMS003");
            _userCode = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value;
        }

        [AuthorizedAction]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetDataPermission()
        {
            //setDbContext();
            ListUserMasterViewModel viewModel = new ListUserMasterViewModel();
            viewModel.Permission = _permissions;
            return Json(viewModel);
        }
        [HttpGet]
        public JsonResult GetMenuConfig(string keywords, string sidx, string sort, int page, int rows, bool _search, string searchField, string searchOper, string searchString)
        {
            //#2 Setting Paging  
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            string id = keywords ?? "1";
            //setDbContext();
            List<PermissionModel> permission = new List<PermissionModel>();
            //permission = _context.GetPermissions(int.Parse(id));
            List<PermissionModel> lst = permission.ToList();
            var jsonData = new
            {
                total = page,
                page = page,
                records = lst.Count,
                rows = lst
            };
            return Json(jsonData);
        }

        [HttpPost]
        public ActionResult SaveUserPermission([FromBody]List<PermissionModel> data)
        {
            var isSuccess = false;
            var message = string.Empty;
            if (_permissions.Count > 0 && _permissions.ToList().FirstOrDefault().FullControl_Flag == false)
            {
                message = "You don't have permission to access data.";
                return Json(new { status = isSuccess, message = message });
            }
            // List<PermissionModel> records = new List<PermissionModel>();            
            // if (_permissions.Count > 0 && _permissions.ToList().FirstOrDefault().FullControl_Flag == false)
            // { 
            // }
            int nKey = int.Parse(data.FirstOrDefault().usergroup_id.ToString());
            string str = "DELETE FROM glsystemconfig.tbl_m_grouppermission WHERE UserGroup_Id = '" + nKey + "'";
            NpgsqlConnection cnn = new NpgsqlConnection(string.Empty);
            cnn.Open();
            NpgsqlCommand myCommand = new NpgsqlCommand(str, cnn);
            NpgsqlTransaction myTrans;
            myTrans = cnn.BeginTransaction();
            myCommand.Connection = cnn;
            myCommand.Transaction = myTrans;
            try
            {
                myCommand.CommandText = "DELETE FROM glsystemconfig.tbl_m_grouppermission WHERE UserGroup_Id = '" + nKey + "'";
                myCommand.ExecuteNonQuery();
                foreach (PermissionModel s in data)
                {
                    if (s.fullcontrol_flag == 1 || s.readonly_flag == 1)
                    {
                        myCommand.CommandText = "INSERT INTO glsystemconfig.tbl_m_grouppermission (UserGroup_Id, Menu_Id, FullControl_Flag, ReadOnly_Flag, CreateUser_Code, Create_DateTime, UpdateUser_Code, Update_DateTime)VALUES(" + s.usergroup_id + "," + s.menu_id + "," + s.fullcontrol_flag + "," + s.readonly_flag + ",'" + _userCode + "', now() " + ",'" + _userCode + "', now())";
                        myCommand.ExecuteNonQuery();
                    }
                }
                myTrans.Commit();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                if (ex.InnerException != null)
                {
                    logger.Error(ex.InnerException, $"Exception on SaveUserPermission");
                    message = ex.InnerException.Message;
                }
                else
                {
                    logger.Error(ex, $"Exception on SaveUserPermission");
                    message = ex.Message;
                }
            }
            return Json(new { status = isSuccess, message = message });
        }
    }
}