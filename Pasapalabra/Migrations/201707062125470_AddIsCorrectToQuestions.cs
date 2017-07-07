namespace Pasapalabra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCorrectToQuestions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "IsCorrect", c => c.Boolean(defaultValue: null));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "IsCorrect");
        }
    }
}
