﻿using System;
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
    public class ContactMessagesController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/ContactMessages
        public ActionResult Index()
        {
            return View(db.ContactMessages.ToList());
        }

        // GET: Admin/ContactMessages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMessage contactMessage = db.ContactMessages.Find(id);
            if (contactMessage == null)
            {
                return HttpNotFound();
            }
            return View(contactMessage);
        }

        // GET: Admin/ContactMessages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ContactMessages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone,Email,Desc,Status")] ContactMessage contactMessage)
        {
            if (ModelState.IsValid)
            {
                db.ContactMessages.Add(contactMessage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactMessage);
        }

        // GET: Admin/ContactMessages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMessage contactMessage = db.ContactMessages.Find(id);
            if (contactMessage == null)
            {
                return HttpNotFound();
            }
            return View(contactMessage);
        }

        // POST: Admin/ContactMessages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Phone,Email,Desc,Status")] ContactMessage contactMessage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactMessage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactMessage);
        }

        // GET: Admin/ContactMessages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMessage contactMessage = db.ContactMessages.Find(id);
            if (contactMessage == null)
            {
                return HttpNotFound();
            }
            return View(contactMessage);
        }

        // POST: Admin/ContactMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactMessage contactMessage = db.ContactMessages.Find(id);
            db.ContactMessages.Remove(contactMessage);
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
