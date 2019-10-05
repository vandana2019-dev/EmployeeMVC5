namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDataFromEmploymentType : DbMigration
    {
        public override void Up()
        {
            // Delete all the exising data from the table
            Sql("DELETE from 'EmploymentTypes'");
        }
        
        public override void Down()
        {
        }
    }
}
