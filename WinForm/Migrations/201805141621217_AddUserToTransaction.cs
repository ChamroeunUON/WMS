namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToTransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransactionItems", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.TransactionItems", "UserId");
            AddForeignKey("dbo.TransactionItems", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionItems", "UserId", "dbo.Users");
            DropIndex("dbo.TransactionItems", new[] { "UserId" });
            DropColumn("dbo.TransactionItems", "UserId");
        }
    }
}
