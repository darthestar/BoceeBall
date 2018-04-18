namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReaddedTeamsIDFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "TeamsID", c => c.Int());
            CreateIndex("dbo.Players", "TeamsID");
            AddForeignKey("dbo.Players", "TeamsID", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamsID", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamsID" });
            DropColumn("dbo.Players", "TeamsID");
        }
    }
}
