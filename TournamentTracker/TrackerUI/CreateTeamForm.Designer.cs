namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.TeamNameBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.AddMemeberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.CellPhoneNumberValue = new System.Windows.Forms.TextBox();
            this.CellPhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailAddressValue = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.LastNameBoxValue = new System.Windows.Forms.TextBox();
            this.LastNameValue = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.TeanNameTextBox = new System.Windows.Forms.TextBox();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.Location = new System.Drawing.Point(19, 122);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(275, 35);
            this.TeamNameBox.TabIndex = 13;
            this.TeamNameBox.TextChanged += new System.EventHandler(this.teamOneScoreBox_TextChanged);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.Location = new System.Drawing.Point(14, 89);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(128, 30);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.TournamentNameLabel_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(187, 40);
            this.HeaderLabel.TabIndex = 11;
            this.HeaderLabel.Text = "Create Team";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // AddMemeberButton
            // 
            this.AddMemeberButton.Location = new System.Drawing.Point(19, 250);
            this.AddMemeberButton.Name = "AddMemeberButton";
            this.AddMemeberButton.Size = new System.Drawing.Size(224, 44);
            this.AddMemeberButton.TabIndex = 19;
            this.AddMemeberButton.Text = "Add Member";
            this.AddMemeberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(19, 206);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(275, 38);
            this.SelectTeamMemberDropDown.TabIndex = 18;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(15, 173);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(216, 30);
            this.SelectTeamMemberLabel.TabIndex = 17;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            this.SelectTeamMemberLabel.Click += new System.EventHandler(this.SelectTeamMemberLabel_Click);
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberGroupBox.Controls.Add(this.CellPhoneNumberValue);
            this.AddNewMemberGroupBox.Controls.Add(this.CellPhoneNumberLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailAddressValue);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailAddressLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameBoxValue);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(30, 333);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(264, 267);
            this.AddNewMemberGroupBox.TabIndex = 20;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.CreateMemberButton.Location = new System.Drawing.Point(46, 220);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(134, 32);
            this.CreateMemberButton.TabIndex = 21;
            this.CreateMemberButton.Text = "CreateMember";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CellPhoneNumberValue
            // 
            this.CellPhoneNumberValue.Location = new System.Drawing.Point(117, 167);
            this.CellPhoneNumberValue.Name = "CellPhoneNumberValue";
            this.CellPhoneNumberValue.Size = new System.Drawing.Size(131, 35);
            this.CellPhoneNumberValue.TabIndex = 16;
            // 
            // CellPhoneNumberLabel
            // 
            this.CellPhoneNumberLabel.AutoSize = true;
            this.CellPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.CellPhoneNumberLabel.Location = new System.Drawing.Point(6, 182);
            this.CellPhoneNumberLabel.Name = "CellPhoneNumberLabel";
            this.CellPhoneNumberLabel.Size = new System.Drawing.Size(86, 20);
            this.CellPhoneNumberLabel.TabIndex = 15;
            this.CellPhoneNumberLabel.Text = "Cell Phone ";
            // 
            // EmailAddressValue
            // 
            this.EmailAddressValue.Location = new System.Drawing.Point(117, 126);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.Size = new System.Drawing.Size(131, 35);
            this.EmailAddressValue.TabIndex = 14;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.EmailAddressLabel.Location = new System.Drawing.Point(3, 141);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(108, 20);
            this.EmailAddressLabel.TabIndex = 13;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // LastNameBoxValue
            // 
            this.LastNameBoxValue.Location = new System.Drawing.Point(117, 85);
            this.LastNameBoxValue.Name = "LastNameBoxValue";
            this.LastNameBoxValue.Size = new System.Drawing.Size(131, 35);
            this.LastNameBoxValue.TabIndex = 12;
            // 
            // LastNameValue
            // 
            this.LastNameValue.AutoSize = true;
            this.LastNameValue.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.LastNameValue.Location = new System.Drawing.Point(6, 100);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(84, 20);
            this.LastNameValue.TabIndex = 11;
            this.LastNameValue.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(117, 44);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(131, 35);
            this.FirstNameValue.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 59);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.Click += new System.EventHandler(this.TeamOneScoreLabel_Click);
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.ItemHeight = 30;
            this.TeamMemberListBox.Location = new System.Drawing.Point(324, 115);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(282, 422);
            this.TeamMemberListBox.TabIndex = 21;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(324, 568);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(282, 32);
            this.DeleteSelectedMemberButton.TabIndex = 22;
            this.DeleteSelectedMemberButton.Text = "Delete Selected";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedMemberButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.Location = new System.Drawing.Point(161, 643);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(282, 32);
            this.CreateTeamButton.TabIndex = 23;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // TeanNameTextBox
            // 
            this.TeanNameTextBox.Location = new System.Drawing.Point(18, 122);
            this.TeanNameTextBox.Name = "TeanNameTextBox";
            this.TeanNameTextBox.Size = new System.Drawing.Size(275, 35);
            this.TeanNameTextBox.TabIndex = 13;
            this.TeanNameTextBox.TextChanged += new System.EventHandler(this.teamOneScoreBox_TextChanged);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 709);
            this.Controls.Add(this.AddMemeberButton);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeanNameTextBox);
            this.Controls.Add(this.TeamNameBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team Form";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameBox;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button AddMemeberButton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropDown;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMemberGroupBox;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox CellPhoneNumberValue;
        private System.Windows.Forms.Label CellPhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailAddressValue;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox LastNameBoxValue;
        private System.Windows.Forms.Label LastNameValue;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Button DeleteSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.TextBox TeanNameTextBox;
    }
}