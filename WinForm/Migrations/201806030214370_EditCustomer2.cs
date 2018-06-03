namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCustomer2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SaleOrders", "CusId", "dbo.Customers");
            DropIndex("dbo.SaleOrders", new[] { "CusId" });
            DropColumn("dbo.SaleOrders", "CusId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleOrders", "CusId", c => c.Int(nullable: false));
            CreateIndex("dbo.SaleOrders", "CusId");
            AddForeignKey("dbo.SaleOrders", "CusId", "dbo.Customers", "CusId", cascadeDelete: true);
        }
    }
}
