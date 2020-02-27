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
        public virtual ICollection<News> News { get; set; }
        public List<Sport> Sports { get; set; }
        public List<Fashion> Fashions { get; set; }
        public List<MoreNew> MoreNews { get; set; }
        public List<Food> Foods { get; set; }
      
    }
}