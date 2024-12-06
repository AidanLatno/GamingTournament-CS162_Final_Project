namespace GamingTournament
{
    public partial class Form1 : Form
    {
        Dictionary<int, Tournament> tournaments = new Dictionary<int, Tournament>();
        int globalIdCounter = 0;
        public Form1()
        {
            InitializeComponent();
            tournaments.Add(globalIdCounter, new SoloTournament(globalIdCounter++, "Game1", "Minecraft", Status.Upcoming, 20));
            tournaments.Add(globalIdCounter, new SoloTournament(globalIdCounter++, "Game2", "BO3", Status.Ongoing, 5));
            tournaments.Add(globalIdCounter, new SoloTournament(globalIdCounter++, "Game3", "Fortnite", Status.Ongoing, 3));
            tournaments.Add(globalIdCounter, new TeamTournament(globalIdCounter++, "Game4", "Minecraft", Status.Upcoming, 45));
            tournaments.Add(globalIdCounter, new TeamTournament(globalIdCounter++, "Game5", "BO3", Status.Completed, 30));
            UpdateTournamentMenu();
        }

        private void UpdateTournamentMenu()
        {
            tournamentListBox.Items.Clear(); // clears list to ensure no repeats
            // add all tournaments in dictionary to list of form
            foreach (var value in tournaments.Values)
            {
                tournamentListBox.Items.Add("Name: " + value.name + " | Game: " + value.game + " | Status: " + value.status + " | ID: " + value.id);
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            int max = 0;
            // Attempt to parse max participants input. Return and inform user if failed
            if (!int.TryParse(maxParticipantsInput.Text, out max))
            {
                MessageBox.Show("Please enter an integer for the max participants");
                return;
            }

            // Checks to make sure all inputs have been filled out before attempting to create a tournament
            if (maxParticipantsInput.Text == "" ||
               tournamentTypeInput.Text == "" ||
               tournamentNameInput.Text == "" ||
               tournamentGameInput.Text == "")
            {
                MessageBox.Show("Please fill out all inputs to create a tournament.");
                return;
            }


            // Creates a new tournament based on the type and increment globalIdCounter and makes sure user correctly inputed Type
            if (tournamentTypeInput.Text == "Solo")
            {
                SoloTournament tournament = new SoloTournament(globalIdCounter, tournamentNameInput.Text, tournamentGameInput.Text, Status.Upcoming, max);
                tournaments.Add(tournament.id, tournament);
                globalIdCounter++;
            }
            else if (tournamentTypeInput.Text == "Team")
            {
                TeamTournament tournament = new TeamTournament(globalIdCounter, tournamentNameInput.Text, tournamentGameInput.Text, Status.Upcoming, max);
                tournaments.Add(tournament.id, tournament);
                globalIdCounter++;
            }
            else
            {
                MessageBox.Show("Please select a value from the drop down menu.");
                return;
            }
            UpdateTournamentMenu();
        }

        private void resetSearchButton_Click(object sender, EventArgs e)
        {
            UpdateTournamentMenu();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Search bar nullcheck
            if (searchBoxInput.Text == "")
            {
                MessageBox.Show("Please enter a string to search for.");
                return;
            }

            tournamentListBox.Items.Clear();

            //loop through tournaments and only add the ones that meet the search to the list
            foreach (var value in tournaments.Values)
                if (value.name.Contains(searchBoxInput.Text))
                    tournamentListBox.Items.Add("Name: " + value.name + " | Game: " + value.game + " | Status: " + value.status + " | ID: " + value.id);
        }

        private void searchByGameButton_Click(object sender, EventArgs e)
        {
            // Search bar nullcheck
            if (searchByGameInput.Text == "")
            {
                MessageBox.Show("Please enter a string to search for.");
                return;
            }

            tournamentListBox.Items.Clear();
            //loop through tournaments and only add the ones that meet the search to the list
            foreach (var value in tournaments.Values)
                if (value.game.Contains(searchByGameInput.Text))
                    tournamentListBox.Items.Add("Name: " + value.name + " | Game: " + value.game + " | Status: " + value.status + " | ID: " + value.id);
        }

        private void setStatusButton_Click(object sender, EventArgs e)
        {
            int Key = GetSelectedKey();
            if (Key == -1) return;

            // Set status variable and check to make sure user correctly inputed status
            Status setStatus;
            if (statusSelector.Text == "Ongoing") setStatus = Status.Ongoing;
            else if (statusSelector.Text == "Upcoming") setStatus = Status.Upcoming;
            else if (statusSelector.Text == "Completed") setStatus = Status.Completed;
            else
            {
                MessageBox.Show("Please select a status from the drop down menu.");
                return;
            }

            tournaments[Key].status = setStatus;
            UpdateTournamentMenu();
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            int Key = GetSelectedKey();
            if (Key == -1) return;

            tournaments.Remove(Key);
            UpdateTournamentMenu();
        }

        private void openMenuButton_Click(object sender, EventArgs e)
        {
            int Key = GetSelectedKey();
            if (Key == -1) return;

            // find tournament with list box id and open form base on type
            
            if(tournaments[Key].GetType() == typeof(SoloTournament))
            {
                SoloTournamentLeaderboardForm leaderboard = new SoloTournamentLeaderboardForm();
                leaderboard.tournament = (SoloTournament)tournaments[Key];
                leaderboard.ShowDialog();
            }
            else if (tournaments[Key].GetType() == typeof(TeamTournament))
            {
                TeamTournamentLeaderboardForm leaderboard = new TeamTournamentLeaderboardForm();
                leaderboard.tournament = (TeamTournament)tournaments[Key];
                leaderboard.ShowDialog();
            }
        }

        private int GetSelectedKey()
        {
            // Check to make sure user has a tournament selected
            if (tournamentListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No tournament selected.");
                return -1;
            }
            // find tournament with list box id and remove
            foreach (var item in tournaments)
            {
                if (tournamentListBox.SelectedItem.ToString().Contains("ID: " + item.Value.id))
                {
                    return item.Key;
                }
            }
            return -1;
        }
    }
}
