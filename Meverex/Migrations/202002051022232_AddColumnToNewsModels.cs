namespace Meverex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnToNewsModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "IsSmall", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "IsSmall");
        }
    }
}
