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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            comboBox1 = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            ListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            TeamOneScoreValue = new TextBox();
            TeamTwoScoreValue = new TextBox();
            TeamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(49, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Tag = "";
            headerLabel.Text = "Tournament:";
            headerLabel.Click += label1_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(269, 19);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(150, 50);
            tournamentName.TabIndex = 1;
            tournamentName.Tag = "";
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.BackColor = Color.White;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(49, 100);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Tag = "";
            roundLabel.Text = "Round";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 38);
            comboBox1.TabIndex = 3;
            comboBox1.Tag = "roundDropDown";
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckbox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckbox.Location = new Point(159, 143);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(209, 41);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Tag = "";
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            unplayedOnlyCheckbox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ListBox
            // 
            ListBox.BorderStyle = BorderStyle.FixedSingle;
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 30;
            ListBox.Location = new Point(49, 190);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(300, 182);
            ListBox.TabIndex = 5;
            ListBox.Tag = "matchupListbox";
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.BackColor = Color.White;
            teamOneName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = SystemColors.MenuHighlight;
            teamOneName.Location = new Point(409, 179);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(165, 37);
            teamOneName.TabIndex = 6;
            teamOneName.Tag = "";
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.BackColor = Color.White;
            teamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(409, 233);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(82, 37);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Tag = "";
            teamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            TeamOneScoreValue.Location = new Point(497, 234);
            TeamOneScoreValue.Name = "TeamOneScoreValue";
            TeamOneScoreValue.Size = new Size(100, 36);
            TeamOneScoreValue.TabIndex = 8;
            TeamOneScoreValue.Tag = "";
            TeamOneScoreValue.Text = "<score>";
            // 
            // TeamTwoScoreValue
            // 
            TeamTwoScoreValue.Location = new Point(497, 408);
            TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            TeamTwoScoreValue.Size = new Size(100, 36);
            TeamTwoScoreValue.TabIndex = 11;
            TeamTwoScoreValue.Tag = "";
            TeamTwoScoreValue.Text = "<score>";
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.BackColor = Color.White;
            TeamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TeamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            TeamTwoScoreLabel.Location = new Point(409, 407);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(82, 37);
            TeamTwoScoreLabel.TabIndex = 10;
            TeamTwoScoreLabel.Tag = "";
            TeamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.BackColor = Color.White;
            teamTwoName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.ForeColor = SystemColors.MenuHighlight;
            teamTwoName.Location = new Point(409, 353);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(165, 37);
            teamTwoName.TabIndex = 9;
            teamTwoName.Tag = "teamTwoName";
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.BackColor = Color.White;
            versusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(457, 297);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(70, 37);
            versusLabel.TabIndex = 12;
            versusLabel.Tag = "";
            versusLabel.Text = "-VS-";
            versusLabel.Click += label1_Click_1;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(593, 288);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(107, 46);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(721, 638);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(TeamTwoScoreValue);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(TeamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(ListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(comboBox1);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox comboBox1;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox ListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Label TeamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}