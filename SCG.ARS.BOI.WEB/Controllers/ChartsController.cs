using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult C3()
        {
            return View();
        }

        public IActionResult Chartist()
        {
            return View();
        }

        public IActionResult ChartJS()
        {
            return View();
        }

        public IActionResult Dygraph()
        {
            return View();
        }

        public IActionResult FlotChart()
        {
            return View();
        }

        public IActionResult Morris()
        {
            return View();
        }

        public IActionResult Plottable()
        {
            return View();
        }
    }
}