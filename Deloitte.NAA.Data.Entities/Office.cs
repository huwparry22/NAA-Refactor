using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class Office
    {
        public Office()
        {
            ReviewBase = new HashSet<ReviewBase>();
            UserOffice = new HashSet<UserOffice>();
        }

        public int OfficeId { get; set; }
        public string City { get; set; }
        public bool AllowReviewSelfAssign { get; set; }
        public bool Active { get; set; }
        public bool ConfirmationRequired { get; set; }
        public int SequenceId { get; set; }
        public bool PartnerOffice { get; set; }
        public int MemberFirmId { get; set; }

        public virtual MemberFirm MemberFirm { get; set; }
        public virtual ICollection<ReviewBase> ReviewBase { get; set; }
        public virtual ICollection<UserOffice> UserOffice { get; set; }
    }
}
