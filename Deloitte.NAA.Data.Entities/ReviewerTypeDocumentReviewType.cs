using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewerTypeDocumentReviewType
    {
        public int ReviewerTypeDocumentReviewTypeId { get; set; }
        public int ReviewerTypeId { get; set; }
        public int DocumentReviewTypeId { get; set; }

        public virtual DocumentReviewType DocumentReviewType { get; set; }
        public virtual ReviewerType ReviewerType { get; set; }
    }
}
