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
            availableTeamMembers.Add(new PersonModel { FirstName = "tomek", LastName = "Zarobek" });
            availableTeamMembers.Add(new PersonModel { FirstName = "jarek", LastName = "Wygarek" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "jonasz", LastName = "Konasz" });
        }
        private void WireUpLists()
        {
            //null data source needed for data refresh
            SelectTeamMemberDropDown.DataSource = null; 
            SelectTeamMemberDropDown.DataSource= availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListbox.DataSource = null;
            teamMembersListbox.DataSource= selectedTeamMembers;
            teamMembersListbox.DisplayMember = "FullName";
        }

        private void TournamentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddTeamMemberButton_Click(object sender, EventArgs e)
        {
            
            PersonModel p = (PersonModel)SelectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                //needed for data refresh
                WireUpLists();
            }
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
                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

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

        private void removeSelectedMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListbox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                //needed for data refresh
                WireUpLists();
            }
            
        }
    }
}
