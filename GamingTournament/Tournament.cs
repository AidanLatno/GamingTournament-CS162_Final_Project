using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingTournament
{
    public enum Status
    {
        Ongoing,
        Upcoming,
        Completed
    }

    public class Tournament
    {
        public int id { get; }
        public string name { get; set; }
        public string game { get; set; }
        public Status status { get; set; }

        public Tournament(int id, string name, string game, Status status)
        {
            this.id = id;
            this.name = name;
            this.game = game;
            this.status = status;
        }

        public virtual void DisplayDetails()
        {
            MessageBox.Show("Name: " + this.name + " | Game: " + this.game + " | Status: " + this.status + " | id: " + this.id);  
        }
    }
}
