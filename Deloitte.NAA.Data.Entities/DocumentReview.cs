using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DocumentReview
    {
        public int ReviewBaseId { get; set; }
        public int? DocumentReviewTypeId { get; set; }
        public int? FinalSignOffDelegate { get; set; }
        public int? FinalSignOffPartner { get; set; }
        public DateTime? FinalSignOffDate { get; set; }
        public bool? ProofRead { get; set; }
        public string ProofReadBy { get; set; }
        public string WincheckName { get; set; }
        public string WincheckGrade { get; set; }
        public int? ReviewPriority { get; set; }
        public string ReviewPriorityReason { get; set; }
        public bool ReadyforAllocation { get; set; }
        public bool FastTrack { get; set; }
        public DateTime? AuditReportDate { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public bool? AuditReportQualified { get; set; }
        public byte[] DocumentReviewRowVersion { get; set; }
        public bool DoNotArchive { get; set; }
        public DateTime? ArchiveActionedDate { get; set; }
        public string ArchiveReference { get; set; }

        public virtual DocumentReviewType DocumentReviewType { get; set; }
        public virtual ReviewUser FinalSignOffPartnerNavigation { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
    }
}
