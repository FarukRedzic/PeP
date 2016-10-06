namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notifikacija5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Narudzbas", "NapomenaPrimaoc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Narudzbas", "NapomenaPrimaoc", c => c.String());
        }
    }
}
