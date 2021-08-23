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
//using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Services;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class UserController : Controller
    {
        private DbContext _context;
        private readonly IUserService _userService;
        private string _userCode;
        private readonly List<LinkRolesMenus> _permissions;
        public UserController(DbContext context,
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IUserService userService
            )
        {
            _context = context;
            _userService = userService;
            var httpContext = httpContextAccessor.HttpContext;
            var user = httpContext.User;
            _permissions = _userService.GetPermissions(user, "AMS002");
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
        public JsonResult GetUserInfo(string sidx, string sort, int page, int rows, bool _search, string searchField, string searchOper, string searchString)
        {
            //#2 Setting Paging  
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            //setDbContext();
            List<Users> users = new List<Users>();
            // users = _context.GetUserInfo();
            // List<Users> lst = users.ToList();
            // if (_search && searchString != null)
            // {
            //     if (searchField == "user_Code")
            //         switch (searchOper)
            //         {
            //             case "eq":
            //                 lst = lst.Where(t => t.User_Code.Equals(searchString)).ToList();
            //                 break;
            //             case "cn":
            //                 lst = lst.Where(t => t.User_Code.Contains(searchString)).ToList();
            //                 break;
            //         }
            //     else
            //         switch (searchOper)
            //         {
            //             case "eq":
            //                 lst = lst.Where(t => t.User_Email.Equals(searchString)).ToList();
            //                 break;
            //             case "cn":
            //                 lst = lst.Where(t => t.User_Email.Contains(searchString)).ToList();
            //                 break;
            //         }
            // }
            var jsonData = new
            {
                total = page,
                page = page,
                records = 0//lst.Count,
                //rows = lst
            };
            return Json(jsonData);
        }
        [HttpPost]
        public string EditUser(Users Model)
        {
            //setDbContext();
            string str = "UPDATE glsystemconfig.tbl_m_user SET UserGroup_ID = '" + Model.UserGroup_Name + "', LastActive_Datetime = now() WHERE User_Code = '" + Model.User_Code + "'";
            NpgsqlConnection cnn = new NpgsqlConnection(string.Empty);
            NpgsqlCommand command = new NpgsqlCommand(str, cnn);
            cnn.Open();
            command.ExecuteNonQuery();
            return "";
        }

        [HttpPost]
        public string DeleteUser(string Id)
        {
            //setDbContext();
            string str = "DELETE FROM glsystemconfig.tbl_m_user WHERE User_Code = '" + Id + "'";
            NpgsqlConnection cnn = new NpgsqlConnection(string.Empty);
            NpgsqlCommand command = new NpgsqlCommand(str, cnn);
            cnn.Open();
            command.ExecuteNonQuery();
            return "";
        }
        [HttpGet]
        public JsonResult GetDataUserGroupForMap(string sKey, int page, int rows)
        {
            //setDbContext();
            List<DataMaster> grp = new List<DataMaster>();
            //grp = _context.GetDataUserGroupForMap();
            return Json(grp);
        }
    }
}
