﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDB
{
    public class Team
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int GamesPlayed {  get; set; }
        public int GamesWon { get; set; }
        public int GamesDrawn { get; set; }
        public int GamesLost {  get; set; }
        public int GoalsFor {  get; set; }
        public int GoalsAgainst {  get; set; }
        public int Points {  get; set; }

        public int LeagueId { get; set; }
        public League League { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
