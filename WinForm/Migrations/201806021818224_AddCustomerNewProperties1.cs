namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerNewProperties1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "Id", newName: "CustomerId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Customers", name: "CustomerId", newName: "Id");
        }
    }
}
