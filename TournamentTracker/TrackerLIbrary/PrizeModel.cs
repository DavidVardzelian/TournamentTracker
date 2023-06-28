using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLIbrary
{
    /// <summary>
    /// Represents Prize for Tournament
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents number in prize for torunament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents name in prize for torunament.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents amout of prize.
        /// </summary>
        public decimal PrizeAmout { get; set; }
        /// <summary>
        /// Represents prize percentage. 
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
