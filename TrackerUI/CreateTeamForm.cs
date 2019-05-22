using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI {
  public partial class CreateTeamForm : Form {
    ITeamRequester callingForm;
    private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
    private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

    public CreateTeamForm(ITeamRequester caller) {
      InitializeComponent();
      //CreateSimpleData();
      WireUpLists();
      callingForm = caller;
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

        p = GlobalConfig.Connection.CreatePerson(p);
        selectedTeamMembers.Add(p);
        WireUpLists();

        ClearCreateMembreFields();

      } else {
        MessageBox.Show("You need to fill in all the fields.");
      }
    }

    private bool IsFormValid() {
      HydrateCreateMemberFields();
      return IsCreateMembreFieldsValid();
    }

    private bool IsCreateMembreFieldsValid() {
      return !(
        firstNameTextBox.Text.Length == 0 ||
        lastNameTextBox.Text.Length == 0 ||
        emailTextBox.Text.Length == 0 ||
        cellPhoneNumberTextBox.Text.Length == 0);
    }

    private void HydrateCreateMemberFields() {
      firstNameTextBox.Text = firstNameTextBox.Text.Trim();
      lastNameTextBox.Text = lastNameTextBox.Text.Trim();
      emailTextBox.Text = emailTextBox.Text.Trim();
      cellPhoneNumberTextBox.Text = cellPhoneNumberTextBox.Text.Trim();
    }

    private void ClearCreateMembreFields() {
      firstNameTextBox.Text = "";
      lastNameTextBox.Text = "";
      emailTextBox.Text = "";
      cellPhoneNumberTextBox.Text = "";
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

    private void CreateTeamBtn_Click(object sender, EventArgs e) {
      TeamModel model = new TeamModel();
      teamNameTextBox.Text = teamNameTextBox.Text.Trim();

      if (teamNameTextBox.Text.Length > 0) {
        if (selectedTeamMembers.Count > 0) {
          model.TeamName = teamNameTextBox.Text;
          model.TeamMembers = selectedTeamMembers;
          GlobalConfig.Connection.CreateTeam(model);

          callingForm.TeamComplete(model);

          this.Close();
        } else {
          MessageBox.Show("You must select team membres, the list can not be empty");
        }
      } else {
        MessageBox.Show("You must specity a Team Name");
      }
    }
  }
}
