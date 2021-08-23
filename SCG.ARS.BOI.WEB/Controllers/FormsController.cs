using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Layouts()
        {
            return View();
        }

        public IActionResult Controls()
        {
            return View();
        }

        public IActionResult Selects()
        {
            return View();
        }

        public IActionResult Pickers()
        {
            return View();
        }

        public IActionResult Editors()
        {
            return View();
        }

        public IActionResult FileUpload()
        {
            return View();
        }

        public IActionResult Validation()
        {
            return View();
        }

        public IActionResult Wizard()
        {
            return View();
        }

        public IActionResult DualList()
        {
            return View();
        }
    }
}