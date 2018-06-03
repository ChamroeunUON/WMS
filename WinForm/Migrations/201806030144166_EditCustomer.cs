namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCustomer : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "CusId", newName: "CustomerId");
            DropColumn("dbo.SaleOrders", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleOrders", "CustomerId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Customers", name: "CustomerId", newName: "CusId");
        }
    }
}
