using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLog;
using SCG.ARS.BOI.WEB.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Attributes
{
    public class WebAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public ScreenID Screen { get; set; }
        public Permission Permission { get; set; }

        static NLog.Logger logger = LogManager.GetLogger("SecurityLog");
        public WebAuthorizeAttribute()
        {
        }

        public WebAuthorizeAttribute(ScreenID screen, Permission permission)
        {
            this.Screen = screen;
            this.Permission = permission;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                if (context.HttpContext.User.FindAll($"PM_{this.Permission.ToString()}").Any(c => c.Value == this.Screen.ToString()) ||
                    context.HttpContext.User.Identity.Name == SecurityHelpers.GetAdminUser() ||
                    context.HttpContext.User.IsInRole(SecurityHelpers.GetAdminRole()))
                {
                    try
                    {
                        logger.Info($"[Permission] User {context.HttpContext.User.Identity.Name} has been granted to {this.Permission.ToString()} screen {this.Screen.ToString()}");
                    }
                    catch
                    {
                        //suppress
                    }
                    return;
                }
            }
            context.HttpContext.Response.Redirect("/Account/AccessDenied");
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            context.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Not Authorized";
            context.Result = new RedirectResult("/Account/AccessDenied");
            //{
            //    Value = new
            //    {
            //        Status = "Error",
            //        Message = $"You has no authorize to {this.Permission.ToString()} at screen {this.Screen.ToString()}"
            //    },
            //};
            try
            {
                logger.Info($"[Permission] User {context.HttpContext.User.Identity.Name} has been denied to {this.Permission.ToString()} screen {this.Screen.ToString()}");
            }
            catch {
                //suppress
            }
        }
    }

    public enum ScreenID
    {
        //warehouse module
        WEB_WH_001,
        WEB_WH_002,
        WEB_WH_003,
        WEB_WH_004,
        WEB_WH_005,
        WEB_WH_006,
        WEB_WH_007,
        WEB_WH_OVERALL,
        //transportation module
        WEB_LPC_001,
        WEB_LPC_002,
        WEB_LPC_003,
        WEB_LPC_004,
        WEB_LPC_005,
        WEB_LPC_006,
        WEB_LPC_007,
        WEB_LPC_008,
        WEB_LPC_009,
        WEB_LPC_010,
        WEB_LPC_011,
        WEB_LPC_012,
        WEB_LPC_013,
        WEB_LPC_014,
        WEB_LPC_015,
        WEB_LPC_016,
        WEB_LPC_017,
        WEB_LPC_018,
        WEB_LPC_019,
        WEB_LPC_020,
        WEB_LPC_021,
        WEB_LPC_022,
        WEB_LPC_023,
        WEB_LPC_024,
        WEB_LPC_025,
        //SKIC module
        WEB_SKIC_001,
        WEB_SKIC_002,
        WEB_SKIC_003,
        WEB_SKIC_004,
        WEB_SKIC_005,
        WEB_SKIC_006,
        WEB_SKIC_007,
        WEB_SKIC_008,
        //ESC module
        WEB_ESC_001,
        WEB_ESC_002,
        WEB_ESC_003,
        WEB_ESC_004,
        WEB_ESC_005,
        WEB_ESC_006,
        WEB_ESC_007,
        WEB_ESC_012,
        //ILB module
        WEB_ILB_001,
        WEB_ILB_002,
        WEB_ILB_003,
        WEB_ILB_004,
        WEB_ILB_005,
        WEB_ILB_006,
        WEB_ILB_007,
		WEB_ILB_008,
		WEB_ILB_009,
		WEB_ILB_010,
		//Security
		WEB_USER,
        WEB_ROLE,
        WEB_EXTERNAL_ACCESS,

        WEB_MASTER,
        WEB_STOCK_MASTER,
        WEB_AUTOREPORT,
        WEB_EMAIL_SCHEDULER,
        WEB_QUARTZMIN,
    }
    public enum Permission
    {
        View,
        Add,
        Edit,
        Delete,
    }
}
