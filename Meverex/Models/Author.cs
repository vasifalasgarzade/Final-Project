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
      
        public List<News> News { get; set; }
        public List<FashionItem> FashionItems { get; set; }
        public List<PopularNews> PopularNews { get; set; }
        public List<Politic> Politics { get; set; }



    }
}