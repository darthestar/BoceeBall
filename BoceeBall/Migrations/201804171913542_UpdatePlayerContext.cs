namespace BoceeBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePlayerContext : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Teams_Id", c => c.Int());
            CreateIndex("dbo.Players", "Teams_Id");
            AddForeignKey("dbo.Players", "Teams_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Teams_Id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Teams_Id" });
            DropColumn("dbo.Players", "Teams_Id");
        }
    }
}
