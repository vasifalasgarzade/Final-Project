using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meverex.ViewModels;

namespace Meverex.Controllers
{
    public class ContactController : BaseController
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactViewModel model = new ContactViewModel
            {
                SocialLinks = _context.SocialLinks.OrderBy(s=>s.Orderby).ToList(),
                ContactUs =_context.ContactUs.FirstOrDefault()
            };
            return View(model);
        }
    }
}