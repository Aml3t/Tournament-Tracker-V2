using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [StringLength(100,MinimumLength = 2)]
        [Required]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public String LastName { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(50, MinimumLength = 6)]
        [Required]
        public String EmailAddress { get; set; }

        [Display(Name = "Mobile number")]
        [StringLength(20, MinimumLength = 10)]
        [Required]
        public String CellphoneNumber { get; set; }

        public string FullName
        {
            get 
            {
                return $"{FirstName} {LastName}";
            }

        }
    }
}
