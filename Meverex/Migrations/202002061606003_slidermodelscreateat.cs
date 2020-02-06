namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class slidermodelscreateat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Tittle = c.String(),
                        Date = c.DateTime(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        Icon = c.String(),
                        IconUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sliders", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Sliders", new[] { "AuthorId" });
            DropTable("dbo.Sliders");
        }
    }
}
