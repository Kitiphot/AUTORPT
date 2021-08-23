using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB;
using SCG.ARS.BOI.WEB.Services;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class UserGroupController : Controller
    {
        private DbContext _context;
        private readonly IUserService _userService;
        private string _userCode;
        private readonly List<LinkRolesMenus> _permissions;
        public UserGroupController(DbContext context,
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IUserService userService
            )
        {
            _context = context;
            _userService = userService;
            var httpContext = httpContextAccessor.HttpContext;
            var user = httpContext.User;
            _permissions = _userService.GetPermissions(user, "AMS001");
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
        [HttpPost]
        public JsonResult GetUserGroup(string sidx, string sort, int page, int rows, bool _search, string searchField, string searchOper, string searchString)
        {
            //#2 Setting Paging  
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;

            //setDbContext();
            List<Roles> usergroup = new List<Roles>();
            //usergroup = _context.GetUserGroupInfo();
            List<Roles> lst = usergroup.ToList();
            if (_search && searchString != null)
            {
                if (searchField == "userGroup_Name")
                    switch (searchOper)
                    {
                        case "eq":
                            lst = lst.Where(t => t.UserGroup_Name.Equals(searchString)).ToList();
                            break;
                        case "cn":
                            lst = lst.Where(t => t.UserGroup_Name.Contains(searchString)).ToList();
                            break;
                    }                    
                else
                    switch (searchOper)
                    {
                        case "eq":
                            lst = lst.Where(t => t.UserGroup_Desc.Equals(searchString)).ToList();
                            break;
                        case "cn":
                            lst = lst.Where(t => t.UserGroup_Desc.Contains(searchString)).ToList();
                            break;
                    }
            }
            var jsonData = new
            {
                total = page,
                page = page,
                records = lst.Count,
                rows = lst
            };
            return Json(jsonData);
        }

        public string AddUserGroup(Roles Model)
        {
            //setDbContext();
            string str = "INSERT INTO glsystemconfig.tbl_m_usergroup (UserGroup_Name, UserGroup_Desc, CreateUser_Code, Create_DateTime, UpdateUser_Code, Update_DateTime)VALUES('" + Model.UserGroup_Name + "','" + Model.UserGroup_Desc + "','" + _userCode + "'" + ", now(),'" + _userCode + "'" + ", now())";
            NpgsqlConnection cnn = new NpgsqlConnection(string.Empty);
            NpgsqlCommand command = new NpgsqlCommand(str, cnn);
            cnn.Open();
            command.ExecuteNonQuery();
            return "";
        }

        [HttpPost]
        public string EditUserGroup(Roles Model)
        {
            //setDbContext();
            string str = "UPDATE glsystemconfig.tbl_m_usergroup SET UserGroup_Desc = '" + Model.UserGroup_Desc + "', UpdateUser_Code = '" + _userCode + "', Update_DateTime = now() WHERE UserGroup_Name = '" + Model.UserGroup_Name + "'";
            NpgsqlConnection cnn = new NpgsqlConnection(string.Empty);
            NpgsqlCommand command = new NpgsqlCommand(str, cnn);
            cnn.Open();
            command.ExecuteNonQuery();
            return "";
        }

        [HttpPost]
        public string DeleteUserGroup(string Id)
        {
            //setDbContext();
            string str = "DELETE FROM glsystemconfig.tbl_m_usergroup WHERE UserGroup_Name = '" + Id + "'";
            NpgsqlConnection cnn = new NpgsqlConnection(string.Empty);
            NpgsqlCommand command = new NpgsqlCommand(str, cnn);
            cnn.Open();
            command.ExecuteNonQuery();
            return "";
        }

    }
}