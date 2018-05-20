namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useStrinAsPrimaryKeyTransaction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TransactionItems", "Transaction_Id", "dbo.Transactions");
            DropIndex("dbo.TransactionItems", new[] { "Transaction_Id" });
            DropColumn("dbo.TransactionItems", "TransactionId");
            RenameColumn(table: "dbo.TransactionItems", name: "Transaction_Id", newName: "TransactionId");
            DropPrimaryKey("dbo.Transactions");
            AlterColumn("dbo.TransactionItems", "TransactionId", c => c.String(maxLength: 128));
            AlterColumn("dbo.TransactionItems", "TransactionId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Transactions", "TransactionId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Transactions", "TransactionId");
            CreateIndex("dbo.TransactionItems", "TransactionId");
            AddForeignKey("dbo.TransactionItems", "TransactionId", "dbo.Transactions", "TransactionId");
            DropColumn("dbo.Transactions", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.TransactionItems", "TransactionId", "dbo.Transactions");
            DropIndex("dbo.TransactionItems", new[] { "TransactionId" });
            DropPrimaryKey("dbo.Transactions");
            AlterColumn("dbo.Transactions", "TransactionId", c => c.String());
            AlterColumn("dbo.TransactionItems", "TransactionId", c => c.Int());
            AlterColumn("dbo.TransactionItems", "TransactionId", c => c.String());
            AddPrimaryKey("dbo.Transactions", "Id");
            RenameColumn(table: "dbo.TransactionItems", name: "TransactionId", newName: "Transaction_Id");
            AddColumn("dbo.TransactionItems", "TransactionId", c => c.String());
            CreateIndex("dbo.TransactionItems", "Transaction_Id");
            AddForeignKey("dbo.TransactionItems", "Transaction_Id", "dbo.Transactions", "Id");
        }
    }
}
