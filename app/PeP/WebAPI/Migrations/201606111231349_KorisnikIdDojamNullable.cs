namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KorisnikIdDojamNullable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Dojams", new[] { "KorisnikId" });
            AlterColumn("dbo.Dojams", "KorisnikId", c => c.Int());
            CreateIndex("dbo.Dojams", "KorisnikId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Dojams", new[] { "KorisnikId" });
            AlterColumn("dbo.Dojams", "KorisnikId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dojams", "KorisnikId");
        }
    }
}
