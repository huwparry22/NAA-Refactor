using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class PsrArmUpdates
    {
        public Guid UniqueIdentifier { get; set; }
        public int PsrlogNo { get; set; }
        public string ArmentityId { get; set; }
        public DateTime? FinancialYearEnd { get; set; }
        public string CurrentState { get; set; }
        public DateTime StateChangedDateTime { get; set; }
        public DateTime? PreferredReviewDate { get; set; }
        public string DocumentReviewTypeCategory { get; set; }
        public string DocumentReviewType { get; set; }
        public DateTime? SentToArm { get; set; }
        public DateTime? ProcessedInArm { get; set; }
        public string Status { get; set; }
        public string ReasonForFailure { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
