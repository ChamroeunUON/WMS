namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editPropertyImage3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Photo", c => c.Binary());
            DropColumn("dbo.Products", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Image", c => c.Binary());
            DropColumn("dbo.Products", "Photo");
        }
    }
}
