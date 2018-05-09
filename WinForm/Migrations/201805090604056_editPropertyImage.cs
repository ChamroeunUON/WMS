namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editPropertyImage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Image", c => c.Byte());
        }
    }
}
