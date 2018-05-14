namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotRequireSupplierId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProducWarehouses", "SupplierId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProducWarehouses", "SupplierId", c => c.Int(nullable: false));
        }
    }
}
