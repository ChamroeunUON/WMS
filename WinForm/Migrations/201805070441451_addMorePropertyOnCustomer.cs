namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMorePropertyOnCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String());
            AddColumn("dbo.Customers", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Note");
            DropColumn("dbo.Customers", "Email");
        }
    }
}
