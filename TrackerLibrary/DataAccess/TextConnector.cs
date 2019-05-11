using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess {
  public class TextConnector : IDataConnection {
    public PrizeModel CreatePrize(PrizeModel model) {

      // TODO - Make the create prize methode save to the Text file.
      model.id = 1;
      return model;
    }
  }
}
