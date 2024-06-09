﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDB
{
    public class Player
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public int Goals { get; set; }
        public string Position {  get; set; }  
        public int TeamId{  get; set; }  

        public Team Team { get; set; }

    }
}
