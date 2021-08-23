using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class MaintenanceController : Controller
    {
        public IActionResult LockScreen()
        {
            return View();
        }

        public IActionResult Page404()
        {
            return View();
        }

        public IActionResult Page500()
        {
            return View();
        }

        public IActionResult UsersMaintenance(){
            return View();
        }

        public IActionResult Quartzmin(){
            return Redirect ("/Quartzmin");
        }

        public IActionResult UnderConstruction() {
            return View();
        }
    }
}