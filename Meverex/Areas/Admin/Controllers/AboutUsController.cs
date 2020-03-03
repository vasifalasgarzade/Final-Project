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
    public class AboutUsController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/AboutUs
        public ActionResult Index()
        {
            return View(db.AboutUs.ToList());
        }

        // GET: Admin/AboutUs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutUs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create( AboutUs aboutUs)
        {
            try
            {
                aboutUs.Photo = FileManager.Upload(aboutUs.PhotoUpload);
                
            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);
            }
            if (ModelState.IsValid)
            {
                db.AboutUs.Add(aboutUs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutUs);
        }

        // GET: Admin/AboutUs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutUs aboutUs = db.AboutUs.Find(id);
            if (aboutUs == null)
            {
                return HttpNotFound();
            }
            return View(aboutUs);
        }

        // POST: Admin/AboutUs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit( AboutUs aboutUs)
        {

            if (aboutUs.PhotoUpload != null)
            {
                try
                {
                    aboutUs.Photo = FileManager.Upload(aboutUs.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }

                if (ModelState.IsValid)
                {
                    db.AboutUs.Add(aboutUs);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                
                return View(aboutUs);
            }

            if (ModelState.IsValid)
            {
                db.Entry(aboutUs).State = EntityState.Modified;

                db.Entry(aboutUs).Property(s => s.Status == true).IsModified = false;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutUs);
        }

        // GET: Admin/AboutUs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutUs aboutUs = db.AboutUs.Find(id);
            if (aboutUs == null)
            {
                return HttpNotFound();
            }
            db.AboutUs.Remove(aboutUs);
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
