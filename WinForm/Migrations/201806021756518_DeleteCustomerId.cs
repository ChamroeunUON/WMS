namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCustomerId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SaleOrders", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleOrders", "CustomerId", c => c.Int(nullable: false));
        }
    }
}
