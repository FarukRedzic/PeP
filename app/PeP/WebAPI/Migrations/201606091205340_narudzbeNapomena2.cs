namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class narudzbeNapomena2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Narudzbas", "NapomenaPosiljaoc", c => c.String());
            AddColumn("dbo.Narudzbas", "NapomenaPrimaoc", c => c.String());
            DropColumn("dbo.Narudzbas", "Napomena");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Narudzbas", "Napomena", c => c.String());
            DropColumn("dbo.Narudzbas", "NapomenaPrimaoc");
            DropColumn("dbo.Narudzbas", "NapomenaPosiljaoc");
        }
    }
}
