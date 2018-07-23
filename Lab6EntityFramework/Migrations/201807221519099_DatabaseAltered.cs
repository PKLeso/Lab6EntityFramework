namespace Lab6EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseAltered : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "TrainingID", "dbo.Trainings");
            DropIndex("dbo.Courses", new[] { "TrainingID" });
            RenameColumn(table: "dbo.Courses", name: "TrainingID", newName: "Training_TrainingID");
            AddColumn("dbo.Trainings", "CourseID", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "Training_TrainingID", c => c.Int());
            CreateIndex("dbo.Courses", "Training_TrainingID");
            AddForeignKey("dbo.Courses", "Training_TrainingID", "dbo.Trainings", "TrainingID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Training_TrainingID", "dbo.Trainings");
            DropIndex("dbo.Courses", new[] { "Training_TrainingID" });
            AlterColumn("dbo.Courses", "Training_TrainingID", c => c.Int(nullable: false));
            DropColumn("dbo.Trainings", "CourseID");
            RenameColumn(table: "dbo.Courses", name: "Training_TrainingID", newName: "TrainingID");
            CreateIndex("dbo.Courses", "TrainingID");
            AddForeignKey("dbo.Courses", "TrainingID", "dbo.Trainings", "TrainingID", cascadeDelete: true);
        }
    }
}
