using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meverex.ViewModels;

namespace Meverex.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            AboutViewModel model = new AboutViewModel
            {
                Sliders = _context.Sliders.OrderByDescending(p => p.Id).Take(3).ToList(),
                AboutUs = _context.AboutUs.FirstOrDefault(),
                Authors = _context.Authors.ToList()

            };
            
            return View(model);
        }
    }
}