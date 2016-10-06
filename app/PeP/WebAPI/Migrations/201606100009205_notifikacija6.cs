namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notifikacija6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifikacijes", "ProizvodId", c => c.Int(nullable: false));
            CreateIndex("dbo.Notifikacijes", "ProizvodId");
            AddForeignKey("dbo.Notifikacijes", "ProizvodId", "dbo.Proizvods", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifikacijes", "ProizvodId", "dbo.Proizvods");
            DropIndex("dbo.Notifikacijes", new[] { "ProizvodId" });
            DropColumn("dbo.Notifikacijes", "ProizvodId");
        }
    }
}
