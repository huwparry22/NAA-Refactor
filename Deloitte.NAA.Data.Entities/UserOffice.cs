using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class UserOffice
    {
        public int UserOfficeId { get; set; }
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Office Office { get; set; }
        public virtual User User { get; set; }
    }
}
