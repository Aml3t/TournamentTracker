using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// The name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The amount of the cash that should be paid to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The list of the teams that will compete.
        /// </summary>
        public List<List<TeamModel>> EnteredTeams { get; set; } = new List<List<TeamModel>>();

        /// <summary>
        /// The amount of the prize the team gets.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The number of Rounds to be played.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }
}
