namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayersGamesandTeams : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HomeTeamID = c.Int(),
                        AwayTeamID = c.Int(),
                        HomeScore = c.Int(nullable: false),
                        AwayScore = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Notess = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        NickName = c.String(),
                        PlayerNumber = c.String(),
                        ThrowingArm = c.String(),
                        TeamID = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mascot = c.String(),
                        Colors = c.String(),
                        RecordsID = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
            DropTable("dbo.Games");
        }
    }
}
