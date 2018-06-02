namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductToSalrOrderItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleOrderItems", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.SaleOrderItems", "ProductId");
            AddForeignKey("dbo.SaleOrderItems", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleOrderItems", "ProductId", "dbo.Products");
            DropIndex("dbo.SaleOrderItems", new[] { "ProductId" });
            DropColumn("dbo.SaleOrderItems", "ProductId");
        }
    }
}
