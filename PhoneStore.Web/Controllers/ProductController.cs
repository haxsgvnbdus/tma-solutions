using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneStore.Data;
using PhoneStore.Web.Extensions;

namespace PhoneStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private PhoneStoreDBContext db = new PhoneStoreDBContext(); 
        
        // GET: Product
        public ActionResult Index()
        {
            var entities = db.Products;
            var viewModels = entities.AsEnumerable().Select(c =>
                {
                    return c.ToVM(); 
                });

            return View(viewModels.ToList());
        }
    }
}