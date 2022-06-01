using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicConsultationOtherIssue
    {
        public int FicconsultationOtherIssueId { get; set; }
        public string FicconsultationId { get; set; }
        public bool? EmbeddedIdentified { get; set; }
        public string EmbeddedIdentifiedList { get; set; }
        public string EmbeddedProcedures { get; set; }
        public string Vacprocedures { get; set; }
        public string VaccalculatedList { get; set; }
        public string Vacimpact { get; set; }
        public bool? Csa { get; set; }
        public bool? NetAgreements { get; set; }
        public string OtherFi { get; set; }
        public bool? OtherRisk { get; set; }
        public string OtherRiskList { get; set; }
        public bool? Vaccalculated { get; set; }

        public virtual FicConsultation Ficconsultation { get; set; }
    }
}
