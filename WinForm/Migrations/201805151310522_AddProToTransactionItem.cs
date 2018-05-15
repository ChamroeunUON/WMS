namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProToTransactionItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransactionItems", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.TransactionItems", "ProductId");
            AddForeignKey("dbo.TransactionItems", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionItems", "ProductId", "dbo.Products");
            DropIndex("dbo.TransactionItems", new[] { "ProductId" });
            DropColumn("dbo.TransactionItems", "ProductId");
        }
    }
}
