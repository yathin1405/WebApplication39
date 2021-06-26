using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication39.Models
{
    public class UserFlight
    {
      

        public Airline Airways { get; set; }
        public enum Airline
        {
            Mango,
            SAA,
            British_Airways,
            Kulula,

        }
        public From FROM { get; set; }
        public enum From
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public To TO { get; set; }
        public enum To
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public Class SeatType { get; set; }
        public enum Class
        {
            Economy,
            Business,
            First,

        }

        Flight user = new Flight();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        
        public int UserID { get; set; }

        [Display(Name = "Number of Adults")]
        public int NumAdults { get; set; }
        [Display(Name = "Number of children")]
        public int NumAChild{ get; set; }
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

            public double Airline_Fee { get; set; }
        
      
        public double AirlineFee()
        {
            double x = 0;

            if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = 500;

            }
            if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = 550;

            }
            if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = 600;

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = 650;

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = 700;

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = 750;

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = 800;

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = 850;

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = 900;

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = 1000;

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = 1050;

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = 200;

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = 500;

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = 550;

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = 600;

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = 650;

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = 700;

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = 750;

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = 800;

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = 850;

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = 900;

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = 1000;

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = 1050;

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = 200;

            }

            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = 500;

            }
            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = 550;

            }
            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = 600;

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = 650;

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = 700;

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = 750;

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = 800;

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = 850;

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = 900;

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = 1000;

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = 1050;

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = 200;

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = 500;

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = 550;

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = 600;

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = 650;

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = 700;

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = 750;

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = 800;

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = 850;

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = 900;

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = 1000;

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = 1050;

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = 200;

            }
            return x;

        }
        public double Ticket_Price { get; set; }
        public double ReturnTicketPrice()
        {
            double x = 0;


            if (SeatType == Class.Economy && Return_Flight == true)
            {
                x = ( passengerCost() + (passengerCost() * 0.60));
            }
            else if (SeatType == Class.Business && Return_Flight == true)
            {
                x = (passengerCost() + passengerCost() * 0.60);
            }
            else if (SeatType == Class.First && Return_Flight == true)
            {
                x = (passengerCost() + passengerCost() * 0.60);
            }
            else if (SeatType == Class.Business)
            {
                x =passengerCost();
            }
            else if (SeatType == Class.Economy)
            {
                x =  passengerCost();
            }
            else if (SeatType == Class.First)
            {
                x = passengerCost();
            }
            return x;
        }
        public double passenger_Cost { get; set; }
        public double passengerCost()
        {
            double x = 0;

            x = NumAdults * AirlineFee() + ((NumAChild * AirlineFee() * 0.50)); 
            return x;
        }

    }
}