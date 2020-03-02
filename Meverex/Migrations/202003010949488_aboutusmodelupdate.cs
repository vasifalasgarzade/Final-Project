namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboutusmodelupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AboutUs", "Body", c => c.String(nullable: false, storeType: "ntext"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AboutUs", "Body", c => c.String());
        }
    }
}
