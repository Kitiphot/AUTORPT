using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Invoice()
        {
            return View();
        }

        public IActionResult PricingTable()
        {
            return View();
        }
    }
}