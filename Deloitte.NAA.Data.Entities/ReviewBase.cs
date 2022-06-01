using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewBase
    {
        public ReviewBase()
        {
            AccountingConsultation = new HashSet<AccountingConsultation>();
            Aqrmconsultation = new HashSet<AqrmConsultation>();
            ArchivedHistory = new HashSet<ArchivedHistory>();
            AuditConsultation = new HashSet<AuditConsultation>();
            Cceconsultation = new HashSet<CceConsultation>();
            Cemoconsultation = new HashSet<CemoConsultation>();
            CgovConsultation = new HashSet<CgovConsultation>();
            Cstconsultation = new HashSet<CstConsultation>();
            Daemsconsultation = new HashSet<DaemsConsultation>();
            DelinquentConsultation = new HashSet<DelinquentConsultation>();
            DelinquentHistory = new HashSet<DelinquentHistory>();
            DuplicateReviews = new HashSet<DuplicateReviews>();
            Earconsultation = new HashSet<EarConsultation>();
            EmailNotification = new HashSet<EmailNotification>();
            Ficconsultation = new HashSet<FicConsultation>();
            HoldsOnRelease = new HashSet<HoldsOnRelease>();
            RelatedQueriesRelatedReviewBase = new HashSet<RelatedQueries>();
            RelatedQueriesReviewBase = new HashSet<RelatedQueries>();
            ReviewArmfield = new HashSet<ReviewArmField>();
            ReviewBaseDocument = new HashSet<ReviewBaseDocument>();
            ReviewPoint = new HashSet<ReviewPoint>();
            ReviewState = new HashSet<ReviewState>();
            ReviewUser = new HashSet<ReviewUser>();
        }

        public int ReviewBaseId { get; set; }
        public string Dunsnumber { get; set; }
        public string ArmentityId { get; set; }
        public string EntityName { get; set; }
        public string Uhcdunsnumber { get; set; }
        public string Uhcname { get; set; }
        public DateTime FinancialYearEnd { get; set; }
        public bool? IsSecregistrant { get; set; }
        public bool? IsRelatedToSecregistrant { get; set; }
        public bool? IsPublicInterestEntity { get; set; }
        public int? PartnerOfficeId { get; set; }
        public string MarketListings { get; set; }
        public int CurrentStateId { get; set; }
        public DateTime StateChangedDate { get; set; }
        public int StateChangedByUserId { get; set; }
        public string WithdrawalReason { get; set; }
        public int? RiskRating { get; set; }
        public string RiskRatingReason { get; set; }
        public string OperatingUnit { get; set; }
        public decimal? CalculatedCharge { get; set; }
        public bool? IsBillable { get; set; }
        public decimal? AmountBilled { get; set; }
        public DateTime? DateBilled { get; set; }
        public bool? IsSecrelationship { get; set; }
        public byte[] RowVersion { get; set; }
        public bool IsConfidentialQuery { get; set; }
        public string Wbsnumber { get; set; }
        public int? SecRelationship { get; set; }
        public string WithdrawalApprovalReason { get; set; }
        public int MemberFirmId { get; set; }

        public virtual State CurrentState { get; set; }
        public virtual MemberFirm MemberFirm { get; set; }
        public virtual Office PartnerOffice { get; set; }
        public virtual User StateChangedByUser { get; set; }
        public virtual DocumentReview DocumentReview { get; set; }
        public virtual FileReview FileReview { get; set; }
        public virtual ICollection<AccountingConsultation> AccountingConsultation { get; set; }
        public virtual ICollection<AqrmConsultation> Aqrmconsultation { get; set; }
        public virtual ICollection<ArchivedHistory> ArchivedHistory { get; set; }
        public virtual ICollection<AuditConsultation> AuditConsultation { get; set; }
        public virtual ICollection<CceConsultation> Cceconsultation { get; set; }
        public virtual ICollection<CemoConsultation> Cemoconsultation { get; set; }
        public virtual ICollection<CgovConsultation> CgovConsultation { get; set; }
        public virtual ICollection<CstConsultation> Cstconsultation { get; set; }
        public virtual ICollection<DaemsConsultation> Daemsconsultation { get; set; }
        public virtual ICollection<DelinquentConsultation> DelinquentConsultation { get; set; }
        public virtual ICollection<DelinquentHistory> DelinquentHistory { get; set; }
        public virtual ICollection<DuplicateReviews> DuplicateReviews { get; set; }
        public virtual ICollection<EarConsultation> Earconsultation { get; set; }
        public virtual ICollection<EmailNotification> EmailNotification { get; set; }
        public virtual ICollection<FicConsultation> Ficconsultation { get; set; }
        public virtual ICollection<HoldsOnRelease> HoldsOnRelease { get; set; }
        public virtual ICollection<RelatedQueries> RelatedQueriesRelatedReviewBase { get; set; }
        public virtual ICollection<RelatedQueries> RelatedQueriesReviewBase { get; set; }
        public virtual ICollection<ReviewArmField> ReviewArmfield { get; set; }
        public virtual ICollection<ReviewBaseDocument> ReviewBaseDocument { get; set; }
        public virtual ICollection<ReviewPoint> ReviewPoint { get; set; }
        public virtual ICollection<ReviewState> ReviewState { get; set; }
        public virtual ICollection<ReviewUser> ReviewUser { get; set; }
    }
}
