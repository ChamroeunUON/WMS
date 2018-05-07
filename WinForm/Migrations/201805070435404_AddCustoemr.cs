namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustoemr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CusId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sex = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.CusId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
