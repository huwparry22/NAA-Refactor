using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DocumentReviewType
    {
        public DocumentReviewType()
        {
            DocumentReview = new HashSet<DocumentReview>();
            ReviewerTypeDocumentReviewType = new HashSet<ReviewerTypeDocumentReviewType>();
            UserDocumentType = new HashSet<UserDocumentType>();
        }

        public int DocumentReviewTypeId { get; set; }
        public int DocumentReviewTypeCategoryId { get; set; }
        public string Name { get; set; }
        public bool Armsearch { get; set; }
        public bool? Active { get; set; }
        public bool Sec { get; set; }
        public bool NeedToArchive { get; set; }

        public virtual DocumentReviewTypeCategory DocumentReviewTypeCategory { get; set; }
        public virtual ICollection<DocumentReview> DocumentReview { get; set; }
        public virtual ICollection<ReviewerTypeDocumentReviewType> ReviewerTypeDocumentReviewType { get; set; }
        public virtual ICollection<UserDocumentType> UserDocumentType { get; set; }
    }
}
