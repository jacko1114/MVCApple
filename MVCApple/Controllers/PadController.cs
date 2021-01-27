using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApple.Controllers
{
    public class PadController : Controller
    {
        // GET: Pad
        public ActionResult Index()
        {
            ViewBag.price = 23100;
            ViewBag.productName = "iPad Pro";
            ViewBag.url = "/iPad.png";
            return View();
        }
    }
}