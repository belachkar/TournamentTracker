namespace TrackerLibrary.Models {

  /// <summary>
  /// Represents one person.
  /// </summary>
  public class PersonModel {

    /// <summary>
    /// The unique identifier for the prize
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// The first name of the person.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of the person.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// The email of the person.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// The cell phonbe number of the person.
    /// </summary>
    public string CellPhoneNbr { get; set; }

    public string FullName {
      get { return $"{FirstName} {LastName}"; }
    }

  }
}
