using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OzturkOtoMarketWEBUI.Entity;


namespace OzturkOtoMarketWEBUI.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products.ToList());
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult List(int? id)
        {
            var products = _context.Products.Where(i => i.IsApproved).AsQueryable();

            if(id!=null)
            {
                products= products.Where(i=>i.CategoryId==id);
            }

            return View(products.ToList());
        }


        public PartialViewResult GetCategories()
            {
            return PartialView(_context.Categories.ToList());
        }

    }
}