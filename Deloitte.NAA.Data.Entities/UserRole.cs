using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class UserRole
    {
        public UserRole()
        {
            PersonalRight = new HashSet<PersonalRight>();
        }

        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int SystemRoleId { get; set; }
        public byte[] Timestamp { get; set; }
        public int MemberFirmId { get; set; }

        public virtual MemberFirm MemberFirm { get; set; }
        public virtual SystemRole SystemRole { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PersonalRight> PersonalRight { get; set; }
    }
}
