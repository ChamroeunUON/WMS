namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditPropertiesProWarehouse : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SaleOrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SaleOrderItems", "WarehouseId", "dbo.Warehouses");
            DropIndex("dbo.SaleOrderItems", new[] { "ProductId" });
            DropIndex("dbo.SaleOrderItems", new[] { "WarehouseId" });
            AddColumn("dbo.SaleOrderItems", "ProductWarehouseId", c => c.Int(nullable: false));
            AddColumn("dbo.SaleOrderItems", "ProducWarehouse_ProductId", c => c.Int());
            AddColumn("dbo.SaleOrderItems", "ProducWarehouse_WarehouseId", c => c.Int());
            CreateIndex("dbo.SaleOrderItems", new[] { "ProducWarehouse_ProductId", "ProducWarehouse_WarehouseId" });
            AddForeignKey("dbo.SaleOrderItems", new[] { "ProducWarehouse_ProductId", "ProducWarehouse_WarehouseId" }, "dbo.ProducWarehouses", new[] { "ProductId", "WarehouseId" });
            DropColumn("dbo.SaleOrderItems", "ProductId");
            DropColumn("dbo.SaleOrderItems", "WarehouseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleOrderItems", "WarehouseId", c => c.Int(nullable: false));
            AddColumn("dbo.SaleOrderItems", "ProductId", c => c.Int(nullable: false));
            DropForeignKey("dbo.SaleOrderItems", new[] { "ProducWarehouse_ProductId", "ProducWarehouse_WarehouseId" }, "dbo.ProducWarehouses");
            DropIndex("dbo.SaleOrderItems", new[] { "ProducWarehouse_ProductId", "ProducWarehouse_WarehouseId" });
            DropColumn("dbo.SaleOrderItems", "ProducWarehouse_WarehouseId");
            DropColumn("dbo.SaleOrderItems", "ProducWarehouse_ProductId");
            DropColumn("dbo.SaleOrderItems", "ProductWarehouseId");
            CreateIndex("dbo.SaleOrderItems", "WarehouseId");
            CreateIndex("dbo.SaleOrderItems", "ProductId");
            AddForeignKey("dbo.SaleOrderItems", "WarehouseId", "dbo.Warehouses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SaleOrderItems", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
