namespace TrackerUI {
  partial class CreateTournamentForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
      this.headerLabel = new System.Windows.Forms.Label();
      this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
      this.tournamentNameLabel = new System.Windows.Forms.Label();
      this.entryrFeeTextBox = new System.Windows.Forms.TextBox();
      this.entryFeeLabel = new System.Windows.Forms.Label();
      this.selectTeamDropDownCB = new System.Windows.Forms.ComboBox();
      this.selectTeamLabel = new System.Windows.Forms.Label();
      this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
      this.addTeamBtn = new System.Windows.Forms.Button();
      this.createPrizeBtn = new System.Windows.Forms.Button();
      this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
      this.tournamentPlayersLabel = new System.Windows.Forms.Label();
      this.removeSelectedPrizeBtn = new System.Windows.Forms.Button();
      this.prizesLabel = new System.Windows.Forms.Label();
      this.prizesListBox = new System.Windows.Forms.ListBox();
      this.removeSelectedPlayerBtn = new System.Windows.Forms.Button();
      this.createTournamentBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.headerLabel.Location = new System.Drawing.Point(284, 25);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(317, 50);
      this.headerLabel.TabIndex = 1;
      this.headerLabel.Text = "Create Tournament";
      // 
      // tournamentNameTextBox
      // 
      this.tournamentNameTextBox.Location = new System.Drawing.Point(34, 142);
      this.tournamentNameTextBox.Name = "tournamentNameTextBox";
      this.tournamentNameTextBox.Size = new System.Drawing.Size(315, 35);
      this.tournamentNameTextBox.TabIndex = 11;
      // 
      // tournamentNameLabel
      // 
      this.tournamentNameLabel.AutoSize = true;
      this.tournamentNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.tournamentNameLabel.Location = new System.Drawing.Point(27, 100);
      this.tournamentNameLabel.Name = "tournamentNameLabel";
      this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
      this.tournamentNameLabel.TabIndex = 10;
      this.tournamentNameLabel.Text = "Tournament Name";
      // 
      // entryrFeeTextBox
      // 
      this.entryrFeeTextBox.Location = new System.Drawing.Point(158, 208);
      this.entryrFeeTextBox.Name = "entryrFeeTextBox";
      this.entryrFeeTextBox.Size = new System.Drawing.Size(118, 35);
      this.entryrFeeTextBox.TabIndex = 13;
      this.entryrFeeTextBox.Text = "0";
      // 
      // entryFeeLabel
      // 
      this.entryFeeLabel.AutoSize = true;
      this.entryFeeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.entryFeeLabel.Location = new System.Drawing.Point(27, 205);
      this.entryFeeLabel.Name = "entryFeeLabel";
      this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
      this.entryFeeLabel.TabIndex = 12;
      this.entryFeeLabel.Text = "Entry Fee";
      // 
      // selectTeamDropDownCB
      // 
      this.selectTeamDropDownCB.FormattingEnabled = true;
      this.selectTeamDropDownCB.Location = new System.Drawing.Point(34, 324);
      this.selectTeamDropDownCB.Name = "selectTeamDropDownCB";
      this.selectTeamDropDownCB.Size = new System.Drawing.Size(315, 38);
      this.selectTeamDropDownCB.TabIndex = 15;
      // 
      // selectTeamLabel
      // 
      this.selectTeamLabel.AutoSize = true;
      this.selectTeamLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.selectTeamLabel.Location = new System.Drawing.Point(27, 284);
      this.selectTeamLabel.Name = "selectTeamLabel";
      this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
      this.selectTeamLabel.TabIndex = 14;
      this.selectTeamLabel.Text = "Select Team";
      // 
      // createNewTeamLink
      // 
      this.createNewTeamLink.AutoSize = true;
      this.createNewTeamLink.Cursor = System.Windows.Forms.Cursors.Hand;
      this.createNewTeamLink.Location = new System.Drawing.Point(244, 291);
      this.createNewTeamLink.Name = "createNewTeamLink";
      this.createNewTeamLink.Size = new System.Drawing.Size(110, 30);
      this.createNewTeamLink.TabIndex = 16;
      this.createNewTeamLink.TabStop = true;
      this.createNewTeamLink.Text = "New Team";
      this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamLink_LinkClicked);
      // 
      // addTeamBtn
      // 
      this.addTeamBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.addTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.addTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.addTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addTeamBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addTeamBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.addTeamBtn.Location = new System.Drawing.Point(73, 395);
      this.addTeamBtn.Name = "addTeamBtn";
      this.addTeamBtn.Size = new System.Drawing.Size(246, 45);
      this.addTeamBtn.TabIndex = 17;
      this.addTeamBtn.Text = "Add Team";
      this.addTeamBtn.UseVisualStyleBackColor = true;
      this.addTeamBtn.Click += new System.EventHandler(this.AddTeamBtn_Click);
      // 
      // createPrizeBtn
      // 
      this.createPrizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.createPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.createPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createPrizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createPrizeBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.createPrizeBtn.Location = new System.Drawing.Point(73, 468);
      this.createPrizeBtn.Name = "createPrizeBtn";
      this.createPrizeBtn.Size = new System.Drawing.Size(246, 45);
      this.createPrizeBtn.TabIndex = 18;
      this.createPrizeBtn.Text = "Create Prize";
      this.createPrizeBtn.UseVisualStyleBackColor = true;
      this.createPrizeBtn.Click += new System.EventHandler(this.CreatePrizeBtn_Click);
      // 
      // tournamentTeamsListBox
      // 
      this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tournamentTeamsListBox.FormattingEnabled = true;
      this.tournamentTeamsListBox.ItemHeight = 30;
      this.tournamentTeamsListBox.Location = new System.Drawing.Point(429, 142);
      this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
      this.tournamentTeamsListBox.Size = new System.Drawing.Size(261, 152);
      this.tournamentTeamsListBox.TabIndex = 19;
      // 
      // tournamentPlayersLabel
      // 
      this.tournamentPlayersLabel.AutoSize = true;
      this.tournamentPlayersLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.tournamentPlayersLabel.Location = new System.Drawing.Point(422, 102);
      this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
      this.tournamentPlayersLabel.Size = new System.Drawing.Size(187, 37);
      this.tournamentPlayersLabel.TabIndex = 20;
      this.tournamentPlayersLabel.Text = "Team / Players";
      // 
      // removeSelectedPrizeBtn
      // 
      this.removeSelectedPrizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.removeSelectedPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.removeSelectedPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.removeSelectedPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.removeSelectedPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.removeSelectedPrizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.removeSelectedPrizeBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.removeSelectedPrizeBtn.Location = new System.Drawing.Point(724, 395);
      this.removeSelectedPrizeBtn.Name = "removeSelectedPrizeBtn";
      this.removeSelectedPrizeBtn.Size = new System.Drawing.Size(127, 84);
      this.removeSelectedPrizeBtn.TabIndex = 24;
      this.removeSelectedPrizeBtn.Text = "Remove Selected";
      this.removeSelectedPrizeBtn.UseVisualStyleBackColor = true;
      this.removeSelectedPrizeBtn.Click += new System.EventHandler(this.RemoveSelectedPrizeBtn_Click);
      // 
      // prizesLabel
      // 
      this.prizesLabel.AutoSize = true;
      this.prizesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.prizesLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.prizesLabel.Location = new System.Drawing.Point(422, 321);
      this.prizesLabel.Name = "prizesLabel";
      this.prizesLabel.Size = new System.Drawing.Size(85, 37);
      this.prizesLabel.TabIndex = 23;
      this.prizesLabel.Text = "Prizes";
      // 
      // prizesListBox
      // 
      this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.prizesListBox.FormattingEnabled = true;
      this.prizesListBox.ItemHeight = 30;
      this.prizesListBox.Location = new System.Drawing.Point(429, 361);
      this.prizesListBox.Name = "prizesListBox";
      this.prizesListBox.Size = new System.Drawing.Size(261, 152);
      this.prizesListBox.TabIndex = 22;
      // 
      // removeSelectedPlayerBtn
      // 
      this.removeSelectedPlayerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.removeSelectedPlayerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.removeSelectedPlayerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.removeSelectedPlayerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.removeSelectedPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.removeSelectedPlayerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.removeSelectedPlayerBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.removeSelectedPlayerBtn.Location = new System.Drawing.Point(724, 180);
      this.removeSelectedPlayerBtn.Name = "removeSelectedPlayerBtn";
      this.removeSelectedPlayerBtn.Size = new System.Drawing.Size(127, 84);
      this.removeSelectedPlayerBtn.TabIndex = 25;
      this.removeSelectedPlayerBtn.Text = "Remove Selected";
      this.removeSelectedPlayerBtn.UseVisualStyleBackColor = true;
      this.removeSelectedPlayerBtn.Click += new System.EventHandler(this.RemoveSelectedPlayerBtn_Click);
      // 
      // createTournamentBtn
      // 
      this.createTournamentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.createTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTournamentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createTournamentBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.createTournamentBtn.Location = new System.Drawing.Point(317, 549);
      this.createTournamentBtn.Name = "createTournamentBtn";
      this.createTournamentBtn.Size = new System.Drawing.Size(223, 71);
      this.createTournamentBtn.TabIndex = 26;
      this.createTournamentBtn.Text = "Create Tounament";
      this.createTournamentBtn.UseVisualStyleBackColor = true;
      // 
      // CreateTournamentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(893, 655);
      this.Controls.Add(this.createTournamentBtn);
      this.Controls.Add(this.removeSelectedPlayerBtn);
      this.Controls.Add(this.removeSelectedPrizeBtn);
      this.Controls.Add(this.prizesLabel);
      this.Controls.Add(this.prizesListBox);
      this.Controls.Add(this.tournamentPlayersLabel);
      this.Controls.Add(this.tournamentTeamsListBox);
      this.Controls.Add(this.createPrizeBtn);
      this.Controls.Add(this.addTeamBtn);
      this.Controls.Add(this.createNewTeamLink);
      this.Controls.Add(this.selectTeamDropDownCB);
      this.Controls.Add(this.selectTeamLabel);
      this.Controls.Add(this.entryrFeeTextBox);
      this.Controls.Add(this.entryFeeLabel);
      this.Controls.Add(this.tournamentNameTextBox);
      this.Controls.Add(this.tournamentNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTournamentForm";
      this.Text = "Create Tournament";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.TextBox tournamentNameTextBox;
    private System.Windows.Forms.Label tournamentNameLabel;
    private System.Windows.Forms.TextBox entryrFeeTextBox;
    private System.Windows.Forms.Label entryFeeLabel;
    private System.Windows.Forms.ComboBox selectTeamDropDownCB;
    private System.Windows.Forms.Label selectTeamLabel;
    private System.Windows.Forms.LinkLabel createNewTeamLink;
    private System.Windows.Forms.Button addTeamBtn;
    private System.Windows.Forms.Button createPrizeBtn;
    private System.Windows.Forms.ListBox tournamentTeamsListBox;
    private System.Windows.Forms.Label tournamentPlayersLabel;
    private System.Windows.Forms.Button removeSelectedPrizeBtn;
    private System.Windows.Forms.Label prizesLabel;
    private System.Windows.Forms.ListBox prizesListBox;
    private System.Windows.Forms.Button removeSelectedPlayerBtn;
    private System.Windows.Forms.Button createTournamentBtn;
  }
}