using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SCG.ARS.BOI.WEB.Attributes;

namespace SCG.ARS.BOI.WEB.Controllers {
    public class SKICController : Controller {
        public IActionResult Index () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_SKIC_001, Permission.View)]
        public IActionResult WEB_SKIC_001 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_SKIC_002, Permission.View)]
        public IActionResult WEB_SKIC_002 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_SKIC_003, Permission.View)]
        public IActionResult WEB_SKIC_003 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_SKIC_004, Permission.View)]
        public IActionResult WEB_SKIC_004 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_SKIC_005, Permission.View)]
        public IActionResult WEB_SKIC_005 () {
            return View ();
        }
        [WebAuthorize(ScreenID.WEB_SKIC_006, Permission.View)]
        public IActionResult WEB_SKIC_006() {
            return View();
        }
        [WebAuthorize(ScreenID.WEB_SKIC_007, Permission.View)]
        public IActionResult WEB_SKIC_007() {
			return View();
        }
        [WebAuthorize(ScreenID.WEB_SKIC_008, Permission.View)]
        public IActionResult WEB_SKIC_008() {
			return View();
		}
	}
}