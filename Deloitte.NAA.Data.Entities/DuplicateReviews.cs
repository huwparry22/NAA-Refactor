using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DuplicateReviews
    {
        public int DuplicateReviewsId { get; set; }
        public int ReviewBaseId { get; set; }
        public int DuplicateId { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
    }
}
