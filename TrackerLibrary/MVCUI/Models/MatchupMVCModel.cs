﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUI.Models
{
    public class MatchupMVCModel
    {
        public int MatchupId { get; set; }
        public int FirstTeamMatchupEntryId { get; set; }
        public string FirstTeamName { get; set; }
        public double FirstTeamScore { get; set; }
        public string SecondTeamName { get; set; }
        public double SecondTeamScore { get; set; }

    }
}