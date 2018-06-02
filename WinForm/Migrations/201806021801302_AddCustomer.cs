namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SaleOrderItems", new[] { "ProducWarehouse_ProductId", "ProducWarehouse_WarehouseId" }, "dbo.ProducWarehouses");
            DropForeignKey("dbo.SaleOrders", "UserId", "dbo.Users");
            DropForeignKey("dbo.SaleOrderItems", "SaleOrderId", "dbo.SaleOrders");
            DropIndex("dbo.SaleOrderItems", new[] { "SaleOrderId" });
            DropIndex("dbo.SaleOrderItems", new[] { "ProducWarehouse_ProductId", "ProducWarehouse_WarehouseId" });
            DropIndex("dbo.SaleOrders", new[] { "UserId" });
            DropTable("dbo.SaleOrderItems");
            DropTable("dbo.SaleOrders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SaleOrders",
                c => new
                    {
                        SaleOrderId = c.String(nullable: false, maxLength: 128),
                        SaleType = c.Int(nullable: false),
                        SaleDate = c.DateTime(nullable: false),
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
                .PrimaryKey(t => t.SaleOrderId);
            
            CreateTable(
                "dbo.SaleOrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleOrderId = c.String(maxLength: 128),
                        ProductWarehouseId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        DisPercent = c.Single(nullable: false),
                        VatPercent = c.Single(nullable: false),
                        Amount = c.Single(nullable: false),
                        Note = c.String(),
                        ProducWarehouse_ProductId = c.Int(),
                        ProducWarehouse_WarehouseId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.SaleOrders", "UserId");
            CreateIndex("dbo.SaleOrderItems", new[] { "ProducWarehouse_ProductId", "ProducWarehouse_WarehouseId" });
            CreateIndex("dbo.SaleOrderItems", "SaleOrderId");
            AddForeignKey("dbo.SaleOrderItems", "SaleOrderId", "dbo.SaleOrders", "SaleOrderId");
            AddForeignKey("dbo.SaleOrders", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SaleOrderItems", new[] { "ProducWarehouse_ProductId", "ProducWarehouse_WarehouseId" }, "dbo.ProducWarehouses", new[] { "ProductId", "WarehouseId" });
        }
    }
}
