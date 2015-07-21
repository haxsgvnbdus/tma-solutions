using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhoneStore.Data;
using PhoneStore.Model.Media;
using PhoneStore.CMS.ViewModels;
using PhoneStore.CMS.Extensions;
using PhoneStore.Model.Catalog;

namespace PhoneStore.CMS.Controllers
{
    [Authorize]
    public class TagController : Controller
    {
        private PhoneStoreDBContext db = new PhoneStoreDBContext();

        // GET: Tag
        public ActionResult Index()
        {
            var entities = db.ProductTags;
            var viewModels = entities.AsEnumerable().Select(c =>
            {
                return c.ToVM();
            });
            return View(viewModels.ToList());
        }

        // GET: Tag/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductTag tag = db.ProductTags.Find(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            var viewModel = new CreateTagSpec();
            viewModel.Name = tag.Name;
            viewModel.ID = tag.ID; 
            return View(viewModel);
        }
        // GET: Tag/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tag/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateTagSpec tagSpec)
        {
            var tag = tagSpec.ToEntity();
            if (ModelState.IsValid)
            {
                db.ProductTags.Add(tag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tag);
        }

        // GET: Tag/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductTag tag = db.ProductTags.Find(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            var viewModel = tag.ToVM(); 
            return View(viewModel);
        }

        // POST: Tag/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateTagSpec tagSpec)
        {
            var tag = tagSpec.ToEntity();
            if (ModelState.IsValid)
            {
                db.Entry(tag).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tag);
        }

        // GET: Tag/Delete/5
        public ActionResult Delete(int? id) 
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductTag tag = db.ProductTags.Find(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);
        }

        // POST: Tag/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductTag tag = db.ProductTags.Find(id);
            db.ProductTags.Remove(tag);
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
