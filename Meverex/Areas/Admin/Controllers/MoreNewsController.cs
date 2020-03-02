using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Meverex.Data;
using Meverex.Models;

namespace Meverex.Areas.Admin.Controllers
{
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
        public ActionResult Create([Bind(Include = "Id,CategoryId,Photo,Tittle,Description,Date,Status")] MoreNew moreNew)
        {
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
        public ActionResult Edit([Bind(Include = "Id,CategoryId,Photo,Tittle,Description,Date,Status")] MoreNew moreNew)
        {
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
