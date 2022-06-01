using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ViewFileStatusText
    {
        public int? TypeOfConsultationId { get; set; }
        public int FileStatus { get; set; }
        public string Description { get; set; }
    }
}
