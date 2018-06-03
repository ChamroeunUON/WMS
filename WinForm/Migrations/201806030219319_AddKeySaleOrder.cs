namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKeySaleOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleOrders", "CusId", c => c.Int(nullable: false));
            CreateIndex("dbo.SaleOrders", "CusId");
            AddForeignKey("dbo.SaleOrders", "CusId", "dbo.Customers", "CusId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleOrders", "CusId", "dbo.Customers");
            DropIndex("dbo.SaleOrders", new[] { "CusId" });
            DropColumn("dbo.SaleOrders", "CusId");
        }
    }
}
