using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meverex.ViewModels;

namespace Meverex.Controllers
{
    public class NewsController : BaseController
    {
        // GET: News
       
        public ActionResult Sports()
        {
            NewsViewModel model = new NewsViewModel
            {
                Texnologies = _context.Texnologies.OrderByDescending(t => t.Id).ToList(),
                Sliders = _context.Sliders.OrderByDescending(p => p.Id).Take(3).ToList(),
                Authors = _context.Authors.ToList(),
               
                Categories = _context.Categories.ToList()

            };
            return View(model);
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