using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }
                                            = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database == true)
            {
                // TODO - Create the SQL Connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
                //string information = "SQL";
            }

            if (textfiles == true)
            {
                // TODO - Generate the txt file
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

    }
}
