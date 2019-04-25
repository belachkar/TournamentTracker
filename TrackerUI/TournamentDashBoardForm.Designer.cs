namespace TrackerUI {
  partial class TournamentDashBoardForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashBoardForm));
      this.headerLabel = new System.Windows.Forms.Label();
      this.loadExistingTournamentDropDownCB = new System.Windows.Forms.ComboBox();
      this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
      this.loadTournamentBtn = new System.Windows.Forms.Button();
      this.createTournamentBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.headerLabel.Location = new System.Drawing.Point(45, 25);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(392, 50);
      this.headerLabel.TabIndex = 14;
      this.headerLabel.Text = "Tournament Dashboard";
      // 
      // loadExistingTournamentDropDownCB
      // 
      this.loadExistingTournamentDropDownCB.FormattingEnabled = true;
      this.loadExistingTournamentDropDownCB.Location = new System.Drawing.Point(54, 161);
      this.loadExistingTournamentDropDownCB.Name = "loadExistingTournamentDropDownCB";
      this.loadExistingTournamentDropDownCB.Size = new System.Drawing.Size(266, 38);
      this.loadExistingTournamentDropDownCB.TabIndex = 21;
      // 
      // loadExistingTournamentLabel
      // 
      this.loadExistingTournamentLabel.AutoSize = true;
      this.loadExistingTournamentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
      this.loadExistingTournamentLabel.Location = new System.Drawing.Point(47, 105);
      this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
      this.loadExistingTournamentLabel.Size = new System.Drawing.Size(227, 37);
      this.loadExistingTournamentLabel.TabIndex = 20;
      this.loadExistingTournamentLabel.Text = "Load Tournament";
      // 
      // loadTournamentBtn
      // 
      this.loadTournamentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.loadTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.loadTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.loadTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.loadTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.loadTournamentBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loadTournamentBtn.ForeColor = System.Drawing.SystemColors.Highlight;
      this.loadTournamentBtn.Location = new System.Drawing.Point(326, 157);
      this.loadTournamentBtn.Name = "loadTournamentBtn";
      this.loadTournamentBtn.Size = new System.Drawing.Size(102, 45);
      this.loadTournamentBtn.TabIndex = 23;
      this.loadTournamentBtn.Text = "Load";
      this.loadTournamentBtn.UseVisualStyleBackColor = true;
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
      this.createTournamentBtn.Location = new System.Drawing.Point(130, 240);
      this.createTournamentBtn.Name = "createTournamentBtn";
      this.createTournamentBtn.Size = new System.Drawing.Size(223, 71);
      this.createTournamentBtn.TabIndex = 29;
      this.createTournamentBtn.Text = "Create Tournament";
      this.createTournamentBtn.UseVisualStyleBackColor = true;
      // 
      // TournamentDashBoardForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(483, 359);
      this.Controls.Add(this.createTournamentBtn);
      this.Controls.Add(this.loadTournamentBtn);
      this.Controls.Add(this.loadExistingTournamentDropDownCB);
      this.Controls.Add(this.loadExistingTournamentLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentDashBoardForm";
      this.Text = "Tournament DashBoard";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.ComboBox loadExistingTournamentDropDownCB;
    private System.Windows.Forms.Label loadExistingTournamentLabel;
    private System.Windows.Forms.Button loadTournamentBtn;
    private System.Windows.Forms.Button createTournamentBtn;
  }
}