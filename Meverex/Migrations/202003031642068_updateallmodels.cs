namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateallmodels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FashionItems", "Photo", c => c.String(maxLength: 100));
            AlterColumn("dbo.Fashions", "Photo", c => c.String(maxLength: 100));
            AlterColumn("dbo.Foods", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.News", "Photo", c => c.String(maxLength: 100));
            AlterColumn("dbo.PopularNews", "Photo", c => c.String(maxLength: 200));
            AlterColumn("dbo.Sports", "Photo", c => c.String(maxLength: 200));
            AlterColumn("dbo.Politics", "Photo", c => c.String(maxLength: 200));
            AlterColumn("dbo.Sliders", "Photo", c => c.String(maxLength: 200));
            AlterColumn("dbo.Galleries", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Posts", "Photo", c => c.String(maxLength: 300));
            AlterColumn("dbo.Settings", "HeaderLogo", c => c.String(maxLength: 100));
            AlterColumn("dbo.Settings", "FooterLogo", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Settings", "FooterLogo", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Settings", "HeaderLogo", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "Photo", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Galleries", "Photo", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Sliders", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Politics", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Sports", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.PopularNews", "Photo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.News", "Photo", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Foods", "Photo", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Fashions", "Photo", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.FashionItems", "Photo", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
