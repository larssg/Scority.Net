using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scority.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        public DateTime PlayedAt { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public List<Team> Teams { get; set; }
    }
}
