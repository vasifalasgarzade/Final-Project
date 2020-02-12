using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Meverex.Models;

namespace Meverex.Data
{
    public class FinalDbMeverex :DbContext
    {
        public FinalDbMeverex(): base("FinalDbMeverex")
        {
        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Texnology> Texnologies { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FashionItem> FashionItems { get; set; }
        public DbSet<PopularNews> PopularNews { get; set; }
        public DbSet<Politic> Politics { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<MostView> MostViews { get; set; }
        public DbSet<MoreNew> MoreNews { get; set; }
    }
  
}