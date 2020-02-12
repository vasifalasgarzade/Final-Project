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
        public FashionItem FashionItem { get; set; }
        public List<FashionItem> FashionItems { get; set; }
        public PopularNews PopularNews { get; set; }
        public List<PopularNews> Populars { get; set; }
        public List<Author> Authors { get; set; }
        public List<Category> Categories { get; set; }
        public List<Politic> Politics { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<MostView> MostViews { get; set; }
        public List<MoreNew> MoreNews { get; set; }

    }
}