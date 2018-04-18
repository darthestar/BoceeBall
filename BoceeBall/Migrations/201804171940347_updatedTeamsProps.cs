namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedTeamsProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Wins", c => c.Int(nullable: false));
            AddColumn("dbo.Teams", "Losses", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Losses");
            DropColumn("dbo.Teams", "Wins");
        }
    }
}
