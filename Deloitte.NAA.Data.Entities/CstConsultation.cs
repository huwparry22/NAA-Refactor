using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class CstConsultation
    {
        public string CstconsultationId { get; set; }
        public int ReviewBaseId { get; set; }
        public string QueryDescription { get; set; }
        public int? SubjectMatterId { get; set; }
        public string FactsAndCircumstancesOfQuery { get; set; }
        public bool? IsDataFileQuery { get; set; }
        public string LocationOfDataFile { get; set; }
        public bool? HasConsultationPassedToAnotherTeam { get; set; }
        public int? RequestPassedTo { get; set; }
        public bool? HasConsultationRequestResolved { get; set; }
        public bool? IsFollowUpRequired { get; set; }
        public DateTime? FollowUpRequiredDate { get; set; }
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

        public virtual State CurrentState { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
        public virtual User StateChangedByUser { get; set; }
    }
}
