namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allmodelsupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.AboutUs", "Photo", c => c.String(maxLength: 100));
            AlterColumn("dbo.AboutUs", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.FashionItems", "Photo", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.FashionItems", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.FashionItems", "Description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.FashionItems", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Categories", "Color", c => c.String(maxLength: 200));
            AlterColumn("dbo.Fashions", "Photo", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Fashions", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Fashions", "Description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Fashions", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Fashions", "CreateAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Foods", "Photo", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Foods", "Tittle", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Foods", "Description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Foods", "CreateAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.MoreNews", "Photo", c => c.String(maxLength: 200));
            AlterColumn("dbo.MoreNews", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.MoreNews", "Description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.MoreNews", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.News", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.News", "Description", c => c.String(nullable: false, maxLength: 400));
            AlterColumn("dbo.News", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.PopularNews", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.PopularNews", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.PopularNews", "Description", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.PopularNews", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Sports", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Sports", "Tittle", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Sports", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Sports", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Sports", "CreateAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Politics", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Politics", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Politics", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Politics", "Icon", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Politics", "IconUrl", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Sliders", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Sliders", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Sliders", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Sliders", "Icon", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Sliders", "IconUrl", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ContactUs", "Tittle", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ContactUs", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ContactUs", "Desc", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.ContactUs", "Number", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ContactUs", "Location", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Galleries", "AuthorComment", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Galleries", "Photo", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.MostViews", "Photo", c => c.String(maxLength: 200));
            AlterColumn("dbo.MostViews", "Tittle", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.MostViews", "Description", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.MostViews", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Posts", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Posts", "Photo", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Posts", "AuthorComment", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Posts", "Text", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Posts", "Commnet", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Texnologies", "BtnUrl", c => c.String(maxLength: 50));
            AlterColumn("dbo.Texnologies", "Photo", c => c.String(maxLength: 150));
            AlterColumn("dbo.Texnologies", "Tittle", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Texnologies", "Tittle", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Texnologies", "Photo", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Texnologies", "BtnUrl", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Posts", "Commnet", c => c.String());
            AlterColumn("dbo.Posts", "Text", c => c.String());
            AlterColumn("dbo.Posts", "AuthorComment", c => c.String());
            AlterColumn("dbo.Posts", "Photo", c => c.String());
            AlterColumn("dbo.Posts", "Description", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
            AlterColumn("dbo.MostViews", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MostViews", "Description", c => c.String());
            AlterColumn("dbo.MostViews", "Tittle", c => c.String());
            AlterColumn("dbo.MostViews", "Photo", c => c.String());
            AlterColumn("dbo.Galleries", "Photo", c => c.String());
            AlterColumn("dbo.Galleries", "AuthorComment", c => c.String());
            AlterColumn("dbo.ContactUs", "Location", c => c.String());
            AlterColumn("dbo.ContactUs", "Number", c => c.String());
            AlterColumn("dbo.ContactUs", "Desc", c => c.String());
            AlterColumn("dbo.ContactUs", "Photo", c => c.String());
            AlterColumn("dbo.ContactUs", "Tittle", c => c.String());
            AlterColumn("dbo.Sliders", "IconUrl", c => c.String());
            AlterColumn("dbo.Sliders", "Icon", c => c.String());
            AlterColumn("dbo.Sliders", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sliders", "Tittle", c => c.String());
            AlterColumn("dbo.Sliders", "Photo", c => c.String());
            AlterColumn("dbo.Politics", "IconUrl", c => c.String());
            AlterColumn("dbo.Politics", "Icon", c => c.String());
            AlterColumn("dbo.Politics", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Politics", "Tittle", c => c.String());
            AlterColumn("dbo.Politics", "Photo", c => c.String());
            AlterColumn("dbo.Sports", "CreateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sports", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sports", "Description", c => c.String());
            AlterColumn("dbo.Sports", "Tittle", c => c.String());
            AlterColumn("dbo.Sports", "Photo", c => c.String());
            AlterColumn("dbo.PopularNews", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PopularNews", "Description", c => c.String());
            AlterColumn("dbo.PopularNews", "Tittle", c => c.String());
            AlterColumn("dbo.PopularNews", "Photo", c => c.String());
            AlterColumn("dbo.News", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.News", "Description", c => c.String());
            AlterColumn("dbo.News", "Tittle", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.MoreNews", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MoreNews", "Description", c => c.String());
            AlterColumn("dbo.MoreNews", "Tittle", c => c.String());
            AlterColumn("dbo.MoreNews", "Photo", c => c.String());
            AlterColumn("dbo.Foods", "CreateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Foods", "Description", c => c.String());
            AlterColumn("dbo.Foods", "Tittle", c => c.String());
            AlterColumn("dbo.Foods", "Photo", c => c.String());
            AlterColumn("dbo.Fashions", "CreateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Fashions", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Fashions", "Description", c => c.String());
            AlterColumn("dbo.Fashions", "Tittle", c => c.String());
            AlterColumn("dbo.Fashions", "Photo", c => c.String());
            AlterColumn("dbo.Categories", "Color", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.FashionItems", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FashionItems", "Description", c => c.String());
            AlterColumn("dbo.FashionItems", "Tittle", c => c.String());
            AlterColumn("dbo.FashionItems", "Photo", c => c.String());
            AlterColumn("dbo.Authors", "Name", c => c.String());
            AlterColumn("dbo.AboutUs", "Tittle", c => c.String());
            AlterColumn("dbo.AboutUs", "Photo", c => c.String());
            DropColumn("dbo.Settings", "Status");
        }
    }
}
