using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents on person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// First name of the player
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the player
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email of the player
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Cellphone of the player
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
