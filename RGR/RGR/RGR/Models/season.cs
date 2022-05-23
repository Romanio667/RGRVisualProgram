using System;
using System.Collections.Generic;

#nullable disable

namespace RGR
{
    public partial class season
    {
        public season()
        {
            Seasons = new HashSet<match>();
        }

        public int seasonId { get; set; }
        public int seasonYear { get; set; }
        public virtual ICollection<match> Seasons { get; set; }
    }
}
