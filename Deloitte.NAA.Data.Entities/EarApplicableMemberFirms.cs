using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EarApplicableMemberFirms
    {
        public int Id { get; set; }
        public int EarrequestReasonId { get; set; }
        public int MemberFirmId { get; set; }

        public virtual EarReason EarrequestReason { get; set; }
        public virtual MemberFirm MemberFirm { get; set; }
    }
}
