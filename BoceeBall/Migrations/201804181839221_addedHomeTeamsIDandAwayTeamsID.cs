namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedHomeTeamsIDandAwayTeamsID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "HomeTeamsID", c => c.Int());
            AddColumn("dbo.Games", "AwayTeamsID", c => c.Int());
            AddColumn("dbo.Games", "Teams_Id", c => c.Int());
            CreateIndex("dbo.Games", "Teams_Id");
            AddForeignKey("dbo.Games", "Teams_Id", "dbo.Teams", "Id");
            DropColumn("dbo.Games", "HomeTeamID");
            DropColumn("dbo.Games", "AwayTeamID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "AwayTeamID", c => c.Int());
            AddColumn("dbo.Games", "HomeTeamID", c => c.Int());
            DropForeignKey("dbo.Games", "Teams_Id", "dbo.Teams");
            DropIndex("dbo.Games", new[] { "Teams_Id" });
            DropColumn("dbo.Games", "Teams_Id");
            DropColumn("dbo.Games", "AwayTeamsID");
            DropColumn("dbo.Games", "HomeTeamsID");
        }
    }
}
