namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsSubscribedToNewsLetter");
        }
    }
}
