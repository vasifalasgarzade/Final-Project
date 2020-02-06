namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createmodelspolitic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Politics",
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
            DropForeignKey("dbo.Politics", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Politics", new[] { "AuthorId" });
            DropTable("dbo.Politics");
        }
    }
}
