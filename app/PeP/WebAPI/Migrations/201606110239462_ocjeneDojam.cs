namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ocjeneDojam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dojams", "Ocjena", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dojams", "Ocjena", c => c.Double(nullable: false));
        }
    }
}
