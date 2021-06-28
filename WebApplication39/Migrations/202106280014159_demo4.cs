namespace WebApplication39.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.UserFlights", "Seat_Type_Calc", c => c.Double(nullable: false));
            DropColumn("dbo.Flights", "Plane_Capacity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Flights", "Plane_Capacity", c => c.String());
            DropColumn("dbo.UserFlights", "Seat_Type_Calc");
            DropColumn("dbo.Flights", "Price");
        }
    }
}
