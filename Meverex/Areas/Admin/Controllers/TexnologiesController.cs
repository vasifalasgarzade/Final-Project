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
    public class TexnologiesController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/Texnologies
        public ActionResult Index()
        {
            return View(db.Texnologies.ToList());
        }

      

        // GET: Admin/Texnologies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Texnologies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,BtnName,BtnUrl,PhotoUpload,Tittle,Description,Status")] Texnology texnology)
        {
            try
            {
                texnology.Photo = FileManager.Upload(texnology.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);


            }
            if (ModelState.IsValid)
            {
                db.Texnologies.Add(texnology);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(texnology);
        }

        // GET: Admin/Texnologies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Texnology texnology = db.Texnologies.Find(id);
            if (texnology == null)
            {
                return HttpNotFound();
            }
            return View(texnology);
        }

        // POST: Admin/Texnologies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,BtnName,BtnUrl,Photo,Tittle,Description,Status,PhotoUpload")] Texnology texnology)
        {
            try
            {
                texnology.Photo = FileManager.Upload(texnology.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);


            }
            if (ModelState.IsValid)
            {
                db.Entry(texnology).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(texnology);
        }

        // GET: Admin/Texnologies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Texnology texnology = db.Texnologies.Find(id);
            if (texnology == null)
            {
                return HttpNotFound();
            }
            db.Texnologies.Remove(texnology);
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
