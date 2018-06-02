namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            SET IDENTITY_INSERT [dbo].[Users] ON
            INSERT INTO [dbo].[Users] ([Id], [UserNmae], [Password], [Note]) VALUES (1, N'Admin', N'NUwXl6tm8XQ6urZrakAqYw==', N'Admin')
            INSERT INTO [dbo].[Users] ([Id], [UserNmae], [Password], [Note]) VALUES (2, N'Chamroeun', N'NUwXl6tm8XQ6urZrakAqYw==', N'')
            SET IDENTITY_INSERT [dbo].[Users] OFF
            ");
        }
        
        public override void Down()
        {
        }
    }
}
