namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTransactionAndTransactionItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WarehouseId = c.Int(nullable: false),
                        TransactionId = c.String(),
                        Qty = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        Cost = c.Single(nullable: false),
                        Transaction_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transactions", t => t.Transaction_Id)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.WarehouseId)
                .Index(t => t.Transaction_Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionId = c.String(),
                        TransactionType = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        TotalAmount = c.Single(nullable: false),
                        SynNote = c.String(),
                        Note = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionItems", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.TransactionItems", "Transaction_Id", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "User_Id", "dbo.Users");
            DropIndex("dbo.Transactions", new[] { "User_Id" });
            DropIndex("dbo.TransactionItems", new[] { "Transaction_Id" });
            DropIndex("dbo.TransactionItems", new[] { "WarehouseId" });
            DropTable("dbo.Transactions");
            DropTable("dbo.TransactionItems");
        }
    }
}
