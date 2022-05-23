using System;
using System.Collections.Generic;

#nullable disable

namespace RGR
{
    public partial class match
    {

        public match()
        {
            Teams = new HashSet<team>();
        }

        public int matchId { get; set; }
       // public int firstTeamId { get; set; }
        //public int secondTeamId { get; set; }
       // public int countryId { get; set; }
        public int groundId { get; set; }
        public string result { get; set; }
        public string date { get; set; }
        public int seasonId { get; set; }
        public virtual ICollection<team> Teams { get; set; }
        //public virtual team firstTeamIdNavigation { get; set; }
        //public virtual team secondTeamIdNavigation { get; set; }
       // public virtual country countryIdNavigation { get; set; }
        public virtual ground groundIdNavigation { get; set; }
        public virtual season seasonIdNavigation { get; set; }
    }
}
