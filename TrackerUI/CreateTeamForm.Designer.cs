﻿namespace TrackerUI
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            addTeamMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberBox = new GroupBox();
            createMemberValue = new Button();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            createTeamButton = new Button();
            removeSelected = new Button();
            addNewMemberBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(29, 123);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(283, 35);
            teamNameValue.TabIndex = 13;
            teamNameValue.Tag = "";
            teamNameValue.TextChanged += tournamentNameValue_TextChanged;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.BackColor = Color.White;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(29, 74);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Tag = "";
            teamNameLabel.Text = "Team Name";
            teamNameLabel.Click += tournamentNameLabel_Click;
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = SystemColors.MenuHighlight;
            createTeamLabel.Location = new Point(18, 13);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(213, 50);
            createTeamLabel.TabIndex = 11;
            createTeamLabel.Tag = "";
            createTeamLabel.Text = "Create Team";
            createTeamLabel.Click += headerLabel_Click;
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamMemberButton.ForeColor = SystemColors.MenuHighlight;
            addTeamMemberButton.Location = new Point(84, 271);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(173, 54);
            addTeamMemberButton.TabIndex = 19;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            addTeamMemberButton.Click += addTeamMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(29, 214);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(283, 38);
            selectTeamMemberDropDown.TabIndex = 18;
            selectTeamMemberDropDown.Tag = "";
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.BackColor = Color.White;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(29, 171);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(263, 37);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Tag = "";
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberBox
            // 
            addNewMemberBox.Controls.Add(createMemberValue);
            addNewMemberBox.Controls.Add(cellphoneValue);
            addNewMemberBox.Controls.Add(cellphoneLabel);
            addNewMemberBox.Controls.Add(emailValue);
            addNewMemberBox.Controls.Add(emailLabel);
            addNewMemberBox.Controls.Add(lastNameValue);
            addNewMemberBox.Controls.Add(lastNameLabel);
            addNewMemberBox.Controls.Add(firstNameValue);
            addNewMemberBox.Controls.Add(firstNameLabel);
            addNewMemberBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            addNewMemberBox.ForeColor = SystemColors.MenuHighlight;
            addNewMemberBox.Location = new Point(31, 340);
            addNewMemberBox.Name = "addNewMemberBox";
            addNewMemberBox.Size = new Size(354, 321);
            addNewMemberBox.TabIndex = 20;
            addNewMemberBox.TabStop = false;
            addNewMemberBox.Text = "Add New Member";
            // 
            // createMemberValue
            // 
            createMemberValue.FlatAppearance.BorderColor = Color.Silver;
            createMemberValue.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberValue.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberValue.FlatStyle = FlatStyle.Flat;
            createMemberValue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberValue.ForeColor = SystemColors.MenuHighlight;
            createMemberValue.Location = new Point(111, 269);
            createMemberValue.Name = "createMemberValue";
            createMemberValue.Size = new Size(173, 39);
            createMemberValue.TabIndex = 21;
            createMemberValue.Text = "Create Member";
            createMemberValue.UseVisualStyleBackColor = true;
            createMemberValue.Click += createMemberValue_Click;
            createMemberValue.MouseClick += createMemberValue_MouseClick;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(170, 217);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(162, 43);
            cellphoneValue.TabIndex = 16;
            cellphoneValue.Tag = "";
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.BackColor = Color.White;
            cellphoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellphoneLabel.Location = new Point(22, 217);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(138, 37);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Tag = "";
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(170, 158);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(162, 43);
            emailValue.TabIndex = 14;
            emailValue.Tag = "";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.White;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(22, 159);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 13;
            emailLabel.Tag = "";
            emailLabel.Text = "Email";
            emailLabel.Click += Label1_Click;
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(170, 106);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(162, 43);
            lastNameValue.TabIndex = 12;
            lastNameValue.Tag = "";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.White;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(22, 106);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Tag = "";
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(170, 51);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(162, 43);
            firstNameValue.TabIndex = 10;
            firstNameValue.Tag = "";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.White;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(22, 51);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Tag = "";
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(414, 125);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(299, 512);
            teamMembersListBox.TabIndex = 21;
            teamMembersListBox.Tag = "tournamentPlayersListBox";
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(317, 667);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(291, 87);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // removeSelected
            // 
            removeSelected.FlatAppearance.BorderColor = Color.Silver;
            removeSelected.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelected.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelected.FlatStyle = FlatStyle.Flat;
            removeSelected.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelected.ForeColor = SystemColors.MenuHighlight;
            removeSelected.Location = new Point(724, 295);
            removeSelected.Name = "removeSelected";
            removeSelected.Size = new Size(100, 82);
            removeSelected.TabIndex = 26;
            removeSelected.Text = "Remove Selected";
            removeSelected.UseVisualStyleBackColor = true;
            removeSelected.Click += removeSelectedMemberButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 766);
            Controls.Add(removeSelected);
            Controls.Add(createTeamButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberBox.ResumeLayout(false);
            addNewMemberBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private Button createMemberValue;
        private ListBox teamMembersListBox;
        private Button createTeamButton;
        private Button removeSelected;
    }
}