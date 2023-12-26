using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OzturkOtoMarketWEBUI.Controllers
{
    public class YoneticiController : Controller
    {
        // GET: Yonetici
        public ActionResult Index()
        {
            ViewBag.Title = "Yonetici";
            return View();
        }
    }
}