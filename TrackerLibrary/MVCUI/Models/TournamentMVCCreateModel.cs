using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackerLibrary.Models;

namespace MVCUI.Models
{
    public class TournamentMVCCreateModel
    {
        [DisplayName("Tournament Name")]
        [Required]
        [StringLength(100,MinimumLength = 2)]
        public string TournamentName { get; set; }

        [DisplayName("Entry Fee")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal EntryFee { get; set; }

        [DisplayName("Entered Teams")]
        public List<SelectListItem> EnteredTeams { get; set; } = new List<SelectListItem>();

        public List<string> SelectedEnteredTeams { get; set; } = new List<string>();

        [DisplayName("Prizes")]
        public List<SelectListItem> Prizes { get; set; } = new List<SelectListItem>();

        public List<string> SelectedPrizes { get; set; } = new List<string>();
    }

}