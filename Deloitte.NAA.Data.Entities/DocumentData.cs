using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DocumentData
    {
        public int DocumentDataId { get; set; }
        public int DocumentId { get; set; }
        public byte[] Data { get; set; }

        public virtual Document Document { get; set; }
    }
}
