using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewerType
    {
        public ReviewerType()
        {
            DelinquentRecipients = new HashSet<DelinquentRecipients>();
            EmailRecipientRole = new HashSet<EmailRecipientRole>();
            ReviewUser = new HashSet<ReviewUser>();
            ReviewerTypeDocumentReviewType = new HashSet<ReviewerTypeDocumentReviewType>();
            ReviewerTypeStatePriviledge = new HashSet<ReviewerTypeStatePriviledge>();
        }

        public int ReviewerTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DelinquentRecipients> DelinquentRecipients { get; set; }
        public virtual ICollection<EmailRecipientRole> EmailRecipientRole { get; set; }
        public virtual ICollection<ReviewUser> ReviewUser { get; set; }
        public virtual ICollection<ReviewerTypeDocumentReviewType> ReviewerTypeDocumentReviewType { get; set; }
        public virtual ICollection<ReviewerTypeStatePriviledge> ReviewerTypeStatePriviledge { get; set; }
    }
}
