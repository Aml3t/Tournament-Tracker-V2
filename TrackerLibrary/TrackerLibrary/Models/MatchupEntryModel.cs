namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {

        public int Id { get; set; }

        public int TeamCompetingId { get; set; }

        public TeamModel TeamCompeting { get; set; }

        public double Score { get; set; }

        // The unique identifier for the parent matchup
        public int ParentMatchupId { get; set; }
        //Represents the matchup that this team came
        public MatchupModel ParentMatchup { get; set; }

    }
}