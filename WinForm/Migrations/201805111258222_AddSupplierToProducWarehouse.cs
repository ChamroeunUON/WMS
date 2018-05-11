namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplierToProducWarehouse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProducWarehouses", "SupplierId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProducWarehouses", "SupplierId");
            AddForeignKey("dbo.ProducWarehouses", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProducWarehouses", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.ProducWarehouses", new[] { "SupplierId" });
            DropColumn("dbo.ProducWarehouses", "SupplierId");
        }
    }
}
