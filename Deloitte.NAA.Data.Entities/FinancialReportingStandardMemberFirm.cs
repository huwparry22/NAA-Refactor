using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FinancialReportingStandardMemberFirm
    {
        public int FinancialReportingStandardMemberFirmId { get; set; }
        public int FinancialReportingStandardId { get; set; }
        public int MemberFirmId { get; set; }
        public int Sequence { get; set; }

        public virtual MemberFirm MemberFirm { get; set; }
    }
}
