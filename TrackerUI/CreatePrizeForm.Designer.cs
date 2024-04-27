



namespace TrackerUI
{
    partial class CreatePrizeForm
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
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 18F);
            HeaderLabel.ForeColor = Color.LightSkyBlue;
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(136, 32);
            HeaderLabel.TabIndex = 12;
            HeaderLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(152, 73);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(149, 23);
            placeNumberValue.TabIndex = 14;
            placeNumberValue.TextChanged += firstNameValue_TextChanged;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI Light", 15F);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(14, 65);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(130, 28);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Text = "Place Number";
            placeNumberLabel.Click += placeNumberLabel_Click;
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(154, 116);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(149, 23);
            placeNameValue.TabIndex = 16;
            placeNameValue.TextChanged += textBox1_TextChanged;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI Light", 15F);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(12, 111);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(111, 28);
            placeNameLabel.TabIndex = 15;
            placeNameLabel.Text = "Place Name";
            placeNameLabel.Click += label1_Click;
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(154, 166);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(149, 23);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Text = "0";
            prizeAmountValue.TextChanged += textBox2_TextChanged;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI Light", 15F);
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.Location = new Point(12, 158);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(126, 28);
            prizeAmountLabel.TabIndex = 17;
            prizeAmountLabel.Text = "Prize Amount";
            prizeAmountLabel.Click += label2_Click;
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(172, 290);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(149, 23);
            prizePercentageValue.TabIndex = 20;
            prizePercentageValue.Text = "0";
            prizePercentageValue.TextChanged += textBox3_TextChanged;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI Light", 15F);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(14, 282);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(152, 28);
            prizePercentageLabel.TabIndex = 19;
            prizePercentageLabel.Text = "Prize Percentage";
            prizePercentageLabel.Click += label3_Click;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI Light", 15F);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(79, 225);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(44, 28);
            orLabel.TabIndex = 21;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(62, 355);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(131, 31);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(508, 450);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(HeaderLabel);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

      











        #endregion

        private Label HeaderLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
       /* private EventHandler textBox1_TextChanged;
        private EventHandler label1_Click;
        private EventHandler textBox2_TextChanged;
        private EventHandler label2_Click;
        private EventHandler textBox3_TextChanged;
        private EventHandler label3_Click;*/
    }
}