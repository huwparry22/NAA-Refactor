using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class SubjectMatter
    {
        public int SubjectMatterId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public byte[] RowVersion { get; set; }
        public int? Sequence { get; set; }
        public int ConsultationTypeId { get; set; }
        public bool ApplicableToAllMemberFirms { get; set; }

        public virtual NaaConsultation ConsultationType { get; set; }
    }
}
