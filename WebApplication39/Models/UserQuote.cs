using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication39.Models
{
    public class UserQuote
    {
        public TourList TourL { get; set; }
        public enum TourList
        {
            Ushaka,
            Kruger_National_Park
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("UserID")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Address is Required")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter Number of Adults")]
        [Display(Name = "Number of Adults")]

        public int NumAdults { get; set; }

        [Required(ErrorMessage = "Please enter Number of Kids")]
        [Display(Name = "Number of Kids")]
        public int NumKids { get; set; }

        [Required(ErrorMessage = "What is your Departure Date?")]
        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]

        public DateTime DepartureDate { get; set; }

        [Required(ErrorMessage = "What is your Return Date?")]
        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Hotels")]
        public bool Hotels { get; set; }

        [Display(Name = "Tours")]
        public bool Tours { get; set; }

        [Display(Name = "Cruises")]
        public bool Cruises { get; set; }

        [Display(Name = "Flights")]
        public bool Flights { get; set; }

    }
}