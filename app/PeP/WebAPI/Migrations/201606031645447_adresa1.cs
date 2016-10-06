namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adresa1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Korisniks", "Adresa", c => c.String());
            DropColumn("dbo.Korisniks", "Ulica");
            DropColumn("dbo.Korisniks", "BrojUlice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Korisniks", "BrojUlice", c => c.String());
            AddColumn("dbo.Korisniks", "Ulica", c => c.String());
            DropColumn("dbo.Korisniks", "Adresa");
        }
    }
}
