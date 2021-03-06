using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class AuditLog
    {
        public int AuditLogId { get; set; }
        public DateTime AuditTime { get; set; }
        public int SqlprocessId { get; set; }
        public string SqluserName { get; set; }
        public int? AuditUserId { get; set; }
        public string AuditDetail { get; set; }
    }
}
