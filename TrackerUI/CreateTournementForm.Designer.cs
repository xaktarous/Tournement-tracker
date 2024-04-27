namespace TrackerUI
{
    partial class CreateTournementForm
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
            HeaderLabel = new Label();
            tournementNameValue = new TextBox();
            tournementNameLabel = new Label();
            EntryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            removeSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            removeSelectedButton = new Button();
            createTournementButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 18F);
            HeaderLabel.ForeColor = Color.LightSkyBlue;
            HeaderLabel.Location = new Point(12, 34);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(211, 32);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Create Tournament:";
            // 
            // tournementNameValue
            // 
            tournementNameValue.Location = new Point(22, 124);
            tournementNameValue.Name = "tournementNameValue";
            tournementNameValue.Size = new Size(215, 23);
            tournementNameValue.TabIndex = 10;
            // 
            // tournementNameLabel
            // 
            tournementNameLabel.AutoSize = true;
            tournementNameLabel.Font = new Font("Segoe UI Light", 18F);
            tournementNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournementNameLabel.Location = new Point(22, 80);
            tournementNameLabel.Name = "tournementNameLabel";
            tournementNameLabel.Size = new Size(201, 32);
            tournementNameLabel.TabIndex = 9;
            tournementNameLabel.Text = "Tournement Name";
            // 
            // EntryFeeValue
            // 
            EntryFeeValue.Location = new Point(137, 166);
            EntryFeeValue.Name = "EntryFeeValue";
            EntryFeeValue.Size = new Size(100, 23);
            EntryFeeValue.TabIndex = 12;
            EntryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Light", 18F);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(22, 157);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(108, 32);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(23, 248);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(215, 23);
            selectTeamDropDown.TabIndex = 14;
            selectTeamDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Light", 18F);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(22, 213);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(132, 32);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(177, 227);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(64, 15);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(66, 287);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(118, 31);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(66, 340);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(118, 31);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 15;
            tournamentTeamsListBox.Location = new Point(294, 124);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(245, 107);
            tournamentTeamsListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI Light", 18F);
            tournamentPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersLabel.Location = new Point(294, 80);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(168, 32);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedPrizeButton.Location = new Point(560, 340);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(75, 51);
            removeSelectedPrizeButton.TabIndex = 23;
            removeSelectedPrizeButton.Text = "remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI Light", 18F);
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.Location = new Point(294, 254);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(72, 32);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 15;
            prizesListBox.Location = new Point(294, 298);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(245, 107);
            prizesListBox.TabIndex = 21;
            // 
            // removeSelectedButton
            // 
            removeSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedButton.FlatStyle = FlatStyle.Flat;
            removeSelectedButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedButton.Location = new Point(560, 153);
            removeSelectedButton.Name = "removeSelectedButton";
            removeSelectedButton.Size = new Size(75, 51);
            removeSelectedButton.TabIndex = 24;
            removeSelectedButton.Text = "remove Selected";
            removeSelectedButton.UseVisualStyleBackColor = true;
            removeSelectedButton.Click += removeSelectedPlayerButton_Click;
            // 
            // createTournementButton
            // 
            createTournementButton.FlatAppearance.BorderColor = Color.Silver;
            createTournementButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournementButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournementButton.FlatStyle = FlatStyle.Flat;
            createTournementButton.ForeColor = SystemColors.MenuHighlight;
            createTournementButton.Location = new Point(265, 439);
            createTournementButton.Name = "createTournementButton";
            createTournementButton.Size = new Size(118, 31);
            createTournementButton.TabIndex = 25;
            createTournementButton.Text = "Create Tournement";
            createTournementButton.UseVisualStyleBackColor = true;
            createTournementButton.Click += createTournementButton_Click;
            // 
            // CreateTournementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 498);
            Controls.Add(createTournementButton);
            Controls.Add(removeSelectedButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(EntryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournementNameValue);
            Controls.Add(tournementNameLabel);
            Controls.Add(HeaderLabel);
            Name = "CreateTournementForm";
            Text = "Create Tournement";
            Load += CreateTournementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox tournementNameValue;
        private Label tournementNameLabel;
        private TextBox EntryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersLabel;
        private Button removeSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button removeSelectedButton;
        private Button createTournementButton;
    }
}