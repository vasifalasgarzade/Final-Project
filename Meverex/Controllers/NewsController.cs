using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meverex.Controllers
{
    public class NewsController : BaseController
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sports()
        {
            return View();
        }
        public ActionResult Fashion()
        {
            return View();
        }
        public ActionResult Travel()
        {
            return View();
        }
        public ActionResult Food()
        {
            return View();
        }
    }
}