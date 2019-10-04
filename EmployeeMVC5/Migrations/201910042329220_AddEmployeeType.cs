namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "EmployeeTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Employees", "EmployeeTypeId");
            AddForeignKey("dbo.Employees", "EmployeeTypeId", "dbo.EmployeeTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "EmployeeTypeId", "dbo.EmployeeTypes");
            DropIndex("dbo.Employees", new[] { "EmployeeTypeId" });
            DropColumn("dbo.Employees", "EmployeeTypeId");
            DropTable("dbo.EmployeeTypes");
        }
    }
}
