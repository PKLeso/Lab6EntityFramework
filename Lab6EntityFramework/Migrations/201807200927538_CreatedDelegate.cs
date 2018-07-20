namespace Lab6EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDelegate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CourseCode = c.String(),
                        CourseName = c.String(),
                        CourseDescription = c.String(),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                        TrainingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Trainings", t => t.TrainingID, cascadeDelete: true)
                .Index(t => t.TrainingID);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        TrainingID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        Venue = c.String(),
                        Seats = c.String(),
                        RegistrationEndDate = c.DateTime(),
                        Cost = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.TrainingID);
            
            CreateTable(
                "dbo.Delegates",
                c => new
                    {
                        DelegateID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        CompanyName = c.String(),
                        DietaryID = c.Int(nullable: false),
                        RegistrationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DelegateID)
                .ForeignKey("dbo.Dietaries", t => t.DietaryID, cascadeDelete: true)
                .ForeignKey("dbo.Registrations", t => t.RegistrationID, cascadeDelete: true)
                .Index(t => t.DietaryID)
                .Index(t => t.RegistrationID);
            
            CreateTable(
                "dbo.Dietaries",
                c => new
                    {
                        DietaryID = c.Int(nullable: false, identity: true),
                        Description = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DietaryID);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        RegistrationID = c.Int(nullable: false, identity: true),
                        DateRegistered = c.DateTime(),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        TrainingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegistrationID)
                .ForeignKey("dbo.Trainings", t => t.TrainingID, cascadeDelete: true)
                .Index(t => t.TrainingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrations", "TrainingID", "dbo.Trainings");
            DropForeignKey("dbo.Delegates", "RegistrationID", "dbo.Registrations");
            DropForeignKey("dbo.Delegates", "DietaryID", "dbo.Dietaries");
            DropForeignKey("dbo.Courses", "TrainingID", "dbo.Trainings");
            DropIndex("dbo.Registrations", new[] { "TrainingID" });
            DropIndex("dbo.Delegates", new[] { "RegistrationID" });
            DropIndex("dbo.Delegates", new[] { "DietaryID" });
            DropIndex("dbo.Courses", new[] { "TrainingID" });
            DropTable("dbo.Registrations");
            DropTable("dbo.Dietaries");
            DropTable("dbo.Delegates");
            DropTable("dbo.Trainings");
            DropTable("dbo.Courses");
        }
    }
}
