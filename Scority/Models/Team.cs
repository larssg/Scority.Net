using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scority.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        public int MatchId { get; set; }
        public Match Match { get; set; }

        public int Score { get; set; }

        public List<TeamMembership> Memberships { get; set; }
    }
}
