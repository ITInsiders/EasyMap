namespace EasyMap.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Users", "DateOfLastVisit", c => c.DateTime());
            AlterColumn("dbo.Users", "DateOfLastChange", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DateOfLastChange", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "DateOfLastVisit", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
