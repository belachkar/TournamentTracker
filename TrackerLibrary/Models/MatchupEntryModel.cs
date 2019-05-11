namespace TrackerLibrary.Models {

  /// <summary>
  /// Represents one team in a matchup.
  /// </summary>
  public class MatchupEntryModel {

    /// <summary>
    /// Represets one team in the matchup.
    /// </summary>
    public TeamModel TeamCompeating { get; set; }

    /// <summary>
    /// Represents the score for this particular team.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Represents the matchup that this team came from as winner.
    /// </summary>
    public MatchupModel ParentMatchup { get; set; }

  }
}
