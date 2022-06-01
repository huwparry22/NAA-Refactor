using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class User
    {
        public User()
        {
            AccountingConsultationEpsignoffByNavigation = new HashSet<AccountingConsultation>();
            AccountingConsultationEqcrsignoffByNavigation = new HashSet<AccountingConsultation>();
            AccountingConsultationNaapartnerSignoffByNavigation = new HashSet<AccountingConsultation>();
            AccountingConsultationStateChangedByUser = new HashSet<AccountingConsultation>();
            AqrmconsultationEpsignoffByNavigation = new HashSet<AqrmConsultation>();
            AqrmconsultationEqcrsignoffByNavigation = new HashSet<AqrmConsultation>();
            AqrmconsultationNaapartnerSignoffByNavigation = new HashSet<AqrmConsultation>();
            AqrmconsultationStateChangedByUser = new HashSet<AqrmConsultation>();
            AuditConsultationEpsignoffByNavigation = new HashSet<AuditConsultation>();
            AuditConsultationEqcrsignoffByNavigation = new HashSet<AuditConsultation>();
            AuditConsultationNaapartnerSignoffByNavigation = new HashSet<AuditConsultation>();
            AuditConsultationStateChangedByUser = new HashSet<AuditConsultation>();
            CceconsultationEpsignoffByNavigation = new HashSet<CceConsultation>();
            CceconsultationEqcrsignoffByNavigation = new HashSet<CceConsultation>();
            CceconsultationNaapartnerSignoffByNavigation = new HashSet<CceConsultation>();
            CceconsultationStateChangedByUser = new HashSet<CceConsultation>();
            CemoconsultationEpsignoffByNavigation = new HashSet<CemoConsultation>();
            CemoconsultationNaapartnerSignoffByNavigation = new HashSet<CemoConsultation>();
            CemoconsultationStateChangedByUser = new HashSet<CemoConsultation>();
            CgovConsultationEpsignoffByNavigation = new HashSet<CgovConsultation>();
            CgovConsultationEqcrsignoffByNavigation = new HashSet<CgovConsultation>();
            CgovConsultationNaapartnerSignoffByNavigation = new HashSet<CgovConsultation>();
            CgovConsultationStateChangedByUser = new HashSet<CgovConsultation>();
            ConsultationReviewPoint = new HashSet<ConsultationReviewPoint>();
            Cstconsultation = new HashSet<CstConsultation>();
            DaemsconsultationEpsignoffByNavigation = new HashSet<DaemsConsultation>();
            DaemsconsultationIndividual = new HashSet<DaemsConsultationIndividual>();
            DaemsconsultationStateChangedByUser = new HashSet<DaemsConsultation>();
            DocumentCreatedByUser = new HashSet<Document>();
            DocumentModifiedByUser = new HashSet<Document>();
            EarconsultationEpsignoffByNavigation = new HashSet<EarConsultation>();
            EarconsultationNaapartnerSignoffByNavigation = new HashSet<EarConsultation>();
            EarconsultationStateChangedByUser = new HashSet<EarConsultation>();
            EmailRecipient = new HashSet<EmailRecipient>();
            FicconsultationEpsignoffByNavigation = new HashSet<FicConsultation>();
            FicconsultationEqcrsignoffByNavigation = new HashSet<FicConsultation>();
            FicconsultationNaapartnerSignoffByNavigation = new HashSet<FicConsultation>();
            FicconsultationStateChangedByUser = new HashSet<FicConsultation>();
            HoldsOnRelease = new HashSet<HoldsOnRelease>();
            PersonalRight = new HashSet<PersonalRight>();
            RelatedQueries = new HashSet<RelatedQueries>();
            ReviewBase = new HashSet<ReviewBase>();
            ReviewPoint = new HashSet<ReviewPoint>();
            ReviewPointCommentCommentByReviewUser = new HashSet<ReviewPointComment>();
            ReviewPointCommentResponseByReviewerUser = new HashSet<ReviewPointComment>();
            ReviewState = new HashSet<ReviewState>();
            ReviewUserSignedOffByUser = new HashSet<ReviewUser>();
            ReviewUserUser = new HashSet<ReviewUser>();
            SubsidiaryEntityEngagementManager = new HashSet<SubsidiaryEntity>();
            SubsidiaryEntityEngagementPartner = new HashSet<SubsidiaryEntity>();
            UserConsultationType = new HashSet<UserConsultationType>();
            UserDocumentType = new HashSet<UserDocumentType>();
            UserOffice = new HashSet<UserOffice>();
            UserRole = new HashSet<UserRole>();
            UsersApplicableMemberFirms = new HashSet<UsersApplicableMemberFirms>();
        }

        public int UserId { get; set; }
        public string SappersonnelNo { get; set; }
        public string ActiveDirectoryId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string SearchName { get; set; }
        public string LoginName { get; set; }
        public string DomainName { get; set; }
        public bool Active { get; set; }
        public string Grade { get; set; }
        public string Phone { get; set; }
        public string PositionTitle { get; set; }
        public string Email { get; set; }
        public bool? SpecialistReviewer { get; set; }
        public byte[] Timestamp { get; set; }
        public int PageSize { get; set; }
        public string CurrentView { get; set; }
        public string SortColumn { get; set; }
        public int? SortDirection { get; set; }
        public string CurrentConsultationType { get; set; }
        public int? OperatingUnit { get; set; }
        public int? OfficeId { get; set; }
        public decimal? ChargePerHour { get; set; }
        public bool IsMyConsultation { get; set; }
        public string MiddleName { get; set; }
        public DateTime? LastLoggedIn { get; set; }
        public string CountryCode { get; set; }
        public string ServiceLine { get; set; }

        public virtual ICollection<AccountingConsultation> AccountingConsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<AccountingConsultation> AccountingConsultationEqcrsignoffByNavigation { get; set; }
        public virtual ICollection<AccountingConsultation> AccountingConsultationNaapartnerSignoffByNavigation { get; set; }
        public virtual ICollection<AccountingConsultation> AccountingConsultationStateChangedByUser { get; set; }
        public virtual ICollection<AqrmConsultation> AqrmconsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<AqrmConsultation> AqrmconsultationEqcrsignoffByNavigation { get; set; }
        public virtual ICollection<AqrmConsultation> AqrmconsultationNaapartnerSignoffByNavigation { get; set; }
        public virtual ICollection<AqrmConsultation> AqrmconsultationStateChangedByUser { get; set; }
        public virtual ICollection<AuditConsultation> AuditConsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<AuditConsultation> AuditConsultationEqcrsignoffByNavigation { get; set; }
        public virtual ICollection<AuditConsultation> AuditConsultationNaapartnerSignoffByNavigation { get; set; }
        public virtual ICollection<AuditConsultation> AuditConsultationStateChangedByUser { get; set; }
        public virtual ICollection<CceConsultation> CceconsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<CceConsultation> CceconsultationEqcrsignoffByNavigation { get; set; }
        public virtual ICollection<CceConsultation> CceconsultationNaapartnerSignoffByNavigation { get; set; }
        public virtual ICollection<CceConsultation> CceconsultationStateChangedByUser { get; set; }
        public virtual ICollection<CemoConsultation> CemoconsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<CemoConsultation> CemoconsultationNaapartnerSignoffByNavigation { get; set; }
        public virtual ICollection<CemoConsultation> CemoconsultationStateChangedByUser { get; set; }
        public virtual ICollection<CgovConsultation> CgovConsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<CgovConsultation> CgovConsultationEqcrsignoffByNavigation { get; set; }
        public virtual ICollection<CgovConsultation> CgovConsultationNaapartnerSignoffByNavigation { get; set; }
        public virtual ICollection<CgovConsultation> CgovConsultationStateChangedByUser { get; set; }
        public virtual ICollection<ConsultationReviewPoint> ConsultationReviewPoint { get; set; }
        public virtual ICollection<CstConsultation> Cstconsultation { get; set; }
        public virtual ICollection<DaemsConsultation> DaemsconsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<DaemsConsultationIndividual> DaemsconsultationIndividual { get; set; }
        public virtual ICollection<DaemsConsultation> DaemsconsultationStateChangedByUser { get; set; }
        public virtual ICollection<Document> DocumentCreatedByUser { get; set; }
        public virtual ICollection<Document> DocumentModifiedByUser { get; set; }
        public virtual ICollection<EarConsultation> EarconsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<EarConsultation> EarconsultationNaapartnerSignoffByNavigation { get; set; }
        public virtual ICollection<EarConsultation> EarconsultationStateChangedByUser { get; set; }
        public virtual ICollection<EmailRecipient> EmailRecipient { get; set; }
        public virtual ICollection<FicConsultation> FicconsultationEpsignoffByNavigation { get; set; }
        public virtual ICollection<FicConsultation> FicconsultationEqcrsignoffByNavigation { get; set; }
        public virtual ICollection<FicConsultation> FicconsultationNaapartnerSignoffByNavigation { get; set; }
        public virtual ICollection<FicConsultation> FicconsultationStateChangedByUser { get; set; }
        public virtual ICollection<HoldsOnRelease> HoldsOnRelease { get; set; }
        public virtual ICollection<PersonalRight> PersonalRight { get; set; }
        public virtual ICollection<RelatedQueries> RelatedQueries { get; set; }
        public virtual ICollection<ReviewBase> ReviewBase { get; set; }
        public virtual ICollection<ReviewPoint> ReviewPoint { get; set; }
        public virtual ICollection<ReviewPointComment> ReviewPointCommentCommentByReviewUser { get; set; }
        public virtual ICollection<ReviewPointComment> ReviewPointCommentResponseByReviewerUser { get; set; }
        public virtual ICollection<ReviewState> ReviewState { get; set; }
        public virtual ICollection<ReviewUser> ReviewUserSignedOffByUser { get; set; }
        public virtual ICollection<ReviewUser> ReviewUserUser { get; set; }
        public virtual ICollection<SubsidiaryEntity> SubsidiaryEntityEngagementManager { get; set; }
        public virtual ICollection<SubsidiaryEntity> SubsidiaryEntityEngagementPartner { get; set; }
        public virtual ICollection<UserConsultationType> UserConsultationType { get; set; }
        public virtual ICollection<UserDocumentType> UserDocumentType { get; set; }
        public virtual ICollection<UserOffice> UserOffice { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<UsersApplicableMemberFirms> UsersApplicableMemberFirms { get; set; }
    }
}
