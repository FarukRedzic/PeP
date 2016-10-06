namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class korisnikIdDOjam : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Dojams", new[] { "NarudzbaId" });
            AddColumn("dbo.Dojams", "KorisnikId", c => c.Int(nullable: false));
            AlterColumn("dbo.Dojams", "NarudzbaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dojams", "NarudzbaId", unique: true);
            CreateIndex("dbo.Dojams", "KorisnikId");
            AddForeignKey("dbo.Dojams", "KorisnikId", "dbo.Korisniks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dojams", "KorisnikId", "dbo.Korisniks");
            DropIndex("dbo.Dojams", new[] { "KorisnikId" });
            DropIndex("dbo.Dojams", new[] { "NarudzbaId" });
            AlterColumn("dbo.Dojams", "NarudzbaId", c => c.Int());
            DropColumn("dbo.Dojams", "KorisnikId");
            CreateIndex("dbo.Dojams", "NarudzbaId");
        }
    }
}
