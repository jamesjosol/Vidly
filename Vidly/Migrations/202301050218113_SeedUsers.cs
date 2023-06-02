namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ad65fc3a-0938-43fd-833a-104f27f94f1f', N'jamesjosol@email.com', 0, N'AH5eY4oIXq9LhlcECKxhFbW+Ndw8LQ4k6J92Eug0qRFPQeDQUNpcRVEmW7T+9TIJ9g==', N'6804ebe5-a49e-42c4-8e99-edac70edd080', NULL, 0, 0, NULL, 1, 0, N'jamesjosol@email.com')
            INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'dd54db4c-1e80-48eb-86c3-225eb227fc7a', N'admin@vidly.com', 0, N'ANF8j9wZ6iV3pPTbjizqU8gVPk8cr0MDkkPySc2r+soEC667Gn3JFOjZPuTgk8HxhA==', N'28eea61b-88a8-4b44-8187-bf20772fb3a6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'898c9bcb-ef3f-4b23-93b0-911abcf4c7f2', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dd54db4c-1e80-48eb-86c3-225eb227fc7a', N'898c9bcb-ef3f-4b23-93b0-911abcf4c7f2')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
