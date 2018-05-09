namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmployyeeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameEN = c.String(),
                        NameKH = c.String(),
                        Sex = c.String(),
                        DOB = c.DateTime(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Possition = c.String(),
                        Note = c.String(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Possition", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Possition");
            DropTable("dbo.Employees");
        }
    }
}
