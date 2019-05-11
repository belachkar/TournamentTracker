using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI {
  public partial class CreatePrizeForm : Form {
    public CreatePrizeForm() {
      InitializeComponent();
    }

    private void CreatePrizeBtn_Click(object sender, EventArgs e) {
      if (IsFormValid()) {
        PrizeModel model = new PrizeModel(
          placeNameTextBox.Text, 
          placeNumberTextBox.Text, 
          prizeAmountTextBox.Text, 
          prizePercentageTextBox.Text);

        GlobalConfig.Connection.CreatePrize(model);

        placeNameTextBox.Text = "";
        placeNumberTextBox.Text = "";
        prizeAmountTextBox.Text = "0";
        prizePercentageTextBox.Text = "0";
      } else {
        MessageBox.Show("This form has invalid information. Please check it and try again.");
      }
    }

    private bool IsFormValid() {
      bool output = true;
      int placeNbr = 0;
      bool isPlaceNbrValidNbr = int.TryParse(placeNumberTextBox.Text, out placeNbr);

      if (!isPlaceNbrValidNbr) {
        output = false;
      }
      if (placeNbr < 1) {
        output = false;
      }
      if (placeNumberTextBox.Text.Length == 0) {
        output = false;
      }
      decimal prizeAmount = 0;
      double prizePercentage = 0;

      bool isPrizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
      bool isPrizePercentageValid = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);

      if (!isPrizeAmountValid || !isPrizePercentageValid) {
        output = false;
      }
      if (prizeAmount <= 0 && prizePercentage <= 0) {
        output = false;
      }
      if (prizePercentage < 0 || prizePercentage > 100) {
        output = false;
      }

      return output;
    }
  }
}
