namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class favoritiConstraint : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Favoritis", new[] { "KorisnikId" });
            DropIndex("dbo.Favoritis", new[] { "ProizvodId" });
            CreateIndex("dbo.Favoritis", new[] { "KorisnikId", "ProizvodId" }, unique: true, name: "IX_Favoriti");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Favoritis", "IX_Favoriti");
            CreateIndex("dbo.Favoritis", "ProizvodId");
            CreateIndex("dbo.Favoritis", "KorisnikId");
        }
    }
}
