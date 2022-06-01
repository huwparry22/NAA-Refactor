using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ViewIfrsData
    {
        public string AccountingConsultationId { get; set; }
        public int SubjectMatterId { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
}
