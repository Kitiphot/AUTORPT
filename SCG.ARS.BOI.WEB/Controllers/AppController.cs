using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult NewsGrid()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult FAQ2()
        {
            return View();
        }

        public IActionResult Timeline()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }
    }
}