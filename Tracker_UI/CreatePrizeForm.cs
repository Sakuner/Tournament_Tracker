﻿using System;
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
        IPrizeRequest callingForm;
        public CreatePrizeForm(IPrizeRequest caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text, 
                    PlaceNumberValue.Text, 
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //PlaceNameValue.Text = "";
                //PlaceNumberValue.Text = "";
                //prizeAmountValue.Text = "0";
                //prizePercentageValue.Text = "0";

            }
            else
            {
                MessageBox.Show("Form has invalid info. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }
            if (placeNumber<1)
            {
                output = false;
            }
            if(PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValidNumber = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValidNumber = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValidNumber || !prizePercentageValidNumber)
            {
                output = false;
            }
            if (prizeAmount <=0 && prizePercentage <=0)
            {
                output = false;
            }
            if (prizePercentage <0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }

        private void prizePercentageValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
