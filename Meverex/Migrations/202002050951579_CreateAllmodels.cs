namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAllmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(nullable: false, maxLength: 100),
                        Tittle = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.News", "AuthorId", "dbo.Authors");
            DropIndex("dbo.News", new[] { "CategoryId" });
            DropIndex("dbo.News", new[] { "AuthorId" });
            DropTable("dbo.Categories");
            DropTable("dbo.News");
            DropTable("dbo.Authors");
        }
    }
}
