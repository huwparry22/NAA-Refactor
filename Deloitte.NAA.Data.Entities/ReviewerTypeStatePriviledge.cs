using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewerTypeStatePriviledge
    {
        public int ReviewerTypeStatePriviledgeId { get; set; }
        public int ReviewerTypeId { get; set; }
        public int StateId { get; set; }
        public int PriviledgeId { get; set; }

        public virtual Priviledge Priviledge { get; set; }
        public virtual ReviewerType ReviewerType { get; set; }
        public virtual State State { get; set; }
    }
}
