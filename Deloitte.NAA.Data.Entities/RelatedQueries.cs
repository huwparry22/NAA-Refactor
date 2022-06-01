using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class RelatedQueries
    {
        public int RelatedQueriesId { get; set; }
        public int ReviewBaseId { get; set; }
        public int RelatedReviewBaseId { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ReviewBase RelatedReviewBase { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
        public virtual User UpdatedByNavigation { get; set; }
    }
}
