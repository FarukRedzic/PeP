namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpstinaId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Korisniks", new[] { "OpstinaId" });
            AlterColumn("dbo.Korisniks", "OpstinaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Korisniks", "OpstinaId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Korisniks", new[] { "OpstinaId" });
            AlterColumn("dbo.Korisniks", "OpstinaId", c => c.Int());
            CreateIndex("dbo.Korisniks", "OpstinaId");
        }
    }
}
