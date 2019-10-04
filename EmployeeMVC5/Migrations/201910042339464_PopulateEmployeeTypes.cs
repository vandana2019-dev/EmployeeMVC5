namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEmployeeTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EmployeeTypes (Id, Type, DurationInMonths) VALUES (1, 'Volunteer', 1)");
            Sql("INSERT INTO EmployeeTypes (Id, Type, DurationInMonths) VALUES (2, 'First Contract' , 3)");
            Sql("INSERT INTO EmployeeTypes (Id, Type, DurationInMonths) VALUES (3, 'Extended Contract', 6)");
            Sql("INSERT INTO EmployeeTypes (Id, Type, DurationInMonths) VALUES (4, 'Full time', 24)");
        }
        
        public override void Down()
        {
        }
    }
}
