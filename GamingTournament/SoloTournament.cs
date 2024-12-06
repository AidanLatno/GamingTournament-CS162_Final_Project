using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTournament
{
    public class SoloTournament : Tournament, IManageable
    {
        // List of tuples to store player names and scores together
        public List<(string name,int score)> players = new List<(string,int)>();
        public int maxParticipants { get; }
        public SoloTournament(int id, string name, string game, Status status, int maxParticipants) : base(id, name, game, status)
        {
            this.maxParticipants = maxParticipants;
        }

        public override void DisplayDetails()
        {
            SoloTournamentLeaderboardForm leaderboard = new SoloTournamentLeaderboardForm();
            leaderboard.tournament = this;
            leaderboard.ShowDialog();
        }

        public void RegisterPlayer(string playerName,int score = 0)
        {
            players.Add((playerName,score));
        }

        public void RegisterTeam(string teamName, List<string> members, int score = 0)
        {
            throw new NotImplementedException();
        }

    }
}
