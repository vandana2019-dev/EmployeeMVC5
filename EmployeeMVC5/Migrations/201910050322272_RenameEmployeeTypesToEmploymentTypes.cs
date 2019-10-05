namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameEmployeeTypesToEmploymentTypes : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmployeeTypes", newName: "EmploymentTypes");
        }

        public override void Down()
        {
            RenameTable(name: "dbo.EmploymentTypes", newName: "EmployeeTypes");
        }
    }

}
