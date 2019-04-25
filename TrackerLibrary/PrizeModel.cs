namespace TrackerLibrary {

  /// <summary>
  /// Represents one prize.
  /// </summary>
  public class PrizeModel {

    /// <summary>
    /// the prize place number.
    /// </summary>
    public int PlaceNumber { get; set; }

    /// <summary>
    /// The place name.
    /// </summary>
    public string PlaceName { get; set; }

    /// <summary>
    /// The prize amount.
    /// </summary>
    public decimal PrizeAmount { get; set; }

    /// <summary>
    /// The prize percentage.
    /// </summary>
    public double PrizePercentage { get; set; }

  }
}
