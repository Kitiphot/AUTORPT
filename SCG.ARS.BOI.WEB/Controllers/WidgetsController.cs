using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class WidgetsController : Controller
    {
        public IActionResult Widgets()
        {
            return View();
        }
    }
}