namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allmodelsupdate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactMessages", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Texnologies", "Date", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Texnologies", "Date");
            DropColumn("dbo.ContactMessages", "Date");
        }
    }
}
