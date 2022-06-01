using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class NaaConsultation
    {
        public NaaConsultation()
        {
            MasterRequiredConsultation = new HashSet<MasterRequiredConsultation>();
            MemberFirmConsultationType = new HashSet<MemberFirmConsultationType>();
            SubjectMatter = new HashSet<SubjectMatter>();
        }

        public int NaaconsultationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public byte[] RowVersion { get; set; }
        public string Abbreviated { get; set; }
        public string HelpText { get; set; }
        public int? Sequence { get; set; }
        public bool HasSignOff { get; set; }
        public int PreSignBy { get; set; }

        public virtual ICollection<MasterRequiredConsultation> MasterRequiredConsultation { get; set; }
        public virtual ICollection<MemberFirmConsultationType> MemberFirmConsultationType { get; set; }
        public virtual ICollection<SubjectMatter> SubjectMatter { get; set; }
    }
}
