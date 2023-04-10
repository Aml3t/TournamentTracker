using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Test", LastName = "Test", });
            availableTeamMembers.Add(new PersonModel { FirstName = "Peggy", LastName = "Sue", });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Joe", LastName = "Doe" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Liz", LastName = "Tr" });
        }
        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void tournamentNameValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {

        }
        private void createMemberValue_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "0";

            }
            else
            {
                MessageBox.Show("You need to fill all the fields.");
            }
        }

        private void createMemberValue_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid first name.");
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid last name.");
                return false;
            }

            if (emailValue.Text.Length == 0 || !emailValue.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.");
                return false;
            }

            if (cellphoneValue.Text.Length < 11)
            {
                MessageBox.Show("Please enter a valid cellphone.");
                return false;
            }
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {

        }
    }
}
