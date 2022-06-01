using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class AccountingConsultation
    {
        public AccountingConsultation()
        {
            AccountingFramework = new HashSet<AccountingFramework>();
            IfrsstandardAndTopic = new HashSet<IfrsStandardAndTopic>();
        }

        public string AccountingConsultationId { get; set; }
        public int ReviewBaseId { get; set; }
        public string QueryDescription { get; set; }
        public int? RequestTypeId { get; set; }
        public string FactsAndCircumstancesOfQuery { get; set; }
        public int? EpsignoffBy { get; set; }
        public DateTime? EpsignoffDateTime { get; set; }
        public int CurrentStateId { get; set; }
        public DateTime StateChangedDate { get; set; }
        public int StateChangedByUserId { get; set; }
        public string WithdrawalReason { get; set; }
        public string RejectionReason { get; set; }
        public byte[] RowVersion { get; set; }
        public int? NaapartnerSignoffBy { get; set; }
        public DateTime? NaapartnerSignoffDateTime { get; set; }
        public bool? IsIssueCoveredinExistingDeloitteGuidence { get; set; }
        public string BasisoftheConsultationResponse { get; set; }
        public string ConsultationResponse { get; set; }
        public string Conditions { get; set; }
        public string References { get; set; }
        public string OtherRemarks { get; set; }
        public bool? HasaFormalResponseBeenRequested { get; set; }
        public int? PriorityId { get; set; }
        public string PriorityReason { get; set; }
        public string Notes { get; set; }
        public bool? IsRelatedtoMorethanOneEntity { get; set; }
        public int? NumberofEntities { get; set; }
        public string NameofEntities { get; set; }
        public string AccountingStandardRefrence { get; set; }
        public bool? IsDiscussedWithNaateam { get; set; }
        public string NameofNaateamMember { get; set; }
        public string CommentstoImproveGuidance { get; set; }
        public string RefrenceGuidance { get; set; }
        public int? ChaserEmail { get; set; }
        public DateTime? ChaserEmailUpdateDate { get; set; }
        public string ResearchUndertaken { get; set; }
        public string WithdrawalApprovalReason { get; set; }
        public bool? IsPriorYear { get; set; }
        public int? PriorYearEntityId { get; set; }
        public int? TypeofChangeinAccountingId { get; set; }
        public int? ConclusionPriorYearId { get; set; }
        public bool IsDelinquencyStopped { get; set; }
        public int? EqcrsignoffBy { get; set; }
        public DateTime? EqcrsignoffDateTime { get; set; }
        public int? PreSignOffRole { get; set; }
        public int? PreSignOffBy { get; set; }
        public DateTime? PreSignOffDateTime { get; set; }

        public virtual State CurrentState { get; set; }
        public virtual User EpsignoffByNavigation { get; set; }
        public virtual User EqcrsignoffByNavigation { get; set; }
        public virtual User NaapartnerSignoffByNavigation { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
        public virtual User StateChangedByUser { get; set; }
        public virtual ICollection<AccountingFramework> AccountingFramework { get; set; }
        public virtual ICollection<IfrsStandardAndTopic> IfrsstandardAndTopic { get; set; }
    }
}
