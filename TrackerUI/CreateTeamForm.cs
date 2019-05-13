using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI {
  public partial class CreateTeamForm : Form {
    private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
    private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

    public CreateTeamForm() {
      InitializeComponent();
      //CreateSimpleData();
      WireUpLists();
    }

    private void CreateSimpleData() {
      availableTeamMembers.Add(new PersonModel { FirstName = "Ali", LastName = "Belachkar" });
      availableTeamMembers.Add(new PersonModel { FirstName = "Steave", LastName = "Kamlin" });

      selectedTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Rover" });
      selectedTeamMembers.Add(new PersonModel { FirstName = "Mahdi", LastName = "Belachkar" });
    }

    private void WireUpLists() {
      selectTeamMemeberDropDownCB.DataSource = null;
      selectTeamMemeberDropDownCB.DataSource = availableTeamMembers;
      selectTeamMemeberDropDownCB.DisplayMember = "FullName";

      tournamentMembersListBox.DataSource = null;
      tournamentMembersListBox.DataSource = selectedTeamMembers;
      tournamentMembersListBox.DisplayMember = "FullName";
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

    private void AddTeamMemberBtn_Click(object sender, EventArgs e) {
      PersonModel p = (PersonModel)selectTeamMemeberDropDownCB.SelectedItem;

      if (p != null) {
        availableTeamMembers.Remove(p);
        selectedTeamMembers.Add(p);

        WireUpLists(); 
      }
    }

    private void RemoveSelectedMemberBtn_Click(object sender, EventArgs e) {
      PersonModel p = (PersonModel)tournamentMembersListBox.SelectedItem;

      if (p != null) {
        selectedTeamMembers.Remove(p);
        availableTeamMembers.Add(p);

        WireUpLists(); 
      }
    }
  }
}
