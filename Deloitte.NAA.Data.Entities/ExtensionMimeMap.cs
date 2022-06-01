using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ExtensionMimeMap
    {
        public ExtensionMimeMap()
        {
            Document = new HashSet<Document>();
            EmailAttachment = new HashSet<EmailAttachment>();
        }

        public int ExtensionMimeMapId { get; set; }
        public string MimeType { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }

        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<EmailAttachment> EmailAttachment { get; set; }
    }
}
