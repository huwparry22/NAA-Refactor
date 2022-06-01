using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class DaemsConsultation
    {
        public DaemsConsultation()
        {
            DaemsconsultationIndividual = new HashSet<DaemsConsultationIndividual>();
        }

        public string DaemsconsultationId { get; set; }
        public int ReviewBaseId { get; set; }
        public string QueryDescription { get; set; }
        public int? TypeOfConsultationId { get; set; }
        public string ReasonForRequest { get; set; }
        public byte? ReasonForRequestId { get; set; }
        public byte? FileStatus { get; set; }
        public string EmsfileName { get; set; }
        public string FileId { get; set; }
        public string ItscallId { get; set; }
        public int? EpsignoffBy { get; set; }
        public DateTime? EpsignoffDateTime { get; set; }
        public int CurrentStateId { get; set; }
        public DateTime StateChangedDate { get; set; }
        public int StateChangedByUserId { get; set; }
        public string WithdrawalReason { get; set; }
        public string RejectionReason { get; set; }
        public byte[] RowVersion { get; set; }
        public string FactsAndCircumstancesOfQuery { get; set; }
        public byte? EngagementTypeId { get; set; }
        public byte? AuditStandardId { get; set; }
        public bool? GroupAudit { get; set; }
        public bool? LetterBoxAuditId { get; set; }
        public string LetterBoxAuditSpecify { get; set; }
        public byte? MemberFirmPerformsFieldWorkId { get; set; }
        public byte? LocalMemberFirmPerformsFieldWorkId { get; set; }
        public string DocumentOtherInformation { get; set; }
        public byte? EmsversionId { get; set; }
        public string MemberFirmEngagementFile { get; set; }
        public DateTime? ArchiveDeadlineDate { get; set; }
        public bool? RecipientMemberFirmReceived { get; set; }
        public byte? AuditReportSigned { get; set; }
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
        public virtual User EpsignoffByNavigation { get; set; }
        public virtual ReviewBase ReviewBase { get; set; }
        public virtual User StateChangedByUser { get; set; }
        public virtual ICollection<DaemsConsultationIndividual> DaemsconsultationIndividual { get; set; }
    }
}
