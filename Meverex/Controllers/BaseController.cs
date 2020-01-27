using Meverex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meverex.Controllers
{
    public class BaseController : Controller
    {
        protected readonly FinalDbMeverex _context;
      public BaseController()
        {
            _context = new FinalDbMeverex();
            ViewBag.SocialLink = _context.SocialLinks.OrderBy(sl => sl.Orderby).ToList();
            ViewBag.Setting = _context.Settings.FirstOrDefault();


        }
    }
}