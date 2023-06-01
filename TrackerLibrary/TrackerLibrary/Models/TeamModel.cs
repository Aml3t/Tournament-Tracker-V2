using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }

        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Display(Name = "Team Members List")]
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
