using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ConsultationDocument
    {
        public int ConsultationDocumentId { get; set; }
        public string DocumentId { get; set; }
        public string ConsultationTypeId { get; set; }
        public int? DocumentTypeId { get; set; }
        public bool Active { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
