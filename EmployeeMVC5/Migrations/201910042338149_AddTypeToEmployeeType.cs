namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypeToEmployeeType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeTypes", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeTypes", "Type");
        }
    }
}
