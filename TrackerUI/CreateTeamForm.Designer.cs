


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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            HeaderLabel = new Label();
            addMemberButton = new Button();
            selectTeamDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            firstNameLabel = new GroupBox();
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            teamOneScoreLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedButton = new Button();
            createTeamButton = new Button();
            firstNameLabel.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(12, 105);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(215, 23);
            teamNameValue.TabIndex = 13;
            teamNameValue.TextChanged += tournementNameValue_TextChanged;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Light", 18F);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(12, 61);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(134, 32);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            teamNameLabel.Click += tournementNameLabel_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 18F);
            HeaderLabel.ForeColor = Color.LightSkyBlue;
            HeaderLabel.Location = new Point(2, 15);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(139, 32);
            HeaderLabel.TabIndex = 11;
            HeaderLabel.Text = "Create Team";
            HeaderLabel.Click += HeaderLabel_Click;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(56, 242);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(118, 31);
            addMemberButton.TabIndex = 20;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(13, 203);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(215, 23);
            selectTeamDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Light", 18F);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(12, 168);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(224, 32);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // firstNameLabel
            // 
            firstNameLabel.Controls.Add(createMemberButton);
            firstNameLabel.Controls.Add(cellphoneValue);
            firstNameLabel.Controls.Add(cellphoneLabel);
            firstNameLabel.Controls.Add(emailValue);
            firstNameLabel.Controls.Add(emailLabel);
            firstNameLabel.Controls.Add(lastNameValue);
            firstNameLabel.Controls.Add(lastNameLabel);
            firstNameLabel.Controls.Add(firstNameValue);
            firstNameLabel.Controls.Add(teamOneScoreLabel);
            firstNameLabel.Font = new Font("Segoe UI", 12F);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(13, 279);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(317, 257);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.TabStop = false;
            firstNameLabel.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(79, 191);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(118, 31);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(113, 145);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(149, 29);
            cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI Light", 15F);
            cellphoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellphoneLabel.Location = new Point(6, 140);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(96, 28);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(113, 108);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(149, 29);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 15F);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(6, 100);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(56, 28);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(113, 64);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(149, 29);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Light", 15F);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(6, 59);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 28);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(113, 24);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(149, 29);
            firstNameValue.TabIndex = 10;
            firstNameValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI Light", 15F);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(6, 24);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(101, 28);
            teamOneScoreLabel.TabIndex = 9;
            teamOneScoreLabel.Text = "First Name";
            teamOneScoreLabel.Click += teamOneScoreLabel_Click;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 15;
            teamMembersListBox.Location = new Point(390, 78);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(272, 437);
            teamMembersListBox.TabIndex = 22;
            // 
            // removeSelectedButton
            // 
            removeSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedButton.FlatStyle = FlatStyle.Flat;
            removeSelectedButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedButton.Location = new Point(684, 275);
            removeSelectedButton.Name = "removeSelectedButton";
            removeSelectedButton.Size = new Size(75, 51);
            removeSelectedButton.TabIndex = 25;
            removeSelectedButton.Text = "remove Selected";
            removeSelectedButton.UseVisualStyleBackColor = true;
            removeSelectedButton.Click += removeSelectedButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(295, 580);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(131, 31);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 649);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(firstNameLabel);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(HeaderLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            firstNameLabel.ResumeLayout(false);
            firstNameLabel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label HeaderLabel;
        private Button addMemberButton;
        private ComboBox selectTeamDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox firstNameLabel;
        private TextBox firstNameValue;
        private Label teamOneScoreLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button removeSelectedButton;
        private Button createTeamButton;
     
    }
}