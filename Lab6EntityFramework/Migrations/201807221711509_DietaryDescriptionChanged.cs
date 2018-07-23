namespace Lab6EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DietaryDescriptionChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dietaries", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dietaries", "Description", c => c.Int(nullable: false));
        }
    }
}
