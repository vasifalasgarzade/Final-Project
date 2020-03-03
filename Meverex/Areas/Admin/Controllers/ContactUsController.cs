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
    public class ContactUsController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/ContactUs
        public ActionResult Index()
        {
            return View(db.ContactUs.ToList());
        }

       

        // GET: Admin/ContactUs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ContactUs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,Tittle,PhotoUpload,Desc,Number,Location,OrderBy")] ContactUs contactUs)
        {
            contactUs.OrderBy = db.ContactUs.Count();

            try
            {
                contactUs.Photo = FileManager.Upload(contactUs.PhotoUpload);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PhotoUpload", ex.Message);
            }

            if (ModelState.IsValid)
            {
                contactUs.OrderBy = db.ContactUs.Count() + 1;

                db.ContactUs.Add(contactUs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

           
            return View(contactUs);
        }

        // GET: Admin/ContactUs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactUs contactUs = db.ContactUs.Find(id);
            if (contactUs == null)
            {
                return HttpNotFound();
            }
            return View(contactUs);
        }

        // POST: Admin/ContactUs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,Tittle,Photo,PhotoUpload,Desc,Number,Location,OrderBy")] ContactUs contactUs)
        {

            if (contactUs.PhotoUpload != null)
            {
                try
                {
                    FileManager.Delete(contactUs.Photo);
                    contactUs.Photo = FileManager.Upload(contactUs.PhotoUpload);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("PhotoUpload", ex.Message);
                }
            }

            if (ModelState.IsValid)
            {
                db.Entry(contactUs).State = EntityState.Modified;
                db.Entry(contactUs).Property(c => c.OrderBy).IsModified = false;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        
            return View(contactUs);

        }

        // GET: Admin/ContactUs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactUs contactUs = db.ContactUs.Find(id);
            if (contactUs == null)
            {
                return HttpNotFound();
            }
            db.ContactUs.Remove(contactUs);
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
