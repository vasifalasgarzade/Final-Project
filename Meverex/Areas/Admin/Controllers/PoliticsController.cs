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
    public class PoliticsController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/Politics
        public ActionResult Index()
        {
            var politics = db.Politics.Include(p => p.Author);
            return View(politics.ToList());
        }


        // GET: Admin/Politics/Create
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name");
            return View();
        }

        // POST: Admin/Politics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,PhotoUpload,Tittle,Date,AuthorId,Icon,IconUrl,Status")] Politic politic)
        {
            try
            {
                politic.Photo = FileManager.Upload(politic.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);


            }
            if (ModelState.IsValid)
            {
                db.Politics.Add(politic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", politic.AuthorId);
            return View(politic);
        }

        // GET: Admin/Politics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Politic politic = db.Politics.Find(id);
            if (politic == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", politic.AuthorId);
            return View(politic);
        }

        // POST: Admin/Politics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,Photo,Tittle,Date,AuthorId,Icon,IconUrl,Status,PhotoUpload")] Politic politic)
        {
            try
            {
                politic.Photo = FileManager.Upload(politic.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);

            }
            if (ModelState.IsValid)
            {
                db.Entry(politic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", politic.AuthorId);
            return View(politic);
        }

        // GET: Admin/Politics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Politic politic = db.Politics.Find(id);
            if (politic == null)
            {
                return HttpNotFound();
            }
            db.Politics.Remove(politic);
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
