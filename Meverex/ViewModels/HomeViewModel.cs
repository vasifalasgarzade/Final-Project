using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Meverex.Models;

namespace Meverex.ViewModels
{
    public class HomeViewModel
    {
        public List<News> News { get; set; }
        public News NewsItem { get; set; }
        public News OneSlider { get; set; }
        public List<Author> Authors { get; set; }
        public List<Category> Categories { get; set; }

    }
}