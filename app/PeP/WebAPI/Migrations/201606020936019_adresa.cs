namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Korisniks", "Ulica", c => c.String());
            AddColumn("dbo.Korisniks", "BrojUlice", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Korisniks", "BrojUlice");
            DropColumn("dbo.Korisniks", "Ulica");
        }
    }
}
