using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class CemoConsultationRequestReason
    {
        public int CemoconsultationRequestReasonId { get; set; }
        public string CemoconsultationId { get; set; }
        public int CemorequestReasonId { get; set; }
        public byte[] RowVersion { get; set; }
        public string Other { get; set; }

        public virtual CemoConsultation Cemoconsultation { get; set; }
        public virtual CemoRequestReason CemorequestReason { get; set; }
    }
}
