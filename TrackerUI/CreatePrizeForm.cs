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
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel();

                model.PlaceName = placeNameValue.Text;
                model.PlaceNumber = placeNumberValue.Text;
                
                
                
               // Console.WriteLine("Prize created");

            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNameValue.Text, out placeNumber);

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

            decimal prizeAmount = 0;
            int pricePercentage = 0;

            bool prizeAmountValidNumber = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValidNumber = int.TryParse(pricePercentageValue.Text, out pricePercentage);

            if ( !prizeAmountValidNumber || !prizePercentageValidNumber)
            {
                output = false;
                Console.WriteLine("Not valid input.");
            }

            if (prizeAmount <= 0 && pricePercentage <= 0)
            {
                output = false;
                Console.WriteLine("Not valid input.");
            }

            if (pricePercentage < 0 || pricePercentage > 100)
            {
                output = false;
                Console.WriteLine("Not valid input.");
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
