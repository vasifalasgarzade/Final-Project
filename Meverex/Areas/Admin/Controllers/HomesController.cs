using Meverex.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meverex.Areas.Admin.Controllers
{
    [AdminAuth]
    public class HomesController : Controller
    {
        // GET: Admin/Homes
        public ActionResult Index()
        {
            return View();
        }
    }
}