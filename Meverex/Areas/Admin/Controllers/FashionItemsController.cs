using System;

using System.Data.Entity;
using System.Linq;
using System.Net;

using System.Web.Mvc;
using Meverex.Areas.Admin.Filters;
using Meverex.Data;
using Meverex.Helper;
using Meverex.Models;

namespace Meverex.Areas.Admin.Controllers
{
    [AdminAuth]
    public class FashionItemsController : Controller
    {
        private FinalDbMeverex db = new FinalDbMeverex();

        // GET: Admin/FashionItems
        public ActionResult Index()
        {
            var fashionItems = db.FashionItems.Include(f => f.Author).Include(f => f.Category);
            return View(fashionItems.ToList());
        }

       

        // GET: Admin/FashionItems/Create
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Admin/FashionItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,CategoryId,AuthorId,PhotoUpload,Tittle,Description,Date,Status")] FashionItem fashionItem)
        {
            try
            {
                fashionItem.Photo = FileManager.Upload(fashionItem.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);
            }
            if (ModelState.IsValid)
            {
                db.FashionItems.Add(fashionItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fashionItem);
        }

        // GET: Admin/FashionItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FashionItem fashionItem = db.FashionItems.Find(id);
            if (fashionItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", fashionItem.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", fashionItem.CategoryId);
            return View(fashionItem);
        }

        // POST: Admin/FashionItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,CategoryId,AuthorId,Photo,Tittle,Description,Date,Status,PhotoUpload")] FashionItem fashionItem)
        {
            try
            {
                fashionItem.Photo = FileManager.Upload(fashionItem.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);
            }
            if (ModelState.IsValid)
            {
                db.Entry(fashionItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "Name", fashionItem.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", fashionItem.CategoryId);

            return View(fashionItem);
        }

        // GET: Admin/FashionItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FashionItem fashionItem = db.FashionItems.Find(id);
            if (fashionItem == null)
            {
                return HttpNotFound();
            }
            db.FashionItems.Remove(fashionItem);
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
