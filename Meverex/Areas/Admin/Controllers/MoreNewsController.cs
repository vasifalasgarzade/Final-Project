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
    public class MoreNewsController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/MoreNews
        public ActionResult Index()
        {
            var moreNews = db.MoreNews.Include(m => m.Category);
            return View(moreNews.ToList());
        }

      

        // GET: Admin/MoreNews/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Admin/MoreNews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,CategoryId,PhotoUpload,Tittle,Description,Date,Status")] MoreNew moreNew)
        {
            try
            {
                moreNew.Photo = FileManager.Upload(moreNew.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);

                
            }
            if (ModelState.IsValid)
            {
                db.MoreNews.Add(moreNew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", moreNew.CategoryId);
            return View(moreNew);
        }

        // GET: Admin/MoreNews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoreNew moreNew = db.MoreNews.Find(id);
            if (moreNew == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", moreNew.CategoryId);
            return View(moreNew);
        }

        // POST: Admin/MoreNews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,CategoryId,Photo,Tittle,Description,Date,Status,PhotoUpload")] MoreNew moreNew)
        {
            try
            {
                moreNew.Photo = FileManager.Upload(moreNew.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);

                
            }
            if (ModelState.IsValid)
            {
                db.Entry(moreNew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", moreNew.CategoryId);
            return View(moreNew);
        }

        // GET: Admin/MoreNews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoreNew moreNew = db.MoreNews.Find(id);
            if (moreNew == null)
            {
                return HttpNotFound();
            }
            db.MoreNews.Remove(moreNew);
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
