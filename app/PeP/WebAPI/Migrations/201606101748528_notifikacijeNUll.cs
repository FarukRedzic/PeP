namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notifikacijeNUll : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Notifikacijes", new[] { "NarudzbaId" });
            DropIndex("dbo.Notifikacijes", new[] { "VrstaNotifikacijeId" });
            DropIndex("dbo.Notifikacijes", new[] { "KorisnikId" });
            DropIndex("dbo.Notifikacijes", new[] { "ProizvodId" });
            AlterColumn("dbo.Notifikacijes", "NarudzbaId", c => c.Int());
            AlterColumn("dbo.Notifikacijes", "VrstaNotifikacijeId", c => c.Int());
            AlterColumn("dbo.Notifikacijes", "KorisnikId", c => c.Int());
            AlterColumn("dbo.Notifikacijes", "ProizvodId", c => c.Int());
            CreateIndex("dbo.Notifikacijes", "NarudzbaId");
            CreateIndex("dbo.Notifikacijes", "VrstaNotifikacijeId");
            CreateIndex("dbo.Notifikacijes", "KorisnikId");
            CreateIndex("dbo.Notifikacijes", "ProizvodId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Notifikacijes", new[] { "ProizvodId" });
            DropIndex("dbo.Notifikacijes", new[] { "KorisnikId" });
            DropIndex("dbo.Notifikacijes", new[] { "VrstaNotifikacijeId" });
            DropIndex("dbo.Notifikacijes", new[] { "NarudzbaId" });
            AlterColumn("dbo.Notifikacijes", "ProizvodId", c => c.Int(nullable: false));
            AlterColumn("dbo.Notifikacijes", "KorisnikId", c => c.Int(nullable: false));
            AlterColumn("dbo.Notifikacijes", "VrstaNotifikacijeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Notifikacijes", "NarudzbaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Notifikacijes", "ProizvodId");
            CreateIndex("dbo.Notifikacijes", "KorisnikId");
            CreateIndex("dbo.Notifikacijes", "VrstaNotifikacijeId");
            CreateIndex("dbo.Notifikacijes", "NarudzbaId");
        }
    }
}
