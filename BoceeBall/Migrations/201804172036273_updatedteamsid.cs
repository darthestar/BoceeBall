namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedteamsid : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Players", new[] { "TeamsId" });
            CreateIndex("dbo.Players", "TeamsID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Players", new[] { "TeamsID" });
            CreateIndex("dbo.Players", "TeamsId");
        }
    }
}
