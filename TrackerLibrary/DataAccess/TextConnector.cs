using System.Collections.Generic;
using System.Linq;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess {
  public class TextConnector : IDataConnection {

    private const string PrizesFile = "PrizeModels.csv";
    private const string PeopleFile = "PersonModels.csv";

    // TODO - Make the create prize methode save to the Text file.
    public PrizeModel CreatePrize(PrizeModel model) {

      // Load the text file and Convert the text to List<PrizeModel>
      List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

      // Find max ID
      int currentId = 1;

      if (prizes.Count > 0) {
        currentId = prizes.OrderByDescending(x => x.id).First().id + 1;
      }
      model.id = currentId;

      // Add the new record with the new ID (max+ 1)
      prizes.Add(model);

      // Convert the prizes to List<string>
      // Save the List<string> to the text file
      prizes.SaveToPrizeFile(PrizesFile);
      return model;
    }

    public PersonModel CreatePerson(PersonModel model) {
      int currentId = 1;
      List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

      if (people.Count > 0) {
        currentId = people.OrderByDescending(x => x.id).First().id + 1;
      }

      model.id = currentId;

      people.Add(model);
      people.SaveToPeopleFile(PeopleFile);

      return model;
    }
  }
}
