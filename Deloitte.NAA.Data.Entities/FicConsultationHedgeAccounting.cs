using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicConsultationHedgeAccounting
    {
        public int FicconsultationHedgeAccountingId { get; set; }
        public string FicconsultationId { get; set; }
        public bool? RulesApply { get; set; }
        public string Details { get; set; }
        public string Procedures { get; set; }
        public int? HedgeAccountingType { get; set; }

        public virtual FicConsultation Ficconsultation { get; set; }
    }
}
