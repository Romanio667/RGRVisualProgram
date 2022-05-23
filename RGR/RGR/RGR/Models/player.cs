using System;
using System.Collections.Generic;

#nullable disable

namespace RGR
{
    public partial class player
    {
        public int playerId { get; set; }
        public string playerName { get; set; }
        public int? teamId { get; set; }
        public string workExperience { get; set; }
        public int matches { get; set; }
        public int runs { get; set; }
        public virtual team teamIdNavigation { get; set; }
    }
}
