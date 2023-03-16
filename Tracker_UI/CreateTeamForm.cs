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
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void TournamentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddTeamMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel(
                    FirstNameValue.Text,
                    LastNameValue.Text,
                    emailValue.Text,
                    CellphoneValue.Text);
                GlobalConfig.Connection.CreatePerson(p);

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                emailValue.Text = "";
                CellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }

        private bool ValidateForm()
        {
            // TODO add validation
            bool Output = true;
            if (FirstNameValue.Text.Length == 0)
            {
                Output = false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                Output = false;
            }
            if (emailValue.Text.Length == 0)
            {
                Output = false;
            }
            if (CellphoneValue.Text.Length == 0)
            {
                Output = false;
            }

            return Output;
        }
    }
}
