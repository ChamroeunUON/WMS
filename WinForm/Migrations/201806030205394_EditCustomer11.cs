namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCustomer11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SaleOrders", "Customer_CusId", "dbo.Customers");
            DropIndex("dbo.SaleOrders", new[] { "Customer_CusId" });
            RenameColumn(table: "dbo.Customers", name: "CustomerId", newName: "CusId");
            RenameColumn(table: "dbo.SaleOrders", name: "Customer_CusId", newName: "CusId");
            AlterColumn("dbo.SaleOrders", "CusId", c => c.Int(nullable: false));
            CreateIndex("dbo.SaleOrders", "CusId");
            AddForeignKey("dbo.SaleOrders", "CusId", "dbo.Customers", "CusId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleOrders", "CusId", "dbo.Customers");
            DropIndex("dbo.SaleOrders", new[] { "CusId" });
            AlterColumn("dbo.SaleOrders", "CusId", c => c.Int());
            RenameColumn(table: "dbo.SaleOrders", name: "CusId", newName: "Customer_CusId");
            RenameColumn(table: "dbo.Customers", name: "CusId", newName: "CustomerId");
            CreateIndex("dbo.SaleOrders", "Customer_CusId");
            AddForeignKey("dbo.SaleOrders", "Customer_CusId", "dbo.Customers", "CustomerId");
        }
    }
}
