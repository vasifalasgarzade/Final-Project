namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactUsPropertyModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactUs", "Photo", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactUs", "Photo", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
