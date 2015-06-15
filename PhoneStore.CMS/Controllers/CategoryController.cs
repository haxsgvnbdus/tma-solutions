using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhoneStore.Data;
using PhoneStore.Model.Catalog;
using PhoneStore.CMS.Extensions;
using PhoneStore.CMS.ViewModels;

namespace PhoneStore.CMS.Controllers
{
    public class CategoryController : Controller
    {
        private PhoneStoreDBContext db = new PhoneStoreDBContext();

        // GET: Categories
        public ActionResult Index()
        {
            var entities = db.Categories;
            var viewModels = entities.AsEnumerable().Select(c =>
                {
                    return c.ToVMIndex();
                });
            return View(viewModels.ToList());
        }

        // GET: Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            var viewModel = new CreateCategorySpec();
            viewModel.Name = category.Name;
            viewModel.Description = category.Description;
            viewModel.PriceRanges = category.PriceRanges;
            viewModel.MetaKeywords = category.MetaKeywords;
            viewModel.MetaTitle = category.MetaTitle;
            viewModel.MetaDescription = category.MetaDescription;
            viewModel.ParentCategoryId = category.ParentCategoryId;
            viewModel.PictureId = category.PictureId;
            viewModel.DisplayOrder = category.DisplayOrder;
            viewModel.IncludeInTopMenu = category.IncludeInTopMenu;
            viewModel.HasDiscountsApplied = category.HasDiscountsApplied; 
            return View(viewModel);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCategorySpec categorySpec)
        {
            var category = categorySpec.ToEntity();
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateCategorySpec categorySpec)
        {
            var category = categorySpec.ToEntity();
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
