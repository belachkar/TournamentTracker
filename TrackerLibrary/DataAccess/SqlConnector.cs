using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess {
  public class SqlConnector : IDataConnection {

    /// <summary>
    /// Saves a new prize to the database.
    /// </summary>
    /// <param name="model"></param>
    /// <returns>The prize information, including the id.</returns>
    public PrizeModel CreatePrize(PrizeModel model) {

      // TODO - Make the create prize methode save to the database.
      model.id = 1;
      return model;
    }
  }
}
