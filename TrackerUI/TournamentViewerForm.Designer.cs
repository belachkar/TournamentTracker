namespace TrackerUI {
  partial class TournamentViewerForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
      this.headerLabel = new System.Windows.Forms.Label();
      this.TounamentNameLabel = new System.Windows.Forms.Label();
      this.roundLabel = new System.Windows.Forms.Label();
      this.roundDropDownCB = new System.Windows.Forms.ComboBox();
      this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
      this.matchupListBox = new System.Windows.Forms.ListBox();
      this.teamOneNameLabel = new System.Windows.Forms.Label();
      this.scoreOneLabel = new System.Windows.Forms.Label();
      this.teamTwoLabel = new System.Windows.Forms.Label();
      this.teamOneScoreTextBox = new System.Windows.Forms.TextBox();
      this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
      this.scoreTwoLabel = new System.Windows.Forms.Label();
      this.vsLabel = new System.Windows.Forms.Label();
      this.scoreBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.headerLabel.Location = new System.Drawing.Point(13, 13);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(220, 50);
      this.headerLabel.TabIndex = 0;
      this.headerLabel.Text = "Tournament:";
      // 
      // TounamentNameLabel
      // 
      this.TounamentNameLabel.AutoSize = true;
      this.TounamentNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.TounamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TounamentNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.TounamentNameLabel.Location = new System.Drawing.Point(225, 13);
      this.TounamentNameLabel.Name = "TounamentNameLabel";
      this.TounamentNameLabel.Size = new System.Drawing.Size(150, 50);
      this.TounamentNameLabel.TabIndex = 1;
      this.TounamentNameLabel.Text = "<none>";
      // 
      // roundLabel
      // 
      this.roundLabel.AutoSize = true;
      this.roundLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.roundLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.roundLabel.Location = new System.Drawing.Point(22, 93);
      this.roundLabel.Name = "roundLabel";
      this.roundLabel.Size = new System.Drawing.Size(95, 37);
      this.roundLabel.TabIndex = 2;
      this.roundLabel.Text = "Round";
      // 
      // roundDropDownCB
      // 
      this.roundDropDownCB.FormattingEnabled = true;
      this.roundDropDownCB.Location = new System.Drawing.Point(123, 92);
      this.roundDropDownCB.Name = "roundDropDownCB";
      this.roundDropDownCB.Size = new System.Drawing.Size(209, 38);
      this.roundDropDownCB.TabIndex = 3;
      // 
      // unplayedOnlyCheckbox
      // 
      this.unplayedOnlyCheckbox.AutoSize = true;
      this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.unplayedOnlyCheckbox.ForeColor = System.Drawing.SystemColors.Highlight;
      this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(123, 137);
      this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
      this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(209, 41);
      this.unplayedOnlyCheckbox.TabIndex = 4;
      this.unplayedOnlyCheckbox.Text = "Unplayed Only";
      this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
      // 
      // matchupListBox
      // 
      this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.matchupListBox.FormattingEnabled = true;
      this.matchupListBox.ItemHeight = 30;
      this.matchupListBox.Location = new System.Drawing.Point(29, 199);
      this.matchupListBox.Name = "matchupListBox";
      this.matchupListBox.Size = new System.Drawing.Size(303, 242);
      this.matchupListBox.TabIndex = 5;
      // 
      // teamOneNameLabel
      // 
      this.teamOneNameLabel.AutoSize = true;
      this.teamOneNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.teamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamOneNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.teamOneNameLabel.Location = new System.Drawing.Point(370, 192);
      this.teamOneNameLabel.Name = "teamOneNameLabel";
      this.teamOneNameLabel.Size = new System.Drawing.Size(174, 37);
      this.teamOneNameLabel.TabIndex = 6;
      this.teamOneNameLabel.Text = "<Team One>";
      // 
      // scoreOneLabel
      // 
      this.scoreOneLabel.AutoSize = true;
      this.scoreOneLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.scoreOneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.scoreOneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.scoreOneLabel.Location = new System.Drawing.Point(370, 242);
      this.scoreOneLabel.Name = "scoreOneLabel";
      this.scoreOneLabel.Size = new System.Drawing.Size(82, 37);
      this.scoreOneLabel.TabIndex = 7;
      this.scoreOneLabel.Text = "Score";
      // 
      // teamTwoLabel
      // 
      this.teamTwoLabel.AutoSize = true;
      this.teamTwoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.teamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamTwoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.teamTwoLabel.Location = new System.Drawing.Point(370, 353);
      this.teamTwoLabel.Name = "teamTwoLabel";
      this.teamTwoLabel.Size = new System.Drawing.Size(175, 37);
      this.teamTwoLabel.TabIndex = 8;
      this.teamTwoLabel.Text = "<Team Two>";
      // 
      // teamOneScoreTextBox
      // 
      this.teamOneScoreTextBox.Location = new System.Drawing.Point(458, 242);
      this.teamOneScoreTextBox.Name = "teamOneScoreTextBox";
      this.teamOneScoreTextBox.Size = new System.Drawing.Size(100, 35);
      this.teamOneScoreTextBox.TabIndex = 9;
      // 
      // teamTwoScoreTextBox
      // 
      this.teamTwoScoreTextBox.Location = new System.Drawing.Point(458, 402);
      this.teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
      this.teamTwoScoreTextBox.Size = new System.Drawing.Size(100, 35);
      this.teamTwoScoreTextBox.TabIndex = 11;
      // 
      // scoreTwoLabel
      // 
      this.scoreTwoLabel.AutoSize = true;
      this.scoreTwoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.scoreTwoLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.scoreTwoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.scoreTwoLabel.Location = new System.Drawing.Point(370, 402);
      this.scoreTwoLabel.Name = "scoreTwoLabel";
      this.scoreTwoLabel.Size = new System.Drawing.Size(82, 37);
      this.scoreTwoLabel.TabIndex = 10;
      this.scoreTwoLabel.Text = "Score";
      // 
      // vsLabel
      // 
      this.vsLabel.AutoSize = true;
      this.vsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.vsLabel.Location = new System.Drawing.Point(429, 304);
      this.vsLabel.Name = "vsLabel";
      this.vsLabel.Size = new System.Drawing.Size(53, 30);
      this.vsLabel.TabIndex = 12;
      this.vsLabel.Text = "-VS-";
      // 
      // scoreBtn
      // 
      this.scoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.scoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.scoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.scoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.scoreBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.scoreBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.scoreBtn.Location = new System.Drawing.Point(586, 304);
      this.scoreBtn.Name = "scoreBtn";
      this.scoreBtn.Size = new System.Drawing.Size(163, 79);
      this.scoreBtn.TabIndex = 13;
      this.scoreBtn.Text = "Score";
      this.scoreBtn.UseVisualStyleBackColor = true;
      // 
      // TournamentViewerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(775, 487);
      this.Controls.Add(this.scoreBtn);
      this.Controls.Add(this.vsLabel);
      this.Controls.Add(this.teamTwoScoreTextBox);
      this.Controls.Add(this.scoreTwoLabel);
      this.Controls.Add(this.teamOneScoreTextBox);
      this.Controls.Add(this.teamTwoLabel);
      this.Controls.Add(this.scoreOneLabel);
      this.Controls.Add(this.teamOneNameLabel);
      this.Controls.Add(this.matchupListBox);
      this.Controls.Add(this.unplayedOnlyCheckbox);
      this.Controls.Add(this.roundDropDownCB);
      this.Controls.Add(this.roundLabel);
      this.Controls.Add(this.TounamentNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentViewerForm";
      this.Text = "Tournament Viewer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label TounamentNameLabel;
    private System.Windows.Forms.Label roundLabel;
    private System.Windows.Forms.ComboBox roundDropDownCB;
    private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
    private System.Windows.Forms.ListBox matchupListBox;
    private System.Windows.Forms.Label teamOneNameLabel;
    private System.Windows.Forms.Label scoreOneLabel;
    private System.Windows.Forms.Label teamTwoLabel;
    private System.Windows.Forms.TextBox teamOneScoreTextBox;
    private System.Windows.Forms.TextBox teamTwoScoreTextBox;
    private System.Windows.Forms.Label scoreTwoLabel;
    private System.Windows.Forms.Label vsLabel;
    private System.Windows.Forms.Button scoreBtn;
  }
}

