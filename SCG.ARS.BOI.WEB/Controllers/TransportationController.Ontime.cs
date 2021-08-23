using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public partial class TransportationController
    {
        [HttpPost]
        public JsonResult OntimeDetail(TransportationCriteria criteria)
        {
            try
            {
                return Json(new { data = _report.OntimeDetail(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "OntimeDetail", Newtonsoft.Json.JsonConvert.SerializeObject(criteria));
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
