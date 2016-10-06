namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PorukeDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Porukas", "isDeletedPrimljena", c => c.Boolean(nullable: false));
            AddColumn("dbo.Porukas", "isDeletedPoslana", c => c.Boolean(nullable: false));
            DropColumn("dbo.Porukas", "isDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Porukas", "isDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Porukas", "isDeletedPoslana");
            DropColumn("dbo.Porukas", "isDeletedPrimljena");
        }
    }
}
