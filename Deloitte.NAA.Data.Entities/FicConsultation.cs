using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class FicConsultation
    {
        public FicConsultation()
        {
            FicconsultationClient = new HashSet<FicConsultationClient>();
            FicconsultationControl = new HashSet<FicConsultationControl>();
            FicconsultationFinal = new HashSet<FicConsultationFinal>();
            FicconsultationHedgeAccounting = new HashSet<FicConsultationHedgeAccounting>();
            FicconsultationOtherIssue = new HashSet<FicConsultationOtherIssue>();
            FicconsultationRequiredDocument = new HashSet<FicConsultationRequiredDocument>();
            FicconsultationReview = new HashSet<FicConsultationReview>();
            FicconsultationSummary = new HashSet<FicConsultationSummary>();
            Ficgrid = new HashSet<FicGrid>();
        }

        public string FicconsultationId { get; set; }
        public int ReviewBaseId { get; set; }
        public int? RequestTypeId { get; set; }
        public int CurrentStateId { get; set; }
        public DateTime StateChangedDate { get; set; }
        public int StateChangedByUserId { get; set; }
        public string WithdrawalReason { get; set; }
        public string RejectionReason { get; set; }
        public byte[] RowVersion { get; set; }
        public int? PriorityId { get; set; }
        public string PriorityReason { get; set; }
        public string Notes { get; set; }
        public bool? IsRelatedtoMorethanOneEntity { get; set; }
        public int? NumberofEntities { get; set; }
        public string NameofEntities { get; set; }
        public bool? IsDiscussedWithNaateam { get; set; }
        public string NameofNaateamMember { get; set; }
        public int? ChaserEmail { get; set; }
        public DateTime? ChaserEmailUpdateDate { get; set; }
        public string WithdrawalApprovalReason { get; set; }
        public bool IsDelinquencyStopped { get; set; }
        public int? EpsignoffBy { get; set; }
        public DateTime? EpsignoffDateTime { get; set; }
        public int? NaapartnerSignoffBy { get; set; }
        public DateTime? NaapartnerSignoffDateTime { get; set; }
        public int? EqcrsignoffBy { get; set; }
        public DateTime? EqcrsignoffDateTime { get; set; }
        public int? ConsultationTypeId { get; set; }
        public int? PreSignOffRole { get; set; }
        public int? PreSignOffBy { get; set; }
        public DateTime? PreSignOffDateTime { get; set; }
        public bool? PricingTeamRequired { get; set; }

        public virtual State CurrentState { get; set; }
        public virtual User EpsignoffByNavigation { get; set; }
        public virtual User EqcrsignoffByNavigation { get; set; }
        public virtual User NaapartnerSignoffByNavigation { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
        public virtual User StateChangedByUser { get; set; }
        public virtual ICollection<FicConsultationClient> FicconsultationClient { get; set; }
        public virtual ICollection<FicConsultationControl> FicconsultationControl { get; set; }
        public virtual ICollection<FicConsultationFinal> FicconsultationFinal { get; set; }
        public virtual ICollection<FicConsultationHedgeAccounting> FicconsultationHedgeAccounting { get; set; }
        public virtual ICollection<FicConsultationOtherIssue> FicconsultationOtherIssue { get; set; }
        public virtual ICollection<FicConsultationRequiredDocument> FicconsultationRequiredDocument { get; set; }
        public virtual ICollection<FicConsultationReview> FicconsultationReview { get; set; }
        public virtual ICollection<FicConsultationSummary> FicconsultationSummary { get; set; }
        public virtual ICollection<FicGrid> Ficgrid { get; set; }
    }
}
