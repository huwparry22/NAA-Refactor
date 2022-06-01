using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class OfflineEmail
    {
        public OfflineEmail()
        {
            OfflineEmailFailure = new HashSet<OfflineEmailFailure>();
        }

        public int OfflineEmailId { get; set; }
        public bool? Psrprocessed { get; set; }
        public DateTime? PsrprocessedDate { get; set; }
        public DateTime PsrcreatedDate { get; set; }
        public string Address { get; set; }
        public string EntryId { get; set; }
        public DateTime Date { get; set; }
        public string Received { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string HtmlBody { get; set; }
        public DateTime DateReceived { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string ReturnPath { get; set; }
        public Guid? Guid { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<OfflineEmailFailure> OfflineEmailFailure { get; set; }
    }
}
