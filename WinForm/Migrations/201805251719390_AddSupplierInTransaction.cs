namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplierInTransaction : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Transactions", "SupplierId");
            AddForeignKey("dbo.Transactions", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Transactions", new[] { "SupplierId" });
        }
    }
}
