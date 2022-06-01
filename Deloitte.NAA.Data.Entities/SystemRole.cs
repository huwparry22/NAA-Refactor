using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class SystemRole
    {
        public SystemRole()
        {
            MenuSecurity = new HashSet<MenuSecurity>();
            SystemRoleStatePriviledge = new HashSet<SystemRoleStatePriviledge>();
            UserRole = new HashSet<UserRole>();
        }

        public int SystemRoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MenuSecurity> MenuSecurity { get; set; }
        public virtual ICollection<SystemRoleStatePriviledge> SystemRoleStatePriviledge { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
