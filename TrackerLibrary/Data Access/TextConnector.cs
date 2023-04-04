using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method to actually save text files.
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, with the unique identifier.</returns>

        public string Information { get; private set; } = "Text File";
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            // Find the max ID
            // Add the new record with the new ID (max +1)
            // Convert the prizes to List<string>
            // Save the List<string> to the text file

            return model;
        }
    }
}
