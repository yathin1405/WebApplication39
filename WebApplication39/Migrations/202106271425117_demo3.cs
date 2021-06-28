namespace WebApplication39.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Flights", "Return_Date");
            DropColumn("dbo.Flights", "Return_Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Flights", "Return_Time", c => c.DateTime(nullable: false));
            AddColumn("dbo.Flights", "Return_Date", c => c.DateTime(nullable: false));
        }
    }
}
