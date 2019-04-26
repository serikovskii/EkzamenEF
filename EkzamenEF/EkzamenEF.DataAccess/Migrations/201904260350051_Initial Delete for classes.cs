namespace EkzamenEF.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDeleteforclasses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "Delete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Streets", "Delete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Countries", "Delete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "Delete");
            DropColumn("dbo.Streets", "Delete");
            DropColumn("dbo.Cities", "Delete");
        }
    }
}
