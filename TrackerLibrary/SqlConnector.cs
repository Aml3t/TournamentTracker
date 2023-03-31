﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method to actually save to the database.
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, with the unique identifier.</returns>

        public string Information { get; private set; } = "SQL";
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            
            return model;
        }

    }
}
