using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class CemoRequestReason
    {
        public CemoRequestReason()
        {
            CemoapplicableMemberFirms = new HashSet<CemoApplicableMemberFirms>();
            CemoconsultationRequestReason = new HashSet<CemoConsultationRequestReason>();
        }

        public int CemorequestReasonId { get; set; }
        public string CemorequestReasonDescription { get; set; }
        public bool? Active { get; set; }
        public int Sequence { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public bool ApplicableToAllMemberFirms { get; set; }

        public virtual ICollection<CemoApplicableMemberFirms> CemoapplicableMemberFirms { get; set; }
        public virtual ICollection<CemoConsultationRequestReason> CemoconsultationRequestReason { get; set; }
    }
}
