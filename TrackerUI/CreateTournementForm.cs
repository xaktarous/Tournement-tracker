using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournementForm : Form, IPrizeRequester, ITeamRequester
    {

        List<TeamModel> availabeleTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournementForm()
        {
            InitializeComponent();
            WriteUpLists();
        }

        private void WriteUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availabeleTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTournementForm_Load(object sender, EventArgs e)
        {

        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availabeleTeams.Add(t);

                WriteUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                availabeleTeams.Remove(t);
                selectedTeams.Add(t);


                WriteUpLists();
            }
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WriteUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WriteUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);


                WriteUpLists();
            }
        }

        private void createTournementButton_Click(object sender, EventArgs e)
        {
           
            bool feeAcceptable = decimal.TryParse(EntryFeeValue.Text, out decimal fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee", "invalid Fee"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tournementNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
            TournamentLogic.CreateRounds(tm);


            GlobalConfig.Connection.CreateTournament(tm);
            tm.AlertUsersToNewRound();

            TournamentViewerForm frm = new TournamentViewerForm(tm);
        
            frm.Show();
            this.Close();
        }
    }
}
