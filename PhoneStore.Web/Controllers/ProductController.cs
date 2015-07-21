using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneStore.Data;
using PhoneStore.Web.Extensions;
using PhoneStore.Web.ViewModels;
using PhoneStore.Model.Catalog;
using System.Net;
using PhoneStore.Model.Media;

namespace PhoneStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private PhoneStoreDBContext db = new PhoneStoreDBContext(); 
        
        // GET: Product
        public ActionResult Index()
        {
            var entities = db.Products.ToList();
            var viewModels = entities.Select(c =>
                {
                    return c.ToVM(); 
                });

            return View(viewModels.ToList());
        }
        [Authorize]
        public ActionResult Detail(int? ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Product product = db.Products.Find(ID);
            if (product == null)
            {
                return HttpNotFound();
            }

            var viewModel = new ProductDetailModel();
            viewModel.Name = product.Name;
            viewModel.Description = product.Description;
            viewModel.Sku = product.Sku;
            viewModel.Price = product.Price;
            viewModel.ProductPictures = product.ProductPictures;
            return View(viewModel);


        }

        public JsonResult GetImages(int id)
        {
            var vm = new ProductPictureDetailsModel();

            return Json(vm, JsonRequestBehavior.AllowGet);
        }

    }
}