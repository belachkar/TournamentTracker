﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI {
  public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester {
    List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
    List<TeamModel> selectedTeams = new List<TeamModel>();
    List<PrizeModel> selectedPrizes = new List<PrizeModel>();

    public CreateTournamentForm() {
      InitializeComponent();
      WireUpLists();
    }

    private void WireUpLists() {
      selectTeamDropDownCB.DataSource = null;
      selectTeamDropDownCB.DataSource = availableTeams;
      selectTeamDropDownCB.DisplayMember = "TeamName";

      tournamentTeamsListBox.DataSource = null;
      tournamentTeamsListBox.DataSource = selectedTeams;
      tournamentTeamsListBox.DisplayMember = "TeamName";

      prizesListBox.DataSource = null;
      prizesListBox.DataSource = selectedPrizes;
      prizesListBox.DisplayMember = "PlaceName";
    }

    private void AddTeamBtn_Click(object sender, System.EventArgs e) {
      TeamModel t = (TeamModel)selectTeamDropDownCB.SelectedItem;
      if (t != null) {
        availableTeams.Remove(t);
        selectedTeams.Add(t);

        WireUpLists();
      }
    }

    private void CreatePrizeBtn_Click(object sender, EventArgs e) {

      // Call the create prize form
      CreatePrizeForm frm = new CreatePrizeForm(this);
      frm.Show();
    }

    public void PrizeComplete(PrizeModel model) {

      // Get back from the form a prize model
      // Take the PrizeModel and put it into our list of selected prizes
      selectedPrizes.Add(model);
      WireUpLists();
    }

    public void TeamComplete(TeamModel model) {
      selectedTeams.Add(model);
      WireUpLists();
    }

    private void CreateNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      CreateTeamForm frm = new CreateTeamForm(this);
      frm.Show();
    }

    private void RemoveSelectedPlayerBtn_Click(object sender, EventArgs e) {
      TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

      if (t != null) {
        selectedTeams.Remove(t);
        availableTeams.Add(t);

        WireUpLists();
      }
    }

    private void RemoveSelectedPrizeBtn_Click(object sender, EventArgs e) {
      PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

      if (p != null) {
        selectedPrizes.Remove(p);

        WireUpLists();
      }
    }
  }
}
