using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewUser
    {
        public ReviewUser()
        {
            DocumentReview = new HashSet<DocumentReview>();
        }

        public int ReviewUserId { get; set; }
        public int ReviewBaseId { get; set; }
        public int UserId { get; set; }
        public int ReviewerTypeId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? SignedOffByUserId { get; set; }
        public bool EmailRequired { get; set; }
        public byte[] RowVersion { get; set; }
        public string ConsultationTypeId { get; set; }
        public decimal? TimeSpent { get; set; }
        public string Position { get; set; }
        public bool? Required { get; set; }
        public DateTime? Independence { get; set; }
        public int? SpecialistField { get; set; }
        public int? SpecialistDelegate { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
        public virtual ReviewerType ReviewerType { get; set; }
        public virtual User SignedOffByUser { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<DocumentReview> DocumentReview { get; set; }
    }
}
