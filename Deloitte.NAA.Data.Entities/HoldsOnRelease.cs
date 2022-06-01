using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class HoldsOnRelease
    {
        public int HoldsOnReleaseId { get; set; }
        public int ReviewBaseId { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public string Response { get; set; }
        public byte[] RowVersion { get; set; }
        public int CategoryId { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
        public virtual User User { get; set; }
    }
}
