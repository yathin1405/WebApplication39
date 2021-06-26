using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication39.Models
{
    public class Flight
    {
        public Airline1 Airways { get; set; }
        public enum Airline1
        {
            Mango,
            SAA,
            British_Airways,
            Kulula,

        }
        public From1 FROM { get; set; }
        public enum From1
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public To1 TO { get; set; }
        public enum To1
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public Class1 SeatType { get; set; }
        public enum Class1
        {
            Economy,
            Business,
            First,

        }
        public Passenger1 PassengerType { get; set; }
        public enum Passenger1
        {
            Adult,
            child,
            infant,
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
       
        public int FlightID { get; set; }
        
        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime Departure_Date { get; set; }

        [Display(Name = "Departure Time")]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }

        [Display(Name = "Return Flight")]
        public bool Return_Flight { get; set; }

        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        public DateTime Return_Date { get; set; }

        [Display(Name = "Return Time")]
        [DataType(DataType.Time)]
        public DateTime Return_Time { get; set; } 
        //[Display(Name = "Plane Name")]
        //public string Plane_Name { get; set; }

        [Display(Name = "Flight Duration")]
        public string Flight_Duration { get; set; }

        [Display(Name = "Flight Delay")]
        public bool FDelay { get; set; }
        [Display(Name = "Estimated Flight Delay")]
        public string Flight_Delay { get; set; }

        
        [Display(Name = "Plane Capacity")]
        public string Plane_Capacity { get; set; }
       
     

        //[Display(Name = "Ticket Price")]
        //[Required(ErrorMessage = "Price Required")]
        //public float Price { get; set; }

       

        
        public enum SeatAvail
        {
            Available,
            Unavailable,
        }
    

        //for(i=Plane_Capacity;NumOfTickets<Plane_Capacity;i--){}

    }
}
    
