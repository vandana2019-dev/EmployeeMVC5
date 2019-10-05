namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToEmployeeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeTypes", "Type", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeTypes", "Type", c => c.String());
        }
    }
}
