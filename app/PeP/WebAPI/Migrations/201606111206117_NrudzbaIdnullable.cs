namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NrudzbaIdnullable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Dojams", new[] { "NarudzbaId" });
            AlterColumn("dbo.Dojams", "NarudzbaId", c => c.Int());
            CreateIndex("dbo.Dojams", "NarudzbaId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Dojams", new[] { "NarudzbaId" });
            AlterColumn("dbo.Dojams", "NarudzbaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dojams", "NarudzbaId");
        }
    }
}
