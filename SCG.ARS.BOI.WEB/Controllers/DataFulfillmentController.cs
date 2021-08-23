using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Repositories;
using Microsoft.AspNetCore.Http;
using System.IO;
using OfficeOpenXml;
using System.Net.Http;
using System.Net;
using static SCG.ARS.BOI.WEB.Models.DataFulfillment;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class DataFulfillmentController : Controller
    {
        const string API_PATH = "https://localhost:44300";
        static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public DataFulfillmentController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quota()
        {
            return View();
        }

        public IActionResult QuotaDetail()
        {
            return View();
        }

        public IActionResult UploadLimit()
        {
            return View();
        }

        public IActionResult AutoSplit()
        {
            return View();
        }

        public IActionResult NoProfile()
        {
            return View();
        }

        public IActionResult GetData(ProxyParam param)
        {
            ReturnResult result = new ReturnResult();
            try
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };
                using System.Net.Http.HttpClient hc = new System.Net.Http.HttpClient(handler);
                HttpResponseMessage hcr;
                
                var content = new StringContent(param.Data ?? "", System.Text.Encoding.UTF8, "application/json");
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                hcr = hc.PostAsync(API_PATH + param.Service, content).Result;
                result.Data = hcr.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                result.Error = ex;
            }
            return Json(result);
        }
    }
}
