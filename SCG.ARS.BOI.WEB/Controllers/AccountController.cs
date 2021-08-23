using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Security;
using SCG.ARS.BOI.WEB.Security.Model;
using SCG.ARS.BOI.WEB.Services;
using SCG.ARS.BOI.WEB.ViewModels;

namespace SCG.ARS.BOI.WEB.Controllers {
    public class AccountController : Controller
    {
        static Logger logger = LogManager.GetLogger("SecurityLog");
        private readonly IHostingEnvironment _hostingEnvironment;

        //private MyDbContext db = new MyDbContext ();

        private readonly IConfiguration _configuration;
        ClaimsPrincipal _user;
        private readonly UserManager<ApplicationUser> userMngr;
        private readonly SignInManager<ApplicationUser> signInMngr;
        private readonly IPermissionRepository pr;

        public AccountController (
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment hostingEnvironment,
            IConfiguration configuration,
            UserManager<ApplicationUser> userMngr,
            SignInManager<ApplicationUser> signInMngr,
            IPermissionRepository pr) {
            _configuration = configuration;
            var httpContext = httpContextAccessor.HttpContext;
            _hostingEnvironment = hostingEnvironment;
            _user = httpContext.User;
            this.userMngr = userMngr;
            this.signInMngr = signInMngr;
            this.pr = pr;
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpGet]
        public IActionResult ForceSignOut()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

        private void GenCookieToken(ApplicationUser usr)
        {
            string token = Guid.NewGuid().ToString();
            HttpContext.Response.Cookies.Append("CookieToken", token, new CookieOptions { HttpOnly = true, IsEssential = true, SameSite = SameSiteMode.Strict });
            pr.RecordCookieToken(usr.UserName, token);
        }

        [HttpGet]
        public async Task<IActionResult> OpenReport([FromQuery] AccessTokenModel model)
        {

            logger.Info($"[External request] {model.SourceSystem} has been request to view {model.Route} with token {model.Token}.");

            JwtSecurityToken token = new JwtSecurityTokenHandler().ReadJwtToken(model.Token);
            var ea = pr.GetExternalAccess(model.SourceSystem);
            string username = ValidateJwtToken(model.Token, ea);
            ApplicationUser user = null;
            if (!string.IsNullOrEmpty(username))
                user = await userMngr.FindByNameAsync(username);
            if (user != null)
            {
                await signInMngr.SignInAsync(user, true);
                logger.Info($"[External request] {model.SourceSystem} has been granted to view {model.Route} as {user.UserName}.");
                GenCookieToken(user);
                return new RedirectResult(model.Route);
            }
            else
            {
                logger.Warn($"[External request] {model.SourceSystem} has been denied to view {model.Route}.");
                return new RedirectResult(Url.Action("AccessDenied", "Account"));
            }
        }

        [HttpPost]
        public async Task<IActionResult> ViewReport([FromBody]AccessTokenModel model) {

            logger.Info($"[External request] {model.SourceSystem} has been request to view {model.Route} with token {model.Token}.");

            JwtSecurityToken token = new JwtSecurityTokenHandler().ReadJwtToken(model.Token);
            var ea = pr.GetExternalAccess(model.SourceSystem);
            string username = ValidateJwtToken(model.Token, ea);
            ApplicationUser user = null;
            if (!string.IsNullOrEmpty(username))
                user = await userMngr.FindByNameAsync(username);
            if (user != null)
            {
                await signInMngr.SignInAsync(user, true);
                logger.Info($"[External request] {model.SourceSystem} has been granted to view {model.Route} as {user.UserName}.");
                GenCookieToken(user);
                return new RedirectResult(model.Route);
            }
            else
            {
                logger.Warn($"[External request] {model.SourceSystem} has been denied to view {model.Route}.");
                return new RedirectResult(Url.Action("AccessDenied", "Account"));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromBody]LoginModel model) {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_user.Identity.IsAuthenticated)
                    {
                        Random rand = new Random();
                        Thread.Sleep(rand.Next(10, 60) * 1000);
                    }
                    var usr = await userMngr.FindByNameAsync(model.UserName);
                    if (usr != null && await userMngr.IsLockedOutAsync(usr))
                    {
                        logger.Info($"[Login] Locked out user try to login: {usr.UserName}.");
                        Random rand = new Random();
                        Thread.Sleep(rand.Next(300, 600) * 1000);
                    }
                    bool loginApi = false;
                    if (usr != null && !usr.IsDelete)
                    {
                        HttpResponseMessage postResult = null;
                        Microsoft.AspNetCore.Identity.SignInResult signResult = null;
                        if (usr.Domain == "Cementhai")
                        {
                            HttpClientHandler clientHandler = new HttpClientHandler();
                            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                            var client = new HttpClient(clientHandler);
                            client.DefaultRequestHeaders.Add("Authorization", "Bearer 48ZvTdQHYL1kBonNej1gvbVK2dRdohu1");
                            using var stringContent = new StringContent($"{{\"Username\": \"{model.UserName}\", \"Password\": \"{model.Password}\", \"Source\": \"auto report\" }}", Encoding.UTF8, "application/json");
                            try
                            {
                                postResult = await client.PostAsync(@"https://scglmw.scglogistics.co.th:8084/api/1/rest/feed-master/queue/SCG/CBM_SCGL/SCG_Logistics_General/GM_auth_version", stringContent);
                                var loginResult = await postResult.Content.ReadAsStringAsync();
                                JObject json = (JObject)JsonConvert.DeserializeObject(loginResult);
                                if (json.ContainsKey("error"))
                                {
                                    logger.Warn($"[Login] Login fail: " + loginResult);
                                }
                                else if (Convert.ToBoolean(json["data"]["authStatus"]))
                                {
                                    loginApi = true;
                                    await signInMngr.SignInAsync(usr, model.RememberMe);
                                }
                                else
                                {
                                    logger.Warn($"[Login] Login fail: Incorrect password for {model.UserName}." + loginResult);
                                }
                            }
                            catch (Exception ex)
                            {
                                loginApi = false;
                                await signInMngr.PasswordSignInAsync(usr, "incorrect_password".ToHash(), model.RememberMe, true);
                                logger.Error(ex, "Login:" + model.UserName);
                            }
                        }
                        else
                        {
                            signResult = await signInMngr.PasswordSignInAsync(usr, model.Password.ToHash(), model.RememberMe, true);
                        }

                        if ((signResult?.Succeeded ?? false) || loginApi)
                        {
                            logger.Info($"[Login] Login succeeded: {usr.UserName}.");
                            GenCookieToken(usr);
                            return Json(new { success = true, url = Url.Action("Index", "Home") });
                        }
                        else
                        {
                            logger.Warn($"[Login] Login fail: Incorrect password for {model.UserName}.");
                        }
                    }
                    else
                    {
                        if (usr == null)
                            logger.Info($"[Login] Login fail: {model.UserName} does not exists.");
                        else if (usr.IsDelete)
                            logger.Info($"[Login] Login fail: {model.UserName} has been deleted.");

                    }
                    if (usr != null)
                    {
                        if (await userMngr.IsLockedOutAsync(usr))
                        {
                            return Json(new { data = "Your user has been locked out.", success = false });
                        }
                    }

                    return Json(new { data = "Invalid username or password.", success = false });
                }
                return Json(new { success = false });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Login:" + model.UserName);
                return Json(new { data = ex.Message, success = false });
            }
        }

        public string ValidateJwtToken(string token, ExternalAccess ea)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                var key = Encoding.UTF8.GetBytes(ea.SecretKey);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero,
                    RequireExpirationTime = false,
                    ValidateLifetime = false,
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                TimeSpan tsNow = new TimeSpan(DateTime.UtcNow.Ticks);
                TimeSpan tsExpire = new TimeSpan(jwtToken.ValidFrom.Ticks);
                if (tsExpire.Subtract(tsNow).TotalMinutes > -5 && tsExpire.Subtract(tsNow).TotalMinutes < 0)
                {
                    string username = jwtToken.Claims.Single(c => c.Type == ClaimTypes.Name).Value;
                    return username;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        [Authorize]
        [Route ("profile")]
        public IActionResult Profile () {
            var model = new ProfileViewModel {
                Name = User.Identity.Name,
                Claims = User.Claims
            };
            return View (model);
        }

        public async Task<ActionResult> Logout () {
            await signInMngr.SignOutAsync();
            return RedirectToAction ("Login", "Account");
        }
    }
}