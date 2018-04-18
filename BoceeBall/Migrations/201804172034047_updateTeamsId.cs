namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTeamsId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Players", new[] { "TeamsID" });
            CreateIndex("dbo.Players", "TeamsId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Players", new[] { "TeamsId" });
            CreateIndex("dbo.Players", "TeamsID");
        }
    }
}
