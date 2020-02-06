namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fahsionitemsmodelcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FashionItems",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FashionItems", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.FashionItems", "AuthorId", "dbo.Authors");
            DropIndex("dbo.FashionItems", new[] { "AuthorId" });
            DropIndex("dbo.FashionItems", new[] { "CategoryId" });
            DropTable("dbo.FashionItems");
        }
    }
}
