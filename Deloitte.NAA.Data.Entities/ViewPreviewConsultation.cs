using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ViewPreviewConsultation
    {
        public int ReviewBaseId { get; set; }
        public string EntityName { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ConsultationId { get; set; }
        public string QueryDescription { get; set; }
        public string StateText { get; set; }
        public int? StateId { get; set; }
        public int ConsultationType { get; set; }
        public bool IsConfidentialQuery { get; set; }
        public int MemberFirmId { get; set; }
        public string Notes { get; set; }
        public int? PriorityId { get; set; }
    }
}
