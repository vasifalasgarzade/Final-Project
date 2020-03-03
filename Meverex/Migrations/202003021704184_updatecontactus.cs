namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecontactus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactUs", "OrderBy", c => c.Int(nullable: false));
            DropColumn("dbo.ContactUs", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactUs", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.ContactUs", "OrderBy");
        }
    }
}
