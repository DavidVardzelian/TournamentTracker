using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLIbrary
{
    /// <summary>
    /// Represents Trounament. 
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Represents Nama of Trounament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents EntryFee for Torunament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents Enetered Teams in Trounament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents Prizes for Torunament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents Rounds of Trounament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
