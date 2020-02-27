using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meverex.ViewModels;

namespace Meverex.Controllers
{
    public class PostController : BaseController
    {
        // GET: Post
        public ActionResult Index()
        {
            PostViewModel model = new PostViewModel
            {
                Posts = _context.Posts.OrderByDescending(p=>p.Id).ToList(),
                News = _context.News.Take(2).OrderByDescending(n=>n.Id).ToList()
            };
            return View(model);
        }
    }
}