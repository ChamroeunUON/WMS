namespace WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotePropertyCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Note");
        }
    }
}
