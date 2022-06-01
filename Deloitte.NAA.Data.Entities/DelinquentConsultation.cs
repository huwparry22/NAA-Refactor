using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DelinquentConsultation
    {
        public int? ReviewBaseId { get; set; }
        public string ConsultationTypeId { get; set; }
        public bool? SlowConsultationFlag { get; set; }
        public DateTime? SlowConsultationEmailSent { get; set; }
        public int? SlowConsultationReviewStatus { get; set; }
        public bool? DelinquentFlag { get; set; }
        public DateTime? DelinquentEmailSent { get; set; }
        public int? DelinquentReviewStatus { get; set; }
        public string DelinquentExplanation { get; set; }
        public bool? Active { get; set; }
        public int? SlowConsultationNoOfDaysStayed { get; set; }
        public int? DelinquentConsultationNoOfDaysStayed { get; set; }
        public byte[] RowVersion { get; set; }
        public int Id { get; set; }

        public virtual ReviewBase ReviewBase { get; set; }
    }
}
