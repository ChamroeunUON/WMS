namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSaleOrderItemUser1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SaleOrders", "Customer_CusId", "dbo.Customers");
            DropIndex("dbo.SaleOrders", new[] { "Customer_CusId" });
            DropColumn("dbo.SaleOrders", "Customer_CusId");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CusId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Sex = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.CusId);
            
            AddColumn("dbo.SaleOrders", "Customer_CusId", c => c.Int());
            CreateIndex("dbo.SaleOrders", "Customer_CusId");
            AddForeignKey("dbo.SaleOrders", "Customer_CusId", "dbo.Customers", "CusId");
        }
    }
}
