using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApple.Controllers
{
    public class WatchController : Controller
    {
        // GET: Watch
        public ActionResult Index()
        {
            ViewBag.price = 1200;
            ViewBag.productName = "Apple Watch";
            ViewData["url"] = "/watch.jpg";
            return View();
        }
    }
}