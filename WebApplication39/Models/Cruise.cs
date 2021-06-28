using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication39.Models
{
    public class Cruise
    {
        public Ships ShipName { get; set; }
        public enum Ships
        {
            Princess_Cruises,
            Costa_Cruises,
            MSC_Cruises,
            Royal_Caribbean_Cruises,

        }

        public From FROM { get; set; }
        public enum From
        {
            Port_Elizabeth,
            Durban,
            Capetown,

        }
        public To TO { get; set; }
        public enum To
        {
            Port_Elizabeth,
            Durban,
            Capetown,

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Cruise ID")]
        public int CruiseID { get; set; }

        [Display(Name = "Ship Name")]
        public string Ship_Name { get; set; }

        [Display(Name = "Cruise Duration")]
        public string Cruise_Duration { get; set; }

        [Display(Name = "Number of passengers")]
        public string Num_Guests { get; set; }


        //[Display(Name = "From")]
        //public string LocationFrom { get; set; }
        //[Display(Name = "TO")]
        //public string LocationTO { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime Departure_Date { get; set; }


        [Display(Name = "Departure Time")]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }



    }
}