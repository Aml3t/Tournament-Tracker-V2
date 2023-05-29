using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailAddress { get; set; }
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
