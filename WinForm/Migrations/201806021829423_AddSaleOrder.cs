namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSaleOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleOrders",
                c => new
                    {
                        SaleOrderId = c.String(nullable: false, maxLength: 128),
                        SaleType = c.Int(nullable: false),
                        SaleDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        DisAmount = c.Single(nullable: false),
                        DisPercent = c.Single(nullable: false),
                        SubTotal = c.Single(nullable: false),
                        GrandTotal = c.Single(nullable: false),
                        Deposit = c.Single(nullable: false),
                        Balance = c.Single(nullable: false),
                        Paid = c.Single(nullable: false),
                        Status = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.SaleOrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleOrders", "UserId", "dbo.Users");
            DropForeignKey("dbo.SaleOrders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.SaleOrders", new[] { "UserId" });
            DropIndex("dbo.SaleOrders", new[] { "CustomerId" });
            DropTable("dbo.SaleOrders");
        }
    }
}
