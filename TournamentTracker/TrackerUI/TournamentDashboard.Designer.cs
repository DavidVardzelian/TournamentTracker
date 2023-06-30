namespace TrackerUI
{
    partial class TournamentDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboard));
            this.TournamentDashboardLabel = new System.Windows.Forms.Label();
            this.LoadTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTorunamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            resources.ApplyResources(this.TournamentDashboardLabel, "TournamentDashboardLabel");
            this.TournamentDashboardLabel.BackColor = System.Drawing.Color.White;
            this.TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            this.TournamentDashboardLabel.Click += new System.EventHandler(this.CreatePrizeLabel_Click);
            // 
            // LoadTournamentDropDown
            // 
            this.LoadTournamentDropDown.FormattingEnabled = true;
            resources.ApplyResources(this.LoadTournamentDropDown, "LoadTournamentDropDown");
            this.LoadTournamentDropDown.Name = "LoadTournamentDropDown";
            // 
            // LoadExistingTournamentLabel
            // 
            resources.ApplyResources(this.LoadExistingTournamentLabel, "LoadExistingTournamentLabel");
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            // 
            // LoadTournamentButton
            // 
            resources.ApplyResources(this.LoadTournamentButton, "LoadTournamentButton");
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTorunamentButton
            // 
            resources.ApplyResources(this.CreateTorunamentButton, "CreateTorunamentButton");
            this.CreateTorunamentButton.Name = "CreateTorunamentButton";
            this.CreateTorunamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CreateTorunamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadTournamentDropDown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.TournamentDashboardLabel);
            this.Name = "TournamentDashboard";
            this.Load += new System.EventHandler(this.TournamentDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardLabel;
        private System.Windows.Forms.ComboBox LoadTournamentDropDown;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTorunamentButton;
    }
}