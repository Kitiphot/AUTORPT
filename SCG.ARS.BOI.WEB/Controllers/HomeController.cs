using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLog;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using Quartz;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Schedule;
using SCG.ARS.BOI.WEB.Services;
//using SCG.ARS.BOI.WEB.ViewModels;

namespace SCG.ARS.BOI.WEB.Controllers
{
    [Authorize]
    //[ServiceFilter (typeof (LogFilter))]
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        static Logger logger = LogManager.GetCurrentClassLogger();
        //MyDbContext db = new MyDbContext ();
        //private readonly List<LinkRolesMenus> _permissions;

        ClaimsPrincipal _user;
        private string _userCode;

        private ILogger<HomeController> _logger;

        private StdSchedulerFactoryEx _factory;
        public HomeController(
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            ILogger<HomeController> logger,
            ISchedulerFactory factory)
        {
            _logger = logger;
            var httpContext = httpContextAccessor.HttpContext;
            _hostingEnvironment = hostingEnvironment;
            _user = httpContext.User;
            _userCode = httpContext.User.Identity.Name;
            //_permissions = _userService.GetPermissions(_user, "HME001");
            _factory = (StdSchedulerFactoryEx)factory;
        }

        [Authorize]
        [Obsolete]
        public IActionResult Index()
        {

            //if (HttpContext.Session.GetString("email") == null)
            if (_user == null)
            {
                return Redirect("/Account/Login");
            }

            //Admins _a = _userService.GetAdmin(_user); //new Admins ();
            //_ = Validate(_a);

            //code to test nlog to database
            //  _logger.LogCritical("nlog is working from a controller");
            // throw new ArgumentException("way wrong");

            // // Display the name of the current thread culture.
            // Console.WriteLine ("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);

            // // Change the current culture to th-TH.
            // CultureInfo.CurrentCulture = new CultureInfo ("th-TH", false);
            // Console.WriteLine ("CurrentCulture is now {0}.", CultureInfo.CurrentCulture.Name);

            // // Display the name of the current UI culture.
            // Console.WriteLine ("CurrentUICulture is {0}.", CultureInfo.CurrentUICulture.Name);

            // // Change the current UI culture to ja-JP.
            // CultureInfo.CurrentUICulture = new CultureInfo ("ja-JP", false);
            // Console.WriteLine ("CurrentUICulture is now {0}.", CultureInfo.CurrentUICulture.Name);

            // const string dataFmt = "{0,-30}{1}";
            // const string timeFmt = "{0,-30}{1:yyyy-MM-dd HH:mm}";

            // Console.WriteLine (
            //     "This example of selected TimeZone class " +
            //     "elements generates the following \n" +
            //     "output, which varies depending on the " +
            //     "time zone in which it is run.\n");

            // // Get the local time zone and the current local time and year.
            // TimeZone localZone = TimeZone.CurrentTimeZone;
            // DateTime currentDate = DateTime.Now;
            // int currentYear = currentDate.Year;

            // // Display the names for standard time and daylight saving 
            // // time for the local time zone.
            // Console.WriteLine (dataFmt, "Standard time name:",
            //     localZone.StandardName);
            // Console.WriteLine (dataFmt, "Daylight saving time name:",
            //     localZone.DaylightName);

            // // Display the current date and time and show if they occur 
            // // in daylight saving time.
            // Console.WriteLine ("\n" + timeFmt, "Current date and time:",
            //     currentDate);
            // Console.WriteLine (dataFmt, "Daylight saving time?",
            //     localZone.IsDaylightSavingTime (currentDate));

            // // Get the current Coordinated Universal Time (UTC) and UTC 
            // // offset.
            // DateTime currentUTC =
            //     localZone.ToUniversalTime (currentDate);
            // TimeSpan currentOffset =
            //     localZone.GetUtcOffset (currentDate);

            // Console.WriteLine (timeFmt, "Coordinated Universal Time:",
            //     currentUTC);
            // Console.WriteLine (dataFmt, "UTC offset:", currentOffset);

            // // Get the DaylightTime object for the current year.
            // DaylightTime daylight =
            //     localZone.GetDaylightChanges (currentYear);

            // // Display the daylight saving time range for the current year.
            // Console.WriteLine (
            //     "\nDaylight saving time for year {0}:", currentYear);
            // Console.WriteLine ("{0:yyyy-MM-dd HH:mm} to " +
            //     "{1:yyyy-MM-dd HH:mm}, delta: {2}",
            //     daylight.Start, daylight.End, daylight.Delta);



            //var builder = TriggerBuilder.Create()
            //        .WithIdentity(new TriggerKey("test trigger", "Test"))
            //        .ForJob("HelloWorldJob")
            //        //.UsingJobData(jobDataMap.GetQuartzJobDataMap())
            //        .WithDescription("test")
            //        .WithPriority(1);

            //builder.StartAt(DateTime.UtcNow);
            //builder.EndAt(DateTime.UtcNow.AddDays(1));

            ////if (!string.IsNullOrEmpty(triggerModel.CalendarName))
            ////    builder.ModifiedByCalendar(triggerModel.CalendarName);

            //builder.WithCronSchedule("0/5 * * * * ?");

            //var trigger = builder.Build();
            //var scheduler = _factory.Scheduler;


            //scheduler.ScheduleJob(trigger);

            ////await Scheduler.RescheduleJob(new TriggerKey(triggerModel.OldTriggerName, triggerModel.OldTriggerGroup), trigger);

            return View();

        }

        public ActionResult Validate(Admins admin)
        {
            var _admin = admin;
            if (admin != null)
            {

                return Json(new { status = true, message = "Login Successfull!" });

            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }
        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb)
        {
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    string url = dr["menu_Url"].ToString();
                    string menuText = dr["menu_Name"].ToString();
                    string icon = dr["menu_Icon"].ToString();

                    if (url != "#")
                    {
                        string line = String.Format(@"<li><a href=""{0}""><i class=""{2}""></i> <span>{1}</span></a></li>", url, menuText, icon);
                        sb.Append(line);
                    }

                    string pid = dr["Menu_Id"].ToString();
                    string parentId = dr["menuparent_id"].ToString();

                    DataRow[] subMenu = table.Select(String.Format("menuparent_id = '{0}'", pid));
                    if (subMenu.Length > 0 && !pid.Equals(parentId))
                    {
                        string line = String.Format(@"<li class=""treeview""><a href=""#""><i class=""{0}""></i> <span>{1}</span><span class=""pull-right-container""><i class=""fa fa-angle-left pull-right""></i></span></a><ul class=""treeview-menu"">", icon, menuText);
                        var subMenuBuilder = new StringBuilder();
                        sb.AppendLine(line);
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder));
                        sb.Append("</ul></li>");
                    }
                }
            }
            return sb.ToString();
        }
        public DataSet ToDataSet<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            return ds;
        }

        public IActionResult Error()
        {
            // Retrieve error information in case of internal errors
            var error = HttpContext
                .Features
                .Get<IExceptionHandlerFeature>();
            if (error == null)
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

            // Use the information about the exception 
            var exception = error.Error;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}