using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class UserSpecialist
    {
        public int UserSpecialistId { get; set; }
        public int UserId { get; set; }
        public int MemberFirmId { get; set; }
        public int SpecialistId { get; set; }
        public bool Active { get; set; }
    }
}
