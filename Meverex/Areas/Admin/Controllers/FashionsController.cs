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
    public class FashionsController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/Fashions
        public ActionResult Index()
        {
            var fashions = db.Fashions.Include(f => f.Author).Include(f => f.Category);
            return View(fashions.ToList());
        }

      

        // GET: Admin/Fashions/Create
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Admin/Fashions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CategoryId,AuthorId,Photo,Tittle,Description,Date,Status,CreateAt")] Fashion fashion)
        {
            if (ModelState.IsValid)
            {
                db.Fashions.Add(fashion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", fashion.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", fashion.CategoryId);
            return View(fashion);
        }

        // GET: Admin/Fashions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fashion fashion = db.Fashions.Find(id);
            if (fashion == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", fashion.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", fashion.CategoryId);
            return View(fashion);
        }

        // POST: Admin/Fashions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CategoryId,AuthorId,Photo,Tittle,Description,Date,Status,CreateAt")] Fashion fashion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fashion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", fashion.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", fashion.CategoryId);
            return View(fashion);
        }

        // GET: Admin/Fashions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fashion fashion = db.Fashions.Find(id);
            if (fashion == null)
            {
                return HttpNotFound();
            }
            db.Fashions.Remove(fashion);
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
