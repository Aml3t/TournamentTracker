using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            decimal prizeNumber = 1.0m;
            bool placeNumberValidNumber = int.TryParse(placeNameValue.Text, out placeNumber);
            bool prizeNumberValidNumber = decimal.TryParse(prizeAmountValue.Text, out prizeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
                Console.WriteLine("Your place number is not valid.");
            }

            if (placeNumber < 1)
            {
                output = false;
                Console.WriteLine("Your place number is not valid.");

            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
                Console.WriteLine("Your place name is not valid.");
            }

            if (prizeNumber <= 0)
            {
                output = false;
                Console.WriteLine("Your prize amount is not valid.");
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
    }
}
