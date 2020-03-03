using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Meverex.Areas.Admin.Models;
using Meverex.Data;

namespace Meverex.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/login
        private readonly FinalDbMeverex db;

        public LoginController()
        {
            db = new FinalDbMeverex();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            Meverex.Models.Admin admin = db.Admins.FirstOrDefault(a => a.Email == login.Email);

            if (admin != null && Crypto.VerifyHashedPassword(admin.Password, login.Password))
            {
                admin.Token = Guid.NewGuid().ToString();

                db.SaveChanges();

                HttpCookie cookie = new HttpCookie("token", admin.Token)
                {
                    HttpOnly = true,
                    Expires = login.RememberMe ? DateTime.Now.AddYears(1) : DateTime.MinValue
                };

                Response.Cookies.Add(cookie);

                return RedirectToAction("index", "Homes");
            }

            ModelState.AddModelError("", "E-poçt və ya şifrə yalnışdır");

            return View(login);
        }

        [HttpGet]
        public ActionResult Logout()
        {
            HttpCookie cookie = Request.Cookies.Get("token");

            if (cookie == null)
            {
                return RedirectToAction("login", new { type = 1 });
            }

            Meverex.Models.Admin admin = db.Admins.FirstOrDefault(a => a.Token == cookie.Value);

            if (admin == null)
            {
                return RedirectToAction("index", new { type = 2 });
            }

            admin.Token = null;
            db.SaveChanges();

            Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);

            return RedirectToAction("index", new { type = 3 });
        }
    }
}