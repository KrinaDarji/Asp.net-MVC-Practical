namespace Practical_12_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dobfield2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeTables", "DOB", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeTables", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
