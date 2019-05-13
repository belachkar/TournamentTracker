namespace TrackerUI {
  partial class CreateTeamForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
      this.teamNameTextBox = new System.Windows.Forms.TextBox();
      this.teamNameLabel = new System.Windows.Forms.Label();
      this.headerLabel = new System.Windows.Forms.Label();
      this.addTeamMemberBtn = new System.Windows.Forms.Button();
      this.selectTeamMemeberDropDownCB = new System.Windows.Forms.ComboBox();
      this.selectTeamMemberLabel = new System.Windows.Forms.Label();
      this.addNewMemeberGroupBox = new System.Windows.Forms.GroupBox();
      this.createMemberBtn = new System.Windows.Forms.Button();
      this.cellPhoneNumberTextBox = new System.Windows.Forms.TextBox();
      this.cellPhoneLabel = new System.Windows.Forms.Label();
      this.emailTextBox = new System.Windows.Forms.TextBox();
      this.emailLabel = new System.Windows.Forms.Label();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNamelabel = new System.Windows.Forms.Label();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.tournamentMembersListBox = new System.Windows.Forms.ListBox();
      this.deleteSelectedMemberBtn = new System.Windows.Forms.Button();
      this.createTeamBtn = new System.Windows.Forms.Button();
      this.addNewMemeberGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // teamNameTextBox
      // 
      this.teamNameTextBox.Location = new System.Drawing.Point(34, 140);
      this.teamNameTextBox.Name = "teamNameTextBox";
      this.teamNameTextBox.Size = new System.Drawing.Size(360, 35);
      this.teamNameTextBox.TabIndex = 14;
      // 
      // teamNameLabel
      // 
      this.teamNameLabel.AutoSize = true;
      this.teamNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.teamNameLabel.Location = new System.Drawing.Point(27, 100);
      this.teamNameLabel.Name = "teamNameLabel";
      this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
      this.teamNameLabel.TabIndex = 13;
      this.teamNameLabel.Text = "Team Name";
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.headerLabel.Location = new System.Drawing.Point(285, 22);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(213, 50);
      this.headerLabel.TabIndex = 12;
      this.headerLabel.Text = "Create Team";
      // 
      // addTeamMemberBtn
      // 
      this.addTeamMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.addTeamMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addTeamMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.addTeamMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.addTeamMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addTeamMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addTeamMemberBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.addTeamMemberBtn.Location = new System.Drawing.Point(94, 286);
      this.addTeamMemberBtn.Name = "addTeamMemberBtn";
      this.addTeamMemberBtn.Size = new System.Drawing.Size(246, 45);
      this.addTeamMemberBtn.TabIndex = 20;
      this.addTeamMemberBtn.Text = "Add Member";
      this.addTeamMemberBtn.UseVisualStyleBackColor = true;
      // 
      // selectTeamMemeberDropDownCB
      // 
      this.selectTeamMemeberDropDownCB.FormattingEnabled = true;
      this.selectTeamMemeberDropDownCB.Location = new System.Drawing.Point(34, 233);
      this.selectTeamMemeberDropDownCB.Name = "selectTeamMemeberDropDownCB";
      this.selectTeamMemeberDropDownCB.Size = new System.Drawing.Size(360, 38);
      this.selectTeamMemeberDropDownCB.TabIndex = 19;
      // 
      // selectTeamMemberLabel
      // 
      this.selectTeamMemberLabel.AutoSize = true;
      this.selectTeamMemberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.selectTeamMemberLabel.Location = new System.Drawing.Point(27, 193);
      this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
      this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
      this.selectTeamMemberLabel.TabIndex = 18;
      this.selectTeamMemberLabel.Text = "Select Team Member";
      // 
      // addNewMemeberGroupBox
      // 
      this.addNewMemeberGroupBox.Controls.Add(this.createMemberBtn);
      this.addNewMemeberGroupBox.Controls.Add(this.cellPhoneNumberTextBox);
      this.addNewMemeberGroupBox.Controls.Add(this.cellPhoneLabel);
      this.addNewMemeberGroupBox.Controls.Add(this.emailTextBox);
      this.addNewMemeberGroupBox.Controls.Add(this.emailLabel);
      this.addNewMemeberGroupBox.Controls.Add(this.lastNameTextBox);
      this.addNewMemeberGroupBox.Controls.Add(this.lastNamelabel);
      this.addNewMemeberGroupBox.Controls.Add(this.firstNameTextBox);
      this.addNewMemeberGroupBox.Controls.Add(this.firstNameLabel);
      this.addNewMemeberGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
      this.addNewMemeberGroupBox.Location = new System.Drawing.Point(34, 365);
      this.addNewMemeberGroupBox.Name = "addNewMemeberGroupBox";
      this.addNewMemeberGroupBox.Size = new System.Drawing.Size(360, 357);
      this.addNewMemeberGroupBox.TabIndex = 21;
      this.addNewMemeberGroupBox.TabStop = false;
      this.addNewMemeberGroupBox.Text = "Add New Member";
      // 
      // createMemberBtn
      // 
      this.createMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.createMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.createMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createMemberBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.createMemberBtn.Location = new System.Drawing.Point(62, 281);
      this.createMemberBtn.Name = "createMemberBtn";
      this.createMemberBtn.Size = new System.Drawing.Size(246, 45);
      this.createMemberBtn.TabIndex = 22;
      this.createMemberBtn.Text = "Create Member";
      this.createMemberBtn.UseVisualStyleBackColor = true;
      this.createMemberBtn.Click += new System.EventHandler(this.CreateMemberBtn_Click);
      // 
      // cellPhoneNumberTextBox
      // 
      this.cellPhoneNumberTextBox.Location = new System.Drawing.Point(142, 217);
      this.cellPhoneNumberTextBox.Name = "cellPhoneNumberTextBox";
      this.cellPhoneNumberTextBox.Size = new System.Drawing.Size(194, 35);
      this.cellPhoneNumberTextBox.TabIndex = 21;
      // 
      // cellPhoneLabel
      // 
      this.cellPhoneLabel.AutoSize = true;
      this.cellPhoneLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cellPhoneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.cellPhoneLabel.Location = new System.Drawing.Point(23, 220);
      this.cellPhoneLabel.Name = "cellPhoneLabel";
      this.cellPhoneLabel.Size = new System.Drawing.Size(102, 30);
      this.cellPhoneLabel.TabIndex = 20;
      this.cellPhoneLabel.Text = "Phone N°";
      // 
      // emailTextBox
      // 
      this.emailTextBox.Location = new System.Drawing.Point(141, 161);
      this.emailTextBox.Name = "emailTextBox";
      this.emailTextBox.Size = new System.Drawing.Size(194, 35);
      this.emailTextBox.TabIndex = 19;
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.emailLabel.Location = new System.Drawing.Point(22, 164);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(63, 30);
      this.emailLabel.TabIndex = 18;
      this.emailLabel.Text = "Email";
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(143, 104);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(194, 35);
      this.lastNameTextBox.TabIndex = 17;
      // 
      // lastNamelabel
      // 
      this.lastNamelabel.AutoSize = true;
      this.lastNamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lastNamelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNamelabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lastNamelabel.Location = new System.Drawing.Point(24, 107);
      this.lastNamelabel.Name = "lastNamelabel";
      this.lastNamelabel.Size = new System.Drawing.Size(112, 30);
      this.lastNamelabel.TabIndex = 16;
      this.lastNamelabel.Text = "Last Name";
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(141, 54);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(194, 35);
      this.firstNameTextBox.TabIndex = 15;
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.firstNameLabel.Location = new System.Drawing.Point(22, 57);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
      this.firstNameLabel.TabIndex = 14;
      this.firstNameLabel.Text = "First Name";
      // 
      // tournamentMembersListBox
      // 
      this.tournamentMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tournamentMembersListBox.FormattingEnabled = true;
      this.tournamentMembersListBox.ItemHeight = 30;
      this.tournamentMembersListBox.Location = new System.Drawing.Point(456, 176);
      this.tournamentMembersListBox.Name = "tournamentMembersListBox";
      this.tournamentMembersListBox.Size = new System.Drawing.Size(303, 542);
      this.tournamentMembersListBox.TabIndex = 22;
      // 
      // deleteSelectedMemberBtn
      // 
      this.deleteSelectedMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.deleteSelectedMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.deleteSelectedMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.deleteSelectedMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.deleteSelectedMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteSelectedMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.deleteSelectedMemberBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.deleteSelectedMemberBtn.Location = new System.Drawing.Point(456, 118);
      this.deleteSelectedMemberBtn.Name = "deleteSelectedMemberBtn";
      this.deleteSelectedMemberBtn.Size = new System.Drawing.Size(303, 45);
      this.deleteSelectedMemberBtn.TabIndex = 23;
      this.deleteSelectedMemberBtn.Text = "Delete Selected";
      this.deleteSelectedMemberBtn.UseVisualStyleBackColor = true;
      // 
      // createTeamBtn
      // 
      this.createTeamBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.createTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.createTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTeamBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createTeamBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.createTeamBtn.Location = new System.Drawing.Point(294, 759);
      this.createTeamBtn.Name = "createTeamBtn";
      this.createTeamBtn.Size = new System.Drawing.Size(223, 71);
      this.createTeamBtn.TabIndex = 27;
      this.createTeamBtn.Text = "Create Team";
      this.createTeamBtn.UseVisualStyleBackColor = true;
      // 
      // CreateTeamForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(802, 863);
      this.Controls.Add(this.createTeamBtn);
      this.Controls.Add(this.deleteSelectedMemberBtn);
      this.Controls.Add(this.tournamentMembersListBox);
      this.Controls.Add(this.addNewMemeberGroupBox);
      this.Controls.Add(this.addTeamMemberBtn);
      this.Controls.Add(this.selectTeamMemeberDropDownCB);
      this.Controls.Add(this.selectTeamMemberLabel);
      this.Controls.Add(this.teamNameTextBox);
      this.Controls.Add(this.teamNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTeamForm";
      this.Text = "Create Team";
      this.addNewMemeberGroupBox.ResumeLayout(false);
      this.addNewMemeberGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox teamNameTextBox;
    private System.Windows.Forms.Label teamNameLabel;
    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Button addTeamMemberBtn;
    private System.Windows.Forms.ComboBox selectTeamMemeberDropDownCB;
    private System.Windows.Forms.Label selectTeamMemberLabel;
    private System.Windows.Forms.GroupBox addNewMemeberGroupBox;
    private System.Windows.Forms.Button createMemberBtn;
    private System.Windows.Forms.TextBox cellPhoneNumberTextBox;
    private System.Windows.Forms.Label cellPhoneLabel;
    private System.Windows.Forms.TextBox emailTextBox;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.TextBox lastNameTextBox;
    private System.Windows.Forms.Label lastNamelabel;
    private System.Windows.Forms.TextBox firstNameTextBox;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.ListBox tournamentMembersListBox;
    private System.Windows.Forms.Button deleteSelectedMemberBtn;
    private System.Windows.Forms.Button createTeamBtn;
  }
}