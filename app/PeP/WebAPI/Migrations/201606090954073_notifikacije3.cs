namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notifikacije3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifikacijes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        isNeaktivna = c.Boolean(nullable: false),
                        Komentar = c.String(),
                        NarudzbaId = c.Int(nullable: false),
                        VrstaNotifikacijeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Narudzbas", t => t.NarudzbaId)
                .ForeignKey("dbo.VrstaNotifikacijes", t => t.VrstaNotifikacijeId)
                .Index(t => t.NarudzbaId)
                .Index(t => t.VrstaNotifikacijeId);
            
            CreateTable(
                "dbo.VrstaNotifikacijes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifikacijes", "VrstaNotifikacijeId", "dbo.VrstaNotifikacijes");
            DropForeignKey("dbo.Notifikacijes", "NarudzbaId", "dbo.Narudzbas");
            DropIndex("dbo.Notifikacijes", new[] { "VrstaNotifikacijeId" });
            DropIndex("dbo.Notifikacijes", new[] { "NarudzbaId" });
            DropTable("dbo.VrstaNotifikacijes");
            DropTable("dbo.Notifikacijes");
        }
    }
}
