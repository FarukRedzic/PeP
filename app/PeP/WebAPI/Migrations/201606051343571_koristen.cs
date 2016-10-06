namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class koristen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proizvods", "Koristen", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proizvods", "Koristen");
        }
    }
}
