namespace EasyMap.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EasyMap2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Places", "Creater", "dbo.Users");
            DropIndex("dbo.Places", new[] { "Creater" });
            AlterColumn("dbo.Places", "Creater", c => c.Int());
            CreateIndex("dbo.Places", "Creater");
            AddForeignKey("dbo.Places", "Creater", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Places", "Creater", "dbo.Users");
            DropIndex("dbo.Places", new[] { "Creater" });
            AlterColumn("dbo.Places", "Creater", c => c.Int(nullable: false));
            CreateIndex("dbo.Places", "Creater");
            AddForeignKey("dbo.Places", "Creater", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
