using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scority.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public int TeamSize { get; set; }
        public List<Match> Matches { get; set; }
    }
}
