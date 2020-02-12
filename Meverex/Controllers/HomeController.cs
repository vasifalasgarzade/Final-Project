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
                FashionItem = _context.FashionItems.FirstOrDefault(),
                FashionItems = _context.FashionItems.OrderByDescending(f=>f.Id).Take(3).ToList(),
                PopularNews = _context.PopularNews.Take(2).FirstOrDefault(),
                Populars = _context.PopularNews.OrderByDescending(p => p.Id).Take(3).ToList(),
                Authors = _context.Authors.ToList(),
                Categories = _context.Categories.ToList(),
                Politics = _context.Politics.OrderByDescending(p => p.Id).Take(2).ToList(),
                Sliders = _context.Sliders.OrderByDescending(p => p.Id).Take(3).ToList(),
                MostViews = _context.MostViews.OrderByDescending(p => p.Id).Take(2).ToList(),
                MoreNews = _context.MoreNews.OrderByDescending(p => p.Id).Take(5).ToList()





            };
            return View(model);
        }

       
    }
}