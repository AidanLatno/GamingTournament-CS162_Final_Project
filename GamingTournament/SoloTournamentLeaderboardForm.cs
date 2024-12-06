using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingTournament
{
    public partial class SoloTournamentLeaderboardForm : Form
    {
        public SoloTournament tournament;
        public SoloTournamentLeaderboardForm()
        {
            InitializeComponent();
        }

        public void UpdatePlayerList()
        {
            playerList.Items.Clear();
            foreach (var player in tournament.players)
            {
                playerList.Items.Add(player.name + "  <========>  " + player.score);
            }
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            // Parse score input and basic input error checking
            int score;
            if (!int.TryParse(scoreInput.Text, out score))
            {
                MessageBox.Show("Please enter a number.");
                return;
            }
            if (nameInput.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            tournament.RegisterPlayer(nameInput.Text, score);
            UpdatePlayerList();
        }

        private int GetSelectedIndex()
        {
            // Check to make sure user has a player selected
            if (playerList.SelectedIndex == -1)
            {
                MessageBox.Show("No player selected.");
                return -1;
            }
            // find player with list box id and remove
            for (int i = 0; i < tournament.players.Count; i++)
            {
                if (playerList.SelectedItem.ToString().Contains(tournament.players[i].name))
                {
                    return i;
                }
            }
            return -1;
        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            int index = GetSelectedIndex();
            if (index == -1) return;

            int score;
            if (!int.TryParse(addScoreInput.Text, out score))
            {
                MessageBox.Show("Please enter a number.");
                return;
            }

            // Get the current tuple
            var player = tournament.players[index];

            // Update the score by creating a new tuple and replacing the old one
            tournament.players[index] = (player.name, player.score + score);
            UpdatePlayerList();
        }
    }
}
