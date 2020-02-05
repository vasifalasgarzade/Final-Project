using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meverex.ViewModels;

namespace Meverex.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                News = _context.News.OrderByDescending(n => n.Id).Take(7).ToList(),
                NewsItem = _context.News.FirstOrDefault(n=>n.CategoryId==8),
                OneSlider= _context.News.FirstOrDefault(one=>one.CategoryId==1),
                Authors = _context.Authors.ToList(),
                Categories = _context.Categories.ToList()

                

            };
            return View(model);
        }

       
    }
}