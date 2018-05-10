using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scority.Models
{
    public class TeamMembership
    {
        public int TeamMembershipId { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public int UserId { get; set; }
    }
}
