namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeSupplierProWarehouse : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProducWarehouses", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.ProducWarehouses", new[] { "SupplierId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.ProducWarehouses", "SupplierId");
            AddForeignKey("dbo.ProducWarehouses", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
    }
}
