namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createmodelfasions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.News", "FashionItem_Id", "dbo.FashionItems");
            DropIndex("dbo.News", new[] { "FashionItem_Id" });
            CreateTable(
                "dbo.Fashions",
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
                        CreateAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.AuthorId);
            
            DropColumn("dbo.News", "FashionItem_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.News", "FashionItem_Id", c => c.Int());
            DropForeignKey("dbo.Fashions", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Fashions", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Fashions", new[] { "AuthorId" });
            DropIndex("dbo.Fashions", new[] { "CategoryId" });
            DropTable("dbo.Fashions");
            CreateIndex("dbo.News", "FashionItem_Id");
            AddForeignKey("dbo.News", "FashionItem_Id", "dbo.FashionItems", "Id");
        }
    }
}
