using Dapper;
using System.Data;
using TrackerLibrary.Models;

//@PlaceNbr int, 
//@PlaceName nvarchar(50),
//@PrizeAmount money,
//@PrizePercentage float,
//@id int = 0 output

namespace TrackerLibrary.DataAccess {
  public class SqlConnector : IDataConnection {

    /// <summary>
    /// Saves a new prize to the database.
    /// </summary>
    /// <param name="model"></param>
    /// <returns>The prize information, including the id.</returns>
    public PrizeModel CreatePrize(PrizeModel model) {

      // Using using to close the connection properly for the code between the curely brackets.
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"))) {
        var p = new DynamicParameters();
        p.Add("@PlaceNbr", model.PlaceNumber);
        p.Add("@PlaceName", model.PlaceName);
        p.Add("@PrizeAmount", model.PrizeAmount);
        p.Add("@PrizePercentage", model.PrizePercentage);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

        model.id = p.Get<int>("@id");

        return model;
      }
    }

    public PersonModel CreatePerson(PersonModel model) {
      // Using using to close the connection properly for the code between the curely brackets.
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"))) {
        var p = new DynamicParameters();
        p.Add("@FirstName", model.FirstName);
        p.Add("@LastName", model.LastName);
        p.Add("@EmailAddress", model.EmailAddress);
        p.Add("@CellPhoneNbr", model.CellPhoneNbr);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

        model.id = p.Get<int>("@id");

        return model;
      }
    }
  }
}
