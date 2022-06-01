using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EmailLog
    {
        public int EmailLogId { get; set; }
        public int EmailRecipientId { get; set; }
        public int EmailStatus { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual EmailRecipient EmailRecipient { get; set; }
    }
}
