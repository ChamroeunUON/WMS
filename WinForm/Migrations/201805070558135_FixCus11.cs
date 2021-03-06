namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixCus11 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CusId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "CusId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CusId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Customers", "CusId");
        }
    }
}
