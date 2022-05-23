using System;
using System.Collections.Generic;

#nullable disable

namespace RGR
{
    public partial class trainer
    {
        public int trainerId { get; set; }
        public string name { get; set; }
        public string workExperience { get; set; }
        public int teamId { get; set; }     
        public virtual team teamIdNavigation { get; set; }
    }
}
