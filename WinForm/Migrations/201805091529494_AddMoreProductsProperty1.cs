namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreProductsProperty1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Note");
        }
    }
}
