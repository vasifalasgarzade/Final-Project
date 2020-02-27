using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meverex.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<News> News { get; set; }
        public List<FashionItem> FashionItems { get; set; }
        public List<PopularNews> PopularNews { get; set; }
        public List<Politic> Politics { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Sport> Sports { get; set; }
        public List<Fashion> Fashions { get; set; }





    }
}