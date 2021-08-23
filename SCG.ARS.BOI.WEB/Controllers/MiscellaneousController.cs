using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class MiscellaneousController : Controller
    {
        public IActionResult Dragula()
        {
            return View();
        }

        public IActionResult Clipboard()
        {
            return View();
        }

        public IActionResult ContextMenu()
        {
            return View();
        }

        public IActionResult Sliders()
        {
            return View();
        }

        public IActionResult Carousel()
        {
            return View();
        }

        public IActionResult Loaders()
        {
            return View();
        }
    }
}