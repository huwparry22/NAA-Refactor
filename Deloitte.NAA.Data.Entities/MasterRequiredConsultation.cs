using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class MasterRequiredConsultation
    {
        public MasterRequiredConsultation()
        {
            MasterConsultationMemberFirms = new HashSet<MasterConsultationMemberFirms>();
        }

        public int ConsultationTypeId { get; set; }
        public string Name { get; set; }
        public int NaaconsultationId { get; set; }
        public bool Active { get; set; }
        public byte[] RowVersion { get; set; }
        public int Sequence { get; set; }
        public byte? RiskRating { get; set; }
        public bool? PublicInterest { get; set; }
        public int? ProfessionalStandards { get; set; }
        public string Code { get; set; }
        public string BasisofDiscussion { get; set; }
        public string SummaryofDiscussion { get; set; }
        public string Reference { get; set; }
        public string OtherRemark { get; set; }
        public string Condition { get; set; }
        public bool FinalSignOffRequired { get; set; }
        public bool ApplicableToAllMemberFirms { get; set; }

        public virtual NaaConsultation Naaconsultation { get; set; }
        public virtual ICollection<MasterConsultationMemberFirms> MasterConsultationMemberFirms { get; set; }
    }
}
