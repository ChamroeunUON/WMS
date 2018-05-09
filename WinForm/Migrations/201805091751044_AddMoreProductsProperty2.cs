namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreProductsProperty2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "SupplierId" });
            AddColumn("dbo.Products", "Cost", c => c.Single(nullable: false));
            DropColumn("dbo.Products", "Qty");
            DropColumn("dbo.Products", "DateEnter");
            DropColumn("dbo.Products", "DateExpire");
            DropColumn("dbo.Products", "SupplierId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "SupplierId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "DateExpire", c => c.DateTime());
            AddColumn("dbo.Products", "DateEnter", c => c.DateTime());
            AddColumn("dbo.Products", "Qty", c => c.Single(nullable: false));
            DropColumn("dbo.Products", "Cost");
            CreateIndex("dbo.Products", "SupplierId");
            AddForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
    }
}
