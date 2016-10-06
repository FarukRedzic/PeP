namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotifikacijeKomentarisaoProizvod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifikacijes", "KomentarisaoProizvod", c => c.String());
            AddColumn("dbo.Notifikacijes", "PoslaoPoruku", c => c.String());
            DropColumn("dbo.Notifikacijes", "Komentar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifikacijes", "Komentar", c => c.String());
            DropColumn("dbo.Notifikacijes", "PoslaoPoruku");
            DropColumn("dbo.Notifikacijes", "KomentarisaoProizvod");
        }
    }
}
