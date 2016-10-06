namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isUTokuNarudzba : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Narudzbas", "isUToku", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Narudzbas", "isUToku");
        }
    }
}
