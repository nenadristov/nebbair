using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NebbAir.Models
{



    public class Patnici
    {
        [Key]
        public int PatnikID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string Ime { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string Prezime { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DataNaRagjanje { get; set; }

        [Required]
        [Display(Name = "Passport Number")]
        public string PassporNo { get; set; }

        [Required]
        [Display(Name = "Flight Number")]
        public string FlightNo { get; set; }

        [Required]
        [Display(Name = "Origin")]
        public string Origin { get; set; }

        [Required]
        [Display(Name = "Destination")]
        public string Destination { get; set; }

        [Required]
        [Display(Name = "Departure")]
        public DateTime Departure { get; set; }

        [Display(Name = "Return")]
        public DateTime Return { get; set; }

        [Required]
        [Display(Name = "Carry On")]
        public int CarryOn { get; set; }

        [Required]
        [Display(Name = "Trolley")]
        public int Trolley { get; set; }

        [Required]
        [Display(Name = "Check In")]
        public int CheckIn { get; set; }
    }
}
