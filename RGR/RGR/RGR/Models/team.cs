using System;
using System.Collections.Generic;

#nullable disable

namespace RGR
{
    public partial class team
    {
        public team()
        {
            Players = new HashSet<player>();
        }

        public int teamId { get; set; }
        public string teamName { get; set; }
        public int? numberPlayers { get; set; }
        public int? countryId { get; set; }
        public int? matchId { get; set; }
        public virtual ICollection<player> Players { get; set; }
        public virtual country countryIdNavigation { get; set; }
        public virtual match matchIdNavigation { get; set; }
    }
}
