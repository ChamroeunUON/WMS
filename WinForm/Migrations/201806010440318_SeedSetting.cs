namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSetting : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Settings] ON
INSERT INTO [dbo].[Settings] ([Id], [InvoicePre], [AdjustPre], [PaymentPre], [ReceivePre], [Issue], [SaleOrderPre], [QuotePre]) VALUES (1, N'IN', N'AD', N'PM', N'RC', N'IS', N'SO', N'QU')
SET IDENTITY_INSERT [dbo].[Settings] OFF

");
        }
        
        public override void Down()
        {
        }
    }
}
