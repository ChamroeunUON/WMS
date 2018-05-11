namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplierToProducWarehouse1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProducWarehouses", "OnHand", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProducWarehouses", "OnHand");
        }
    }
}
