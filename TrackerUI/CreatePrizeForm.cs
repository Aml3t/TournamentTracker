using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createTeamLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                    MessageBox.Show($"Prize created for: {db}");
                }

                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid information. Please check again");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
                MessageBox.Show("Your place number is not valid.");
            }

            if (placeNumber < 1)
            {
                output = false;
                MessageBox.Show("Your place number is lower than 1.");

            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Your place name is not valid.");
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValidNumber = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValidNumber = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValidNumber || !prizePercentageValidNumber)
            {
                output = false;
                MessageBox.Show("Your percentage or prize amount is not valid.");
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
                MessageBox.Show("Either prize or percentage is small.");
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
                MessageBox.Show("Your percentage is out of range.");
            }

            return output;
        }

        private void privePercentageValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void prizeAmountValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
