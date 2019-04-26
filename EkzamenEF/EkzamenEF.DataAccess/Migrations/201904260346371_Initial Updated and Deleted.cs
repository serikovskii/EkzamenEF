namespace EkzamenEF.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialUpdatedandDeleted : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deleteds",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DeletedObjectId = c.Guid(nullable: false),
                        DeletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Updateds",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UpdatedObjectId = c.Guid(nullable: false),
                        OldNameObject = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Updateds");
            DropTable("dbo.Deleteds");
        }
    }
}
