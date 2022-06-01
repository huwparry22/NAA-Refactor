using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicConsultationReview
    {
        public int FicconsultationReviewId { get; set; }
        public string FicconsultationId { get; set; }
        public int? PreferredReviewerUserId { get; set; }
        public string PreferredReviewerReason { get; set; }
        public DateTime? MemoRequestedDate { get; set; }
        public DateTime? AuditSignOff { get; set; }
        public string OtherReviewInformation { get; set; }
        public int? TimeExpectation { get; set; }

        public virtual FicConsultation Ficconsultation { get; set; }
    }
}
