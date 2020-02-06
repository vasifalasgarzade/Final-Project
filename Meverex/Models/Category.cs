using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meverex.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }


        public List<PopularNews> Populars { get; set; }
        public List<FashionItem> FashionItems { get; set; }
        public List<News> News { get; set; }
    }
}