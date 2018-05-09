namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMeasure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Measures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "MeasureId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "MeasureId");
            AddForeignKey("dbo.Products", "MeasureId", "dbo.Measures", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "MeasureId", "dbo.Measures");
            DropIndex("dbo.Products", new[] { "MeasureId" });
            DropColumn("dbo.Products", "MeasureId");
            DropTable("dbo.Measures");
        }
    }
}
