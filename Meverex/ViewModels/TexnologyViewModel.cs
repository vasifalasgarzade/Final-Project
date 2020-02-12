using Meverex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meverex.ViewModels
{
    public class TexnologyViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Texnology> Texnologies { get; set; }
        public List<Author> Authors { get; set; }
    }
}