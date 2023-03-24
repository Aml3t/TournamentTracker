namespace TrackerLibrary
{
    /// <summary>
    /// Represents one team in the matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// The score of the particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The matchup that this team came
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}