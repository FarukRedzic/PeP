namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class slike : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Korisniks", "SlikaThumb");
            DropColumn("dbo.Proizvods", "SlikaThumb");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Proizvods", "SlikaThumb", c => c.Binary());
            AddColumn("dbo.Korisniks", "SlikaThumb", c => c.Binary());
        }
    }
}
