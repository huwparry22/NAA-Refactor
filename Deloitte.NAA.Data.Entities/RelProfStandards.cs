using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class RelProfStandards
    {
        public RelProfStandards()
        {
            RelProfStandardsMemberFirm = new HashSet<RelProfStandardsMemberFirm>();
        }

        public int RelProfStandardsId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public byte[] RowVersion { get; set; }
        public int? Sequence { get; set; }
        public bool ApplicableToAllMemberFirms { get; set; }

        public virtual ICollection<RelProfStandardsMemberFirm> RelProfStandardsMemberFirm { get; set; }
    }
}
