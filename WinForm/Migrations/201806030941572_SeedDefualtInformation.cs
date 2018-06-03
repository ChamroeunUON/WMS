namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDefualtInformation : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT INTO [dbo].[Customers] ([CusId], [Name], [Sex], [Address], [Phone], [Email], [Note]) VALUES (1, N'Kok Dara', N'Male', N'N/A', N'N/A', N'N/A', N'N/A')
SET IDENTITY_INSERT [dbo].[Customers] OFF
");
            Sql(@"

SET IDENTITY_INSERT [dbo].[Measures] ON
INSERT INTO [dbo].[Measures] ([Id], [Name], [Note]) VALUES (1, N'Can', N'')
INSERT INTO [dbo].[Measures] ([Id], [Name], [Note]) VALUES (2, N'Case', N'')
INSERT INTO [dbo].[Measures] ([Id], [Name], [Note]) VALUES (3, N'Bottle', N'')
INSERT INTO [dbo].[Measures] ([Id], [Name], [Note]) VALUES (4, N'Kg', N'')
SET IDENTITY_INSERT [dbo].[Measures] OFF
");
            Sql(@"
SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT INTO [dbo].[Categories] ([Id], [Name], [Note]) VALUES (1, N'Cast', N'Note')
SET IDENTITY_INSERT [dbo].[Categories] OFF
");
            Sql(@"
SET IDENTITY_INSERT [dbo].[Warehouses] ON
INSERT INTO [dbo].[Warehouses] ([Id], [NameEN], [NameKH], [Phone], [Fax], [Address], [Note], [Email]) VALUES (1, N'Warehouse1', N'ឃ្លាំង១', N'', N'', N'', N'', N'')
INSERT INTO [dbo].[Warehouses] ([Id], [NameEN], [NameKH], [Phone], [Fax], [Address], [Note], [Email]) VALUES (2, N'Warehouse2', N'ឃ្លាំង២', N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[Warehouses] OFF
");
  
}
        
        public override void Down()
        {
        }
    }
}
