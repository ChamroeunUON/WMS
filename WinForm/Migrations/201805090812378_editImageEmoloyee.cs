namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editImageEmoloyee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Photo", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Photo", c => c.Binary());
        }
    }
}
