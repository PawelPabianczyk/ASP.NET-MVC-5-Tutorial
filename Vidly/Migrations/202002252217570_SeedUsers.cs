namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8904bce6-6d0c-4489-9f0a-9ec62b02e14c', N'guest@vidly.com', 0, N'AH04t14t745rDIZwHHp+v5fWROb7V6PeaxgTcj5uYLdSkjXX8fthIHZmCrnb085W1w==', N'afb29553-ed9a-43b1-b3ce-d7954092a438', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e81b8669-bea6-46a6-a212-855d50892bff', N'admin@vidly.com', 0, N'ABZf5DlLasHu9n2g/ZcfRMSveZI1i5+DfQ9KeKYFiWOcbW1OXpBHoh7lJ3FPe4uDrg==', N'5a5b35f5-6582-4253-8bc4-7711317194f9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'434ee497-459c-4e06-95eb-9ab6971554c2', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e81b8669-bea6-46a6-a212-855d50892bff', N'434ee497-459c-4e06-95eb-9ab6971554c2')

");
        }
        
        public override void Down()
        {
        }
    }
}
