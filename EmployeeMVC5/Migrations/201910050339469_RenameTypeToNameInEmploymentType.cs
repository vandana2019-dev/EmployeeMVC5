namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTypeToNameInEmploymentType : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "EmployeeTypeId", newName: "EmploymentTypeId");
            RenameIndex(table: "dbo.Employees", name: "IX_EmployeeTypeId", newName: "IX_EmploymentTypeId");
            AddColumn("dbo.EmploymentTypes", "Name", c => c.String(nullable: false));
            DropColumn("dbo.EmploymentTypes", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmploymentTypes", "Type", c => c.String(nullable: false));
            DropColumn("dbo.EmploymentTypes", "Name");
            RenameIndex(table: "dbo.Employees", name: "IX_EmploymentTypeId", newName: "IX_EmployeeTypeId");
            RenameColumn(table: "dbo.Employees", name: "EmploymentTypeId", newName: "EmployeeTypeId");
        }
    }
}
