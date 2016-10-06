namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PorukaDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Porukas", "DatumVrijeme", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Porukas", "DatumVrijeme", c => c.String());
        }
    }
}
