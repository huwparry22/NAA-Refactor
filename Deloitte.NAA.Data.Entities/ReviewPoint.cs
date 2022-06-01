using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewPoint
    {
        public ReviewPoint()
        {
            ReviewPointComment = new HashSet<ReviewPointComment>();
        }

        public int ReviewPointId { get; set; }
        public int ReviewBaseId { get; set; }
        public int? SupportingDocumentId { get; set; }
        public string Description { get; set; }
        public DateTime DateRaised { get; set; }
        public int CreatedByReviewUserId { get; set; }
        public byte[] RowVersion { get; set; }
        public string ConsultationId { get; set; }
        public int ConsultationTypeId { get; set; }

        public virtual User CreatedByReviewUser { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
        public virtual Document SupportingDocument { get; set; }
        public virtual ICollection<ReviewPointComment> ReviewPointComment { get; set; }
    }
}
