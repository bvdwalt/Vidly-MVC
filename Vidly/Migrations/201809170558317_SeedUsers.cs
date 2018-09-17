namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'05a2d2e2-406e-4188-b76c-3f9285370edd', N'admin@vidly.com', 0, N'AGSzv63eQoDPmVbyzuS48Rl50QzaI5sJiF6M+JkVOKTamQjNkhcIYFwwF9fF0XqGoA==', N'c1387ff2-8440-4af6-a610-7400fd7cde70', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'10c25047-772a-4fda-92b2-4c441d12e2f6', N'guest@vidly.com', 0, N'APgh3RFp4YbvHJOImNZVcXx6p+kv99r2uI2brhFais56DcyaNGdElWmZ5wCd9lwYFA==', N'f486a9c2-8b3d-4ffe-bcdf-489bf1cc0b25', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cffbbe12-f5ad-4a8d-9c28-a50f16cf59e9', N'CanManageMovie')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'05a2d2e2-406e-4188-b76c-3f9285370edd', N'cffbbe12-f5ad-4a8d-9c28-a50f16cf59e9')
                ");
        }

        public override void Down()
        {
        }
    }
}
