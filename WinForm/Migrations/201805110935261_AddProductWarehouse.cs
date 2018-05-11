namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductWarehouse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProducWarehouses",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        AlertQty = c.Int(nullable: false),
                        Note = c.String(),
                        SaleOrderQty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.WarehouseId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.WarehouseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProducWarehouses", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.ProducWarehouses", "ProductId", "dbo.Products");
            DropIndex("dbo.ProducWarehouses", new[] { "WarehouseId" });
            DropIndex("dbo.ProducWarehouses", new[] { "ProductId" });
            DropTable("dbo.ProducWarehouses");
        }
    }
}
