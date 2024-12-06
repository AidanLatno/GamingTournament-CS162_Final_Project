using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTournament
{
    public interface IManageable
    {
        public void RegisterPlayer(string playerName, int score = 0);
        public void RegisterTeam(string teamName, List<string> members, int score = 0);


    }
}
