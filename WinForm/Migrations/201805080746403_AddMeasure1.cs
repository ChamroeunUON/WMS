namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMeasure1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Measures", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Measures", "Note");
        }
    }
}
