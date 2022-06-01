using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class TempReviewBase
    {
        public int ReviewBaseId { get; set; }
        public string Dunsnumber { get; set; }
        public string ArmentityId { get; set; }
        public string EntityName { get; set; }
        public string Uhcdunsnumber { get; set; }
        public string Uhcname { get; set; }
        public DateTime? FinancialYearEnd { get; set; }
        public int? OverallCurrentRisk { get; set; }
        public bool? IsSecregistrant { get; set; }
        public bool? IsRelatedToSecregistrant { get; set; }
        public bool? IsPublicInterestEntity { get; set; }
        public decimal? AuditFees { get; set; }
        public DateTime? EngAcceptanceDate { get; set; }
        public string WfemailLog { get; set; }
        public int? OwningOfficeId { get; set; }
        public int? ReviewOfficeId { get; set; }
        public byte[] ReviewBaseRowVersion { get; set; }
        public DateTime? DateReviewRequiredBy { get; set; }
        public string Wbs3number { get; set; }
        public string Sector { get; set; }
        public DateTime? ReviewPreferredDate { get; set; }
        public short? TimeRequiredInHours { get; set; }
        public DateTime? ReportingDate { get; set; }
        public DateTime? ReviewConfirmedDate { get; set; }
        public string OtherReviewInformation { get; set; }
        public string MarketListings { get; set; }
        public bool? FirstYearAudit { get; set; }
        public bool? LastYearAudit { get; set; }
        public string ClientsBusiness { get; set; }
        public string OtherInformation { get; set; }
        public int? PreferredReviewerUserId { get; set; }
        public bool AwaitingClearance { get; set; }
        public int CurrentStateId { get; set; }
        public DateTime StateChangedDate { get; set; }
        public int StateChangedByUserId { get; set; }
        public string OtherKeyDates { get; set; }
        public string PreferredReviewerReason { get; set; }
        public string WithdrawalReason { get; set; }
        public string RejectionReason { get; set; }
        public int? ChaserEmail { get; set; }
        public string ClearanceReason { get; set; }
        public DateTime? ClearanceDate { get; set; }
        public DateTime? InitialAuditReportDate { get; set; }
        public DateTime? InitialAuditReportYear { get; set; }
        public DateTime? InitialAcceptanceDate { get; set; }
        public string TypeOfAuditAssuranceOpinion { get; set; }
        public string ReasonForQualification { get; set; }
        public string PreviousReviewer { get; set; }
        public bool? CreatedUsingMultipleDr { get; set; }
        public int? ReviewLanguageId { get; set; }
        public int? Gaapid { get; set; }
        public string OwningDttlmemberFirm { get; set; }
        public bool? Emsengagement { get; set; }
        public int VersionNumber { get; set; }
        public bool? RequiredUsgaapknowledge { get; set; }
        public int? Secrelationship { get; set; }
        public DateTime? PsrfileAssemblyDate { get; set; }
        public string LocalBusinessId { get; set; }
        public string CountryOfIncorporation { get; set; }
        public string ClientType { get; set; }
        public string AssuranceType { get; set; }
    }
}
