namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmailtoWarehouse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Warehouses", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Warehouses", "Email");
        }
    }
}
