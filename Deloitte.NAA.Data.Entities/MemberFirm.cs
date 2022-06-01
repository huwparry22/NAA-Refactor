using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class MemberFirm
    {
        public MemberFirm()
        {
            CemoapplicableMemberFirms = new HashSet<CemoApplicableMemberFirms>();
            CorpReportingSubjectMatterMemberFirm = new HashSet<CorpReportingSubjectMatterMemberFirm>();
            DaemsapplicableMemberFirms = new HashSet<DaemsApplicableMemberFirms>();
            DelinquentConfigurations = new HashSet<DelinquentConfigurations>();
            EarapplicableMemberFirms = new HashSet<EarApplicableMemberFirms>();
            EngagementTypeMemberFirm = new HashSet<EngagementTypeMemberFirm>();
            FinancialReportingStandardMemberFirm = new HashSet<FinancialReportingStandardMemberFirm>();
            HotlineClosureSetting = new HashSet<HotlineClosureSetting>();
            IfrscatApplicableMemberFirms = new HashSet<IfrsCatApplicableMemberFirms>();
            IfrssubCatApplicableMemberFirms = new HashSet<IfrsSubCatApplicableMemberFirms>();
            MasterConsultationMemberFirms = new HashSet<MasterConsultationMemberFirms>();
            MemberFirmConsultationType = new HashSet<MemberFirmConsultationType>();
            MemberFirmDelinquentconfig = new HashSet<MemberFirmDelinquentConfig>();
            Office = new HashSet<Office>();
            RelProfStandardsMemberFirm = new HashSet<RelProfStandardsMemberFirm>();
            ReviewBase = new HashSet<ReviewBase>();
            SatelliteFirm = new HashSet<SatelliteFirm>();
            SubjectMatterMemberFirm = new HashSet<SubjectMatterMemberFirm>();
            UserConsultationType = new HashSet<UserConsultationType>();
            UserRole = new HashSet<UserRole>();
            UsersApplicableMemberFirms = new HashSet<UsersApplicableMemberFirms>();
        }

        public int Id { get; set; }
        public string FirmName { get; set; }
        public string FirmCode { get; set; }
        public bool Active { get; set; }
        public string ErrorMessage { get; set; }
        public string DisplayFirmCode { get; set; }
        public bool ArmSupport { get; set; }

        public virtual ICollection<CemoApplicableMemberFirms> CemoapplicableMemberFirms { get; set; }
        public virtual ICollection<CorpReportingSubjectMatterMemberFirm> CorpReportingSubjectMatterMemberFirm { get; set; }
        public virtual ICollection<DaemsApplicableMemberFirms> DaemsapplicableMemberFirms { get; set; }
        public virtual ICollection<DelinquentConfigurations> DelinquentConfigurations { get; set; }
        public virtual ICollection<EarApplicableMemberFirms> EarapplicableMemberFirms { get; set; }
        public virtual ICollection<EngagementTypeMemberFirm> EngagementTypeMemberFirm { get; set; }
        public virtual ICollection<FinancialReportingStandardMemberFirm> FinancialReportingStandardMemberFirm { get; set; }
        public virtual ICollection<HotlineClosureSetting> HotlineClosureSetting { get; set; }
        public virtual ICollection<IfrsCatApplicableMemberFirms> IfrscatApplicableMemberFirms { get; set; }
        public virtual ICollection<IfrsSubCatApplicableMemberFirms> IfrssubCatApplicableMemberFirms { get; set; }
        public virtual ICollection<MasterConsultationMemberFirms> MasterConsultationMemberFirms { get; set; }
        public virtual ICollection<MemberFirmConsultationType> MemberFirmConsultationType { get; set; }
        public virtual ICollection<MemberFirmDelinquentConfig> MemberFirmDelinquentconfig { get; set; }
        public virtual ICollection<Office> Office { get; set; }
        public virtual ICollection<RelProfStandardsMemberFirm> RelProfStandardsMemberFirm { get; set; }
        public virtual ICollection<ReviewBase> ReviewBase { get; set; }
        public virtual ICollection<SatelliteFirm> SatelliteFirm { get; set; }
        public virtual ICollection<SubjectMatterMemberFirm> SubjectMatterMemberFirm { get; set; }
        public virtual ICollection<UserConsultationType> UserConsultationType { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<UsersApplicableMemberFirms> UsersApplicableMemberFirms { get; set; }
    }
}
