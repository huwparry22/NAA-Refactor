using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class Document
    {
        public Document()
        {
            ReviewBaseDocument = new HashSet<ReviewBaseDocument>();
            ReviewPoint = new HashSet<ReviewPoint>();
        }

        public int DocumentId { get; set; }
        public int? OriginalDocumentId { get; set; }
        public string OriginalFilename { get; set; }
        public string ModifiedFilename { get; set; }
        public string Description { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Charset { get; set; }
        public string Encoding { get; set; }
        public string Extension { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual ExtensionMimeMap ExtensionNavigation { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual DocumentData DocumentData { get; set; }
        public virtual ICollection<ReviewBaseDocument> ReviewBaseDocument { get; set; }
        public virtual ICollection<ReviewPoint> ReviewPoint { get; set; }
    }
}
