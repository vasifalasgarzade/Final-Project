namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtablemorenew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MoreNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Photo = c.String(),
                        Tittle = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MoreNews", "CategoryId", "dbo.Categories");
            DropIndex("dbo.MoreNews", new[] { "CategoryId" });
            DropTable("dbo.MoreNews");
        }
    }
}
