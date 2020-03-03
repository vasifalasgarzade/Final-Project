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
    public class PopularNewsController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/PopularNews
        public ActionResult Index()
        {
            var popularNews = db.PopularNews.Include(p => p.Author).Include(p => p.Category);
            return View(popularNews.ToList());
        }

      

        // GET: Admin/PopularNews/Create
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Admin/PopularNews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,CategoryId,AuthorId,PhotoUpload,Tittle,Description,Date,Status")] PopularNews popularNews)
        {
            try
            {
                popularNews.Photo = FileManager.Upload(popularNews.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);


            }
            if (ModelState.IsValid)
            {
                db.PopularNews.Add(popularNews);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", popularNews.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", popularNews.CategoryId);
            return View(popularNews);
        }

        // GET: Admin/PopularNews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PopularNews popularNews = db.PopularNews.Find(id);
            if (popularNews == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", popularNews.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", popularNews.CategoryId);
            return View(popularNews);
        }

        // POST: Admin/PopularNews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,CategoryId,AuthorId,Photo,PhotoUpload,Tittle,Description,Date,Status")] PopularNews popularNews)
        {
            try
            {
                popularNews.Photo = FileManager.Upload(popularNews.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);


            }
            if (ModelState.IsValid)
            {
                db.Entry(popularNews).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", popularNews.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", popularNews.CategoryId);
            return View(popularNews);
        }

        // GET: Admin/PopularNews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PopularNews popularNews = db.PopularNews.Find(id);
            if (popularNews == null)
            {
                return HttpNotFound();
            }
            db.PopularNews.Remove(popularNews);
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
