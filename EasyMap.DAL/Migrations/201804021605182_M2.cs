namespace EasyMap.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Rating", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Rating", c => c.Double(nullable: false));
        }
    }
}
