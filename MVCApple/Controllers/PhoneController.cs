using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApple.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            ViewBag.price = 42000;
            ViewBag.productName = "iPhone 12";
            ViewBag.url = "/iPhone.png";
            return View();
        }
    }
}