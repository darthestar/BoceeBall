namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHomeTeamsID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "HomeTeamsID", c => c.Int());
            AddColumn("dbo.Games", "AwayTeamsID", c => c.Int());
            CreateIndex("dbo.Games", "HomeTeamsID");
            AddForeignKey("dbo.Games", "HomeTeamsID", "dbo.Teams", "Id");
            CreateIndex("dbo.Games", "AwayTeamsID");
            AddForeignKey("dbo.Games", "AwayTeamsID", "dbo.Teams", "Id");


        }

        public override void Down()
        {
            DropForeignKey("dbo.Games", "Teams_Id", "dbo.Teams");
            DropIndex("dbo.Games", new[] { "Teams_Id" });
            DropColumn("dbo.Games", "Teams_Id");
            DropColumn("dbo.Games", "AwayTeamsID");
            DropColumn("dbo.Games", "HomeTeamsID");
        }
    }
}
