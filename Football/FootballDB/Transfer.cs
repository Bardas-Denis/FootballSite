using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDB
{
    public class Transfer
    {
        public int Id { get; set; }

        public int PlayerId { get; set; } 
        public int LastTeamId { get; set; } 
        public int NewTeamId { get; set; } 

        public Player Player { get; set; }
        public Team LastTeam { get; set; }
        public Team NewTeam { get; set; }

    }
}
