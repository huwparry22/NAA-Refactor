using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class MemberFirmConsultationType
    {
        public int Id { get; set; }
        public int NaaconsultaionTypeId { get; set; }
        public int MemberfirmId { get; set; }
        public string Email { get; set; }
        public string HelpText { get; set; }
        public bool Active { get; set; }

        public virtual MemberFirm Memberfirm { get; set; }
        public virtual NaaConsultation NaaconsultaionType { get; set; }
    }
}
