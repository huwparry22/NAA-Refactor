using Deloitte.NAA.Data.Entities;
using Deloitte.NAA.Data.SqlServer.Context.Configurations;
using Deloitte.NAA.Data.SqlServer.Context.Configurations.Views;
using Microsoft.EntityFrameworkCore;

namespace Deloitte.NAA.Data.SqlServer.Context
{
    public class NaaContext : DbContext
    {
        public NaaContext(DbContextOptions<NaaContext> options) : base(options) { }

        public DbSet<AccountingConsultation> AccountingConsultation { get; set; }
        public DbSet<AccountingFramework> AccountingFramework { get; set; }
        public DbSet<AqrmConsultation> Aqrmconsultation { get; set; }
        public DbSet<ArchiveDdextHistory> ArchiveDdextHistory { get; set; }
        public DbSet<ArchivedHistory> ArchivedHistory { get; set; }
        public DbSet<ArmField> Armfield { get; set; }
        public DbSet<ArmHistory> Armhistory { get; set; }
        public DbSet<AuditConsultation> AuditConsultation { get; set; }
        public DbSet<AuditLog> AuditLog { get; set; }
        public DbSet<AuditRequiredConsultation> AuditRequiredConsultation { get; set; }
        public DbSet<CceConsultation> Cceconsultation { get; set; }
        public DbSet<CemoApplicableMemberFirms> CemoapplicableMemberFirms { get; set; }
        public DbSet<CemoConsultation> Cemoconsultation { get; set; }
        public DbSet<CemoConsultationRequestReason> CemoconsultationRequestReason { get; set; }
        public DbSet<CemoRequestReason> CemorequestReason { get; set; }
        public DbSet<CgovConsultation> CgovConsultation { get; set; }
        public DbSet<Code> Code { get; set; }
        public DbSet<CodeColumnConstraint> CodeColumnConstraint { get; set; }
        public DbSet<CodeData> CodeData { get; set; }
        public DbSet<ConsultationDocument> ConsultationDocument { get; set; }
        public DbSet<ConsultationReviewPoint> ConsultationReviewPoint { get; set; }
        public DbSet<CoreDataEmployee> CoreDataEmployee { get; set; }
        public DbSet<CoreDataOrganisationOperatingUnit> CoreDataOrganisationOperatingUnit { get; set; }
        public DbSet<CoreDataWbs3Number> CoreDataWbs3number { get; set; }
        public DbSet<CorpReportingSubjectMatter> CorpReportingSubjectMatter { get; set; }
        public DbSet<CorpReportingSubjectMatterMemberFirm> CorpReportingSubjectMatterMemberFirm { get; set; }
        public DbSet<CstConsultation> Cstconsultation { get; set; }
        public DbSet<DaemsApplicableMemberFirms> DaemsapplicableMemberFirms { get; set; }
        public DbSet<DaemsConsultation> Daemsconsultation { get; set; }
        public DbSet<DaemsConsultationIndividual> DaemsconsultationIndividual { get; set; }
        public DbSet<DaemsTypeOfConsultation> DaemstypeOfConsultation { get; set; }
        public DbSet<DaemsVersion> Daemsversion { get; set; }
        public DbSet<DelinquentConfigurations> DelinquentConfigurations { get; set; }
        public DbSet<DelinquentConsultation> DelinquentConsultation { get; set; }
        public DbSet<DelinquentHistory> DelinquentHistory { get; set; }
        public DbSet<DelinquentRecipients> DelinquentRecipients { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentData> DocumentData { get; set; }
        public DbSet<DocumentReview> DocumentReview { get; set; }
        public DbSet<DocumentReviewType> DocumentReviewType { get; set; }
        public DbSet<DocumentReviewTypeCategory> DocumentReviewTypeCategory { get; set; }
        public DbSet<DuplicateReviews> DuplicateReviews { get; set; }
        public DbSet<EarApplicableMemberFirms> EarapplicableMemberFirms { get; set; }
        public DbSet<EarConsultation> Earconsultation { get; set; }
        public DbSet<EarConsultationOffshoreEntity> EarconsultationOffshoreEntity { get; set; }
        public DbSet<EarReason> Earreason { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<EmailAttachment> EmailAttachment { get; set; }
        public DbSet<EmailLog> EmailLog { get; set; }
        public DbSet<EmailNotification> EmailNotification { get; set; }
        public DbSet<EmailRecipient> EmailRecipient { get; set; }
        public DbSet<EmailRecipientRole> EmailRecipientRole { get; set; }
        public DbSet<EmailTemplateType> EmailTemplateType { get; set; }
        public DbSet<EngagementType> EngagementType { get; set; }
        public DbSet<EngagementTypeMemberFirm> EngagementTypeMemberFirm { get; set; }
        public DbSet<ExtensionMimeMap> ExtensionMimeMap { get; set; }
        public DbSet<FicConfigData> FicconfigData { get; set; }
        public DbSet<FicConsultation> Ficconsultation { get; set; }
        public DbSet<FicConsultationClient> FicconsultationClient { get; set; }
        public DbSet<FicConsultationControl> FicconsultationControl { get; set; }
        public DbSet<FicConsultationFinal> FicconsultationFinal { get; set; }
        public DbSet<FicConsultationHedgeAccounting> FicconsultationHedgeAccounting { get; set; }
        public DbSet<FicConsultationOtherIssue> FicconsultationOtherIssue { get; set; }
        public DbSet<FicConsultationRequiredDocument> FicconsultationRequiredDocument { get; set; }
        public DbSet<FicConsultationReview> FicconsultationReview { get; set; }
        public DbSet<FicConsultationSummary> FicconsultationSummary { get; set; }
        public DbSet<FicGrid> Ficgrid { get; set; }
        public DbSet<FicGridHedge> FicgridHedge { get; set; }
        public DbSet<FicGridSummary> FicgridSummary { get; set; }
        public DbSet<FileReview> FileReview { get; set; }
        public DbSet<FinancialReportingStandard> FinancialReportingStandard { get; set; }
        public DbSet<FinancialReportingStandardConsultation> FinancialReportingStandardConsultation { get; set; }
        public DbSet<FinancialReportingStandardMemberFirm> FinancialReportingStandardMemberFirm { get; set; }
        public DbSet<HoldsOnRelease> HoldsOnRelease { get; set; }
        public DbSet<HotlineClosureSetting> HotlineClosureSetting { get; set; }
        public DbSet<IfrsCatApplicableMemberFirms> IfrscatApplicableMemberFirms { get; set; }
        public DbSet<IfrsCategory> Ifrscategory { get; set; }
        public DbSet<IfrsCategoryTmp> IfrscategoryTmp { get; set; }
        public DbSet<IfrsStandardAndTopic> IfrsstandardAndTopic { get; set; }
        public DbSet<IfrsSubCatApplicableMemberFirms> IfrssubCatApplicableMemberFirms { get; set; }
        public DbSet<IfrsSubCategory> IfrssubCategory { get; set; }
        public DbSet<IfrsSubCategoryTmp> IfrssubCategoryTmp { get; set; }
        public DbSet<MasterConsultationMemberFirms> MasterConsultationMemberFirms { get; set; }
        public DbSet<MasterRequiredConsultation> MasterRequiredConsultation { get; set; }
        public DbSet<MemberFirm> MemberFirm { get; set; }
        public DbSet<MemberFirmConsultationType> MemberFirmConsultationType { get; set; }
        public DbSet<MemberFirmDelinquentConfig> MemberFirmDelinquentconfig { get; set; }
        public DbSet<MenuSecurity> MenuSecurity { get; set; }
        public DbSet<NaaConsultation> Naaconsultation { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<OfflineEmail> OfflineEmail { get; set; }
        public DbSet<OfflineEmailFailure> OfflineEmailFailure { get; set; }
        public DbSet<Operation> Operation { get; set; }
        public DbSet<PeriodEndCorrectedLog> PeriodEndCorrectedLog { get; set; }
        public DbSet<PersonalRight> PersonalRight { get; set; }
        public DbSet<Priviledge> Priviledge { get; set; }
        public DbSet<PsrLocalIdExport150313> PsrLocalIdExport150313 { get; set; }
        public DbSet<PsrArmUpdateProcess> PsrarmupdateProcess { get; set; }
        public DbSet<PsrArmUpdateSsisJobProgress> PsrarmupdateSsisjobProgress { get; set; }
        public DbSet<PsrArmUpdateWsJobProgress> PsrarmupdateWsjobProgress { get; set; }
        public DbSet<PsrArmUpdates> Psrarmupdates { get; set; }
        public DbSet<PublicHolidays> PublicHolidays { get; set; }
        public DbSet<RelProfStandards> RelProfStandards { get; set; }
        public DbSet<RelProfStandardsMemberFirm> RelProfStandardsMemberFirm { get; set; }
        public DbSet<RelatedQueries> RelatedQueries { get; set; }
        public DbSet<RequiredConsultationTypes> RequiredConsultationTypess { get; set; }
        public DbSet<ReviewArmField> ReviewArmfield { get; set; }
        public DbSet<ReviewBase> ReviewBase { get; set; }
        public DbSet<ReviewBaseDocument> ReviewBaseDocument { get; set; }
        public DbSet<ReviewPoint> ReviewPoint { get; set; }
        public DbSet<ReviewPointComment> ReviewPointComment { get; set; }
        public DbSet<ReviewState> ReviewState { get; set; }
        public DbSet<ReviewUser> ReviewUser { get; set; }
        public DbSet<ReviewerType> ReviewerType { get; set; }
        public DbSet<ReviewerTypeDocumentReviewType> ReviewerTypeDocumentReviewType { get; set; }
        public DbSet<ReviewerTypeStatePriviledge> ReviewerTypeStatePriviledge { get; set; }
        public DbSet<SatelliteFirm> SatelliteFirm { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<SlowMovingRecipients> SlowMovingRecipients { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<SubjectMatter> SubjectMatter { get; set; }
        public DbSet<SubjectMatterMemberFirm> SubjectMatterMemberFirm { get; set; }
        public DbSet<SubsidiaryEntity> SubsidiaryEntity { get; set; }
        public DbSet<SystemRole> SystemRole { get; set; }
        public DbSet<SystemRoleStatePriviledge> SystemRoleStatePriviledge { get; set; }
        public DbSet<TempReviewBase> TempReviewBase { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserConsultationType> UserConsultationType { get; set; }
        public DbSet<UserDocumentType> UserDocumentType { get; set; }
        public DbSet<UserEmployeeData> UserEmployeeData { get; set; }
        public DbSet<UserFic> UserFic { get; set; }
        public DbSet<UserOffice> UserOffice { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserSpecialist> UserSpecialist { get; set; }
        public DbSet<UsersApplicableMemberFirms> UsersApplicableMemberFirms { get; set; }
        public DbSet<ValidEmailTestRecipient> ValidEmailTestRecipient { get; set; }
        public DbSet<ViewAccountDescription> ViewAccountDescription { get; set; }
        public DbSet<ViewAllConsultation> ViewAllConsultation { get; set; }
        public DbSet<ViewAuditReqConsul> ViewAuditReqConsul { get; set; }
        public DbSet<ViewAuditStandardText> ViewAuditStandardText { get; set; }
        public DbSet<ViewAuditTerritoryText> ViewAuditTerritoryText { get; set; }
        public DbSet<ViewBitStateText> ViewBitStateText { get; set; }
        public DbSet<ViewCceEngagementTypes> ViewCceengagementTypes { get; set; }
        public DbSet<ViewCemoReqReason> ViewCemoreqReason { get; set; }
        public DbSet<ViewComplexityText> ViewComplexityText { get; set; }
        public DbSet<ViewConsultationTypeMatch> ViewConsultationTypeMatch { get; set; }
        public DbSet<ViewCurrentReviewers> ViewCurrentReviewers { get; set; }
        public DbSet<ViewDaemsEngagementType> ViewDaemsengagementType { get; set; }
        public DbSet<ViewDaemsIndiv> ViewDaemsindiv { get; set; }
        public DbSet<ViewDocketsOnly> ViewDocketsOnly { get; set; }
        public DbSet<ViewEarOffshore> ViewEaroffshore { get; set; }
        public DbSet<ViewFileStatusText> ViewFileStatusText { get; set; }
        public DbSet<ViewFrsConsul> ViewFrsconsul { get; set; }
        public DbSet<ViewGroupCompanyText> ViewGroupCompanyText { get; set; }
        public DbSet<ViewIfrsData> ViewIfrsdata { get; set; }
        public DbSet<ViewPreviewConsultation> ViewPreviewConsultation { get; set; }
        public DbSet<ViewPreviewFolder> ViewPreviewFolder { get; set; }
        public DbSet<ViewPreviewFolderEntries> ViewPreviewFolderEntries { get; set; }
        public DbSet<ViewReviewState> ViewReviewState { get; set; }
        public DbSet<ViewReviewUser> ViewReviewUser { get; set; }
        public DbSet<ViewReviewerEtm> ViewReviewerEtm { get; set; }
        public DbSet<ViewReviewerMain> ViewReviewerMain { get; set; }
        public DbSet<ViewReviewerName> ViewReviewerName { get; set; }
        public DbSet<ViewReviewerSub> ViewReviewerSub { get; set; }
        public DbSet<ViewReviewerType> ViewReviewerType { get; set; }
        public DbSet<ViewRiskRating> ViewRiskRating { get; set; }
        public DbSet<ViewStateCategory> ViewStateCategory { get; set; }
        public DbSet<ViewStatePreview> ViewStatePreview { get; set; }
        public DbSet<ViewSystemRole> ViewSystemRole { get; set; }
        public DbSet<ViewUserAccess> ViewUserAccess { get; set; }
        public DbSet<ViewUserName> ViewUserName { get; set; }
        public DbSet<ViewUserRole> ViewUserRole { get; set; }
        public DbSet<ViewUserTimed> ViewUserTimed { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountingConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new AccountingFrameworkConfiguration());

            modelBuilder.ApplyConfiguration(new AqrmConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new ArchiveDdextHistoryConfiguration());

            modelBuilder.ApplyConfiguration(new ArchivedHistoryConfiguration());

            modelBuilder.ApplyConfiguration(new ArmFieldConfiguration());

            modelBuilder.ApplyConfiguration(new ArmHistoryConfiguration());

            modelBuilder.ApplyConfiguration(new AuditConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new AuditLogConfiguration());

            modelBuilder.ApplyConfiguration(new AuditRequiredConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new CceConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new CemoApplicableMemberFirmsConfiguration());

            modelBuilder.ApplyConfiguration(new CemoConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new CemoConsultationRequestReasonConfiguration());

            modelBuilder.ApplyConfiguration(new CemoRequestReasonConfiguration());

            modelBuilder.ApplyConfiguration(new CgovConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new CodeConfiguration());

            modelBuilder.ApplyConfiguration(new CodeColumnConstraintConfiguration());

            modelBuilder.ApplyConfiguration(new CodeDataConfiguration());

            modelBuilder.ApplyConfiguration(new ConsultationDocumentConfiguration());

            modelBuilder.ApplyConfiguration(new ConsultationReviewPointConfiguration());

            modelBuilder.ApplyConfiguration(new CoreDataEmployeeConfiguration());

            modelBuilder.ApplyConfiguration(new CoreDataOrganisationOperatingUnitConfiguration());

            modelBuilder.ApplyConfiguration(new CoreDataWbs3NumberConfiguration());

            modelBuilder.ApplyConfiguration(new CorpReportingSubjectMatterConfiguration());

            modelBuilder.ApplyConfiguration(new CorpReportingSubjectMatterMemberFirmConfiguration());

            modelBuilder.ApplyConfiguration(new CstConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new DaemsApplicableMemberFirmsConfiguration());

            modelBuilder.ApplyConfiguration(new DaemsConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new DaemsConsultationIndividualConfiguration());

            modelBuilder.ApplyConfiguration(new DaemsTypeOfConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new DaemsVersionConfiguration());

            modelBuilder.ApplyConfiguration(new DelinquentConfigurationsConfiguration());

            modelBuilder.ApplyConfiguration(new DelinquentConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new DelinquentHistoryConfiguration());

            modelBuilder.ApplyConfiguration(new DelinquentRecipientsConfiguration());

            modelBuilder.ApplyConfiguration(new DocumentConfiguration());

            modelBuilder.ApplyConfiguration(new DocumentDataConfiguration());

            modelBuilder.ApplyConfiguration(new DocumentReviewConfiguration());

            modelBuilder.ApplyConfiguration(new DocumentReviewTypeConfiguration());

            modelBuilder.ApplyConfiguration(new DocumentReviewTypeCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new DuplicateReviewsConfiguration());

            modelBuilder.ApplyConfiguration(new EarApplicableMemberFirmsConfiguration());

            modelBuilder.ApplyConfiguration(new EarConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new EarConsultationOffshoreEntityConfiguration());

            modelBuilder.ApplyConfiguration(new EarReasonConfiguration());

            modelBuilder.ApplyConfiguration(new EmailConfiguration());

            modelBuilder.ApplyConfiguration(new EmailAttachmentConfiguration());

            modelBuilder.ApplyConfiguration(new EmailLogConfiguration());

            modelBuilder.ApplyConfiguration(new EmailNotificationConfiguration());

            modelBuilder.ApplyConfiguration(new EmailRecipientConfiguration());

            modelBuilder.ApplyConfiguration(new EmailRecipientRoleConfiguration());

            modelBuilder.ApplyConfiguration(new EmailTemplateTypeConfiguration());

            modelBuilder.ApplyConfiguration(new EngagementTypeConfiguration());

            modelBuilder.ApplyConfiguration(new EngagementTypeMemberFirmConfiguration());

            modelBuilder.ApplyConfiguration(new ExtensionMimeMapConfiguration());

            modelBuilder.ApplyConfiguration(new FicConfigDataConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationClientConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationControlConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationFinalConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationHedgeAccountingConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationOtherIssueConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationRequiredDocumentConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationReviewConfiguration());

            modelBuilder.ApplyConfiguration(new FicConsultationSummaryConfiguration());

            modelBuilder.ApplyConfiguration(new FicGridConfiguration());

            modelBuilder.ApplyConfiguration(new FicGridHedgeConfiguration());

            modelBuilder.ApplyConfiguration(new FicGridSummaryConfiguration());

            modelBuilder.ApplyConfiguration(new FileReviewConfiguration());

            modelBuilder.ApplyConfiguration(new FinancialReportingStandardConfiguration());

            modelBuilder.ApplyConfiguration(new FinancialReportingStandardConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new FinancialReportingStandardMemberFirmConfiguration());

            modelBuilder.ApplyConfiguration(new HoldsOnReleaseConfiguration());

            modelBuilder.ApplyConfiguration(new HotlineClosureSettingConfiguration());

            modelBuilder.ApplyConfiguration(new IfrsCatApplicableMemberFirmsConfiguration());

            modelBuilder.ApplyConfiguration(new IfrsCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new IfrsCategoryTmpConfiguration());

            modelBuilder.ApplyConfiguration(new IfrsStandardAndTopicConfiguration());

            modelBuilder.ApplyConfiguration(new IfrsSubCatApplicableMemberFirmsConfiguration());

            modelBuilder.ApplyConfiguration(new IfrsSubCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new IfrsSubCategoryTmpConfiguration());

            modelBuilder.ApplyConfiguration(new MasterConsultationMemberFirmsConfiguration());

            modelBuilder.ApplyConfiguration(new MasterRequiredConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new MemberFirmConfiguration());

            modelBuilder.ApplyConfiguration(new MemberFirmConsultationTypeConfiguration());

            modelBuilder.ApplyConfiguration(new MemberFirmDelinquentConfigConfiguration());

            modelBuilder.ApplyConfiguration(new MenuSecurityConfiguration());

            modelBuilder.ApplyConfiguration(new NaaConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new OfficeConfiguration());

            modelBuilder.ApplyConfiguration(new OfflineEmailConfiguration());

            modelBuilder.ApplyConfiguration(new OfflineEmailFailureConfiguration());

            modelBuilder.ApplyConfiguration(new OperationConfiguration());

            modelBuilder.ApplyConfiguration(new PeriodEndCorrectedLogConfiguration());

            modelBuilder.ApplyConfiguration(new PersonalRightConfiguration());

            modelBuilder.ApplyConfiguration(new PriviledgeConfiguration());

            modelBuilder.ApplyConfiguration(new PsrLocalIdExport150313Configuration());

            modelBuilder.ApplyConfiguration(new PsrArmUpdateProcessConfiguration());

            modelBuilder.ApplyConfiguration(new PsrArmUpdateSsisJobProgressConfiguration());

            modelBuilder.ApplyConfiguration(new PsrArmUpdateWsJobProgressConfiguration());

            modelBuilder.ApplyConfiguration(new PsrArmUpdatesConfiguration());

            modelBuilder.ApplyConfiguration(new PublicHolidaysConfiguration());

            modelBuilder.ApplyConfiguration(new RelProfStandardsConfiguration());

            modelBuilder.ApplyConfiguration(new RelProfStandardsMemberFirmConfiguration());

            modelBuilder.ApplyConfiguration(new RelatedQueriesConfiguration());

            modelBuilder.ApplyConfiguration(new RequiredConsultationTypesConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewArmFieldConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewBaseConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewBaseDocumentConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewPointConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewPointCommentConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewStateConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewUserConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewerTypeConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewerTypeDocumentReviewTypeConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewerTypeStatePriviledgeConfiguration());

            modelBuilder.ApplyConfiguration(new SatelliteFirmConfiguration());

            modelBuilder.ApplyConfiguration(new SettingsConfiguration());

            modelBuilder.ApplyConfiguration(new SlowMovingRecipientsConfiguration());

            modelBuilder.ApplyConfiguration(new StateConfiguration());

            modelBuilder.ApplyConfiguration(new SubjectMatterConfiguration());

            modelBuilder.ApplyConfiguration(new SubjectMatterMemberFirmConfiguration());

            modelBuilder.ApplyConfiguration(new SubsidiaryEntityConfiguration());

            modelBuilder.ApplyConfiguration(new SystemRoleConfiguration());

            modelBuilder.ApplyConfiguration(new SystemRoleStatePriviledgeConfiguration());

            modelBuilder.ApplyConfiguration(new TempReviewBaseConfiguration());

            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.ApplyConfiguration(new UserConsultationTypeConfiguration());

            modelBuilder.ApplyConfiguration(new UserDocumentTypeConfiguration());

            modelBuilder.ApplyConfiguration(new UserEmployeeDataConfiguration());

            modelBuilder.ApplyConfiguration(new UserFicConfiguration());

            modelBuilder.ApplyConfiguration(new UserOfficeConfiguration());

            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

            modelBuilder.ApplyConfiguration(new UserSpecialistConfiguration());

            modelBuilder.ApplyConfiguration(new UsersApplicableMemberFirmsConfiguration());

            modelBuilder.ApplyConfiguration(new ValidEmailTestRecipientConfiguration());

            modelBuilder.ApplyConfiguration(new ViewAccountDescriptionConfiguration());

            modelBuilder.ApplyConfiguration(new ViewAllConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new ViewAuditReqConsulConfiguration());

            modelBuilder.ApplyConfiguration(new ViewAuditStandardTextConfiguration());

            modelBuilder.ApplyConfiguration(new ViewAuditTerritoryTextConfiguration());

            modelBuilder.ApplyConfiguration(new ViewBitStateTextConfiguration());

            modelBuilder.ApplyConfiguration(new ViewCceEngagementTypesConfiguration());

            modelBuilder.ApplyConfiguration(new ViewCemoReqReasonConfiguration());

            modelBuilder.ApplyConfiguration(new ViewComplexityTextConfiguration());

            modelBuilder.ApplyConfiguration(new ViewConsultationTypeMatchConfiguration());

            modelBuilder.ApplyConfiguration(new ViewCurrentReviewersConfiguration());

            modelBuilder.ApplyConfiguration(new ViewDaemsEngagementTypeConfiguration());

            modelBuilder.ApplyConfiguration(new ViewDaemsIndivConfiguration());

            modelBuilder.ApplyConfiguration(new ViewDocketsOnlyConfiguration());

            modelBuilder.ApplyConfiguration(new ViewEarOffshoreConfiguration());

            modelBuilder.ApplyConfiguration(new ViewFileStatusTextConfiguration());

            modelBuilder.ApplyConfiguration(new ViewFrsConsulConfiguration());

            modelBuilder.ApplyConfiguration(new ViewGroupCompanyTextConfiguration());

            modelBuilder.ApplyConfiguration(new ViewIfrsDataConfiguration());

            modelBuilder.ApplyConfiguration(new ViewPreviewConsultationConfiguration());

            modelBuilder.ApplyConfiguration(new ViewPreviewFolderConfiguration());

            modelBuilder.ApplyConfiguration(new ViewPreviewFolderEntriesConfiguration());

            modelBuilder.ApplyConfiguration(new ViewReviewStateConfiguration());

            modelBuilder.ApplyConfiguration(new ViewReviewUserConfiguration());

            modelBuilder.ApplyConfiguration(new ViewReviewerEtmConfiguration());

            modelBuilder.ApplyConfiguration(new ViewReviewerMainConfiguration());

            modelBuilder.ApplyConfiguration(new ViewReviewerNameConfiguration());

            modelBuilder.ApplyConfiguration(new ViewReviewerSubConfiguration());

            modelBuilder.ApplyConfiguration(new ViewReviewerTypeConfiguration());

            modelBuilder.ApplyConfiguration(new ViewRiskRatingConfiguration());

            modelBuilder.ApplyConfiguration(new ViewStateCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new ViewStatePreviewConfiguration());

            modelBuilder.ApplyConfiguration(new ViewSystemRoleConfiguration());

            modelBuilder.ApplyConfiguration(new ViewUserAccessConfiguration());

            modelBuilder.ApplyConfiguration(new ViewUserNameConfiguration());

            modelBuilder.ApplyConfiguration(new ViewUserRoleConfiguration());

            modelBuilder.ApplyConfiguration(new ViewUserTimedConfiguration());
        }
    }
}
