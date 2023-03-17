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
    public partial class CreateTournament : Form, IPrizeRequest
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel> ();

        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournament()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListbox.DataSource = null;
            tournamentTeamsListbox.DataSource = selectedTeams;
            tournamentTeamsListbox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
            }
            WireUpLists();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //call the createPrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
            
        }

        public void PrizeComplete(PrizeModel model)
        {
            //get back from the form a prizeModel
            //take the prizeModel and put it in our list
            selectedPrizes.Add(model);
            WireUpLists();
        }
    }
}
