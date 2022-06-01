using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EarReason
    {
        public EarReason()
        {
            EarapplicableMemberFirms = new HashSet<EarApplicableMemberFirms>();
        }

        public int EarrequestReasonId { get; set; }
        public string EarrequestReasonDescription { get; set; }
        public bool? Active { get; set; }
        public int Sequence { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public bool ApplicableToAllMemberFirms { get; set; }

        public virtual ICollection<EarApplicableMemberFirms> EarapplicableMemberFirms { get; set; }
    }
}
