using System.Collections.Generic;

namespace TrackerLibrary.Models {

  /// <summary>
  /// Represents one tournament.
  /// </summary>
  public class TournamentModel {

    /// <summary>
    /// The tournament name.
    /// </summary>
    public string Tournament { get; set; }

    /// <summary>
    /// The entry fee.
    /// </summary>
    public decimal EntryFee { get; set; }

    /// <summary>
    /// The list of teams in this tournament.
    /// </summary>
    public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

    /// <summary>
    /// The list of prizes for this tournament.
    /// </summary>
    public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

    /// <summary>
    /// The list of rounds.
    /// </summary>
    public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
  }
}
