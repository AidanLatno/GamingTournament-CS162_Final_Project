using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTournament
{
    public class TeamTournament : Tournament, IManageable
    {
        public int maxTeams { get; }
        // List containing all teams and their players
        public List<(string name, int score, List<string> players)> teams = new List<(string, int, List<string>)>();
        public TeamTournament(int id, string name, string game, Status status, int maxTeams) : base(id, name, game, status)
        {
            this.maxTeams = maxTeams;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
        }

        public void RegisterPlayer(string playerName, int score = 0)
        {
            throw new NotImplementedException();
        }

        public void RegisterTeam(string teamName, List<string> members, int score = 0)
        {
            teams.Add((teamName, score, members));
        }
    }
}
