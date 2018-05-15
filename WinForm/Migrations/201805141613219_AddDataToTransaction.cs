namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToTransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "DateTime");
        }
    }
}
