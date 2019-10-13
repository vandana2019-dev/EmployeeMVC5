namespace EmployeeMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e438a3e2-9af3-49b0-a5a4-c7e3c367979a', N'admin@gmail.com', 0, N'AJTsAVgB0w5TPfPTt5C7CYfT21RO4BBrhLsHZ//2YXC12mbPhlg4SRZrjr8DsVh9oA==', N'4001676e-5aaa-42df-8df1-61574aacf236', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
                INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'efe7f3ca-f3c2-42cd-83bf-0af5fa9e6c28', N'guest@gmail.com', 0, N'AEp7Tg02ti6F9OC4RvgIznAFQA5Tre+3mPWuAY2+F8MnfsPUoWdcN0MoSNp08Px41A==', N'2991a365-3526-44c5-8213-88188e800caf', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4810d455-ed39-49c1-9444-c6b6bbdb3cd1', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e438a3e2-9af3-49b0-a5a4-c7e3c367979a', N'4810d455-ed39-49c1-9444-c6b6bbdb3cd1')
                ");

        }
        
        public override void Down()
        {
        }
    }
}
