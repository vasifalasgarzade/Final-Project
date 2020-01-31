using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meverex.Controllers
{
    public class TexnologyController : BaseController
    {
        // GET: Texnology
        public ActionResult Index()
        {
            
            return View(_context.Texnologies.ToList());
        }
      
    }
}