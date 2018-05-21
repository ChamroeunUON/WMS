namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSaleOrderAndSaleOrderItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleOrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleOrderId = c.String(maxLength: 128),
                        WarehouseId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        DisPercent = c.Single(nullable: false),
                        VatPercent = c.Single(nullable: false),
                        Amount = c.Single(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SaleOrders", t => t.SaleOrderId)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.SaleOrderId)
                .Index(t => t.WarehouseId);
            
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
                        Customer_CusId = c.Int(),
                    })
                .PrimaryKey(t => t.SaleOrderId)
                .ForeignKey("dbo.Customers", t => t.Customer_CusId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Customer_CusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleOrderItems", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.SaleOrderItems", "SaleOrderId", "dbo.SaleOrders");
            DropForeignKey("dbo.SaleOrders", "UserId", "dbo.Users");
            DropForeignKey("dbo.SaleOrders", "Customer_CusId", "dbo.Customers");
            DropIndex("dbo.SaleOrders", new[] { "Customer_CusId" });
            DropIndex("dbo.SaleOrders", new[] { "UserId" });
            DropIndex("dbo.SaleOrderItems", new[] { "WarehouseId" });
            DropIndex("dbo.SaleOrderItems", new[] { "SaleOrderId" });
            DropTable("dbo.SaleOrders");
            DropTable("dbo.SaleOrderItems");
        }
    }
}
