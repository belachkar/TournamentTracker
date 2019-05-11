using System.Collections.Generic;
using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary {
  public static class GlobalConfig {
    public static IDataConnection Connection { get; private set; }

    public static void InitializeConnections(DatabaseType db) {

      switch (db) {
        case DatabaseType.Sql:

          // TODO - Set up the  SQL connection properly
          SqlConnector sql = new SqlConnector();
          Connection = sql;
          break;
        case DatabaseType.TextFile:

          // TODO - Create the text Connection
          TextConnector text = new TextConnector();
          Connection = text;
          break;
        default:
          break;
      }
    }

    public static string CnnString(string name) {
      return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
  }
}

