namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductWarehouseSupplier1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProducWarehouses", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.ProducWarehouses", new[] { "SupplierId" });
            DropColumn("dbo.ProducWarehouses", "SupplierId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProducWarehouses", "SupplierId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProducWarehouses", "SupplierId");
            AddForeignKey("dbo.ProducWarehouses", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
    }
}
