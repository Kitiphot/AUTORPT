using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class IconsController : Controller
    {
        public IActionResult MaterialIcon()
        {
            return View();
        }

        public IActionResult FontAwesomeIcon()
        {
            return View();
        }

        public IActionResult SimpleIcon()
        {
            return View();
        }
    }
}