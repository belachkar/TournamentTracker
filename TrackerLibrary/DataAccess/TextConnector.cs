using System.Collections.Generic;
using System.Linq;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess {
  public class TextConnector : IDataConnection {

    private const string PrizesFile = "PrizeModels.csv";
    private const string PeopleFile = "PersonModels.csv";
    private const string TeamFile = "TeamModels.csv";
    public PrizeModel CreatePrize(PrizeModel model) {

      // Load the text file and Convert the text to List<PrizeModel>
      List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

      // Find max ID
      int currentId = 1;

      if (prizes.Count > 0) {
        currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;

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

    public List<PersonModel> GetPerson_All() {
      return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
    }

    public TeamModel CreateTeam(TeamModel model) {
      int currentId = 1;

      List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

      if (teams.Count > 0) {
        currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;

      teams.Add(model);
      teams.SaveToTeamFile(TeamFile);

      return model;
    }

    public List<TeamModel> GetTeam_All() {
      // TODO: Implemeante GetTeam_All function
      return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
    }
  }
}
