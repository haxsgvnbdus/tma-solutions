using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneStore.Data;
using PhoneStore.Web.Extensions;

namespace PhoneStore.Web.Controllers
{
    public class HomeController : Controller
    {
        PhoneStoreDBContext db = new PhoneStoreDBContext();
        public ActionResult Index()
        {
            var entities = db.Products;
            var viewModels = entities.AsEnumerable().Select(c =>
                {
                    return c.ToVM(); 
                });
            return View(viewModels.ToList());
        }

        public ActionResult About() 
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}