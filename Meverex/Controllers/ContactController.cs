using System.Linq;
using System.Web.Mvc;
using Meverex.Data;
using Meverex.Models;
using Meverex.ViewModels;

namespace Meverex.Controllers
{
    public class ContactController : BaseController
    {
        private readonly FinalDbMeverex db;

        public ContactController()
        {
            db = new FinalDbMeverex();
        }

        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            ContactViewModel model = new ContactViewModel
            {
                SocialLinks = _context.SocialLinks.OrderBy(s => s.Orderby).ToList(),
                ContactUs = _context.ContactUs.FirstOrDefault()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Index(ContactMessage message)
        {
            ContactViewModel model = new ContactViewModel
            {
                SocialLinks = _context.SocialLinks.OrderBy(s => s.Orderby).ToList(),
                ContactUs = _context.ContactUs.FirstOrDefault(),
                Message = new ContactMessage
                {
                    Name = message.Name,
                    Phone = message.Phone,
                    Email = message.Email,
                    Desc = message.Desc
                }
            };

            if (ModelState.IsValid)
            {
                message.Status = true;
                db.ContactMessages.Add(message);
                db.SaveChanges();
                return RedirectToAction("index");
            }

            return View(model);
        }
    }
}