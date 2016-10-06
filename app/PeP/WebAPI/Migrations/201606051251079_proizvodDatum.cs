namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class proizvodDatum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proizvods", "Postavio", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proizvods", "Postavio");
        }
    }
}
