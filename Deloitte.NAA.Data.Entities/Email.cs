using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class Email
    {
        public Email()
        {
            EmailAttachment = new HashSet<EmailAttachment>();
            EmailRecipient = new HashSet<EmailRecipient>();
        }

        public int EmailId { get; set; }
        public int EmailNotificationId { get; set; }
        public int TemplateTypeId { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public bool Processed { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsHighPriority { get; set; }

        public virtual EmailNotification EmailNotification { get; set; }
        public virtual EmailTemplateType TemplateType { get; set; }
        public virtual ICollection<EmailAttachment> EmailAttachment { get; set; }
        public virtual ICollection<EmailRecipient> EmailRecipient { get; set; }
    }
}
