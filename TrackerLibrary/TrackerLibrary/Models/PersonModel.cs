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
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Email Address")]
        public String EmailAddress { get; set; }

        [Display(Name = "Mobile number")]
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
