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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.AddTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.CellphoneValue = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListbox = new System.Windows.Forms.ListBox();
            this.removeSelectedMember = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(35, 161);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(409, 27);
            this.TeamNameValue.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TeamNameLabel.Location = new System.Drawing.Point(24, 97);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(192, 45);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.TournamentNameLabel_Click);
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createTeamLabel.Location = new System.Drawing.Point(12, 19);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(272, 62);
            this.createTeamLabel.TabIndex = 11;
            this.createTeamLabel.Text = "Create Team";
            // 
            // AddTeamMemberButton
            // 
            this.AddTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.AddTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTeamMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddTeamMemberButton.Location = new System.Drawing.Point(137, 322);
            this.AddTeamMemberButton.Name = "AddTeamMemberButton";
            this.AddTeamMemberButton.Size = new System.Drawing.Size(220, 53);
            this.AddTeamMemberButton.TabIndex = 19;
            this.AddTeamMemberButton.Text = "Add Member";
            this.AddTeamMemberButton.UseVisualStyleBackColor = true;
            this.AddTeamMemberButton.Click += new System.EventHandler(this.AddTeamMemberButton_Click);
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(35, 230);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(322, 45);
            this.selectTeamMemberLabel.TabIndex = 18;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(35, 278);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(409, 28);
            this.SelectTeamMemberDropDown.TabIndex = 17;
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberBox.Controls.Add(this.CellphoneValue);
            this.AddNewMemberBox.Controls.Add(this.CellphoneLabel);
            this.AddNewMemberBox.Controls.Add(this.emailValue);
            this.AddNewMemberBox.Controls.Add(this.emailLabel);
            this.AddNewMemberBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewMemberBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddNewMemberBox.Location = new System.Drawing.Point(35, 381);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Size = new System.Drawing.Size(409, 362);
            this.AddNewMemberBox.TabIndex = 20;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CreateMemberButton.Location = new System.Drawing.Point(79, 291);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(243, 53);
            this.CreateMemberButton.TabIndex = 21;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // CellphoneValue
            // 
            this.CellphoneValue.Location = new System.Drawing.Point(188, 234);
            this.CellphoneValue.Name = "CellphoneValue";
            this.CellphoneValue.Size = new System.Drawing.Size(173, 51);
            this.CellphoneValue.TabIndex = 28;
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellphoneLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CellphoneLabel.Location = new System.Drawing.Point(8, 220);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(166, 45);
            this.CellphoneLabel.TabIndex = 27;
            this.CellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(188, 177);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(173, 51);
            this.emailValue.TabIndex = 26;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.emailLabel.Location = new System.Drawing.Point(6, 160);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(98, 45);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(188, 119);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(173, 51);
            this.LastNameValue.TabIndex = 24;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 102);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(174, 45);
            this.LastNameLabel.TabIndex = 23;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(188, 65);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(173, 51);
            this.FirstNameValue.TabIndex = 22;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 48);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(176, 45);
            this.FirstNameLabel.TabIndex = 21;
            this.FirstNameLabel.Text = "First Name";
            // 
            // teamMembersListbox
            // 
            this.teamMembersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListbox.FormattingEnabled = true;
            this.teamMembersListbox.ItemHeight = 20;
            this.teamMembersListbox.Location = new System.Drawing.Point(506, 161);
            this.teamMembersListbox.Name = "teamMembersListbox";
            this.teamMembersListbox.Size = new System.Drawing.Size(365, 582);
            this.teamMembersListbox.TabIndex = 21;
            // 
            // removeSelectedMember
            // 
            this.removeSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.removeSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.removeSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedMember.ForeColor = System.Drawing.Color.DodgerBlue;
            this.removeSelectedMember.Location = new System.Drawing.Point(905, 381);
            this.removeSelectedMember.Name = "removeSelectedMember";
            this.removeSelectedMember.Size = new System.Drawing.Size(136, 91);
            this.removeSelectedMember.TabIndex = 22;
            this.removeSelectedMember.Text = "Remove Selected";
            this.removeSelectedMember.UseVisualStyleBackColor = true;
            this.removeSelectedMember.Click += new System.EventHandler(this.removeSelectedMember_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createTeamButton.Location = new System.Drawing.Point(352, 769);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(295, 74);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 861);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedMember);
            this.Controls.Add(this.teamMembersListbox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.AddTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TeamNameValue;
        private Label TeamNameLabel;
        private Label createTeamLabel;
        private Button AddTeamMemberButton;
        private Label selectTeamMemberLabel;
        private ComboBox SelectTeamMemberDropDown;
        private GroupBox AddNewMemberBox;
        private Button CreateMemberButton;
        private TextBox CellphoneValue;
        private Label CellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox LastNameValue;
        private Label LastNameLabel;
        private TextBox FirstNameValue;
        private Label FirstNameLabel;
        private ListBox teamMembersListbox;
        private Button removeSelectedMember;
        private Button createTeamButton;
    }
}