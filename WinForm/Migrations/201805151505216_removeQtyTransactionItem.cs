namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeQtyTransactionItem : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProducWarehouses", "Qty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProducWarehouses", "Qty", c => c.Int(nullable: false));
        }
    }
}
