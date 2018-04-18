namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteUpdatetoTeamsID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "Teams_Id", "dbo.Teams");
            DropIndex("dbo.Games", new[] { "Teams_Id" });
            DropColumn("dbo.Games", "HomeTeamsID");
            DropColumn("dbo.Games", "AwayTeamsID");
            DropColumn("dbo.Games", "Teams_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Teams_Id", c => c.Int());
            AddColumn("dbo.Games", "AwayTeamsID", c => c.Int());
            AddColumn("dbo.Games", "HomeTeamsID", c => c.Int());
            CreateIndex("dbo.Games", "Teams_Id");
            AddForeignKey("dbo.Games", "Teams_Id", "dbo.Teams", "Id");
        }
    }
}
