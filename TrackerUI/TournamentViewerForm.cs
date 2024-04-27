using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using TrackerLibrary;
using TrackerLibrary.Models;
using System.Diagnostics;


namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;

            tournament.OnTournamentComplete += Tournament_OnTournamentComplete;
            WireUpLists();
            LoadFormData();
            LoadRounds();

        }

        private void Tournament_OnTournamentComplete(object? sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            TournementName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {

            roundDropDown.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";

        }
        private void LoadRounds()
        {

            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;
            foreach (List<MatchupModel> m in tournament.Rounds)
            {
                if (m.First().MatchupRound > currRound)
                {
                    currRound = m.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            LoadMatchups(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }
        private void LoadMatchups(int round)
        {

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {

                        if (m.Winner == null || !UnplayedOnlyBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }

                    }
                }
            }
            if (selectedMatchups.Count>0)
            {
                LoadMatchup(selectedMatchups.First());
            }

            DisplayMatchupInfo();
        }
        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            TeamOneName.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreValue.Visible = isVisible;
            teamTwoName.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreText.Visible = isVisible;
            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }


        private void LoadMatchup(MatchupModel m)
        {

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        TeamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        teamTwoName.Text = "<bye>";
                        teamTwoScoreText.Text = "0";

                    }
                    else
                    {
                        TeamOneName.Text = "Not yet set";
                        teamOneScoreValue.Text = "";
                    }

                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreText.Text = m.Entries[1].Score.ToString();

                    }
                    else
                    {
                        teamTwoName.Text = "Not yet set";
                        teamTwoScoreText.Text = "";
                    }

                }
            }
        }
        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchupListBox.SelectedItem != null)
            {
                LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
            }

        }

        private void unplayedOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }
        private string ValideData()
        {
           string output = "";
            double teamOneScore = 0;
            double teamTwoScore = 0;
            bool scoreOneValid = double.TryParse(teamOneScoreValue.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(teamTwoScoreText.Text, out teamTwoScore);

            if (!scoreOneValid)
            {
                output = "the score is not valid number";
            }
            else if ( !scoreTwoValid)
            {
                output = "the score is not valid number";
            }
           else  if (teamOneScore==0 && teamTwoScore == 0)
            {
                output = "you dont enter score";
            }
           else  if (teamOneScore == teamTwoScore)
            {
                output = "we dont allow ties in this app";
            }
            return output;
        }
        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValideData();
            if (errorMessage.Length>0)
            {
                MessageBox.Show($"Input error:{errorMessage}");
                return;
            }

            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamOneScoreValue.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("please enter a valid score for  team 1");
                            return;
                        }

                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamTwoScoreText.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("please enter a valid score for  team 2");
                            return;
                        }

                    }

                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"the application a following error:{ex.Message}");
              
                return;
            }
          
            
            LoadMatchups((int)roundDropDown.SelectedItem);

        }
    }
}
