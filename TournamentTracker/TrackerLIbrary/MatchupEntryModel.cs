using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLIbrary
{
    /// <summary>
    /// Represents one team in a matchup.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCmpeting { get; set; } 
        /// <summary>
        /// Represents the score for ths particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team cam from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
