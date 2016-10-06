namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PorukaIsDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Porukas", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Porukas", "isDeleted");
        }
    }
}
