namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreProductsProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Qty", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "Status", c => c.Byte(nullable: false));
            AddColumn("dbo.Products", "SupplierId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Photo", c => c.Binary(storeType: "image"));
            CreateIndex("dbo.Products", "SupplierId");
            AddForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "Possition");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Possition", c => c.String());
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "SupplierId" });
            AlterColumn("dbo.Products", "Photo", c => c.Binary());
            DropColumn("dbo.Products", "SupplierId");
            DropColumn("dbo.Products", "Status");
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Products", "Qty");
        }
    }
}
