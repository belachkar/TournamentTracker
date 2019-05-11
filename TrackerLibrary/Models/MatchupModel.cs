using System.Collections.Generic;

namespace TrackerLibrary.Models {

  /// <summary>
  /// Represents one match in the tounament.
  /// </summary>
  public class MatchupModel {

    /// <summary>
    /// Teh set of teams that are involved in this match.
    /// </summary>
    public List<MatchupEntryModel> Entries { get; set; }

    /// <summary>
    /// The winner of the match.
    /// </summary>
    public TeamModel Winner { get; set; }

    /// <summary>
    /// Which round this match is a part of.
    /// </summary>
    public int MatchupRound { get; set; }

  }
}
