using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meverex.ViewModels;


namespace Meverex.Controllers
{
    public class TexnologyController : BaseController
    {
        // GET: Texnology
        public ActionResult Index()
        {
            TexnologyViewModel model = new TexnologyViewModel
            {
                Texnologies = _context.Texnologies.OrderByDescending(t=>t.Id).ToList(),
                Sliders = _context.Sliders.OrderByDescending(p => p.Id).Take(3).ToList(),
                Authors = _context.Authors.ToList()


            };
            
            return View(model);
        }
      
    }
}