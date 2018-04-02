namespace EasyMap.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlacePhotos", "Main", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlacePhotos", "Main");
        }
    }
}
