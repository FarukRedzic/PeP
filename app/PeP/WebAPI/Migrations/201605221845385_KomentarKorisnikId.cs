namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KomentarKorisnikId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Komentars", "KorisnikId", c => c.Int(nullable: false));
            CreateIndex("dbo.Komentars", "KorisnikId");
            AddForeignKey("dbo.Komentars", "KorisnikId", "dbo.Korisniks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Komentars", "KorisnikId", "dbo.Korisniks");
            DropIndex("dbo.Komentars", new[] { "KorisnikId" });
            DropColumn("dbo.Komentars", "KorisnikId");
        }
    }
}
