using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class UserConsultationType
    {
        public int UserConsultationTypeId { get; set; }
        public int UserId { get; set; }
        public int ConsultationTypeId { get; set; }
        public byte AccessLevel { get; set; }
        public byte[] Timestamp { get; set; }
        public int MemberFirmId { get; set; }

        public virtual MemberFirm MemberFirm { get; set; }
        public virtual User User { get; set; }
    }
}
