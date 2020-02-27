using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Meverex.Models;

namespace Meverex.ViewModels
{
    public class AboutViewModel
    {
        public List<Slider> Sliders { get; set; }
        public AboutUs AboutUs { get; set; }
        public List<Author> Authors { get; set; }

    }
}