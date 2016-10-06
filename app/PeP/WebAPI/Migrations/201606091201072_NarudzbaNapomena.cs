namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NarudzbaNapomena : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Narudzbas", "Napomena", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Narudzbas", "Napomena");
        }
    }
}
