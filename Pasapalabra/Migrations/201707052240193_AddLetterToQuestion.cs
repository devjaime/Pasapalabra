namespace Pasapalabra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLetterToQuestion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Letter", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "Letter");
        }
    }
}
