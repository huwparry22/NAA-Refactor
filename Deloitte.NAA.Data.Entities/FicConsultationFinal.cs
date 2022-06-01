using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicConsultationFinal
    {
        public int FicconsultationFinalId { get; set; }
        public string FicconsultationId { get; set; }
        public bool? Independent { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? ValuationId { get; set; }
        public int? HedgeAccountingId { get; set; }
        public bool? Memo { get; set; }
        public string MemoReference { get; set; }
        public string OtherSpecialistInvolved { get; set; }
        public double? TotalHoursByAllSpecialists { get; set; }
        public string ValuationIssuesIdentified { get; set; }
        public bool? HedgeAccounting { get; set; }
        public bool OutcomeAchieved { get; set; }
        public bool OutcomeFailed { get; set; }
        public bool OutcomeImprovementsSuggested { get; set; }
        public string OtherFinalSignOffComments { get; set; }
        public bool RevalTradesArchived { get; set; }
        public bool ClientDataRemovedFromLaptop { get; set; }
        public bool ConfirmIhaveReviewed { get; set; }

        public virtual FicConsultation Ficconsultation { get; set; }
    }
}
