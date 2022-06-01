using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EmailRecipient
    {
        public EmailRecipient()
        {
            EmailLog = new HashSet<EmailLog>();
            EmailRecipientRole = new HashSet<EmailRecipientRole>();
        }

        public int EmailRecipientId { get; set; }
        public Guid Guid { get; set; }
        public int EmailId { get; set; }
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? IsTo { get; set; }
        public string CcuserEmail { get; set; }

        public virtual Email Email { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<EmailLog> EmailLog { get; set; }
        public virtual ICollection<EmailRecipientRole> EmailRecipientRole { get; set; }
    }
}
