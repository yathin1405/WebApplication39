namespace WebApplication39.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        FlightID = c.Int(nullable: false, identity: true),
                        Airways = c.Int(nullable: false),
                        FROM = c.Int(nullable: false),
                        TO = c.Int(nullable: false),
                        SeatType = c.Int(nullable: false),
                        PassengerType = c.Int(nullable: false),
                        Departure_Date = c.DateTime(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        Return_Flight = c.Boolean(nullable: false),
                        Return_Date = c.DateTime(nullable: false),
                        Return_Time = c.DateTime(nullable: false),
                        Flight_Duration = c.String(),
                        FDelay = c.Boolean(nullable: false),
                        Flight_Delay = c.String(),
                        Plane_Capacity = c.String(),
                    })
                .PrimaryKey(t => t.FlightID);
            
            CreateTable(
                "dbo.UserFlights",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Airways = c.Int(nullable: false),
                        FROM = c.Int(nullable: false),
                        TO = c.Int(nullable: false),
                        SeatType = c.Int(nullable: false),
                        NumAdults = c.Int(nullable: false),
                        NumAChild = c.Int(nullable: false),
                        Departure_Date = c.DateTime(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        Return_Flight = c.Boolean(nullable: false),
                        Return_Date = c.DateTime(nullable: false),
                        Return_Time = c.DateTime(nullable: false),
                        Airline_Fee = c.Double(nullable: false),
                        Ticket_Price = c.Double(nullable: false),
                        passenger_Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserFlights");
            DropTable("dbo.Flights");
        }
    }
}
