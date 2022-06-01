﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class EarConsultation
    {
        public EarConsultation()
        {
            EarconsultationOffshoreEntity = new HashSet<EarConsultationOffshoreEntity>();
        }

        public string EarconsultationId { get; set; }
        public int ReviewBaseId { get; set; }
        public string QueryDescription { get; set; }
        public DateTime? AuditReportSigningDate { get; set; }
        public DateTime? DateEarreviewRequestedBy { get; set; }
        public bool? IsFirstYearofPreparingEar { get; set; }
        public int? ReasonForEar { get; set; }
        public bool? IsOffshoreEntity { get; set; }
        public bool? AuditReportObservation { get; set; }
        public bool? IsEntityPreparingGrpOrCompany { get; set; }
        public int? Gaap { get; set; }
        public bool? IsModificationAuditOpinion { get; set; }
        public string FactsAndCircumstancesOfQuery { get; set; }
        public int? RequestTypeId { get; set; }
        public bool? ComplexityOfRequest { get; set; }
        public bool? DiscussionLowReviewBeenCompleted { get; set; }
        public string DiscussionLowReviewEngtTeamCleared { get; set; }
        public bool? DiscussionMediumReviewBeenCompleted { get; set; }
        public string DiscussionMediumReviewEngTeamCleared { get; set; }
        public bool? DiscussionMediumSecondReviewBeenCompleted { get; set; }
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
        public int? PriorityId { get; set; }
        public string PriorityReason { get; set; }
        public string Notes { get; set; }
        public bool? IsRelatedtoMorethanOneEntity { get; set; }
        public int? NumberofEntities { get; set; }
        public string NameofEntities { get; set; }
        public bool? IsDiscussedWithNaateam { get; set; }
        public string NameofNaateamMember { get; set; }
        public bool? IsRiskTableIncluded { get; set; }
        public int? ChaserEmail { get; set; }
        public DateTime? ChaserEmailUpdateDate { get; set; }
        public string WithdrawalApprovalReason { get; set; }
        public bool IsDelinquencyStopped { get; set; }

        public virtual State CurrentState { get; set; }
        public virtual User EpsignoffByNavigation { get; set; }
        public virtual User NaapartnerSignoffByNavigation { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
        public virtual User StateChangedByUser { get; set; }
        public virtual ICollection<EarConsultationOffshoreEntity> EarconsultationOffshoreEntity { get; set; }
    }
}
