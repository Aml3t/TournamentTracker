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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            pricePercentageValue = new TextBox();
            privePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = SystemColors.MenuHighlight;
            createPrizeLabel.Location = new Point(60, 34);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(209, 50);
            createPrizeLabel.TabIndex = 12;
            createPrizeLabel.Tag = "";
            createPrizeLabel.Text = "Create Prize";
            createPrizeLabel.Click += createTeamLabel_Click;
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(244, 106);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(162, 35);
            placeNumberValue.TabIndex = 14;
            placeNumberValue.Tag = "";
            placeNumberValue.TextChanged += placeNumberValue_TextChanged;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.BackColor = Color.White;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(55, 104);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Tag = "";
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(244, 169);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(162, 35);
            placeNameValue.TabIndex = 16;
            placeNameValue.Tag = "";
            placeNameValue.TextChanged += placeNameValue_TextChanged;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.BackColor = Color.White;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(55, 166);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 15;
            placeNameLabel.Tag = "";
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(244, 225);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(162, 35);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Tag = "";
            prizeAmountValue.TextChanged += prizeAmountValue_TextChanged;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.BackColor = Color.White;
            prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.Location = new Point(55, 222);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(176, 37);
            prizeAmountLabel.TabIndex = 17;
            prizeAmountLabel.Tag = "";
            prizeAmountLabel.Text = "Price Amount";
            // 
            // pricePercentageValue
            // 
            pricePercentageValue.Location = new Point(273, 412);
            pricePercentageValue.Name = "pricePercentageValue";
            pricePercentageValue.Size = new Size(162, 35);
            pricePercentageValue.TabIndex = 20;
            pricePercentageValue.Tag = "";
            pricePercentageValue.TextChanged += privePercentageValue_TextChanged;
            // 
            // privePercentageLabel
            // 
            privePercentageLabel.AutoSize = true;
            privePercentageLabel.BackColor = Color.White;
            privePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            privePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            privePercentageLabel.Location = new Point(55, 410);
            privePercentageLabel.Name = "privePercentageLabel";
            privePercentageLabel.Size = new Size(212, 37);
            privePercentageLabel.TabIndex = 19;
            privePercentageLabel.Tag = "";
            privePercentageLabel.Text = "Price Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.BackColor = Color.White;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(205, 314);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 37);
            orLabel.TabIndex = 21;
            orLabel.Tag = "";
            orLabel.Text = "-or-";
            orLabel.Click += label1_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(170, 518);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(310, 83);
            createPrizeButton.TabIndex = 26;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 618);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(pricePercentageValue);
            Controls.Add(privePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox pricePercentageValue;
        private Label privePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}