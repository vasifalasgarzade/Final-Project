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
               
                Sliders = _context.Sliders.OrderByDescending(p => p.Id).Take(3).ToList(),
                Authors = _context.Authors.ToList(),
               Sports = _context.Sports.OrderByDescending(s=>s.Id).Take(7).ToList(),
                Categories = _context.Categories.ToList()

            };
            return View(model);
        }
        public ActionResult Fashion()
        {


            NewsViewModel model = new NewsViewModel
            {

                Sliders = _context.Sliders.OrderByDescending(p => p.Id).Take(3).ToList(),
                Authors = _context.Authors.ToList(),
                Fashions = _context.Fashions.OrderByDescending(s => s.Id).Take(7).ToList(),
                Categories = _context.Categories.ToList()

            };
            return View(model);
        }
        public ActionResult Travel()
        {
            
            NewsViewModel model = new NewsViewModel
            {

                Sliders = _context.Sliders.OrderByDescending(p => p.Id).Take(3).ToList(),
                Authors = _context.Authors.ToList(),
                MoreNews = _context.MoreNews.OrderByDescending(p => p.Id).Take(5).ToList(),
                Categories = _context.Categories.ToList()

            };
            return View(model);
        }
        public ActionResult Food()
        {
            NewsViewModel model = new NewsViewModel
            {

                Sliders = _context.Sliders.OrderByDescending(p => p.Id).Take(3).ToList(),
                Authors = _context.Authors.ToList(),
                Foods = _context.Foods.OrderByDescending(f => f.Id).Take(8).ToList(),
                Categories = _context.Categories.ToList()

            };
            return View(model);
        }
    }
}