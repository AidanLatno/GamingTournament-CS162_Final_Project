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

namespace GamingTournament
{
    public partial class TeamTournamentLeaderboardForm : Form
    {
        public TeamTournament tournament;
        private int selectedIndex = -1;
        private string selectedObject = "";
        public TeamTournamentLeaderboardForm()
        {
            InitializeComponent();
        }

        public void UpdateTeamList()
        {
            teamList.Nodes.Clear();

            // loop through each team to write their team name and score to the tree
            for (int i = 0; i < tournament.teams.Count; i++)
            {
                teamList.Nodes.Add(tournament.teams[i].name + "  <=======> " + tournament.teams[i].score);
                // loop through each player on the team to write their name into the board
                for (int j = 0; j < tournament.teams[i].players.Count; j++)
                    teamList.Nodes[i].Nodes.Add(tournament.teams[i].players[j]);
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            // Error handling
            int score;
            if (!int.TryParse(scoreInput.Text, out score))
            {
                MessageBox.Show("Please input an integer for the score.");
                return;
            }
            if (nameInput.Text == "" || playerNameInput.Text == "")
            {
                MessageBox.Show("Please fill out all inputs.");
                return;
            }

            // Clean up strings
            List<string> members = playerNameInput.Text.Split(',').ToList();
            for (int i = 0; i < members.Count; i++)
            {
                members[i] = members[i].Trim();
            }

            // Add team to list and update leaderboard
            tournament.RegisterTeam(nameInput.Text, members, score);
            UpdateTeamList();
        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            // Input Error checking
            int score;
            if (!int.TryParse(addScoreInput.Text, out score))
            {
                MessageBox.Show("Please input an integer.");
                return;
            }
            if(scoreAddNameInput.Text == "")
            {
                MessageBox.Show("Please enter the name of the team.");
                return;
            }

            // Look through teams and find right name to change score
            for (int i = 0; i < tournament.teams.Count; i++)
            {
                if (tournament.teams[i].name.Contains(scoreAddNameInput.Text))
                {
                    // Get the current tuple
                    var team = tournament.teams[i];

                    // Update the score by creating a new tuple and replacing the old one
                    tournament.teams[i] = (team.name, team.score + score, team.players);
                }
            }
            UpdateTeamList();
        }
    }
}
