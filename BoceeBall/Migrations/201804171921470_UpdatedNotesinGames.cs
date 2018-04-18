namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedNotesinGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Notes", c => c.String());
            DropColumn("dbo.Games", "Notess");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Notess", c => c.String());
            DropColumn("dbo.Games", "Notes");
        }
    }
}
