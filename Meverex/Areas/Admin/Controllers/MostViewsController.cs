using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Meverex.Areas.Admin.Filters;
using Meverex.Data;
using Meverex.Helper;
using Meverex.Models;

namespace Meverex.Areas.Admin.Controllers
{
    [AdminAuth]
    public class MostViewsController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/MostViews
        public ActionResult Index()
        {
            var mostViews = db.MostViews.Include(m => m.Author).Include(m => m.Category);
            return View(mostViews.ToList());
        }

       

        // GET: Admin/MostViews/Create
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Admin/MostViews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,CategoryId,AuthorId,Tittle,Description,Date,Status,PhotoUpload")] MostView mostView)
        {
            try
            {
                mostView.Photo = FileManager.Upload(mostView.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);


            }
            if (ModelState.IsValid)
            {
                db.MostViews.Add(mostView);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", mostView.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", mostView.CategoryId);
            return View(mostView);
        }

        // GET: Admin/MostViews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MostView mostView = db.MostViews.Find(id);
            if (mostView == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", mostView.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", mostView.CategoryId);
            return View(mostView);
        }

        // POST: Admin/MostViews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,CategoryId,AuthorId,Photo,Tittle,Description,Date,Status,PhotoUpload")] MostView mostView)
        {
            try
            {
                mostView.Photo = FileManager.Upload(mostView.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);


            }
            if (ModelState.IsValid)
            {
                db.Entry(mostView).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", mostView.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", mostView.CategoryId);
            return View(mostView);
        }

        // GET: Admin/MostViews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MostView mostView = db.MostViews.Find(id);
            if (mostView == null)
            {
                return HttpNotFound();
            }
            db.MostViews.Remove(mostView);
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
