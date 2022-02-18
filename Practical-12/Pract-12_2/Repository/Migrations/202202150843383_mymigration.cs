namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mymigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DesignationName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        MobileNumber = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false, maxLength: 100),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Designation_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.Designation_ID)
                .Index(t => t.Designation_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Designation_ID", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "Designation_ID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Designations");
        }
    }
}
