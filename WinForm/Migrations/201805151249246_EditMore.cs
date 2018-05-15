namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditMore : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TransactionItems", "UserId", "dbo.Users");
            DropForeignKey("dbo.Transactions", "User_Id", "dbo.Users");
            DropIndex("dbo.TransactionItems", new[] { "UserId" });
            DropIndex("dbo.Transactions", new[] { "User_Id" });
            RenameColumn(table: "dbo.Transactions", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Transactions", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "UserId");
            AddForeignKey("dbo.Transactions", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.TransactionItems", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TransactionItems", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Transactions", "UserId", "dbo.Users");
            DropIndex("dbo.Transactions", new[] { "UserId" });
            AlterColumn("dbo.Transactions", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Transactions", name: "UserId", newName: "User_Id");
            CreateIndex("dbo.Transactions", "User_Id");
            CreateIndex("dbo.TransactionItems", "UserId");
            AddForeignKey("dbo.Transactions", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.TransactionItems", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
