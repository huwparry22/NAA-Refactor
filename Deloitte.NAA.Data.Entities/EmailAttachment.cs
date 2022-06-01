using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EmailAttachment
    {
        public int AttachmentId { get; set; }
        public int EmailId { get; set; }
        public byte[] Attachment { get; set; }
        public int ExtensionMimeMapId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual Email Email { get; set; }
        public virtual ExtensionMimeMap ExtensionMimeMap { get; set; }
    }
}
