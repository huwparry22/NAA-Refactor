using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class Priviledge
    {
        public Priviledge()
        {
            ReviewerTypeStatePriviledge = new HashSet<ReviewerTypeStatePriviledge>();
            SystemRoleStatePriviledge = new HashSet<SystemRoleStatePriviledge>();
        }

        public int PriviledgeId { get; set; }
        public string Text { get; set; }

        public virtual ICollection<ReviewerTypeStatePriviledge> ReviewerTypeStatePriviledge { get; set; }
        public virtual ICollection<SystemRoleStatePriviledge> SystemRoleStatePriviledge { get; set; }
    }
}
