namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPro : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "SupplierId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            RenameColumn(table: "dbo.Products", name: "CategoryId", newName: "Category_Id");
            AddColumn("dbo.Products", "Cost", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Note", c => c.String());
            AddColumn("dbo.Products", "CateforyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "NameEN", c => c.String());
            AlterColumn("dbo.Products", "NameKH", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "Status", c => c.String());
            AlterColumn("dbo.Products", "Category_Id", c => c.Int());
            AlterColumn("dbo.Products", "Photo", c => c.Binary());
            CreateIndex("dbo.Products", "Category_Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id");
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
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_Id" });
            AlterColumn("dbo.Products", "Photo", c => c.Binary(storeType: "image"));
            AlterColumn("dbo.Products", "Category_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Status", c => c.Byte(nullable: false));
            AlterColumn("dbo.Products", "Price", c => c.Single(nullable: false));
            AlterColumn("dbo.Products", "NameKH", c => c.String(maxLength: 255));
            AlterColumn("dbo.Products", "NameEN", c => c.String(maxLength: 255));
            DropColumn("dbo.Products", "CateforyId");
            DropColumn("dbo.Products", "Note");
            DropColumn("dbo.Products", "Cost");
            RenameColumn(table: "dbo.Products", name: "Category_Id", newName: "CategoryId");
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "SupplierId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
    }
}
