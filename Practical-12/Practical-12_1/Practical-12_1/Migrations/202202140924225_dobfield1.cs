namespace Practical_12_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dobfield1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeTables", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeTables", "DOB", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
