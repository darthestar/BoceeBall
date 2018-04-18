namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePlayerTeamFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Teams_Id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Teams_Id" });
            DropColumn("dbo.Players", "TeamID");
            DropColumn("dbo.Players", "Teams_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Teams_Id", c => c.Int());
            AddColumn("dbo.Players", "TeamID", c => c.Int());
            CreateIndex("dbo.Players", "Teams_Id");
            AddForeignKey("dbo.Players", "Teams_Id", "dbo.Teams", "Id");
        }
    }
}
