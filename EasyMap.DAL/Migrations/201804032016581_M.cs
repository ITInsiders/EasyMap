namespace EasyMap.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlacePhotos", "Main", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {

        }
    }
}
