using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApple.Controllers
{
    public class MacController : Controller
    {
        // GET: Mac
        public ActionResult Index()
        {
            ViewBag.price = 43210;
            ViewBag.productName = "MacBook'13";
            ViewBag.url = "Mac.jpg";
            return View();
        }
    }
}