namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtablemostview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MostViews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        Photo = c.String(),
                        Tittle = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.AuthorId);
            
            AddColumn("dbo.News", "MostView_Id", c => c.Int());
            CreateIndex("dbo.News", "MostView_Id");
            AddForeignKey("dbo.News", "MostView_Id", "dbo.MostViews", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "MostView_Id", "dbo.MostViews");
            DropForeignKey("dbo.MostViews", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.MostViews", "AuthorId", "dbo.Authors");
            DropIndex("dbo.MostViews", new[] { "AuthorId" });
            DropIndex("dbo.MostViews", new[] { "CategoryId" });
            DropIndex("dbo.News", new[] { "MostView_Id" });
            DropColumn("dbo.News", "MostView_Id");
            DropTable("dbo.MostViews");
        }
    }
}
