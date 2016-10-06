namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ocjeneINT : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dojams", "Ocjena", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dojams", "Ocjena", c => c.Double());
        }
    }
}
