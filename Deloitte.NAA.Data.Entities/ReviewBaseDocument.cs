using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewBaseDocument
    {
        public int ReviewBaseDocumentId { get; set; }
        public int ReviewBaseId { get; set; }
        public int DocumentId { get; set; }
        public bool? Active { get; set; }
        public byte[] RowVersion { get; set; }
        public string ConsultationId { get; set; }
        public int DocumentType { get; set; }
        public string SpfileUrl { get; set; }
        public bool? UploadedToSharePoint { get; set; }

        public virtual Document Document { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
    }
}
