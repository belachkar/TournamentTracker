namespace TrackerLibrary.Models {

  /// <summary>
  /// Represents one prize.
  /// </summary>
  public class PrizeModel {

    /// <summary>
    /// The unique identifier for the prize
    /// </summary>
    public int Id { get; set; }

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

    public PrizeModel() {

    }

    public PrizeModel(string placeName, string placeNbr, string prizeAmount, string prizePercentage) {
      PlaceName = placeName;

      int placeNbrValue = 0;
      int.TryParse(placeNbr, out placeNbrValue);
      PlaceNumber = placeNbrValue;

      decimal prizeAmountValue = 0;
      decimal.TryParse(prizeAmount, out prizeAmountValue);
      PrizeAmount = prizeAmountValue;

      double prizePercentageValue = 0;
      double.TryParse(prizePercentage, out prizePercentageValue);
      PrizePercentage = prizePercentageValue;
    }

  }
}
