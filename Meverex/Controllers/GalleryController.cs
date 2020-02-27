using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meverex.Models;

namespace Meverex.Controllers
{
    public class GalleryController : BaseController
    {
        // GET: Gallery
        public ActionResult Index()
        {

            return View(_context.Galleries.OrderByDescending(g=>g.Id).ToList());
        }
    }
}