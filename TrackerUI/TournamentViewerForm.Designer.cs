namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            TournementName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            UnplayedOnlyBox = new CheckBox();
            matchupListBox = new ListBox();
            TeamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreText = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 18F);
            HeaderLabel.ForeColor = Color.LightSkyBlue;
            HeaderLabel.Location = new Point(12, 68);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(138, 32);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament:";
            // 
            // TournementName
            // 
            TournementName.AutoSize = true;
            TournementName.Font = new Font("Segoe UI Light", 18F);
            TournementName.ForeColor = Color.LightSkyBlue;
            TournementName.Location = new Point(160, 68);
            TournementName.Name = "TournementName";
            TournementName.Size = new Size(97, 32);
            TournementName.TabIndex = 1;
            TournementName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI Light", 18F);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(12, 129);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(79, 32);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(97, 125);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(170, 36);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // UnplayedOnlyBox
            // 
            UnplayedOnlyBox.AccessibleDescription = "UnplayedOnlyCheckBox";
            UnplayedOnlyBox.AutoSize = true;
            UnplayedOnlyBox.FlatStyle = FlatStyle.Flat;
            UnplayedOnlyBox.Font = new Font("Segoe UI Light", 18F);
            UnplayedOnlyBox.ForeColor = SystemColors.MenuHighlight;
            UnplayedOnlyBox.Location = new Point(97, 167);
            UnplayedOnlyBox.Name = "UnplayedOnlyBox";
            UnplayedOnlyBox.Size = new Size(179, 36);
            UnplayedOnlyBox.TabIndex = 4;
            UnplayedOnlyBox.Text = "Unplayed Only";
            UnplayedOnlyBox.UseVisualStyleBackColor = true;
            UnplayedOnlyBox.CheckedChanged += unplayedOnly_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 28;
            matchupListBox.Location = new Point(12, 255);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(245, 142);
            matchupListBox.TabIndex = 5;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // TeamOneName
            // 
            TeamOneName.AutoSize = true;
            TeamOneName.Font = new Font("Segoe UI Light", 18F);
            TeamOneName.ForeColor = SystemColors.MenuHighlight;
            TeamOneName.Location = new Point(284, 220);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(142, 32);
            TeamOneName.TabIndex = 6;
            TeamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI Light", 18F);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(295, 266);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(70, 32);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(371, 264);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(100, 34);
            teamOneScoreValue.TabIndex = 8;
            teamOneScoreValue.TextChanged += textBox1_TextChanged;
            // 
            // teamTwoScoreText
            // 
            teamTwoScoreText.Location = new Point(371, 418);
            teamTwoScoreText.Name = "teamTwoScoreText";
            teamTwoScoreText.Size = new Size(100, 34);
            teamTwoScoreText.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI Light", 18F);
            teamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoScoreLabel.Location = new Point(295, 418);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(70, 32);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI Light", 18F);
            teamTwoName.ForeColor = SystemColors.MenuHighlight;
            teamTwoName.Location = new Point(284, 363);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(140, 32);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI Light", 18F);
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(325, 319);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(60, 32);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            versusLabel.Click += label1_Click;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(510, 319);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(75, 39);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += scoreButton_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(645, 749);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreText);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(TeamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(UnplayedOnlyBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(TournementName);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label TournementName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox UnplayedOnlyBox;
        private ListBox matchupListBox;
        private Label TeamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreText;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}
