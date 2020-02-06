namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fashionitemsrealtionsnewsmodels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "FashionId", c => c.Int(nullable: false));
            AddColumn("dbo.News", "FashionItem_Id", c => c.Int());
            CreateIndex("dbo.News", "FashionItem_Id");
            AddForeignKey("dbo.News", "FashionItem_Id", "dbo.FashionItems", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "FashionItem_Id", "dbo.FashionItems");
            DropIndex("dbo.News", new[] { "FashionItem_Id" });
            DropColumn("dbo.News", "FashionItem_Id");
            DropColumn("dbo.News", "FashionId");
        }
    }
}
