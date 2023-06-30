namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.teamOneScoreBox = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeBox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TeamPlayerListBox = new System.Windows.Forms.ListBox();
            this.TeamPlayersLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(282, 40);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            // 
            // teamOneScoreBox
            // 
            this.teamOneScoreBox.Location = new System.Drawing.Point(19, 122);
            this.teamOneScoreBox.Name = "teamOneScoreBox";
            this.teamOneScoreBox.Size = new System.Drawing.Size(275, 35);
            this.teamOneScoreBox.TabIndex = 10;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.Location = new System.Drawing.Point(14, 89);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(196, 30);
            this.TournamentNameLabel.TabIndex = 9;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeBox
            // 
            this.EntryFeeBox.Location = new System.Drawing.Point(124, 183);
            this.EntryFeeBox.Name = "EntryFeeBox";
            this.EntryFeeBox.Size = new System.Drawing.Size(100, 35);
            this.EntryFeeBox.TabIndex = 12;
            this.EntryFeeBox.Text = "0";
            this.EntryFeeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.Location = new System.Drawing.Point(14, 188);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(104, 30);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee";
            this.EntryFeeLabel.Click += new System.EventHandler(this.TeamOneScoreLabel_Click);
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(19, 283);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(275, 38);
            this.SelectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.Location = new System.Drawing.Point(14, 250);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(128, 30);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team";
            this.SelectTeamLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // CreateNewLabel
            // 
            this.CreateNewLabel.AutoSize = true;
            this.CreateNewLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.CreateNewLabel.Location = new System.Drawing.Point(173, 250);
            this.CreateNewLabel.Name = "CreateNewLabel";
            this.CreateNewLabel.Size = new System.Drawing.Size(121, 30);
            this.CreateNewLabel.TabIndex = 15;
            this.CreateNewLabel.TabStop = true;
            this.CreateNewLabel.Text = "Create New";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Location = new System.Drawing.Point(47, 327);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(224, 44);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Location = new System.Drawing.Point(47, 377);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(224, 44);
            this.CreatePrizeButton.TabIndex = 17;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TeamPlayerListBox
            // 
            this.TeamPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamPlayerListBox.FormattingEnabled = true;
            this.TeamPlayerListBox.ItemHeight = 30;
            this.TeamPlayerListBox.Location = new System.Drawing.Point(362, 122);
            this.TeamPlayerListBox.Name = "TeamPlayerListBox";
            this.TeamPlayerListBox.Size = new System.Drawing.Size(223, 152);
            this.TeamPlayerListBox.TabIndex = 18;
            // 
            // TeamPlayersLabel
            // 
            this.TeamPlayersLabel.AutoSize = true;
            this.TeamPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamPlayersLabel.Location = new System.Drawing.Point(357, 89);
            this.TeamPlayersLabel.Name = "TeamPlayersLabel";
            this.TeamPlayersLabel.Size = new System.Drawing.Size(163, 30);
            this.TeamPlayersLabel.TabIndex = 19;
            this.TeamPlayersLabel.Text = "Teams / Players";
            this.TeamPlayersLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeleteSelectedPlayersButton
            // 
            this.DeleteSelectedPlayersButton.Location = new System.Drawing.Point(603, 155);
            this.DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            this.DeleteSelectedPlayersButton.Size = new System.Drawing.Size(127, 83);
            this.DeleteSelectedPlayersButton.TabIndex = 20;
            this.DeleteSelectedPlayersButton.Text = "Delete Selected";
            this.DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 83);
            this.button1.TabIndex = 23;
            this.button1.Text = "Delete Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Teams / Players";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 30;
            this.PrizesListBox.Location = new System.Drawing.Point(362, 322);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(223, 152);
            this.PrizesListBox.TabIndex = 21;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Location = new System.Drawing.Point(154, 499);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(412, 48);
            this.CreateTournamentButton.TabIndex = 24;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 559);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.DeleteSelectedPlayersButton);
            this.Controls.Add(this.TeamPlayersLabel);
            this.Controls.Add(this.TeamPlayerListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewLabel);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeBox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.teamOneScoreBox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox teamOneScoreBox;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeBox;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.ListBox TeamPlayerListBox;
        private System.Windows.Forms.Label TeamPlayersLabel;
        private System.Windows.Forms.Button DeleteSelectedPlayersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}