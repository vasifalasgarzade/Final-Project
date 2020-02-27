using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Meverex.Models;

namespace Meverex.ViewModels
{
    public class ContactViewModel
    {
        public List<SocialLink> SocialLinks { get; set; }
        public ContactUs ContactUs { get; set; }

    }
}