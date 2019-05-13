using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI {
  public partial class CreateTeamForm : Form {
    public CreateTeamForm() {
      InitializeComponent();
    }

    private void CreateMemberBtn_Click(object sender, EventArgs e) {
      if (IsFormValid()) {
        PersonModel p = new PersonModel();

        p.FirstName = firstNameTextBox.Text;
        p.LastName = lastNameTextBox.Text;
        p.EmailAddress = emailTextBox.Text;
        p.CellPhoneNbr = cellPhoneNumberTextBox.Text;

        GlobalConfig.Connection.CreatePerson(p);

        firstNameTextBox.Text = "";
        lastNameTextBox.Text = "";
        emailTextBox.Text = "";
        cellPhoneNumberTextBox.Text = "";

      } else {
        MessageBox.Show("You need to fill in all the fields.");
      }
    }

    private bool IsFormValid() {

      // TODO: Add validation to the form.
      bool output = true;

      firstNameTextBox.Text = firstNameTextBox.Text.Trim();
      lastNameTextBox.Text = lastNameTextBox.Text.Trim();
      emailTextBox.Text = emailTextBox.Text.Trim();
      cellPhoneNumberTextBox.Text = cellPhoneNumberTextBox.Text.Trim();

      if (
        firstNameTextBox.Text.Length == 0 ||
        lastNameTextBox.Text.Length == 0 ||
        emailTextBox.Text.Length == 0 ||
        cellPhoneNumberTextBox.Text.Length == 0
        ) {
        output = false;
      }



      return output;
    }
  }
}
