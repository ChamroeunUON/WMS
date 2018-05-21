namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreProperTiesOnSetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "Issue", c => c.String());
            AddColumn("dbo.Settings", "SaleOrderPre", c => c.String());
            AddColumn("dbo.Settings", "QuotePre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "QuotePre");
            DropColumn("dbo.Settings", "SaleOrderPre");
            DropColumn("dbo.Settings", "Issue");
        }
    }
}
