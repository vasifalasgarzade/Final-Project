using System.Collections.Generic;
using Meverex.Models;

namespace Meverex.ViewModels
{
    public class ContactViewModel
    {
        public List<SocialLink> SocialLinks { get; set; }
        public ContactUs ContactUs { get; set; }
        public ContactMessage Message { get; set; }
    }
}