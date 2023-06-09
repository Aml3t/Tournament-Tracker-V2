using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCUI.Models
{
    public class TournamentMVCDetailsModel
    {
        [DisplayName("Tournament Name")]
        public string TournamentName { get; set; }
    }
}