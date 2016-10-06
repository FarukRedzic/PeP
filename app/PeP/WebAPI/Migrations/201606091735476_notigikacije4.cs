namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notigikacije4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifikacijes", "KorisnikId", c => c.Int(nullable: false));
            CreateIndex("dbo.Notifikacijes", "KorisnikId");
            AddForeignKey("dbo.Notifikacijes", "KorisnikId", "dbo.Korisniks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifikacijes", "KorisnikId", "dbo.Korisniks");
            DropIndex("dbo.Notifikacijes", new[] { "KorisnikId" });
            DropColumn("dbo.Notifikacijes", "KorisnikId");
        }
    }
}
