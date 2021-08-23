using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public partial class ReportController
    {

        //Warut S.
        [HttpPost]
        //public JsonResult RPTLPC001_Report(string business, string fleet, string shipping_point, string shipto_region, string mat_group, string order_type, string truck_type, string planner_name, string search_day, string search_month, string search_year, string status, string carrier, string aging)
        public JsonResult RPTLPC001_Report(TransportationCriteria request)
        {
            //string business, string fleet, string shipping_point, string shipto_region, string mat_group, string order_type, string truck_type, string planner_name, string search_day, string search_month, string search_year, string status, string carrier, string aging
            var jsonResult = Json(new { data = _report.RPTLPC001_Report(request) });

            return jsonResult;

        }
    }
}
