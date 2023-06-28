using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLIbrary
{
    /// <summary>
    /// Represents Team in trournament.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents one team member in team.
        /// </summary>
        public List<PersonModel> TeamMember { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents name of team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
