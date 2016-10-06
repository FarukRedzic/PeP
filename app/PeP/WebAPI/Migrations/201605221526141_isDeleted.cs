namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proizvods", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proizvods", "isDeleted");
        }
    }
}
