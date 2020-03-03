using System.Data.Entity;
using Meverex.Models;

namespace Meverex.Data
{
    public class FinalDbMeverex : DbContext
    {
        public FinalDbMeverex() : base("FinalDbMeverex")
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
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Fashion> Fashions { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}