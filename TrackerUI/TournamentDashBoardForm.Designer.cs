namespace TrackerUI
{
    partial class TournamentDashBoardForm
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
            selectTournamentDropDown = new ComboBox();
            loaLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentbutton = new Button();
            tornamentDachBoardlabel1 = new Label();
            SuspendLayout();
            // 
            // selectTournamentDropDown
            // 
            selectTournamentDropDown.FormattingEnabled = true;
            selectTournamentDropDown.Location = new Point(209, 166);
            selectTournamentDropDown.Name = "selectTournamentDropDown";
            selectTournamentDropDown.Size = new Size(317, 23);
            selectTournamentDropDown.TabIndex = 30;
            // 
            // loaLabel
            // 
            loaLabel.AutoSize = true;
            loaLabel.Font = new Font("Segoe UI Light", 18F);
            loaLabel.ForeColor = SystemColors.MenuHighlight;
            loaLabel.Location = new Point(235, 131);
            loaLabel.Name = "loaLabel";
            loaLabel.Size = new Size(270, 32);
            loaLabel.TabIndex = 29;
            loaLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.ForeColor = SystemColors.MenuHighlight;
            loadTournamentButton.Location = new Point(299, 216);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(118, 31);
            loadTournamentButton.TabIndex = 31;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            loadTournamentButton.Click += loadTournamentButton_Click;
            // 
            // createTournamentbutton
            // 
            createTournamentbutton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentbutton.FlatStyle = FlatStyle.Flat;
            createTournamentbutton.ForeColor = SystemColors.MenuHighlight;
            createTournamentbutton.Location = new Point(299, 280);
            createTournamentbutton.Name = "createTournamentbutton";
            createTournamentbutton.Size = new Size(131, 31);
            createTournamentbutton.TabIndex = 32;
            createTournamentbutton.Text = "Create Tournament";
            createTournamentbutton.UseVisualStyleBackColor = true;
            createTournamentbutton.Click += createTournamentbutton_Click;
            // 
            // tornamentDachBoardlabel1
            // 
            tornamentDachBoardlabel1.AutoSize = true;
            tornamentDachBoardlabel1.Font = new Font("Segoe UI Light", 18F);
            tornamentDachBoardlabel1.ForeColor = SystemColors.MenuHighlight;
            tornamentDachBoardlabel1.Location = new Point(235, 66);
            tornamentDachBoardlabel1.Name = "tornamentDachBoardlabel1";
            tornamentDachBoardlabel1.Size = new Size(249, 32);
            tornamentDachBoardlabel1.TabIndex = 33;
            tornamentDachBoardlabel1.Text = "Tournament DashBoard";
            tornamentDachBoardlabel1.Click += label1_Click;
            // 
            // TournamentDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tornamentDachBoardlabel1);
            Controls.Add(createTournamentbutton);
            Controls.Add(loadTournamentButton);
            Controls.Add(selectTournamentDropDown);
            Controls.Add(loaLabel);
            Name = "TournamentDashBoardForm";
            Text = "Tournament DashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox selectTournamentDropDown;
        private Label loaLabel;
        private Button loadTournamentButton;
        private Button createTournamentbutton;
        private Label tornamentDachBoardlabel1;
    }
}