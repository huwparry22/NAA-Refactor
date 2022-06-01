using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ArchivedHistory
    {
        public int ArchivedHistoryId { get; set; }
        public int? ReviewBaseId { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Reference { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateAmended { get; set; }
        public string Operation { get; set; }
        public byte[] ArchivedHistoryRowVersion { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
    }
}
