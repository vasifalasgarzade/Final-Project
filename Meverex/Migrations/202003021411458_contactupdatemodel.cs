namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactupdatemodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactUs", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactUs", "Status");
        }
    }
}
