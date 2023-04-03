using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }
       
        public static void InitializeConnections(DatabaseType db)
        {
                //switch (db)
                //{
                //    case DatabaseType.Sql:
                    
                //        SqlConnector sql = new SqlConnector();
                //        Connections = sql;
                //        break;

                //    case DatabaseType.TextFile:

                //        TextConnector text = new TextConnector();
                //        Connections = text;
                //        break;

                //    default:
                //        break;
                //}

            if (db == DatabaseType.Sql)
            {
                // TODO - Create the SQL Connection

                SqlConnector sql = new SqlConnector();
                Connections = sql;

            }

            else if (db == DatabaseType.TextFile)
            {
                // TODO - Generate the txt file
                TextConnector text = new TextConnector();
                Connections  = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
