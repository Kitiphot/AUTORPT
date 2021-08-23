using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using SCG.ARS.BOI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB
{
    public class AuthorizedAction: ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            // if (filterContext.HttpContext.Session.GetString("email") == null)
            // {
            //     filterContext.Result = new RedirectToRouteResult(
            //         new RouteValueDictionary { { "controller", "Home" }, { "action", "Index" } });
            //     return;
            // }

            // var menus = JsonConvert.DeserializeObject<List<Menus>>(filterContext.HttpContext.Session.GetString("menus"));
            // var controllerName = filterContext.RouteData.Values["controller"];
            // var actionName = filterContext.RouteData.Values["action"];
            // string url = "/" + controllerName + "/" + actionName;
            // string controller = $"/{controllerName}";

            // if (!menus.Where(s => s.Menu_Url == url).Any() && !menus.Where(s => s.Menu_Url == controller).Any())

            // {
            //     filterContext.Result = new RedirectToRouteResult(
            //         new RouteValueDictionary { { "controller", "Home" }, { "action", "Index" } });
            //     return;
            // }
        }
    }
}
